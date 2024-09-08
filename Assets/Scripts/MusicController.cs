using System.Collections;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource FinalMusicBegining;
    public AudioSource selectionTimeLoopMusic;
    public AudioSource SelectionTimeToFinalMusic;
    public AudioSource EndingMusic;
    public AudioSource DingSound;
    public TimelineSignalReceiver timelineSignalReceiver;

    public float fadeDuration = 2.5f;

    private AudioSource currentMusic;

    void Start()
    {
        // 开始时播放音乐1
        FinalMusicBegining.Play();
        currentMusic = FinalMusicBegining;
    }

    void Update()
    {
        // // 示例：按下 A 键触发剧情点 A
        // if (Input.GetKeyDown(KeyCode.A) && currentMusic == FinalMusicBegining)
        // {
        //     StartCoroutine(SwitchMusic(FinalMusicBegining, selectionTimeLoopMusic));
        //     currentMusic = selectionTimeLoopMusic;
        // }

        // // 示例：按下 B 键触发剧情点 B
        // if (Input.GetKeyDown(KeyCode.B) && currentMusic == selectionTimeLoopMusic)
        // {
        //     StartCoroutine(SwitchMusic(selectionTimeLoopMusic, SelectionTimeToFinalMusic));
        //     currentMusic = SelectionTimeToFinalMusic;
        // }

        // // 示例：按下 C 键触发剧情点 C
        // if (Input.GetKeyDown(KeyCode.C) && currentMusic == SelectionTimeToFinalMusic)
        // {
        //     DingSound.Play();
        //     StartCoroutine(SwitchMusic(SelectionTimeToFinalMusic, EndingMusic));
        //     currentMusic = EndingMusic;
        // }
    }

    public void changeMusic1()
    {
        StartCoroutine(SwitchMusic(FinalMusicBegining, selectionTimeLoopMusic));
        currentMusic = selectionTimeLoopMusic;
    }

    public void changeMusic2()
    {
        StartCoroutine(SwitchMusic(selectionTimeLoopMusic, SelectionTimeToFinalMusic));
            currentMusic = SelectionTimeToFinalMusic;
    }

    public void changeMusic3()
    {
        DingSound.Play();
            StartCoroutine(SwitchMusic(SelectionTimeToFinalMusic, EndingMusic));
            currentMusic = EndingMusic;
    }

    // 音乐淡入淡出切换的协程
    IEnumerator SwitchMusic(AudioSource fromMusic, AudioSource toMusic)
    {
        float elapsedTime = 0f;

        // 开始播放目标音乐，但音量设为 0
        toMusic.volume = 0f;
        toMusic.Play();

        // 同时淡出当前音乐和淡入目标音乐
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float percentage = elapsedTime / fadeDuration;

            fromMusic.volume = Mathf.Lerp(0.6f, 0f, percentage);
            toMusic.volume = Mathf.Lerp(0f, 0.6f, percentage);

            yield return null;
        }

        // 确保音量调整到最终值
        fromMusic.volume = 0f;
        toMusic.volume = 0.6f;

        // 停止之前的音乐
        fromMusic.Stop();
    }

    public void checkIfHasNextMusic()
    {
        if(currentMusic.time >= currentMusic.clip.length)
        {
            
        }
    }
}