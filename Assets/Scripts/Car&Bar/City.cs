using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour
{
    public Dialogue dialogue;
    //public GameObject spriteFade;
    public DialogueManager dialogueManager;
    //private AudioSource audioManager;

    void Start()
    {
        Invoke("PlaySong", 15.0f);
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public void Quit()
    {
        Application.Quit();
    }

    void PlaySong()
    {
        FindObjectOfType<AudioManager>().Play("ItGoesOn");
    }
}
