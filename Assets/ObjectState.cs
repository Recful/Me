using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectState : MonoBehaviour
{
    
    public PickUp pickUpClass;
    public GameObject AmyInteractable1;
    public GameObject AmyInteractable2;
    public GameObject JamesInteractableWithDoc;
    public GameObject JamesInteractableWithoutDoc;
    public GameObject pickUpInteractable;
    public DialogueManager conversationState;
    public bool hasEssential = false;
    public interactable state;
    public bool isDisable1 = false;
    public GameObject cardBattlePortal;
    public GameObject[] needToBeClosed;

    // Start is called before the first frame update
    void Start()
    {
        AmyInteractable2.SetActive(false);
        JamesInteractableWithoutDoc.SetActive(false);
        JamesInteractableWithDoc.SetActive(false);
        cardBattlePortal.SetActive(false);
    }

    void Update()
    {
        //disable the first interactable from Amy in office scene 1
        if(conversationState.currentSpeaker == "Amy" && isDisable1 == false && SceneManager.GetActiveScene().buildIndex == 2)
        {
            disableAmyInteractable1();
        }
        // enable the second interactable from Amy in office scene1
        if(isDisable1 == true)
        {
            enableAmyInteractable2();
        }

        //disable the second interactable in office scene 1
        if(conversationState.currentSpeaker == "James" && SceneManager.GetActiveScene().buildIndex == 2)
        {
            disableAmyInteractable2();
            disableGameObject();
        }

        if(pickUpClass.haveItem == true)
        {
            hasEssential = true;
            disablePickUp();
        }
        bossReaction();

        //disable day3 office 2 seat interactable
        if(SceneManager.GetActiveScene().buildIndex == 14 && conversationState.currentSpeaker == "Nate")
        {
            disableGameObject();
        }

    }
    public void disableAmyInteractable1()
    {
        AmyInteractable1.SetActive(false);
        isDisable1 = true;
    }

    public void disableAmyInteractable2()
    {
        AmyInteractable2.SetActive(false);
        cardBattlePortal.SetActive(true);
    }
    public void enableAmyInteractable2()
    {
        AmyInteractable2.SetActive(true);
    }

    public void disableGameObject()
    {
        for(int i = 0; i < needToBeClosed.Length; i++)
        {
            needToBeClosed[i].SetActive(false);
        }
    }

    public void disablePickUp()
    {
        if(hasEssential == true)
        {
            pickUpInteractable.SetActive(false);
        }
    }

    public void bossReaction()
    {
        if(hasEssential == true)
        {
            JamesInteractableWithDoc.SetActive(true);
            JamesInteractableWithoutDoc.SetActive(false);
        }
        else{
            JamesInteractableWithoutDoc.SetActive(true);
            JamesInteractableWithDoc.SetActive(false);
        }
    }
}
