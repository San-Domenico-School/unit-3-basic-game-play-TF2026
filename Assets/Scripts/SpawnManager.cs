using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float spawnrange = 15f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;
    [SerializeField] GameObject[] animals;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // spawns random animal
    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animals.Length);
        float x = Random.Range(-spawnrange, spawnrange);
        Vector3 spawnPosition = new Vector3(x, 0.0f, 25.0f);
        GameObject animal = animals[animalIndex];

        Instantiate(animal, spawnPosition, animal.transform.rotation);
    }
}
