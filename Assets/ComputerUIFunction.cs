using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerUIFunction : MonoBehaviour
{
    private int i = 0;

    [Header("UI")]
    public GameObject screen1;
    public GameObject screen2;
    public GameObject playerName;
    public GameObject playerSign;
    public GameObject playerAge;
    public GameObject playerGender;
    public GameObject screen3;
    public GameObject picture;
    public GameObject screen4;
    public GameObject screen5;
    public GameObject personProfile1;
    public GameObject personProfile2;
    public GameObject personProfile3;
    public GameObject personProfile4;
    public GameObject closeText;
    public GameObject computerScreen;


    [Header("Button")]
    public GameObject screen1Button;
    public GameObject nameBlank;
    public GameObject signBlank;
    public GameObject ageBlank;
    public GameObject genderBlank;
    public GameObject screen2Button;
    public GameObject pictureButton;
    public GameObject screen3Button;
    public GameObject screen4Button;
    public GameObject skip1;
    public GameObject skip2;
    public GameObject skip3;
    public GameObject skip4;
    public GameObject like1;
    public GameObject like2;
    public GameObject like3;
    public GameObject like4;
    public GameObject closeButton;

    [Header("Animation")]
    public Animator computerFadeOut;
    public float FadeOutTime = 1f;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextScreen()
    {
        screen2.SetActive(true);
        screen1Button.SetActive(false);
        screen1.SetActive(false);
    }
    
    public void showName()
    {
        playerName.SetActive(true);
        nameBlank.SetActive(false);
    }
    public void showSign()
    {
        playerSign.SetActive(true);
        signBlank.SetActive(false);
    }
    public void showAge()
    {
        playerAge.SetActive(true);
        ageBlank.SetActive(false);
    }
    public void showGender()
    {
        playerGender.SetActive(true);
        genderBlank.SetActive(false);
    }

    public void Screen2NextButton()
    {
        screen2Button.SetActive(true);
    }

    public void ThirdScreen()
    {
        screen3.SetActive(true);
        screen2Button.SetActive(false);
        screen2.SetActive(false);
    }

    public void showPicture()
    {
        picture.SetActive(true);
        pictureButton.SetActive(false);
    }

    public void Screen3NextButton()
    {
        screen3Button.SetActive(true);
    }

    public void fourthScreen()
    {
        screen4.SetActive(true);
        screen3Button.SetActive(false);
        screen3.SetActive(false);
    }
    
    public void fifthScreen()
    {
        screen5.SetActive(true);
        screen4Button.SetActive(false);
        screen4.SetActive(false);
    }

    public void showPerson2()
    {
        personProfile1.SetActive(false);
        personProfile2.SetActive(true);
        skip1.SetActive(false);
        skip2.SetActive(true);
        like1.SetActive(false);
        like2.SetActive(true);
    }
    public void showPerson3()
    {
        personProfile2.SetActive(false);
        personProfile3.SetActive(true);
        skip2.SetActive(false);
        skip3.SetActive(true);
        like2.SetActive(false);
        like3.SetActive(true);
    }
    public void showPerson4()
    {
        personProfile3.SetActive(false);
        personProfile4.SetActive(true);
        skip3.SetActive(false);
        skip4.SetActive(true);
        like3.SetActive(false);
        like4.SetActive(true);
    }
    public void hidePerson4()
    {
        personProfile4.SetActive(false);
        skip4.SetActive(false);
        like4.SetActive(false);
        closeButton.SetActive(true);
        closeText.SetActive(true);
    }

    public void closeComputer()
    {
        computerFadeOut.SetTrigger("Start");
        Invoke("disableComputer", FadeOutTime);
    }
    void disableComputer()
    {
        computerScreen.SetActive(false);
    }
}
