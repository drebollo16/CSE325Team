using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using SacramentMeeting.Models;

namespace SacramentMeeting.Data
{

    public class DbInitializer
    {
        public static void Initialize(MeetingContext context)
        {
            context.Database.EnsureCreated();

            // Look for existing meeting planners
            if (context.MeetingPlanners.Any())
            {
                return; // Database has been seeded
            }

            var meetings = new MeetingPlanner[]
            {
                new MeetingPlanner
                {
                    MeetingDate = DateTime.Parse("2009-06-02"),
                    ConductingLeader = "Brother John",
                    OpeningPrayer = "Sister Watson",
                    OpeningSong = "167 - Come, Sing to the Lord",
                    SacramentHym = "39 - O Saints of Zion",
                    NumOfSpeakers = 3,
                    SpeakerSubjects = "Agency",
                    ClosingSong = "237 - Do What Is Right",
                    ClosingPrayer = "Brother Zack"
                },



                new MeetingPlanner
                {
                    MeetingDate = DateTime.Parse("2012-06-02"),
                    ConductingLeader = "Brother Fret",
                    OpeningPrayer = "Sister Mane",
                    OpeningSong = "94 - Ye Thankful People",
                    SacramentHym = "169 - As Now We Take the Sacrament",
                    NumOfSpeakers = 2,
                    SpeakerSubjects = "Honesty",
                    ClosingSong = "239 - Choose the Right",
                    ClosingPrayer = "Brother Jones"
                },

                new MeetingPlanner
                {
                    MeetingDate = DateTime.Parse("2016-12-08"),
                    ConductingLeader = "Brother John",
                    OpeningPrayer = "Brother Lane",
                    OpeningSong = "89 - The Lord is My Light",
                    SacramentHym = "39 - O Saints of Zion",
                    NumOfSpeakers = 3,
                    SpeakerSubjects = "Blessings",
                    ClosingSong = "294 - Love At Home",
                    ClosingPrayer = "Sister John"
                },

                new MeetingPlanner
                {
                    MeetingDate = DateTime.Parse("2020-15-05"),
                    ConductingLeader = "Brother John",
                    OpeningPrayer = "Elder Doe",
                    OpeningSong = "224 - I have Work Enough to Do",
                    SacramentHym = "241 - Count Your Blessings",
                    NumOfSpeakers = 3,
                    SpeakerSubjects = "Intergrity",
                    ClosingSong = "259 - Hope of Isreal",
                    ClosingPrayer = "Brother Mills"
                },

                new MeetingPlanner
                {
                    MeetingDate = DateTime.Parse("2021-06-03"),
                    ConductingLeader = "Brother John",
                    OpeningPrayer = "Sister Jane",
                    OpeningSong = "24 - Call to Serve",
                    SacramentHym = "263 - Go Forth with Faith",
                    NumOfSpeakers = 3,
                    SpeakerSubjects = "Priesthood",
                    ClosingSong = "237 - Do what is Right",
                    ClosingPrayer = "Sister Chase"
                },

                new MeetingPlanner
                {
                    MeetingDate = DateTime.Parse("2022-25-12"),
                    ConductingLeader = "Brother Tim",
                    OpeningPrayer = "Sister Mason",
                    OpeningSong = "216 - We are Sowing",
                    SacramentHym = "264 - Hark, All Ye Nations",
                    NumOfSpeakers = 3,
                    SpeakerSubjects = "Prayer",
                    ClosingSong = "213 - The First Noel",
                    ClosingPrayer = "Brother Ethan"
                }
        };

            foreach (MeetingPlanner m in meetings)
            {
                context.MeetingPlanners.Add(m);
            }
            context.SaveChanges();
        }
    }
}
 
    


        /*
        public static void Initizlie(MeetingContext context)
        {
            context.Database.EnsureCreated();

            //look for members
            if (context.MeetingPlanners.Any())
            {
                return;
            }

            var meetings = new MeetingPlanner[]
            {
                new MeetingPlanner
                {
                    MeetingDate = DateTime.Parse("2009-06-02"),
                    ConductingLeader = "Brother John",
                    OpeningPrayer = "Sister Watson",
                    OpeningSong = "167 - Come,Sing to the Lord",
                    SacramentHym = "39 - O Saints of Zion",
                    NumOfSpeakers = 3,
                    SpeakerSubjects = "Agency",
                    ClosingSong = "237 - Do what is Right",
                    ClosingPrayer = "Brother Zack"
                },

                new MeetingPlanner
                {
                    MeetingDate = DateTime.Parse("2012-06-02"),
                    ConductingLeader = "Brother Fret",
                    OpeningPrayer = "Sister Mane",
                    OpeningSong = "94 - Ye Thankful People",
                    SacramentHym = "169 - As Now We Take the Sacrament",
                    NumOfSpeakers = 2,
                    SpeakerSubjects = "Honesty",
                    ClosingSong = "239 - Choose the Right",
                    ClosingPrayer = "Brother Jones"
                },

                new MeetingPlanner
                {
                    MeetingDate = DateTime.Parse("2016-12-08"),
                    ConductingLeader = "Brother John",
                    OpeningPrayer = "Brother Lane",
                    OpeningSong = "89 - The Lord is My Light",
                    SacramentHym = "39 - O Saints of Zion",
                    NumOfSpeakers = 3,
                    SpeakerSubjects = "Blessings",
                    ClosingSong = "294 - Love At Home",
                    ClosingPrayer = "Sister John"
                },

                new MeetingPlanner
                {
                    MeetingDate = DateTime.Parse("2020-15-05"),
                    ConductingLeader = "Brother John",
                    OpeningPrayer = "Elder Doe",
                    OpeningSong = "224 - I have Work Enough to Do",
                    SacramentHym = "241 - Count Your Blessings",
                    NumOfSpeakers = 3,
                    SpeakerSubjects = "Intergrity",
                    ClosingSong = "259 - Hope of Isreal",
                    ClosingPrayer = "Brother Mills"
                },

                new MeetingPlanner
                {
                    MeetingDate = DateTime.Parse("2021-06-03"),
                    ConductingLeader = "Brother John",
                    OpeningPrayer = "Sister Jane",
                    OpeningSong = "24 - Call to Serve",
                    SacramentHym = "263 - Go Forth with Faith",
                    NumOfSpeakers = 3,
                    SpeakerSubjects = "Priesthood",
                    ClosingSong = "237 - Do what is Right",
                    ClosingPrayer = "Sister Chase"
                },

                new MeetingPlanner
                {
                    MeetingDate = DateTime.Parse("2022-25-12"),
                    ConductingLeader = "Brother Tim",
                    OpeningPrayer = "Sister Mason",
                    OpeningSong = "216 - We are Sowing",
                    SacramentHym = "264 - Hark, All Ye Nations",
                    NumOfSpeakers = 3,
                    SpeakerSubjects = "Prayer",
                    ClosingSong = "213 - The First Noel",
                    ClosingPrayer = "Brother Ethan"
                }
            };

            foreach (MeetingPlanner m in meetings)
            {
                context.MeetingPlanners.Add(m);
            }
            context.SaveChanges();


        

        }

       
    }

        */
     
