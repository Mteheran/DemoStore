using DemoStore.Web.Enums;

namespace DemoStore.Web.Helper
{
    public class VarsHelper
    {
        public static string Mode {get;set;}
        public static ModeType GetDataMode()
        {
            switch (Mode)
            {
                case "SQLData":
                    return ModeType.SQLData;                    
                case "InMemory":
                    return ModeType.InMemory;                  
                default:
                    return ModeType.SQLData;
            }            
        }
    }
}