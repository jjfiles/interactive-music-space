using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paramAdjust : MonoBehaviour 
{
    [FMODUnity.EventRef]
    public string bank;
    public string zone;
    FMOD.Studio.EventInstance sEvent;
    public KeyCode playbackStart;
    public KeyCode playbackStop;
    public KeyCode playbackMute;


    void Start() 
    {
        sEvent = FMODUnity.RuntimeManager.CreateInstance(bank);
        print("Instance created");
    }

//TODO:
//? use sEvent.getTimelinePosition() to make changes only at desired times (measures / beats)
//? conditional for height vairance controlling some param i.e. alt or reverb
    void Update() 
    {
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(sEvent, GetComponent<Transform>(), GetComponent<Rigidbody>());
        controls(); 
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (!other.name.Contains("z"))
        {
            sEvent.setParameterByName(zone + other.name, 1);
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if (!other.name.Contains("z"))
        {
            sEvent.setParameterByName(zone + other.name, 0);
        }
    }

    void controls() {
        if (Input.GetKeyDown(playbackStart))
        {
            sEvent.start();
        }

        if (Input.GetKeyDown(playbackStop))
        {
            sEvent.stop(0);
        }

        if (Input.GetKeyDown(playbackMute))
        {
            for (int i = 1; i < 5; i++)
            {
                sEvent.setParameterByName(zone + "-" + i.ToString(), 0);
            }
        }
    }

}