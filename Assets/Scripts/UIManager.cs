using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private ScoreKeeper keeper;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: " + keeper.Score;
    }
}
