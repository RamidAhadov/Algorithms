using Operations.Abstractions;

namespace Operations;

public class Divide : IOperation
{
    public int Calculate(int number1, int number2)
    {
        if (number2 == 0)
        {
            throw new DivideByZeroException();
        }
        
        return RecursiveDivide(number1, number2, 0);
    }

    public int CalculateWithoutOptimization(int number1, int number2)
    {
        if (number2 == 0)
        {
            throw new DivideByZeroException();
        }

        int count = 0;
        while (number1 > number2)
        {
            number1 -= number2;
            count++;
        }

        return count;
    }

    private int RecursiveDivide(int number1, int number2, int result)
    {
        int divider = number2;
        int step = 1;
        while (number1 >= divider)
        {
            number1 -= divider;
            divider += divider;
            result += step;
            step += step;
        }

        if (number1 >= number2)
        {
            return RecursiveDivide(number1, number2, result);
        }
        
        return result;
    }
}