﻿using System.Runtime.InteropServices;
using Managed.x64dbg.SDK;
using Microsoft.VisualBasic;
using RGiesecke.DllExport;

namespace ErcXdbg
{
    public class ErcXdbg
    {
        private const int MENU_ABOUT = 0;
        private const int MENU_HELP = 1;

        public static bool PluginInit(Plugins.PLUG_INITSTRUCT initStruct)
        {
            PLog.WriteLine("[DotNet TEST] pluginHandle: {0}", Plugins.pluginHandle);
            if (!Plugins._plugin_registercommand(Plugins.pluginHandle, "DotNetpluginTestCommand", RegisteredCommands.ErcCommand, false))
                PLog.WriteLine("[DotNet TEST] error registering the \"DotNetpluginTestCommand\" command!");
            return true;
        }

        public static void PluginStop()
        {
            Plugins._plugin_unregistercallback(Plugins.pluginHandle, Plugins.CBTYPE.CB_INITDEBUG);
            Plugins._plugin_unregistercallback(Plugins.pluginHandle, Plugins.CBTYPE.CB_STOPDEBUG);
        }

        public static void PluginSetup(Plugins.PLUG_SETUPSTRUCT setupStruct)
        {
            Plugins._plugin_menuaddentry(setupStruct.hMenu, 0, "&About...");
            Plugins._plugin_menuaddentry(setupStruct.hMenu, 1, "&Help");
        }

        [DllExport("CBMENUENTRY", CallingConvention.Cdecl)]
        public static void CBMENUENTRY(Plugins.CBTYPE cbType, ref Plugins.PLUG_CB_MENUENTRY info)
        {
            switch (info.hEntry)
            {
                case MENU_ABOUT:
                    Interaction.MsgBox("ERC Plugin For x64dbg\nCoded By Andy Bowden", MsgBoxStyle.OkOnly, "Info");
                    break;
                case MENU_HELP:
                    Interaction.MsgBox("https://github.com/Andy53/ERC.net", MsgBoxStyle.OkOnly, "Help");
                    break;

            }
        }
    }
}
