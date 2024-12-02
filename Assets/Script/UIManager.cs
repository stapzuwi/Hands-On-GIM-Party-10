using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject score;
    [SerializeField] private TextMeshProUGUI scoreUI;
    void Start()
    {
        score.SetActive(true);
    }
    void Update()
    {
        if (GameManager.Instance.isPlaying == false)
        {
            score.SetActive(false);
            enabled = false;
        }
    }
    private void OnGUI()
    {
        scoreUI.text = "Score: " + GameManager.Instance.Score();
    }

        
}
