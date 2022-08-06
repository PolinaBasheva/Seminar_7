Задача 47.
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

CreateArrayDouble(array);

WriteArray(array);

Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int k = 0; k < n; k++)
    {
      array[i, k] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] array){
for (int i = 0; i < m; i++)
  {
      for (int k = 0; k < n; k++)
      {
        double nNumber = Math.Round(array[i, k], 1);
        Console.Write(nNumber + " ");
      }
      Console.WriteLine();
  }
}

Задача 50.
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

CreateArrayDouble(array);

WriteArray(array);

Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int k = 0; k < n; k++)
    {
      array[i, k] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] array){
for (int i = 0; i < m; i++)
  {
      for (int k = 0; k < n; k++)
      {
        double nNumber = Math.Round(array[i, k], 1);
        Console.Write(nNumber + " ");
      }
      Console.WriteLine();
  }
}

Console.Write("Введите координаты позиции элемента, разделенных запятой: ");

string positionElement = Console.ReadLine();
positionElement = RemovingSpaces(positionElement);
int[] position = ParserString(positionElement);

if(position[0] <= m 
&& position[1] <= n 
&& position[0] >= 0 
&& position[1] >= 0) 
{
  double result = array[position[0]-1, position[1]-1];
  Console.Write($"Значение элемента: {result}");
}
else Console.Write($"такого элемента в массиве нет.");

int[] ParserString(string input)
{
  int countNumbers = 1;
  for (int i = 0; i < input.Length; i++)
  {
      if (input[i] == ',')
          countNumbers++;
  }

  int[] numbers = new int[countNumbers];

  int numberIndex = 0;
  for(int i = 0; i < input.Length; i++)
  {
    string subString = String.Empty;

    while (input[i] != ',')
    {
      subString += input[i].ToString();
      if (i >= input.Length - 1)
        break;
      i++;
    }
    numbers[numberIndex] = Convert.ToInt32(subString);
    numberIndex++;
  }

  return numbers;
}

string RemovingSpaces (string input)
{
  string output = String.Empty;
  for (int i = 0; i < input.Length; i++)
  {
    if (input[i] != ' ') 
    {
      output += input[i];
    }
  }
  return output;
}

Задача 52.
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

CreateArrayDouble(array);

WriteArray(array);

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int k = 0; k < n; k++)
    {
      array[i, k] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] array){
for (int i = 0; i < m; i++)
  {
      for (int k = 0; k < n; k++)
      {
        double nNumber = Math.Round(array[i, k], 1);
        
      }
      
  }
}


int[,] arrayN = new int[m, n];
arrayN = TransformationArrayN(array);

WriteArrayInt(arrayN);

Console.Write("Cреднее арифметическое значение:");
for (int i = 0; i < n; i++)
{
  double MathsMean = 0;
  for (int k = 0; k < m; k++)
  {
    MathsMean += arrayN[k, i];
  }
  MathsMean = Math.Round(MathsMean / m, 1);
  Console.WriteLine($"столбца № {i+1} {MathsMean}");
}

int[,] TransformationArrayN (double[,] array)
{
  int[,] arrayN = new int[array.GetLength(0), array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int k = 0; k < array.GetLength(1); k++)
    {
      arrayN[i, k] = Convert.ToInt32(array[i, k]);
    }
  }
  return arrayN;
}

void WriteArrayInt (int[,] arrayN){
for (int i = 0; i < m; i++)
  {
      for (int k = 0; k < n; k++)
      {
        Console.Write(arrayN[i, k] + " ");
      }
      Console.WriteLine();
  }
}Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

CreateArrayDouble(array);

WriteArray(array);

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int k = 0; k < n; k++)
    {
      array[i, k] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] array){
for (int i = 0; i < m; i++)
  {
      for (int k = 0; k < n; k++)
      {
        double nNumber = Math.Round(array[i, k], 1);
        
      }
      
  }
}


int[,] arrayN = new int[m, n];
arrayN = TransformationArrayN(array);

WriteArrayInt(arrayN);

Console.Write("Cреднее арифметическое значение:");
for (int i = 0; i < n; i++)
{
  double MathsMean = 0;
  for (int k = 0; k < m; k++)
  {
    MathsMean += arrayN[k, i];
  }
  MathsMean = Math.Round(MathsMean / m, 1);
  Console.WriteLine($"столбца № {i+1} {MathsMean}");
}

int[,] TransformationArrayN (double[,] array)
{
  int[,] arrayN = new int[array.GetLength(0), array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int k = 0; k < array.GetLength(1); k++)
    {
      arrayN[i, k] = Convert.ToInt32(array[i, k]);
    }
  }
  return arrayN;
}

void WriteArrayInt (int[,] arrayN){
for (int i = 0; i < m; i++)
  {
      for (int k = 0; k < n; k++)
      {
        Console.Write(arrayN[i, k] + " ");
      }
      Console.WriteLine();
  }
}
