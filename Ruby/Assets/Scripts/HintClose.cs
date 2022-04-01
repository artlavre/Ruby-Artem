using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintClose : MonoBehaviour
{
    public GameObject popUp;
    public GameObject trigger;
    public void Close()
    {
        popUp.SetActive(false);
        trigger.SetActive(false);
    }
}
