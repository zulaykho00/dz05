using System;

namespace dz5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ZADANIE#2");
            int a,b,c=0;
            Console.Write("a=");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            b=Convert.ToInt32(Console.ReadLine());
            while(a+1<b)
            {
               
                c+=a+1;
                 a++;
            }
            Console.WriteLine(c);
            int a1,b1;
            Console.Write("a1=");
            a1=Convert.ToInt32(Console.ReadLine())+1;
            Console.Write("b1=");
            b1=Convert.ToInt32(Console.ReadLine());
            while(a1<b1)
            {
                if(a1%2==1)
                
                Console.WriteLine(a1);
                a1++;
            }
            Console.WriteLine("ZADANIE#3");
            int a2,b2;
            Console.WriteLine("введите длину:");
            a2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите ширину:");
            b2=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("прямоугольник");
           
            for(int i=0;i<b2;i++)
            {
                if(i==0 || i==b2-1)
                {
                    for(int j=0;j<a2;j++)
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("*");
                    for(int j=0;j<a2-2;j++)
                    {
                        Console.Write("  ");
                    }
                    Console.Write(" *");
                }
                Console.Write("\n");


            }
            Console.Write("*\n");
           
           Console.WriteLine("прямоугольный треугольник");
            for(int i=0;i<b2;i++)
            {
                if(i==b2-1)
                {
                    for(int j=0;j<b2+1;j++)
                    Console.Write("* ");
                    
                }
                else
                {
                    Console.Write("*");
                    for(int j=0;j<i;j++)
                    {
                        Console.Write("  ");
                    }
                    Console.Write(" *");
                }
                Console.Write("\n");


            }
        b2*=2;
          Console.WriteLine("равносторонний треугольник");
          for(int i=0;i<b2-1;i++)
          {
              if(i==b2/2-1)
              {
                  for(int j=0;j<b2/2;j++)
                  Console.Write("* ");
              }
              else
              {
                  Console.Write(" ");
                  for(int j=0;j<b2/2-1;j++)
                    {
                       if(j==b2/2-i-2)
                       Console.Write("*");
                       else Console.Write(" ");
                    }
                  
                  for(int j=0;j<b2/2-1;j++)
                    {
                        if(j==i-1)
                       Console.Write("*");
                       else Console.Write(" ");
                    }                
              }
              Console.Write("\n"); 
          }

          Console.WriteLine("ромб");
          for(int i=0;i<b2/2;i++)
          {
                  
                  for(int j=0;j<b2/2;j++)
                    {
                       if(j==b2/2-i-1)
                       Console.Write("*");
                       else Console.Write(" ");
                    }
                  
                  for(int j=0;j<b2/2;j++)
                    {
                        if(j==i-1)
                       Console.Write("*");
                       else Console.Write(" ");
                    }                
                    Console.Write("\n");
                  
          }
          for(int i=1;i<b2/2;i++)
          {
                  for(int j=0;j<b2/2;j++)
                    {
                        if(j==i)
                       Console.Write("*");
                       else Console.Write(" ");
                    }      
                     for(int j=1;j<b2/2;j++)
                    {
                       if(j==b2/2-i-1)
                       Console.Write("*");
                       else Console.Write(" ");
                    }          
                    Console.Write("\n");
                  
                       
               
          }
          Console.WriteLine("ZADANIE#4");
          Console.Write("p=");
          double s=1000,p=Convert.ToDouble(Console.ReadLine());
          int k=0;
          while(s<=1100)
          {
              s+=s*p/100;
              k++;

          }
          Console.WriteLine($"количество месяцев:{k}");
          Console.WriteLine($"итоговый размер вклада:{s}");


        }
    }
}
