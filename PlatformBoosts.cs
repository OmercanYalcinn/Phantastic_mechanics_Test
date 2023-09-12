using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBoosts : MonoBehaviour
{
    [SerializeField] private float pushForce = 20f;
    private  Vector2 pushDirection = Vector2.up;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Player") return;
        Debug.Log("Collision Has Done");
        Rigidbody2D rigidbody2D = other.gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.AddForce(pushDirection * pushForce, ForceMode2D.Impulse);
    }
    
}
