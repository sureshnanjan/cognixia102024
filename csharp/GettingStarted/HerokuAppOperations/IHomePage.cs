namespace HerokuAppOperations
{
    public interface IHomePage
    {
        public string getTitle();

        public string getDescription();

        public string[] getAvailableExamples();

        public ICheckBox navigateToCheckBox();

        public IABTesting navigateToABTest();
        public object navigateToExample(string exname);

    }
}
