using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paramTest : MonoBehaviour
{

    [FMODUnity.EventRef]
    public string selectSound;
    public string zoneNum;
    FMOD.Studio.EventInstance soundEvent;
    public KeyCode play;
    public KeyCode stop;


    // Start is called before the first frame update
    void Start()
    {
        soundEvent = FMODUnity.RuntimeManager.CreateInstance(selectSound);
    }

    // Update is called once per frame
    void Update()
    {
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(soundEvent, GetComponent<Transform>(), GetComponent<Rigidbody>());
        test();
    }

    private void OnTriggerEnter(Collider other) {
        //print("other: " + other.name);
        //print("zone: " + zoneNum);

        if (other.name == "c1") {
            soundEvent.setParameterByName(zoneNum + "-1", 1);
        }
        if (other.name == "c2") {
            soundEvent.setParameterByName(zoneNum + "-2", 1);
        }
        if (other.name == "c3") {
            soundEvent.setParameterByName(zoneNum + "-3", 1);
        }
        if (other.name == "c4") {
            soundEvent.setParameterByName(zoneNum + "-4", 1);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.name == "c1") {
            soundEvent.setParameterByName(zoneNum + "-1", 0);
        }
        if (other.name == "c2") {
            soundEvent.setParameterByName(zoneNum + "-2", 0);
        }
        if (other.name == "c3") {
            soundEvent.setParameterByName(zoneNum + "-3", 0);
        }
        if (other.name == "c4") {
            soundEvent.setParameterByName(zoneNum + "-4", 0);
        }
    }

    void test() {
        if (Input.GetKeyDown(play)) {
            soundEvent.start();
        }
        if (Input.GetKeyDown(stop)) {
            soundEvent.stop(0);
        }
        
    }
}
