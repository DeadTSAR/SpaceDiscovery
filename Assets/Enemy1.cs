using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour, IKillable
{
    private float _health = 100f;

    public float Health
    {
        get{ return _health; }
    }

    public void Die()
    {
        print("lol you 1 Die!");
    }
}
