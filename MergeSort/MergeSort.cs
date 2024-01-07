namespace Algorithms.MergeSort;

public class MergeSort<T> where T:IComparable
{
    public void Sort(T[] array)
    {
        if (array.Length == 0)
            throw new NullReferenceException();
        if (array.Length == 1)
            return;
        bool isEven = array.Length % 2 == 0;
        int mid = array.Length / 2;
        T[] left;
        T[] right;
        if (isEven)
        {
            left = new T[mid];
            right = new T[mid];
        }
        else
        {
            left = new T[mid];
            right = new T[array.Length - mid];
        }

        for (int i = 0; i < mid; i++)
        {
            left[i] = array[i];
        }

        int k = 0;
        for (int i = mid; i < array.Length; i++)
        {
            right[k] = array[i];
            k++;
        }
        
        Sort(left);
        Sort(right);
        
        Merge(array,left,right);
    }

    private void Merge(T[] array,T[] left,T[] right)
    {
        int i = 0, j = 0, k = 0;
        while (i < left.Length && j < right.Length)
        {
            if (left[i].CompareTo(right[j]) < 0)
            {
                array[k] = left[i];
                k++;
                i++;
            }
            else
            {
                array[k] = right[j];
                k++;
                j++;
            }
        }

        while (j < right.Length)
        {
            array[k] = right[j];
            k++;
            j++;
        }

        while (i < left.Length)
        {
            array[k] = left[i];
            k++;
            i++;
        }
    }
}