using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidBody2D;
    public float flapStrength = 5;

    //video stopped at 17:03
    //https://youtu.be/XtQMytORBmM

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            birdRigidBody2D.velocity = Vector2.up * flapStrength;
        }
        
    }
}
