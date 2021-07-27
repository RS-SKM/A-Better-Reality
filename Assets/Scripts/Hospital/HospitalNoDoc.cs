using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Playables;

public class HospitalNoDoc : MonoBehaviour
{
    public Dialogue dialogue;
    //public PlayableDirector playablesDirector;
    public DialogueManager dialogueManager;
    public GameObject closerLookButton;
    public GameObject canvas; 

    void Start()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        closerLookButton = GameObject.Find("CloserLookButton");
        closerLookButton.SetActive(false);
    }

    void Update()
    {
        if(dialogueManager.dialogueEnd)
        {
            closerLookButton.SetActive(true);
        }
    }

    public void PlaySoundtrack()
    {
        canvas = GameObject.Find("Canvas");
        canvas.SetActive(false);
        FindObjectOfType<AudioManager>().Play("Drifting Away");
    }
}
