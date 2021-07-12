using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype2.Challenge2
{
   public class DetectCollisionsX : MonoBehaviour
   {
      private void OnTriggerEnter(Collider other)
      {
         Destroy(gameObject);
      }
   }
}