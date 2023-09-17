using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class CoinSystem : MonoBehaviour
{
    [SerializeField] public List<GameObject> coinScore = new List<GameObject>();
    [SerializeField] public int coinCount = 0;
    public GameObject coin;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Player"){
            gameObject.SetActive(false);
            updatesCoinSystem();
            Debug.Log("Coin has taken");
        }
    }
    
    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Coin")
        {
            gameObject.SetActive(false);
            updatesCoinSystem();
            Debug.Log("Coin has taken");
        }
    }*/
    
    void updatesCoinSystem()
    {
        coinScore.Add(coin);
        coinCount++;
        Debug.Log(coinCount);
    }

    
}
