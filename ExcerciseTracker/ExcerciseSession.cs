using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseTracker
{
    internal class ExcerciseSession
    {
        public int Id { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public TimeSpan Duration { get; }
        public string? Comments { get; set; }
    }
}
