using System;
using System.Text.Json;

namespace Common
{
    public class News
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
    }

    public class Command
    {
        public string Type { get; set; }
    }
}