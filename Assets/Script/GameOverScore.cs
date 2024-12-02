using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameOverScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI totalScore;
    void Start()
    {
        
    }


    private void OnGUI()
    {
        totalScore.text = "TOTAL SCORE: " + GameManager.Instance.Score();
    }
}
