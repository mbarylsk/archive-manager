using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Collections;
using System.Data.SQLite;

namespace ArchiveManager
{
    public partial class Form_archmgr : Form
    {
        /// <summary>
        /// Gets MD5 sum of the file contents
        /// </summary>
        /// <param name="fileName">filename</param>
        /// <returns>MD5 sum of filename contents</returns>
        private static string GetMD5HashFromFile(string fileName)
        {
            try
            {
                FileStream file = new FileStream(fileName, FileMode.Open);
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch
            {
                return String.Empty;
            }
        }
        
        /// <summary>
        /// Gets MD5 sum for file from archive
        /// </summary>
        /// <param name="entry">entry in archive</param>
        /// <returns>MD5 sum from archive entry</returns>
        private static string GetMD5HashFromArchive(string entry)
        {
            String[] entries = entry.Split(ARCHIVE_SEPARATOR.ToArray());
            return entries[3];
        }

        /// <summary>
        /// Checks if list contains data from archives only
        /// </summary>
        /// <param name="list">list</param>
        /// <returns>true if data from archive only; otherwise false</returns>
        private static bool CheckIfListFromArchiveOnly(List<String> list)
        {
            bool result = true;
            foreach (String s in list)
            {
                if (!s.StartsWith(ARCHIVE_MARKER))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// Gets UX timestamp
        /// </summary>
        /// <returns>Number of seconds from UX epoch</returns>
        private static long GetTimestamp()
        {
            long ticks = DateTime.UtcNow.Ticks - DateTime.Parse("01/01/1970 00:00:00").Ticks;
            ticks /= 10000000;
            return ticks;
        }

        /// <summary>
        /// Returns filesize in bytes
        /// </summary>
        /// <param name="fileName">path to the file</param>
        /// <returns>filesize as a string</returns>
        private static string GetFileSize(string fileName)
        {
            FileInfo fi = new FileInfo(fileName);
            return (fi.Length.ToString() + "B");
        }

        /// <summary>
        /// Returns shortened string if required
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="maxLength">Maximum length</param>
        /// <returns>Shortened string if length more than maximum length; otherwise original string</returns>
        public static String StringShortenIfNeeded(String input, int maxLength)
        {
            String dots = "...";
            if (input.Length > maxLength)
            {
                return (input.Substring(0, maxLength - 2*dots.Length) + dots + input.Substring(input.Length - dots.Length, dots.Length));
            }
            else
            {
                return input;
            }
        }

        /// <summary>
        /// Setups new SQLLite database
        /// </summary>
        /// <param name="dbName">DB name</param>
        /// <returns>connection to DB</returns>
        public static SQLiteConnection SQLSetupDB (String dbName)
        {            
            SQLiteConnection.CreateFile(SQLLITE_DB_NAME);
            return (new SQLiteConnection("Data Source=" + dbName + ";Version=3;"));
        }

        /// <summary>
        /// Setups SQLLite tables
        /// </summary>
        /// <param name="dbConnection">connection to DB</param>
        public static void SQLSetupTables (SQLiteConnection dbConnection)
        {
            String sql = "CREATE TABLE archives (archivename VARCHAR(60), md5sum CHAR(32))";
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Adds archive to SQLLite
        /// </summary>
        /// <param name="dbConnection">connection to DB</param>
        /// <param name="filename">name of the archive</param>
        /// <param name="md5Sum">MD5 sum</param>
        public static void SQLAddArchive(SQLiteConnection dbConnection, String filename, String md5Sum)
        {
            string sql = "INSERT INTO archives (archivename, md5sum) values ('" + filename + "', " + md5Sum + ")";
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection); 
            command.ExecuteNonQuery();
        }
    }
}