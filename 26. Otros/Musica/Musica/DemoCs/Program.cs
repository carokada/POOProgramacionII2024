using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCs;

namespace DemoCs
{
   class Program
   {
      static void Main(string[] args)
      {
         string divisor = "----------------------------------------------------------";
         Console.WriteLine(divisor);
         Console.WriteLine(" creando usuarios...");
         Usuario user1 = new Usuario("Jazmin", "jazmin@gmail.com");
         Usuario user2 = new Usuario("Ramiro", "ramiro@gmail.com");
         Usuario user3 = new Usuario("Alexis", "alexis@gmail.com");
         try
         {
            Usuario user4 = new Usuario("Al", "alejo@gmail.com");
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error : {e.Message}");
         }
         try
         {
            Usuario user4 = new Usuario("Alejo", "alejogmail.com");
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error : {e.Message}");
         }

         Console.WriteLine("\n mostrando usuarios cargados: ");
         Console.WriteLine(user1);
         Console.WriteLine(user2);
         Console.WriteLine(user3);

         Console.WriteLine(divisor);
         Console.WriteLine(" creando interpretes...");
         Contenido artista1 = new Interprete("Sabrina Carpenter");
         Contenido artista2 = new Interprete("Chappell Roan");
         Contenido artista3 = new Interprete("Billie Eilish");
         try
         {
            Contenido artista4 = new Interprete("");
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error : {e.Message}");
         }

         Console.WriteLine("\n mostrando interpretes cargados: ");
         Console.WriteLine(artista1);
         Console.WriteLine(artista2);
         Console.WriteLine(artista3);

         Console.WriteLine(divisor);
         Console.WriteLine(" creando albums...");
         Contenido album1 = new Album("Short 'n Sweet", new DateTime(2024, 8, 23));
         Contenido album2 = new Album("The Rise and Fall of a Midwest Princess", new DateTime(2023, 9, 22));
         Contenido album3 = new Album("Hit Me Hard and Soft", new DateTime(2024, 5, 17));
         try
         {
            Contenido album4 = new Album("brat", new DateTime(2025, 6, 7));
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error : {e.Message}");
         }

         Console.WriteLine("\n mostrando albums cargados: ");
         Console.WriteLine(album1);
         Console.WriteLine(album2);
         Console.WriteLine(album3);

         Console.WriteLine(divisor);
         Console.WriteLine(" creando canciones...");
         Contenido cancion1 = new Cancion("Please please please", (Interprete)artista1, (Album)album1, 186);
         Contenido cancion2 = new Cancion("Espresso", (Interprete)artista1, (Album)album1, 175);
         Contenido cancion3 = new Cancion("Femininomenon", (Interprete)artista2, (Album)album2, 219);
         Contenido cancion4 = new Cancion("HOT TO GO", (Interprete)artista2, (Album)album2, 184);
         Contenido cancion5 = new Cancion("WILDFLOWER", (Interprete)artista3, (Album)album3, 261);
         Contenido cancion6 = new Cancion("BLUE", (Interprete)artista3, (Album)album3, 343);
         try
         {
            Contenido cancion7 = new Cancion("!!!!!!!!", null, (Album)album3, 13);
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error : {e.Message}");
         }
         try
         {
            Contenido cancion7 = new Cancion("!!!!!!!!", (Interprete)artista3, null, 13);
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error : {e.Message}");
         }
         try
         {
            Contenido cancion7 = new Cancion("!!!!!!!!", (Interprete)artista3, (Album)album3, 9);
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error : {e.Message}");
         }

         Console.WriteLine("\n mostrando canciones cargadas: ");
         Console.WriteLine(cancion1);
         Console.WriteLine(cancion2);
         Console.WriteLine(cancion3);
         Console.WriteLine(cancion4);
         Console.WriteLine(cancion5);
         Console.WriteLine(cancion6);

         Console.WriteLine(divisor);
         Console.WriteLine(" agregando canciones a un interprete...");
         Interprete artista1Casted = (Interprete)artista1;
         Interprete artista2Casted = (Interprete)artista2;
         Interprete artista3Casted = (Interprete)artista3;
         artista1Casted.AgregarCancion((Cancion)cancion1);
         artista1Casted.AgregarCancion((Cancion)cancion2);
         artista2Casted.AgregarCancion((Cancion)cancion3);
         artista2Casted.AgregarCancion((Cancion)cancion4);
         artista3Casted.AgregarCancion((Cancion)cancion5);
         artista3Casted.AgregarCancion((Cancion)cancion6);
         try
         {
            artista1Casted.AgregarCancion((Cancion)cancion2);
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error : {e.Message}");
         }
         try
         {
            artista1Casted.AgregarCancion(null);
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error : {e.Message}");
         }
         Console.WriteLine();
         MostrarCanciones(artista1Casted);
         Console.WriteLine();
         MostrarAlbums(artista1Casted);
         Console.WriteLine();
         MostrarCanciones(artista2Casted);
         Console.WriteLine();
         MostrarAlbums(artista2Casted);
         Console.WriteLine();
         MostrarCanciones(artista3Casted);
         Console.WriteLine();
         MostrarAlbums(artista3Casted);

         Console.WriteLine(divisor);
         Console.WriteLine(" agregando canciones a un album...");
         Album album1Casted = (Album)album1;
         Album album2Casted = (Album)album2;
         Album album3Casted = (Album)album3;
         album1Casted.AgregarCancion((Cancion)cancion1);
         album1Casted.AgregarCancion((Cancion)cancion2);
         album2Casted.AgregarCancion((Cancion)cancion3);
         album2Casted.AgregarCancion((Cancion)cancion4);
         album3Casted.AgregarCancion((Cancion)cancion5);
         album3Casted.AgregarCancion((Cancion)cancion6);
         try
         {
            album2Casted.AgregarCancion((Cancion)cancion3);
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error : {e.Message}");
         }
         try
         {
            album2Casted.AgregarCancion(null);
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error : {e.Message}");
         }
         Console.WriteLine();
         MostrarCanciones(album1Casted);
         Console.WriteLine($" duracion: {album1Casted.Duracion} minutos.");
         Console.WriteLine();
         MostrarCanciones(album2Casted);
         Console.WriteLine($" duracion: {album2Casted.Duracion} minutos.");
         Console.WriteLine();
         MostrarCanciones(album3Casted);
         Console.WriteLine($" duracion: {album3Casted.Duracion} minutos.");

         Console.WriteLine(divisor);
         Console.WriteLine(" agregando favoritos a las bibliotecas de cada usuario...");
         user1.biblioteca.AgregarFavorito(album3);
         user1.biblioteca.AgregarFavorito(artista2);
         user1.biblioteca.AgregarFavorito(cancion1);
         user2.biblioteca.AgregarFavorito(album2);
         user2.biblioteca.AgregarFavorito(artista1);
         user2.biblioteca.AgregarFavorito(cancion2);
         user3.biblioteca.AgregarFavorito(album1);
         user3.biblioteca.AgregarFavorito(artista3);
         user3.biblioteca.AgregarFavorito(cancion3);
         try
         {
            user3.biblioteca.AgregarFavorito(cancion3);
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error : {e.Message}");
         }
         try
         {
            user3.biblioteca.AgregarFavorito(null);
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error : {e.Message}");
         }
         Console.WriteLine();
         MostrarFavoritos(user1);
         Console.WriteLine();
         MostrarFavoritos(user2);
         Console.WriteLine();
         MostrarFavoritos(user3);
         // duracion de biblioteca ?? no se como se calcula porque si los obj son contenido no usan ITemporizable y no se puede acceder a sus propiedades porque estan declarados con la clase de la herencia


         Console.WriteLine("");
         Console.WriteLine(divisor);
         Console.WriteLine("\n presione una tecla para salir ");
         Console.ReadKey();
      }

      private static void MostrarFavoritos(Usuario user)
      {
         Console.WriteLine($" mostrando favoritos de {user.Nombre}:");
         foreach (var fav in user.biblioteca.ObtenerFavoritos())
         {
            Console.WriteLine($" - {fav}");
         }
      }

      private static void MostrarCanciones(Interprete artista)
      {
         Console.WriteLine($" mostrando canciones de {artista.Nombre}:");
         foreach (var cancion in artista.ObtenerCanciones())
         {
            Console.WriteLine($" - {cancion}");
         }
      }

      private static void MostrarCanciones(Album album)
      {
         Console.WriteLine($" mostrando canciones en {album.Nombre}:");
         foreach (var cancion in album.ObtenerCanciones())
         {
            Console.WriteLine($" - {cancion}");
         }
      }

      private static void MostrarAlbums(Interprete artista)
      {
         Console.WriteLine($" mostrando albums de {artista.Nombre}:");
         foreach (var album in artista.ObtenerAlbums())
         {
            Console.WriteLine($" - {album}");
         }
      }
   }
}

         //try
         //{

         //}
         //catch (Exception e)
         //{
         //   Console.WriteLine($" !! error : {e.Message}");
         //}
