using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;

namespace Profit_Calculator
{
    public static class FirebaseOperations
    {
        private static IFirebaseClient client = new FireSharp.FirebaseClient(new FirebaseConfig
        {
            AuthSecret = "zscvEX4FwmRJBlDzGuME9Y5BlfnBmnbJM2y71pYD",
            BasePath = "https://aopc-88476-default-rtdb.europe-west1.firebasedatabase.app/"
        });
        public static async void SetItem<T>(string path, T item)
        {
            await Task.Factory.StartNew(() =>{ client.Push(path + "/", item);});
        }
        public static Task<Dictionary<string, T>> GetListOfItems<T>(string path)
        {
            return Task.FromResult(JsonConvert.DeserializeObject<Dictionary<string, T>>(client.Get(path).Body.ToString()));
        }

    }
}
