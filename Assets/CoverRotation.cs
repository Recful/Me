using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoverRotation : MonoBehaviour
{
    
    public float rotationsPerSecond;
    public Transform cover;
    
    void Update()
    {
        Rotation();
    }
    public void Rotation()
    {
        float rZ = -(rotationsPerSecond * Time.time * 360) % 360f;
        transform.rotation = Quaternion.Euler(0, 0, rZ);
    }

}
