using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsOption : MonoBehaviour
{
    
    public void TrackSelect()
    {
        SceneManager.LoadScene(2);

    }
    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void Track01()
    {
        SceneManager.LoadScene(3);
    }

    public void Track02()
    {
        SceneManager.LoadScene(4);
    }
    public void InfoAutori()
    {
        SceneManager.LoadScene(5);
    }
}
