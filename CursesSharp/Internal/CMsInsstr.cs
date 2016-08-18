#region Copyright 2009 Robert Konklewski
/*
 * CursesSharp
 * 
 * Copyright 2009 Robert Konklewski
 * 
 * This library is free software; you can redistribute it and/or modify it
 * under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation; either version 3 of the License, or (at your
 * option) any later version.
 *
 * This library is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
 * FITNESS FOR A PARTICULAR PURPOSE.  See the GNU Lesser General Public
 * License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * www.gnu.org/licenses/>.
 * 
 */
#endregion

using System;
using System.Runtime.InteropServices;

namespace CursesSharp.Internal
{
    internal static partial class CursesMethods
    {
        internal static void winsnstr(IntPtr win, string str, int n)
        {
            int ret = wrap_winsnstr(win, str, n);
            InternalException.Verify(ret, "winsnstr");
        }

        internal static void mvwinsnstr(IntPtr win, int y, int x, string str, int n)
        {
            int ret = wrap_mvwinsnstr(win, y, x, str, n);
            InternalException.Verify(ret, "mvwinsnstr");
        }

        [DllImport("CursesWrapper", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern int wrap_winsnstr(IntPtr win, String str, int n);
        [DllImport("CursesWrapper", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern int wrap_mvwinsnstr(IntPtr win, int y, int x, String str, int n);
    }
}

