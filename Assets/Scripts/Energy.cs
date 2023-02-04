using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour
{
    private int energyPower = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMovement player = collision.transform.GetComponent<PlayerMovement>();

        if (player != null)
        {
            player.GetEnergy(energyPower);
        }
    }
}
