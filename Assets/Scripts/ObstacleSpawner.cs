using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    private Rigidbody2D rb;
    public float spawnInterval = 2f;
    public float obstacleSpeed = 5f;

    private GameObject gm;

    private float timer;


    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager");
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 6)
        {
            Destroy(gameObject);
        }
        rb.velocity = Vector2.left * (obstacleSpeed + gm.GetComponent<JumpGameManager>().speedMultiplier);
    }
}
