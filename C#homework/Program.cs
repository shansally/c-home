

    namespace hw_array
    {
        internal class Program
        {
            public static void practice5_1()
            {
                //利用一維陣列求10個數字的計算平均值

                double[] x = new double[10];

                Console.WriteLine("請輸入10個數字:");

                for (int i = 0; i < x.Length; i++)
                {
                    Console.WriteLine($"第{i + 1}個數字:");
                    x[i] = Convert.ToDouble(Console.ReadLine());
                }
                //計算平均值
                double sum = 0;
                foreach (var item in x)
                {
                    sum += item;
                }
                Console.WriteLine($"平均值為:{sum / 10}");
                Console.ReadKey();
            }

            public static void practice5_2()
            {
                //利用一維陣列求10個數字的最大值

                double[] x = new double[10];
                double max = double.MinValue;

                Console.WriteLine("請輸入10個數字:");

                for (int i = 0; i < x.Length; i++)
                {
                    Console.WriteLine($"第{i + 1}個數字:");
                    x[i] = Convert.ToDouble(Console.ReadLine());
                    if (x[i] > max)
                    { max = x[i]; }
                }
                Console.WriteLine($"最大值為:{max}");
            }

            public static void practice5_3()
            {
                //輸入10個數字至A[]，再輸入x，判斷x是否存在於A陣列中，如果存在，輸出所在的註標(索引)值，若不存在，則告知不存在

                double[] array1 = new double[10];
                Console.WriteLine("請輸入10個數字:");
                for (int i = 0; i < array1.Length; i++)
                {
                    Console.WriteLine($"請輸入第{i + 1}個數字:");
                    array1[i] = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("請輸入x值,查詢是否在此10個數字中:");
                double x = Convert.ToDouble(Console.ReadLine());
                bool found = false;
                for (int i = 0; i < 10; i++)
                {
                    if (array1[i] == x)
                    {
                        found = true;
                        Console.WriteLine($"{x}在此陣列中");
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine($"{x}不在此陣列中");
                }
            }

            public static void practice5_4()
            {
                //兩個二維矩陣相加。以陣列模擬矩陣，求兩個2乘3的二維矩陣相加之結果，第一個及第二個矩陣分別以A及B表示，相加之結果存入C矩陣，最後將C矩陣內容顯示出來
                double[,] A = new double[2, 3];
                double[,] B = new double[2, 3];
                double[,] C = new double[2, 3];

                Console.WriteLine("兩個二維矩陣相加,分別以A及B表示，相加之結果存入C矩陣");
                //A矩陣
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"請輸入A矩陣,第{i + 1}行第{j + 1}列的數字:");
                        A[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
                }
                //B矩陣
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"請輸入B矩陣,第{i + 1}第{j + 1}的數字:");
                        B[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
                }
                //C矩陣
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        C[i, j] = A[i, j] + B[i, j];
                        Console.Write($"C矩陣第{i + 1}行第{j + 1}列的值為:");
                        Console.WriteLine(C[i, j]);
                    }
                }
                Console.ReadKey();
            }


            public static void practice5_5()
            {
                //兩個矩陣相乘。求2乘3的A矩陣乘以3乘1的B矩陣，結果存入2乘1的C矩陣，最後將C矩陣的內容顯示出來

                int[,] A = new int[2, 3];
                int[,] B = new int[3, 1];
                int[,] C = new int[2, 1];

                Console.WriteLine("請輸入A矩陣的值(2x3):");
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"請輸入A{i + 1},{j + 1}的值:");
                        A[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("請輸入B矩陣的值(3x1):");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        Console.WriteLine($"請輸入B{i + 1},{j + 1}的值:");
                        B[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                //C
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        C[i, j] = 0;
                        for (int k = 0; k < 3; k++)
                        {
                            C[i, j] += A[i, k] * B[k, j];

                        }
                    }

                }

                Console.WriteLine("C矩陣為:");
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        Console.WriteLine($"c[{i + 1},{j + 1}]={C[i, j]}");
                    }
                }
            }


            public static void hw5_1()
            {
                //寫一程式，將10個數字讀入A陣列，然後逐一檢查此陣列，如A[i]>5，則令A[i]=A[i]-5，否則A[i]=A[i]+5

                double[] A = new double[10];
                Console.WriteLine("請輸入10個數字:");
                for (int i = 0; i < A.Length; i++)
                {
                    Console.WriteLine($"請輸入第{i + 1}個數字:");
                    A[i] = Convert.ToDouble(Console.ReadLine());
                }
                for (int i = 0; i < A.Length; i++)
                {
                    //if (A[i] > 5)
                    //{ A[i] -= 5; }
                    //else
                    //{ A[i] += 5; }
                    A[i] = A[i] > 5 ? A[i] - 5 : A[i] + 5;

                }
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write($"經過處理後,第{i + 1}個數字為:");
                    Console.WriteLine(A[i]);
                }
            }

            public static void hw5_2()
            {
                //寫一程式，將10個數字讀入A陣列，對每一個數字，令A[i] = A[i] + i

                double[] A = new double[10];
                Console.WriteLine("請輸入10個數字:");
                for (int i = 0; i < A.Length; i++)
                {
                    Console.WriteLine($"請輸入第{i + 1}個數字:");
                    A[i] = Convert.ToDouble(Console.ReadLine());
                    A[i] += i;
                }
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write($"經過處理後,A陣列值第{i + 1}個數字為:");
                    Console.WriteLine(A[i]);
                }
            }

            public static void hw5_3()
            {
                //寫一程式，將10個數字讀入A陣列，並建立一個B陣列，如A[i]≥0，令B[i] = 1，否則令B[i] = 0

                double[] A = new double[10];
                double[] B = new double[10];
                Console.WriteLine("請輸入10個數字:");
                for (int i = 0; i < A.Length; i++)
                {
                    Console.WriteLine($"請輸入第{i + 1}個數:");
                    A[i] = Convert.ToDouble(Console.ReadLine());
                }
                for (int i = 0; i < A.Length; i++)
                {
                    //if (A[i] >= 0)
                    //{ B[i] = 1; }
                    //else
                    //{ B[i] = 0; }
                    B[i] = A[i] >= 0 ? 1 : 0;


                }
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write($"經過處理後,A陣列值第{i + 1}個數字為:");
                    Console.WriteLine(B[i]);
                }
            }


            public static void hw5_4()
            {
                //寫一程式，將15數字存入3×5的二維陣列A中，求每一行及每一列數字的和

                double[,] A = new double[3, 5];

                Console.WriteLine("請輸入15個數:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine($"請輸入A陣列第{i + 1}行第{j + 1}列的值:");
                        A[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
                }
                //計算每行之和
                for (int i = 0; i < 3; i++)
                {
                    double sum = 0;
                    for (int j = 0; j < 5; j++)
                    {
                        sum += A[i, j];
                    }
                    Console.WriteLine($"第{i + 1}行的和為:");
                    Console.WriteLine(sum);
                }
                //計算每列之和
                for (int j = 0; j < 5; j++)
                {
                    double sum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        sum += A[i, j];
                    }
                    Console.WriteLine($"第{j + 1}列的和為:");
                    Console.WriteLine(sum);
                }

                Console.ReadLine();
            }

            public static void hw5_5()
            {
                //寫一程式，將15數字存入3×5的二維陣列A中，求每一行及每一列數字的最小值

                double[,] A = new double[3, 5];

                Console.WriteLine("請輸入15個數:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine($"請輸入第{i + 1}行第{j + 1}列的值:");
                        A[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
                }
                //求每行最小值
                for (int i = 0; i < 3; i++)
                {
                    double min = double.MaxValue;
                    for (int j = 0; j < 5; j++)
                    {
                        if (A[i, j] < min)
                        { min = A[i, j]; }
                    }
                    Console.Write($"第{i + 1}行的最小值為:");
                    Console.WriteLine(min);
                }
                //求每列最小值
                for (int j = 0; j < 5; j++)
                {
                    double min = double.MaxValue;
                    for (int i = 0; i < 3; i++)
                    {
                        if (A[i, j] < min)
                        { min = A[i, j]; }
                    }
                    Console.Write($"第{j + 1}列的最小值為:");
                    Console.WriteLine(min);
                }
                Console.ReadKey();
            }


            public static void hw5_6()
            {
                //寫一程式，輸入兩組數字：a1,a2,…,a5和b1,b2,…,b5。求ai + bi，i = 1到i = 5

                double[] a = new double[5];
                double[] b = new double[5];
                double[] result = new double[5];
                Console.WriteLine("請輸入A陣列的五個數字:");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine($"請輸入A陣列的第{i + 1}個數:");
                    a[i] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("請輸入B陣列的五個數字:");
                for (int j = 0; j < a.Length; j++)
                {
                    Console.WriteLine($"請輸入B陣列的第{j + 1}個數:");
                    b[j] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("兩者相加的和為:");
                for (int i = 0; i < 5; i++)
                {
                    result[i] = a[i] + b[i];
                    Console.WriteLine($"a{i + 1}+ b{i + 1}的和為:{result[i]}");
                }
                Console.WriteLine();
            }


            public static void hw5_7()
            {
                //寫一程式，輸入兩組數字： a1,a2,…,a5和b1,b2,…,b5。令x為a中的最大值，令y為b中的最大值，求x與y中較小者

                double[] a = new double[5];
                double[] b = new double[5];
                double[] result = new double[5];
                Console.WriteLine("請輸入A陣列的五個數字:");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine($"請輸入A陣列的第{i + 1}個數:");
                    a[i] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("請輸入B陣列的五個數字:");
                for (int j = 0; j < a.Length; j++)
                {
                    Console.WriteLine($"請輸入B陣列的第{j + 1}個數:");
                    b[j] = Convert.ToDouble(Console.ReadLine());
                }

                double x = double.MinValue;
                double y = double.MinValue;
                Console.WriteLine("令x為a中的最大值，令y為b中的最大值，求x與y中較小者");
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > x)
                    { x = a[i]; }
                }
                for (int j = 0; j < b.Length; j++)
                {
                    if (b[j] > y)
                    { y = b[j]; }

                }
                if (x > y)
                { Console.WriteLine($"兩者中較小的是:{y}"); }
                else if (x < y)
                { Console.WriteLine($"兩者中較小的是{x}"); }
                else
                { Console.WriteLine("兩者相等"); }
            }



            static void Main(string[] args)
            {

                practice5_1();
                practice5_2();
                practice5_3();
                practice5_4();
                practice5_5();
                hw5_1();
                hw5_2();
                hw5_3();
                hw5_4();
                hw5_5();
                hw5_6();
                hw5_7();



                //陣列名稱宣告
                //int[] number=new int [3]{ 22,44,66};
                // foreach (int i in number) 
                // { Console.WriteLine(i); }
                // Console.ReadKey();

                //int[] helloarray=new int[2];
                //for(int i = 0; i < helloarray.Length; i++)
                //{ helloarray[i] = Convert.ToInt32(Console.ReadLine()); }
                //Console.WriteLine();

                //Length取得陣列所有長度

                //int[,] A = new int[2, 2] { { 1, 2 }, { 3, 4 } };
                //int[,] B = new int[2, 2] { { 1, 2 }, { 3, 4 } };
                //int[,] C = new int[2, 2];
                //for (int i = 0; i < 2; i++)
                //{
                //    for (int j = 0; j < 2; i++)
                //    {
                //        C[i, j] = A[i, j] + B[i, j];
                //    }
                //}

                //Console.ReadLine();


                //int[,] a = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
                //int[,] b = new int[3, 1] { { 1 }, { 2 }, { 3 } };
                //for (int i = 0; i < 2; i++)
                //{
                //    for (int j = 0; j < 2; j++)
                //    {
                //    }
                //}
            }
        }
    }


