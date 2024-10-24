using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSShooting : MonoBehaviour
{
    public LayerMask explosionLayer;
    private Collider[] hits;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hitInfo;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hitInfo))
        {
            if (hitInfo.transform.tag == "Enemy" && Input.GetKeyDown(KeyCode.Mouse0))
            {
                Debug.Log("Can shoot this");
                hitInfo.transform.GetComponent<Renderer>().material.color = Color.yellow;
                hitInfo.transform.GetComponent<EnemyBehavior>().damageTaken = 20;
                hitInfo.transform.GetComponent<EnemyBehavior>().TakeDamage();

                //Spawn bomb and explode it? Gotta get all colliders in an area
                /*
                GameObject bomb = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                bomb.name = "Bomb";
                bomb.transform.position = hitInfo.transform.position;
                bomb.AddComponent<Rigidbody>();
                */
                Collider[] hitColliders = Physics.OverlapSphere(hitInfo.transform.position, 10, explosionLayer);
                Debug.Log("colliders: " + hitColliders.Length);
                foreach (var hitCollider in hitColliders)
                {
                    Debug.Log("hitcol: " + hitCollider.gameObject.name);
                    //hitCollider.SendMessage("AddDamage");
                    hitCollider.transform.GetComponent<Rigidbody>().AddExplosionForce(1000, hitInfo.transform.position, 5);
                }
                
            }
        }
    }
}
