// Script to load prefabs and threat models

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class LoadModels : MonoBehaviour
{
    public GameObject Hacker_image;// for Loading hacker image on threat load
    public int Scene_num;//stores scen number
    public static bool intersection_flag = false;//for activating attack mode i.e when load attack button is pressed models of interest will move 
    public GameObject Bluecar;//Definition for Bluecar gameobject
    public GameObject whitecar;
    public GameObject yellowcar;
    public GameObject car1Prefab;
    public bool prefab_Flag = true;// To actiavte prefab mode
    private Scene_Dropdown scene_Dropdown;//defination for Scene_Dropdown script
    private SceneInfo sceneinfo2;
    private SceneInfo sceneinfo;
    private string Dropdown_value;
    

    //Loads all the prefab models at runtime . takes all the models from resource(path: Assets/Resources/Instantiable) folder and based on scene number and dropdown values loads the models
    public void prefab_load()
    {
        intersection_flag = false;
        scene_Dropdown = GameObject.FindObjectOfType(typeof(Scene_Dropdown)) as Scene_Dropdown;//
        Dropdown_value = scene_Dropdown.DropdownText_value();
        Scene_num = scene_Dropdown.Scene_number();
        sceneinfo2 = GameObject.FindObjectOfType(typeof(SceneInfo)) as SceneInfo;
        if (prefab_Flag)
        {
            // -----------------------------------Scene "Intersection/city"------------------------------------------------------ -
            
            if (Scene_num == 1)
            {
                if (Dropdown_value == "Vehicle is approaching intersection")
                {
                    var B_Car_Prefab = Resources.Load("Instantiable/Car blue") as GameObject;
                    var B_Car_Prefab_GO = GameObject.Instantiate(B_Car_Prefab, new Vector3(210, 342, -221),
                        Quaternion.Euler(0, -103, 0)) as GameObject;
                    Bluecar = B_Car_Prefab_GO;

                    var GiroGirl = Resources.Load("Instantiable/Gyroscooter_Girl") as GameObject;
                    var GiroGirl_GO = GameObject.Instantiate(GiroGirl, new Vector3(196, 342, -227),
                        Quaternion.Euler(0, -190, 0)) as GameObject;

                    var taxi_Prefab = Resources.Load("Instantiable/Taxi(yellow)") as GameObject;
                    var taxi_GO = GameObject.Instantiate(taxi_Prefab, new Vector3(215, 342, -223),
                        Quaternion.Euler(0, -104, 0)) as GameObject;

                    var W_Car_Prefab = Resources.Load("Instantiable/Car white") as GameObject;
                    var W_Car_Prefab_GO = GameObject.Instantiate(W_Car_Prefab, new Vector3(168, 342, -231),
                        Quaternion.Euler(0, -102, 0)) as GameObject;

                    var Y_Car_Prefab = Resources.Load("Instantiable/Car yellow") as GameObject;
                    var Y_Car_Prefab_GO = GameObject.Instantiate(Y_Car_Prefab, new Vector3(178, 342, -243),
                        Quaternion.Euler(0, 75, 0)) as GameObject;

                    var SportBike_Prefab = Resources.Load("Instantiable/SportBike") as GameObject;
                    var SportBike_Prefab_GO = GameObject.Instantiate(SportBike_Prefab, new Vector3(224, 342, -220),
                        Quaternion.Euler(0, -99, 0)) as GameObject;

                    var W1_Car_Prefab = Resources.Load("Instantiable/Car white") as GameObject;
                    var W1_Car_Prefab_GO = GameObject.Instantiate(W1_Car_Prefab, new Vector3(218, 342, -219),
                        Quaternion.Euler(0, -103, 0)) as GameObject;

                    var Y1_Car_Prefab = Resources.Load("Instantiable/Car yellow") as GameObject;
                    var Y1_Car_Prefab_GO = GameObject.Instantiate(Y1_Car_Prefab, new Vector3(226, 342, -228),
                        Quaternion.Euler(0, 79, 0)) as GameObject;

                    var Y2_Car_Prefab = Resources.Load("Instantiable/car yellow") as GameObject;
                    var Y2_Car_Prefab_GO = GameObject.Instantiate(Y2_Car_Prefab, new Vector3(189, 342, -225),
                        Quaternion.Euler(0, -18, 0)) as GameObject;

                    var W2_Car_Prefab = Resources.Load("Instantiable/Car white") as GameObject;
                    var W2_Car_Prefab_GO = GameObject.Instantiate(W2_Car_Prefab, new Vector3(174, 342, -240),
                        Quaternion.Euler(0, 83, 0)) as GameObject;

                    var Police_Prefab = Resources.Load("Instantiable/Police vehicle") as GameObject;
                    var Police_Prefab_GO = GameObject.Instantiate(Police_Prefab, new Vector3(213, 342, -231),
                        Quaternion.Euler(-2, 78, 0)) as GameObject;

                    var Bicycle_Prefab = Resources.Load("Instantiable/Bicycle_Man") as GameObject;
                    var Bicycle_Prefab_GO = GameObject.Instantiate(Bicycle_Prefab, new Vector3(195, 342, -223),
                        Quaternion.Euler(0, -190, 0)) as GameObject;

                    var City_bus_Prefab = Resources.Load("Instantiable/City_bus") as GameObject;
                    var mCity_bus_Prefab_GO = GameObject.Instantiate(City_bus_Prefab, new Vector3(192, 342, -238),
                        Quaternion.Euler(0, -16, 0)) as GameObject;

                    var Bicycle2_Prefab = Resources.Load("Instantiable/Bicycle_Man") as GameObject;
                    var Bicycle2_Prefab_GO = GameObject.Instantiate(Bicycle2_Prefab, new Vector3(195, 342, -218),
                        Quaternion.Euler(0, -193, 0)) as GameObject;

                    var Person_Prefab1 = Resources.Load("Instantiable/person") as GameObject;
                    var Person_Prefab1_GO = GameObject.Instantiate(Person_Prefab1, new Vector3(198, 342, -220),
                        Quaternion.Euler(0, -200, 0)) as GameObject;
                    var Person_Prefab2 = Resources.Load("Instantiable/person") as GameObject;
                    var Person_Prefab2_GO = GameObject.Instantiate(Person_Prefab2, new Vector3(195, 342, -224),
                        Quaternion.Euler(0, -193, 0)) as GameObject;

                }
                if (Dropdown_value == "Vehicle detects the traffic jams")
                {
                    var B_Car_Prefab = Resources.Load("Instantiable/Car blue") as GameObject;
                    var B_Car_Prefab_GO = GameObject.Instantiate(B_Car_Prefab, new Vector3(223, 342, -218),
                        Quaternion.Euler(0, -103, 0)) as GameObject;
                    Bluecar = B_Car_Prefab_GO;

                    var B_Car_Prefab1 = Resources.Load("Instantiable/Car blue") as GameObject;
                    var B_Car_Prefab1_GO = GameObject.Instantiate(B_Car_Prefab1, new Vector3(193, 342, -235),
                        Quaternion.Euler(0, -10, 0)) as GameObject;

                    var GiroGirl = Resources.Load("Instantiable/Gyroscooter_Girl") as GameObject;
                    var GiroGirl_GO = GameObject.Instantiate(GiroGirl, new Vector3(196, 342, -227),
                        Quaternion.Euler(0, -190, 0)) as GameObject;

                    var Y4_Car_Prefab = Resources.Load("Instantiable/Car yellow") as GameObject;
                    var Y4_Car_Prefab_GO = GameObject.Instantiate(Y4_Car_Prefab, new Vector3(206, 342, -222),
                        Quaternion.Euler(0, -120, 0)) as GameObject;

                    var Y5_Car_Prefab = Resources.Load("Instantiable/Car yellow") as GameObject;
                    var Y5_Car_Prefab_GO = GameObject.Instantiate(Y5_Car_Prefab, new Vector3(213, 342, -220),
                        Quaternion.Euler(0, -103, 0)) as GameObject;

                    var Y6_Car_Prefab = Resources.Load("Instantiable/Car yellow") as GameObject;
                    var Y6_Car_Prefab_GO = GameObject.Instantiate(Y6_Car_Prefab, new Vector3(216, 342, -239),
                        Quaternion.Euler(0, -187, 0)) as GameObject;


                    var W_Car_Prefab = Resources.Load("Instantiable/Car white") as GameObject;
                    var W_Car_Prefab_GO = GameObject.Instantiate(W_Car_Prefab, new Vector3(168, 342, -231),
                        Quaternion.Euler(0, -102, 0)) as GameObject;


                    var Y_Car_Prefab = Resources.Load("Instantiable/Car yellow") as GameObject;
                    var Y_Car_Prefab_GO = GameObject.Instantiate(Y_Car_Prefab, new Vector3(178, 342, -243),
                        Quaternion.Euler(0, 75, 0)) as GameObject;

                    var SportBike_Prefab = Resources.Load("Instantiable/SportBike") as GameObject;
                    var SportBike_Prefab_GO = GameObject.Instantiate(SportBike_Prefab, new Vector3(213, 342, -231),
                        Quaternion.Euler(0, 84, 0)) as GameObject;

                    var W1_Car_Prefab = Resources.Load("Instantiable/Car white") as GameObject;
                    var W1_Car_Prefab_GO = GameObject.Instantiate(W1_Car_Prefab, new Vector3(209, 342, -224),
                        Quaternion.Euler(0, -70, 0)) as GameObject;

                    var Y1_Car_Prefab = Resources.Load("Instantiable/Car yellow") as GameObject;
                    var Y1_Car_Prefab_GO = GameObject.Instantiate(Y1_Car_Prefab, new Vector3(226, 342, -228),
                        Quaternion.Euler(0, 79, 0)) as GameObject;

                    var Y2_Car_Prefab = Resources.Load("Instantiable/car yellow") as GameObject;
                    var Y2_Car_Prefab_GO = GameObject.Instantiate(Y2_Car_Prefab, new Vector3(189, 342, -225),
                        Quaternion.Euler(0, -10, 0)) as GameObject;

                    var W2_Car_Prefab = Resources.Load("Instantiable/Car white") as GameObject;
                    var W2_Car_Prefab_GO = GameObject.Instantiate(W2_Car_Prefab, new Vector3(174, 342, -240),
                        Quaternion.Euler(0, 83, 0)) as GameObject;

                    var W3_Car_Prefab = Resources.Load("Instantiable/Car white") as GameObject;
                    var W3_Car_Prefab_GO = GameObject.Instantiate(W3_Car_Prefab, new Vector3(220, 342, -239),
                        Quaternion.Euler(0, 170, 0)) as GameObject;

                    var Y3_Car_Prefab = Resources.Load("Instantiable/Car yellow") as GameObject;
                    var Y3_Car_Prefab_GO = GameObject.Instantiate(Y3_Car_Prefab, new Vector3(214, 342, -223),
                        Quaternion.Euler(0, -103, 0)) as GameObject;

                    var Bicycle_Prefab = Resources.Load("Instantiable/Bicycle_Man") as GameObject;
                    var Bicycle_Prefab_GO = GameObject.Instantiate(Bicycle_Prefab, new Vector3(195, 342, -223),
                        Quaternion.Euler(0, -190, 0)) as GameObject;

                    var Jeep_Prefab = Resources.Load("Instantiable/Jeep_2") as GameObject;
                    var Jeep_Prefab_GO = GameObject.Instantiate(Jeep_Prefab, new Vector3(195, 342, -247),
                        Quaternion.Euler(0, 0, 0)) as GameObject;

                    var Bicycle2_Prefab = Resources.Load("Instantiable/Bicycle_Man") as GameObject;
                    var Bicycle2_Prefab_GO = GameObject.Instantiate(Bicycle2_Prefab, new Vector3(195, 342, -218),
                        Quaternion.Euler(0, -193, 0)) as GameObject;

                    var Person_Prefab1 = Resources.Load("Instantiable/person") as GameObject;
                    var Person_Prefab1_GO = GameObject.Instantiate(Person_Prefab1, new Vector3(198, 342, -220),
                        Quaternion.Euler(0, -200, 0)) as GameObject;
                    var Person_Prefab2 = Resources.Load("Instantiable/person") as GameObject;
                    var Person_Prefab2_GO = GameObject.Instantiate(Person_Prefab2, new Vector3(195, 342, -224),
                        Quaternion.Euler(0, -193, 0)) as GameObject;
                }
            }
            // -----------------------------------Scene "HighWay"-------------------------------------------------------
            if (Scene_num == 2)
            {
                if (Dropdown_value == "Vehicle on highway changing the lane")
                {
                    var Y_Car_Prefab = Resources.Load("Instantiable/Car yellow") as GameObject;
                    var Y_Car_Prefab_GO = GameObject.Instantiate(Y_Car_Prefab, new Vector3(487, 292, 170),
                        Quaternion.Euler(0, -88, 0)) as GameObject;

                    var Y1_Car_Prefab = Resources.Load("Instantiable/Car yellow") as GameObject;
                    var Y1_Car_Prefab_GO = GameObject.Instantiate(Y1_Car_Prefab, new Vector3(449, 292, 176),
                         Quaternion.Euler(0, -80, 0)) as GameObject;

                    var Y2_Car_Prefab = Resources.Load("Instantiable/car yellow") as GameObject;
                    var Y2_Car_Prefab_GO = GameObject.Instantiate(Y2_Car_Prefab, new Vector3(464, 292, 175),
                        Quaternion.Euler(0, -82, 0)) as GameObject;

                    var Y3_Car_Prefab = Resources.Load("Instantiable/car yellow") as GameObject;
                    var Y3_Car_Prefab_GO = GameObject.Instantiate(Y3_Car_Prefab, new Vector3(484, 293, 174),
                        Quaternion.Euler(0, -86, 0)) as GameObject;

                    var Y4_Car_Prefab = Resources.Load("Instantiable/car yellow") as GameObject;
                    var Y4_Car_Prefab_GO = GameObject.Instantiate(Y4_Car_Prefab, new Vector3(475, 293, 174),
                        Quaternion.Euler(0, -83, 0)) as GameObject;
                    yellowcar = Y4_Car_Prefab_GO;


                    var police_Prefab = Resources.Load("Instantiable/police vehicle") as GameObject;
                    var police_Prefab_GO = GameObject.Instantiate(police_Prefab, new Vector3(479, 291, 157),
                        Quaternion.Euler(1, 102, 0)) as GameObject;

                    var Bus_Prefab = Resources.Load("Instantiable/City_bus") as GameObject;
                    var Bus_Prefab_GO = GameObject.Instantiate(Bus_Prefab, new Vector3(461, 288, 155),
                        Quaternion.Euler(-5, 100, 3)) as GameObject;


                    var Bike_Prefab = Resources.Load("Instantiable/SportBike") as GameObject;
                    var Bike_Prefab_GO = GameObject.Instantiate(Bike_Prefab, new Vector3(481, 291, 154),
                        Quaternion.Euler(0, 97, 0)) as GameObject;

                    var B_Car_Prefab = Resources.Load("Instantiable/Car blue") as GameObject;
                    var B_Car_Prefab_GO = GameObject.Instantiate(B_Car_Prefab, new Vector3(472, 293, 171),
                        Quaternion.Euler(0, -90, 0)) as GameObject;
                    Bluecar = B_Car_Prefab_GO;

                    var W_Car_Prefab = Resources.Load("Instantiable/Car white") as GameObject;
                    var W_Car_Prefab_GO = GameObject.Instantiate(W_Car_Prefab, new Vector3(481, 293, 170),
                        Quaternion.Euler(0, -87, 0)) as GameObject;

                    var Jeep_Prefab = Resources.Load("Instantiable/Jeep_2") as GameObject;
                    var Jeep_Prefab_GO = GameObject.Instantiate(Jeep_Prefab, new Vector3(450, 290, 159),
                        Quaternion.Euler(0, 100, 0)) as GameObject;


                }
                if (Dropdown_value == "Vehicle on highway met with an accident")
                {


                    var Y1_Car_Prefab = Resources.Load("Instantiable/Car yellow") as GameObject;
                    var Y1_Car_Prefab_GO = GameObject.Instantiate(Y1_Car_Prefab, new Vector3(449, 292, 176),
                         Quaternion.Euler(0, -80, 0)) as GameObject;


                    var Y4_Car_Prefab = Resources.Load("Instantiable/car yellow") as GameObject;
                    var Y4_Car_Prefab_GO = GameObject.Instantiate(Y4_Car_Prefab, new Vector3(477, 293, 175),
                        Quaternion.Euler(0, -49, 0)) as GameObject;
                    yellowcar = Y4_Car_Prefab_GO;


                    var police_Prefab = Resources.Load("Instantiable/police vehicle") as GameObject;
                    var police_Prefab_GO = GameObject.Instantiate(police_Prefab, new Vector3(479, 291, 157),
                        Quaternion.Euler(1, 102, 0)) as GameObject;

                    var Bus_Prefab = Resources.Load("Instantiable/City_bus") as GameObject;
                    var Bus_Prefab_GO = GameObject.Instantiate(Bus_Prefab, new Vector3(461, 288, 155),
                        Quaternion.Euler(-5, 100, 3)) as GameObject;

                    var Bus_Prefab1 = Resources.Load("Instantiable/City_bus") as GameObject;
                    var Bus_Prefab1_GO = GameObject.Instantiate(Bus_Prefab1, new Vector3(467, 290, 175),
                        Quaternion.Euler(0, -85, 0)) as GameObject;


                    var Bike_Prefab = Resources.Load("Instantiable/SportBike") as GameObject;
                    var Bike_Prefab_GO = GameObject.Instantiate(Bike_Prefab, new Vector3(481, 291, 154),
                        Quaternion.Euler(0, 97, 0)) as GameObject;

                    var B_Car_Prefab = Resources.Load("Instantiable/Car blue") as GameObject;
                    var B_Car_Prefab_GO = GameObject.Instantiate(B_Car_Prefab, new Vector3(487, 293, 173),
                        Quaternion.Euler(0, -87, 0)) as GameObject;
                    Bluecar = B_Car_Prefab_GO;

                    var W_Car_Prefab = Resources.Load("Instantiable/Car white") as GameObject;
                    var W_Car_Prefab_GO = GameObject.Instantiate(W_Car_Prefab, new Vector3(438, 285, 175),
                        Quaternion.Euler(0, -87, 0)) as GameObject;

                    var Jeep_Prefab = Resources.Load("Instantiable/Jeep_2") as GameObject;
                    var Jeep_Prefab_GO = GameObject.Instantiate(Jeep_Prefab, new Vector3(450, 290, 159),
                        Quaternion.Euler(0, 100, 0)) as GameObject;


                }
            }
            //  -----------------------------------Scene "countrySide"-------------------------------------------------------

            if (Scene_num == 3)
            {
                if (Dropdown_value == "Animal crossing the road")
                {
                    var W_Car_Prefab = Resources.Load("Instantiable/Car white") as GameObject;
                    var W_Car_Prefab_GO = GameObject.Instantiate(W_Car_Prefab, new Vector3(228, 303, 386),
                        Quaternion.Euler(0, -108, 0)) as GameObject;

                    var animal_Prefab = Resources.Load("Instantiable/animal") as GameObject;
                    var animal_Prefab_GO = GameObject.Instantiate(animal_Prefab, new Vector3(243, 301, 386),
                         Quaternion.Euler(0, -51, 0)) as GameObject;


                    var Y_Car_Prefab = Resources.Load("Instantiable/car yellow") as GameObject;
                    var Y_Car_Prefab_GO = GameObject.Instantiate(Y_Car_Prefab, new Vector3(251, 301, 387),
                        Quaternion.Euler(0, -95, 0)) as GameObject;
                    yellowcar = Y_Car_Prefab_GO;
                }
                else if (Dropdown_value == "Vehicle driving near curved way")
                {
                    var W_Car_Prefab = Resources.Load("Instantiable/Car white") as GameObject;
                    var W_Car_Prefab_GO = GameObject.Instantiate(W_Car_Prefab, new Vector3(228, 303, 386),
                        Quaternion.Euler(0, -108, 0)) as GameObject;

                    var animal_Prefab = Resources.Load("Instantiable/animal") as GameObject;
                    var animal_Prefab_GO = GameObject.Instantiate(animal_Prefab, new Vector3(238, 301, 391),
                         Quaternion.Euler(0, -31, 0)) as GameObject;


                    var Y_Car_Prefab = Resources.Load("Instantiable/car yellow") as GameObject;
                    var Y_Car_Prefab_GO = GameObject.Instantiate(Y_Car_Prefab, new Vector3(247, 301, 381),
                        Quaternion.Euler(0, -98, 0)) as GameObject;
                    yellowcar = Y_Car_Prefab_GO;
                }
            }
            // -----------------------------------Scene "Parking Zone"------------------------------------------------------ -
            if (Scene_num == 4)
            {
                if (Dropdown_value == "Two Vehicles detect the same parking place")
                {

                    var Y4_Car_Prefab = Resources.Load("Instantiable/car yellow") as GameObject;
                    var Y4_Car_Prefab_GO = GameObject.Instantiate(Y4_Car_Prefab, new Vector3(301, 342, -365),
                        Quaternion.Euler(0, 101, 0)) as GameObject;
                    yellowcar = Y4_Car_Prefab_GO;


                    var Bus_Prefab = Resources.Load("Instantiable/SchoolBus") as GameObject;
                    var Bus_Prefab_GO = GameObject.Instantiate(Bus_Prefab, new Vector3(328, 345, -349),
                        Quaternion.Euler(0, 206, 0)) as GameObject;


                    var B_Car_Prefab = Resources.Load("Instantiable/Car blue") as GameObject;
                    var B_Car_Prefab_GO = GameObject.Instantiate(B_Car_Prefab, new Vector3(303, 341, -359),
                        Quaternion.Euler(0, 9, 0)) as GameObject;


                    var W_Car_Prefab = Resources.Load("Instantiable/Car white") as GameObject;
                    var W_Car_Prefab_GO = GameObject.Instantiate(W_Car_Prefab, new Vector3(309, 342, -361),
                        Quaternion.Euler(0, 13, 0)) as GameObject;
                    // whitecar = W_Car_Prefab_GO;

                    var Jeep_Prefab = Resources.Load("Instantiable/Jeep_2") as GameObject;
                    var Jeep_Prefab_GO = GameObject.Instantiate(Jeep_Prefab, new Vector3(316, 341, -362),
                        Quaternion.Euler(0, 18, 0)) as GameObject;

                    var Person_Prefab2 = Resources.Load("Instantiable/person_Girl") as GameObject;
                    var Person_Prefab2_GO = GameObject.Instantiate(Person_Prefab2, new Vector3(297, 346, -353),
                        Quaternion.Euler(0, -143, 0)) as GameObject;

                    var GiroGirl = Resources.Load("Instantiable/Gyroscooter_Girl") as GameObject;
                    var GiroGirl_GO = GameObject.Instantiate(GiroGirl, new Vector3(316, 342, -366),
                        Quaternion.Euler(0, -104, 0)) as GameObject;


                }
                if (Dropdown_value == "Pedestrians behind the vehicle While unparking")
                {



                    var Bus_Prefab = Resources.Load("Instantiable/SchoolBus") as GameObject;
                    var Bus_Prefab_GO = GameObject.Instantiate(Bus_Prefab, new Vector3(328, 342, -349),
                        Quaternion.Euler(0, 206, 0)) as GameObject;


                    var B_Car_Prefab = Resources.Load("Instantiable/Car blue") as GameObject;
                    var B_Car_Prefab_GO = GameObject.Instantiate(B_Car_Prefab, new Vector3(303, 341, -359),
                        Quaternion.Euler(0, 9, 0)) as GameObject;


                    var W_Car_Prefab = Resources.Load("Instantiable/Car white") as GameObject;
                    var W_Car_Prefab_GO = GameObject.Instantiate(W_Car_Prefab, new Vector3(309, 342, -361),
                        Quaternion.Euler(0, 13, 0)) as GameObject;
                    whitecar = W_Car_Prefab_GO;

                    var Jeep_Prefab = Resources.Load("Instantiable/Jeep_2") as GameObject;
                    var Jeep_Prefab_GO = GameObject.Instantiate(Jeep_Prefab, new Vector3(316, 341, -362),
                        Quaternion.Euler(0, 18, 0)) as GameObject;

                    var Person_Prefab2 = Resources.Load("Instantiable/person_Girl") as GameObject;
                    var Person_Prefab2_GO = GameObject.Instantiate(Person_Prefab2, new Vector3(297, 346, -353),
                        Quaternion.Euler(0, -143, 0)) as GameObject;

                    var GiroGirl = Resources.Load("Instantiable/Gyroscooter_Girl") as GameObject;
                    var GiroGirl_GO = GameObject.Instantiate(GiroGirl, new Vector3(308, 342, -365),
                        Quaternion.Euler(0, -69, 0)) as GameObject;

                }
            }
            
        }
        // Calls the SceneInfo's callInfo function to print text on  debug text panel
       sceneinfo2.callInfo();
       prefab_Flag = false;
    }

    // this method is callled when load attack button is pressed.Sets the intersection_flag true which means models positions changes in update funtion
    public void threatload()
    {
        sceneinfo = GameObject.FindObjectOfType(typeof(SceneInfo)) as SceneInfo;
        intersection_flag = true;
        Hacker_image.SetActive(true);
        sceneinfo.callInfo();

    }

    //(optional function) not using in the current applicaion
    // method to pass the intersection_flag value so that we can activate debug panel on "Threat load" button click
    public bool flagchange()
    {
        return intersection_flag;
    }


    void Update()
    {
        //Loads all the changed position of prefab models at runtime .
        if (intersection_flag)
        {
            // -----------------------------------Scene "Intersection/city"------------------------------------------------------ -
            if (Scene_num == 1)
            {
                if (Dropdown_value == "Vehicle is approaching intersection")
                {

                    // lerp funtion helps to moves the object to destination frameby frame i,e using lerp method
                    Vector3 BlueCar_Position = new Vector3(191f, Bluecar.transform.position.y, -224f);
                    Bluecar.transform.position = Vector3.Lerp(Bluecar.transform.position, BlueCar_Position, Time.deltaTime * 1);


                }
                else if (Dropdown_value == "Vehicle detects the traffic jams")
                {


                    Vector3 BlueCar_Position = new Vector3(207f, Bluecar.transform.position.y, -222f);
                    Bluecar.transform.position = Vector3.Lerp(Bluecar.transform.position, BlueCar_Position, Time.deltaTime * 1);
                    //Bluecar.transform.Translate(p);

                }
            }


            // -----------------------------------Scene "HighWay"------------------------------------------------------ -

            if (Scene_num == 2)
            {
                if (Dropdown_value == "Vehicle on highway changing the lane")
                {



                    Vector3 yellowcar_position = new Vector3(470f, yellowcar.transform.position.y, 175f);
                    yellowcar.transform.position = Vector3.Lerp(yellowcar.transform.position, yellowcar_position, Time.deltaTime * 1);

                    Vector3 BlueCar_Position = new Vector3(467f, Bluecar.transform.position.y, 176f);
                    Bluecar.transform.position = Vector3.Lerp(Bluecar.transform.position, BlueCar_Position, Time.deltaTime * 1);



                }
                else if (Dropdown_value == "Vehicle on highway met with an accident")
                {

                    Vector3 BlueCar_Position = new Vector3(475f, Bluecar.transform.position.y, 173f);
                    Bluecar.transform.position = Vector3.Lerp(Bluecar.transform.position, BlueCar_Position, Time.deltaTime * 1);



                }
            }


            // -----------------------------------Scene "CountrySide"------------------------------------------------------ -

            if (Scene_num == 3)
            {
                if (Dropdown_value == "Animal crossing the road")
                {

                    Vector3 yellowcar_Position = new Vector3(240f, yellowcar.transform.position.y, 386f);
                    yellowcar.transform.position = Vector3.Lerp(yellowcar.transform.position, yellowcar_Position, Time.deltaTime * 1);
                }
                else if (Dropdown_value == "Vehicle driving near curved way")
                {
                    Vector3 yellowcar_Position = new Vector3(233f, yellowcar.transform.position.y, 374f);
                    yellowcar.transform.position = Vector3.Lerp(yellowcar.transform.position, yellowcar_Position, Time.deltaTime * 1);
                }
            }


            // -----------------------------------Scene "ParkingZone"------------------------------------------------------ -
            if (Scene_num == 4)
            {
                if (Dropdown_value == "Two Vehicles detect the same parking place")
                {
                    Vector3 yellowcar_Position = new Vector3(308f, yellowcar.transform.position.y, -363f);
                    yellowcar.transform.position = Vector3.Lerp(yellowcar.transform.position, yellowcar_Position, Time.deltaTime * 1);
                    

                }
                else if (Dropdown_value == "Pedestrians behind the vehicle While unparking")
                    {

                    Vector3 whitecar_Position = new Vector3(309f, whitecar.transform.position.y, -367f);
                    whitecar.transform.position = Vector3.Lerp(whitecar.transform.position, whitecar_Position, Time.deltaTime * 1);

                }
            }

        }
    }
    
}
