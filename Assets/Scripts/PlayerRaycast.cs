using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class PlayerRaycast : MonoBehaviour
{

    private GameObject raycastedObject;

    [SerializeField] private int rayLength = 10;
    public LayerMask interactibleLayerMask = 6;
    [SerializeField] private Image uiCrosshair;

    //TODO: move this
    public GameObject InventoryUI;
    bool inventoryActive = false;
    public GameObject FirstPersonControllerParent;

    [SerializeField] private InputActionAsset playerControls;


    private void Start()
    {

    }
    private void Awake()
    {
       // var controlsActionMap = playerControls.GetActionMap("Player");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, rayLength, interactibleLayerMask.value))
        {
            if (hit.collider.CompareTag("Interactable"))
            {
                raycastedObject = hit.collider.gameObject;
                CrosshairActive();
                if (Keyboard.current.eKey.wasPressedThisFrame)
                {
                    hit.collider.gameObject.SendMessage("Interact");
                  //  raycastedObject.SetActive(false); // this is good for collecting objects..
                }

            }
        }
        else
        {
            CrosshairNormal();
        }

        //TODO: Move this somewhere else, Dependent on GameObject InventoryUI
        if (Keyboard.current.iKey.wasPressedThisFrame)
        {
            if (inventoryActive == false) {
                InventoryUI.GetComponent<Canvas>().enabled = true;
                inventoryActive = true;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                FirstPersonControllerParent.SendMessage("stopRotation");
                
            }
            else
            {
                InventoryUI.GetComponent<Canvas>().enabled = false;
                inventoryActive = false;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                FirstPersonControllerParent.SendMessage("startRotation");
            }

        }
    }
    void CrosshairActive()
    {
        uiCrosshair.color = Color.red;
    }

    void CrosshairNormal()
    {
        uiCrosshair.color = Color.black;
    }

    //TODO: Move this
    private bool isMouseOverUI() {

        return EventSystem.current.IsPointerOverGameObject();
    }
}
