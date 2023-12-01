using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
   

    public void DeactivateObjectWithDelay(GameObject targetObject)
    {
        // Start a coroutine to delay deactivating the object
        StartCoroutine(DeactivateObjectAfterDelayCoroutine());
        
        IEnumerator DeactivateObjectAfterDelayCoroutine()
        {
            // Wait for 2 seconds
            yield return new WaitForSeconds(2f);

            // Deactivate the target object
            targetObject.SetActive(false);
        }
    }
    
    
   
}
