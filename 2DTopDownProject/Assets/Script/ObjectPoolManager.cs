using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public enum PoolObjectType
{ 

    Ect,
    PlayerNameTag

}


public class ObjectPoolManager : MonoBehaviour
{


    [System.Serializable]
    public class ObjectInfo
    {
 
        public string objectName;
        public GameObject prefab;
        public int count;


    }

    public List<ObjectInfo> pools;
    public Dictionary<string, Queue<GameObject>> PoolDictionary;


    private void Awake()
    {
        PoolDictionary = new Dictionary<string, Queue<GameObject>>();
        foreach (var pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();

            for (int i = 0; i < pool.count; i++)
            {
         
                GameObject obj = Instantiate(pool.prefab, this.transform);
                obj.SetActive(false);
            
                objectPool.Enqueue(obj);
            }

            PoolDictionary.Add(pool.objectName, objectPool);
        }

    }

    public GameObject SpawnFromPool(string objectName, RectTransform parent)
    {

        if (!PoolDictionary.ContainsKey(objectName))
            return null;

        GameObject obj = PoolDictionary[objectName].Dequeue();
        PoolDictionary[objectName].Enqueue(obj);
        obj.SetActive(true);


        if (objectName == PoolObjectType.PlayerNameTag.ToString())
        {

            RectTransform rectTransform = obj.GetComponent<RectTransform>();
            
            if (rectTransform != null)
            {
                rectTransform.SetParent(parent,false);
       

            }


        }


        return obj;
    
    }


}
