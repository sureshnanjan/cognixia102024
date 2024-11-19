namespace HerokuAppOperations
{
    public interface IHomePage
    {
        public string getTitle();

        public string getDescription();

        public string[] getAvailableExamples();

        public void navigateToExample(string exname);

    }
}
