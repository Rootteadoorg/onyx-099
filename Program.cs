using System;
using System.Diagnostics;
using System.Net;

class ONYX099
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("========================================");
        Console.WriteLine("|                                      |");
        Console.WriteLine("|   ONYX-099 by: Rootr | MortenTod     |");
        Console.WriteLine("|                                      |");
        Console.WriteLine("|                                      |");
        Console.WriteLine("|    created in: C# / @AnonymousCRI    |");
        Console.WriteLine("|                                      |");
        Console.WriteLine("========================================   ");
        Console.WriteLine("               ");
        Console.ResetColor();

        Console.Write("- Introduzca la URL del objetivo para escanear las IPs de la dirección (ejemplo: http://ejemplo.com): ");
        string targetaUrl = Console.ReadLine();
        Uri fenix = new Uri(targetaUrl);

        try
        {
            // Obtener todas las IPs asociadas con el dominio.
            IPAddress[] direccionesIp = Dns.GetHostAddresses(fenix.Host);

            if (direccionesIp.Length > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("       ");
                Console.WriteLine($"[-->] Se encontraron {direccionesIp.Length} direcciones IP para el dominio {fenix.Host}:");

                // Recorrer y mostrar las direcciones IP.
                foreach (IPAddress ip in direccionesIp)
                {
                    Console.WriteLine($"   - {ip}");
                }
                Console.ResetColor();

                Console.WriteLine("   ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Si quiere volver a escanear un objetivo escriba 1 o si quiere salir escriba 2.");
                Console.WriteLine("[+] Escriba 1");
                Console.WriteLine("[+] Escriba 2");
                Console.WriteLine("   ");
                string regresar = Console.ReadLine();
                if (regresar == "1")
                {
                    Menu();
                }
                else if (regresar == "2")
                {
                    Console.WriteLine("Saliendo de ONYX-099...");
                    Console.WriteLine("Gracias por usar ONYX-099 " +
                      "| X: @anonymousCRI - X: @elZtanomas |");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[-->] No se encontraron direcciones IP para el dominio {fenix.Host}.");
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[-->] Error al obtener las direcciones IP: {ex.Message}");
        }
        finally
        {
            Console.ResetColor();
        }
    }
}