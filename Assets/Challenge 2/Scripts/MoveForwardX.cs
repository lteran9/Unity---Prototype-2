using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype2.Challenge2
{
   public class MoveForwardX : MonoBehaviour
   {
      [SerializeField] float speed = 5.0f;

      // Update is called once per frame
      void Update()
      {
         transform.Translate(Vector3.forward * speed * Time.deltaTime);
      }
   }
}
