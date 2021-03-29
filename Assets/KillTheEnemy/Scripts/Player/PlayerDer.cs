using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerDer : Player
{
    public AtackDer atackDer1, atackDer2, atackDer3;

    #region Inputs
    private void OnAttack(InputValue valor)
    {
        atackDer1.Attack();
        atackDer2.Attack();
        atackDer3.Attack();
    }
    #endregion
    #region UnityFunctions
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        box = GetComponent<BoxCollider2D>();
        vida = 21;
        anim.SetInteger("Vida", vida);
        damage = 3;
        particleSystem = GetComponentInChildren<ParticleSystem>();
    }
    void FixedUpdate()
    {
        anim.SetBool("Grounded", grounded);
        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));
        if (atacked)
        {
            LifeState();
            anim.SetInteger("Vida", vida);
            atacked = false;
        }
        Movement();
    }
    #endregion UnityFunctions UnityFunctions
    #region PublicFunctions   
    public void LifeState()
    {
        if (vida > 3)
        {
            if (vida < 10)
            {
                basura1.GetComponent<Basura>().bas = false;
                box.size = new Vector2(0.3f, 0.8f);
                damage = 2;
                speed = 3;
                jumpPower = 7.5f;
                Nuevo.SetActive(true);
                Actual.SetActive(false);
            }
        }
        else
        {
            basura2.GetComponent<Basura>().bas = false;
            box.size = new Vector2(0.2f, 0.2f);
            box.offset = new Vector2(-0.02f, 0);
            damage = 1;
            speed = 4;
            jumpPower = 8.5f;
            MasNuevo.SetActive(true);
            Nuevo.SetActive(false);
        }
    }
    #endregion
}