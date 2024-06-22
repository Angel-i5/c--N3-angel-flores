// See https://aka.ms/new-console-template for more information

Dictionary<string, int> Inventario = new Dictionary<string, int>();

while (true)
{
    Console.WriteLine("Menu de opciones");
    Console.WriteLine("celecione una de las siguientes opciones ");
    Console.WriteLine("1, Agregar producto");
    Console.WriteLine("2, Eliminar producto");
    Console.WriteLine("3, Actualizar cantidad");
    Console.WriteLine("4, Mostrar inventario");
    Console.WriteLine("5, salir");
    Console.WriteLine("celeccione una opcion");

    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1://agregar producto
            Console.WriteLine("ingresar nombre de producto");
            string nombreProducto = Console.ReadLine();
            Console.WriteLine("ingrese la cantidad");
            int cantidadProducto = int.Parse(Console.ReadLine());

            if (Inventario.ContainsKey(nombreProducto))
            {
                Console.WriteLine($"El producto´{nombreProducto}´ ya existe en el inventario");
            }
            else
            {
                Inventario.Add(nombreProducto, cantidadProducto);
                Console.WriteLine($"El producto´{nombreProducto}´fue agregado al inventario");
            };

            break;

         case 2:// eliminar producto
            Console.WriteLine("ingrese el producto que desea eliminar de la lista");
            string EliminarProducto = Console.ReadLine();

            if (Inventario.ContainsKey(EliminarProducto))
            {
                Inventario.Remove(EliminarProducto);
                Console.WriteLine($"el producto´{EliminarProducto}´ fue eliminado de la lista ");

            }
            else
            {
                Console.WriteLine($"el producto´{EliminarProducto}´ no existe en la lista");
            };

         break;

         case 3:// actualizar cantida
           
            Console.Write("Ingrese el nombre del producto a actualizar: ");
            string productoActualizar = Console.ReadLine();

            if (Inventario.ContainsKey(productoActualizar))
            {
                Console.WriteLine($"Cantidad actual de '{productoActualizar}': {Inventario[productoActualizar]}.");
                Console.Write("Ingrese la nueva cantidad: ");
                if (!int.TryParse(Console.ReadLine(), out int nuevaCantidad) || nuevaCantidad < 0)
                {
                    Console.WriteLine("Cantidad no válida. Debe ser un número entero positivo.");
                    continue;
                }

                Inventario[productoActualizar] = nuevaCantidad;
                Console.WriteLine($"Cantidad de '{productoActualizar}' actualizada a '{nuevaCantidad}'.");
            }
            else
            {
                Console.WriteLine($"El producto '{productoActualizar}' no existe en el inventario.");
            };
            break;

         case 4: // mostrar inventario

            Console.WriteLine("Inventario:");
            foreach (var keyValuePair in Inventario)
            {
                Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
            }
            break;


        case 5:
            Console.WriteLine("grasias por usar el programa");

         break;


        default:
            Console.WriteLine("introdusca una opcion valida");
        break;
    };
    Console.WriteLine(" Presione cualquier tecla para continuar...");
    Console.ReadKey();
    Console.Clear();


};