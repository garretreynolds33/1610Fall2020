using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : Players
{
   public float superiorityDice = 1f;

   protected void actionSurge()
   {
      var use = superiorityDice;
   }
   
}
