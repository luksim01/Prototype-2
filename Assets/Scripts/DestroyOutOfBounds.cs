using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    private float zBoundary = 20;
    private float xBoundary = 25;

    private GameUI gameUI;

    // Start is called before the first frame update
    void Start()
    {
        // reference PlayerTracker script to make use of methods
        gameUI = GameObject.Find("GameUI").GetComponent<GameUI>();
    }

    // Update is called once per frame
    void Update()
    {
        // check if any animals get beyond the boundaries
        if (transform.position.z > zBoundary)
        {
            Destroy(gameObject);
            gameUI.decreaseLivesBy(1);
        }
        else if (transform.position.z < -zBoundary)
        {
            Destroy(gameObject);
            gameUI.decreaseLivesBy(1);
        }
        else if (transform.position.x > xBoundary)
        {
            Destroy(gameObject);
            gameUI.decreaseLivesBy(1);
        }
        else if (transform.position.x < -xBoundary)
        {
            Destroy(gameObject);
            gameUI.decreaseLivesBy(1);
        }
    }
}
