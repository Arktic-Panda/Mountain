using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerTxt;
    
    private bool finished = false;

    public float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (finished)
            return;
        
        currentTime += Time.deltaTime;

        string minutes = ((int) currentTime/60 ).ToString();
        string seconds = (currentTime % 60 ).ToString("f2");
        
        timerTxt.text = minutes + ":" + seconds;
        
    }

  
    
    public void Finish ()
    {
        timerTxt.color = Color.red;
        finished = true;

    }
}
