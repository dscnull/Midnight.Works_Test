﻿using UnityEditor.SceneManagement;
using UnityEditor;

[InitializeOnLoad]
public class BootstrapSceneLoader
{
    static BootstrapSceneLoader()
    {
        var pathOfFirstScene = EditorBuildSettings.scenes[0].path;
        var sceneAsset = AssetDatabase.LoadAssetAtPath<SceneAsset>(pathOfFirstScene);
        EditorSceneManager.playModeStartScene = sceneAsset;
    }
}