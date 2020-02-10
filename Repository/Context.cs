using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;
using Shared.Abstract;

namespace Repository
{

        public class Context : IDisposable,IContext
        {
            public List<Classroom> Classes { get; set; }


            public Context()
            {
                // first Classesroom
                this.Classes = new List<Classroom>();
                Classroom C1 = new Classroom("GINF3");
                C1.Students.Add(new Student("Oussama", 20));
                C1.Students.Add(new Student("Kouetar", 23));
                C1.Students.Add(new Student("Tarik", 22));
                C1.Students.Add(new Student("Otman", 21));
                Classes.Add(C1);
                // second classroom
                Classroom C2 = new Classroom("GIND");
                C2.Students.Add(new Student("Mohamed", 20));
                C2.Students.Add(new Student("Imad", 19));
                C2.Students.Add(new Student("Soufiane", 19));
                C2.Students.Add(new Student("Imane", 23));
                Classes.Add(C2);

            }
            public void Dispose()
            {
                Classes = null;
            }
        }
    }



