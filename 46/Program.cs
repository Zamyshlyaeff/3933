/* Создать массив из 123 элементов. Заполнить 
случайными положительными числами от 0 до 1000. 
Найти количество элементов которые принадлежат отрезку [10,99].*/
int[] arr;
arr=new int[122];
Random random=new Random();
for(int i=0;i<arr.Length;i++)
arr[i]=random.Next(0,1000);

for(int i=0;i<arr.Length;i++)
if (arr[i]>10 && arr[i]<99)
System.Console.WriteLine(arr[i]);

int s=0;
for(int i=0;i<arr.Length;i++)
   if (arr[i]>10 && arr[i]<99)
  {s=s+1;
  }

System.Console.WriteLine($"Количество элементов' = {s}");

