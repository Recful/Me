using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.Audio;

public class TimelineSignalReceiver : MonoBehaviour
{
    public PlayableDirector director;
    public DialogueTrigger dialogueTrigger;
    public DialogueManager dialogueManager;
    public FireworkManager fireworkManager;
    [SerializeField] private bool playedAnimation = false;
    

    private void Start()
    {
        
    }

    public void pauseTimeLineWithoutAudio()
    {
        var playableGraph = director.playableGraph;

        // Loop through all the outputs of the PlayableGraph
        for (int i = 0; i < playableGraph.GetOutputCount(); i++)
        {
            var output = playableGraph.GetOutput(i);

            // Check if this output is of type AudioPlayableOutput
            if (output.IsPlayableOutputOfType<AudioPlayableOutput>())
            {
                // Get the source playable (which is the playable associated with this audio track)
                var audioPlayable = output.GetSourcePlayable();

                // Now you can control this specific audio track's playable
                // For example, set its speed to 1 to ensure it keeps playing
                audioPlayable.SetSpeed(1);

                Debug.Log("Found and controlled an audio track!");
            }
        }
    }
    private void fireworkAnimation()
    {
        if(fireworkManager)
        {
            fireworkManager.playFireworks();
            playedAnimation = true;
            ContinueTimeline();
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
        pauseTimeLineWithoutAudio();
        dialogStart();
        fireworkAnimation();
    }

    public void ContinueTimeline()
    {
        dialogueManager.endConversation = false;
        
        director.playableGraph.GetRootPlayable(0).SetSpeed(1);
    }
}
