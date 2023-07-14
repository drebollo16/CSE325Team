
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
        [Required]
        [StringLength(30, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 6)]

        public string OpeningPrayer { get; set; }
        [Display(Name = "Conducting Leader")]
        [Required]
        [StringLength(30, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 6)]

        public string ConductingLeader { get; set; }
        [Display(Name = "Opening Song")]
        [StringLength(30, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 6)]

        [Required]

        public string OpeningSong { get; set; }
        [Display(Name = "Sacrament Hymn")]
        [StringLength(30, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 6)]

        public string SacramentHym { get; set; }
        [Display(Name = "Number of Speakers")]
        [Range(0, 6)]
        [Required]
        public int NumOfSpeakers { get; set; }
        [Display(Name = "Speaker Subjects")]
        [StringLength(30, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 6)]
        [Required]

        public string SpeakerSubjects { get; set; }
        [Display(Name = "Closing Song")]
        [StringLength(30, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 6)]

        [Required]

        public string ClosingSong { get; set; }

        [Display(Name = "Closing Prayer")]
        [StringLength(30, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 6)]

        [Required]

        public string ClosingPrayer { get; set;}
      

    }
}
