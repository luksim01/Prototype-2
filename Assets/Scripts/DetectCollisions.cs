using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

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
            Destroy(gameObject);
            Destroy(otherObject.gameObject);
        }
        // alternative colliding object is the player
        else
        {
            Debug.Log("Game Over!");
        }
    }
}
