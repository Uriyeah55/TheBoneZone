using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScorePlayerPref : MonoBehaviour
{
    public int scoreToSet;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("HighScore", scoreToSet);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
