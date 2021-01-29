using System.Collections.Generic;

namespace Problem
{
    public class FileLogger
    {
        private static List<int> list = new List<int>();                
        public FileLogger()
        {
            list.Add(list.Count + 1);          
        }    

        public string GetInstance()
        { 
            return "Nº de Instancias: " + list.Count;
        }


       
    }
}