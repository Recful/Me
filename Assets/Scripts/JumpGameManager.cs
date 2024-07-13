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
    private float distance;
    public LevelLoader levelLoader;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanceUI.text = "Distance: " + distance.ToString("F2");
        speedMultiplier += Time.deltaTime * 0.1f;
        timer += Time.deltaTime;
        distance += Time.deltaTime * 0.8f;

        if (timer >= spawnInterval)
        {
            timer = 0;
            int randomIndex = Random.Range(0, 3);
            Instantiate(spawnObject, spawnPoints[randomIndex].transform.position, Quaternion.identity);
            timer = 0;
        }
        if (distance >= 20)
        {
            //win!Next Scene
            if(levelLoader){
                Debug.Log("Load next level");
            }
            else{
                Debug.Log("LevelLoader not found");
            }
            levelLoader.LoadNextLevel();
        }
    }
}
