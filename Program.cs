using System;
using System.Collections.Generic;

class Program
{


    static void Main(string[] args)
    {
        Dictionary<string, int> productos = new Dictionary<string, int>();
        {
            productos.Add("leche", 10);
            productos.Add("azucar", 20);
            productos.Add("cafe", 17);

        }

        string operacion;
        string operacion1;
        string nombreProducto;
        int stock;
        int stockMinimo;


        foreach (KeyValuePair<string, int> producto in productos)
        {
            Console.WriteLine("el producto " + producto.Key + " su stock es de " + producto.Value);
        }

        Console.WriteLine("ingrese operacion");
        operacion1 = Console.ReadLine();


        if (operacion1 == "A")
        {
            Console.WriteLine("ingrese nombre de producto");
            nombreProducto = Console.ReadLine();

            if (productos.ContainsKey(nombreProducto))
            {
                Console.WriteLine("el producto ya existe");

            }
            else 
            {
                Console.WriteLine("ingrese el stock minimo");
                stockMinimo = Int32.Parse(Console.ReadLine());


                Console.WriteLine("Ingrese el stock del producto:");
                stock = Int32.Parse(Console.ReadLine());

                if (stock < stockMinimo)
                {
                    Console.WriteLine("el stock es menor al stock minimo");
                }
                else
                {
                    Console.WriteLine("el stock sobre pasa al stock minimo");
                }
                productos.Add(nombreProducto, stock);
                


                Console.WriteLine("Producto agregado exitosamente.");
                
            }
           
        }
        
        else if (operacion1 == "B")
        {
            Console.WriteLine("ingrese un producto a dar de baja");
            nombreProducto = Console.ReadLine();

            if (productos.Remove(nombreProducto))
            {
                Console.WriteLine("Producto borrado exitosamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }

        }
        else if (operacion1 == "M")
        {
            Console.WriteLine("Ingrese nombre del producto a modificar:");
            nombreProducto = Console.ReadLine();

            if (productos.ContainsKey(nombreProducto))
            {
                Console.WriteLine("Ingrese el nuevo stock del producto:");
                stock = Int32.Parse(Console.ReadLine());
                productos[nombreProducto] = stock;
                Console.WriteLine("Stock del producto modificado exitosamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
           

        }
        foreach (KeyValuePair<string, int> producto in productos)
        {
            Console.WriteLine("el producto " + producto.Key + " su stock es de " + producto.Value);
        }

        Console.WriteLine("Desea ingresar otra operacion");

        string ingresarOtraOperacion = Console.ReadLine();

        while(ingresarOtraOperacion == "si")
        {
            Console.WriteLine("vuelva a ingresar otra operacion");
            operacion = Console.ReadLine();



            if (operacion == "A")
            {
                Console.WriteLine("ingrese nombre de producto");
                nombreProducto = Console.ReadLine();

                if (productos.ContainsKey(nombreProducto))
                {
                    Console.WriteLine("el producto ya existe");

                }
                else
                {
                    Console.WriteLine("ingrese el stock minimo");
                    stockMinimo = Int32.Parse(Console.ReadLine());


                    Console.WriteLine("Ingrese el stock del producto:");
                    stock = Int32.Parse(Console.ReadLine());

                    if (stock < stockMinimo)
                    {
                        Console.WriteLine("el stock es menor al stock minimo");
                    }
                    else
                    {
                        Console.WriteLine("el stock cobre pasa al stock minimo");
                    }

                    productos.Add(nombreProducto, stock);
                    Console.WriteLine("Producto agregado exitosamente.");

                }

            }

            else if (operacion == "B")
            {
                Console.WriteLine("ingrese un producto a dar de baja");
                nombreProducto = Console.ReadLine();

                if (productos.Remove(nombreProducto))
                {
                    Console.WriteLine("Producto borrado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Producto no encontrado.");
                }
                

            }
            else if (operacion == "M")
            {
                Console.WriteLine("Ingrese nombre del producto a modificar:");
                nombreProducto = Console.ReadLine();

                if (productos.ContainsKey(nombreProducto))
                {
                    Console.WriteLine("Ingrese el nuevo stock del producto:");
                    stock = Int32.Parse(Console.ReadLine());
                    productos[nombreProducto] = stock;
                    Console.WriteLine("Stock del producto modificado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Producto no encontrado.");
                }

                
            }
            foreach (KeyValuePair<string, int> producto in productos)
            {
                Console.WriteLine("el producto " + producto.Key + " su stock es de " + producto.Value);
            }

            Console.WriteLine("Desea ingresar otra operacion");
            ingresarOtraOperacion = Console.ReadLine();


        }















    }

}
