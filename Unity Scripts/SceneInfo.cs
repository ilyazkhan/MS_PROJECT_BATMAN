// Scripts to preint the scene details on the debug panel, using leantween asset for zooming in and zooming out the debug panel


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneInfo : MonoBehaviour
{


    [SerializeField]
    float time;//leantween time
    [SerializeField]
    public LeanTweenType type;//leantween type
    public Text textpanel;// textpanel to store the information based on scene loaded
    public CameraOPS cameraOPS;//creaing a defination for CamerOPS script
    public static bool debug_flag = true;//this flag helps to activate debug panel when it is closed and vice versa
    private Scene_Dropdown scene_Dropdown;//creating a definaition of Scene_Dropdown script
    private string Dropdown_value;
    private ParseHandler parsehand_Instance;//creating a defination of ParseHandler


    //this method/function is called when we load the file and this method helps to print the text on debug panel once the file is loaded, to show whether file has the threattypes we required or not

    public void callInfo_startingScene()
    {

        parsehand_Instance = GameObject.FindObjectOfType(typeof(ParseHandler)) as ParseHandler;//creating a gameobject of ParseHandler script
        List<string> Threattpe_list= parsehand_Instance.GetList();//storing the list of threatypes so we can find its count and based on count we print the text on debug textpanel
       
      
        //if count is less than one it means the file loaded do not have the predefined threttypes so print to ask correct jason file with the threattypes that works
        if (Threattpe_list.Count >= 1)
        {
            textpanel.text = "File loaded succesfilly"+ "\r\n"+"Click on dropdown to select scene";
        }
        else
        {
            textpanel.text = "Please load proper JSON file with threats";
        }
            
      
        }

    //whenever a scene is loaded and load usecase and load attack buttons are pressed this method is called to print the text on debugtext panel related to respective scenes 
    public void callInfo()
    {

  
        scene_Dropdown = GameObject.FindObjectOfType(typeof(Scene_Dropdown)) as Scene_Dropdown;
        Dropdown_value = scene_Dropdown.DropdownText_value();
        
       
        

            //Based on selected scene value using dropdown value that sceen description will be loaded
            if (Dropdown_value == "Vehicle is approaching intersection")
            {
                
                textpanel.text = "Scene Loaded..." + "\r\n" + "\r\n" + "Summary..." + "\r\n" + "\r\n" + "Scene Number: 1" + "\r\n" + "Model : Usecasemodel_01" + "\r\n" + "Name : Vehicle is approaching intersection" + "\r\n" + "Location : Near intersection" + "\r\n" + "Environment : Normal Weather Conditions" + "\r\n" + "Specific Location : Intersection" + "\r\n" + "Specific Environment : Sunny" + "\r\n" + "Position : In front of intersection" + "\r\n" + "Actors : 10" + "\r\n" + "Target : Sensors" + "\r\n" + "Type of Attcak : Spoofing" + "\r\n" + "Threat : Sensors couldn't detect traffic signal" + "\r\n"  + "Consequence : Vehicle jumps the signal and hits the opposite lane vehicles" +  "\r\n" + "Date : 26-02-2021" + "\r\n" + "Designed By: AI Group" + "\r\n";
            }
            if (Dropdown_value == "Vehicle on highway changing the lane")
            {

                textpanel.text = "Scene Loaded..." + "\r\n" + "\r\n" + "Summary..." + "\r\n" + "\r\n" + "Scene Number: 2" + "\r\n" + "Model : Usecasemodel_02" + "\r\n" + "Name : Vehicle on highway changing the lane" + "\r\n" + "Location : On HighWay" + "\r\n" + "Environment : Normal Weather Conditions" + "\r\n" + "Specific Location : 2 lane Highway" + "\r\n" + "Specific Environment : Sunny" + "\r\n" + "Position : Beside lane of platoon of vehicles" + "\r\n" + "Actors : 10" + "\r\n" + "Target : Sensors" + "\r\n" + "Type of Attcak : Tampering" + "\r\n" + "Threat : Sensors couldn't detect the vehicles on beside lane " + "\r\n" + "Consequence : Vehicle changes the lane and hits the other vehicles of beside lane" + "\r\n" + "Date : 26-02-2021" + "\r\n" + "Designed By: AI Group" + "\r\n";
            }
            if (Dropdown_value == "Vehicle on highway met with an accident")
            {

                textpanel.text = "Scene Loaded..." + "\r\n" + "\r\n" + "Summary..." + "\r\n" + "\r\n" + "Scene Number: 3" + "\r\n" + "Model : Usecasemodel_03" + "\r\n" + "Name : Vehicle on highway Detects an accident" + "\r\n" + "Location : On highway" + "\r\n" + "Environment : Normal Weather Conditions" + "\r\n" + "Specific Location : Highway" + "\r\n" + "Specific Environment : Sunny" + "\r\n" + "Position : In front of accident location" + "\r\n" + "Actors : 10" + "\r\n" + "Target : Sensors" + "\r\n" + "Type of Attcak : Denial of service" + "\r\n" + "Threat : Vehicle sensors couldn't detect the accident " + "\r\n" + "Consequence : Vehicle could not find the accident and hits the accident vehicle" + "\r\n" + "Date : 26-02-2021" + "\r\n" + "Designed By: AI Group" + "\r\n";
            }
            if (Dropdown_value == "Pedestrians behind the vehicle While unparking")
            {

                textpanel.text = "Scene Loaded..." + "\r\n" + "\r\n" + "Summary..." + "\r\n" + "\r\n" + "Scene Number: 4" + "\r\n" + "Model : Usecasemodel_03" + "\r\n" + "Name : Pedestrians behind the vehicle While unparking" + "\r\n" + "Location : Parking zone" + "\r\n" + "Environment : Normal Weather Conditions" + "\r\n" + "Specific Location : Parking zone" + "\r\n" + "Specific Environment : Sunny" + "\r\n" + "Position : unparking" + "\r\n" + "Actors : 10" + "\r\n" + "Target : Sensors" + "\r\n" + "Type of Attcak : Hijacking" + "\r\n" + "Threat : Vehicle sensors couldn't detect the pedestrian behind the vehicle" + "\r\n" + "Consequence : Vehicle hits the pedestrian" + "\r\n" + "Date : 26-02-2021" + "\r\n" + "Designed By: AI Group" + "\r\n";
            }
            if (Dropdown_value == "Animal crossing the road")
            {

                textpanel.text = "Scene Loaded..." + "\r\n" + "\r\n" + "Summary..." + "\r\n" + "\r\n" + "Scene Number: 5" + "\r\n" + "Model : Usecasemodel_05" + "\r\n" + "Name : Animal crossing the road" + "\r\n" + "Location : Near Country side" + "\r\n" + "Environment : Normal Weather Conditions" + "\r\n" + "Specific Location : On country side road" + "\r\n" + "Specific Environment : Sunny" + "\r\n" + "Position : In front of animal" + "\r\n" + "Actors : 10" + "\r\n" + "Target : Sensors" + "\r\n" + "Type of Attcak : Cyber Attack" + "\r\n" + "Threat : Vehicle sensors couldn't detect the animal crossing the road" + "\r\n" + "Consequence : Vehicle hits the animal" + "\r\n" + "Date : 26-02-2021" + "\r\n" + "Designed By: AI Group" + "\r\n";
            }
            if (Dropdown_value == "Vehicle detects the traffic jams")
            {

                textpanel.text = "Scene Loaded..." + "\r\n" + "\r\n" + "Summary..." + "\r\n" + "\r\n" + "Scene Number: 6" + "\r\n" + "Model : Usecasemodel_06" + "\r\n" + "Name : Vehicle detects the traffic jams" + "\r\n" + "Location : Near intersection" + "\r\n" + "Environment : Normal Weather Conditions" + "\r\n" + "Specific Location : At traffic jam" + "\r\n" + "Specific Environment : Sunny" + "\r\n" + "Position : In front of traffic jam area" + "\r\n" + "Actors : 10" + "\r\n" + "Target : Sensors" + "\r\n" + "Type of Attcak : Brute Force" + "\r\n" + "Threat : Vehicle sensors couldn't detect traffic Jams" + "\r\n" + "Consequence : Vehicle hits the other vehicles" + "\r\n" + "Date : 26-02-2021" + "\r\n" + "Designed By: AI Group" + "\r\n";
            }
            if (Dropdown_value == "Vehicle driving near curved way")
            {

                textpanel.text = "Scene Loaded..." + "\r\n" + "\r\n" + "Summary..." + "\r\n" + "\r\n" + "Scene Number: 7" + "\r\n" + "Model : Usecasemodel_07" + "\r\n" + "Name : Vehicle driving near curved way" + "\r\n" + "Location : Country side" + "\r\n" + "Environment : Normal Weather Conditions" + "\r\n" + "Specific Location : Curved path" + "\r\n" + "Specific Environment : Sunny" + "\r\n" + "Position : Near curved way" + "\r\n" + "Actors : 10" + "\r\n" + "Target : Sensors" + "\r\n" + "Type of Attcak : phishing" + "\r\n" + "Threat : Vehicle sensors couldn't detect the curved way" + "\r\n" + "Consequence : Vehicle could not turn at the curve and went off road" + "\r\n" + "Date : 26-02-2021" + "\r\n" + "Designed By: AI Group" + "\r\n";
            }
            if (Dropdown_value == "Two Vehicles detect the same parking place")
            {

                textpanel.text = "Scene Loaded..." + "\r\n" + "\r\n" + "Summary..." + "\r\n" + "\r\n" + "Scene Number: 8" + "\r\n" + "Model : Usecasemodel_08" + "\r\n" + "Name : Two Vehicles detect the same parking place" + "\r\n" + "Location : Parking Zone" + "\r\n" + "Environment : Normal Weather " + "\r\n" + "Specific Location : Near parking area" + "\r\n" + "Specific Environment : Sunny" + "\r\n" + "Position : Ready to park" + "\r\n" + "Actors : 10" + "\r\n" + "Target : Sensors" + "\r\n" + "Type of Attcak : Information disclosure" + "\r\n" + "Threat : Vehicle sensors could not detect the other vehicles movement and communication" + "\r\n" + "Consequence : Both Vehicles find the same parking zone as empty and try to park and hit each other" + "\r\n" + "Date : 26-02-2021" + "\r\n" + "Designed By: AI Group" + "\r\n";
            }


       
    }



    // Activate the debug panel by enlarging its size
    public void Show_info()
    {
        if (debug_flag == true)
        {
            LeanTween.cancel(gameObject);
            LeanTween.scale(gameObject, new Vector3(1, 1, 1), 1f).setEase(type);
            debug_flag = false;
        }

        //if debug button is already press, so Deactivate the debug panel by minimizing its size on second time pressing the debug button
        else
        {
            InfoExit();
            debug_flag = true;

        }
    }
    //Deactivate the debug panel by minimizing its size
    public void InfoExit()
    {
        LeanTween.cancel(gameObject);

        LeanTween.scale(gameObject, new Vector3(0, 0, 0), 1f).setEase(type);
        debug_flag = true;
    }

}
