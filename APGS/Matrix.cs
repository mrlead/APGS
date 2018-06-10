using System.Windows.Forms;

namespace APGS
{
    class Matrix
    {
        public double [,] element { get; set; }
        public int cols { get; set; }
        public int rows { get; set; }

        public Matrix(int rows, int cols)
        {
            element = new double[rows, cols];
            this.cols = cols;
            this.rows = rows;
        }

        public Matrix(int dim)
        {
            element = new double[dim, dim];
            cols = rows = dim;
            for(int i = 0; i < dim; i++)
            {
                for(int j = 0; j < dim; j++)
                {
                    element[i, j] = (i == j ? 1 : 0);
                }
            }
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if(m1.cols != m2.rows)
            {
                MessageBox.Show("m1 должно быть ровно m2");
                return null;
            }
            else
            {
                Matrix result = new Matrix(m1.rows, m2.cols);
                for(int q = 0; q < result.rows; q++)
                {
                    for(int i = 0; i < result.cols; i++)
                    {
                        for(int j = 0; j < result.rows; j++)
                        {
                            result.element[q, i] += m1.element[q, j] * m2.element[j, i];
                        }
                    }
                }
                return result;
            }
        }

        public static Matrix operator *(Matrix matrix, int m)
        {
            Matrix result = new Matrix(matrix.rows, matrix.cols);
            for(int i = 0; i < matrix.rows; i++)
            {
                for(int j = 0; j < matrix.cols; j++)
                {
                    result.element[i, j] = matrix.element[i, j] * m;
                }
            }
            return result;
        }

        public Matrix transpose(Matrix matrix)
        {
            Matrix result = new Matrix(matrix.rows, matrix.cols);
            for(int i = 0; i < matrix.rows; i++)
            {
                for(int j = 0; j < matrix.cols; j++)
                {
                    result.element[j, i] = matrix.element[i, j];
                }
            }
            return result;
        }
    }
}
