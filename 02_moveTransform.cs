using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    //Start function : executed first only once.

    private void Start(){
        //Accessing Inspector property of object from script
        //initialising the object in world to 0 in all coordinates
        transform.position = new Vector3(0.0f, 0.0f,0.0f);
        //Vector3 : Returns position in 3D
    }

    void FixedUpdate () {
        //Inputs from arrow keys
        //Edit : Input Manager
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
 
        Debug.Log(moveVertical); //Outputs to console

        transform.position += new Vector3(moveHorizontal*Time.deltaTime*5, moveVertical* Time.deltaTime*8, 0.0f);  //adds to current pos
    }
}
