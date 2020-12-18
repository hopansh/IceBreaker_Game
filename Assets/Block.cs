using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
   private Level level;

   private void Start()
   {
      level = FindObjectOfType<Level>();
      level.CountBBlock();
   }

   private void OnCollisionEnter2D(Collision2D collision)
   {
      Destroy(gameObject);
      level.BlockDestroy();
   }

   
}
