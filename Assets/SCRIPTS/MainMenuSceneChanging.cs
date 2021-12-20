using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class MainMenuSceneChanging : MonoBehaviour
{
    public void StartGame()
    {
        EditorSceneManager.LoadScene("OpeningScene");
    }
}
