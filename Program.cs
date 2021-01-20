using System;

namespace HelloWorld
{
    class User 
    {
        public string User_Frist_Name { get; set;}
        public string User_Last_Name { get; set;}
        public string Born_Year { get; set; }
        public void Print()
        {
            Console.WriteLine("Пользователь "+ User_Frist_Name +" "+User_Last_Name+", "+Born_Year+" года рождения успешно зарегистрирован");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User us1 = new User();
            Console.WriteLine("Введите ваше имя: ");
            us1.User_Frist_Name=Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию: ");
            us1.User_Last_Name = Console.ReadLine();
            Console.WriteLine("Введите ваш год рождения: ");
            us1.Born_Year = Console.ReadLine();
            us1.Print();
        }
    }
}
