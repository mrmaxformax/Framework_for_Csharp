using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPAutomation
{
    public class PostCreator
    {
        public static string PreviousBody { get; set; }
        public static string PreviousTitle { get; set; }
        public static bool CreatedAPost { get { return !String.IsNullOrEmpty(PreviousTitle); } }

        public static string[] Words = new[] { "boy", "cat", "dog", "rabbit", "baseball", "throw", "find", "mustard" };
        public static string[] Articles = new[] { "a", "the", "an", "and", "of", "to", "it", "as" };

        public static void Initialize()
        {
            PreviousTitle = null;
            PreviousBody = null;
        }

        public static void CleanUp()
        {
            if (CreatedAPost)
            {
                TrashPost();
            }
        }

        private static void TrashPost()
        {
            ListPostsPage.TrashPost(PreviousTitle);
            Initialize();
        }

        public static void CreatePost()
        {
            PreviousTitle = CreateTitle();
            PreviousBody = CreateBody();

            NewPostPage.GoTo();
            NewPostPage.CreatePost(PreviousTitle).WithBody(PreviousBody).Publish();
        }

        public static string CreateBody()
        {
            return CreateRandomString() + ", body";
        }

        public static string CreateTitle()
        {
            return CreateRandomString() + ", title";
        }

        private static string CreateRandomString()
        {
            var s = new StringBuilder();

            var random = new Random();
            var cycles = random.Next(5 + 1);

            for (int i = 0; i < cycles; i++)
            {
                s.Append(Words[random.Next(Words.Length)]);
                s.Append(" ");
                s.Append(Articles[random.Next(Articles.Length)]);
                s.Append(" ");
                s.Append(Words[random.Next(Words.Length)]);
                s.Append(" ");
            }

            return s.ToString();
        }

    }
}
