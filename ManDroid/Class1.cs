using System;
using System.Drawing;
using System.ComponentModel;
using ManDroid.ManDroid;

namespace Events
{

    //public enum Event

    public class EventRecord
    {
        public string Time { get; set; }
        public string Type { get; set; }
        public string Operation { get; set; }
        public string Description { get; set; }
        public string EventListKind { get; set; }
        public Image Icon { get; set; }
        public EventRecord(string eventtype, string operation, string description, string eventlistkind, Image icon)
        {
            Time = DateTime.Now.ToLongTimeString();
            Operation = operation;
            Type = eventtype;
            Description = description;
            EventListKind = eventlistkind;
            Icon = icon;
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

    public static class EventListKind
    {
        public readonly static string Parent = "Parent";
        public readonly static string Child = "Child";
    }
}

