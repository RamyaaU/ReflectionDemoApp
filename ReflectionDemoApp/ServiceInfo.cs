using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionDemoApp
{
    public class ServiceInfo
    {

        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public ServiceInfo(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public ServiceInfo()
        {
            this.Id = -5;
            this.Name = string.Empty;
        }

        public void PrintId()
        {
            Console.WriteLine("Id is {0}", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name is {0}", this.Name);
        }

    }

}
