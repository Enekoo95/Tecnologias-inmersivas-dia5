using UnityEngine;


public class Recompensa : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bola"))
        {
            Debug.Log("¡Recompensa recogida!"); // Esto debe aparecer en la consola
            FindObjectOfType<RecompensaManager>().RecolectarRecompensa();
            Destroy(gameObject);
        }
    }
}


