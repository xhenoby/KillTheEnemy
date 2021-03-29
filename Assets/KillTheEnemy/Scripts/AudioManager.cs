using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource Sourcesong, SourceweDied, SourceweWon, SourcekillTheEnemy;
    private void Start()
    {
        StartCoroutine(StarSound());
    }
    private IEnumerator StarSound()
    {
        yield return new WaitForSeconds(2);
        Sourcesong.Play();
    }
    public void WeDied()
    {
        Sourcesong.Stop();
        SourceweDied.Play();
    }
    public void WeWon()
    {
        Sourcesong.Stop();
        Debug.Log("Start");
        SourceweWon.Play();
        Debug.Log("End");
    }
}
