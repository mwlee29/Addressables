using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AddressableAssets;

[CreateAssetMenu(menuName = "SceneData")]
public class SceneDataSO : ScriptableObject
{
    private const int SceneCount = 3;
    private int currentSceneIndex = 0;

    // Scene Labels are mapped to scene build order,
    // in a production environment this is probably not a best practice.
    [SerializeField]
    private string[] labels = new string[SceneCount];

    public List<GameObject> currentAssets;

    public (string label, int index) ChangeSceneData()
    {
        currentSceneIndex += 1;
        if (currentSceneIndex >= SceneCount)
        {
            currentSceneIndex = 0;
        }

        return (labels[currentSceneIndex], currentSceneIndex);
    }

    public void UpdateAssets(List<GameObject> objs)
    {
        currentAssets = objs;
    }
}
