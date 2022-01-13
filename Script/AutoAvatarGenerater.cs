/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private EffectManager[] effect;
    private BehaviorManager[] behave;
    
    public GameObject Avatar;
    private GameObject[] AVarray;
    
    [SerializeField]
    private int AVnum = 10;
    
    [SerializeField]
    private float sp = 1.5f;
    
    public void Start()
    {
        AVarray = new GameObject[AVnum];
        effect = new EffectManager[AVnum];
        behave = new BehaviorManager[AVnum];
        GameObject EChild;
        
        for(int i = 0; i < AVnum; i++)
        {
            AVarray[i] = Instantiate(Avatar) as GameObject;
            AVarray[i].transform.position = new Vector3(sp*(i%5), 0 , sp*(i/5));
            EChild = AVarray[i].transform.GetChild(2).gameObject;
            effect[i] = EChild.GetComponent<EffectManager>();
            behave[i] = AVarray[i].GetComponent<BehaviorManager>();
        }
    }
    
    public void Test(int cmd)
    {
        for(int i = 0; i < AVnum; i++)
        {
                effect[i].Generate(cmd);
                behave[i].Generate(cmd);
        }
    }
}
*/
