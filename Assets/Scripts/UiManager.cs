using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UiManager : MonoBehaviour
{
    public static int scoreTotal;
    public TextMeshProUGUI score;
      
    void Update()
    {
        score.text = scoreTotal.ToString();
    }
}
