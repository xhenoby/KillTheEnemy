using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AtackDer : MonoBehaviour
{
    private float espera, tiempo;
    public bool inRange1, inRange2;
    public GameObject PlayerIzq1, PlayerIzq2;
    public Animator fatheranimator,animator;
    PlayerDer playerDer;
    PlayerIzq playerIzq1, playerIzq2;
    public int damage;
    #region BasicFunctions
    void Start()
    {
        playerDer = GetComponentInParent<PlayerDer>();
        if(PlayerIzq1!=null)
        playerIzq1 = PlayerIzq1.GetComponent<PlayerIzq>();
        if(PlayerIzq2!=null)
        playerIzq2 = PlayerIzq2.GetComponent<PlayerIzq>();
        espera = 1;
    }
    void FixedUpdate()
    {
        if (playerDer.vida > 3)
        {
            if (playerDer.vida < 10)
            {
                espera = 0.75f;
            }
        }
        else
        {
            espera = 0.5f;
        }
        damage = playerDer.damage;
        tiempo -= Time.deltaTime;
    }
    #endregion
    #region Functions
    public void Attack()
    {
        if (tiempo <= 0)
        {
            animator.SetTrigger("Ataque");
            fatheranimator.SetTrigger("Atack");
            if (inRange1&&playerIzq1!=null&& !playerIzq1.isInmortal)
            {
                playerIzq1.vida -= damage;
                playerIzq1.atacked = true;
            }
            if (inRange2&&PlayerIzq2!=null&& !playerIzq2.isInmortal)
            {
                playerIzq2.vida -= damage;
                playerIzq2.atacked = true;
            }
            tiempo = espera;
        }
    }
    #endregion
    #region Collisions
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PlayerIzq1")
        {
            inRange1 = true;
        }
        if (col.gameObject.tag == "PlayerIzq2")
        {
            inRange2 = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "PlayerIzq1")
        {
            inRange1 = false;
        }
        if (col.gameObject.tag == "PlayerIzq2")
        {
            inRange2 = false;
        }
    }
    #endregion
}
