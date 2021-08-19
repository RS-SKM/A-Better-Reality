using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bedroom : MonoBehaviour
{
    public Dialogue dialogue;
    public DialogueManager dialogueManager;
    public GameObject drug;
    public GameObject canvas;

    void Start()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        drug = GameObject.Find("Drug");
        drug.SetActive(false);
    }

    void Update()
    {
        if(dialogueManager.dialogueEnd)
        {
            drug.SetActive(true);
        }
    }

    public void DeactivateButton()
    {
        canvas = GameObject.Find("Canvas");
        canvas.SetActive(false);
    }
}
