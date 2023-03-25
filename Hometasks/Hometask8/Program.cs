using dz8_namespace;
using System.Reflection;

namespace Hometask8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Explorer explorer = new Explorer();

            // explorer.Manage();

            Type type = typeof(Class_dz8);

            Console.WriteLine(type);
            Console.WriteLine($"Name: {type.Name}");
            Console.WriteLine($"Full name: {type.FullName}");
            Console.WriteLine($"Namespace: {type.Namespace}");
            Console.WriteLine($"Is class: {type.IsClass}\n");

            foreach (MemberInfo member in type.GetMembers())
            {
                Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
            }

            Class_dz8 class_Dz8 = new Class_dz8();
        }
    }
}
