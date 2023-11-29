using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBox : MonoBehaviour
{
    public GameObject prefab;
    private Vector3 existingPos;
    private Quaternion existingRot;

    // Start is called before the first frame update
    void Start()
    {
        existingPos = transform.position;
        existingRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToReset()
    {
        Destroy(gameObject);
        Instantiate(prefab,existingPos,existingRot);
    }
}
