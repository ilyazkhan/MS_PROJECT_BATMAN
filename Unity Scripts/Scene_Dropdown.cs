// This script loads the dropdown Values for all the scenes except the starting scene and contains the code to change between scenes
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Scene_Dropdown : MonoBehaviour
{
    Dropdown s_Dropdown;//assign a dropdown gameobject to this variable on unity application
    public static int Scene_num;//saves scene number
    private SceneSelector sceneSelector;//creates a defination of SceneSelector script
    public List<string> dropdown_list = new List<string>();
    public static string dropdown_Text;



    void Start()
    {
        sceneSelector = GameObject.FindObjectOfType(typeof(SceneSelector)) as SceneSelector;//creatung a child instance/object of sceneselector
        dropdown_list=sceneSelector.GetDropdown_List();//retrive the threattype list in to local list
        s_Dropdown = GetComponent<Dropdown>();//finds the assigned gameobject at unity applcation
        s_Dropdown.ClearOptions();//clear the dropdown at the begining before adding the values
        s_Dropdown.options.Add(new Dropdown.OptionData("--Click to Load Dropdown--"));// adding this first option so it will appear as dropdown menu
        
        //Access each value of local dropdown_list and loads into dropdown gameobject 
        foreach (string option in dropdown_list)
        {
            s_Dropdown.options.Add(new Dropdown.OptionData(option));
          
        }
        s_Dropdown.onValueChanged.AddListener(delegate { callingthescenes(s_Dropdown); });//onclick value change function

    }

    //on value change function calls this method 
    private void callingthescenes(Dropdown mydropdown)
    {
        //calling select_scene  method/function with clicked dropdown value so based on clicked value we can load the other scenes
        select_scene(mydropdown.options[mydropdown.value].text);
        int menuIndex = mydropdown.GetComponent<Dropdown>().value;//get the value of selected option in dropdown
        List<Dropdown.OptionData> menuOptions = mydropdown.GetComponent<Dropdown>().options;//load the dropdown options into new list
        //Gets the selected option text
        dropdown_Text = menuOptions[menuIndex].text;
        
    }
    
    //Returns selected dropdown value
    public string DropdownText_value()
    {
        return dropdown_Text;
    }
    //Returns current scene number
    public int Scene_number()
    {
        return Scene_num;
    }
    //sets Dropdown value in dropdown_text
    public void set_text(string dropdown_txt)
    {
        dropdown_Text = dropdown_txt;
        
    }
    //sets Scene number
    public void set_num(int scene_num)
    {
        Scene_num = scene_num;
    }
    
    // Change between scenes
    private void select_scene(string scenetext)
    {


        if (scenetext == "--Starting Page--")
        {

            SceneManager.LoadScene(0);

            Scene_num = 0;

        }
        if (scenetext == "Vehicle on highway changing the lane" || scenetext == "Vehicle on highway met with an accident")
        {

            SceneManager.LoadScene(2);

            Scene_num = 2;

        }
        if (scenetext == "Vehicle is approaching intersection" || scenetext == "Vehicle detects the traffic jams")
        {

            SceneManager.LoadScene(1);

            Scene_num = 1;



        }
        if (scenetext == "Animal crossing the road" || scenetext == "Vehicle driving near curved way")
        {

            SceneManager.LoadScene(3);

            Scene_num = 3;

        }
        if (scenetext == "Two Vehicles detect the same parking place" || scenetext == "Pedestrians behind the vehicle While unparking")
        {

            SceneManager.LoadScene(4);

            Scene_num = 4;

        }


    }


}
