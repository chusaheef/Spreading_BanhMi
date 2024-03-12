using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    private GameObject heldObject;

    void Update()
    {
        // Check for mouse click to pick up objects
        if (Input.GetMouseButtonDown(0)) // Change "0" to the appropriate button index if necessary
        {
            // Perform pick-up action
            //PickUpObject();
        }

        // Check for key press to drop objects
        if (Input.GetKeyDown(KeyCode.Space)) // Example: Space key for dropping objects
        {
            // Perform drop-off action
            DropObject();
        }
    }


    // Pick up an object when the player interacts with it
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PickupableObject"))
        {
            // Store a reference to the object being picked up
            heldObject = other.gameObject;

            // Disable physics for the object while it's being held
            heldObject.GetComponent<Rigidbody>().isKinematic = true;

            // Parent the object to the player's hand or wherever you want to hold it
            heldObject.transform.parent = transform;
        }
    }

    // Drop off the object when the player interacts with the drop-off zone
    public void DropObject()
    {
        if (heldObject != null)
        {
            // Release the object from the player's hand
            heldObject.transform.parent = null;

            // Enable physics for the object
            heldObject.GetComponent<Rigidbody>().isKinematic = false;

            // Reset the reference to the held object
            heldObject = null;
        }
    }
}
