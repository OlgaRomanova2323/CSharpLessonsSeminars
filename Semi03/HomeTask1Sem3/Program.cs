int[] numbers = {10, 5, 10, 20, 30, 40, 99, 4, 90, 3, 88};



int minRange = 10;
int maxRange = 90;
      
int count = 0;
  for (int i = 0; i < numbers.Length; i++)
      {
        if (numbers[i] >= minRange && numbers[i] <= maxRange)
          count++;
      }
      
 //return count;
   Console.WriteLine(count) ;
    