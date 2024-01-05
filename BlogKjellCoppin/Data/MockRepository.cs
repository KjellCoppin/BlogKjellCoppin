using System.Drawing;

namespace BlogKjellCoppin.Data
{
    public class MockRepository : IRepository
    {
        public List<Post> Posts { get;  set ; }

        public MockRepository()
        {
            Posts = new List<Post>()
            {
                new Post(0, "Hackaton OH Vorarlberg", new DateTime(2023, 11, 20, 13, 35, 23), "Last weekend, I participated in the ÖH Hackaton 2023" +
                " at FHV - Vorarlberg University of Applied Sciences with my good friend Nori Alija." +
                " Together we created and built the RealTea Concept. An application that lets you share anonymous dairy posts" +
                " with your friend group.<br><br> I took charge of crafting the backend, utilizing ASP.NET Web API and Entity Framework." +
                " This challenge allowed me to put my .Net skills to practice once more and grow as a developer. I'm immensely" +
                " proud of what we accomplished in such a short span, and I look forward to taking on more challenges like this. ",
                new List<string>() { "https://i.ibb.co/9VZP22b/RealTea2.png", "https://i.ibb.co/4sL7gmy/RealTea1.jpg" }), 

                new Post(1, "My Semester in Austria", new DateTime(2024, 1, 1, 12, 0, 0), "This is the story of my exiting Erasmus Semester.<br><br>" +
                "Embarking on my Erasmus semester was something I had planned on for quite some time, and I couldn't have chosen a better destination than Austria." +
                " The fifth semester of my bachelor's degree in Applied Computer Science led me to the Fachhochschule Vorarlberg, situated in the heart of the" +
                " Austrian Alps. My choice was deeply rooted in my love for hiking and mountain biking.<br><br>" +
                "The initial week was nothing short of a whirlwind." +
                " I got to meet the people I would spend the semester with as Erasmus students from around the world gathered for orientation and a series of" +
                " ice-breaking activities. We did quizzes about the culture and language, visited the market in the city and much more. I already went on a few" +
                " spectacular hikes and mountain bike rides between all the gatherings that the international office organised. <br><br>" +
                " One of the unique aspects of" +
                " my semester at Fachhochschule Vorarlberg was the emphasis on projects over traditional exams. The curriculum was designed to encourage practical" +
                " application of knowledge, always allowing students to team up. The teachers, with their laid-back yet dedicated approach, created an interactive" +
                " atmosphere where every person had input. It was urged that we explore our own interests in the context of tasks and projects. So for the module" +
                " Augmented reality I created a concept application to help drivers learn new tracks faster. My favorite module, largely due to the amazing teacher," +
                " was DevOps. These classes gave me a new understanding and interest in Linux machines and containerization. The material was not just instructive but also" +
                " thought-provoking, challenging me to explore beyond the conventional boundaries of my discipline. <br><br>" +
                "Life in Austria was not just confined to the classrooms;" +
                " it extended to the breathtaking landscapes that surrounded us. My dear friends Nori and Ron quickly became companions in my exploration of Austrian life." +
                " We bonded over shared interests like fitness and music, and our weekends were often dedicated to hiking the picturesque trails of the Alps." +
                " These adventures not only tested our physical limits but also solidified the bonds of friendship, creating memories that I will remember forever." +
                " I travelled to Austria by car, which meant I had a car available. This allowed us to really explore the region and enjoy the fun mountain" +
                " roads with tight curves. <br><br>" +
                "As the semester drew to a close, bidding farewell to Austria was bittersweet. The challenges, friendships," +
                " and cultural immersion had shaped me into a more resilient and adaptable individual. Leaving behind the majestic landscapes and the amazing" +
                " friends was difficult, but the personal growth I achieved during my time in Austria was undeniably worth it.\r\nIn retrospect, my Erasmus" +
                " semester at Fachhochschule Vorarlberg was more than just an academic endeavor—it was an adventure that enriched my understanding of both" +
                " computer science and the world around me.\r\n"
                , new List<string> { "https://i.ibb.co/ctWxL3y/Erasmus1.jpg",
                    "https://i.ibb.co/880b6VW/Erasmus2.jpg", "https://i.ibb.co/VVGdjQv/Erasmus3.jpg" }),
            };

            Posts = Posts.OrderByDescending(post => post.PublishDate).ToList();
        }
    }
}
