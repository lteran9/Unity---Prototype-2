using System.Collections;
using System.Collections.Generic;
using Prototype2.Events.ScriptableObjects;
using UnityEngine;

namespace Prototype2 {
   public class GameManager : MonoBehaviour {
      [SerializeField] private GameObject _titleScreen = default;
      [SerializeField] private GameObject _gameScreen = default;
      [Header("Broadcasts on")]
      [SerializeField] private VoidEventChannelSO _onStartGame = default;
      [Header("Listens on")]
      [SerializeField] private VoidEventChannelSO _onGameOver = default;
      [SerializeField] private VoidEventChannelSO _scoreIncrease = default;

      private int score = 0;

      private void OnEnable() {
         _onGameOver?.Subscribe(EndGame);
         _scoreIncrease?.Subscribe(ScoreIncrease);
      }

      private void OnDisable() {
         _onGameOver?.Unsubscribe(EndGame);
         _scoreIncrease?.Unsubscribe(ScoreIncrease);
      }

      private void ScoreIncrease() {
         score++;
      }

      public void StartGame() {
         _titleScreen?.SetActive(false);
         _gameScreen?.SetActive(true);
         _onStartGame?.RaiseEvent();
      }

      public void EndGame() {
         _gameScreen?.SetActive(false);
         _titleScreen?.SetActive(true);
      }
   }
}