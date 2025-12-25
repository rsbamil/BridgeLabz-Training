using System;

class MatrixUtility{
    public static double[,] CreateRandomMatrix(int rows, int cols)
    {
        double[,] m = new double[rows, cols];
        Random r = new Random();

        for (int i = 0; i < rows; i++){
            for (int j = 0; j < cols; j++){
                m[i, j] = r.Next(1, 10); 
            } 
        }   
        return m;
    }

    public static void Display(double[,] m){
        int r = m.GetLength(0);
        int c = m.GetLength(1);

        for (int i = 0; i < r; i++){
            for (int j = 0; j < c; j++){
                Console.Write(m[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static double[,] Add(double[,] A, double[,] B){
        int r = A.GetLength(0);
        int c = A.GetLength(1);
        double[,] R = new double[r, c];

        for (int i = 0; i < r; i++){
            for (int j = 0; j < c; j++){
                R[i, j] = A[i, j] + B[i, j];
            }
        }

        return R;
    }

    public static double[,] Subtract(double[,] A, double[,] B){
        int r = A.GetLength(0);
        int c = A.GetLength(1);
        double[,] R = new double[r, c];

        for (int i = 0; i < r; i++){
            for (int j = 0; j < c; j++){
                R[i, j] = A[i, j] - B[i, j];
            }
        }

        return R;
    }

    public static double[,] Multiply(double[,] A, double[,] B){
        int r1 = A.GetLength(0);
        int c1 = A.GetLength(1);
        int c2 = B.GetLength(1);

        double[,] R = new double[r1, c2];

        for (int i = 0; i < r1; i++){
            for (int j = 0; j < c2; j++){
                for (int k = 0; k < c1; k++){
                    R[i, j] += A[i, k] * B[k, j];
                }
            }
        }
        return R;
    }

    public static double[,] Transpose(double[,] M){
        int r = M.GetLength(0);
        int c = M.GetLength(1);
        double[,] T = new double[c, r];

        for (int i = 0; i < r; i++){
            for (int j = 0; j < c; j++){
                T[j, i] = M[i, j];
                }
     }
        return T;
    }

    public static double Det2(double[,] m){
        return m[0,0] * m[1,1] - m[0,1] * m[1,0];
    }

    public static double Det3(double[,] m){
        return m[0,0]*(m[1,1]*m[2,2]-m[1,2]*m[2,1])
             - m[0,1]*(m[1,0]*m[2,2]-m[1,2]*m[2,0])
             + m[0,2]*(m[1,0]*m[2,1]-m[1,1]*m[2,0]);
    }

    public static double[,] Inverse2(double[,] m){
        double det = Det2(m);
        double[,] inv = new double[2,2];

        inv[0,0] =  m[1,1]/det;
        inv[0,1] = -m[0,1]/det;
        inv[1,0] = -m[1,0]/det;
        inv[1,1] =  m[0,0]/det;

        return inv;
    }

    public static double[,] Inverse3(double[,] m){
        double det = Det3(m);
        double[,] inv = new double[3,3];

        inv[0,0] =  (m[1,1]*m[2,2]-m[1,2]*m[2,1])/det;
        inv[0,1] = -(m[0,1]*m[2,2]-m[0,2]*m[2,1])/det;
        inv[0,2] =  (m[0,1]*m[1,2]-m[0,2]*m[1,1])/det;

        inv[1,0] = -(m[1,0]*m[2,2]-m[1,2]*m[2,0])/det;
        inv[1,1] =  (m[0,0]*m[2,2]-m[0,2]*m[2,0])/det;
        inv[1,2] = -(m[0,0]*m[1,2]-m[0,2]*m[1,0])/det;

        inv[2,0] =  (m[1,0]*m[2,1]-m[1,1]*m[2,0])/det;
        inv[2,1] = -(m[0,0]*m[2,1]-m[0,1]*m[2,0])/det;
        inv[2,2] =  (m[0,0]*m[1,1]-m[0,1]*m[1,0])/det;

        return inv;
    }
}

class Matrix{
    static void Main(){
        double[,] A = MatrixUtility.CreateRandomMatrix(3,3);
        double[,] B = MatrixUtility.CreateRandomMatrix(3,3);

        Console.WriteLine("Matrix A:");
        MatrixUtility.Display(A);

        Console.WriteLine("\nMatrix B:");
        MatrixUtility.Display(B);

        Console.WriteLine("\nA + B:");
        MatrixUtility.Display(MatrixUtility.Add(A,B));

        Console.WriteLine("\nA - B:");
        MatrixUtility.Display(MatrixUtility.Subtract(A,B));

        Console.WriteLine("\nA x B:");
        MatrixUtility.Display(MatrixUtility.Multiply(A,B));

        Console.WriteLine("\nTranspose of A:");
        MatrixUtility.Display(MatrixUtility.Transpose(A));

        Console.WriteLine("\nDeterminant of A = " + MatrixUtility.Det3(A));

        Console.WriteLine("\nInverse of A:");
        MatrixUtility.Display(MatrixUtility.Inverse3(A));
    }
}
