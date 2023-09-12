using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private float followSpeed = 2f;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(player.position.x, player.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, newPosition, followSpeed * Time.deltaTime);
    }
}
