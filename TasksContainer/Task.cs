using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Use Nuget package 'Newtonsoft.Json.11.0.2'
using Newtonsoft.Json;
using System.IO;

namespace TasksContainer
{
    public class Task {

        /// <summary>
        /// Crea una lista de personas
        /// </summary>
        /// <returns>Devuelve una lista de objetos Person inicializada, pero vacía</returns>
        public static List<Person> CreatePersonList()
        {
            List<Person> people = new List<Person>();
            return people;
        }


        /// <summary>
        /// Carga una lista de objetos Person
        /// </summary>
        /// <param name="people">Lista instanciada de Person</param>
        public static void LoadPeopleList(ref List<Person> people)
        {
            ReadPeopleFromJsonFile(ref people);
        }


        /// <summary>
        /// Lee una lista de people desde un archivo json
        /// </summary>
        public static void ReadPeopleFromJsonFile(ref List<Person> people) {
            using (StreamReader r = new StreamReader(@"D:\Repositorios\2018\C#\TestConsoleApplication\data\people.json"))
            {
               string json = r.ReadToEnd();
               people = JsonConvert.DeserializeObject<List<Person>>(json);
            }
        }


        public static void SortByName(List<Person> people) {

            var orderedPeople = people.OrderBy(p => p.name).ToList();


            Console.WriteLine("Lista ordenada \n");
            foreach (var item in orderedPeople)
            {
                Console.WriteLine(item.name);
            }

            Console.WriteLine("\nLista por defecto");
            foreach (var item in people)
            {
                Console.WriteLine(item.name);
            }

            Console.Read();
        }




        public static void LoadItemsList(ref List<Item> items)
        {
            ReadItemsFromJsonFile(ref items);
        }


        /// <summary>
        /// Lee una lista de items desde un archivo json
        /// </summary>
        public static void ReadItemsFromJsonFile(ref List<Item> items)
        {
            using (StreamReader r = new StreamReader(@"D:\Repositorios\2018\C#\TestConsoleApplication\data\listaDeItems.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<Item>>(json);
            }
        }
    }
    
}
