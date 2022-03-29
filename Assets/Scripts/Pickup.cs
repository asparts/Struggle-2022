using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Pickup : MonoBehaviour
{

    //[SerializeField] RawImage inventorySprite;

    [SerializeField] private LayerMask pickupLayer;
    [SerializeField] private Camera camera;
    [SerializeField] private float pickupRange;
    [SerializeField] private Transform hand;
    [SerializeField] private float throwingForce;


    private Rigidbody currentObjectRigidBody;
    private Collider currentObjectCollider;

    /**
     If item is pickable, check if there's space in inventory, 
        disable 3d object and add corresponding 2d item to inventory
         
         --> Probably have to do dropping off with raycast 
         */
    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            Ray pickupRay = new Ray(camera.transform.position, camera.transform.forward);

            if (Physics.Raycast(pickupRay, out RaycastHit hitInfo, pickupRange, pickupLayer))
            {
                if (currentObjectRigidBody)
                {
                    currentObjectRigidBody.isKinematic = false;
                    currentObjectCollider.enabled = true;

                    currentObjectRigidBody = hitInfo.rigidbody;
                    currentObjectCollider = hitInfo.collider;

                    currentObjectRigidBody.isKinematic = true;
                    currentObjectCollider.enabled = false;
                }
                else
                {
                    currentObjectRigidBody = hitInfo.rigidbody;
                    currentObjectCollider = hitInfo.collider;

                    currentObjectRigidBody.isKinematic = true;
                    currentObjectCollider.enabled = false;

                }
                return;
            }
            if (currentObjectRigidBody)
            {
                currentObjectRigidBody.isKinematic = false;
                currentObjectCollider.enabled = true;

                currentObjectRigidBody = null;
                currentObjectCollider = null;
                
            }
        }

        if (currentObjectRigidBody)
        {
            currentObjectRigidBody.position = hand.position;
            currentObjectRigidBody.rotation = hand.rotation;
        }
        if (Keyboard.current.qKey.wasPressedThisFrame)
        {
            if (currentObjectRigidBody)
            {
                currentObjectRigidBody.isKinematic = false;
                currentObjectCollider.enabled = true;

                currentObjectRigidBody.AddForce(camera.transform.forward * throwingForce, ForceMode.Impulse);
                currentObjectRigidBody = null;
                currentObjectCollider = null;
            }
        }


        }
}
