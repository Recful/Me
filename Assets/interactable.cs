using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interactable : MonoBehaviour
{
    
    public GameObject interactionUI;
    public Animator UIExit;
    public float UIExitTime;
    public DialogueTrigger startDialogue;
    public GameObject dialogueUI;
    public GameObject conversationBubble;
    public bool interactAllowed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) == true && interactAllowed == true)
        {
            dialogueUI.SetActive(true);
            startDialogue.TriggerDialogue();
            conversationBubble.SetActive(false);
            interactAllowed = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = collision.gameObject;
        if(player.name == "Player")
        {
            interactionUI.SetActive(true);
            interactAllowed = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            UIExit.SetTrigger("exit");
            Invoke("InteractionUIDisappear", UIExitTime);
            interactAllowed = false;
        }
    }
    void InteractionUIDisappear()
    {
        interactionUI.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            interactAllowed = true;
        }
    }

}
