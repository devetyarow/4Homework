 //число, которое нужно возвести в степень 

 Console.Write("Enter number   : ");
  int num = int.Parse(Console.ReadLine());
  //степень числа
  Console.Write("Enter exponentiation number : ");
  int n = int.Parse(Console.ReadLine());
  //число, возведенное в степень
  int num_n=1;
  for(int i=0; i<n; i++)
  {
   num_n*=num;
  }
  Console.WriteLine("{0} ^ {1} = {2}", num, n, num_n);
  Console.ReadKey();
  return 0;
