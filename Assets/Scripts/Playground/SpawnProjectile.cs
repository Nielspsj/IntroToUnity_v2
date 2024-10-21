using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{
    //Spawn a prefab object. How do we give it movement? Check in the other scripts.
    //Add a prefab for the projectile to spawn in the Inspector.
    public GameObject spawnedProjectile;
    // Start is called before the first frame update
    void Start()
    {
        //Spawn once on Start
        Spawn();
    }

    //Spawn a projectile prefab in the position of the object holding the spawn script but taking the projectile rotation.
    private void Spawn()
    {
        Instantiate(spawnedProjectile, transform.position, spawnedProjectile.transform.rotation);
    }
}
