using System;
using System.Collections.Generic;

namespace Euvic.WebAPI.ResourcesNaming.Domain
{
    public class Training
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime TrainingDate { get; set; }

        public ICollection<Attendee> Attendees { get; set; }
    }
}
