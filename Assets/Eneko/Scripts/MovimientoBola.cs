using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBola : MonoBehaviour
{
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().drag = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movHorizontal, 0.0f, movVertical);

        this.GetComponent<Rigidbody>().AddForce(movimiento * velocidad, ForceMode.Acceleration);

    }
}