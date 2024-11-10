using Operations.Abstractions;

namespace Operations;

public class Multiply : IOperation
{
    public int Calculate(int number1, int number2)
    {
        if (number1 == 0 || number2 == 0)
        {
            return 0;
        }
        
        return RecursiveMultiply(number1, number2, 0);
    }

    public int CalculateWithoutOptimization(int number1, int number2)
    {
        if (number1 == 0 || number2 == 0)
        {
            return 0;
        }

        int addedNumber = number1;
        while (number2 > 1)
        {
            number1 += addedNumber;
            number2--;
        }

        return number1;
    }

    private int RecursiveMultiply(int number1, int number2, int result)
    {
        int addedNum = number1;
        int count = 1;
        while (number2 > 0)
        {
            result += addedNum;
            addedNum += addedNum;
            number2 -= count;
            count += count;
            
            if (number2 < count)
            {
                return RecursiveMultiply(number1, number2, result);
            }
        }

        return result;
    }
}