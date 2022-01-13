using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private EffectManager[] effect;
    private BehaviorManager[] behave;
    //private CheerManager[] cheer;
    private SeManager se;
    private NeoManager[] Rneo;
    private NeoManager[] Lneo;

    private MyNeoManager rmyneo;
    private MyNeoManager lmyneo;
    public GameObject Avatar;
    private GameObject[] AVarray;
    private int AVnum;

    private GameObject[] RNarray;
    private GameObject[] LNarray;
    private ConManager con;

    public void Start()
    {
        AVnum = Avatar.transform.childCount;
        AVarray = new GameObject[AVnum];

        RNarray = new GameObject[AVnum];
        LNarray = new GameObject[AVnum];

        effect = new EffectManager[AVnum];
        behave = new BehaviorManager[AVnum];
        //cheer = new CheerManager[AVnum];
        se = GameObject.Find("ViveCameraRig/Camera").GetComponent<SeManager>();
        Rneo = new NeoManager[AVnum];
        Lneo = new NeoManager[AVnum];
        con = GameObject.Find("ViveCameraRig/Camera/Canvas/ConEffect").GetComponent<ConManager>();
        GameObject EChild;
        rmyneo = GameObject.Find("ViveCameraRig/RightHand/vr_glove_right_model_slim/Neo").GetComponent<MyNeoManager>();
        lmyneo = GameObject.Find("ViveCameraRig/LeftHand/vr_glove_left_model_slim/Neo").GetComponent<MyNeoManager>();

        for (int i = 0; i < AVnum; i++)
        {
            AVarray[i] = Avatar.transform.GetChild(i).gameObject;
            EChild = AVarray[i].transform.GetChild(2).gameObject;
            effect[i] = EChild.GetComponent<EffectManager>();
            behave[i] = AVarray[i].GetComponent<BehaviorManager>();
            //cheer[i] = AVarray[i].GetComponent<CheerManager>();

            RNarray[i] = AVarray[i].transform.Find("Root/Spine/Spine1/Spine2/LeftShoulder/LeftArm/LeftForeArm/LeftHand/Neo").gameObject;
            LNarray[i] = AVarray[i].transform.Find("Root/Spine/Spine1/Spine2/RightShoulder/RightArm/RightForeArm/RightHand/Neo").gameObject;

            Rneo[i] = RNarray[i].GetComponent<NeoManager>();
            Lneo[i] = LNarray[i].GetComponent<NeoManager>();
        }

    }

    public void Test(int cmd)
    {
        se.Play(cmd);
        con.Generate(cmd);
        //rmyneo.Change(cmd);
        //lmyneo.Change(cmd);

        for (int i = 0; i < AVnum; i++)
        {
            //effect[i].Generate(cmd);
            behave[i].Generate(cmd);
            //cheer[i].Play(cmd);
            Rneo[i].Change(cmd);
            Lneo[i].Change(cmd);
        }
    }
}