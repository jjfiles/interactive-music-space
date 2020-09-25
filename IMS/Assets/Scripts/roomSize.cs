using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class roomSize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float pX = 0;
        float pY = 0;
        var chap = OpenVR.Chaperone;
        bool checkPlayArea = (chap != null) && chap.GetPlayAreaSize(ref pX, ref pY);

        print("x: " + pX);
        print("y: " + pY);
        

        gameObject.transform.localScale = new Vector3((pX/4)-.1f, 1, (pY/4)-.2f);
    }

}
