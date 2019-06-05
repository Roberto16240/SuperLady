using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pontos : MonoBehaviour
{
    public Text score;
    void Update()
    {
        score.text = Player.pontos.ToString();
    }
}
