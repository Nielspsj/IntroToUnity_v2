using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> enemiesList = new List<GameObject>();
    public List<GameObject> spawnLocationsList = new List<GameObject>();
    public GameObject enemyGO;
    public int index = 0;
    public Vector3 spawnPosition;
    private GameObject spawnLocation;

    public List<GameObject> inventoryList = new List<GameObject>();
    private GameObject pickedUpItem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            SpawnEnemies();
        }
        SpawnAtLocations();
    }

    private void SpawnEnemies()
    {
        index = Random.Range(0, enemiesList.Count);
        GameObject enemy = Instantiate(enemiesList[index], spawnPosition, enemiesList[index].transform.rotation);
        enemiesList.Remove(enemy);
    }
    private void SpawnAtLocations()
    {
        index = Random.Range(0, spawnLocationsList.Count);
        spawnLocation = spawnLocationsList[index];
        GameObject spawnLocation = Instantiate(enemyGO, spawnLocationsList[index].transform.position, enemiesList[index].transform.rotation);
        enemiesList.Remove(spawnLocation);
    }

    private void AddToInventory()
    {
        inventoryList.Add(pickedUpItem);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Pickup")
        {
            pickedUpItem = other.gameObject;
            AddToInventory();
        }
    }

}
