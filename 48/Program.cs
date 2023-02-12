/* Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10.
 Создайте массив, который является произведением пар чисел в одномерном массиве a. 
 Парой считаем первый и последний элемент, второй и предпоследний и т.д.
а) вариант когда в массиве четное кол-во элементов
б) * вариант когда в массиве и четное и не четное кол-во элементов */
int [] a;
a=new int[5];
Random random =new Random();
for (int i=0;i!=a.Length;i++)
 a[i]=random.Next(1,10);

 for (int i=0;i!=a.Length;i++)
  Console.WriteLine(a[i]);

int[] b;
int length=a.Length;
if (length%2==0)
{ b=new int[a.Length/2];
for (int i=0;i<=length/2;i++)
b[i]=a[i]*a[length-1];
length=length-1;
System.Console.WriteLine($"{b[0]} {b[1]} {b[2]} {b[3]} {b[4]}");
}
else b=new int[a.Length/2+1];
for (int i=0;i<=length/2+1;i++)
{
b[i]=a[i]*a[length-1];
length=length-1;
System.Console.WriteLine($"{b[i]}");
}
