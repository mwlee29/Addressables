using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class SpawnObjectsByReference : MonoBehaviour
{
    //By using AssetReferences, we don't have to know the address of our assets :)
    [SerializeField] private List<AssetReference> objectReferences = new List<AssetReference>();

    public void SpawnObject()
    {
        //Random index and Random Spawn point for object to instantiate
        int randIndex = Random.Range(0, objectReferences.Count - 1);
        Vector2 randSpawnPoint = new Vector2(Random.Range(-8.0f, 8.0f), Random.Range(-5.0f, 5.0f));

        Addressables.InstantiateAsync(objectReferences[randIndex], randSpawnPoint, Quaternion.identity);
    }
}
