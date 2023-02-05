using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy02 : MonoBehaviour
{
    private int hitPower = 20;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMovement player = collision.transform.GetComponent<PlayerMovement>();

        if (player != null)
        {
            player.Damage(hitPower);
        }
    }
}
