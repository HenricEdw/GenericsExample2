using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCreation1
{
    class Program
    {
        static void Main(string[] args)
        {
            PracticeList<Person> practiceList = new PracticeList<Person>();

            practiceList.Add(new Person { Age = 43, Name = "Henric" });
            practiceList.Add(new Person { Age = 15, Name = "Alvin" });

            Repository<Person> repository = new Repository<Person>();

            repository.SaveToRepo(new Person { Age = 43, Name = "Benny" });
            repository.SaveToRepo(new Person { Age = 99, Name = "Jenny" });

            Person person1 = repository.GetItemFromDataBase(0);
            Person person2 = repository.GetItemFromDataBase(1);

            //repository.RemoveItem(person);

            foreach(var item in repository)
            {
                Console.WriteLine($"{item.Name} och {item.Age}");
            }

            //Console.WriteLine($"{person1.Name} och {person1.Age}");
            //Console.WriteLine($"{person2.Name} och {person2.Age}");

            Console.ReadLine();
        }
    }
}
