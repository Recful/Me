using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Camera cam;
    public float zoomSpeed = 0.0125f;
    public bool zoomActive = false;
    public Vector3[] target;
    
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = collision.gameObject;
        Debug.Log("hit!");
        if(player.tag == "Player")
        {
            zoomActive = true;
        }
    }
    // Update is called once per frame
    public void LateUpdate()
    {
        if(zoomActive == true)
        {
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 2, zoomSpeed);
        }
        else
        {
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 5, zoomSpeed);
        }
    }
}
