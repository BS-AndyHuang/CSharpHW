using System;
using System.Linq;
using System.Threading.Channels;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("請輸入計算人數：");
            int count = int.Parse(Console.ReadLine());
            string[] peopleInfo = new string[count];
            double[] bmiArray = new double[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"請輸入第{i+1}個人姓名：");
                string name = Console.ReadLine();
                Console.WriteLine($"請輸入第{i+1}個人身高：");
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"請輸入第{i+1}個人體重：");
                double weight = double.Parse(Console.ReadLine());
                peopleInfo[i] = $"{name}的身高:{height} 體重:{weight}";
                bmiArray[i] = weight / Math.Pow(height / 100, 2);
            }
            
            Array.Sort(bmiArray,peopleInfo);
            
            //印出每個人的姓名及BMI(從高到排列)
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{peopleInfo[i]} => BMI:{bmiArray[i].ToString("#.##")}");
            }
            
            Console.ReadLine();
        }

        
    }

    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; }
        public string LastName { get;  }

        public string FullName => $"{FirstName} - {LastName}";

        public override string ToString()
        {
            return FullName;
        }
    }
    
    
}