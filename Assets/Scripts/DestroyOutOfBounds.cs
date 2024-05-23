using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype2 {
   public class DestroyOutOfBounds : MonoBehaviour {
      private float topBound = 30.0f;
      private float lowBound = -10.0f;

      // Start is called before the first frame update
      private void Start() {

      }

      // Update is called once per frame
      private void Update() {
         if (transform.position.z > topBound) {
            Destroy(gameObject);
         } else if (transform.position.z < lowBound) {
            Destroy(gameObject);
         }
      }
   }
}