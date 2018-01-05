using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func_action_linq
{

    public delegate void MyDel(string message);

    class Program
    {

        static void Main(string[] args)
        {
            int i = 0;
            do
            {

                // Console.WriteLine(i);
                i++;
            } while (i < 10);
            /*
            int[] d = {1, 2, 3 };
            List<int> isd = new List<int>() { 1, 2, 3 };
            IEnumerator<int> enumerator = isd.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Console.WriteLine("**********");
            foreach (int ia in isd)
            {
                if (isd.Contains(2)) { }
                Console.WriteLine(ia);
            }

            isd.Where(x => x.Equals(2)).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("ARRAY HERUNDER");
            foreach (int array in d)
            {
                Console.WriteLine(array);
            }
            */

            throw new MyException("Hello min Exception");
            //Mydelegate d = new Mydelegate();
            Console.ReadLine();
        }


        static void FuncAndAction()
        {
            Func<int, int, int> add = (x, y) => x + y;
            Action<int> write = x => Console.WriteLine(x);

            write(add(2, 3));
        }


        static void MyLinqWhere()
        {
            Action<int> writeInt = x => Console.WriteLine(x);
            Action<string> writeString = x => Console.WriteLine(x);
            Action<string> myWriteLine = x => Console.WriteLine(x);

            myWriteLine("DETTE ER MIN WRITE");
            IEnumerable<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6, 32, 2, 5, 7, 2323, 553535, 12121 };

            var query = intList.myWhere(x => x == 2);

            writeString("Invoke af myWhere == 2: ");
            foreach (int item in query)
            {
                writeInt(item);
            }

            writeString("Count of ints in string with myCount: ");
            writeInt(intList.myCount());

            writeString("Counts of ints == 2 with MyCount");
            writeInt(intList.myWhere(x => x.Equals(2)).myCount());

            writeString("List sorted with orderBy: ");
            intList.OrderBy(x => x).ToList().ForEach(x => writeInt(x));

            writeString("List sorted with orderByDesn: ");
            intList.OrderByDescending(x => x).ToList().ForEach(x => writeInt(x));
        }


        static void Setup()
        {
            Manager manager = new Manager { Name = "Über Boss" };
            Manager underManager = new Manager { Name = "Under Boss" };

            manager.emplooyes = GenerateEmployees(10).OrderBy(x => x.name).ToList();
            underManager.emplooyes = GenerateEmployees(10).OrderBy(x => x.name).ToList();
            
            //NotifyEmployeeDelegate notifyEmployeeDelegate = new NotifyEmployeeDelegate(manager.NotifyEmployee("fuldtid", Manager.NotifyType.shiftRequested));



            //manager.Notify("fultid");
        }

        static List<Employee> GenerateEmployees(int amountOfEmployees)
        {
            List<Employee> employees = new List<Employee>();
            Random random = new Random();
            List<string> title = new List<string>() { "fultid", "deltid" };
            List<string> name = new List<string>() { "Søren", "Hans", "Lone", "Ingrid", "Donald", "Inger", "Arne", "Casper", "Mikkel", "Stefan" };

            for (int i = 0; i < amountOfEmployees; i++)
            {
                int rName = random.Next(10 - i);
                int rTitle = random.Next(2);
                Employee e = new Employee(title[rTitle], name[rName]);
                name.Remove(name[rName]);
                employees.Add(e);
            }

            return employees;
        }

        public enum NotifyType
        {
            shiftRequested,
            ShiftDeleted,
            shiftTaken
        }
    }
}
