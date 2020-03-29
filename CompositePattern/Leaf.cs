using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Leaf:Component
    {

        public Leaf(string name):base(name)
        {

        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot Add to a leaf");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot Remove from Leaf");
        }


        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);

        }

      
    }
}
