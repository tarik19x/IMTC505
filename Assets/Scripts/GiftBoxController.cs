using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftBoxController : MonoBehaviour
{
    public GameObject giftbox1;
    public GameObject giftbox2;
    public GameObject giftbox3;

    private int clickCount = 0;

    private void Start()
    {
        // Set initial visibility
        giftbox1.SetActive(true);
        giftbox2.SetActive(false);
        giftbox3.SetActive(false);
    }

    public void HandleClick()
    {
        // Increment click count
        clickCount++;

        // Deactivate the current gift box after a 4-second delay
        Invoke("DeactivateCurrentGiftBox", 4f);

        // Activate the next gift box
        switch (clickCount)
        {
            case 1:
                StartCoroutine(ActivateGiftBox(giftbox2, 5f));
                break;
            case 2:
                StartCoroutine(ActivateGiftBox(giftbox3, 5f));
                break;
            // Add more cases for additional gift boxes if needed
            default:
                Debug.Log("All gift boxes opened!");
                break;
        }
    }

    private void DeactivateCurrentGiftBox()
    {
        // Deactivate the current gift box
        if (clickCount == 1)
        {
            giftbox1.SetActive(false);
        }
        else if (clickCount == 2)
        {
            giftbox2.SetActive(false);
        }
        // Add more conditions for additional gift boxes if needed
    }

    private IEnumerator ActivateGiftBox(GameObject giftbox, float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Activate the next gift box
        giftbox.SetActive(true);
    }
}