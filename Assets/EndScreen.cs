using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }

    public void LVLSLCT()
    {
        SceneManager.LoadScene("Level Select");
    }

    public void MENU()
    {
        SceneManager.LoadScene("Menu"); 
    }

    public void LVL1()
    {
        SceneManager.LoadScene("1");
    }

    public void LVL2()
    {
        SceneManager.LoadScene("2");
    }

    public void LVL3()
    {
        SceneManager.LoadScene("3");
    }

    public void LVL4()
    {
        SceneManager.LoadScene("4");
    }

    public void LVL5()
    {
        SceneManager.LoadScene("5");
    }
}
