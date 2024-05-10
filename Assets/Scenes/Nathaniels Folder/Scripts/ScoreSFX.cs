using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSFX : MonoBehaviour
{
    public AudioSource ScorePointSFX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collision col)
    {
        if (col.gameObject.CompareTag("PickUp"))
        {
            //Debug.Log("Pick up sound");
            //ScorePointSFX.PlayOneShot(ScorePointSFX.clip, 1);
        }
    }
}
