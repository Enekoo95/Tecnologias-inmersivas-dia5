using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corutina : MonoBehaviour
{

    public Transform Destino;
    public float suavizado;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MiCorutina(Destino));
        Debug.Log("Seguimos chavaleeees");
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator MiCorutina(Transform MiDestino)
    {
        Debug.Log("Empezamos baby");
        while (Vector3.Distance(transform.position, MiDestino.position) > 0.05f)
        {
            Debug.Log("un movimiento sexy");
            transform.position = Vector3.Lerp(transform.position, MiDestino.position, suavizado * Time.deltaTime);
            yield return null;
        }
        Debug.Log("Se ha acabado el while que no te enteras");
        yield return new WaitForSeconds(3f);
        Debug.Log("Acabe");
    }
}
