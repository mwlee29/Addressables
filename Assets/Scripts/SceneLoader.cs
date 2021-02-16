using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class SceneLoader : MonoBehaviour
{
    private List<GameObject> objectsToLoad;
    [SerializeField]
    private SceneDataSO data;

    public void ChangeScene()
    {
        var nextSceneData = data.ChangeSceneData();
        StartCoroutine(PreloadScene(nextSceneData.label));
        data.UpdateAssets(objectsToLoad);
        SceneManager.LoadSceneAsync(nextSceneData.index);
    }

    IEnumerator PreloadScene(string label)
    {
        List<GameObject> objs = new List<GameObject>();

        AsyncOperationHandle<IList<GameObject>> handle =
            Addressables.LoadAssetsAsync<GameObject>(label, obj =>
            {
                Debug.Log("obj added: " + obj);
                objs.Add(obj);
            });

        objectsToLoad = objs;
        yield return handle;
        
    }
}
