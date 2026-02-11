using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        #region Delegets
        delegate bool MyDelegate(int item);
        delegate bool MyDelegate2(string item);
        //delegate bool MyDelegate3(List<int> item);

        static bool IsPositive(int number)
        {
            return number > 0;
        }
        static void DisplayPositive(List<int> numbers)
        {
            foreach (int n in numbers)
            {
                if (IsPositive(n))
                {
                    Console.WriteLine(n);
                }
            }
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        static void DisplayEvens(List<int> numbers)
        {
            foreach (int n in numbers)
            {
                if (IsEven(n))
                {
                    Console.WriteLine(n);
                }
            }
        }
        //static void Display(List<int> numbers, IChecker checker)
        //{
        //    foreach (int n in numbers)
        //    {
        //        if (checker.Check(n))
        //        {
        //            Console.WriteLine(n);
        //        }
        //    }
        //}

        //static void Display(List<int> numbers, ??)
        //{
        //    foreach (int n in numbers)
        //    {
        //        if (??(n))
        //        {
        //            Console.WriteLine(n);
        //        }
        //    }
        //}
        static void Display(List<int> numbers, MyDelegate myDelegate)
        {
            foreach (int n in numbers)
            {
                if (myDelegate.Invoke (n))
                {
                    Console.WriteLine(n);
                }
            }
        }


        // ************************** We need One Function to display ********************

        // 1- We Can Make Flag (int or Enum) and Check inside the Display Function  

        // 2- We Can Make Base Class and Inherit from It .. and override on the method Display
        //    ( Make Interface and make Function Check in it) ===>> the Class Not Entity here .. in Java
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
            //Mylist_For_IEnumrable mylist_For_IEnumrable = new Mylist_For_IEnumrable();
            //mylist_For_IEnumrable.Add(1);
            //mylist_For_IEnumrable.Add(10);
            //mylist_For_IEnumrable.Add(15);
            //mylist_For_IEnumrable.Add(11);
            //mylist_For_IEnumrable.Add(31);
            //mylist_For_IEnumrable.Add(181);
            //mylist_For_IEnumrable.Add(8);
            ////Console.WriteLine(mylist_For_IEnumrable.GetByIndex(2));

            ////for (int i = 0; i < mylist_For_IEnumrable.GetCount(); i++)
            ////{
            ////    Console.WriteLine(mylist_For_IEnumrable.GetByIndex(i));
            ////}

            ////foreach (var item in mylist_For_IEnumrable)
            ////{

            ////}
            ////Outer outer = new Outer();
            //////outer.x مش هشوفها 
            //////inner مش هشوفها برضو
            ////outer.GetInner();

            ////var res = outer.GetInner();
            ////res.ToString();

            //foreach (var item in mylist_For_IEnumrable)
            //{
            //    Console.WriteLine(item);
            //}.

            //الكود الي تحت ده هو نفس الفور ايتش بتعمله 
            ////how to custom write foreach
            //IEnumerator enumerator = mylist_For_IEnumrable.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    int item = (int)enumerator.Current;
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Collections
            //Mylist_For_IEnumrable mylist_For_IEnumrable2 = new Mylist_For_IEnumrable();
            //mylist_For_IEnumrable2.Add(1);
            //mylist_For_IEnumrable2.Add(10);
            //mylist_For_IEnumrable2.Add(15);

            ////mylist_For_IEnumrable2[1];
            ////indexer
            //mylist_For_IEnumrable2[1] = 80;

            ////collection
            //Collection collection = new Collection();
            ////ICollection,<>
            ////IList
            ////IList<>
            ////array list in not generic
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(7);
            //arrayList.Add("Hi");
            //arrayList.Add(90.70);
            //arrayList.Add(true);
            //arrayList.Add('A');
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            ////class list is the updated generic 
            //List<int> ints = new List<int>();
            //ints.Add(4);
            //ints.Add(5);
            //ints[0] = 1;
            //foreach (var item in ints)
            //{
            //    Console.WriteLine(item);
            //}

            ////stack fifo
            //Stack<int> stack = new Stack<int>();

            ////linked list
            //LinkedList<int> linkedlsit = new LinkedList<int>();
            //linkedlsit.AddFirst(5);

            ////hashset
            //HashSet<int> hashset = new HashSet<int>();
            //hashset.Add(7);
            #endregion
            #region Delegate
            
            List<int> numbers = new List<int> {1,5,-8, 2, -5, -4};
            Postive_Delegete postive_Delegete = new Postive_Delegete();
            Negative_Delegete negative_Delegete = new Negative_Delegete();
            DisplayEvens(numbers);
            DisplayPositive(numbers);
            //Display(numbers, postive_Delegete);
            //Display(numbers, negative_Delegete);

            MyDelegate myDelegate = new MyDelegate(IsPositive);
            MyDelegate2 myDelegate2 = new MyDelegate2(string.IsNullOrEmpty);
            myDelegate.Invoke(2);
            myDelegate2.Invoke("Hi");
            Display(numbers, myDelegate);
            myDelegate(2);

            int[] ints = { 1, 2, 3, 44, 5, 6 };
            //MyDelegate @delegate = new MyDelegate (IsPositive);
            MyDelegate @delegate = (IsEven);
            Display(numbers, @delegate);
            //كل الكلام الي فوق اقدر اختصره فالسطر الي تحت
            Display(numbers, IsPositive);
            //ممكن اكتب الفانشكن نفسها 
            Display(numbers, delegate (int item)
            {
                return item % 2 == 0;
            }
            );
            //ممكن اختصر اكتر 
            //anonoumes function
            Display(numbers, item => item % 2 == 0);
            //lambda exp
            //item => item % 2 == 0
            //predifined delegets

            //1 - Predicate<int>
            Predicate<int> predicate = IsPositive;

            //2-Func<in,out> or <out>
            Func<int, string, double, bool, string> func = (int x, string y, double z, bool b) => "Hi";

            //3-Action
            Action<int> action = (int x) => Console.WriteLine(x);
            //Action<>
            Action action1 = () => Console.WriteLine("Hello World");
            #endregion


        }
    }
}
