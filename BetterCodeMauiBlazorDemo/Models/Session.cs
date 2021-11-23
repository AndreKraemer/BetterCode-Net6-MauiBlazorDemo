using System;
using System.Collections.Generic;


namespace BetterCodeMauiBlazorDemo.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Goals { get; set; }
        public Speaker Speaker { get; set; }

        public TimeOnly Start { get; set; }
        public TimeOnly End { get; set; }

    }
}
