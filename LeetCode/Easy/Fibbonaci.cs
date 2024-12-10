namespace LeetCode;

public class Fibbonaci
{
    //Using bottom-up approach ( Quy hoạch động )
    public static int Fib(int n) {
        if (n==0) return 0;
        if (n==1) return 1;
        int first = 0;
        int second = 1;
        int current = 0;
        for (int i = 2; i <= n; i++)
        {
            current = first + second;
            first = second;
            second = current;
        }
    
        return current;
    }
    
    //Using Matrix Exponentiation ( Ma trận nâng cao)
    // public static int Fib(int n)
    // {
    //     if (n == 0) return 0;
    //
    //     int[,] baseMatrix = { { 1, 1 }, { 1, 0 } };
    //     int[,] result = MatrixPower(baseMatrix, n - 1);
    //     return result[0, 0];
    // }
    //
    // private static int[,] MatrixPower(int[,] matrix, int n)
    // {
    //     int[,] result = { { 1, 0 }, { 0, 1 } }; // Ma trận đơn vị
    //     while (n > 0)
    //     {
    //         if (n % 2 == 1)
    //         {
    //             result = MultiplyMatrices(result, matrix);
    //         }
    //         matrix = MultiplyMatrices(matrix, matrix);
    //         n /= 2;
    //     }
    //     return result;
    // }
    //
    // private static int[,] MultiplyMatrices(int[,] a, int[,] b)
    // {
    //     return new int[,] {
    //         { a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0], a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1] },
    //         { a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0], a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1] }
    //     };
    // }
    
    //Using Binet's Formula ( Công thức Binet)
    // public static int Fib(int n)
    // {
    //     double sqrt5 = Math.Sqrt(5);
    //     double phi = (1 + sqrt5) / 2;
    //     return (int)Math.Round(Math.Pow(phi, n) / sqrt5);
    // }

}