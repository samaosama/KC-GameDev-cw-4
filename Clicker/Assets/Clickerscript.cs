using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clickerscript : MonoBehaviour
{
     public int score = 0;
     public int increment = 1;
     public Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void increase()
    {
        score = score + increment;
        scoreText.text=score.ToString();
    }
    public void Shop()
    {
        if (score >= 5)
        {
            increment+=1;
            score -= 1;
            scoreText.text = score.ToString();
        }
    }
}
