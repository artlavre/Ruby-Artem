using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour
{
    public GameObject hintPopUp;
    void Start()
    {
        hintPopUp.SetActive(false);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            hintPopUp.SetActive(true);
        }
    }
}
