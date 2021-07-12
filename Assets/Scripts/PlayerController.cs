using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype2
{
   public class PlayerController : MonoBehaviour
   {
      float horizontalInput;
      float leftBoundary = -15.0f;
      float rightBoundary = 15.0f;

      [SerializeField] float speed;
      [SerializeField] GameObject projectilePrefab;

      // Start is called before the first frame update
      void Start()
      {

      }

      // Update is called once per frame
      void Update()
      {
         // Keep player inbounds
         if (transform.position.x < leftBoundary)
         {
            transform.position = new Vector3(leftBoundary, transform.position.y, transform.position.z);
         }
         // Keep player inbounds
         if (transform.position.x > rightBoundary)
         {
            transform.position = new Vector3(rightBoundary, transform.position.y, transform.position.z);
         }

         horizontalInput = Input.GetAxis("Horizontal");
         transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

         if (Input.GetKeyDown(KeyCode.Space))
         {
            Instantiate(projectilePrefab, new Vector3(transform.position.x, 1, transform.position.z), projectilePrefab.transform.rotation);
         }
      }
   }
}