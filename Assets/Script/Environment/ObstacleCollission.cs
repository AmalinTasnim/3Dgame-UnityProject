using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollission : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource crash;
    public GameObject levelControl;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMovement>().enabled = false;
        charModel.GetComponent<Animator>().Play("CharacterArmature|Death");
        crash.Play(); 
        levelControl.GetComponent<EndRunSequence>().enabled = true;
    } 
}
