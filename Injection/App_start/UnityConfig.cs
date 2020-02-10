using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Shared;
using Services;
using Repository;
using Shared.Abstract;

namespace Injection.App_start
{
    public static class UnityConfig
    {
        public static void RegisterComponent(UnityContainer container)
        {
            container.RegisterType<ISchoolService, SchoolService>();
            container.RegisterType<IContext, Context>();

        }
    }
}
