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

    private void OnTriggerEnter(Collider other) 
    {
        if (!other.name.Contains("z")) {
            soundEvent.setParameterByName(zoneNum + other.name, 1);
            print("paramter: " + zoneNum + other.name + " on");
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if (!other.name.Contains("z")) {
            soundEvent.setParameterByName(zoneNum + other.name, 0);
            print("paramter: " + zoneNum + other.name + " off");
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
