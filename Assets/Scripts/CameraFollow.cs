using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    public float smoothSpeed = 0.125f;
    public float smoothBackSpeed = 0.05f;
    public Vector3 offset;
    public float startXPositionMin;
    public float startXPositionMax;
    public float endXPositionMin;
    public float endXPositionMax;
    private Vector3 camPosInitial;
    private Vector3 camPosStop;
    private Vector3 tempPos;
    public Vector3 desireStopPosition;
    public Vector3 tem = new Vector3(30.6f, 0f, -1f);

    void Start()
    {
        camPosInitial = transform.position;
        camPosStop = desireStopPosition;
        
    }


    void FixedUpdate()
    {
        
        tempPos = transform.position;
        
        //cam stick on the initial position
        if(target.position.x > startXPositionMin && target.position.x < startXPositionMax)
        {
            transform.position = Vector3.Lerp(tempPos, camPosInitial, smoothBackSpeed);
        }
        //cam focus on the player
        if(target.position.x > startXPositionMax)
        {
            Vector3 desiredPosition = new Vector3(target.position.x + offset.x, camPosInitial.y, target.position.z +offset.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }

        //cam stick on the stop position
        if(target.position.x > endXPositionMin && target.position.x < endXPositionMax)
        {
            
            transform.position = Vector3.Lerp(tempPos, camPosStop, smoothBackSpeed);
        }

    }

}
