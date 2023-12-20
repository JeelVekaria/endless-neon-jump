using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip flying,bonked;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        flying = Resources.Load<AudioClip>("jump");
        bonked = Resources.Load<AudioClip>("bonk");

        audioSrc = GetComponent<AudioSource>();

        
    }

    public static void PlaySound(int x){
        switch(x){
            case 1:
                audioSrc.PlayOneShot(flying);
                break;
            case 2:
                audioSrc.PlayOneShot(bonked);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
