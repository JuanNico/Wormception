using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIinteractions : MonoBehaviour
{
    public Button startGame;
    public Button quitGame;
    public Label messageText;
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        startGame = root.Q<Button>("start-game");
        quitGame = root.Q<Button>("quit-game");

        startGame.clicked += StartGamePressed;
        quitGame.clicked += QuitGamePressed;

    }
    public void StartGamePressed()
    {
        Debug.Log("Start");
        SceneManager.LoadScene("Level");
    }

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
