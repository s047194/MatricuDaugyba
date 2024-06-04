using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricos
{
    public class Calculations
    {
        private int[,] _matrixA;
        private int[,] _matrixB;

        public Calculations(int[,] MatrixA, int[,] MatrixB)
        {
            _matrixA = MatrixA;
            _matrixB = MatrixB;
        }

        public int[,] Multiply()
        {
            int x1 = _matrixA.GetLength(0);
            int y1 = _matrixA.GetLength(1);
            int x2 = _matrixB.GetLength(0);
            int y2 = _matrixB.GetLength(1);

            if (y1 != x2)
                throw new InvalidOperationException("Matrix dimensions are not valid for multiplication.");

            int[,] result = new int[x1, y2];

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Parallel.For(0, x1, i =>
            {
                for (int j = 0; j < y2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < y1; k++)
                    {
                        sum += _matrixA[i, k] * _matrixB[k, j];
                    }
                    result[i, j] = sum;
                }
            });

            stopwatch.Stop();
            TimeSpan time = stopwatch.Elapsed;
            double timeMs = time.TotalMilliseconds;
            MessageBox.Show($"Laikas: {timeMs} ms");
            stopwatch.Reset();

            return result;
        }
    }
}
