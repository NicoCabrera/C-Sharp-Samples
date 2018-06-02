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

            List<Person> people = TasksContainer.Task.CreatePersonList();

            TasksContainer.Task.LoadPeopleList(people);
        }


        
    }
}
