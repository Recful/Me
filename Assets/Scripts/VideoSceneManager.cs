using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoSceneManager : MonoBehaviour
{
    public GameObject videoPlayer;
    public float videoTime = 16.75f;
    public float currentTime;
    public LevelLoader levelLoader;
    
    // Start is called before the first frame update
    void Start()
    {
        //videoTime = (float) videoPlayer.GetComponent<VideoPlayer>().clip.length;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = (float) videoPlayer.GetComponent<VideoPlayer>().time;
        if(currentTime >= videoTime)
        {
            if(videoTime > 16.75)
            {
                levelLoader.ToMainTitleScene();
            }

            levelLoader.LoadNextLevel();
        }
    }
}
