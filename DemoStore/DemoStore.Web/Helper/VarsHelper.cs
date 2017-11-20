using DemoStore.Web.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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