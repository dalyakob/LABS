using System;
namespace Lab27.Models
{
    public class Time
    {
        public string       LayoutKey { get; set; }
        public string[]     StartPeriodName { get; set; }
        public DateTime[]   StartValidTime { get; set; }
        public string[]     TempLabel { get; set; }
    }
}
