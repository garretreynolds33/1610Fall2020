﻿using System;
using UnityEngine;

public class AttachOnTrigger : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Ground"))
      {
         transform.parent = other.transform;
      }
      
   }

   private void OnTriggerExit(Collider other)
   {
      transform.parent = null;
   }
}