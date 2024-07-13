using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{

    public AudioSource song;
    public GameObject BGM;
    public interactable2 portal;

    [SerializeField] 
    private float volumeChangeDuration; // over how many seconds the change lasts
    [SerializeField] 
    private float minVolume = -15f;
    private float originalVolume;
    private float elapsedTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        originalVolume = BGM.GetComponent<AudioSource>().volume;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (SceneManager.GetActiveScene().buildIndex != 0){
            if(portal.hit == true)
            {
                volumControl();
            }
        }
    }

    public void playMusic()
    {
        song.Play();
    }

    public void volumControl()
    {
        originalVolume = Mathf.Lerp(originalVolume, minVolume, elapsedTime/volumeChangeDuration);
        BGM.GetComponent<AudioSource>().volume = originalVolume;
    }
}
