using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watersound : MonoBehaviour {
    public AudioClip water_sound;

    // Use this for initialization
   void Start ()
    {
            SoundManager.instance.PlaySingle(water_sound);
        
	}
	
}
