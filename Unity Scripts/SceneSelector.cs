// This Script loads the dropdown values for starting scene and contains the code to change between scenes

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Globalization;

public class SceneSelector : MonoBehaviour
{
    // Defining dropdown gameobject
    Dropdown m_Dropdown;
    //creaing a defination for parsehandler script
    private ParseHandler parsehand;
    //creaing a defination for Scene_Dropdown script
    private Scene_Dropdown scene_Dropdown;
    // list for storing dropdown values
    public static List<string> drop_opt = new List<string>();
    int Scene_num;
    //Stores dropdown text
    string drop_text;
    
    public void DropDownList ()
    {
        
        m_Dropdown = GetComponent<Dropdown>();
        //Clear the old options of the Dropdown menu
        m_Dropdown.ClearOptions();
        
        //m_Dropdown.options.Add(new Dropdown.OptionData("--Click to Load Dropdown--"));
        parsehand = GameObject.FindObjectOfType(typeof(ParseHandler)) as ParseHandler;
        scene_Dropdown = GameObject.FindObjectOfType(typeof(Scene_Dropdown)) as Scene_Dropdown;
        // calling getlist function from parsehandler script and accessing each value and checking with our internal threat data type and storing the values to show in dropdown options
        foreach (string threat in parsehand.GetList())
        {
            
            if (threat == "TMP")
            {
                m_Dropdown.options.Add(new Dropdown.OptionData("Vehicle on highway changing the lane"));
                drop_opt.Add("Vehicle on highway changing the lane");


            }
            if (threat == "DOS")
            {
                m_Dropdown.options.Add(new Dropdown.OptionData("Vehicle on highway met with an accident"));
                drop_opt.Add("Vehicle on highway met with an accident");
            }
            if (threat == "HJK")
            {
                m_Dropdown.options.Add(new Dropdown.OptionData("Pedestrians behind the vehicle While unparking"));
                drop_opt.Add("Pedestrians behind the vehicle While unparking");
            }
            if (threat == "CYB")
            {
                m_Dropdown.options.Add(new Dropdown.OptionData("Animal crossing the road"));
                drop_opt.Add("Animal crossing the road");
            }
            if (threat == "SBF")
            {
                m_Dropdown.options.Add(new Dropdown.OptionData("Vehicle detects the traffic jams"));
                drop_opt.Add("Animal crossing the road");

            }
            if (threat == "SPF")
            {
                m_Dropdown.options.Add(new Dropdown.OptionData("Vehicle is approaching intersection"));
                drop_opt.Add("Vehicle is approaching intersection");
            }
            if (threat == "PHG")
            {
                m_Dropdown.options.Add(new Dropdown.OptionData("Vehicle driving near curved way"));
                 drop_opt.Add("Vehicle driving near curved way");
            }
            if (threat == "IFD")
            {
                m_Dropdown.options.Add(new Dropdown.OptionData("Two Vehicles detect the same parking place"));
                drop_opt.Add("Two Vehicles detect the same parking place");
            }




        }
        //calling on value change function
        m_Dropdown.onValueChanged.AddListener(delegate { callingthescenes(m_Dropdown); });
        

    }
    private void callingthescenes(Dropdown mydropdown)
    {
        select_scene(mydropdown.options[mydropdown.value].text);
        //loading each selected option text in drop_text string so we can use this in different scipts as required
        drop_text = mydropdown.options[mydropdown.value].text;

    }

    //function to load/change between scenes
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

        scene_Dropdown.set_num(Scene_num);
    }

    //Function to pass dropdown values
    public List<string> GetDropdown_List()
    {
        return drop_opt;

    }

}
