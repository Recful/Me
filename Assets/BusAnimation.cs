using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusAnimation : MonoBehaviour
{
    public Transform wheel1;
    public Transform wheel2;
    public float rotationSpeed = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wheel1.Rotate(0, 0, rotationSpeed);
        wheel2.Rotate(0, 0, rotationSpeed);
    }
}
