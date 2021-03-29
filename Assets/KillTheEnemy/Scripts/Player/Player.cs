using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public GameObject basura1, basura2, Nuevo, Actual, MasNuevo,corazones, infinito;

    [HideInInspector] public int damage, vida;
    [HideInInspector] public bool isInmortal,grounded,atacked;
    [HideInInspector] public float speed = 2f, jumpPower = 6.5f, inputHorizontal;
    [HideInInspector] public Rigidbody2D rb2d;
    [HideInInspector] public Animator anim;
    [HideInInspector] public BoxCollider2D box;
    [HideInInspector]new public ParticleSystem particleSystem;

    [SerializeField] private PlayerInput playerInput;
    private void OnMove(InputValue valor)
    {
        inputHorizontal = valor.Get<float>();
    }
    private void OnJump(InputValue valor)
    {
        Jump();
    }
    public void Inmortality()
    {
        particleSystem.Play();
        isInmortal = true;
        corazones.transform.position += new Vector3(0, 100, 0);
        infinito.SetActive(true);
        speed *= 1.5f;
        StartCoroutine(Inmortal());
    }
    IEnumerator Inmortal()
    {
        yield return new WaitForSeconds(10f);
        speed /= 1.5f;
        particleSystem.Stop();
        corazones.transform.position -= new Vector3(0, 100, 0);
        infinito.SetActive(false);
        isInmortal = false;
    }
    public void Movement()
    {
        rb2d.velocity = new Vector2(inputHorizontal * speed, rb2d.velocity.y);
        if (inputHorizontal > 0)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        if (inputHorizontal < 0)
        {
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
    }
    public void Jump()
    {
        if (grounded)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
            rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }
    }
    #region Collisions
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            grounded = true;
        }

    }
    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            grounded = false;
        }
    }
    #endregion
}
