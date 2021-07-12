using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype2.Challenge2
{
   public class DestroyOutOfBoundsX : MonoBehaviour
   {
      float leftLimit = 40.0f;
      float bottomLimit = -5.0f;

      // Update is called once per frame
      void Update()
      {
         // Destroy dogs if x position less than left limit
         if (transform.position.x < -leftLimit)
         {
            Destroy(gameObject);
         }
         // Destroy balls if y position is less than bottomLimit
         else if (transform.position.y < bottomLimit)
         {
            Destroy(gameObject);
         }

      }
   }
}