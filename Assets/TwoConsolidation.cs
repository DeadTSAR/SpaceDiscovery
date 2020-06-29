using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoConsolidation : MonoBehaviour
{
    public Enemy1 enemy1;
    public Enemy2 enemy2;
    // Start is called before the first frame update
    void Start()
    {
        (enemy1 as IKillable).Die();
        ((IKillable)enemy2).Die();
    }
 
    // Update is called once per frame
    void Update()
    {

    }
}




