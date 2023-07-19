using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed;
    public float deadZone = -45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;  
        //Time.deltaTime avoids the code from running as fast as it can
        //virtual voluntary bottleneck
        if(transform.position.x < deadZone)
        {
            Debug.Log("Pipe Destroyed");  
            Destroy(gameObject);
        }
    }
}
