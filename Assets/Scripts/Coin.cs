using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //not exactly optimial, but it works for the sake of the prac
        FindObjectOfType<ScoreKeeper>().OnPickup();
        Destroy(gameObject);
    }
}
