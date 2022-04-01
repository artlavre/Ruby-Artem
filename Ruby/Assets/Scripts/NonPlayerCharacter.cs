using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NonPlayerCharacter : MonoBehaviour
{
    public GameObject dialogBox;
    public GameObject questHolder;
    public TextMeshProUGUI questText;
    public int fixedRobots = 0;

    void Start()
    {
        dialogBox.transform.localScale = Vector2.zero;
        questHolder.SetActive(false);
    }

    public void DisplayDialog()
    {
        dialogBox.transform.LeanScale(Vector2.Scale(new Vector2(0.01f, 0.01f), new Vector2(1f,1f)), 0.4f);
    }

    public void DialogClose()
    {
        dialogBox.transform.LeanScale(Vector2.zero, 0.4f);
    }

    public void Quest()
    {
        questHolder.SetActive(true);
        dialogBox.transform.LeanScale(Vector2.zero, 0.4f);
        Invoke("HideDialog", 1f);
    }

    void HideDialog()
    {
        dialogBox.SetActive(false);
    }

    public void SetCountText()
    {
        fixedRobots++;
        questText.text = fixedRobots.ToString() + "/5 Fixed Robots";
    }
}
