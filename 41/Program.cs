// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int[] arr;
arr=new int[5];
Random random=new Random();
for(int i=0;i<arr.Length;i++)
arr[i]=random.Next(0,2);

for(int i=0;i<arr.Length;i++)
Console.WriteLine(arr[i]);

 

