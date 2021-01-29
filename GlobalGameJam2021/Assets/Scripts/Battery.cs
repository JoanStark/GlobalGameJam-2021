using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CharacterLight character = collision.gameObject.GetComponent<CharacterLight>();
            if (character.batteryCounter < character.batteryCounterMax)
            {
                character.AddLight();
                Destroy(gameObject);
            }
        }
    }
}
