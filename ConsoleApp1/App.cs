using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    public class App
    {
        public App()
        {
            GetWorkers();
            Message message = new Message();
            message.Display(Workers);
            

        }

        // właściwości
        public List<Worker> Workers { get; set; }

        // pobieranie bazy pracowników
        void GetWorkers()
        {
            var path = $"{Directory.GetCurrentDirectory()}\\WorkersList.json";
            var json = File.ReadAllText(path);
            Workers = JsonConvert.DeserializeObject<List<Worker>>(json);
        }

        


    }
}
