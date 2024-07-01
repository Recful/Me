using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    
    public LevelLoader levelLoader;

    public void NextLevelFunction()
    {
        levelLoader.LoadNextLevel();
    }
}
