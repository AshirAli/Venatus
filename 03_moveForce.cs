using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public Rigidbody rb; //Public to show this in inspector
                         // to access the rigid body component of object
                         // can access any component of the object

    public float forwardForce = 800f; //add this to rb.AddForce after compiling with constant force.
    public float sidewaysForce = 500f;





     private void Start(){
        rb.AddForce(0, 0, 200);    //Adds specified force at the start of the game.
     }


    //Use fixed update for physics related objects
    //using just update adds specified amount of force every frame (varies with computers)
    //Use fixed update for forces, velocities etc

    void FixedUpdate(){
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);       //Adds specified force at each each constant frame.
                                                                //To stop cube rotating, add constraint rotation
                                                                //Remove constraint and add Phyisc Material to plane

        if (Input.GetKey("d"))  //GetKey describe :: is not recommended inside FixedUpdate cause its slower than update and game may miss an input 
        {                       //Use boolean variable in update and use that in here.
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);        //Gets d key, which means +ve x axis
        }
        if (Input.GetKey("a"))                      
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);       //Gets a key, which means -ve x axis
        }
    }

}
