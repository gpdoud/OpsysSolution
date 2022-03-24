using System;
namespace OpSys {

    public class OpSysBase {
        public static IOpSys CreateInstance(OpSysType opSysType) {
            return opSysType switch {
                OpSysType.Windows => new OpSysWin(),
                OpSysType.Mac => new OpSysMac(),
                _ => throw new Exception("Invalid OpSysType")
            };
        }
    }

    public enum OpSysType { Windows, Mac }
}

