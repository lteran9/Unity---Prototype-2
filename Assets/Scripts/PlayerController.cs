using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype2 {
   public class PlayerController : MonoBehaviour {
      [SerializeField] private float speed;
      [SerializeField] private GameObject projectilePrefab;

      // Keep player between -15m and 15m on X axis
      private float bounds = 15.0f;

      // Start is called before the first frame update
      private void Start() {

      }

      // Update is called once per frame
      private void Update() {
         KeepPlayerInbounds();
         MovePlayerHorizontally(Input.GetAxis("Horizontal"));
         FirePizza();
      }

      /// <summary>
      /// This method will look at the player's transform position and prevent them from going out of bounds.
      /// </summary>
      private void KeepPlayerInbounds() {
         // Left boundary
         if (transform.position.x < -bounds) {
            transform.position = new Vector3(-bounds, transform.position.y, transform.position.z);
         }
         // Right boundary
         if (transform.position.x > bounds) {
            transform.position = new Vector3(bounds, transform.position.y, transform.position.z);
         }
      }

      private void MovePlayerHorizontally(float horizontalInput) {
         transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
      }

      private void FirePizza() {
         if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(projectilePrefab, new Vector3(transform.position.x, 1, transform.position.z), projectilePrefab.transform.rotation);
         }
      }
   }
}