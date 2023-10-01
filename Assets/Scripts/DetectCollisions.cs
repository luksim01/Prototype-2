using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
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

    }

    private void OnTriggerEnter(Collider otherObject)
    {
        // if colliding object is an apple
        if(otherObject.name.Contains("Apple"))
        {
            // both apple and animal are destroyed and score is incremented
            gameUI.increaseScoreBy(1);
            Destroy(gameObject);
            Destroy(otherObject.gameObject);
        }
        // alternative colliding object is the player
        else
        {
            gameUI.decreaseLivesBy(1);
        }
    }
}
