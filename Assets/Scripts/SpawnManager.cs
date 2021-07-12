using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype2
{
   public class SpawnManager : MonoBehaviour
   {
      float spawnRangeX = 15;
      float spawnPosZ = 20;

      [SerializeField] GameObject[] animalPrefabs;

      // Start is called before the first frame update
      void Start()
      {
         InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
      }

      // Update is called once per frame
      void Update()
      {
         if (Input.GetKeyDown(KeyCode.S))
         {
            SpawnRandomAnimal();
         }
      }

      void SpawnRandomAnimal()
      {
         int animalIndex = Random.Range(0, animalPrefabs.Length);
         var spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

         Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
      }
   }
}