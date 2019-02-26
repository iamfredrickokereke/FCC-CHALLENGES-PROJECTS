Using foreach with arrays (C# Programming Guide)
05/23/2018
2 minutes to read
Contributors
Bill Wagner  NextTurn  pkulikov  Aymeric A  Maira Wenzel all
The foreach statement provides a simple, clean way to iterate through the elements of an array.

For single-dimensional arrays, the foreach statement processes elements in increasing index order, starting with index 0 and ending with index Length - 1:

C#

Copy
int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
foreach (int i in numbers)
{
    System.Console.Write("{0} ", i);
}
// Output: 4 5 6 1 2 3 -2 -1 0
For multi-dimensional arrays, elements are traversed such that the indices of the rightmost dimension are increased first, then the next left dimension, and so on to the left:

C#

Copy
int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
// Or use the short form:
// int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } };

foreach (int i in numbers2D)
{
    System.Console.Write("{0} ", i);
}
// Output: 9 99 3 33 5 55
However, with multidimensional arrays, using a nested for loop gives you more control over the order in which to process the array elements.


