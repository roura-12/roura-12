using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene("name of the scene") or (index of the scene);
        //SceneManager.LoadScene("") (1);
    }
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}


