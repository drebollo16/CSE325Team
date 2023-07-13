
 using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SacramentMeeting.Models
{ 
    public class MeetingPlanner
    {
        public int ID { get; set; }
        [Display(Name = "Meeting Date")]
        public DateTime MeetingDate { get; set; }
        [Display(Name = "Opening Prayer")]
        public string OpeningPrayer { get; set; }
        [Display(Name = "Conducting Leader")]
        public string ConductingLeader { get; set; }
        [Display(Name = "Hymn Number")]
        public string OpeningSong { get; set; }
        [Display(Name = "Sacrament Hymn")]
        public string SacramentHym { get; set; }
        [Display(Name = "Number of Speakers")]

        public int NumOfSpeakers { get; set; }
        [Display(Name = "Speaker Subjects")]
        public string SpeakerSubjects { get; set; }
        [Display(Name = "Closing Hymn")]

        public string ClosingSong { get; set; }

        [Display(Name = "Closing Prayer")]
        public string ClosingPrayer { get; set;}
      

    }
}
