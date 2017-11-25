using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SaveBackup
{
    /// <summary>
    /// Usage: Each time Backup() is called, a new subdir will be created in OutputPath/, 
    /// which will contain a copy of the files found in InputPath; if TargetFileNames is 
    /// specified, only those files will be copied.
    /// </summary>
    class SaveBackuper
    {
        static public readonly string DateTimeFormat = "dd-MM-yyyy_HH-mm-ss-ff";

        public string InputPath { get; set; }
        public HashSet<string> TargetFileNames { get; set; }
        public string OutputPath { get; set; }
        /// <summary>
        /// Adds a (user-friendly) postfix to the backup directory names.
        /// </summary>
        public string BackupDirPostfix { get; set; }
        public int MaxBackupCount { get; set; }

        public SaveBackuper()
        {
            InputPath = "";
            TargetFileNames = new HashSet<string>();
            OutputPath = "";
            BackupDirPostfix = "";
            MaxBackupCount = 0;
        }

        public bool DeleteBackups()
        {
            if (!Directory.Exists(OutputPath))
                return false;

            try
            {
                Directory.Delete(OutputPath, true);
                Directory.CreateDirectory(OutputPath);
                lastBackupFolderName = "";
                lastInputModifiedTime = DateTime.MinValue;
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool Backup()
        {
            // check state
            if (InputPath.Length == 0)
                return false;
            if (OutputPath.Length == 0)
                return false;

            // check directories
            if (!Directory.Exists(InputPath))
                return false;
            try
            {
                Directory.CreateDirectory(OutputPath);
            }
            catch(Exception e)
            {
                return false;
            }

            string[] inputFilePaths = Directory.GetFiles(InputPath);
            // isolate file names
            HashSet<string>  inputList = new HashSet<string>(inputFilePaths.Select(path => Path.GetFileName(path)));
            if(TargetFileNames.Count > 0)
                inputList.IntersectWith(TargetFileNames);

            if (inputList.Count == 0)
                return false;

            // if we already copied the latest version of the file, skip backing up
            DateTime newLastWriteTime = File.GetLastWriteTime(Path.Combine(InputPath, inputList.First()));
            if (newLastWriteTime.Equals(lastInputModifiedTime))
                return true;

            // compute paths
            string backupFolderName = string.Format("{0}{1}", DateTime.Now.ToString(DateTimeFormat), BackupDirPostfix);
            string finalOutputPath = Path.Combine(OutputPath, backupFolderName);

            // delete last if necessary
            if (MaxBackupCount > 0)
            {
                BackupInfo backupInfo = getCurrentBackupInfo();
                if (backupInfo.count >= MaxBackupCount)
                {
                    try
                    {
                        Directory.Delete(Path.Combine(OutputPath, backupInfo.oldestBackupDirName), true);
                    }
                    catch
                    { }
                }
            }

            // make new backup folder
            try
            {
                Directory.CreateDirectory(finalOutputPath);
            }
            catch (Exception e)
            {
                return false;
            }

            // copy
            bool successful = true;
            foreach(string inputFile in inputList)
            {
                try
                {
                    File.Copy(Path.Combine(InputPath, inputFile), Path.Combine(finalOutputPath, inputFile), true);
                }
                catch
                {
                    successful = false;
                }
            }

            if(successful)
                lastInputModifiedTime = newLastWriteTime;
            lastBackupFolderName = backupFolderName;

            return successful;
        }

        private struct BackupInfo
        {
            public int count;
            public string oldestBackupDirName;
        }

        /// <summary>
        /// Prerequisites: input directory has been checked and exists
        /// </summary>
        private BackupInfo getCurrentBackupInfo()
        {
            BackupInfo result;
            result.count = 0;
            result.oldestBackupDirName = "";
            DateTime oldestTimestamp = DateTime.Now;

            foreach (string dirPath in Directory.GetDirectories(OutputPath))
            {
                string dirName = Path.GetFileName(dirPath.TrimEnd(Path.DirectorySeparatorChar));
                if (!dirName.EndsWith(BackupDirPostfix))
                    continue;

                try
                {
                    DateTime.ParseExact(dirName.Substring(0, dirName.Length - BackupDirPostfix.Length), DateTimeFormat, System.Globalization.CultureInfo.InvariantCulture);
                }
                catch
                {
                    continue;
                }

                DateTime lastWriteTime = Directory.GetLastWriteTime(dirPath);
                if (lastWriteTime < oldestTimestamp)
                {
                    oldestTimestamp = lastWriteTime;
                    result.oldestBackupDirName = dirName;
                }
                result.count++;
            }

            return result;
        }

        private string lastBackupFolderName;
        private DateTime lastInputModifiedTime;
    }
}
