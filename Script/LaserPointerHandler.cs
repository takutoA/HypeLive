using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;

public class LaserPointerHandler : MonoBehaviour
{

    [SerializeField]
    private string tutorial1;
    [SerializeField]
    private string tutorial2;
    [SerializeField]
    private string scene1;
    [SerializeField]
    private string scene2;
    [SerializeField]
    private float timeToFade;


    Color32 color0 = new Color32(250, 0, 0, 130);
    Color32 color1 = new Color32(20, 170, 250, 130);

    //右手用
    public SteamVR_LaserPointer laserPointer;
    //左手用
    public SteamVR_LaserPointer laserPointer2;

    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
        laserPointer2.PointerIn += PointerInside;
        laserPointer2.PointerOut += PointerOutside;
        laserPointer2.PointerClick += PointerClick;
    }

    //レーザーポインターをtargetに焦点をあわせてトリガーをひいたとき
    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Tutorial1Button")
        {
            GameObject Tutorial1Button = GameObject.Find("Tutorial1Button");
            Tutorial1Button.GetComponent<Image>().color = color0;
            FadeManager.Instance.LoadScene(tutorial1, timeToFade);
        }

        if (e.target.name == "Tutorial2Button")
        {
            GameObject Tutorial2Button = GameObject.Find("Tutorial2Button");
            Tutorial2Button.GetComponent<Image>().color = color0;
            FadeManager.Instance.LoadScene(tutorial2, timeToFade);
        }

        if (e.target.name == "Scene1Button")
        {
            GameObject Scene1Button = GameObject.Find("Scene1Button");
            Scene1Button.GetComponent<Image>().color = color0;
            FadeManager.Instance.LoadScene(scene1, timeToFade);
        }

        if (e.target.name == "Scene2Button")
        {
            GameObject Scene2Button = GameObject.Find("Scene2Button");
            Scene2Button.GetComponent<Image>().color = color0;
            FadeManager.Instance.LoadScene(scene2, timeToFade);
        }

    }

    //レーザーポインターがtargetに触れたとき
    public void PointerInside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Tutorial1Button")
        {
            GameObject Tutorial1Button = GameObject.Find("Tutorial1Button");
            Tutorial1Button.GetComponent<Image>().color = color1;
        }

        if (e.target.name == "Tutorial2Button")
        {
            GameObject Tutorial2Button = GameObject.Find("Tutorial2Button");
            Tutorial2Button.GetComponent<Image>().color = color1;
        }

        if (e.target.name == "Scene1Button")
        {
            GameObject Scene1Button = GameObject.Find("Scene1Button");
            Scene1Button.GetComponent<Image>().color = color1;
        }

        if (e.target.name == "Scene2Button")
        {
            GameObject Scene2Button = GameObject.Find("Scene2Button");
            Scene2Button.GetComponent<Image>().color = color1;
        }

    }

    //レーザーポインターがtargetから離れたとき
    public void PointerOutside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Tutorial1Button")
        {
            GameObject Tutorial1Button = GameObject.Find("Tutorial1Button");
            Tutorial1Button.GetComponent<Image>().color = Color.white;
        }

        if (e.target.name == "Tutorial2Button")
        {
            GameObject Tutorial2Button = GameObject.Find("Tutorial2Button");
            Tutorial2Button.GetComponent<Image>().color = Color.white;
        }

        if (e.target.name == "Scene1Button")
        {
            GameObject Scene1Button = GameObject.Find("Scene1Button");
            Scene1Button.GetComponent<Image>().color = Color.white;
        }

        if (e.target.name == "Scene2Button")
        {
            GameObject Scene2Button = GameObject.Find("Scene2Button");
            Scene2Button.GetComponent<Image>().color = Color.white;
        }

    }


}