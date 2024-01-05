// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Algorithms.InsertionSort;

Console.WriteLine("Hello, World!");


List<int> list = new List<int>
{
  //6,7,4,2,8,9,4,2,21,1  
};

Random random = new Random();
for (int i = 0; i < 1000000; i++)
{
  if (random.Next(0,i) == 8)
  {
    Console.WriteLine(i);
  }
  //list.Add(random.Next(0,100000));
}

//sort.Sort(list);
var arr = new int[100];
for (int i = 0; i < 100; i++)
{
  arr[i] = random.Next(0, 1000);
}

InsertionSort<int> insertionSort = new InsertionSort<int>();

var sortedList = insertionSort.Sort(arr);



Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();
//insertionSort.Sort(list);
Thread.Sleep(997);

stopwatch.Stop();
Console.WriteLine(stopwatch.ElapsedMilliseconds);


int index = 0;

foreach (var i in list)
{
  index++;
  //Console.WriteLine(index);
}


