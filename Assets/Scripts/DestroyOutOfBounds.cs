using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype2 {
   /// <summary>
   /// Component to destroy enemies when they reach an out-of-bounds marker.
   /// </summary>
   public class DestroyOutOfBounds : MonoBehaviour {
      private float topBound = 30.0f;
      private float lowBound = -10.0f;

      //  Called every fixed frame-rate frame
      private void FixedUpdate() {
         if (transform.position.z > topBound) {
            Destroy(gameObject);
         } else if (transform.position.z < lowBound) {
            Destroy(gameObject);
         }
      }
   }
}