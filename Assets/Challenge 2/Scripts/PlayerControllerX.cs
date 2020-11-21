using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float coolDown = 1;  // time the user has to wait to fire again
    private float fireNext = 0;  // time the user can fire again
    // Update is called once per frame
    void Update()
    {
 // On spacebar press, send dog and if time has passed single last fire send dog 
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > fireNext)
        {
  fireNext = Time.time + coolDown; // resets the fireNext variable to current time + coolDown
       Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
