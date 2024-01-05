namespace Algorithms.InsertionSort;

public class InsertionSort<T> where T:IComparable
{
    public void Sort(ICollection<T> collection)
    {
        if (collection == null)
            throw new NullReferenceException();
        if (collection.Count == 1) return ;

        var sortedArray = new T[collection.Count];
        int index = 0;
        foreach (var item in collection)
        {
            if (index == 0)
            {
                sortedArray[index] = item;
                index++;
            }
            else
            {
                sortedArray[index] = item;
                int tempIndex = index;
                while (sortedArray[tempIndex-1].CompareTo(sortedArray[tempIndex]) > 0)
                {
                    (sortedArray[tempIndex - 1], sortedArray[tempIndex]) = (sortedArray[tempIndex], sortedArray[tempIndex - 1]);
                    switch (tempIndex)
                    {
                        case 1:
                            break;
                        default:
                            tempIndex--;
                            break;
                    }
                }
                index++;
            }
        }

    }

    public List<T> Sort(T[] array)
    {
        if (array == null)
            throw new NullReferenceException();
        var result = new List<T>();
        if (array.Length == 1)
        {
            result.Add(array[0]);
            return result;
        }

        for (int i = 0; i < array.Length; i++)
        {
            var item = array[i];
            if (i == 0)
            {
                result.Add(item);
            }

            else
            {
                int tempIndex = i;
                result.Add(item);
                while (result[tempIndex].CompareTo(result[tempIndex-1]) > 0)
                {
                    (result[tempIndex-1],result[tempIndex])=(result[tempIndex],result[tempIndex-1]);
                    switch (tempIndex)
                    {
                        case 1:
                            break;
                        default:
                            tempIndex--;
                            break;
                    }
                }
            }
        }
        return result;
    }
}