using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbeScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    //TODO change

    // Start is called before the first frame 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // use if to skip some code unless conditionhas beemn
        if (Input.GetKeyDown(KeyCode.Space) == true)

        myRigidbody.velocity = Vector2.up * flapStrength;

        //one = to make the thing on the left to make the same as the thing on the right
        //two == to check to see if the thing on the left is the same as the things on the right

    }

}
