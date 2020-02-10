using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Presentation
{
    class DoSomethingClass
    {
        public ISchoolService _service;
        public DoSomethingClass(ISchoolService srv)
        {
            _service = srv;
        }
        public void Execute()
        {
            

                Console.WriteLine("All Students");
                foreach (var std in _service.AllStudents())
                {

                    Console.WriteLine(std);

                }
                Console.WriteLine("----------------------------");
                Console.WriteLine("Students of GINF3");
                foreach (var std in _service.StudentsByClass("GINF3"))
                {
                    Console.WriteLine(std);
                }
                Console.WriteLine("----------------------------");
                Console.WriteLine("Students of aaaaa");
            try
            {
                foreach (var std in _service.StudentsByClass("aaaa"))
                {
                    Console.WriteLine(std);
                }
                Console.WriteLine("----------------------------");
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("its an empty class");
            }

                Console.WriteLine("----------------------------");
                Console.WriteLine("Students of GIND");
                foreach (var std in _service.StudentsByClass("GIND"))
                {
                    Console.WriteLine(std);
                }
                Console.WriteLine("----------------------------");
            
            
            
         



            Console.ReadKey();
        }
    }
}
