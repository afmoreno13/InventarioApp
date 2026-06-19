// ============================================================
// SISTEMA DE INVENTARIO - Clase 1.1
// Estado: Mensaje de bienvenida
// ============================================================

using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;


MostarBanner();

if (args.Length > 0)
{
    switch (args[0].ToLower())
    {
        case "--help":
            MostrarAyuda();
            Environment.Exit(0);
            break;

        case "--version":
            Console.WriteLine($"InventarioApp v[{version}]");
            Environment.Exit(0);
            break;
            
        default:
            Console.WriteLine($"Error: comando desconocido '{args[0]}'");
            Console.WriteLine("Usa --help para ver las opciones disponibles");
            Environment.Exit(2);
            break;
    }
}

int cantidadProductos = 0;
//decimal valorTotalDelInventario = 0.00m;
bool sistemaActivo = true;
//string nombreSistema = "Sistema de Gestion de Inventario";
//decimal precio =19.99m;


/*
string? nombre = null;
int longitud = nombre.Length;
Console.WriteLine($"La longitud del nombre es: {longitud}");

// Problema: readline puede devolver null
Console.Write("Ingrese un valor: ");
string? entrada = Console.ReadLine();
int? longitud = entrada?.Length;

// Solucion Operador coalescing ??
//string comando = string.IsNullOrEmpty(entrada) ? "salir" : entrada;
string comandoLimpio = string.IsNullOrWhiteSpace(entrada) ? "salir" : entrada.Trim().ToLower();
Console.WriteLine($"Longitud: {longitud ?? 0}");
Console.WriteLine($"Comando: {comandoLimpio}");
*/


Console.WriteLine("Estado del sistema");
//Console.WriteLine($"Nombre: {nombreSistema}");
Console.WriteLine($"productos registrados: {cantidadProductos}");
//Console.WriteLine($"Valor total del inventario: ${valorTotalDelInventario:N2}");
Console.WriteLine($"Sistema activo: {(sistemaActivo ? "Si" : "No")}");
//Console.Write("Ingrese una cantidad: ");
//string? input = Console.ReadLine();

// Loop de nullabilidad
Console.WriteLine("Comandos: listar, agregar, buscar, salir");
Console.WriteLine();

while (sistemaActivo)
{
    Console.Write("inventario: ");
    string? entrada = Console.ReadLine();

    string comando = string.IsNullOrEmpty(entrada) ? "salir" : entrada.Trim().ToLower();
    switch (comando)
    {
        case "salir":
            sistemaActivo=false;
            Console.WriteLine("Hasta luego");
            break;
        case "listar":
            Console.WriteLine($"Productos de inventario: {cantidadProductos}");
            break;
        case "":
            break;
        default:
            Console.WriteLine($"Comando '{comando}' no reconocido");
            Console.WriteLine("Comandos disponibles: listar, agregar, buscar, salir");
            break;
    }
}



void MostarBanner()
{
    Console.WriteLine("==========================================");
    Console.WriteLine("    SISTEMA DE GESTIÓN DE INVENTARIO      ");
    Console.WriteLine("==========================================");
    Console.WriteLine();
    Console.WriteLine($"Version: {version}");
    Console.WriteLine($"Plataforma: {Environment.OSVersion}");
    Console.WriteLine($".NET Version: {Environment.Version}");
    Console.WriteLine();
}

void MostrarAyuda()
{
    Console.WriteLine("USO: InventarioApp [comando] [opciones]");
    Console.WriteLine();
    Console.WriteLine("COMANDOS:");
    Console.WriteLine("  --help, -h      Muestra esta ayuda");
    Console.WriteLine("  --version, -v   Muestra la version del programa");
    Console.WriteLine();
    Console.WriteLine("EJEMPLOS:");
    Console.WriteLine(" dotnet run -- --help");
    Console.WriteLine(" dotnet run -- --version");
}



