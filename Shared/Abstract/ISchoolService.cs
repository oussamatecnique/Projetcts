using Shared;
using System.Collections.Generic;

namespace Shared
{
    public interface ISchoolService
    {
        List<Student> AllStudents();
        List<Student> StudentsByClass(string lvl);

    }
}
