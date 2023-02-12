// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] arr;
arr=new int[8];
Random random=new Random();
for(int i=0;i<arr.Length;i++)
arr[i]=random.Next(100,250);

for(int i=0;i<arr.Length;i++)
System.Console.WriteLine(arr[i]);

int s=0; int m=0;
for(int i=0;i<arr.Length;i++)
  if (arr[i]%2==0)
  {s=s+1;
  }
  else 
  m=m+1;

System.Console.WriteLine($"Количество чётных чисел = {s}");
System.Console.WriteLine($"Количество нечетных чисел = {m}");