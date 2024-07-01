using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardEnemy : MonoBehaviour
{
    
    public int randomNumber;

    [TextArea(3, 10)]
    public string[] lines;

    void Awake()
    {
        RandomNumberGenerator();
    }

    
    void Update()
    {
        
    }

    public void RandomNumberGenerator()
    {
        randomNumber = Random.Range(0, 3);
    }
}
