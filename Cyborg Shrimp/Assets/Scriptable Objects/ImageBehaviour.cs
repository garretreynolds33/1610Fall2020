using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour
{
    private Image img;
    
    private void Start()
    {
        img = GetComponent<Image>();
    }

    public void DisplayValue(FloatData data)
    {
        img.fillAmount = data.value;
    }
}
