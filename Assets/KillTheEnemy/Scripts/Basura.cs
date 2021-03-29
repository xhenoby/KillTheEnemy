using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basura : MonoBehaviour
{
    public GameObject player,basura,cabeza,torso,brazoder,brazizq,piernaizq,piernader,espada;
    public bool bas;
    void Start()
    {
        bas = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (bas == true)
        {
            basura.transform.position = player.transform.position;
        }
        if (bas == false)
        {
            cabeza.SetActive(true);
            torso.SetActive(true);
            brazizq.SetActive(true);
            brazoder.SetActive(true);
            piernader.SetActive(true);
            piernaizq.SetActive(true);
            espada.SetActive(true);
        }
     
    }
}
