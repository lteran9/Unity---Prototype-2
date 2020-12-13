using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
   public GameObject dogPrefab;

   private float lastKeyPress;

   void Start()
   {
      //
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
