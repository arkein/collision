using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollisionTest.Log
{
    public static class Log
    {
        static Log()
        {
            LogEntries = new ObservableCollection<LogEntry>();
            LogEntries.Add(new LogEntry() { DateTime = DateTime.UtcNow, Index = 0, Message = "Application started." });
        }

        public static ObservableCollection<LogEntry> LogEntries { get; private set; }

        public static void AddEntry(LogEntry entry)
        {
            LogEntries.Add(entry);
        }

        public static void Message(string message)
        {
            AddEntry(new LogEntry() { DateTime = DateTime.UtcNow, Message = message});
        }
    }
}
