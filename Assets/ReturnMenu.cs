using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReturnMenu : MonoBehaviour
{
    public void VoltarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
