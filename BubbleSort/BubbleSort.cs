namespace Algorithms.BubbleSort;

public class BubbleSort<T> where T:IComparable
{
    //Time complexity:
    //Worst case : O(n^2)
    //Best case : O(n)
    public void Sort(T[] array)
    {
        if (array.Length == 0)
            throw new NullReferenceException();
        if (array.Length != 1)
        {
            int attempt = array.Length - 1;
            for (int i = 0; i < attempt; i++)
            {
                int compareAttempt = attempt - i;
                for (int j = 0; j < compareAttempt; j++)
                {
                    if (array[j].CompareTo(array[j+1]) > 0)
                    {
                        (array[j],array[j+1])=(array[j+1],array[j]);
                    }
                }
            }
        }
    }

    //Time complexity:
    //Worst case : O(n) + O(n^2)
    //Best case : 2 * O(n)
    public List<T> Sort(ICollection<T> collection)
    {
        if (collection.Count == 0)
        {
            throw new NullReferenceException();
        }
        
        var result = new List<T>();

        if (collection.Count == 1)
        {
            foreach (var item in collection)
            {
                result.Add(item);
            }
        }

        if (collection.Count != 1)
        {
            
            foreach (var item in collection)
            {
                result.Add(item);
            }
            int attempt = collection.Count - 1;
            for (int i = 0; i < attempt; i++)
            {
                int compareAttempt = attempt - i;
                for (int j = 0; j < compareAttempt; j++)
                {
                    if (result[j].CompareTo(result[j+1]) > 0)
                    {
                        (result[j],result[j+1])=(result[j+1],result[j]);
                    }
                }
            }
        }
        

        return result;
    }
}