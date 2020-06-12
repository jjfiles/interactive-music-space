using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioTest : MonoBehaviour {
    
    [FMODUnity.EventRef]
    public string selectSound;
    [FMODUnity.BankRef]
    public string selectBank;
    FMOD.Studio.EventInstance soundEvent;

    public KeyCode pressToPlaySound;

    void Start() {
        FMODUnity.RuntimeManager.HasBankLoaded("bank:/Master");
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