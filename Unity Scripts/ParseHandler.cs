//Script that select the json file and loads the data
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System.Text;
using System.Dynamic;
using SmartDLL;
using Newtonsoft.Json.Linq;
using System.Linq;

// Serializing Data variable vlaues of Json File
[System.Serializable]
public class Data
{
    public string Label;
    public string Word;
}
//Serializing all the variables of Json File
[System.Serializable]
public class MyObject
{
    public Data Data;
    public int Start;
    public int End;
    public string ThreatClassification;
}

//Function to store key and percentage of match
public class MatchData
{

    public int key;
    public float percentage;

    public MatchData(int k, float p)
    {
        this.key = k;
        this.percentage = p;
    }

    public void Log()
    {

        Debug.Log("Key :" + this.key + ", Percentage:" + this.percentage);
    }
}

//Function to compare the percentage
class MatchDataComparar : IComparer
{
    public int Compare(object x, object y)
    {
        return (new CaseInsensitiveComparer()).Compare(((MatchData)x).percentage, ((MatchData)y).percentage);
    }
}

//Class to select Json file and parse the data
public class ParseHandler : MonoBehaviour
{
    //list to store json file data
    private List<MyObject> jsonData;
    //list to  store our internal predefined threat type data 
    public List<string> threatLib;
    // List to store matched threat data
    public List<string> threat_select;
    //list to store threat data without duplicates
    public static List<string> threat_select_new;
    //Stores matched data
    private MatchData[] mdata;
   private static string pathn;
    static string name;
    public GameObject panel;
    // gameobject which is active on dropdown list until we select the "LoadFile" button
    public GameObject Block_button;
    public Text textpopup;
    //Gameobject which tells to cleck on "LoadFile" button
    public Text textpanel;
    public string f_path;
    public string Jdata;
    private SceneSelector sceneSelector;
    private SceneInfo sceneinfo_Instance;
    private CameraOPS cameraOPS;

    // Function to explore local files to select a json file
    public SmartFileExplorer fileExplorer = new SmartFileExplorer();

    public void Explorer()
    {
        

        string initialDir = @"C:\";
        bool restoreDir = true;
        string title = "Open a Json File";
        string defExt = "json";
        string filter = "json files (*.json)|*.json";
        fileExplorer.OpenExplorer(initialDir, restoreDir, title, defExt, filter);
        f_path = fileExplorer.fileName;
        Jdata = File.ReadAllText(f_path);
        cameraOPS = GameObject.FindObjectOfType(typeof(CameraOPS)) as CameraOPS;
        
        //call the tween function in cameraOPS script to popupdebug panel
        
        cameraOPS.Tween();
        

        show();
        sceneinfo_Instance = GameObject.FindObjectOfType(typeof(SceneInfo)) as SceneInfo;
        sceneinfo_Instance.callInfo_startingScene();

    }

    // Function to Parse the Selected Json File data and select the threat details based on local threat library
    public void show()
    {
        jsonData = new List<MyObject>();
        threatLib = new List<string>();
        threat_select = new List<string>();
        threat_select_new = new List<string>();
        
        string jsonString = Jdata;
        //If there is Json file with data deactive the Blockbutton gameobject
        if(jsonString.Length!=null)
        {
            Block_button.SetActive(false);
        }
        //stores the json file data
        JArray a = JArray.Parse(jsonString);



        //Adding the data in josnData list
        for (int i = 0; i < a.Count; i++)
        {
            JArray a1 = JArray.Parse(a[i].ToString());
            jsonData.Add(JsonUtility.FromJson<MyObject>(a1[0].ToString()));

        }
        // Local List with all the predefined threats
        threatLib.Add("SBF");
        threatLib.Add("DOS");
        threatLib.Add("SPF");
        threatLib.Add("NC");
        threatLib.Add("TMP");
        threatLib.Add("HJK");
        threatLib.Add("PHG");
        threatLib.Add("CYB");
        threatLib.Add("PC");
        threatLib.Add("RA");
        threatLib.Add("IFD");




        mdata = new MatchData[jsonData.Count];


        //Finding the percentag and selecting threats with percentage greater than 50 percentage
        for (int i = 0; i < jsonData.Count; i++)
        {
            for (int j = 0; j < threatLib.Count; j++)
            {
                double percentage = LevenshteinAL.CalculateSimilarity(jsonData[i].ThreatClassification, threatLib[j]) * 100;
                if (percentage > 50)
                {
                    threat_select.Add(threatLib[j]);
                }
            }



            

        }
        // Filtering and removing duplicates
        threat_select_new = threat_select.Distinct().ToList();

        // calling the DropDownList function from SceneSelector script for loading dropdown values
        sceneSelector = GameObject.FindObjectOfType(typeof(SceneSelector)) as SceneSelector;
        sceneSelector.DropDownList();
        
    }

    // returns the selected threat types
    public List<string> GetList()
    {
        return threat_select_new;

    }

    




}

