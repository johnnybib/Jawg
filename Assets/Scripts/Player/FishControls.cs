﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishControls : MonoBehaviour
{

    public Animator anim;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if ( Input.GetKeyDown(KeyCode.Space) ) {
            StartCoroutine(roll());
        } else if ( Input.GetKeyDown(KeyCode.W) ) {
            StartCoroutine(running("start"));
        }

        if ( Input.GetKeyUp(KeyCode.W) ) {
            StartCoroutine(running("stop"));
        }
    }
    IEnumerator roll() {
        anim.SetBool("roll", true);
        yield return new WaitForSeconds(1.0f);
        anim.SetBool("roll", false);
    }
    IEnumerator running(string s) {

        if ( s == "start" ) {
            anim.SetFloat("speedPercent", 10f);
            yield return new WaitForSeconds(0.0f);
        } else if ( s == "stop" ) {
            anim.SetFloat("speedPercent", 0.0f);
            yield return new WaitForSeconds(0.0f);
        }
        
    }

}