using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class interactable2 : MonoBehaviour
{
    
    public GameObject interactionUI;
    public Animator UIExit;
    public float UIExitTime;
    public DialogueTrigger startDialogue;
    public DialogueManager Getname;
    public GameObject dialogueUI;
    public GameObject conversationBubble;
    public LevelLoader levelLoader;

    [Header("End animation UI")]
    public GameObject SleepUIBlack;
    public GameObject cometCover;
    public Animator cometTrigger;
    public GameObject Chapter1EndUI;
    public Animator endingTrigger;
    public GameObject notificationUI;
    public Animator showingNotification;
    public GameObject blackBackgroud;
    public Animator background;
    public GameObject notificationSound;
    public GameObject cometSound;
    public float showCometTime = 1f;
    public float CometAnimationTime = 1f;
    public float showComputerTime = 1f;
    public float showChatTime = 1f;
    public float showBlackTime = 1f;
    public float returnToMainTime = 1f;

    private bool enterNextSceneAllowed = false;

    //only for the music
    public bool hit = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //enter the office scene
        if(Input.GetKeyDown(KeyCode.E) == true && enterNextSceneAllowed == true && SceneManager.GetActiveScene().buildIndex == 1)
        {
            levelLoader.LoadNextLevel();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        //enter the card battle 1
        if(Input.GetKeyDown(KeyCode.E) == true && enterNextSceneAllowed == true && Getname.currentSpeaker == "Nate" && SceneManager.GetActiveScene().buildIndex == 2)
        {
            levelLoader.LoadNextLevel();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        //enter the home scene
        if(Input.GetKeyDown(KeyCode.E) == true && enterNextSceneAllowed == true && SceneManager.GetActiveScene().buildIndex == 4)
        {
            levelLoader.LoadNextLevel();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        //enter day2 scene
        if(Input.GetKeyDown(KeyCode.E) == true && enterNextSceneAllowed == true && SceneManager.GetActiveScene().buildIndex == 5)
        {
            levelLoader.LoadNextLevel();
        }
        //enter office 2
        if(Input.GetKeyDown(KeyCode.E) == true && enterNextSceneAllowed == true && SceneManager.GetActiveScene().buildIndex == 6)
        {
            levelLoader.LoadNextLevel();
        }
        //enter office 2.3
        if(Input.GetKeyDown(KeyCode.E) == true && enterNextSceneAllowed == true && SceneManager.GetActiveScene().buildIndex == 7)
        {
            levelLoader.LoadNextLevel();
        }
        //enter the card battle 2
        if(Input.GetKeyDown(KeyCode.E) == true && enterNextSceneAllowed == true && Getname.currentSpeaker == "Nate" && SceneManager.GetActiveScene().buildIndex == 9)
        {
            levelLoader.LoadNextLevel();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        //enter the home2 scene
        if(Input.GetKeyDown(KeyCode.E) == true && enterNextSceneAllowed == true && SceneManager.GetActiveScene().buildIndex == 11)
        {
            levelLoader.LoadNextLevel();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        //enter day3 scene
        if(Input.GetKeyDown(KeyCode.E) == true && enterNextSceneAllowed == true && SceneManager.GetActiveScene().buildIndex == 12)
        {
            levelLoader.LoadNextLevel();
        }
        //enter day3 bus scene
        if(Input.GetKeyDown(KeyCode.E) == true && enterNextSceneAllowed == true && SceneManager.GetActiveScene().buildIndex == 13)
        {
            levelLoader.LoadNextLevel();
        }
        //enter day3 office
        if(Input.GetKeyDown(KeyCode.E) == true && enterNextSceneAllowed == true && SceneManager.GetActiveScene().buildIndex == 14)
        {
            levelLoader.LoadNextLevel();
        }
        //enter day3 office
        if(Input.GetKeyDown(KeyCode.E) == true && Getname.currentSpeaker == "Nate" && enterNextSceneAllowed == true && SceneManager.GetActiveScene().buildIndex == 15)
        {
            levelLoader.LoadNextLevel();
        }
        //enter the card battle 2
        if(Input.GetKeyDown(KeyCode.E) == true && Getname.currentSpeaker == "Nate" && enterNextSceneAllowed == true && SceneManager.GetActiveScene().buildIndex == 17)
        {
            levelLoader.LoadNextLevel();
        }
        //enter day3 home1
        if(Input.GetKeyDown(KeyCode.E) == true && Getname.currentSpeaker == "Nate" && enterNextSceneAllowed == true && SceneManager.GetActiveScene().buildIndex == 19)
        {
            levelLoader.LoadNextLevel();
        }
        //enter day3 home2
        if(Input.GetKeyDown(KeyCode.E) == true && Getname.currentSpeaker == "Nate" && enterNextSceneAllowed == true && SceneManager.GetActiveScene().buildIndex == 20)
        {
            levelLoader.LoadNextLevel();
        }

        // enter the UI Animation END OF CHAPTER1
        if(Input.GetKeyDown(KeyCode.E) == true && Getname.currentSpeaker == "Nate" && enterNextSceneAllowed == true && SceneManager.GetActiveScene().buildIndex == 21)
        {
            SleepUIBlack.SetActive(true);
            Invoke("showComet", showCometTime);
            
        }
        
        // Chapter 2 Day 4 start C2D4_1
        if(Input.GetKeyDown(KeyCode.E) == true && Getname.currentSpeaker == "Nate" && enterNextSceneAllowed == true && SceneManager.GetActiveScene().buildIndex == 22)
        {
            levelLoader.LoadNextLevel();
        }

        // Chapter 2 Day 4 start C2D4_2
        if(Input.GetKeyDown(KeyCode.E) == true && Getname.currentSpeaker == "Nate" && enterNextSceneAllowed == true && SceneManager.GetActiveScene().buildIndex == 23)
        {
            levelLoader.LoadNextLevel();
        }

        // Chapter 2 Day 4 start C2D4_3
        if(Input.GetKeyDown(KeyCode.E) == true && Getname.currentSpeaker == "Nate" && enterNextSceneAllowed == true && SceneManager.GetActiveScene().buildIndex == 24)
        {
            levelLoader.LoadNextLevel();
        }

        // Chapter 2 Day 4 start C2D4_4 (done the jump game)
        if(Input.GetKeyDown(KeyCode.E) == true && Getname.currentSpeaker == "Nate" && enterNextSceneAllowed == true && SceneManager.GetActiveScene().buildIndex == 26)
        {
            levelLoader.LoadNextLevel();
        }

        // Chapter 2 Day 4 start C2D4_5
        if(Input.GetKeyDown(KeyCode.E) == true && Getname.currentSpeaker == "Nate" && enterNextSceneAllowed == true && SceneManager.GetActiveScene().buildIndex == 27)
        {
            levelLoader.LoadNextLevel();
        }

        // Chapter 2 Day 5 start C2D5_1
        if(Input.GetKeyDown(KeyCode.E) == true && Getname.currentSpeaker == "Nate" && enterNextSceneAllowed == true && SceneManager.GetActiveScene().buildIndex == 28)
        {
            //play jump slipt game, scene 29
            levelLoader.LoadNextLevel();
        }


    }
    void showComet()
    {
        cometCover.SetActive(true);
        Invoke("showCometAnimation", CometAnimationTime);
        
    }
    void showCometAnimation()
    {
        cometTrigger.SetTrigger("StartComet");
        Invoke("showComputer", showComputerTime);
        cometSound.SetActive(true);
    }
    void showComputer()
    {
        Chapter1EndUI.SetActive(true);
        endingTrigger.SetTrigger("Action");
        Invoke("chatNotification", showChatTime);
    }
    void chatNotification()
    {
        notificationUI.SetActive(true);
        showingNotification.SetTrigger("Show");
        notificationSound.SetActive(true);
        Invoke("endBackground", showBlackTime);
    }
    void endBackground()
    {
        blackBackgroud.SetActive(true);
        background.SetTrigger("Start");
        Invoke("returnToMain", returnToMainTime);
    }
    void returnToMain()
    {
        levelLoader.LoadNextLevel();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = collision.gameObject;
        if(player.name == "Player")
        {
            dialogueUI.SetActive(true);
            startDialogue.TriggerDialogue();
            conversationBubble.SetActive(false);
            interactionUI.SetActive(true);

            //trigger let music quieter
            hit = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            UIExit.SetTrigger("exit");
            Invoke("InteractionUIDisappear", UIExitTime);
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
            enterNextSceneAllowed = true;
        }
    }
}
