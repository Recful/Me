using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerUIFunction2 : MonoBehaviour
{
    private int i = 0;

    [Header("UI")]
    public GameObject screen1;
    public GameObject screen2;
    public GameObject screen3;
    public GameObject screen4;
    public GameObject screen5;
    public GameObject playerName;
    public GameObject playerName2;
    public GameObject playerName3;
    public GameObject playerName4;
    public GameObject playerName5;
    public GameObject computerScreen;


    [Header("Button")]

    public GameObject nameBlank;
    public GameObject nameBlank2;
    public GameObject nameBlank3;
    public GameObject nameBlank4;
    public GameObject nameBlank5;
    
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject image5;

    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;


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
    public void showName()
    {
        playerName.SetActive(true);
        nameBlank.SetActive(false);
        Invoke("NextScreen", 2f);
    }

    public void NextScreen()
    {
        screen2.SetActive(true);
        image2.SetActive(true);
        nameBlank2.SetActive(true);
        text2.SetActive(true);
        screen1.SetActive(false);
    }
    
    

    public void showName2()
    {
        playerName2.SetActive(true);
        nameBlank2.SetActive(false);
        Invoke("NextScreen2", 2f);
    }
    
    public void NextScreen2()
    {
        //screen2.SetActive(false);
        image3.SetActive(true);
        nameBlank3.SetActive(true);
        text3.SetActive(true);
        screen3.SetActive(true);
    }

    public void showName3()
    {
        playerName3.SetActive(true);
        nameBlank3.SetActive(false);
        Invoke("NextScreen3", 2f);
    }
    
    public void NextScreen3()
    {
        //screen3.SetActive(false);
        image4.SetActive(true);
        nameBlank4.SetActive(true);
        text4.SetActive(true);
        screen4.SetActive(true);
    }

    public void showName4()
    {
        playerName4.SetActive(true);
        nameBlank4.SetActive(false);
        Invoke("NextScreen4", 2f);
    }

    public void NextScreen4()
    {
        //screen4.SetActive(false);
        screen5.SetActive(true);
        image5.SetActive(true);
        nameBlank5.SetActive(true);
        text5.SetActive(true);
        playerName5.SetActive(false);
    }
    
    public void showName5()
    {
        playerName5.SetActive(true);
        nameBlank5.SetActive(false);
        //Invoke("NextScreen5", 2f);
    }
    
    // public void NextScreen5()
    // {
    //     screen5.SetActive(false);
    //     image5.SetActive(true);
    //     nameBlank5.SetActive(true);
    //     text5.SetActive(true);
    //     screen5.SetActive(true);
    // }

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
