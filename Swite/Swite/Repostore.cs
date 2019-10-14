using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swite
{
    class Repostore
    {
        //Lista para guardar los productos
        List<double> ListaProductos = new List<double>();

        int n = 0;
        int count = 0;
        Product[] products = new Product[1000];

        public void Menu()
        {
            //Opciones del menu
            Console.WriteLine("Obtener Producto:" + "\n"
            + "1.Obtener producto" + "\n"
            + "2.Mostrar Producto" + "\n"
            + "3.Mostar Lista" + "\n"
            + "4.Salir");
            Console.ReadLine();



            //Variable de opcion

            n = Convert.ToInt16(Console.ReadLine());

            //Opciones del menu con switch
            switch (n)
            {
                case 1:
                    Console.WriteLine("1.Obtener producto");
                    GetProduct();
                    break;

                case 2:
                    Console.WriteLine("2.Mostrar Producto");
                    ShowProduct(products);
                    break;

                case 3:
                    Console.WriteLine("3.Mostrar Lista");
                    ListProduct();
                    break;


                case 4:
                    Console.Write("bye bye");
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("No se selecciono una opcion");
                    break;

            }
        }


        public void GetProduct()
        {
            Product p = new Product();

            p.Id = count;
            Console.WriteLine("Ingrese un Nombre");
            p.Name = Console.ReadLine();
            Console.WriteLine("Ingrese una Descripcion");
            p.Description = Console.ReadLine();
            Console.WriteLine("Ingrese un Precio");
            p.Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese una Cantidad");
            p.Quantity = Convert.ToInt32(Console.ReadLine());

            products[count] = p;

            count += 1;
            Console.Clear();
            Menu();

            Console.ReadKey();

        }

        public void ShowProduct(Product[] p)
        {
            Console.WriteLine("Lista de Productos");

            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] != null)
                {
                    Console.WriteLine(p[i].Id + "\t" + p[i].Name);
                }
                else
                {
                    break;
                }
            }


        }

        public void ListProduct(Product[] p)
        {
            Console.Write("Lista de productos");
            

        }

    }
}
