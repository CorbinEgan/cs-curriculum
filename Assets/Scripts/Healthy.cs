using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthy : MonoBehaviour

{
    public GameManger gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindFirstObjectByType<GameManger>();
    }

    private void OnCollisionEnter2D(Collision2D other);
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
