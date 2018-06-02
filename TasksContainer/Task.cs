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
        public static void LoadPeopleList(List<Person> people)
        {

            Console.WriteLine("La lista se ha cargado exitosamente");
            ReadItemsFromJsonFile(people);
        }


        /// <summary>
        /// Lee una lista de items desde un archivo json
        /// </summary>
        public static dynamic ReadItemsFromJsonFile(List<Person> people) {
            using (StreamReader r = new StreamReader(@"D:\Repositorios\2018\C#\TestConsoleApplication\data\people.json"))
            {
               string json = r.ReadToEnd();
               people = JsonConvert.DeserializeObject<List<Person>>(json);
            }
            return people;
        }
        
    }
    
}
