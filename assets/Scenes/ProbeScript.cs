using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbeScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float vInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vInput = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector2.up * vInput * moveSpeed * Time.deltaTime);
    }
}
