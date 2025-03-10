using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interpolaciones : MonoBehaviour
{


    public Transform ObjetoAMover;
    public Vector3 PosInicial = new Vector3(0, 0, 0);
    public Vector3 PosFinal = new Vector3(10, 0, 0);
    public float Duraci�n = 5f;
    public float Temporizador = 0f;

    public Light MiLuz;
    public Color ColorInicial = Color.red;
    public Color ColorFinal = Color.green;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Mi funci�n chaval", 5.0f, 4.0f);

    }

    // Update is called once per frame
    void Update()
    {
        Temporizador += Time.deltaTime;
        float t = Mathf.Clamp01(Temporizador/Duraci�n);
        ObjetoAMover.position = Vector3.Lerp(PosFinal,PosInicial, t);

        MiLuz.color = Color.Lerp(ColorInicial,ColorFinal,t);
    }

    void MiFuncion()
    {
        Debug.Log("He hecho la funci�n chaval");
    }


}
