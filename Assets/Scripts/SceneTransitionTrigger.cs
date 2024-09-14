using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTransitionTrigger : MonoBehaviour
{
    
    [SerializeField] private GameObject levelLoader;

    public void NextScene()
    {
        if (levelLoader != null)
        {
            levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
        }
    }

    public void toMainScene()
    {
        levelLoader.GetComponent<LevelLoader>().BackToMainTitleScene();
    }
    
}
