using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    private Queue<string> sentences;
    private Queue<string> names;

    public AudioSource textDisplaySound;

    void Awake()
    {
        textDisplaySound = GetComponent<AudioSource>();
        sentences = new Queue<string>();
        names = new Queue<string>();

    }

    public void StartDialogue (Dialogue dialogue)
    {
        names.Clear();

        foreach (string name in dialogue.names)
        {
            names.Enqueue(name);
        }
        DisplayNextName();
        
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextName()
    {
        if(names.Count == 0)
        {
            EndDialogue();
            return;
        }

        string name = names.Dequeue();
        nameText.text = name;
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        textDisplaySound.Play();
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.04f);
        }
        textDisplaySound.Stop();
    }

    public bool dialogueEnd = false;
    void EndDialogue()
    {
        Debug.Log("End of dialogue");
        dialogueEnd = true;
    }
}
