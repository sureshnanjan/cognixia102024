namespace KeywordLearning
{
    public class decimal_int_return
    {
        public void display()
        {
            Console.WriteLine("9. DECIMAL, INT, and RETURN");

            decimal result = CalculateTotalPrice(5, 20.75m);
            Console.WriteLine("Total Price: " + result);

            Console.WriteLine(" ");
        }
        public decimal CalculateTotalPrice(int quantity, decimal pricePerItem)
        {
            decimal totalPrice = quantity * pricePerItem;
            return totalPrice;
        }
    }
}