using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype2.Challenge2
{
   public class SpawnManagerX : MonoBehaviour
   {
      float spawnLimitXLeft = -22;
      float spawnLimitXRight = 7;
      float spawnPosY = 30;
      float startDelay = 1.0f;
      float spawnInterval = 4.0f;

      [SerializeField] GameObject[] ballPrefabs;

      // Start is called before the first frame update
      void Start()
      {
         Invoke("SpawnRandomBall", startDelay);
      }

      // Spawn random ball at random x position at top of play area
      void SpawnRandomBall()
      {
         // Generate random ball index and random spawn position
         Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

         int randomIndex = Random.Range(0, ballPrefabs.Length);

         // instantiate ball at random spawn location
         Instantiate(ballPrefabs[randomIndex], spawnPos, ballPrefabs[randomIndex].transform.rotation);

         Invoke("SpawnRandomBall", Random.Range(1, spawnInterval));
      }
   }
}