using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneButtonFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject screen;
    public GameObject lightScreenButton;
    public GameObject screenUI;
    public GameObject playUI;
    public GameObject pauseUI;

    public float cutSceneTime;
    public GameObject cutSceneUI;

    public Animator transition;

    public GameObject tutorialUI;
    public Animator tutorialBoxExit;

    public GameObject chapter1Title;
    public Animator titleDisppear;
    public GameObject bus;

    [Header("Day3 UI")]
    public GameObject currentScreen;
    public GameObject secondScreen;
    public GameObject NextButton;
    public GameObject thirdScreen;
    public GameObject NextButton2;
    public GameObject finalButton;
    public GameObject BusSound;

    void Start()
    {
        screen = GameObject.Find("screen");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activeSecondScreen()
    {
        currentScreen.SetActive(false);
        secondScreen.SetActive(true);
        NextButton.SetActive(false);
        NextButton2.SetActive(true);

    }

    public void activeThirdScreen()
    {
        secondScreen.SetActive(false);
        thirdScreen.SetActive(true);
        NextButton2.SetActive(false);
        finalButton.SetActive(true);
    }
    public void enableBus(){
        Invoke("Bus",cutSceneTime );
    }

    void Bus()
    {
        bus.SetActive(true);
    }
    public void TitleAppear()
    {
        titleDisppear.SetTrigger("start");
        Invoke("TitleAnimation", cutSceneTime + 1f);
    }

    void TitleAnimation()
    {
        chapter1Title.SetActive(false);
    }
    public void UIDisappear()
    {
        transition.SetTrigger("Start");
        Invoke("UIinactive", cutSceneTime);
    }

    void UIinactive()
    {
        cutSceneUI.SetActive(false);
    }

    public void ActiveTutorialUI()
    {
        Invoke("TutorialUIAnimation", cutSceneTime);
        //inactive tutorial UI
        Invoke("TutorialUIDisappear",cutSceneTime * 2);
    }
    void TutorialUIAnimation()
    {
        tutorialUI.SetActive(true);
    }

    void TutorialUIDisappear()
    {
        tutorialBoxExit.SetTrigger("exit");
    }

    public void InactivePhoneButton()
    {
        GameObject button = GameObject.FindWithTag("OneClick");
        button.SetActive(false);
    }

    public void InactiveButton()
    {
        GameObject button = GameObject.FindWithTag("OneClick");
        button.SetActive(false);
    }

    public void InactivePlay()
    {
        playUI.SetActive(false);
    }

    public void ActivePause()
    {
        pauseUI.SetActive(true);
    }

    public void ActiveButton()
    {
        lightScreenButton.SetActive(true);
    }
    public void LightScreen()
    {
        screenUI.SetActive(true);
    }

    public void StartBusSound()
    {
        BusSound.SetActive(true);
    }
}
