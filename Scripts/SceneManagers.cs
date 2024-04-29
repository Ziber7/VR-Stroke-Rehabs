using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagers : MonoBehaviour
{
    // ...

    public void LoadSceneButton(int angkaScene)
    {
        SceneManager.LoadScene(angkaScene);
    }

    public void ExitApp()
    {
        Application.Quit();
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Lobby_Menu");
    }
}
