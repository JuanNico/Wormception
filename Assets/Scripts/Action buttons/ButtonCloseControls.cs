using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCloseControls : MonoBehaviour
{
    public GameObject Panel;
    public void ClosePanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(false);
        }
    }
}
