using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackIzq : MonoBehaviour
{
    private float espera, tiempo;
    private bool inRange1, inRange2;
    public GameObject PlayerDer1, PlayerDer2;
    public Animator fatheranimator, animator;
    PlayerDer playerDer1, playerDer2;
    PlayerIzq playerIzq;
    public int damage;
    #region BasicFuncions
    void Start()
    {
        if(PlayerDer1!=null)
        playerDer1 = PlayerDer1.GetComponent<PlayerDer>();
        if(PlayerDer2!=null)
        playerDer2 = PlayerDer2.GetComponent<PlayerDer>();
        playerIzq = GetComponentInParent<PlayerIzq>();
        espera = 1;  

    } 

    void FixedUpdate()
    {
        if (playerIzq.vida > 3)
        {
            if (playerIzq.vida < 10)
            {
                espera = 0.75f;
            }
        }
        else
        {
            espera = 0.5f;
        } 
        damage = playerIzq.damage;
        tiempo -= Time.deltaTime;
    }
    #endregion
    #region Funciones
    public void Attack()
    {
        if (tiempo <= 0)
        {
            animator.SetTrigger("Ataque");
            fatheranimator.SetTrigger("Atack");
            if (inRange1&&playerDer1!=null&&!playerDer1.isInmortal)
            {
                playerDer1.vida -= damage;
                playerDer1.atacked = true;
            }
            if (inRange2&&playerDer2!=null&& !playerDer2.isInmortal)
            {
                playerDer2.vida -= damage;
                playerDer2.atacked = true;
            }
            tiempo = espera;
        }
    }
    #endregion
    #region Colsiones
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PlayerDer1")
        {
            inRange1 = true;
        }
        if (col.gameObject.tag == "PlayerDer2")
        {
            inRange2 = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "PlayerDer1")
        {
            inRange1 = false;
        }
        if (col.gameObject.tag == "PlayerDer2")
        {
            inRange2 = false;
        }
    }
    #endregion
}
