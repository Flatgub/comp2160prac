using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{

    [SerializeField]
    private int pointsPerPickup = 1;
    public int Score 
    {
        get;
        private set;
    }

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    public void OnPickup()
    {
        Score += pointsPerPickup;
    }
}
