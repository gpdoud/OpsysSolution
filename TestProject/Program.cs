
using OpSys;
using static System.Console;

var opsys = OpSysBase.CreateInstance(OpSysType.Windows);

WriteLine($"Win Timezone: {opsys.Timezone()}");

opsys = OpSysBase.CreateInstance(OpSysType.Mac);

WriteLine($"Mac Timezone: {opsys.Timezone()}");
