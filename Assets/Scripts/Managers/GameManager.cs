using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private static PoolManager poolManager;
    private static ResourceManager resource;
    private static UIManager ui;
    public static GameManager Instance { get { return instance; } }
    public static PoolManager Pool { get { return poolManager; } }
    public static ResourceManager Resource { get { return resource; } }
    public static UIManager UI { get { return ui; } }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this);
        InitManagers();
    }

    private void OnDestroy()
    {
        if (instance == this)
            instance = null;
    }

    private void InitManagers()
    {
        GameObject resourceObj = new GameObject();
        resourceObj.name = "ResourceManager";
        resourceObj.transform.parent = transform;
        resource = resourceObj.AddComponent<ResourceManager>();

        GameObject poolObj = new GameObject();
        poolObj.name = "PoolManager";
        poolObj.transform.parent = transform;
        poolManager = poolObj.AddComponent<PoolManager>();

        GameObject UIObj = new GameObject();
        UIObj.name = "UIManager";
        UIObj.transform.parent = transform;
        ui = UIObj.AddComponent<UIManager>();
    }
}
