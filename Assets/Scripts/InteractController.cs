using System;
using System.Collections;
using System.Collections.Generic;
using MixedReality.Toolkit;
using MixedReality.Toolkit.UX;
using UnityEngine;

public class InteractController : MonoBehaviour
{
    // Start is called before the first frame update
    private StatefulInteractable interactable;
    public Animator anim;

    void Start()
    {
        interactable = GetComponent<StatefulInteractable>();
        if (interactable == null)
        {
            interactable = gameObject.AddComponent<StatefulInteractable>();
        }
        // interactable.OnClicked.AddListener(OnClickCallback);
        //
        // gameObject.AddComponent<UGUIInputAdapter>();
    }

    private void Update()
    {
        
            if (interactable.IsGrabHovered)
            {
                anim.SetTrigger("Open");
            }
            else
            {
                Debug.Log("Object is not being poked or hovered over");
            }
        
    }

   
    


}
