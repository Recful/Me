using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public GameObject animationObject;
    // Start is called before the first frame update
    void Start()
    {
        animationObject.SetActive(false);
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "Player")
        {
            animationObject.SetActive(true);
            Debug.Log("HIT");
        }
    }
}
