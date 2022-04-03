using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroTimer : MonoBehaviour 
{ 
    public float timeRemaining = 10; 
    public Text Welcome; 
    public Text FirstTask; 
    void Start() 
    { 
        FirstTask.gameObject.SetActive(false); 
    } 
 
    // Update is called once per frame 
    void Update() 
    { 
        if (timeRemaining > 0) 
        { 
            timeRemaining -= Time.deltaTime; 
        } 
        if (timeRemaining < 0) 
        { 
            Welcome.gameObject.SetActive(false); 
            FirstTask.gameObject.SetActive(true); 
        } 
    } 
}
