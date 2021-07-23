using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class AutoBuild : MonoBehaviour
{
    bool InBatchModel
    {
        get { return UnityEditorInternal.InternalEditorUtility.inBatchMode; }
    }

    static void Build()
    {
        string outputPathName = string.Empty;
        string[] commonLines = Environment.GetCommandLineArgs();
        foreach (var line in commonLines)
        {
            if (line.Equals("BUILD_OUTPUT_PATH"))
            {
                outputPathName = line;
            }
        }
        if (outputPathName == string.Empty)
        {
            throw new Exception("OutPutPath is Null");
        }
        if (outputPathName == string.Empty)
        {
            EditorApplication.Exit(1);
        }
        string[] scenes = { "Assets/MyScenes.unity" };
        BuildPlayerOptions build = new BuildPlayerOptions();
        build.scenes = scenes;
        build.target = BuildTarget.Android;
        build.locationPathName = outputPathName;
        build.options = BuildOptions.Development;
        BuildPipeline.BuildPlayer(build);
    }
}
