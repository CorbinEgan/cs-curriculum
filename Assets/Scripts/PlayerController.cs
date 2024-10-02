using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float xSpeed = 5f;
    float xVector = 0f;
    float xdirection;
    float ydirection;
    float yvector;

    public bool overworld;
    public float speed;

    private void Start()
    {
        GetComponentInChildren<TopDown_AnimatorController>().enabled = overworld;
        GetComponentInChildren<Platformer_AnimatorController>().enabled = !overworld; //what do you think ! means?

        if (overworld)
        {
            GetComponent<Rigidbody2D>().gravityScale = 0f;
        }
        else
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }

    private void Update()
    {
        xdirection = Input.GetAxis("Horizontal");
        if (overworld)
        {
            ydirection = Input.GetAxis("Vertical");
        }
        xVector = xSpeed * xdirection;
        yvector = xSpeed * ydirection;

        transform.Translate(xVector * Time.deltaTime, yvector * Time.deltaTime, 0);
    }
    
}