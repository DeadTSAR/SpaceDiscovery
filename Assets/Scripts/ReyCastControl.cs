using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReyCastControl : MonoBehaviour
{
    public Camera cam;
    public GameObject pref;

    void Start()
    {
    
        
    }

    void Update()
    {
        Ray rayCastR = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool collision = Physics.Raycast(rayCastR.origin, rayCastR.direction, out hit);
        if (collision==true)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {

                GameObject intitiazationPrefab =(GameObject) Instantiate(pref, hit.point, Quaternion.identity);
                Destroy(intitiazationPrefab, 2);
            }
           
        }
    }
}
