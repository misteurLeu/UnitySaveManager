using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveElement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SaveManager.Instance.RunElements.Add(this);
    }

    public string GetSaveData(bool recursive=true)
    {
        return "";
    }

    public static void LoadSavedData()
    {

    }

    private void OnDestroy()
    {
        if (!SaveManager.Instance.loading)
            SaveManager.Instance.RunElements.Remove(this);
    }
}
