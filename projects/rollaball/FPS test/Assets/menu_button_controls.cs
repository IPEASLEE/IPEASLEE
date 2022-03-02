using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu_button_controls : MonoBehaviour
{
    public void LoadOnClick()
    {
        SceneManager.LoadScene("level one");
    }
    public void QuitOnClick()
    {
        Application.Quit();
    }
}