using System.Collections;
using System.Collections.Generic;
using Gamekit3D;
using UnityEngine;

public class TouchControl : MonoBehaviour
{
    private bool isTouching = false;
    public float holdDuration = 2f; // Adjust the duration as needed
    public Animator _anim;
    private float touchStartTime;
    public ToggleVisibility tv;
    public GameObject QuestionMenu;
    public InteractionTrigger interactionTrigger;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            // Get the first touch
            Touch touch = Input.GetTouch(0);

            // Perform raycasting from the touch position
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // Record touch start time
                    isTouching = true;
                    touchStartTime = Time.time;
                    break;

                case TouchPhase.Moved:
                    // Check if the touch is still within the same object
                    if (isTouching && Physics.Raycast(ray, out hit) && hit.transform.CompareTag("giftbox"))
                    {
                        // Check if touch has been held for at least 2 seconds
                        if (Time.time - touchStartTime >= 2f)
                        {
                            // Call your custom function when a "giftbox" is touched and held for 2 seconds
                            OnTouchAndHoldStart();
                        }
                    }
                    break;

                case TouchPhase.Ended:
                    // Reset touch state
                    isTouching = false;
                    break;
            }
        }
    }


    private void OnTouchAndHoldStart()
    {
        _anim.SetTrigger("Open");
        interactionTrigger.enabled = true;
        tv.ToggleImageVisibility(QuestionMenu);
        _anim.SetTrigger("Pickup");


    }
    
}