using System.ComponentModel;

static double Determinant(double[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    if (rows != columns)
        throw new ArgumentException("Матрица должна быть квадратной");

    double det = 0;

    if (rows == 2)
    {
       
        det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }
    else
    {
        
        for (int j = 0; j < columns; j++)
        {
            double[,] submatrix = new double[rows - 1, columns - 1];

            for (int i = 1; i < rows; i++)
            {
                for (int k = 0; k < columns; k++)
                {
                    if (k < j)
                        submatrix[i - 1, k] = matrix[i, k];
                    else if (k > j)
                        submatrix[i - 1, k - 1] = matrix[i, k];
                }
            }

            det += Math.Pow(-1, j) * matrix[0, j] * Determinant(submatrix);
        }
    }
    return det;
}
Console.WriteLine("Введите размерность матрицы");
int n=Int32.Parse(Console.ReadLine());
double[,] mat = new double[n,n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        mat[i, j] = Convert.ToDouble(Console.ReadLine());
    }
}
Console.WriteLine(Determinant(mat));