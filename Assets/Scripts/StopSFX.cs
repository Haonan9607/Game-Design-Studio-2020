using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSFX : MonoBehaviour
{
    public AudioSource stopSound;

    void OnTriggerEnter(Collider other)
    {
        stopSound.Stop();
    }
}
