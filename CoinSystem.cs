using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class CoinSystem : MonoBehaviour
{
    [SerializeField] public int coinCount = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false); // Deactivates the coin
            coinCount++; // Increment the coin score
            Debug.Log(coinCount);
            Debug.Log("Coin has taken");
        }
    }

}
