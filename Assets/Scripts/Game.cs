using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Rewind");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
