using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class HapticController : MonoBehaviour
{
    public SteamVR_Input_Sources handType;

    public SteamVR_Action_Vibration hapicAction = SteamVR_Input.GetAction<SteamVR_Action_Vibration>("Hapic");


    public enum HapicPower
    {
        NONE = 0,
        WEEK = 1000,
        MIDDLE = 2000,
        STRONG = 4000
    }


    void Reset()
    {
        handType = this.gameObject.GetComponent<SteamVR_Behaviour_Pose>().inputSource;
    }


    public void ControllerHaptic()
    {
        float seconds = (float)HapicPower.STRONG / 1000000f;
        hapicAction.Execute(0, seconds, 1f / seconds, 1, handType);
    }

    void OnCollisionEnter(Collision collision)
    {
        ControllerHaptic();
    }

    void OnTriggerEnter(Collider collision)
    {
        ControllerHaptic();
    }

}
