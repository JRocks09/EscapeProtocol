using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    
    public AudioSource source;
    public AudioClip clip;

    // Sound is repeating every time the 'd' key is pressed

    void Update() {
        if(Input.GetKeyDown(KeyCode.D)) {
            source.PlayOneShot(clip);
        }
    }

}
