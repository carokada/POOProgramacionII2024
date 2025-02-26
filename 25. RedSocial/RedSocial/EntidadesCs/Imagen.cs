using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Imagen : Publicacion
   {
      public string File { get; private set; } //solo lectura set privado ??

      //inferido porque la imagen tapa el contenido
      public Imagen (DateTime fechaHora, string texto, Usuario usuario) : base(fechaHora, texto, usuario)
      {

      }

      public bool SubirImagen (string fileName)
      {
         if (string.IsNullOrEmpty(fileName))
            throw new ArgumentNullException(" no se ha especificado el nombre de archivo");
         File = fileName;
         return true;
      }

      public override string ToString()
      {
         return base.ToString() + $" <{File}>";
      }
   }
}
