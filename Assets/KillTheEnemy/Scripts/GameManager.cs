using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject puertaN, puertaB, kill, the, enemy, pressSpace, player1, player2, player3, player4, BlackWin, WhiteWin, Tie,Restart;
    Animator animKill, animThe, animEnemy, animPressSpace;
    private bool Started,Finished;
    AudioManager audioManager;
    [SerializeField] private PlayerInput playerInput;
    bool ended;
    private void OnSpace(InputValue value)
    {
        if (!Started)
        {
            puertaN.transform.position = new Vector2(10.5f, 2);
            puertaB.transform.position = new Vector2(-10.5f, 2);
            animPressSpace.Play("PressSpaceEnding");
            animKill.Play("Outro");
            animThe.Play("OutroThe");
            animEnemy.Play("OutroKill");
            Started = true;
        }
        if (Finished)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    void Start()
    {
        ended = false;
        animKill = kill.GetComponent<Animator>();
        animThe = the.GetComponent<Animator>();
        animEnemy = enemy.GetComponent<Animator>();
        animPressSpace = pressSpace.GetComponent<Animator>();
        puertaN.transform.position = new Vector2(-10.5f, 2);
        puertaB.transform.position = new Vector2(10.5f, 2);
        WhiteWin.SetActive(false);
        BlackWin.SetActive(false);
        Tie.SetActive(false);
        Restart.SetActive(false);
        Started = false;
        Finished = false;
        audioManager = FindObjectOfType<AudioManager>();
    }
    void Update()
    {
        if (player1 == null && player2 == null)
        {
            if (!ended)
            {
               StartCoroutine(End());
            }
        }
        else if (player3 == null && player4 == null)
        {
            if (!ended)
            {
                StartCoroutine(End());
            }
        }
    }
    IEnumerator End()
    {
        ended = true;
        yield return new WaitForSeconds(1f);
        if (player1 == null && player2 == null)
        {
            if ((player3 != null || player4 != null))
            {
                BlackWin.SetActive(true);
                audioManager.WeWon();
            }
            else
            {
                Tie.SetActive(true);
                audioManager.WeDied();
            }
        }
        else if (player3 == null && player4 == null)
        {
            if ((player1 != null || player2 != null))
            {
                WhiteWin.SetActive(true);
                audioManager.WeWon();
            }
            else
            {
                Tie.SetActive(true);
                audioManager.WeDied();
            }
        }
        else
        {
            Tie.SetActive(true);
            audioManager.WeDied();
        }
        Restart.SetActive(true);
        Finished = true;
    }
}
