using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestBoxController : MonoBehaviour
{
    public GameObject questBoxPrefab;
    public GameObject questBoxPrefab2;
    public GameObject questBoxPrefab3;
    public GameObject questBoxPrefab4;
    private Vector3 existingPos;
    private Quaternion existingRot;
    private int numberOfExitClick = 0;

    // Start is called before the first frame update
    void Start()
    {
        questBoxPrefab.SetActive(true);
        questBoxPrefab2.SetActive(false);
        questBoxPrefab3.SetActive(false);
        questBoxPrefab4.SetActive(false);
        existingPos = questBoxPrefab.transform.position;
        existingRot = questBoxPrefab.transform.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void whenExitClicked()
    {
        numberOfExitClick++;
        switch (numberOfExitClick)
        {
            case 1:
                questBoxPrefab.SetActive(false);
                questBoxPrefab2.SetActive(true);
                break;
            case 2:
                questBoxPrefab2.SetActive(false);
                questBoxPrefab3.SetActive(true);
                break;
            case 3:
                questBoxPrefab3.SetActive(false);
                questBoxPrefab4.SetActive(true);
                break;
            default:
                break;
        }

    }


}
