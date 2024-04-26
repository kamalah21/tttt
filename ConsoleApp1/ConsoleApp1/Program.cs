#region #1
//int number   = 10;
//int[] numbers = { 100, 200, 300, 400 };

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);  
//}
#endregion
#region #2
//int[] numbers = { 100, 200, 300 };
//int sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i];
//};
//Console.WriteLine(sum);
#endregion
#region # 3 
//int[] numbers = { 100, 200, 300 };
//for (int i = numbers.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(numbers[i]);
//}
#endregion
#region # 4
//int[] numbers = { 100, 200, 300 };
//for (int i = 0; i < numbers.Length / 2; i++)
//{
//    int temp = numbers[i];
//    numbers[i] = numbers[numbers.Length - i - 1];
//    numbers[numbers.Length - i - 1] = temp;
//}
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}
#endregion
#region # 5 

//int max = 0;
//int[] numbers = { 100, 200, 300 };
//for (int i = 0; i < numbers.Length; i++)
//{
//        if (numbers[i] > max)
//          max = numbers[i];
//}
//Console.WriteLine(max);
#endregion
#region # 6
//int count = 0;
//int[] numbers = { 100, 200, 300 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    count++;
//}
//Console.WriteLine(count);
#endregion
#region # 7
//selection Sort

//int[] arr = { 1, 2, 3, 4,34,1,765,12,76, 5, 6 };
//int n = arr.Length; 
//Console.WriteLine("Selection sort");
//Console.Write("Initial array is: ");
//for (int i = 0; i < n; i++)
//{
//    Console.Write(arr[i] + " ");
//}
//int temp, smallest;
//for (int i = 0; i < n - 1; i++)
//{
//    smallest = i;
//    for (int j = i + 1; j < n; j++)
//    {
//        if (arr[j] < arr[smallest])
//        {
//            smallest = j;
//        }
//    }
//    temp = arr[smallest];
//    arr[smallest] = arr[i];
//    arr[i] = temp;
//}
//Console.WriteLine();
//Console.Write("Sorted array is: ");
//for (int i = 0; i < n; i++)
//{
//    Console.Write(arr[i] + " ");
//}
#endregion
#region # 8
//int count = 0 ;
//int[] numbers = { 100, 200, 300, 400 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);
#endregion
#region # 9
//int count = 0;
//int[] number = { 1, 2, 3, 4, 5, 7, 9 };
//for (int i = 0; i < number.Length; i++)
//{
//    if (number[i] < 0)
//    {
//        count++;
//    }

//}
//Console.WriteLine(count);
#endregion
#region # 10
//int sum = 0;
//int[] number = { 1, 2, 3, 4, 5, 6, 7 };
//for (int i = 0; i < number.Length; i++)
//{
//    if (number[i] > 0)
//    {
//        sum+= number[i];
//    }
//}
//Console.WriteLine(sum);
#endregion
#region # 11
//int[] number = { 1, 2, 4, 5 };
//for (int i = 0; i <number.Length; i++)
//{
//    Console.WriteLine(number[i] * number[i]);
//}
#endregion
#region # 12
//int[] arr = { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
//int n = arr.Length; ;

//int  smallest;
//for (int i = 0; i < n - 1; i++)
//{
//    smallest = i;
//    for (int j = i + 1; j < n; j++)
//    {
//        if (arr[j] < arr[smallest])
//        {
//            smallest = j;
//        }
//    }
//    int temp = arr[smallest];
//    arr[smallest] = arr[i];
//    arr[i] = temp;
//}
//for (int i = 0; i < arr.Length / 2; i++)
//{
//    int temp = arr[i];
//    arr[i] = arr[arr.Length - i - 1];
//    arr[arr.Length - i - 1] = temp;
//}
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}
#endregion
#region
//int[,] array =
//{
//    { 100,200,300},
//    {50,250,350 },
//    { 10,20,30}
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.WriteLine(array[i,j]);
//    }
//}
#endregion
#region
//int sum = 0;
//int[,] array =
//{
//      {150,200,300},
//      {50,400,250},

//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        sum+= array[i,j];
//    }
//}
//Console.WriteLine(sum);
#endregion
#region
//int sum = 0;
//int[,] array =
//{
//      { 0150,200,300},
//      {50,400,250},

//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (j == 0)
//        {
//            sum+= array[i,j];
//        }
//    }
//}
//Console.WriteLine(sum);
#endregion
using System.ComponentModel.Design;
using System.Threading.Channels;
#region
//int sum  = 0;
//int[,] array =
//{
//       {150,200,300},
//       {50,400,250},

//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (array[i,j] < 0 )
//                Console.WriteLine(array[i,j]);  

//    }
//}
#endregion
#region # 5 
//int[,] array =
//{
//     {150,200,300},
//     {50,400,250},

//};
//int max = array[0, 0];
//int min = array[0, 0];
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (array[i, j] > max)
//        {
//            max = array[i, j];


//        }
//        else if (array[i, j] < min) 


//        {
//            min = array[i, j];

//        }
//    }
//}
//Console.WriteLine(min);
//Console.WriteLine(max);
#endregion
#region
//int[,] array =
//{
//    {150,200,300},
//    {50,400,250},

