using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject projectilePrefab;
    private float timer = 4f;
    public float spawnTime = 4f;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SpawnEnemy();
            timer = spawnTime;
            if (spawnTime > 0.1)
            {
                spawnTime -= 0.1f;
            }
            
        }
    }


    public void SpawnEnemy()
    {
        //declare a variable to hold the cloned object
        GameObject clonedProjectile;
        // Use Instantiate to clone the projectile and keep the result in our variable
        clonedProjectile = Instantiate(projectilePrefab);

        //position the projectile on the gameobject... tranform is the location of the script (the object)
        clonedProjectile.transform.position = transform.position; //optional: add an offset (use a public variable)
    }
}
