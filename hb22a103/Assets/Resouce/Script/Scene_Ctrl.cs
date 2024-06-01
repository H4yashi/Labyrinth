using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Ctrl : MonoBehaviour
{
    public void SC_Play()
    {
        SceneManager.LoadScene("Day3");
    }
    public void SC_Title()
    {
        SceneManager.LoadScene("Title");
    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Result");
        }
    }
}
