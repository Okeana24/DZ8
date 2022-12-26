int a = 4;
int[,] sqareMatrix = new int[a, a];

int temp = 1;
int b = 0;
int B = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[b, B] = temp;
  temp++;
  if (b <= B + 1 && b + B < sqareMatrix.GetLength(1) - 1)
    B++;
  else if (b < B && b + B >= sqareMatrix.GetLength(0) - 1)
    b++;
  else if (b >= B && b + B > sqareMatrix.GetLength(1) - 1)
    B--;
  else
    b--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int b = 0; b < array.GetLength(0); b++)
  {
    for (int B = 0; B < array.GetLength(1); B++)
    {
      if (array[b,B] / 10 <= 0)
      Console.Write($" {array[b,B]} ");

      else Console.Write($"{array[b,B]} ");
    }
    Console.WriteLine();
  }
}
  
