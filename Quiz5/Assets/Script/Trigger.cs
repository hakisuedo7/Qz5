using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    Controller controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            controller.EnableObstacle();
        }
        else
        {
            return;
        }
    }
}
