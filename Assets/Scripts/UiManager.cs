using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UiManager : MonoBehaviour
{
    public static int scoreValue;
    public TextMeshProUGUI score;
      
    void Update()
    {
        score.text = scoreValue.ToString();
    }
}
