// This scripts contains all the operations related to all the buttons of the unity configurator, such as camera options and defects , debug, except usecase and threat load and weather and time simualtion.

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using UnityEngine.UI;
using System.Text;
using System;
using System.Dynamic;
using UnityEngine.SceneManagement;
using System.Configuration;
using System.Runtime.CompilerServices;
using TMPro;



public class CameraOPS : MonoBehaviour
{

    /*
     * wasdrf : Basic movement
     * shift : Makes camera accelerate
     * space : Moves camera on X and Z axis only.  So camera doesn't gain any height
     * L : Mouse Lock
     */
   
    public float mouseSensitivity = 5.0f;        // Mouse rotation sensitivity.
    public float speed = 10.0f;    // Regular speed.
    public float gravity = 20.0f;    // Gravity force.
    public float shiftAdd = 25.0f;    // Multiplied by how long shift is held.  Basically running.
    public float maxShift = 100.0f;    // Maximum speed when holding shift.
    public bool superman_move = false; // For flyaround
    public bool bolt_move = false;   // For walk and run
    public bool switch_view = false; // swicth the camera position
    Vector3 matric;
    public bool fixed_view = false; // Fixedview 
    public static bool Mouse_Lock; // to lock the mouse
    private float totalRun = 1.0f; 
    private float rotationY = 0.0f;
    private float maximumY = 90.0f;
    private float minimumY = -90.0f;   
    public Quaternion moveToangle = Quaternion.identity;
    private CharacterController controller;
    public GameObject Lensflare;//Gameobject for lensfalre defect
    public GameObject Moisture;//Gameobject for Moiseture
    public GameObject Dirt1;//Gameobject for Dirt1 defect
    public GameObject Dirt2;//Gameobject for Dirt2 defect
    public GameObject Dirt3;//Gameobject for Dirt3 defect
    public ParseHandler phand;
    private Scene_Dropdown scene_Dropdown;
   // public GameObject cam;
    //public GameObject FPS;
    public static int Scene_num;
    [SerializeField]
    float time;//lean tween time for popup speed of debug text panel
    [SerializeField]
    public LeanTweenType type;//leantween style type
    
   


    void Start()
    {
        controller = GetComponent<CharacterController>();
        Mouse_Lock = true;//keeo the mouse lock 


    }
    
