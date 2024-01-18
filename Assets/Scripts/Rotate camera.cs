using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatecamera : MonoBehaviour
{
    public float Rotationspeed;
    public float horizontalInput;
   void start(){

       horizontalInput = Input.GetAxis("Horizontal");
   }

    
    // Update is called once per frame
    void Update()
    {
     
        transform.Rotate(Vector3.up ,horizontalInput * Time.deltaTime);
    }
}
