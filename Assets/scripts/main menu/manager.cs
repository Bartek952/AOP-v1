using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("FirstLVL");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
