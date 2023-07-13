
 using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace SacramentMeeting.Models
{ 
    public class MeetingPlanner
    {
        public int ID { get; set; }
        public DateTime MeetingDate { get; set; }
        public string OpeningPrayer { get; set; }
        public string ConductingLeader { get; set; }
        public string OpeningSong { get; set; }
        public string SacramentHym { get; set; }
        
        public int NumOfSpeakers { get; set; }
        public string SpeakerSubjects { get; set; }

        public string ClosingSong { get; set; }

        public string ClosingPrayer { get; set;}
      

    }
}
