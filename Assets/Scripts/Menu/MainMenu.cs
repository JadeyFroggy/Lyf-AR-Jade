using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject play;
        
    public void PlayGame()
    {
        Debug.Log("Click");
        SceneManager.LoadScene("ArCam");
    }
}
