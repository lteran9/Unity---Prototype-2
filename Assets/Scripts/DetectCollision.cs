using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype2 {
   public class DetectCollision : MonoBehaviour {
      // Start is called before the first frame update
      private void Start() {

      }

      // Update is called once per frame
      private void Update() {

      }

      private void OnTriggerEnter(Collider other) {
         if (tag == "Player") {
            if (other.CompareTag("Pizza")) {
               return;
            }
         } else if (tag == "Pizza") {
            if (other.CompareTag("Player")) {
               return;
            }
         } else {
            Destroy(gameObject);
            Destroy(other.gameObject);
         }
      }
   }
}