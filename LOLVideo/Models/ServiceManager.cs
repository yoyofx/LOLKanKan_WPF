using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLVideo.Models
{
    public class ServiceManager
    {
        private static Dictionary<Type, object> regServices = new Dictionary<Type, object>();

        public static T GetService<T>()
        {
            object service = null;
            regServices.TryGetValue(typeof(T),out service);
            return (T)service;
        }

        public static void AddService<T>(T obj)
        {
            regServices.Add(typeof(T),obj);
        }


    }
}
