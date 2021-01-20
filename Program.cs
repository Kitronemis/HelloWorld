using System;

namespace HelloWorld
{
    class User 
    {
        private string User_Frist_Name { get; set;}
        private string User_Last_Name { get; set;}
        private string Born_Year { get; set; }
        public void Set_user() 
        {
            Console.WriteLine("Введите ваше имя: ");
            this.User_Frist_Name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию: ");
            this.User_Last_Name = Console.ReadLine();
            Console.WriteLine("Введите ваш год рождения: ");
            this.Born_Year = Console.ReadLine();
        }
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
            us1.Set_user();
            us1.Print();
        }
    }
}
