using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public float horizontalInput;
   public float speed;
   private float leftBoundary = -15.0f;
   private float rightBoundary = 15.0f;

   public GameObject projectilePrefab;

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
