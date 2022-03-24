using System;
namespace OpSys {

    public enum Timezones { ET, CT, MT, PT}

    public interface IOpSys {
        string About();
        string Timezone();
    }
}

