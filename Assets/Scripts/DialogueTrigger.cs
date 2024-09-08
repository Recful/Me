using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue;
    

    public void TriggerDialogue()
    {
        
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

        /*
        while(true)
        {
            int sentenceLength = 2;
            if(FindObjectOfType<DialogueManager>().isEndDialogue == true || index == 0)
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue[index]);
                index++;
            }
            if(index == sentenceLength)
            {
                break;
            }
        }
        */
        
    }
}
