using System.Collections.Generic;
namespace FanControl.Liquidctl
{
    public class LiquidctlStatusJSON
    {
        public class StatusRecord
        {
            public string key { get; set; }
            //public float? value { get; set; }     // float fails if the returned value is not a number (e.g. for "Fan control mode", which returns "PWM" or "DC")
                                                    // Setting it to dynamic seems to fix the issue(?)
            public dynamic value { get; set; }
            public string unit { get; set; }
        }
        public string bus { get; set; }
        public string address { get; set; }

        public string description { get; set; }

        public List<StatusRecord> status { get; set; }
    }
}
