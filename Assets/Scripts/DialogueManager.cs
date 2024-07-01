using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    
    public Text nameText;
    public Text dialogueText;
    public Animator animator;

    private Queue<string> sentences;
    private Queue<string> names;
    public bool endConversation = false;
    public string currentSpeaker;



    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        names = new Queue<string>();
    }

    
    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        
        // nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        foreach (string name in dialogue.names)
        {
            names.Enqueue(name);
        }

        DisplayNextSentence();
        
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0) 
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        string name = names.Dequeue();
        currentSpeaker = name;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence,name));
    }

    IEnumerator TypeSentence (string sentence, string name)
    {
        nameText.text = name;
        dialogueText.text = " ";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        endConversation = true;
    }
}
