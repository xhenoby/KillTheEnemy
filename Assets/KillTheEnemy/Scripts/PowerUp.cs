using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject Der1Inmortal, Der2Inmortal, Izq1Inmortal, Izq2Inmortal;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PlayerDer1")
        {
            Der1Inmortal.GetComponent<PlayerDer>().Inmortality();
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "PlayerDer2")
        {
            Der2Inmortal.GetComponent<PlayerDer>().Inmortality();
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "PlayerIzq1")
        {
            Izq1Inmortal.GetComponent<PlayerIzq>().Inmortality();
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "PlayerIzq2")
        {
            Izq2Inmortal.GetComponent<PlayerIzq>().Inmortality();
            Destroy(gameObject);
        }
    }
}
