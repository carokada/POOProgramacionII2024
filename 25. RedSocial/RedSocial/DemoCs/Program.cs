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

         // creacion de usuarios
         Console.WriteLine(divisor);
         Console.WriteLine(" creando usuarios... ");
         Usuario usuario1 = new Usuario("Alice", new DateTime(1990, 5, 20), "Buenos Aires");
         Usuario usuario2 = new Usuario("Bobby", new DateTime(1985, 11, 15), "Cordoba");
         Usuario usuario3 = new Usuario("Charles", new DateTime(1992, 8, 10));
         Usuario usuario4 = new Usuario("Diana", new DateTime(1998, 2, 25));

         // creacion de publicaciones
         Console.WriteLine(divisor);
         Console.WriteLine(" creando publicaciones... ");
         Publicacion publicacion1 = new Publicacion(DateTime.Now, "Buen dia desde Buenos Aires", usuario1);
         Publicacion publicacion2 = new Publicacion(DateTime.Now.AddHours(-1), "Amanece en La Plata", usuario2);
         Publicacion publicacion3 = new Publicacion(DateTime.Now.AddHours(-2), "Boquita lo mas grande !!!", usuario3);
         Publicacion publicacion4 = new Publicacion(DateTime.Now.AddHours(-3), "A estudiar", usuario4);
         Publicacion publicacion5 = new Publicacion(DateTime.Now.AddHours(-4), "Feliz cumple tio toto!", usuario3);
         Publicacion publicacion6 = new Publicacion(DateTime.Now.AddHours(-5), "De vuelta a casa", usuario2);
         // error por publicacion con usuario nulo
         try
         {
            new Publicacion(DateTime.Now, "", null);
         }
         catch (Exception excepcion)
         {
            Console.WriteLine(" !! error en creacion de publicacion: " + excepcion.Message);
         }

         Imagen imagen1 = new Imagen(DateTime.Now.AddMinutes(-30), "Paisaje", usuario4);
         imagen1.SubirImagen("paisaje.jpeg");
         Imagen imagen2 = new Imagen(DateTime.Now.AddMinutes(-25), "Selfie", usuario3);
         imagen2.SubirImagen("selfie.jpeg");
         Imagen imagen3 = new Imagen(DateTime.Now.AddMinutes(-20), "Atardecer", usuario2);
         imagen3.SubirImagen("atardecer.jpeg");
         Imagen imagen4 = new Imagen(DateTime.Now.AddMinutes(-15), "Playa", usuario1);
         imagen4.SubirImagen("playa.jpeg");
         // error por publicacion con usuario nulo (por herencia de publicacion a imagen)
         try
         {
            new Imagen(DateTime.Now, "", null);
         }
         catch (Exception excepcion)
         {
            Console.WriteLine(" !! error en creacion de imagen: " + excepcion.Message);
         }

         //prueba 1 sencilla
         Console.WriteLine(publicacion1);
         Console.WriteLine(imagen1);

         Console.WriteLine(divisor);
         Console.WriteLine(" agregando usuarios a la clase contenedora... ");
         RedSocial.AddUsuario(usuario1);
         RedSocial.AddUsuario(usuario2);
         RedSocial.AddUsuario(usuario3);
         RedSocial.AddUsuario(usuario4);

         Console.WriteLine(divisor);
         Console.WriteLine(" agregando opciones no validas a la clase contenedora... ");
         try
         {
            RedSocial.AddUsuario(null);
         }
         catch (Exception excepcion)
         {
            Console.WriteLine(" !! error: " + excepcion.Message);
         }
         try
         {
            RedSocial.AddUsuario(usuario3);
         }
         catch (Exception excepcion)
         {
            Console.WriteLine(" !! error: " + excepcion.Message);

         }

         // mostrar los usuarios de la clase controladora
         Console.WriteLine(divisor);
         MostrarTodo();

         // prueba de eliminacion de publicaciones
         Console.WriteLine(divisor);
         try
         {
            usuario1.BorrarPublicacion(publicacion6);
         }
         catch (Exception excepcion)
         {
            Console.WriteLine(" !! error: " + excepcion.Message);
         }
         usuario2.BorrarPublicacion(publicacion6);
         Console.WriteLine(divisor);
         MostrarTodo();

         // prueba seguidores y seguidos
         Console.WriteLine(divisor);
         Console.WriteLine(" pruebas de funcion seguir...");
         usuario1.Seguir(usuario2);
         usuario1.Seguir(usuario4);
         usuario2.Seguir(usuario1);
         usuario2.Seguir(usuario4);
         usuario3.Seguir(usuario1);
         usuario3.Seguir(usuario2);
         usuario3.Seguir(usuario4);

         // prueba seguirse a si mismo y seguir a alguien que ya sigue
         Console.WriteLine(divisor);
         try
         {
            usuario1.Seguir(usuario1);
         }
         catch (Exception excepcion)
         {
            Console.WriteLine(" !! error: " + excepcion.Message);
         }
         try
         {
            usuario1.Seguir(usuario2);
         }
         catch (Exception excepcion)
         {
            Console.WriteLine(" !! error: " + excepcion.Message);
         }

         Console.WriteLine(divisor);
         MostrarSeguimientos();
         Console.WriteLine(divisor);

         // prueba de stopSeguir()
         try
         {
            usuario1.StopSeguir(null);
         }
         catch (Exception excepcion)
         {
            Console.WriteLine(" !! error: " + excepcion.Message);
         }
         try
         {
            usuario4.StopSeguir(usuario1);
         }
         catch (Exception excepcion)
         {
            Console.WriteLine(" !! error: " + excepcion.Message);
         }
         usuario3.StopSeguir(usuario1);
         usuario2.StopSeguir(usuario1);

         Console.WriteLine(divisor);
         MostrarSeguimientos();

         // prueba me gusta
         Console.WriteLine(divisor);
         Console.WriteLine(" pruebas de funcion megusta...");
         usuario1.MeGusta(publicacion2);
         usuario1.MeGusta(publicacion3);
         usuario1.MeGusta(imagen4);
         usuario3.MeGusta(publicacion2);
         usuario3.MeGusta(imagen4);
         usuario4.MeGusta(publicacion3);
         usuario4.MeGusta(publicacion2);
         usuario4.MeGusta(imagen4);

         // prueba gustar de algo ya gustado (al ser bool solo se quita de la lista)
         Console.WriteLine(divisor);
         try
         {
            usuario3.MeGusta(imagen4);
         }
         catch (Exception excepcion)
         {
            Console.WriteLine(" !! error: " + excepcion.Message);
         }
         // prueba gustar de algo nulo
         try
         {
            usuario3.MeGusta(null);
         }
         catch (Exception excepcion)
         {
            Console.WriteLine(" !! error: " + excepcion.Message);
         }

         Console.WriteLine(divisor);
         MostrarGustados(usuario1);
         MostrarGustados(usuario3);
         MostrarGustados(usuario4);
         MostrarGustaron(publicacion2);
         MostrarGustaron(publicacion3);
         MostrarGustaron(imagen4);

         Console.WriteLine(divisor);
         Console.WriteLine("\n presione una tecla para salir ");
         Console.ReadKey();
      }

      private static void MostrarTodo()
      {
         Console.WriteLine(" lista de usuarios y publicaciones: ");
         foreach (var usuario in RedSocial.GetUsuarios())
         {
            Console.WriteLine(" usuario: " + usuario + "\n publicaciones: ");
            foreach (var publicacion in usuario.GetPublicaciones())
               Console.WriteLine(publicacion);
         }
      }

      private static void MostrarSeguimientos()
      {
         Console.WriteLine(" lista de usuarios y seguidos/seguidores: ");
         foreach (var usuario in RedSocial.GetUsuarios())
         {
            Console.WriteLine(" usuario: " + usuario + "\n seguidos: ");
            foreach (var seguido in usuario.GetSeguidos())
            {
               Console.WriteLine($" - {seguido}");
            }
            Console.WriteLine(" seguidores: ");
            foreach (var seguidor in usuario.GetSeguidores())
            {
               Console.WriteLine($" - {seguidor}");
            }
         }
      }

      private static void MostrarGustados(Usuario usuario)
      {
         Console.WriteLine("Gustados de " + usuario);
         foreach (var publicacion in usuario.GetGustados())
         {
            Console.WriteLine(" -> " + publicacion); 
         }
      }

      private static void MostrarGustaron(Publicacion publicacion)
      {
         Console.WriteLine("MeGusta de la publicacion " + publicacion);
         foreach (var usuario in publicacion.GetGustaron())
         {
            Console.WriteLine(" -> " + usuario);
         }
      }

      private static void MostrarGustaron(Imagen imagen)
      {
         Console.WriteLine("MeGusta de la imagen " + imagen);
         foreach (var usuario in imagen.GetGustaron())
         {
            Console.WriteLine(" -> " + usuario);
         }
      }
   }
}
