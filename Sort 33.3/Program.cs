﻿int sort = 0;
int Even;
int Odd;

for (int i = 1; i <= 100; i++)
{


    sort = i;
   
    if (sort % 2 == 0)
    {
        Even = i;
        Console.Write(Even + " ");
    }
}
  for (int i = 1;i<= 100; i+=2)
{
    Odd = i;
    Console.Write(Odd+" ");

}



