using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    [Header("Reference")]
    public CardPlayer player;
    public CardEnemy enemy;
    // reference to UI texts
    public Text enemyLine;
    public Text playerLine;
    

    //the initial number from enemy random number generator
    private int initialNumber;
    //number from player's choice
    private int playerNumber;
    // show if one turn ends
    private bool turnEnd = false;
    //player and enemy's health
    public int playerHealth;
    public int enemyHealth;
    //if player wins or enemy wins
    public bool playerWin;
    public bool enemyWin;
    

    void Start()
    {
        //get the initial enemy random number
        initialNumber = enemy.randomNumber;
        //get the player's number
        playerNumber = player.playerChoiceNumber;
        

        //initialize player's health and enemy's health
        playerHealth = 3;
        enemyHealth = 3;
        //no one wins
        playerWin = false;
        enemyWin = false;
    }

    
    void Update()
    {
        for(int i = 0; i < 3; i++)
        {
            generateNumber();
            int newNumber = enemy.randomNumber;
            initialNumber = initialNumber + newNumber;
        }
        

    }

    private void generateNumber()
    {
        //call enemy's function to generate random number
        enemy.RandomNumberGenerator();
    }


    private void compareNumber()
    {
        
    }

    private void minusPlayerHealth()
    {
        //check if player's health is 0
        if(playerHealth == 0)
        {
            enemyWin = true;
            return;
        }

        //if enemy's number is larger than player's option number
        

    }

    private void minusEnemyHealth()
    {
        //check if enemy's health is 0
        if(enemyHealth == 0)
        {
            playerWin = true;
            return;
        }

        //if player's number is larger than enemy's number
        
    }

    private void addNumber()
    {

        if(turnEnd == true)
        {

        }

    }


    

}
