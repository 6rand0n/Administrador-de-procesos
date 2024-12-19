using SOProyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SOProyecto
{
    internal class Clases
    {
    }
}
public class BloqueMemoria
{
    public int Inicio { get; set; }
    public int Tamaño { get; set; }
    public bool EstaLibre { get; set; }
    public int? ProcesoID { get; set; }
    public BloqueMemoria Buddy { get; set; } // Nuevo campo para el buddy del bloque

    public BloqueMemoria(int inicio, int tamaño)
    {
        Inicio = inicio;
        Tamaño = tamaño;
        EstaLibre = true;
        ProcesoID = null;
        Buddy = null;  // Inicializamos el buddy como null
    }
}

public class AsignadorMemoria
{
    private List<BloqueMemoria> bloquesMemoria;

    public AsignadorMemoria(int tamañoMemoria)
    {
        bloquesMemoria = new List<BloqueMemoria>
        {
            new BloqueMemoria(0, tamañoMemoria)
        };
    }

    // Método para encontrar el bloque adecuado para asignar memoria
    public BloqueMemoria EncontrarBloqueAdecuado(int tamano)
    {
        foreach (var bloque in bloquesMemoria)
        {
            if (bloque.EstaLibre && bloque.Tamaño >= tamano)
            {
                return bloque; // Retorna el primer bloque libre que sea adecuado
            }
        }
        return null; // Si no se encontró un bloque adecuado
    }

    // Método para dividir un bloque en dos bloques (buddy)
    public void DividirBloque(BloqueMemoria bloque, int tamano)
    {
        // Si el tamaño del bloque es mayor que el tamaño solicitado, lo dividimos
        if (bloque.Tamaño > tamano)
        {
            int mitad = bloque.Tamaño / 2;
            BloqueMemoria bloqueNuevo = new BloqueMemoria(bloque.Inicio + mitad, mitad);

            bloque.Tamaño = mitad; // El bloque original ahora tiene el tamaño reducido
            bloque.Buddy = bloqueNuevo; // Asignamos el buddy

            // El bloque nuevo se marca como libre
            bloqueNuevo.EstaLibre = true;
            bloqueNuevo.ProcesoID = null;
        }
    }


    // Método para asignar memoria (usando Buddy System)
    public bool AsignarMemoria(int id, int tamano, int ejecucion)
    {
        // Llamamos a EncontrarBloqueAdecuado para obtener el primer bloque adecuado
        BloqueMemoria bloque = EncontrarBloqueAdecuado(tamano);

        // Si no se encuentra un bloque adecuado, devolvemos false
        if (bloque == null)
        {
            Console.WriteLine($"No hay suficiente memoria para asignar {tamano} unidades.");
            return false;
        }

        // Si el bloque es mayor que el tamaño necesario, lo dividimos
        while (bloque.Tamaño > tamano)
        {
            // Verifica que el buddy esté correctamente asignado
            if (bloque.Buddy == null)
            {
                // Creación y asignación de buddy si es necesario
                bloque.Buddy = new BloqueMemoria(bloque.Inicio + bloque.Tamaño / 2, bloque.Tamaño / 2);
            }

            DividirBloque(bloque, tamano);
            bloque = bloque.Buddy; // Asignamos el buddy para la división recursiva
        }

        // Asignamos memoria al bloque
        bloque.EstaLibre = false;
        bloque.ProcesoID = id;

        return true;
    }



    // Liberar memoria y combinar con el buddy si está libre
    public void LiberarMemoria(int id)
    {
        foreach (var bloque in bloquesMemoria)
        {
            if (bloque.ProcesoID == id)
            {
                bloque.EstaLibre = true;
                bloque.ProcesoID = null;

                // Intentamos combinar el bloque con su buddy
                CombinarBloques(bloque);
                break;
            }
        }
    }

    // Combina bloques de memoria si ambos están libres
    public void CombinarBloques(BloqueMemoria bloque)
    {
        if (bloque.Buddy != null && bloque.Buddy.EstaLibre)
        {
            // Actualizamos el tamaño y eliminamos el buddy
            bloque.Tamaño *= 2;
            bloquesMemoria.Remove(bloque.Buddy);
            bloque.Buddy = null;
        }
    }

    public List<BloqueMemoria> ObtenerBloquesMemoria()
    {
        return bloquesMemoria;
    }
    public void ImprimirEstadoMemoria()
    {
        foreach (var bloque in bloquesMemoria)
        {
            string estado = bloque.EstaLibre ? "[0," : "[1,";
            Console.WriteLine($"{estado}{bloque.Tamaño},{bloque.Inicio}]");
            if (bloque.Buddy != null)
            {
                Console.WriteLine($"  Buddy: {bloque.Buddy.Inicio}, {bloque.Buddy.Tamaño}");
            }
        }
    }
}


public class Proceso
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public int Memoria { get; set; }
    public int CPU { get; set; }
    public int TiempoEjecucion { get; set; }
    public int TiempoRestante { get; set; }
    public string Estado { get; set; }
    public string Swap { get; set; }
    public int TiempoEnAmarillo { get; set; } // Tiempo en estado "Inicializando"
    public int TiempoTerminado { get; set; }
    public int Procesamiento {  get; set; }

    public DateTime? TiempoInicio { get; set; } //tiempo del proceso

    // Constructor
    public Proceso(int id, string nombre, int memoria, int cpu, int tiempoEjecucion, int procesamiento)
    {
        ID = id;
        Nombre = nombre;
        Memoria = memoria;
        CPU = cpu;
        TiempoEjecucion = tiempoEjecucion;
        TiempoRestante = tiempoEjecucion;
        Estado = "Ready"; // Estado inicial
        Swap = "En espera";
        Procesamiento = procesamiento;
        TiempoInicio = null;
    }

    


}
