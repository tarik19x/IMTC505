using UnityEngine;


public class CoverflowManager : MonoBehaviour
{
    public GameObject centerImage;
    public GameObject leftImage;
    public GameObject rightImage;

    private void Start()
    {
        SetTransparency(centerImage, 1f);
        SetTransparency(leftImage, 0.5f);
        SetTransparency(rightImage, 0.5f);
    }

    private void SetTransparency(GameObject image, float transparency)
    {
        var imageRenderer = image.GetComponent<Renderer>();
        var color = imageRenderer.material.color;
        color.a = transparency;
        imageRenderer.material.color = color;
    }

    public void SwipeLeft()
    {
        GameObject temp = rightImage;
        rightImage = centerImage;
        centerImage = leftImage;
        leftImage = temp;

        SetTransparency(centerImage, 1f);
        SetTransparency(leftImage, 0.5f);
        SetTransparency(rightImage, 0.5f);
    }

    public void SwipeRight()
    {
        GameObject temp = leftImage;
        leftImage = centerImage;
        centerImage = rightImage;
        rightImage = temp;

        SetTransparency(centerImage, 1f);
        SetTransparency(leftImage, 0.5f);
        SetTransparency(rightImage, 0.5f);
    }

    // IMixedRealityManipulationHandler methods


   
}
