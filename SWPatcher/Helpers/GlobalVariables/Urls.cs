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
    internal static class Urls
    {
        internal const string SoulworkerWebsite = "https://github.com/dev-iCEY/SWPatcher";
#if DEBUG
        internal static string TranslationGitHubHome = System.Environment.ExpandEnvironmentVariables(@"%userprofile%\Documents\GitHub\SoulWorkerHQTranslations\");
#else
        internal const string TranslationGitHubHome = "https://raw.githubusercontent.com/dev-iCEY/SoulWorkerHQTranslations/RUJPPatcherData/";
#endif
        internal const string SoulworkerSettingsHome = "http://patch-cdn.soulworker.gamecom.jp/SWK/update/";
        internal const string SoulworkerJPHome = "http://soulworker.jp/";
        internal const string SoulworkerKRHome = "http://soulworker.co.kr/";
        internal const string SoulworkerNaverKRHome = "http://soulworker.game.naver.com/";
        internal const string SoulworkerGFHome = "https://store.steampowered.com/app/630100";
        internal const string HangameLogin = "https://id.hangame.co.jp/login.nhn";
        internal const string SoulworkerGameStart = "http://soulworker.hangame.co.jp/gamestart.nhn";
        internal const string SoulworkerReactorGameStart = "http://soulworker.hangame.co.jp/reactor/gameStart.nhn";
        internal const string SoulworkerReactor = "http://soulworker.hangame.co.jp/reactor/reactor.nhn";
        internal const string SoulworkerRegistCheck = "http://soulworker.hangame.co.jp/reactor/registCheck.nhn";

        internal const string SoulworkerKRAPI = "http://patchapi.onstove.com:80/apiv1/get_live_version";
        internal const string StoveLogin = "https://member.onstove.com/auth/login/request";
        internal const string SoulworkerKRGameStart = "http://soulworker.game.onstove.com/Game/GameStart";
    }
}
