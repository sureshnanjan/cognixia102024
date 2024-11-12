namespace KeywordLearning

{

    public class GenericList<T>

    {

        public List<T> items = new List<T>();

        // Add item to list

        public void AddItem(T item) => items.Add(item);

        // Find an item based on a condition

        public T FindItem(Func<T, bool> predicate) => items.FirstOrDefault(predicate);

        // Update item at specific index

        public void UpdateItem(int index, T item) => items[index] = item;

        // Remove item by value

        public bool RemoveItem(T item) => items.Remove(item);

        // Display the list

        public void DisplayList() => Console.WriteLine(string.Join(", ", items));

    }



}
