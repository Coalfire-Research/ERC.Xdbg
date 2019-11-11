using System;
using System.Runtime.InteropServices;

namespace Managed.x64dbg.SDK
{
    public class TitanEngine
    {
        public const int UE_STRUCT_PE32STRUCT = 1;
        public const int UE_STRUCT_PE64STRUCT = 2;
        public const int UE_STRUCT_PESTRUCT = 3;
        public const int UE_STRUCT_IMPORTENUMDATA = 4;
        public const int UE_STRUCT_THREAD_ITEM_DATA = 5;
        public const int UE_STRUCT_LIBRARY_ITEM_DATA = 6;
        public const int UE_STRUCT_LIBRARY_ITEM_DATAW = 7;
        public const int UE_STRUCT_PROCESS_ITEM_DATA = 8;
        public const int UE_STRUCT_HANDLERARRAY = 9;
        public const int UE_STRUCT_PLUGININFORMATION = 10;
        public const int UE_STRUCT_HOOK_ENTRY = 11;
        public const int UE_STRUCT_FILE_STATUS_INFO = 12;
        public const int UE_STRUCT_FILE_FIX_INFO = 13;
        public const int UE_STRUCT_X87FPUREGISTER = 14;
        public const int UE_STRUCT_X87FPU = 15;
        public const int UE_STRUCT_TITAN_ENGINE_CONTEXT = 16;
        public const int UE_ACCESS_READ = 0;
        public const int UE_ACCESS_WRITE = 1;
        public const int UE_ACCESS_ALL = 2;
        public const int UE_HIDE_PEBONLY = 0;
        public const int UE_HIDE_BASIC = 1;
        public const int UE_PLUGIN_CALL_REASON_PREDEBUG = 1;
        public const int UE_PLUGIN_CALL_REASON_EXCEPTION = 2;
        public const int UE_PLUGIN_CALL_REASON_POSTDEBUG = 3;
        public const int UE_PLUGIN_CALL_REASON_UNHANDLEDEXCEPTION = 4;
        public const int TEE_HOOK_NRM_JUMP = 1;
        public const int TEE_HOOK_NRM_CALL = 3;
        public const int TEE_HOOK_IAT = 5;
        public const int UE_ENGINE_ALOW_MODULE_LOADING = 1;
        public const int UE_ENGINE_AUTOFIX_FORWARDERS = 2;
        public const int UE_ENGINE_PASS_ALL_EXCEPTIONS = 3;
        public const int UE_ENGINE_NO_CONSOLE_WINDOW = 4;
        public const int UE_ENGINE_BACKUP_FOR_CRITICAL_FUNCTIONS = 5;
        public const int UE_ENGINE_CALL_PLUGIN_CALLBACK = 6;
        public const int UE_ENGINE_RESET_CUSTOM_HANDLER = 7;
        public const int UE_ENGINE_CALL_PLUGIN_DEBUG_CALLBACK = 8;
        public const int UE_ENGINE_SET_DEBUG_PRIVILEGE = 9;
        public const int UE_OPTION_REMOVEALL = 1;
        public const int UE_OPTION_DISABLEALL = 2;
        public const int UE_OPTION_REMOVEALLDISABLED = 3;
        public const int UE_OPTION_REMOVEALLENABLED = 4;
        public const int UE_STATIC_DECRYPTOR_XOR = 1;
        public const int UE_STATIC_DECRYPTOR_SUB = 2;
        public const int UE_STATIC_DECRYPTOR_ADD = 3;
        public const int UE_STATIC_DECRYPTOR_FOREWARD = 1;
        public const int UE_STATIC_DECRYPTOR_BACKWARD = 2;
        public const int UE_STATIC_KEY_SIZE_1 = 1;
        public const int UE_STATIC_KEY_SIZE_2 = 2;
        public const int UE_STATIC_KEY_SIZE_4 = 4;
        public const int UE_STATIC_KEY_SIZE_8 = 8;
        public const int UE_STATIC_APLIB = 1;
        public const int UE_STATIC_APLIB_DEPACK = 2;
        public const int UE_STATIC_LZMA = 3;
        public const int UE_STATIC_HASH_MD5 = 1;
        public const int UE_STATIC_HASH_SHA1 = 2;
        public const int UE_STATIC_HASH_CRC32 = 3;
        public const int UE_RESOURCE_LANGUAGE_ANY = -1;
        public const int UE_PE_OFFSET = 0;
        public const int UE_IMAGEBASE = 1;
        public const int UE_OEP = 2;
        public const int UE_SIZEOFIMAGE = 3;
        public const int UE_SIZEOFHEADERS = 4;
        public const int UE_SIZEOFOPTIONALHEADER = 5;
        public const int UE_SECTIONALIGNMENT = 6;
        public const int UE_IMPORTTABLEADDRESS = 7;
        public const int UE_IMPORTTABLESIZE = 8;
        public const int UE_RESOURCETABLEADDRESS = 9;
        public const int UE_RESOURCETABLESIZE = 10;
        public const int UE_EXPORTTABLEADDRESS = 11;
        public const int UE_EXPORTTABLESIZE = 12;
        public const int UE_TLSTABLEADDRESS = 13;
        public const int UE_TLSTABLESIZE = 14;
        public const int UE_RELOCATIONTABLEADDRESS = 15;
        public const int UE_RELOCATIONTABLESIZE = 16;
        public const int UE_TIMEDATESTAMP = 17;
        public const int UE_SECTIONNUMBER = 18;
        public const int UE_CHECKSUM = 19;
        public const int UE_SUBSYSTEM = 20;
        public const int UE_CHARACTERISTICS = 21;
        public const int UE_NUMBEROFRVAANDSIZES = 22;
        public const int UE_BASEOFCODE = 23;
        public const int UE_BASEOFDATA = 24;
        public const int UE_SECTIONNAME = 40;
        public const int UE_SECTIONVIRTUALOFFSET = 41;
        public const int UE_SECTIONVIRTUALSIZE = 42;
        public const int UE_SECTIONRAWOFFSET = 43;
        public const int UE_SECTIONRAWSIZE = 44;
        public const int UE_SECTIONFLAGS = 45;
        public const int UE_VANOTFOUND = -2;
        public const int UE_CH_BREAKPOINT = 1;
        public const int UE_CH_SINGLESTEP = 2;
        public const int UE_CH_ACCESSVIOLATION = 3;
        public const int UE_CH_ILLEGALINSTRUCTION = 4;
        public const int UE_CH_NONCONTINUABLEEXCEPTION = 5;
        public const int UE_CH_ARRAYBOUNDSEXCEPTION = 6;
        public const int UE_CH_FLOATDENORMALOPERAND = 7;
        public const int UE_CH_FLOATDEVIDEBYZERO = 8;
        public const int UE_CH_INTEGERDEVIDEBYZERO = 9;
        public const int UE_CH_INTEGEROVERFLOW = 10;
        public const int UE_CH_PRIVILEGEDINSTRUCTION = 11;
        public const int UE_CH_PAGEGUARD = 12;
        public const int UE_CH_EVERYTHINGELSE = 13;
        public const int UE_CH_CREATETHREAD = 14;
        public const int UE_CH_EXITTHREAD = 15;
        public const int UE_CH_CREATEPROCESS = 16;
        public const int UE_CH_EXITPROCESS = 17;
        public const int UE_CH_LOADDLL = 18;
        public const int UE_CH_UNLOADDLL = 19;
        public const int UE_CH_OUTPUTDEBUGSTRING = 20;
        public const int UE_CH_AFTEREXCEPTIONPROCESSING = 21;
        public const int UE_CH_SYSTEMBREAKPOINT = 23;
        public const int UE_CH_UNHANDLEDEXCEPTION = 24;
        public const int UE_CH_RIPEVENT = 25;
        public const int UE_CH_DEBUGEVENT = 26;
        public const int UE_OPTION_HANDLER_RETURN_HANDLECOUNT = 1;
        public const int UE_OPTION_HANDLER_RETURN_ACCESS = 2;
        public const int UE_OPTION_HANDLER_RETURN_FLAGS = 3;
        public const int UE_OPTION_HANDLER_RETURN_TYPENAME = 4;
        public const int UE_BREAKPOINT_INT3 = 1;
        public const int UE_BREAKPOINT_LONG_INT3 = 2;
        public const int UE_BREAKPOINT_UD2 = 3;
        public const int UE_BPXREMOVED = 0;
        public const int UE_BPXACTIVE = 1;
        public const int UE_BPXINACTIVE = 2;
        public const int UE_BREAKPOINT = 0;
        public const int UE_SINGLESHOOT = 1;
        public const int UE_HARDWARE = 2;
        public const int UE_MEMORY = 3;
        public const int UE_MEMORY_READ = 4;
        public const int UE_MEMORY_WRITE = 5;
        public const int UE_MEMORY_EXECUTE = 6;
        public const int UE_BREAKPOINT_TYPE_INT3 = 268435456;
        public const int UE_BREAKPOINT_TYPE_LONG_INT3 = 536870912;
        public const int UE_BREAKPOINT_TYPE_UD2 = 805306368;
        public const int UE_HARDWARE_EXECUTE = 4;
        public const int UE_HARDWARE_WRITE = 5;
        public const int UE_HARDWARE_READWRITE = 6;
        public const int UE_HARDWARE_SIZE_1 = 7;
        public const int UE_HARDWARE_SIZE_2 = 8;
        public const int UE_HARDWARE_SIZE_4 = 9;
        public const int UE_HARDWARE_SIZE_8 = 10;
        public const int UE_ON_LIB_LOAD = 1;
        public const int UE_ON_LIB_UNLOAD = 2;
        public const int UE_ON_LIB_ALL = 3;
        public const int UE_APISTART = 0;
        public const int UE_APIEND = 1;
        public const int UE_PLATFORM_x86 = 1;
        public const int UE_PLATFORM_x64 = 2;
        public const int UE_PLATFORM_ALL = 3;
        public const int UE_FUNCTION_STDCALL = 1;
        public const int UE_FUNCTION_CCALL = 2;
        public const int UE_FUNCTION_FASTCALL = 3;
        public const int UE_FUNCTION_STDCALL_RET = 4;
        public const int UE_FUNCTION_CCALL_RET = 5;
        public const int UE_FUNCTION_FASTCALL_RET = 6;
        public const int UE_FUNCTION_STDCALL_CALL = 7;
        public const int UE_FUNCTION_CCALL_CALL = 8;
        public const int UE_FUNCTION_FASTCALL_CALL = 9;
        public const int UE_PARAMETER_BYTE = 0;
        public const int UE_PARAMETER_WORD = 1;
        public const int UE_PARAMETER_DWORD = 2;
        public const int UE_PARAMETER_QWORD = 3;
        public const int UE_PARAMETER_PTR_BYTE = 4;
        public const int UE_PARAMETER_PTR_WORD = 5;
        public const int UE_PARAMETER_PTR_DWORD = 6;
        public const int UE_PARAMETER_PTR_QWORD = 7;
        public const int UE_PARAMETER_STRING = 8;
        public const int UE_PARAMETER_UNICODE = 9;
        public const int UE_EAX = 1;
        public const int UE_EBX = 2;
        public const int UE_ECX = 3;
        public const int UE_EDX = 4;
        public const int UE_EDI = 5;
        public const int UE_ESI = 6;
        public const int UE_EBP = 7;
        public const int UE_ESP = 8;
        public const int UE_EIP = 9;
        public const int UE_EFLAGS = 10;
        public const int UE_DR0 = 11;
        public const int UE_DR1 = 12;
        public const int UE_DR2 = 13;
        public const int UE_DR3 = 14;
        public const int UE_DR6 = 15;
        public const int UE_DR7 = 16;
        public const int UE_RAX = 17;
        public const int UE_RBX = 18;
        public const int UE_RCX = 19;
        public const int UE_RDX = 20;
        public const int UE_RDI = 21;
        public const int UE_RSI = 22;
        public const int UE_RBP = 23;
        public const int UE_RSP = 24;
        public const int UE_RIP = 25;
        public const int UE_RFLAGS = 26;
        public const int UE_R8 = 27;
        public const int UE_R9 = 28;
        public const int UE_R10 = 29;
        public const int UE_R11 = 30;
        public const int UE_R12 = 31;
        public const int UE_R13 = 32;
        public const int UE_R14 = 33;
        public const int UE_R15 = 34;
        public const int UE_CIP = 35;
        public const int UE_CSP = 36;

        [DllImport("TitanEngine.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetContextData(uint IndexOfRegister);

        [DllImport("TitanEngine.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr TitanGetProcessInformation();

        [DllImport("TitanEngine.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool DumpProcess(IntPtr hProcess, IntPtr ImageBase, string szDumpFileName, IntPtr EntryPoint);

        [DllImport("TitanEngine.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool StaticFileLoadW(string szFileName, uint DesiredAccess, bool SimulateLoad, IntPtr FileHandle, ref uint LoadedSize, IntPtr FileMap, IntPtr FileMapVA);
    }
}
