using System;

namespace ManDroid.ManDroid
{
    public class EventRecord
    {
        public string Time { get; set; }
        public string Type { get; set; }
        public string Operation { get; set; }
        public string Description { get; set; }

        public EventRecord(string type, string operation, string description)
        {
            Time = DateTime.Now.ToShortTimeString();
            Operation = operation;
            Type = type;
            Description = description;
        }
    }

    public static class EventType
    {
        public readonly static string Info = "Info";
        public readonly static string Error = "Error";
        public readonly static string Complete = "Complete";
        public readonly static string Warning = "Warning";
        public readonly static string Success = "Success";
        public readonly static string Fail = "Fail";
        public readonly static string System = "System";
        public readonly static string Device = "Device";
    }
}

