using System;
using System.Collections.Generic;

namespace Euvic.WebAPI.ResourcesNaming.Domain
{
    public class Attendee
    {
        public long Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int AllowedHours { get; set; }

        public ICollection<Training> Trainings { get; set; }
    }
}
