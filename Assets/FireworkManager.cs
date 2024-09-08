using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworkManager : MonoBehaviour
{
    private Animator animator;
    public string interactableTag = "Player";

    public GameObject firework1;
    public GameObject firework2;
    public GameObject firework3;
    private bool isPlaying = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !isPlaying)
        {
            StartCoroutine(PlayFireworks());
        }
    }

    public void playFireworks()
    {
        StartCoroutine(PlayFireworks());
    }

    private IEnumerator PlayFireworks()
    {
        for (int i = 0; i < 5; i++){
            firework1.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            firework2.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            firework3.SetActive(true);
            yield return new WaitForSeconds(1.5f);
            firework1.SetActive(false);
            firework2.SetActive(false);
            firework3.SetActive(false);
            float randomDelay = Random.Range(1f, 5f);
            yield return new WaitForSeconds(randomDelay);
        }
        isPlaying = false;
    }
}
