﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteleAni : MonoBehaviour
{
    
    [SerializeField] private Animator myAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("near_stele01", true);            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("near_stele01", false);
        }
    }
}