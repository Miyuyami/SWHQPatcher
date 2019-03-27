﻿/*
 * This file is part of Soulworker Patcher.
 * Copyright (C) 2016-2017 Miyu, Dramiel Leayal
 * 
 * Soulworker Patcher is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * Soulworker Patcher is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with Soulworker Patcher. If not, see <http://www.gnu.org/licenses/>.
 */

using MadMilkman.Ini;
using SWPatcher.Helpers;
using SWPatcher.Helpers.GlobalVariables;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;

namespace SWPatcher.General
{
    internal static class SWFileManager
    {
        private static List<SWFile> SWFiles;
        internal static int Count => SWFiles.Count;
        internal static SWFile GetElementAt(int index) => SWFiles[index];
        internal static ReadOnlyCollection<SWFile> GetFiles() => SWFiles.AsReadOnly();

        internal static void LoadFileConfiguration(Language language)
        {
            if (SWFiles == null)
            {
                string packPath = Urls.TranslationGitHubHome + language.Path + '/' + Strings.IniName.TranslationPackData;
                Logger.Debug(Methods.MethodFullName(System.Reflection.MethodBase.GetCurrentMethod(), packPath));
                InternalLoadFileConfiguration(packPath);
            }
        }

        private static void InternalLoadFileConfiguration(string url)
        {
            SWFiles = new List<SWFile>();

            byte[] packData;
            using (WebClient client = new WebClient())
            {
                packData = client.DownloadData(url);
            }

            IniFile ini = new IniFile();
            using (MemoryStream stream = new MemoryStream(packData))
            {
                ini.Load(stream);
            }

            foreach (IniSection section in ini.Sections)
            {
                string name = section.Name;
                string path = section.Keys[Strings.IniName.Pack.KeyPath].Value;
                string pathA = section.Keys[Strings.IniName.Pack.KeyPathInArchive].Value;
                string pathD = section.Keys[Strings.IniName.Pack.KeyPathOfDownload].Value;
                string format = section.Keys[Strings.IniName.Pack.KeyFormat].Value;

                if (format != String.Empty)
                {
                    SWFiles.Add(new PatchedSWFile(name, path, pathD, pathA, format));
                }
                else if (pathA != String.Empty)
                {
                    if (pathA == Strings.IniName.Pack.KeyBaseValue)
                    {
                        pathA = String.Empty;
                    }

                    SWFiles.Add(new ArchivedSWFile(name, path, pathD, pathA));
                }
                else
                {
                    SWFiles.Add(new SWFile(name, path, pathD));
                }
            }
        }

        internal static void DisposeFileData()
        {
            IEnumerable<ArchivedSWFile> archivedSWFiles = SWFiles.OfType<ArchivedSWFile>();

            foreach (ArchivedSWFile archivedSWFile in archivedSWFiles)
            {
                archivedSWFile.Data = null;
            }
        }
    }
}
