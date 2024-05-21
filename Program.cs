using System;
namespace Activity2;
class Program
{
    private static int Main(string[] args)
    {
        DelegateExample example = new DelegateExample();
        DelegateExample.MathOperation operation = example.Add;
        int result = operation(10, 5);
        Console.WriteLine("Result of Add operation: " + result);
        operation = example.Subtract;
        result = operation(10, 5);
        Console.WriteLine("Result of Subtract operation: " + result);
        Console.ReadLine();

         DelegateExample example1 = new DelegateExample();

            DelegateExample.MathOperation operation1 = example1.Add;
            operation1 += example1.Subtract;

            int result = operation1(10, 5);
            Console.WriteLine($"Result of multicast delegate: {result}");

            DelegateExample.MathOperation operationWithResults = null;
            operationWithResults += (a, b) =>
            {
                int addResult = example1.Add(a, b);
                Console.WriteLine($"Addition result: {addResult}");
                return addResult;
            };
            operationWithResults += (a, b) =>
            {
                int subtractResult = example1.Subtract(a, b);
                Console.WriteLine($"Subtraction result: {subtractResult}");
                return subtractResult;
            };

            operationWithResults?.Invoke(10, 5);

            Console.ReadLine();
    }
}