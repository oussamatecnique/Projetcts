namespace Shared
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(string Nom, int Age)
        {
            this.Name = Nom;
            this.Age = Age;
        }
        public override string ToString()
        {
            return "Name: "+Name+" Age: "+Age+"";
        }
    }
}
