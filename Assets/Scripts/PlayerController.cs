using System.Collections;
using System.Collections.Generic;
using Prototype2.Events.ScriptableObjects;
using UnityEngine;

namespace Prototype2 {
   public class PlayerController : MonoBehaviour {
      [SerializeField] private float speed = 0f;
      [SerializeField] private GameObject projectilePrefab = default;
      [Header("Listens on")]
      [SerializeField] private VoidEventChannelSO _onStartGame = default;

      private bool isGameRunning = false;
      // Keep player between -15m and 15m on X axis
      private float bounds = 15.0f;

      // Start is called before the first frame update
      private void Start() {

      }

      // Update is called once per frame
      private void Update() {
         if (isGameRunning) {
            KeepPlayerInbounds();
            MovePlayerHorizontally(Input.GetAxis("Horizontal"));
            FirePizza();
         }
      }

      private void OnEnable() {
         _onStartGame?.Subscribe(StartGame);
      }

      private void OnDisable() {
         _onStartGame?.Unsubscribe(StartGame);
      }

      private void StartGame() {
         isGameRunning = true;
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