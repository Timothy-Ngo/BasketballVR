using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class BasketballScore : MonoBehaviour
{
    // Rigidbody of the ball
    private Rigidbody rb;

    // Variable to keep track of collected "PickUp" objects.
    public int count;

    // UI text component to display count of "PickUp" objects collected.
    public TextMeshProUGUI countText;

    // UI object to display winning text.
    public GameObject winTextObject;

    // Score SfX
    public AudioSource scoreSFX;

    // Start is called before the first frame update.
    void Start()
    {
        // Get and store the Rigidbody component attached to the ball
        rb = GetComponent<Rigidbody>();

        // Initialize count to zero.
        count = 0;

        // Update the count display.
        SetCountText();

        // Initially set the win text to be inactive.
        winTextObject.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {
        // Check if the object the player collided with has the "PickUp" tag.
        if (other.gameObject.CompareTag("PickUp"))
        {

            // Increment the count of "PickUp" objects collected.
            count = count + 1;

            // Update the count display.
            SetCountText();

            Debug.Log("Play Sound");
            scoreSFX.PlayOneShot(scoreSFX.clip, 1f);

        }
    }

    // Function to update the displayed count of "PickUp" objects collected.
    void SetCountText()
    {
        // Update the count text with the current count.
        countText.text = "Score: " + count.ToString();

    }
}

