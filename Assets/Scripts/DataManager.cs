using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
//using Newtonsoft.Json;
using static UnityEditor.Progress;

[System.Serializable]
public class DataManager : MonoBehaviour
{



    //public readonly string MONSTER = "MonsterData";

    //public List<Monster> monsters { get; private set; }



    //public void MonsterDataSetting()
    //{
    //    monsters = LoadData<List<Monster>>(MONSTER);
    //}

    //public static string GetProjectPath()
    //{
    //    string fullPath = Directory.GetCurrentDirectory();
    //    string[] pathSegments = fullPath.Split(new[] { "bin" }, StringSplitOptions.None);
    //    return pathSegments[0];
    //}


    //public T LoadData<T>(string fileName)
    //{
    //    string fullPath = GetProjectPath() + fileName + ".json";

    //    if (!File.Exists(fullPath))
    //        throw new InvalidOperationException("파일이 존재하지 않음");

    //    string jsonData = File.ReadAllText(fullPath);
    //    T loadData = JsonConvert.DeserializeObject<T>(jsonData);
    //    return loadData;
    //}





}
