
 using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SacramentMeeting.Models
{ 
    public class MeetingPlanner
    {
        [Required]
        public int ID { get; set; }
        [Display(Name = "Meeting Date")]
        public DateTime MeetingDate { get; set; }
        [Display(Name = "Opening Prayer")]
        [StringLength(50)]


        public string OpeningPrayer { get; set; }
        [Display(Name = "Conducting Leader")]
        [Required] 
        [StringLength(50, ErrorMessage = "Cannot be longer than 50 characters.")]

        public string ConductingLeader { get; set; }
        [Display(Name = "Opening Song")]
        public string OpeningSong { get; set; }
        [Display(Name = "Sacrament Hymn")]
        public string SacramentHym { get; set; }
        [Display(Name = "Number of Speakers")]

        public int NumOfSpeakers { get; set; }
        [Display(Name = "Speaker Subjects")]
        public string SpeakerSubjects { get; set; }
        [Display(Name = "Closing Song")]

        public string ClosingSong { get; set; }

        [Display(Name = "Closing Prayer")]
        public string ClosingPrayer { get; set;}
      

    }
}
