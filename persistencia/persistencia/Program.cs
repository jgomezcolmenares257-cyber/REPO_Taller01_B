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
		    
	//TODO: Inplemen Functionality Here
		
            string dir = "./";

            Console.WriteLine("Desafío 1...");
            string entrada = "usuario;clave123";
            string[] partes = entrada.Split(';');
            
            if (partes.Length > 1 && partes[1].Contains("123"))
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(dir, "seguridad.txt")))
                {
                    sw.WriteLine("Clave Débil detectada");
                }
                Console.WriteLine("Aviso de seguridad generado.");
            }

            //Desafío 2: copiar archivo byte a byte con filestream 
            string origenimg = Path.Combine(dir, "imagen.JPG");
            string destinoimg = Path.Combine(dir, "respaldo.JPG");

            if(!File.Exists(origenimg)){
                File.WriteAllText(origenimg, "bin");
            }

            using(FileStream fs1 = new FileStream(origenimg, FileMode.Open))
            using(FileStream fs2 = new FileStream(destinoimg, FileMode.Create))
            {
                byte[] buffer = new byte[1024];
                int bytesLeidos;
                while ((bytesLeidos = fs1.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fs2.Write(buffer, 0, bytesLeidos);
                }
            }

            //Desafío 3: Buscar y borrar archivos mayores a 5 KB
            DirectoryInfo info = new DirectoryInfo(dir);
            FileInfo[] lista = info.GetFiles();

            foreach (FileInfo Archi in lista){
                if(Archi.Length > 5120){
                    Console.WriteLine("activando archivo pesado: " + Archi.Name);
                }
            }

            Console.WriteLine("proceso finalizado:");
            Console.ReadKey(true);
		}
	}
}
