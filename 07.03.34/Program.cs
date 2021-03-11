using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._34
{
    class Program
    {

        public class Workers 
        {
            List<Task> five_tasks = new List<Task>(5);
            public void MultiplyX2 (List<int> list)
            {

                for (int i = 0; i < list.Count; i++)
                {
                    five_tasks[i] = new Task();
                    five_tasks[i] = Task.Run(() =>
                     {
                         //list[i] *= 2;
                     });
                }
            }
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 3, 2 };
            Workers workers1 = new Workers();
            workers1.MultiplyX2(numbers);
        }
    }
}
