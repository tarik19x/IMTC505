using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour
{
    public float holdDuration = 4f; // Adjust the duration as needed
    public Animator _anim;
    private void Update()
    {
        // Check for touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // Check if the touch began on the object
                    if (IsTouchingObject(touch.position))
                    {
                        // Call the function when the touch begins
                        OnTouchAndHoldStart();
                    }
                    break;

                case TouchPhase.Ended:
                    // Call the function when the touch ends
                    OnTouchAndHoldEnd();
                    break;
            }
        }
    }

    private bool IsTouchingObject(Vector2 touchPosition)
    {
        // Cast a ray from the touch position to see if it hits the object
        Ray ray = Camera.main.ScreenPointToRay(touchPosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            return hit.collider.gameObject == gameObject;
        }

        return false;
    }

    private void OnTouchAndHoldStart()
    {
        _anim.SetTrigger("Open");
    }

    private void OnTouchAndHoldEnd()
    {
        _anim.SetTrigger("Pickup");

    }
}
