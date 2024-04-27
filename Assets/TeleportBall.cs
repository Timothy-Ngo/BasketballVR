using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class TeleportBall : MonoBehaviour
{

    public GameObject basketBall;

    public InputActionProperty tpBallAction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = tpBallAction.action.ReadValue<float>();
        
        if (triggerValue == 1)
        {
            basketBall.transform.position = Camera.main.transform.localPosition + Vector3.forward;
            basketBall.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
        
    }
}
