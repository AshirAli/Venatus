using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    //Start function : executed first only once.

    private void Start(){

    }

    void Update()
    {
        Debug.Log("Update Time : "+ Time.deltaTime);
    }
    /*: Called Every Frame
     * Used for regular updates such as:
     *  1. Moving non-physics objects
     *  2. Simples Timers
     *  3. Receiving Input
     * Update intervals vary depending upon processing time of each frame.
     * 
     */

    void FixedUpdate () {
        Debug.Log("Fixed Update Time : " + Time.deltaTime);
    }

    /*: Called Every physics step
     * Used for regular updates such as:
     *  1. Moving physics objects
     * Update intervals are consistent
     * 
     */
}

/* Advantage of FixedUpdate : doesnot depend on frame process
 * Disadvantage : Maybe sometimes slower than Update
 * /
 * TIME DOT DELTA TIME : 
 * The time in seconds it took to complete the last frame (Read Only).

If you add or subtract to a value every frame chances are you should multiply with Time.deltaTime.

When you multiply with Time.deltaTime you essentially express: I want to move this object 10 meters per second instead of 10 meters per frame.

When called from inside MonoBehaviour's FixedUpdate, returns the fixed framerate delta time.
*/