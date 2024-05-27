using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype2 {
   /// <summary>
   /// Component used by enemies to move forward in a straight line. Different types of enemies have different speeds.
   /// </summary>
   public class MoveForward : MonoBehaviour {
      [SerializeField] private float speed = 20.0f;

      // Start is called before the first frame update
      private void Start() {

      }

      // Update is called once per frame
      private void Update() {
         transform.Translate(Vector3.forward * Time.deltaTime * speed);
      }
   }
}