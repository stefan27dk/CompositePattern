using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
             Composite Root = new Composite("root"); //The added name
            Root.Add(new Leaf("Leaf A"));
            Root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));
            Root.Add(comp);
            Root.Add(new Leaf("Leaf C"));

            //Add and Remove a Leaf
            Leaf leaf = new Leaf("Leaf D");
            Root.Add(leaf);
            Root.Remove(leaf);

            // Recursively display Tree
            Root.Display(1);
            Console.ReadKey();
            
        }
    }
}
