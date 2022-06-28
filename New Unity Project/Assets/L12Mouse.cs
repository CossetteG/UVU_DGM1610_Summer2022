using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L12Mouse : MonoBehaviour
{
   public Rigidbody rb;

   private void Awake()
   {
      rb = GetComponent<Rigidbody>();
      
   }

   void OnMouseDown()
   {
      GetComponent<Renderer>().material.color = Color.black;
      rb.useGravity = true;
   }

}
