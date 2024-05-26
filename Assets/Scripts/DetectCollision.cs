using System.Collections;
using System.Collections.Generic;
using Prototype2.Events.ScriptableObjects;
using UnityEngine;

namespace Prototype2 {
   public class DetectCollision : MonoBehaviour {
      [Header("Broadcasts on")]
      [SerializeField] private VoidEventChannelSO _onGameOver = default;
      [SerializeField] private VoidEventChannelSO _onScoreIncrease = default;

      /// <summary>
      /// Detects collision between player and animals or pizza and animals.
      /// </summary>
      /// <param name="other"></param>
      private void OnTriggerEnter(Collider other) {
         if (tag == "Pizza" && other.CompareTag("Player")) {
            return;
         } else {
            Destroy(gameObject);
            if (other.CompareTag("Player")) {
               other.gameObject.SetActive(false);
               other.gameObject.transform.position = Vector3.zero;
               _onGameOver?.RaiseEvent();
            } else {
               Destroy(other.gameObject);
               _onScoreIncrease?.RaiseEvent();
            }
         }
      }
   }
}