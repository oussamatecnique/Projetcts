using Shared;
using Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class SchoolService : ISchoolService
    {
        public IContext _context;

        public SchoolService(IContext cxt)
        {
            _context = cxt;
        }
        public List<Student> AllStudents()
        {
            List<Student> ListS = new List<Student>();


            foreach (var c in _context.Classes)
            {
                ListS.AddRange(c.Students.ToList());

            }
            return ListS;


        }
        public List<Student> StudentsByClass(String level)

        {
            List<Student> ListS = new List<Student>();
            
               ListS = _context.Classes.Where(a => a.Level.Equals(level)).Select(a => a.Students).FirstOrDefault();

            if (ListS == null)
                throw new NullReferenceException();

            return ListS;
        }

    }
}