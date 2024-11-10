namespace Operations.Abstractions;

public interface IOperation
{
    int Calculate(int number1, int number2);
    int CalculateWithoutOptimization(int number1, int number2);
}