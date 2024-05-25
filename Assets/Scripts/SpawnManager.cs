using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype2 {
   public class SpawnManager : MonoBehaviour {
      [SerializeField] private GameObject[] animalPrefabs;

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

      private void SpawnRandomAnimal() {
         int animalIndex = Random.Range(0, animalPrefabs.Length);
         var spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

         Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
      }
   }
}