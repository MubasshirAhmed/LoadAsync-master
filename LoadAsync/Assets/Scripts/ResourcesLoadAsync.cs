using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesLoadAsync : MonoBehaviour
{
    private GameObject loadingGameObject;
    // Use this for initialization
    void Start()
    {
        //Invoke("StartLoading", 1);
        StartLoading();
    }

    private void StartLoading()
    {
        StartCoroutine(LoadCarFromResourcesFolder1());
    }

    IEnumerator LoadCarFromResourcesFolder1()
    {
        ResourceRequest loadAsync = Resources.LoadAsync("Line8", typeof(GameObject));
        while (!loadAsync.isDone)
        {
            yield return null;
        }
        loadingGameObject = loadAsync.asset as GameObject;
        Instantiate(loadingGameObject);
        StartCoroutine(LoadCarFromResourcesFolder2());
    }
    IEnumerator LoadCarFromResourcesFolder2()
    {
        ResourceRequest loadAsync = Resources.LoadAsync("Line7", typeof(GameObject));
        while (!loadAsync.isDone)
        {
            yield return null;
        }
        loadingGameObject = loadAsync.asset as GameObject;
        Instantiate(loadingGameObject);
        StartCoroutine(LoadCarFromResourcesFolder3());
    }

    IEnumerator LoadCarFromResourcesFolder3()
    {
        ResourceRequest loadAsync = Resources.LoadAsync("Line6", typeof(GameObject));
        while (!loadAsync.isDone)
        {
            yield return null;
        }
        loadingGameObject = loadAsync.asset as GameObject;
        Instantiate(loadingGameObject);
        StartCoroutine(LoadCarFromResourcesFolder4());
    }

    IEnumerator LoadCarFromResourcesFolder4()
    {
        ResourceRequest loadAsync = Resources.LoadAsync("Line5", typeof(GameObject));
        while (!loadAsync.isDone)
        {
            yield return null;
        }
        loadingGameObject = loadAsync.asset as GameObject;
        Instantiate(loadingGameObject);
        StartCoroutine(LoadCarFromResourcesFolder5());
    }

    IEnumerator LoadCarFromResourcesFolder5()
    {
        ResourceRequest loadAsync = Resources.LoadAsync("Line4", typeof(GameObject));
        while (!loadAsync.isDone)
        {
            yield return null;
        }
        loadingGameObject = loadAsync.asset as GameObject;
        Instantiate(loadingGameObject);
        StartCoroutine(LoadCarFromResourcesFolder6());
    }

    IEnumerator LoadCarFromResourcesFolder6()
    {
        ResourceRequest loadAsync = Resources.LoadAsync("Line3", typeof(GameObject));
        while (!loadAsync.isDone)
        {
            yield return null;
        }
        loadingGameObject = loadAsync.asset as GameObject;
        Instantiate(loadingGameObject);
        StartCoroutine(LoadCarFromResourcesFolder7());
    }
    IEnumerator LoadCarFromResourcesFolder7()
    {
        ResourceRequest loadAsync = Resources.LoadAsync("Line2", typeof(GameObject));
        while (!loadAsync.isDone)
        {
            yield return null;
        }
        loadingGameObject = loadAsync.asset as GameObject;
        Instantiate(loadingGameObject);
        StartCoroutine(LoadCarFromResourcesFolder8());
    }
    IEnumerator LoadCarFromResourcesFolder8()
    {
        ResourceRequest loadAsync = Resources.LoadAsync("Line1", typeof(GameObject));
        while (!loadAsync.isDone)
        {
            yield return null;
        }
        loadingGameObject = loadAsync.asset as GameObject;
        Instantiate(loadingGameObject);
        StartCoroutine(LoadCarFromResourcesFolderAll1());
    }


    IEnumerator LoadCarFromResourcesFolderAll1()
    {
        ResourceRequest loadAsync = Resources.LoadAsync("All1", typeof(GameObject));
        while (!loadAsync.isDone)
        {
            yield return null;
        }
        loadingGameObject = loadAsync.asset as GameObject;
        Instantiate(loadingGameObject);
        StartCoroutine(LoadCarFromResourcesFolderAll2());
    }
    IEnumerator LoadCarFromResourcesFolderAll2()
    {
        ResourceRequest loadAsync = Resources.LoadAsync("All2", typeof(GameObject));
        while (!loadAsync.isDone)
        {
            yield return null;
        }
        loadingGameObject = loadAsync.asset as GameObject;
        Instantiate(loadingGameObject);
        StartCoroutine(LoadCarFromResourcesFolderAll3());
    }

    IEnumerator LoadCarFromResourcesFolderAll3()
    {
        ResourceRequest loadAsync = Resources.LoadAsync("All3", typeof(GameObject));
        while (!loadAsync.isDone)
        {
            yield return null;
        }
        loadingGameObject = loadAsync.asset as GameObject;
        Instantiate(loadingGameObject);
        StartCoroutine(LoadCarFromResourcesFolderAll4());
    }

    IEnumerator LoadCarFromResourcesFolderAll4()
    {
        ResourceRequest loadAsync = Resources.LoadAsync("All4", typeof(GameObject));
        while (!loadAsync.isDone)
        {
            yield return null;
        }
        loadingGameObject = loadAsync.asset as GameObject;
        Instantiate(loadingGameObject);
        StartCoroutine(LoadCarFromResourcesFolderAll5());
    }

    IEnumerator LoadCarFromResourcesFolderAll5()
    {
        ResourceRequest loadAsync = Resources.LoadAsync("All5", typeof(GameObject));
        while (!loadAsync.isDone)
        {
            yield return null;
        }
        loadingGameObject = loadAsync.asset as GameObject;
        Instantiate(loadingGameObject);
        StartCoroutine(LoadCarFromResourcesFolderAll6());
    }

    IEnumerator LoadCarFromResourcesFolderAll6()
    {
        ResourceRequest loadAsync = Resources.LoadAsync("All6", typeof(GameObject));
        while (!loadAsync.isDone)
        {
            yield return null;
        }
        loadingGameObject = loadAsync.asset as GameObject;
        Instantiate(loadingGameObject);
        StartCoroutine(LoadCarFromResourcesFolderAll7());
    }
    IEnumerator LoadCarFromResourcesFolderAll7()
    {
        ResourceRequest loadAsync = Resources.LoadAsync("All7", typeof(GameObject));
        while (!loadAsync.isDone)
        {
            yield return null;
        }
        loadingGameObject = loadAsync.asset as GameObject;
        Instantiate(loadingGameObject);
        StartCoroutine(LoadCarFromResourcesFolderAll8());
    }
    IEnumerator LoadCarFromResourcesFolderAll8()
    {
        ResourceRequest loadAsync = Resources.LoadAsync("All8", typeof(GameObject));
        while (!loadAsync.isDone)
        {
            yield return null;
        }
        loadingGameObject = loadAsync.asset as GameObject;
        Instantiate(loadingGameObject);
    }
}
