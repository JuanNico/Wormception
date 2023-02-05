using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonStart : MonoBehaviour
{
    public void StartGamePressed()
    {
        Debug.Log("Start");
        SceneManager.LoadScene("Leve3l");
    }
}
