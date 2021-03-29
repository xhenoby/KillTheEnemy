using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaciones : MonoBehaviour
{
    int vida;
    Animator anim;
    public bool Der, Izq;
    public PlayerDer playerDer;
    public PlayerIzq playerIzq;

    void Start()
    {
        anim = GetComponent<Animator>();
        vida = 21;
    }
    void Update()
    {
        anim.SetInteger("Vida", vida);
        if (Der)
        {
            vida = playerDer.vida;
            anim.SetInteger("Vida", vida);
            if (vida < 1)
            {
                Destroy(playerDer.gameObject);
                Destroy(this);
            }
        }
        if (Izq)
        {
            vida = playerIzq.vida;
            anim.SetInteger("Vida", vida);
            if (vida < 1)
            {
                Destroy(playerIzq.gameObject);
                Destroy(this);
                
            }
        }
    }
}
