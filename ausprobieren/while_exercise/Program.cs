// See https://aka.ms/new-console-template for more information
int i = 1;
while (i <= 10)
{
  for (int j = 1; j <= 10; j++)
  {
    Console.WriteLine($"{i} * {j} = {i * j}");
  }
  i++;
}

for (int zeile = 1; zeile <= 3; zeile++)
{
  for (int spalte = 1; spalte <= 5; spalte++)
  {
    Console.Write("#");
  }
  Console.WriteLine();
}


// class Program
// {
//   static void Main()
//   {
//     int size = 9; // Größe des Quadrats, kann beliebig geändert werden
//     PrintDiagonalPattern(size);
//   }
//
//   static void PrintDiagonalPattern(int size)
//   {
//     for (int i = 0; i < size; i++)
//     {
//       for (int j = 0; j < size; j++)
//       {
//         if (i == j)
//         {
//           Console.Write("#");
//         }
//         else
//         {
//           Console.Write(".");
//         }
//       }
//       Console.WriteLine();
//     }
//   }
// }
