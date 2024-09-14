using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class FinalButtonFunctions : MonoBehaviour
{
    public LevelLoader levelLoader;
    public PlayableDirector director;

    public void Ending1()
    {
        director.playableGraph.GetRootPlayable(0).SetSpeed(1);
    }

    public void Ending2()
    {
        if(levelLoader)
        {
            levelLoader.LoadNextLevel();
        }
    }
}
