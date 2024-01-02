using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGo;
    public GameObject fadeIn;
    public AudioSource readyFX;
    public AudioSource goFX;

    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1.0f);
        countDown3.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1.0f);
        countDown2.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1.0f);
        countDown1.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1.0f);
        countDownGo.SetActive(true);
        readyFX.Play();
        PlayerMovement.canMove = true;
    }
}
