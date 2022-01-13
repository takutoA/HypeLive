using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheerManager : MonoBehaviour
{
    [SerializeField]
    AudioClip[] audioClips;
    AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponentInParent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
        public void Play(int cmd)
    {
        switch (cmd)
        {
            case 1:
                Debug.Log("Play1");
                audioSource.PlayOneShot(audioClips[0]);
                break;
            case 2:
                Debug.Log("Play2");
                audioSource.PlayOneShot(audioClips[1]);
                break;
            case 3:
                Debug.Log("Play3");
                audioSource.PlayOneShot(audioClips[2]);
                break;
            case 4:
                Debug.Log("Play4");
                audioSource.PlayOneShot(audioClips[3]);
                break;
        }
    }
    
}
