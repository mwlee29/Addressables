using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class SpawnObjectsPreload : MonoBehaviour
{
    public SceneDataSO data;
    public List<GameObject> objects;

    public void SpawnObject()
    {
        //Random index and Random Spawn point for object to instantiate
        int randIndex = Random.Range(0, data.currentAssets.Count - 1);
        Vector2 randSpawnPoint = new Vector2(Random.Range(-8.0f, 8.0f), Random.Range(-5.0f, 5.0f));

        Instantiate(data.currentAssets[randIndex], randSpawnPoint, Quaternion.identity);
    }
}
