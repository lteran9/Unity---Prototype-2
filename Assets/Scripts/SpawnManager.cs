using System.Collections;
using System.Collections.Generic;
using Prototype2.Events.ScriptableObjects;
using UnityEngine;

namespace Prototype2 {
   public class SpawnManager : MonoBehaviour {
      [SerializeField] private GameObject[] animalPrefabs;
      [Header("Listens on")]
      [SerializeField] private VoidEventChannelSO _onStartGame = default;
      [SerializeField] private VoidEventChannelSO _onGameOver = default;

      private bool isGameRunning = false;
      private float spawnRangeX = 15;
      private float spawnPosZ = 20;

      // Start is called before the first frame update
      private void Start() {
         InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
      }

      // Update is called once per frame
      private void Update() {
         //
      }

      private void OnEnable() {
         _onStartGame?.Subscribe(StartGame);
         _onGameOver?.Subscribe(EndGame);
      }

      private void OnDisable() {
         _onStartGame?.Unsubscribe(StartGame);
         _onGameOver?.Unsubscribe(EndGame);
      }

      private void StartGame() {
         isGameRunning = true;
      }

      private void EndGame() {
         isGameRunning = false;
      }

      private void SpawnRandomAnimal() {
         if (isGameRunning) {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            var spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
         }
      }
   }
}