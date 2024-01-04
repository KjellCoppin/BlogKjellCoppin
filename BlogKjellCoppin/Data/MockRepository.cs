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
                new Post("Hackaton OH Vorarlberg", DateTime.Now, "Last weekend, I participated in the ÖH Hackaton 2023" +
                " at FHV - Vorarlberg University of Applied Sciences with my good friend Nori Alija." +
                " Together we created and built the RealTea Concept. An application that lets you share anonymous dairy posts" +
                " with your friend group. I took charge of crafting the backend, utilizing ASP.NET Web API and Entity Framework." +
                " This challenge allowed me to put my .Net skills to practice once more and grow as a developer. I'm immensely" +
                " proud of what we accomplished in such a short span, and I look forward to taking on more challenges like this. ",
                new List<Bitmap> {new Bitmap(@"./Data/MockImages/KjellNori.JPG"), new Bitmap(@"./Data/MockImages/RealTea.png") })
            };
        }
    }
}
