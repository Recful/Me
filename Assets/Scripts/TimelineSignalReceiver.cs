using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimelineSignalReceiver : MonoBehaviour
{
    public PlayableDirector director;
    public DialogueTrigger dialogueTrigger;
    public DialogueManager dialogueManager;

    private void Start()
    {
        // director = GetComponent<PlayableDirector>();
    }

    public void PauseTimeLine()
    {
        // director.Pause();
        director.playableGraph.GetRootPlayable(0).SetSpeed(0);
        dialogueTrigger.TriggerDialogue();
    }

    public void ContinueTimeline()
    {
        dialogueManager.endConversation = false;
        // director.Resume();
        director.playableGraph.GetRootPlayable(0).SetSpeed(1);
    }
}
