namespace Async
{
    internal class Website
    {
        private static string[] websiteNames = { "google", "github", "stackoverflow", "leetcode", "youtube" };
        public string[] Urls
        {
            get
            {
                return websiteNames.Select(x => $"https://www.{x}.com").ToArray();
            }
        }

        public Website()
        {

        }

        public Website(string name)
        {

        }
    }
}
