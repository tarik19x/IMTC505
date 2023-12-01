using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildVisibilityAnimation : MonoBehaviour
{
    public GameObject[] gameObjects; // Array to hold your three game objects
    private int currentIndex = 0; // Index to keep track of the currently visible object
    private float interval = 1f; // Interval in seconds

    void Start()
    {
        // Make sure all objects are initially set to inactive (invisible)
        foreach (GameObject obj in gameObjects)
        {
            obj.SetActive(false);
        }

        // Set the last object to active (visible)
        currentIndex = gameObjects.Length - 1;
        gameObjects[currentIndex].SetActive(true);
    }

    void Update()
    {
        // Check if the interval has passed
        if (Time.time % interval < Time.deltaTime)
        {
            // Set the current object to inactive (invisible)
            gameObjects[currentIndex].SetActive(false);

            // Decrement the index for the previous object
            currentIndex = (currentIndex - 1 + gameObjects.Length) % gameObjects.Length;

            // Set the previous object to active (visible)
            gameObjects[currentIndex].SetActive(true);
        }
    }
}
