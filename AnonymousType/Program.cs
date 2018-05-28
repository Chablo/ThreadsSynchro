using System;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new { id = 1, name = "BoseQC35" };
            Console.WriteLine("L'id du produit est : " + product.id + " et le nom du produit est : " + product.name);
        }
    }
}
