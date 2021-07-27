using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject spriteFade;
    public DialogueManager dialogueManager;
    private AudioSource audioManager;

    void Start()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        audioManager = FindObjectOfType<AudioManager>().GetComponent<AudioSource>();
    }

    void Update()
    {
        if(dialogueManager.dialogueEnd)
        {
            FindObjectOfType<AudioManager>().Play("Fall");
            StartCoroutine(FadeAudioSource.StartFade(audioManager, 2.0f, 0f));
            spriteFade.GetComponent<LevelLoaderSpriteFade>().LoadNextLevel();
        }
    }
}
