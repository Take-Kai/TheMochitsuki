using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public GameObject start;
    AudioSource audioData;
    public AudioClip Minzoku33;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
        audioData.PlayOneShot(Minzoku33);
    }
}
