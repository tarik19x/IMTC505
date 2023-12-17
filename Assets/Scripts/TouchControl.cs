using System.Collections;
using System.Collections.Generic;
using Gamekit3D;
using UnityEngine;

public class TouchControl : MonoBehaviour
{
    private bool isTouching = false;
    public Animator _anim;
    public ToggleVisibility tv;
    public GameObject QuestionMenu;
    public InteractionTrigger interactionTrigger;

    private void Update()
    {
        // Check if there are exactly two touches
        if (Input.touchCount == 2)
        {
            // Get both touches
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            // Perform raycasting from both touch positions
            Ray ray1 = Camera.main.ScreenPointToRay(touch1.position);
            Ray ray2 = Camera.main.ScreenPointToRay(touch2.position);

            // Check if both touches are over the "giftbox" object
            RaycastHit hit1, hit2;
            bool isTouchingGiftbox1 = Physics.Raycast(ray1, out hit1) && hit1.transform.CompareTag("giftbox");
            bool isTouchingGiftbox2 = Physics.Raycast(ray2, out hit2) && hit2.transform.CompareTag("giftbox");

            if (isTouchingGiftbox1 && isTouchingGiftbox2)
            {
                // Call your custom function when there is a two-finger touch on the "giftbox"
                OnTwoFingerTouch();
            }
        }
    }

    private void OnTwoFingerTouch()
    {
        tv.ToggleImageVisibility(QuestionMenu);
        // Implement your logic for two-finger touch
        _anim.SetTrigger("Open");
        interactionTrigger.enabled = true;
        
        _anim.SetTrigger("Pickup");
    }
}