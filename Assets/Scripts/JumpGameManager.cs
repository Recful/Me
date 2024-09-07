using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JumpGameManager : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject spawnObject;
    public float timer;
    public float spawnInterval;
    public float speedMultiplier;
    public Text distanceUI;
    public float distance;
    public LevelLoader levelLoader;

    // 用于存储三个随机选择的 Sprites
    public Sprite[] possibleSprites;

    void Start()
    {
        
    }

    void Update()
    {
        distanceUI.text = "Distance: " + distance.ToString("F2");
        speedMultiplier += Time.deltaTime * 0.1f;
        timer += Time.deltaTime;
        distance += Time.deltaTime * 0.8f;

        if (timer >= spawnInterval)
        {
            timer = 0;
            int randomIndex = Random.Range(0, spawnPoints.Length);
            GameObject newSpawn = Instantiate(spawnObject, spawnPoints[randomIndex].transform.position, Quaternion.identity);

            // 随机选择一个 Sprite 并应用到生成的对象上
            SpriteRenderer spriteRenderer = newSpawn.GetComponent<SpriteRenderer>();
            if (spriteRenderer != null && possibleSprites.Length > 0)
            {
                int spriteIndex = Random.Range(0, possibleSprites.Length);
                spriteRenderer.sprite = possibleSprites[spriteIndex];
            }

            timer = 0;
        }

        if (distance >= 20)
        {
            //win!Next Scene
            if(levelLoader)
            {
                Debug.Log("Load next level");
            }
            else
            {
                Debug.Log("LevelLoader not found");
            }
            levelLoader.LoadNextLevel();
        }
    }
}
