using Unity;

namespace Presentation
{
    class Program
    {
        public static UnityContainer RegisterComponent()
        {
            var container = new UnityContainer();
            Injection.App_start.UnityConfig.RegisterComponent(container);
            return container;
        }
        static void Main(string[] args)
        {
            var unity = RegisterComponent();
            var program = unity.Resolve<DoSomethingClass>();
            program.Execute();

        }
    }
}
