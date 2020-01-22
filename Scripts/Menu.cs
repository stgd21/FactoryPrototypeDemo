using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadPrototype()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadFactory()
    {
        SceneManager.LoadScene(2);
    }
}