//};
//for (int i = 0; i < array.Length; i++)
//{
//    for (int j = 0; j < array.Length; j++)
//    {
//        if (array[i, j] > 0 && array[i, j] % 2 == 0)
//        {
//            array[i, j] = 2;

//        }
//        else if (array[i, j] > 0 && array[i, j] % 2 == 1)
//        {
//            array[i, j] = 1;

//        }
//        else if (array[i, j] < 0 && array[i, j] % 2 == 0)
//        {
//            array[i, j] = -2;
//        }
//        else if (array[i, j] == 0)
//        {
//            array[i, j] = 0;
//        }
//        else
//        {
//            array[i, j] = -1;
//        }

//    }
//}
#endregion
//int[,] array =
//{
//  {100,200,300,876},
//    {123,234,456,544 },
//    {121,279,198,345},
//    {111,222,333,122},
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
// for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (i == 1)
//        {
//            array[i, j] = 0;
//        }

//        Console.Write(array[i,j] + " ");
//    }

//    Console.WriteLine();
//}
#region
//int[,] array =
//{
//{ 1,2,3 },
//{ 4,5, 6 },
//{ 7,8,9 },
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (i == 2)
//        {
//            array[i, j] = 0;
//        }
//        Console.Write(array[i, j] + " ");
//    }

//    Console.WriteLine();
//}
#endregion
#region
//int sum = 0;
//int[,] array =
//{
//{ 1,2,3 },
//{ 4,5,6 },
//{ 12,8,9 },
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (i == j)
//        {
//            sum += array[i, j];
//        }

//    }

//}
//Console.WriteLine(sum);
#endregion
#region
//int sum = 0;
//int[,] array =
//{
//{1,2, 3,4 },
//{5,6,7,8},
//{9,10,11,12},
//{13,14,15,16},
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (j == i)
//        {
//            sum += array[i,j];
//        }
//    }
//}
//Console.WriteLine(sum);
#endregion
#region

//int[,] array =
//{
//{1,2,3,4,5},
//{6,7,8,9,10 },
//{11,12,13,14,15},
//{16,17,18,19,20},
//{21,22,23,24,25},
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (j == i)
//        {
//            break;
//        }

//        Console.Write(array[i, j] + " ");

//    }

//    Console.WriteLine();
//}
#endregion
#region

//int[,] array =
//{
//{1,2,3,4,5},
//{6,7,8,9,10 },
//{11,12,13,14,15},
//{16,17,18,19,20},
//{21,22,23,24,25},
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (i == j)
//        {
//            break;
//        }

//        Console.Write(array[i, j] + " ");

//    }

//    Console.WriteLine();
//}
#endregion
#region
//int[,] array1 =
//{
//{1,2,3 },
//{4,5,6 },
//};
//int[,] array2 =
//{
//{7,8,9 },
//{10,11,12 },
//};
//int[,] array3 = new int[2, 3];
//for (int i = 0; i < array1.GetLength(0); i++)
//{
//    for (int j = 0; j < array2.GetLength(1); j++)
//    {
//        array3[i, j] = array1[i, j] + array2[i, j];


//        Console.Write(array3[i, j] + " ");
//    }


//        Console.WriteLine();

//}
#endregion
#region   # 14
//int[,] array =
//{
//{ 1,2,3},
//{4,6,7},
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    int sum = 0;
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        sum += array[i, j];
//    }
//    Console.WriteLine(sum);

//}
#endregion
#region # 15 
//int[,] array =
//{
//{ 1,2,3},
//{4,6,7},
//};
//int sum = 0;
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {

//        sum += array[i, j];
//    }
//    Console.WriteLine(sum);
//}
#endregion
#region # 16 
//int[,] array =
//{
//   {1, 1, 0, 0, 1, 1},
//   {1, 1, 0, 0, 1, 1},
//   {1, 1, 0, 0, 1, 1},
//   {1, 1, 0, 0, 1, 1},
//};
//int shift = 3;
//for (int i = 0; i < array.GetLength(0); i++)
//{
//	for (int  j = array.GetLength(1) - 1; j >= 0; j--)
//	{
//		if (j - shift >= 0)
//		{
//			array[i, j] = array[i, j - shift];
//		}
//		else
//		{
//			array[i, j] = 0;
//		}

//	}
//}
//for (int i = 0; i < array.GetLength(0); i++)
//{
//	for (int j = 0; j < array.GetLength(1); j++)
//	{
//		Console.Write($"{array[i, j]}");
//	}
//    Console.WriteLine();
//}
#endregion
#region
//int[,] array1 =
//{
//{1,2,3},
//{4,5,6 }, 
//};
//int[,] array2 =
//{
//{7,8,9},
//{10,11,12},
//};

//int[,] array3 = new int[2,3];
//for (int i = 0; i < array1.GetLength(0); i++)
//{
//    for (int j = 0; j < array2.GetLength(1); j++)
//    {
//        array3[i, j] = array1[i, j] * array2[i,j];
//        Console.Write(array3[i,j] + " ");
//    }
//    Console.WriteLine();

//}
#endregion