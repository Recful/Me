using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.Audio;
using UnityEngine.Video;

public class TimelineSignalReceiver : MonoBehaviour
{
    public PlayableDirector director;
    public DialogueTrigger dialogueTrigger;
    public DialogueManager dialogueManager;
    public FireworkManager fireworkManager;
    public MusicController musicController;
    public GameObject choicePanel;
    public VideoPlayer video;
    [SerializeField] private bool playedAnimation = false;
    [SerializeField] private int pauseCount = 0;
    

    private void Start()
    {
        
    }

    public void fireworkAnimation()
    {
        if(fireworkManager)
        {
            fireworkManager.playFireworks();
            playedAnimation = true;
        }
    }

    public void videoTrigger()
    {
        video.Play();
    }
    public void musicChange()
    {
        if(!musicController)
        {
            
            return;
        }

        pauseCount = pauseCount + 1;
        
        if(pauseCount == 1)
        {
            musicController.changeMusic1();
        }
        if(pauseCount == 2)
        {
            musicController.changeMusic2();
        }
    }

    public void dialogStart()
    {
        if(dialogueTrigger)
        {
            dialogueTrigger.TriggerDialogue();
        }
    }

    public void PauseTimeLine()
    {
        
        director.playableGraph.GetRootPlayable(0).SetSpeed(0);
        //pauseTimeLineWithoutAudio();
        dialogStart();
    }

    public void ContinueTimeline()
    {
        dialogueManager.endConversation = false;
        
        director.playableGraph.GetRootPlayable(0).SetSpeed(1);
    }
}
