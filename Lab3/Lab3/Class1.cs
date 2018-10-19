using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._1
{
    class Program
    {
        public class Student
        {
            private int number;
            private string surname;
            private string name;
            private string patronymic;
            private int age;
            private string adress;
            private string telephoneNumber;
            private string faculty;
            private int course;
            private int group;
            private readonly int id;

            public static int quantity = 0;

            public int Number { get => number; set => number = value; }
            public string Surname { get => surname; set => surname = value; }
            public string Name { get => name; set => name = value; }
            public string Patronymic { get => patronymic; set => patronymic = value; }
            public int Age { get => age; set => age = value; }
            public string Adress { get => adress; set => adress = value; }
            public string TelephoneNumber { get => telephoneNumber; set => telephoneNumber = value; }
            public string Faculty { get => faculty; set => faculty = value; }
            public int Course { get => course; set => course = value; }
            public int Group { get => group; set => group = value; }

            public Student()
            {
                quantity++;
                Console.Write("Student number ");
                Console.WriteLine(quantity);
            }

            public Student(int number,string name, string surname, string patronymic, int age, string adress, string telephoneNumber, string faculty, int course, int group)
            {
                this.name = name;
                this.surname = surname;
                this.patronymic = patronymic;
                this.age = age;
                this.adress = adress;
                this.telephoneNumber = telephoneNumber;
                this.faculty = faculty;
                this.course = course;
                this.group = group;
                id = number * 4273;

            }

            private Student(int number, string name, string surname, string patronymic, int age, string adress, string telephoneNumber, string faculty, int course)
            {
                this.name = name;
                this.surname = surname;
                this.patronymic = patronymic;
                this.age = age;
                this.adress = adress;
                this.telephoneNumber = telephoneNumber;
                this.faculty = faculty;
                this.course = course;
                this.number = number;
                id = number * 4273;

            }

            public void Info()
            {
                Console.WriteLine(id);
                Console.WriteLine(name);
                Console.WriteLine(surname);
                Console.WriteLine(patronymic);
                Console.WriteLine(age);
                Console.WriteLine(adress);
                Console.WriteLine(telephoneNumber);
                Console.WriteLine(faculty);
                Console.WriteLine(course);
                Console.WriteLine(group);
            }

            public override string ToString()
            {
                return this.Name;
            }

        }

        static void Main(string[] args)
        {
            var vasya = new Student(1,"Vasya", "Pupkin", "Vasilievich", 19, "Bobruiskaya25", "375447025748", "FIT", 2, 2);
            var petya = new Student(2,"Petya", "Skarabeykin", "Vitalievich", 20, "Bobruiskaya25", "375443535345", "FIT", 3, 1);
            var vanya = new Student(3,"Vanya", "Petrov", "Petrovich", 21, "Bobruiskaya25", "3752974353453", "FIT", 4, 3);

            vasya.Info();
            Console.WriteLine();
            petya.Info();
            Console.WriteLine();
            vanya.Info();
            Console.WriteLine();

            if (petya == vasya)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            if (vasya is Student)
            {
                Console.WriteLine("vasya student");
            }
            else
            {
                Console.WriteLine("vasya ne student");
            }

            Console.WriteLine();

            Student[] students = new Student[3];

            for (int i = 0; i < 3; i++)
            {
                students[i] = new Student();
                Console.Write("Введите id: ");
                students[i].Number = int.Parse(Console.ReadLine());
                Console.Write("Введите имя: ");
                students[i].Name = Console.ReadLine();
                Console.Write("Введите фамилию: ");
                students[i].Surname = Console.ReadLine();
                Console.Write("Введите отчество: ");
                students[i].Patronymic = Console.ReadLine();
                Console.Write("Введите адресс: ");
                students[i].Adress = Console.ReadLine();
                Console.Write("Введите номер телефона: ");
                students[i].TelephoneNumber =Console.ReadLine();
                Console.Write("Введите факультет: ");
                students[i].Faculty = Console.ReadLine();
                Console.Write("Введите возраст: ");
                students[i].Age = int.Parse(Console.ReadLine());
                Console.Write("Введите курс: ");
                students[i].Course = int.Parse(Console.ReadLine());
                Console.Write("Введите номер группы: ");
                students[i].Group = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                
            }

            Console.WriteLine("Выберите способ сортировки: 1.По факультету; 2. По группе");
            int v = int.Parse(Console.ReadLine());
            if (v == 1)
            {
                Console.Write("Введите название факультета: ");
                String value = Console.ReadLine();
                for (int j = 0; j < 3; j++)
                {
                    if (students[j].Faculty == value)
                    {
                        students[j].Info();
                        Console.WriteLine();
                    }
                }
            }
            else if (v == 2)
            {
                Console.Write("Введите номер группы: ");
                int value = int.Parse(Console.ReadLine());
                for (int j = 0; j < 3; j++)
                {
                    if (students[j].Group == value)
                    {
                        students[j].Info();
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Неверное значение");
            }

        }

    }

}


