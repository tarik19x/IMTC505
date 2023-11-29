using System.Collections;
using System.Collections.Generic;
using MixedReality.Toolkit;
using MixedReality.Toolkit.UX;
using UnityEngine;

public class InteractController : MonoBehaviour
{
    // Start is called before the first frame update
    private StatefulInteractable interactable;

    void Start()
    {
        interactable = GetComponent<StatefulInteractable>();
        if (interactable == null)
        {
            interactable = gameObject.AddComponent<StatefulInteractable>();
        }
        interactable.OnClicked.AddListener(OnClickCallback);
        
        gameObject.AddComponent<UGUIInputAdapter>();
    }

    public void OnClickCallback()
    {
       Debug.Log("debugging"); 
    }
    


}
