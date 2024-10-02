using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public int Coins;
    public static GameManger gm;

    private void Awake()
    {
        if (gm != null && gm != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gm = this;
            DontDestroyOnLoad(gameObject);

        }
    }

}

public int Score;
public int GetScore()
{
    return Score;
}
private SetScore(int amount)
{
    Score = amount;
}
public void AddScore(int amount)
{
    Score += amount;
}

private GameManger gm;
Start()
{
    gm = FindObjectOfType<GameManger>();
}
private void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Coin"))
    {
        gm.AddScore(1); 
        Destroy(other.gameObject);
    }
}