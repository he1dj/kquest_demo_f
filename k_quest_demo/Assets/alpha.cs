using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alpha : MonoBehaviour
{
    public void SetAlpha(){
        var sr = GetComponent<SpriteRenderer>();
        sr.color = new Color(0, 0, 0, 0.4f);
    }
}