    void Update()
    {
       
        // Mouse commands. press L to lock the screen
        if (Input.GetKey(KeyCode.L))
        {
           Mouse_Lock = !Mouse_Lock;
        }

        
        // script to unlock the mosue movements for superman and usainbolt mode
        if (!Mouse_Lock)
        {
            float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * mouseSensitivity;
            rotationY += Input.GetAxis("Mouse Y") * mouseSensitivity;
            rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);
            transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0.0f);

        }
        

        // Keyboard commands. press ctrl and navigation buttons to run
        Vector3 p = getDirection();
        if (Input.GetKey(KeyCode.LeftShift))
        {
            totalRun += Time.deltaTime;
            p = p * totalRun * shiftAdd;
            p.x = Mathf.Clamp(p.x, -maxShift, maxShift);
            p.y = Mathf.Clamp(p.y, -maxShift, maxShift);
            p.z = Mathf.Clamp(p.z, -maxShift, maxShift);
        }
        else
        {
            totalRun = Mathf.Clamp(totalRun * 0.5f, 1.0f, 1000.0f);
            p = p * speed;

        }

        p = p * Time.deltaTime;
        Vector3 newPosition = transform.position;

        if (bolt_move)//for walking in usainbolt mode
        {
            p = transform.TransformDirection(p);
            p.y = 0.0f;
            p.y -= gravity * Time.deltaTime;
            controller.Move(p);
        }
        // Allow the player to fly around the scene
        if (superman_move)
        {
            transform.Translate(p);
        }

        // Transfer the camera position to new position so that scene can been seen from the top at 75 degree angle
        if (switch_view)
        {
            Vector3 moveToPosition = new Vector3(transform.position.x, 365f, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, moveToPosition, Time.deltaTime * 1);
            moveToangle = Quaternion.Euler(55, transform.localEulerAngles.y, 0);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, moveToangle, Time.deltaTime * 25);

        }
        // Moves the camera to a fixed position according to scene
        if (fixed_view)
        {
            scene_Dropdown = GameObject.FindObjectOfType(typeof(Scene_Dropdown)) as Scene_Dropdown;
            Scene_num = scene_Dropdown.Scene_number();
            if (Scene_num == 1)
            {
                Vector3 moveToPosition = new Vector3(236f, 354f, -220f);
                transform.position = Vector3.Lerp(transform.position, moveToPosition, Time.deltaTime * 1);
                moveToangle = Quaternion.Euler(30, 255, 0);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, moveToangle, Time.deltaTime * 25);
            }
            else if (Scene_num == 2)
            {
                Vector3 moveToPosition = new Vector3(494f, 302f, 167f);
                transform.position = Vector3.Lerp(transform.position, moveToPosition, Time.deltaTime * 1);
                moveToangle = Quaternion.Euler(38, 267, 0);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, moveToangle, Time.deltaTime * 25);
            }
            else if (Scene_num == 3)
            {
                Vector3 moveToPosition = new Vector3(263f, 312f, 384f);
                transform.position = Vector3.Lerp(transform.position, moveToPosition, Time.deltaTime * 1);
                moveToangle = Quaternion.Euler(29, 262, 0);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, moveToangle, Time.deltaTime * 25);
            }
            else if (Scene_num == 4)
            {
                Vector3 moveToPosition = new Vector3(305f, 350f, -378f);
                transform.position = Vector3.Lerp(transform.position, moveToPosition, Time.deltaTime * 1);
                moveToangle = Quaternion.Euler(30, 15, 0);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, moveToangle, Time.deltaTime * 25);
            }
            
        }
    }
    // Function to Activate bolt_move flag 
    public void Boltview()
    {
        if (!bolt_move)
        {
            Mouse_Lock = false;
            switch_view = false;
            superman_move = false;
            fixed_view = false;
            bolt_move = true;

        }
    }
    // Function to Activate superman_move flag 
    public void supermanView()
    {

        if (!superman_move)
        {
            Mouse_Lock = false;
            switch_view = false;
            fixed_view = false;
            bolt_move = false;
            superman_move = true;
            Vector3 movesuperpos = new Vector3(transform.position.x, 360f, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, movesuperpos, Time.deltaTime * 1);
        }


    }
    // Function to Activate switch_view flag 
    public void SwitchView()
    {

        if (!switch_view)
        {
            Mouse_Lock = true;
            bolt_move = false;
            fixed_view = false;
            superman_move = false;
            switch_view = true;

        }

    }
    // Function to Activate fixed_view flag 
    public void FixedView()
    {
        
        if (!fixed_view)
        {
            Mouse_Lock = true;
            bolt_move = false;
            superman_move = false;
            switch_view = false;
            fixed_view = true;
        }


    }
    // For fog effect
    public void Fog()
    {
        // Enable fog
        if (RenderSettings.fog)
        {

            RenderSettings.fog = false;
        }
        RenderSettings.fog = true;
    }

    // Function to Activate Lensfalre effect
    public void Lensflare_method()
    {
                Lensflare.SetActive(true);
                Moisture.SetActive(false);
                Dirt1.SetActive(false);
                Dirt2.SetActive(false);
                Dirt3.SetActive(false);
                
    }

    // Function to Activate  Moisture drops effect
    public void Moisture_method()
    {
                 Moisture.SetActive(true);
                 Lensflare.SetActive(false);
                 Dirt1.SetActive(false);
                 Dirt2.SetActive(false);
                 Dirt3.SetActive(false);
                 
    }

    // Function to Activate  dirt effect in 3 levels as a dropdown
    public void Dirtdropdown(int val)
    {
        Moisture.SetActive(false);
        Lensflare.SetActive(false);
    
        if (val == 1)
        {
            Dirt1.SetActive(true);
            Dirt2.SetActive(false);
            Dirt3.SetActive(false);

        }
        if (val == 2)
        {
            Dirt2.SetActive(true);
            Dirt1.SetActive(false);
            Dirt3.SetActive(false);
           
        }
        if (val == 3)
        {
            Dirt3.SetActive(true);
            Dirt1.SetActive(false);
            Dirt2.SetActive(false);
            
        }
    }

    // Finction to deactivate all the defects
    public void NoDefect()
    {
        Lensflare.SetActive(false);
        Moisture.SetActive(false);
        Dirt1.SetActive(false);
        Dirt2.SetActive(false);
        Dirt3.SetActive(false);

    }

    // For keyboard commands
    private Vector3 getDirection()
    {

        Vector3 p_Velocity = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        // Strifing enabled only in Fly Mode.
        if (!bolt_move)
        {
            if (Input.GetKey(KeyCode.F))
            {
                p_Velocity += new Vector3(0.0f, -1.0f, 0.0f);
            }
            if (Input.GetKey(KeyCode.R))
            {
                p_Velocity += new Vector3(0.0f, 1.0f, 0.0f);
            }
        }
        return p_Velocity;
    }

    public void resetRotation(Vector3 lookAt)
    {
        transform.LookAt(lookAt);
    }
    

    //  fucntion to enlarge debug text panel
    public void Tween()
    {
        LeanTween.cancel(gameObject);
        
        LeanTween.scale(gameObject, new Vector3(1,1,1), 1f).setEase(type);
    }
    //  fucntion to reduce debug text panel size
    public void TweenExit()
    {
        LeanTween.cancel(gameObject);
        
        LeanTween.scale(gameObject, new Vector3(0, 0, 0), 1f).setEase(type);
    }

    //For exit the game
    public void doExitGame()
    {
        Application.Quit();
        
    }
    
    // For exit the scene and go to starting scene
    public void SceneLoader(int SceneIndex)
    {
         
        if (SceneIndex == 0)
        {
            SceneManager.LoadScene(0);
        }

    }
}
