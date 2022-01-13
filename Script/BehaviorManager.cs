using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorManager : MonoBehaviour
{
    Animator animator;
    private bool flag = true;
    
    void Start()
    {
        this.animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
        public void Generate(int cmd)
    {
        switch (cmd)
        {
            case 1:
                Debug.Log("M1");
                this.animator.SetTrigger("Trigger");
                this.animator.SetInteger("Motion",1);
                break;
            case 2:
                Debug.Log("M2");
                this.animator.SetTrigger("Trigger");
                this.animator.SetInteger("Motion",2);
                break;
            case 3:
                Debug.Log("M3");
                this.animator.SetTrigger("Trigger");
                this.animator.SetInteger("Motion",3);
                break;
            case 4:
                Debug.Log("M4");
                this.animator.SetTrigger("Trigger");
                this.animator.SetInteger("Motion",4);
                break;
        }
    }
}
