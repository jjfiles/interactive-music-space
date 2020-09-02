using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Valve.VR;
//using UnityEngine.XR;
//using UnityEngine.XR.Interaction.Toolkit;
public class inputTest : MonoBehaviour
{
    public enum ControllerType
    {
        None,
        Vive
    }

    //public Text context = null;
    //public ControllerType controllerType = ControllerType.None;

    //private XRController controller = null;

    // public string num;
    // public SteamVR_Action_Boolean toggled;
    // public SteamVR_Input_Sources mDevice;
    private string zoneNum;
    FMOD.Studio.EventInstance sEvent;
    
    
    // Start is called before the first frame update
    void Start()
    {
        // toggled.AddOnStateDownListener(TriggerDown, mDevice);
        // toggled.AddOnStateUpListener(TriggerUp, mDevice);
        // num = "-" + num;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        zoneNum = other.GetComponent<paramAdjust>().zone;
        sEvent = other.GetComponent<paramAdjust>().sEvent;
    }

// //turning alt on
//     void TriggerDown(SteamVR_Action_Boolean act, SteamVR_Input_Sources src)
//     {
//         ;
//         sEvent.setParameterByName(zoneNum + gameObject.name, 0);
//         gameObject.name = gameObject.name + "a";
//         sEvent.setParameterByName(zoneNum + gameObject.name, 1);

//     }

// //turning alt off
//     void TriggerUp(SteamVR_Action_Boolean act, SteamVR_Input_Sources src)
//     {
//         sEvent.setParameterByName(zoneNum + gameObject.name, 0);
//         gameObject.name = gameObject.name.Remove(gameObject.name.Length - 1);
//         sEvent.setParameterByName(zoneNum + gameObject.name, 1);

//     }


}
