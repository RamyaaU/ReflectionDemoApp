using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ReflectionDemoApp
{
    public class ReflectionOnService
    {
        public static void ServiceInfo()
        {
            Type type = Type.GetType("ReflectionDemoApp.ServiceInfo");

            //prints full name
            Console.WriteLine("full Name:{0}", type.FullName);
            //prints class name
            Console.WriteLine("class name:{0}",type.Name);

            Console.WriteLine("Methods inserviceInfo class");
            //storing number of methods in an array which is MethodInfo class
            MethodInfo[] methods = type.GetMethods();

            //traversing the date i the method object

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }

            Console.WriteLine("Property in Service class");

            //propertyinfo is class where it stores the info of property of 
            //service class in an array

            PropertyInfo[] properties = type.GetProperties();

            //traversing the data i the method object

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + "" + property.Name);
            }
            
        }
    }
}
