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
    public GameObject playerName;
    public GameObject computerScreen;


    [Header("Button")]

    public GameObject nameBlank;
 

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
        screen1.SetActive(false);
    }
    
    public void showName()
    {
        playerName.SetActive(true);
        nameBlank.SetActive(false);
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
