using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadDelay : MonoBehaviour
{
    private int maxAmmo = 5;
    private int ammoAmount;
    private bool isReloading;

    // Start is called before the first frame update
    void Start()
    {
        ammoAmount = maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && isReloading == false)
        {
            ammoAmount--;
            Debug.Log("Fire! Ammo left: " + ammoAmount);
            if(ammoAmount <= 0 )
            {
                isReloading = true;
                StartCoroutine(Reload());
            }
        }
    }

    private IEnumerator Reload()
    {
        Debug.Log("Reloading!");
        yield return new WaitForSeconds(3f);
        isReloading = false;
        ammoAmount = maxAmmo;
        Debug.Log("Ready for action! Ammo: " + ammoAmount);
    }
}
