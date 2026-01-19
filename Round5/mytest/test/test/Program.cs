using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        #region Generics functions
        static void Swapint(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Swapfloat(ref float x, ref float y)
        {
            float temp = x;
            x = y;
            y = temp;
        }
        static void Swapobj(object x, object y)
        {
            object temp = x;
            x = y;
            y = temp;
        }
        //template in c++,in c# >> generics
        static void SwapT<T>(T x, T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        #endregion


        static void Main(string[] args)
        {
            #region LEC1-LEC3
            ////Vechile vechile = new Car();
            ////Vechile vechile2 = new Vechile();
            ////vechile.Move(); //هنا شايف الحاجات الي بيورثها للابن بس
            ////لاحظ اني لما زودت الاوفر رايد و الفيرتشوال السطر الي فوق سمع ع الكار مش الفيكال

            ////Car car = new Car();
            ////car.Move();
            ////car.test();
            ////vechile2.test();

            //Employee employee1 = new Employee();
            //Employee employee2 = new Employee();
            ////employee1.

            //object obj1 = new Employee();
            //object obj2 = new Employee();
            //object car = new Car();
            //object obj3 = 5; //boxing
            //int x = (int)obj3; //unboxing

            //employee1.ID = 10;
            //employee2.ID = 10;
            ////value compare
            //if (employee1.ID.Equals(employee2.ID))
            //{
            //    Console.WriteLine("==");
            //}
            //else
            //{
            //    Console.WriteLine("!=");
            //}
            ////ref compare
            //if (employee1.Equals(employee2))
            //{
            //    Console.WriteLine("==");
            //}
            //else
            //{
            //    Console.WriteLine("!=");
            //}

            //if (Equals(employee1.ID, employee2.ID))
            //{
            //    Console.WriteLine("==");
            //}
            //else
            //{
            //    Console.WriteLine("!=");
            //}

            //int c = 5;
            //int b = 5;
            //if (c.Equals(b))
            //{
            //    Console.WriteLine("==");
            //}
            //else
            //{
            //    Console.WriteLine("!=");
            //}
            //employee1.Name = "Ali";
            //Employee employee3 = employee1;
            //Console.WriteLine(employee1.ToString());
            //Console.WriteLine(employee1.GetHashCode());
            //Console.WriteLine(employee2.GetHashCode());
            //Console.WriteLine(employee3.GetHashCode());
            #endregion

            #region Intefaces
            //Game game = new Game();
            ////القديم قبل مع اعمل انترفيس
            ////GameMember gameMember = new Humen() { Name = "ali", Age = 50 };

            ////INTERFACE 
            //IMovable gameMember = new Humen() { Name = "ali", Age = 50 };

            //Humen humen1 = new Humen() { Name = "ali", Age = 50 };
            //Humen humen2 = new Humen() { Name = "sam", Age = 25 };
            //Humen humen3 = new Humen() { Name = "essa", Age = 30 };

            //Animal animal1 = new Animal() { Age = 20 };
            //Animal animal2 = new Animal() { Age = 20 };
            //Animal animal3 = new Animal() { Age = 20 };

            //game.AddGameMember(gameMember);

            //game.AddGameMember(humen1);
            //game.AddGameMember(humen2);
            //game.AddGameMember(humen3);

            //game.AddGameMember(animal1);
            //game.AddGameMember(animal2);
            //game.AddGameMember(animal3);

            //game.StartGame();

            #endregion

            #region IComparable
            //int[] items = { 4, 1, 7, 9, 5 };
            //Array.Sort(items);
            //for (int i = 0; i < items.Length; i++)
            //{
            //    Console.WriteLine(items[i]);
            //}

            //Humen humen1 = new Humen() { Name = "Ali", Age = 20 };
            //Humen humen2 = new Humen() { Name = "Alaa", Age = 24 };
            //Humen humen3 = new Humen() { Name = "Aya", Age = 21 };
            //Car car = new Car() { Make = "TOYOTA", Model = 2022 };
            //Humen[] humens = { humen1, humen2, humen3 };

            ////الي تحت هيديني ايرور لان هيرتب ع اي اساس
            //Array.Sort(humens);
            //for (int i = 0; i < humens.Length; i++)
            //{ Console.WriteLine(humens[i].Name + " " + humens[i].Age); }

            //IComparable[] comparables = { humen1, humen2, humen3, car };
            //Array.Sort(comparables);

            //foreach (Humen humen in comparables)
            //{ Console.WriteLine(humen.Name + " " + humen.Age); }

            //compare_class compare_Class = new compare_class();
            //compare_class compare_Class1 = new compare_class();
            //compare_class compare_Class2 = new compare_class();
            //compare_class compare_Class3 = new compare_class();
            //compare_class[] compare_Classes = { compare_Class, compare_Class1, compare_Class2, compare_Class3 };
            //Array.Sort(compare_Classes);

            #endregion

            #region Generics

            //swap

            //int x = 5;
            //int y = 10;
            //Swapint(ref x,ref y);
            //Swapobj(x, y);
            //SwapT<int>(x, y);
            //SwapT<double>(x, y);
            //Console.WriteLine($"swap: x = {x} & y = {y}");

            ////Array (Dynamic Size)
            //Mylist mylist = new Mylist();
            //mylist.Add(15);
            //mylist.Add(15);
            //mylist.Add(15);
            //mylist.Add(15);
            //mylist.Add(15);
            //mylist.Add(15);
            //mylist.Add(15);
            //الجاهز بقا منها معمول و اسمه ليست
            //List<>

            ////generics in my list
            //Mylist<int> mylist = new Mylist<int>();
            //mylist.Add(10);
            //mylist.Add(15);
            //mylist.Add(15);
            //mylist.Add(15);
            //mylist.Add(15);
            //mylist.Add(15);
            //mylist.Add(15);
            //mylist.Add(15);

            ////advanvanced list
            //MyAdvancedList<Employee> myAdvancedList = new MyAdvancedList<Employee>();
            //myAdvancedList.Add(50);
            //myAdvancedList.Add(50);
            //myAdvancedList.Add(50);
            //myAdvancedList.Add(50);
            //myAdvancedList.Add(50);
            //myAdvancedList.Resize();

            #endregion
            #region IEnumrable

            #endregion


        }
    }
}
