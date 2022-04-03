using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class welcome : MonoBehaviour
{
    public float timer = 10;
    public Text WelcomeText;
    void Start()
    {
        
    }
    void Update()
    {
        if (timer > 0){
            timer -= Time.deltaTime;
        }
        if (timer <0){
            WelcomeText.gameObject.SetActive(false);
        }
    }
}
