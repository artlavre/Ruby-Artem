using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public AudioClip collectedClip;
    public GameObject pickUpEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if (controller.currentHealth < controller.maxHealth)
            {
                controller.ChangeHealth(1);

                GameObject pickUp = Instantiate(pickUpEffect, gameObject.transform.position, gameObject.transform.rotation);
                Destroy(gameObject);

                Destroy(pickUp, 2f);
                controller.PlaySound(collectedClip);
            }
        }
    }
}
