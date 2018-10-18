using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    //Start function : executed first only once.

    private void Start(){
    }
    
    //Set object as Trigger
    //Function is called when Triggered

    void OnTriggerEnter(Collider idi)
    {
        //gameObject.SetActive(false);
        //idi.gameObject.SetActive(false);
        //Run the above code first

        if (idi.gameObject.tag == "Enemy")
            gameObject.SetActive(false);

        if (idi.gameObject.tag == "Coin")
            idi.gameObject.SetActive(false);
    }
}
