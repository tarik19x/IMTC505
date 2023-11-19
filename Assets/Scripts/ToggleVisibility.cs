using UnityEngine;
using UnityEngine.UI;

public class ToggleVisibility : MonoBehaviour
{
    //private Image targetImage;

    void Start()
    {
        
    }

    public void ToggleImageVisibility(GameObject targetImage)
    {
        // Check if the targetImage GameObject is active in the scene
        if (targetImage.gameObject.activeSelf)
        {
            // If it's active, deactivate it
            targetImage.gameObject.SetActive(false);
        }
        else
        {
            // If it's not active, activate it
            targetImage.gameObject.SetActive(true);
        }
    }
}
