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
    public BloqueMemoria(int inicio, int tamaño)
    {
        Inicio = inicio;
        Tamaño = tamaño;
        EstaLibre = true;
        ProcesoID = null;
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

    public List<BloqueMemoria> ObtenerBloquesMemoria()
    {
        return bloquesMemoria;
    }

    public bool AsignarMemoria(int id, int tamano, int ejecucion)
    {
        if (tamano > bloquesMemoria.Sum(b => b.EstaLibre ? b.Tamaño : 0))
        {
            return false;
        }


        for (int i = 0; i < bloquesMemoria.Count; i++)
        {
            if (bloquesMemoria[i].EstaLibre && bloquesMemoria[i].Tamaño >= tamano)
            {
                var nuevoBloque = new BloqueMemoria(bloquesMemoria[i].Inicio, tamano)
                {
                    EstaLibre = false,
                    ProcesoID = id
                };

                //ajustar bloque libre
                bloquesMemoria[i].Inicio += tamano;
                bloquesMemoria[i].Tamaño -= tamano;

                if (bloquesMemoria[i].Tamaño == 0)
                {
                    bloquesMemoria.RemoveAt(i);
                }
                //insterar un nuevo bloque y actualizarlo
                bloquesMemoria.Insert(i, nuevoBloque);

                return true;

            }

        }
        return false;
    }

    public void liberarMemoria(int id)
    {
        for (int i = 0; i < bloquesMemoria.Count; i++)
        {
            if (!bloquesMemoria[i].EstaLibre && bloquesMemoria[i].ProcesoID == id)
            {
                bloquesMemoria[i].EstaLibre = true;
                bloquesMemoria[i].ProcesoID = null;

                CombinarBloquesLibre();
                break;
            }
        }



    }

    public void CombinarBloquesLibre()
    {
        for (int i = 0; i < bloquesMemoria.Count - 1; i++)
        {
            if (bloquesMemoria[i].EstaLibre && bloquesMemoria[i + 1].EstaLibre)
            {
                bloquesMemoria[i].Tamaño += bloquesMemoria[i + 1].Tamaño;
                bloquesMemoria.RemoveAt(i + 1);
                i--;
            }
        }
        bloquesMemoria.RemoveAll(b => b.Tamaño == 0);
    }

    public void ImprimirEstadoMemoria()
    {
        foreach (var bloque in bloquesMemoria)
        {
            string estado = bloque.EstaLibre ? "[0," : "[1,";
            Console.WriteLine($"{estado}{bloque.Tamaño},{bloque.Inicio}]");
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
        Estado = "Inicializando"; // Estado inicial
        Swap = "En espera";
        Procesamiento = procesamiento;
        TiempoInicio = null;
    }

    


}
