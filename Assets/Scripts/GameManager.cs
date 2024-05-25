using System.Collections;
using System.Collections.Generic;
using Prototype2.Events.ScriptableObjects;
using UnityEngine;

namespace Prototype2 {
   public class GameManager : MonoBehaviour {
      [SerializeField] private GameObject _titleScreen;
      [Header("Broadcasts on")]
      [SerializeField] private VoidEventChannelSO _onStartGame;
      [Header("Listens on")]
      [SerializeField] private VoidEventChannelSO _onGameOver;

      private void OnEnable() {
         _onGameOver?.Subscribe(EndGame);
      }

      private void OnDisable() {
         _onGameOver?.Unsubscribe(EndGame);
      }

      public void StartGame() {
         _titleScreen?.SetActive(false);
         _onStartGame?.RaiseEvent();
      }

      public void EndGame() {
         _titleScreen?.SetActive(true);
      }
   }
}