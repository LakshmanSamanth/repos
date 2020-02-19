using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrincipleUdemy
{
    public enum Size
    {
        Small,Medium,Large,Huge
    }

    public enum Color
    {
        Red,Blue,Yellow,Green
    }

    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color,Size size)
        {
            if (name == null)
            {
                throw new ArgumentNullException(paramName: nameof(name));
            }
            Name = name;
            Size = size;
            Color = color;

        }
    }


    public class ProductFilter
    {
        public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
            {
                if (p.Size == size)
                    yield return p;
            }
        }

        public  IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var p in products)
            {
                if (p.Color == color)
                    yield return p;
            }
        }


        public IEnumerable<Product> FilterByColorAndSize(IEnumerable<Product> products, Color color,Size size)
        {
            foreach (var p in products)
            {
                if (p.Color == color && p.Size == size)
                    yield return p;
            }
        }


    }

    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }

    public class ColorSpecification : ISpecification<Product>
    {
        private Color color;

        public ColorSpecification(Color color)
        {
            this.color = color;
        }
        public bool IsSatisfied(Product t)
        {
            return t.Color == color;
        }
    }

    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var i in items)
            {
                if (spec.IsSatisfied(i))
                    yield return i;

            }
        }
    }

    public class SizeSpecification : ISpecification<Product>
    {
        private Size size;
        public SizeSpecification(Size size)
        {
            this.size = size;
        }
        public bool IsSatisfied(Product t)
        {
            return t.Size == size;
        }
    }

    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first, second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
            this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));

        }

        public bool IsSatisfied(T t)
        {
            return first.IsSatisfied(t) && second.IsSatisfied(t);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);
            var car = new Product("Car", Color.Red, Size.Medium);
            var table = new Product("Table", Color.Yellow, Size.Medium);
            var unbrella = new Product("Umbrella", Color.Yellow, Size.Small);


            Product[] products = { apple, tree, house };

            var bf = new BetterFilter();
            Console.WriteLine(" Using Interface OpenCloseEx");
            foreach (var p in bf.Filter(products, new ColorSpecification(Color.Yellow)))
            {
                Console.WriteLine($"- {p.Name} is Yellow");
                Console.ReadLine();
            }

            var pf = new ProductFilter();
            Console.WriteLine("Old Method");
            foreach (var p in pf.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($"- {p.Name} is green");
                Console.ReadLine();

            }

            Console.WriteLine("Large Blue Items");
            foreach (var p in bf.Filter(products, new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large))))
            {
                Console.WriteLine($"- {p.Name} is Large and Blue");
                Console.ReadLine();
            }




        }
    }
}
