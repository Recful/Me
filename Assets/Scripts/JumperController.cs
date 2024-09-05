using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JumperController : MonoBehaviour
{
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    private bool isGrounded = false;

    public GameObject restartPanel;
    private Animator childAnimator;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Transform childTransform = transform.Find("Graphics");
        childAnimator = childTransform.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            childAnimator.speed = 1;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            childAnimator.speed = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //call out the restart panel
            restartPanel.SetActive(true);
            Time.timeScale = 0f; // 暂停游戏
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

