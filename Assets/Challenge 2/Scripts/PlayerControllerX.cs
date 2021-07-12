using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype2.Challenge2
{
   public class PlayerControllerX : MonoBehaviour
   {
      float lastKeyPress;

      [SerializeField] GameObject dogPrefab;

      //
      void Start()
      {

      }

      // Update is called once per frame
      void Update()
      {
         // On spacebar press, send dog
         if (Input.GetKeyDown(KeyCode.Space))
         {
            if (lastKeyPress + 1 <= Time.time)
            {
               lastKeyPress = Time.time;
               Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
         }
      }
   }
}