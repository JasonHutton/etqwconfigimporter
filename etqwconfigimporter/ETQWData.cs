using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Win32;
using System.IO;

namespace configimporter
{
    public enum ETQWPath
    {
        GAMEPATH = 0,
        SAVEPATH,
        USERPATH
    };

    public class PathContents
    {
        private string fullPath;
        private string filename;

        public PathContents(string fullPath)
        {
            this.FullPath = fullPath;
            this.Filename = fullPath.Substring(fullPath.LastIndexOf(System.IO.Path.DirectorySeparatorChar) + 1);
        }

        public string FullPath
        {
            get { return fullPath; }
            set { fullPath = value; }
        }

        public string Filename
        {
            get { return filename; }
            set { filename = value; }
        }

        public override string ToString()
        {
            return Filename;
        }
    }

    public class ETQWData
    {
        private string gamePath;
        private string savePath;
        private string userPath;

        public ETQWData()
        {
            DetectPaths();
        }

        public void DetectPaths()
        {
            try
            {
                RegistryKey rkLM = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Id\\ET - QUAKE Wars");
                gamePath = rkLM.GetValue("InstallPath").ToString();
                rkLM.Close();
            }
            catch (Exception)
            {
                gamePath = "C:\\Program Files\\id Software\\Enemy Territory - QUAKE Wars";
            }

            savePath = Environment.GetEnvironmentVariable("localappdata");
            if (savePath == null)
            {
                savePath = Environment.GetEnvironmentVariable("userprofile")
                    + "\\Local Settings\\Application Data";
            }
            savePath += "\\id Software\\Enemy Territory - QUAKE Wars";

            userPath = Environment.GetEnvironmentVariable("userprofile")
                + "\\My Documents\\id Software\\Enemy Territory - QUAKE Wars";
        }

        public List<PathContents> getPathData(ETQWPath path, string modPath, string searchPattern)
        {
            List<string> strResults = new List<string>();

            //if (modPath == null || modPath.Equals(""))
            if (searchPattern == null || searchPattern.Equals(""))
            {
                if (modPath == null || modPath.Equals(""))
                {
                    try
                    {
                        switch (path)
                        {
                            case ETQWPath.GAMEPATH:
                                strResults = Directory.GetDirectories(gamePath).ToList<string>();
                                break;
                            case ETQWPath.SAVEPATH:
                                strResults = Directory.GetDirectories(savePath).ToList<string>();
                                break;
                            case ETQWPath.USERPATH:
                                strResults = Directory.GetDirectories(userPath).ToList<string>();
                                break;
                            default:
                                break;
                        }
                    }
                    catch (DirectoryNotFoundException) { /* Fail silently. */ }
                }
                else
                {
                    if (modPath == null || modPath.Equals(""))
                    {
                        try
                        {
                            switch (path)
                            {
                                case ETQWPath.GAMEPATH:
                                    strResults = Directory.GetDirectories(gamePath).ToList<string>();
                                    break;
                                case ETQWPath.SAVEPATH:
                                    strResults = Directory.GetDirectories(savePath).ToList<string>();
                                    break;
                                case ETQWPath.USERPATH:
                                    strResults = Directory.GetDirectories(userPath).ToList<string>();
                                    break;
                                default:
                                    break;
                            }
                        }
                        catch (DirectoryNotFoundException) { /* Fail silently. */ }
                    }
                    else
                    {
                        try
                        {
                            switch (path)
                            {
                                case ETQWPath.GAMEPATH:
                                    strResults = Directory.GetDirectories(gamePath + System.IO.Path.DirectorySeparatorChar + modPath).ToList<string>();
                                    break;
                                case ETQWPath.SAVEPATH:
                                    strResults = Directory.GetDirectories(savePath + System.IO.Path.DirectorySeparatorChar + modPath).ToList<string>();
                                    break;
                                case ETQWPath.USERPATH:
                                    strResults = Directory.GetDirectories(userPath + System.IO.Path.DirectorySeparatorChar + modPath).ToList<string>();
                                    break;
                                default:
                                    break;
                            }
                        }
                        catch (DirectoryNotFoundException) { /* Fail silently. */ }
                    }
                }
            }
            else
            {
                try
                {
                    switch (path)
                    {
                        case ETQWPath.GAMEPATH:
                            strResults = Directory.GetFiles(gamePath + System.IO.Path.DirectorySeparatorChar + modPath, searchPattern).ToList<string>();
                            break;
                        case ETQWPath.SAVEPATH:
                            strResults = Directory.GetFiles(savePath + System.IO.Path.DirectorySeparatorChar + modPath, searchPattern).ToList<string>();
                            break;
                        case ETQWPath.USERPATH:
                            strResults = Directory.GetFiles(userPath + System.IO.Path.DirectorySeparatorChar + modPath, searchPattern).ToList<string>();
                            break;
                        default:
                            break;
                    }
                }
                catch (DirectoryNotFoundException) { /* Fail silently. */ }
            }

            List<PathContents> pcResults = new List<PathContents>();
            foreach (string result in strResults)
            {
                pcResults.Add(new PathContents(result));
            }

            return pcResults;
        }

        public string GamePath
        {
            get { return gamePath; }
            set { gamePath = value; }
        }

        public string UserPath
        {
            get { return userPath; }
            set { userPath = value; }
        }

        public string SavePath
        {
            get { return savePath; }
            set { savePath = value; }
        }
    }
}
