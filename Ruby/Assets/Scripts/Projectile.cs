using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    public GameObject destructive;
    public GameObject food;

    private NonPlayerCharacter npcScript;

    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        npcScript = GameObject.Find("Jambi").GetComponent<NonPlayerCharacter>();
    }

    void Update()
    {
        if (transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject);
        }
    }

    public void Launch(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        int rand = Random.Range(0, 2);

        EnemyController e = other.collider.GetComponent<EnemyController>();
        if (e != null)
        {
            e.Fix();
            npcScript.SetCountText();
        }

        if (other.gameObject.CompareTag("Destructible"))
        {
            
            GameObject destrEffect = Instantiate(destructive, other.gameObject.transform.position, other.gameObject.transform.rotation);


            if(rand == 1)
            {
                GameObject health = Instantiate(food, other.gameObject.transform.position, other.gameObject.transform.rotation);
            }


            other.gameObject.SetActive(false);

            Destroy(destrEffect,2);
        }

        Destroy(gameObject);


    }
}
