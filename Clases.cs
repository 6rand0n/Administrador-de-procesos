using SOProyecto;
using System;
using System.Collections.Generic;
using System.Linq;
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

    public BloqueMemoria(int inicio, int tamaño)
    {
        Inicio = inicio;
        Tamaño = tamaño;
        EstaLibre = true;
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

    // Constructor
    public Proceso(int id, string nombre, int memoria, int cpu, int tiempoEjecucion, int procesamiento)
    {
        ID = id;
        Nombre = nombre;
        Memoria = memoria;
        CPU = cpu;
        TiempoEjecucion = tiempoEjecucion;
        TiempoRestante = tiempoEjecucion;
        Estado = "Inicializando"; // Estado inicial
        Swap = "En espera";
        Procesamiento = procesamiento;
    }
}