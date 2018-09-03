using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Custom libraries
using Entities;
using TasksContainer;


namespace TestConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            List<Person> people = TasksContainer.Task.CreatePersonList();

            TasksContainer.Task.LoadPeopleList(ref people);

            TasksContainer.Task.SortByName(people);
            */

            List<Item> items = new List<Item>(); 
            TasksContainer.Task.LoadItemsList(ref items);


            //Expresion de consulta/Sintaxis de consulta
            var itemList1 = (from i in items
                           where i.quantity == 2
                           select i).ToList(); 


            //Expresion de método(Sintaxis de método
            var itemList2 = items.Where(i => i.quantity == 2).Select(i => i).ToList();


            var range = Enumerable.Range(1, 100).Select(x => Math.Pow(x,2)).ToList();
          

            Console.ReadKey();


        }
    }
}
