/*
 * Creado por SharpDevelop.
 * Usuario: JULIO
 * Fecha: 17/4/2026
 * Hora: 2:23 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace persistencia
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// directorio
			string rutaRiz = Path .conbine(AppDomain.CurrentDomain.BaseDirectory,"DATOSIUJO");
		    string rutareportes =  Path.Combine(rutaRiz, "reporte");

	Console.Writeline(rutaRiz);
		    Console.WriteLine(rutareportes);
		    
		    if(!Directory.Exists (rutareportes)){
		    	Directory.createDirectory(rutareportes);
		    	Console.WriteLine("directorio creado correctamente");
		    }
		    
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}