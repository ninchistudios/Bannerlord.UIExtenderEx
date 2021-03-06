﻿using TaleWorlds.Core;
using TaleWorlds.Library;

using Debug = System.Diagnostics.Debug;

namespace Bannerlord.UIExtenderEx
{
    internal static class Utils
    {
        public static void Fail(string text)
        {
            Debug.Fail(text);
        }

        public static void Assert(bool condition, string text = "no description")
        {
            Debug.Assert(condition, $"UIExtenderEx failure: {text}.");
        }

        /// <summary>
        /// Critical runtime compatibility assert. Used when Bannerlord version is not compatible and it
        /// prevents runtime from functioning
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="text"></param>
        public static void CompatAssert(bool condition, string text = "no description")
        {
            Debug.Assert(condition, $"Bannerlord compatibility failure: {text}.");
        }

        /// <summary>
        /// Display error message to the end user
        /// </summary>
        /// <param name="text"></param>
        /// <param name="args"></param>
        public static void DisplayUserError(string text, params object[] args)
        {
            InformationManager.DisplayMessage(new InformationMessage($"UIExtender: {string.Format(text, args)}", Colors.Red));
        }

        /// <summary>
        /// Display warning message to the end user
        /// </summary>
        /// <param name="text"></param>
        /// <param name="args"></param>
        public static void DisplayUserWarning(string text, params object[] args)
        {
            InformationManager.DisplayMessage(new InformationMessage($"UIExtender: {string.Format(text, args)}", Colors.Yellow));
        }
    }
}