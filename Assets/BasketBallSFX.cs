using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBallSFX : MonoBehaviour
{
    public AudioSource bounceSFX;

    // Start is called before the first frame update
    void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Surface"))
        {
            bounceSFX.PlayOneShot(bounceSFX.clip, 1);
        }
    }
}
