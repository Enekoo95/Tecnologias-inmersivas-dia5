using UnityEngine;
using UnityEngine.UI;

public class RecompensaManager : MonoBehaviour
{
    private int totalRecompensas;
    private int recompensasRecogidas = 0;

    public Text mensajeFinal;  // Texto para mostrar cuando recoge todas
    public Text contadorTexto; // Texto para mostrar cuántas lleva

    void Start()
    {
        // Contamos todas las recompensas en la escena
        totalRecompensas = GameObject.FindGameObjectsWithTag("Recompensa").Length;

        // Ocultamos el mensaje final al inicio
        mensajeFinal.gameObject.SetActive(false);

        // Mostramos el contador inicial
        ActualizarContador();
    }

    public void RecolectarRecompensa()
    {
        recompensasRecogidas++;
        ActualizarContador();

        if (recompensasRecogidas >= totalRecompensas)
        {
            Debug.Log("YOU WIN"); // Verifica si este mensaje aparece en la consola
            mensajeFinal.text = "YOU WIN";
            mensajeFinal.enabled = true; // Asegura que el texto está habilitado
            mensajeFinal.gameObject.SetActive(true); // Activa el objeto
        }
    }

    void ActualizarContador()
    {
        contadorTexto.text = "Recompensas: " + recompensasRecogidas + " / " + totalRecompensas;
    }
}
