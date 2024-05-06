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
            if ((315 <= Camera.main.transform.rotation.eulerAngles.y && Camera.main.transform.rotation.eulerAngles.y <= 0) ||
                (0 <= Camera.main.transform.rotation.eulerAngles.y && Camera.main.transform.rotation.eulerAngles.y <= 45))
            {
                basketBall.transform.position = Camera.main.transform.position + Vector3.forward;
                basketBall.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
            else if ((45 <= Camera.main.transform.rotation.eulerAngles.y && Camera.main.transform.rotation.eulerAngles.y <= 135))
            {
                basketBall.transform.position = Camera.main.transform.position + Vector3.right;
                basketBall.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }  
            else if ((135 <= Camera.main.transform.rotation.eulerAngles.y && Camera.main.transform.rotation.eulerAngles.y <= 225))
            {
                basketBall.transform.position = Camera.main.transform.position + Vector3.back;
                basketBall.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }  
            else if ((225 <= Camera.main.transform.rotation.eulerAngles.y && Camera.main.transform.rotation.eulerAngles.y <= 315))
            {
                basketBall.transform.position = Camera.main.transform.position + Vector3.left;
                basketBall.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }  
            
        }
        
    }
}
