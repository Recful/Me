using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    
    public GameObject pickUpItem;
    public bool canPickUp = false;
    public bool haveItem = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canPickUp == true && Input.GetKeyDown(KeyCode.E) == true)
        {
            pickUpItem.SetActive(false);
            haveItem = true;
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        GameObject player = collision.gameObject;
        if(player.name == "Player")
        {
            canPickUp = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        GameObject player = collision.gameObject;
        if(player.name == "Player")
        {
            canPickUp = false;
        }
    }
}
