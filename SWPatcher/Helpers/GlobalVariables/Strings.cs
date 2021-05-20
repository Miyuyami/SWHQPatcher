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


namespace SWPatcher.Helpers.GlobalVariables
{
    internal sealed class Strings
    {
        internal sealed class PasteBin
        {
            internal const string DevKey = "2e5bee04f7455774443dd399934494bd";
            internal const string Username = "SWPatcher";
            internal const string Password = "pIIrwSL8lNJOjPhW";
        }

        internal sealed class FileName
        {
            internal const string GameExeJP = "SoulWorker100.exe";
            internal const string GameExeKR = "SoulWorker.exe";
            internal const string GameExeGL = "SoulWorker.exe";
            internal const string PurpleExe = "PLauncher.exe";
            internal const string ReactorExe = "reactor.exe";
            internal const string OutboundExe = "Outbound.exe";
            internal const string OptionExe = "Option.exe";
            internal const string SecurityExe = "DirectoryRights.exe";
            internal const string Log = ".log";
            internal const string Data12 = "data12.v";
            //public const string Data14 = "data14.v";
        }

        internal sealed class FolderName
        {
            internal const string Data = "datas";
            internal const string Backup = "backup";
            internal const string RTPatchLogs = "RTPatchLogs";
        }

        internal sealed class IniName
        {
            internal const string ServerVer = "ServerVer.ini";
            internal const string ClientVer = "Ver.ini";
            internal const string Translation = "Translation.ini";
            internal const string LanguagePack = "LanguagePacks.xml";
            internal const string TranslationPackData = "TranslationPackData.ini";
            internal const string BytesToPatch = "BytePatch.ini";
            internal const string DatasArchives = "datas.ini";

            internal sealed class Ver
            {
                internal const string Section = "Client";
                internal const string Key = "ver";
            }

            internal sealed class ServerRepository
            {
                internal const string Section = "FTP";
                internal const string Key = "address";
                internal const string UpdateRepository = "update/";
            }

            internal sealed class Patcher
            {
                internal const string Section = "Patcher";
                internal const string KeyDate = "date";
            }

            internal sealed class Pack
            {
                internal const string KeyPath = "path";
                internal const string KeyPathInArchive = "path_a";
                internal const string KeyPathOfDownload = "path_d";
                internal const string KeyFormat = "format";
                internal const string KeyBaseValue = "__base__";
            }

            internal sealed class PatchBytes
            {
                internal const string KeyOriginal = "original";
                internal const string KeyPatch = "patch";
            }

            internal sealed class Datas
            {
                internal const string SectionZipPassword = "Zip Passwords";
                internal const string Data12 = "data12";
            }
        }

        internal sealed class Server
        {
            internal const string IP = "re-gs.soulworker.gamecom.jp";
            internal const string Port = "10000";
        }

        internal sealed class Web
        {
            internal sealed class JP
            {
                internal sealed class Hange
                {
                    internal const string PostEncodeId = "encodeId";
                    internal const string PostEncodeFlag = "encodeFlg";
                    internal const string PostEncodeFlagDefaultValue = "true";
                    internal const string PostId = "strmemberid";
                    internal const string PostPw = "strpassword";
                    internal const string PostClearFlag = "clFlg";
                    internal const string PostClearFlagDefaultValue = "y";
                    internal const string PostNextUrl = "nxtURL";
                    internal const string PostNextUrlDefaultValue = "http://www.hange.jp";
                    internal const string MessageVariable = "var msg = ";
                    internal const string CaptchaValidationText = "画像認証";
                    internal const string CaptchaValidationText2 = "認証に連続";
                    internal const string CaptchaUrl = "http://top.hange.jp/login/loginfailed?type=dlf";
                }

                internal sealed class Gamecom
                {
                    internal const string PostId = "txtPortalID";
                    internal const string PostPw = "txtPortalPW";
                }
            }

            internal sealed class KR
            {
                internal const string ServiceCode = "service_code";
                internal const string LocalVersion = "local_version";

                internal const string PostId = "user_id";
                internal const string PostPw = "user_pwd";
                internal const string KeepForever = "forever";
                internal const string KeepForeverDefaultValue = "false";
            }
        }

        internal sealed class Registry
        {
            internal sealed class JP
            {
                internal static Microsoft.Win32.RegistryKey RegistryKey = Microsoft.Win32.Registry.LocalMachine;
                internal const string Key32Path = @"SOFTWARE\WeMade Online\Soulworker";
                internal const string Key64Path = @"SOFTWARE\WOW6432Node\WeMade Online\Soulworker";
                internal const string FolderName = "InstallPath";
            }

            internal sealed class KR
            {
                internal static Microsoft.Win32.RegistryKey RegistryKey = Microsoft.Win32.Registry.CurrentUser;
                internal const string Key32Path = @"SOFTWARE\SGUP\Apps\11";
                //public const string Key64Path = @"SOFTWARE\SGUP\Apps\11";
                internal const string FolderName = "GamePath";
                internal const string Version = "Version";

                internal const string StoveKeyPath = @"SOFTWARE\SGUP\ActiveProcess";
                internal const string StoveWorkingDir = "WorkingDir";
            }

            internal sealed class NaverKR
            {
                internal static Microsoft.Win32.RegistryKey RegistryKey = Microsoft.Win32.Registry.CurrentUser;
                internal const string Key32Path = @"SOFTWARE\SGSWOSCHANNEL\Apps\11";
                //public const string Key64Path = @"SOFTWARE\SGSWOSCHANNEL\Apps\11";
                internal const string FolderName = "GamePath";
                internal const string Version = "Version";
            }

            internal sealed class Steam
            {
                internal static Microsoft.Win32.RegistryKey RegistryKey = Microsoft.Win32.Registry.LocalMachine;
                internal const string Key32Path = @"SOFTWARE\Valve\Steam";
                internal const string Key64Path = @"SOFTWARE\Wow6432Node\Valve\Steam";
                internal const string InstallPath = "InstallPath";
            }

            internal sealed class Gameforge
            {
                internal static Microsoft.Win32.RegistryKey RegistryKey = Microsoft.Win32.Registry.LocalMachine;
                internal const string Key32Path = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\{e3ecbe04-49b0-40c8-9d1e-88c52f42813c}";
                internal const string Key64Path = @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\{e3ecbe04-49b0-40c8-9d1e-88c52f42813c}";
                internal const string InstallPath = "InstallLocation";

                internal const string Metadata32Path = @"Software\Gameforge4d\GameforgeClient\Metadata\Production\e3ecbe04-49b0-40c8-9d1e-88c52f42813c";
                internal const string Metadata64Path = @"Software\WOW6432Node\Gameforge4d\GameforgeClient\Metadata\Production\e3ecbe04-49b0-40c8-9d1e-88c52f42813c";
                internal const string GameState = "GameState";
            }
        }

        internal sealed class Xml
        {
            internal const string Value = "value";
            internal const string Regions = "regions";
            internal const string Languages = "languages";

            internal sealed class Attributes
            {
                internal const string Name = "name";
                internal const string Folder = "folder";
                internal const string LanguagesLinkId = "langlink";
            }
        }
    }
}
