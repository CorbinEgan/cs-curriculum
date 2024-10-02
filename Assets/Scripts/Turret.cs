using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private float Cooldown;

    private float Firerate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OntriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") & (Cooldown < 0))
        {
            Instantiate(bullet)
                bullet.targetposistion 
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
