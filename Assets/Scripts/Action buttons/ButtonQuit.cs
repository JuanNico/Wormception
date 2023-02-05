using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonQuit : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey("escape"))
        {
            QuitGamePressed();
        }
    }

    public void QuitGamePressed()
    {
        #if UNITY_STANDALONE
                Debug.Log("UNITY_STANDALONE Quit");
                Application.Quit();
        #endif
        #if UNITY_EDITOR
                Debug.Log("UNITY_EDITOR Quit");
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
