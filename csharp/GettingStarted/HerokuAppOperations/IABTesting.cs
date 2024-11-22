namespace HerokuAppOperations
{
    public interface IABTesting
    {
        public void OptInABTest();
        public void OptOutABTest();

        public String GetTitle();

        public String GetDiscription();
    }
}