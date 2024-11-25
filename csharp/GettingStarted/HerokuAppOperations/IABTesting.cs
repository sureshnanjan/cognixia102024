namespace HerokuAppOperations
{
    // This interface defines the contract for A/B testing operations.
    public interface IABTesting
    {
        // Method to opt-in a user to an A/B test.
        public void OptInABTest();

        // Method to opt-out a user from an A/B test.
        public void OptOutABTest();
    }
}