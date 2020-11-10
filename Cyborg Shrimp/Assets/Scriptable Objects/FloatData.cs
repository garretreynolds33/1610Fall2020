﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
 public UnityEvent onZeroEvent;
 
 public float value;

 public void UpdateValue(float number)
 {
  value += number;
 }

 public void ReplaceValue(float number)
 {
  value = number;
 }
 
 public void DisplayImage(Image img)
 {
  if (value <= 0)
  {
   onZeroEvent.Invoke();
  }

  if (value >= 1)
  {
   value = 1;
  }
  
  img.fillAmount = value;
 }

 public void DisplayNumber(Text txt)
 {
  txt.text = value.ToString();
 }
}
