// See https://aka.ms/new-console-template for more information
using System;
Random random = new Random();
Random random1 = new Random();
bool continuar = true;





while (continuar)
{
    //dado 1
    int dado1 = random.Next();
    
    int LanzarDado(Random random)
    {
      
        return random.Next(1, 7);
    }

  
    //dado 2
    int dado = random.Next();

    int LanzarDado2(Random random)
    {

        return random.Next(1, 7);
    } 
    int resultado = LanzarDado (random);
    Console.WriteLine ("Resultado de el dado1 :" + resultado);


    int resultado2 = LanzarDado2(random);
    Console.WriteLine("resultado de el dado2 :" + resultado2);




    Console.Write("¿Deseas lanzar los dados de nuevo? (s/n): ");
        string respuesta = Console.ReadLine().ToLower();

        if (respuesta != "s")
        {
            continuar = false;
        }
         
  
          Console.WriteLine(" juego terminado");

 };
   

    

    
    







