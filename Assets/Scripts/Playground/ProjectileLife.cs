using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLife : MonoBehaviour
{
    public float projectileLifetime = 50;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, projectileLifetime);
    }    
}
