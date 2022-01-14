using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    public static Score Instance { get; private set; }
   
    public int score = 0;
    public int totalEnemy = 36;

    private void Awake()
    {
        Instance = this;
    }


    void Update()
    {
        textScore.text = "Score: " + score.ToString(); 
        if (totalEnemy == 0)
        {
            //Win UI
        }
    }
}
