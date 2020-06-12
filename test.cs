using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
    
    [FMODUnity.EventRef]
    public string selectSound;
    FMOD.Studio.EventInstance soundEvent;

    public KeyCode pressToPlaySound;

    void Start() {
        soundEvent = FMODUnity.RuntimeManager.CreateInstance(selectSound);
    }

    void Update() {
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(soundEvent, GetComponent<Transform>(), GetComponent<Rigidbody>());
    }

    void playSound() {
        if (Input.GetKeyDown(pressToPlaySound)) {
            soundEvent.start();
        }
    }
}