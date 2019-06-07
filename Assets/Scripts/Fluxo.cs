using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fluxo : MonoBehaviour
{
    public void CarregarJogo()
    {
        SceneManager.LoadScene("Jogo");
    }
}
