using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    public static GameManger gm;

    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManger>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.gameObject.CompareTag("Coin"))
            {
                score = score + 1;
                Destroy(other.gameObject);
                Debug.Log(message: "score: " + score);
            }
        
    }
}