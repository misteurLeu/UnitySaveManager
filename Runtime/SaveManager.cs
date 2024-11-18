using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{

    private static SaveManager _instance;

    public static SaveManager Instance { get => _instance; }

    // Saved in player preferences and loaded in awake if avaible.
    public Dictionary<string, string> Preferences { get; private set; }
    // Data linked to a save loaded when a save is selected, should mostly contains save statistics.
    public Dictionary<string, string> SaveData { get; private set; }
    // List of savable elements in the current run, will be saved in a separate file, multiple run files can coexists
    public List<SaveElement> RunElements { get; private set; }
    public string SaveLocation = Application.persistentDataPath;

    public bool loading = false;
    public bool saving = false;

    private void Awake()
    {
        if (_instance != null && _instance != this)
            DestroyImmediate(_instance);
        _instance = this;
        Preferences = new Dictionary<string, string>();
        SaveData = new Dictionary<string, string>();
        RunElements = new List<SaveElement>();
    }

    public void LoadPreferences()
    {
        loading = true;
        loading = false;
    }

    public void SavePreferences()
    {
        saving = true;
        saving = false;
    }

    public void LoadSaveData(string filePath)
    {
        loading = true;
        loading = false;
    }

    public void SaveSaveData()
    {
        saving = true;
        saving = false;
    }

    public void LoadRunData(string filePath)
    {
        loading = true;
        loading = false;

    }

    public void SaveRunData(string saveName)
    {
        saving = true;
        saving = false;
    }

    public void scanSaveDirectory()
    {

    }
}