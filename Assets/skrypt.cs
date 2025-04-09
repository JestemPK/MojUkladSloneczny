using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Cinemachine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{
    public CinemachineVirtualCamera Kamera1;
    public CinemachineVirtualCamera Kamera2;
    public CinemachineVirtualCamera Kamera3;
    public CinemachineVirtualCamera Kamera4;
    public CinemachineVirtualCamera Kamera5Modele0;
    public CinemachineVirtualCamera Kamera6Modele1;
    public CinemachineVirtualCamera Kamera7Modele2;
    public CinemachineVirtualCamera Kamera8Modele3;
    public CinemachineVirtualCamera Kamera9Modele4;
    public CinemachineVirtualCamera Kamera10Modele5;
    public CinemachineVirtualCamera Kamera11Modele6;
    public CinemachineVirtualCamera Kamera12Modele7;
    public CinemachineVirtualCamera Kamera13Modele8;
    public CinemachineVirtualCamera Kamera14Modele9;
    public CinemachineVirtualCamera Kamera15Modele10;
    public GameObject rakieta;
    public float skok = 0;
    public float kat = 0;
    public float promien = 5;
    public float szybkosc = 5;
    public int rakietaStart = 0;
    public int aktualnaKamera = 1;
    public int modeleKamera = 0;
    private Vector3 horizontalMove;
    private Vector3 verticalMove;
    public float moveSpeed;
    private float horizontalMouse;
    private Quaternion currentRotation;

    void Start()
    {
        if (gameObject.CompareTag("Kula"))
        {
            transform.position = new Vector3(10, 5, 0); //pozycje x y i z
        }

        //znikanie i centrowanie kursora 
        UnityEngine.Cursor.visible = false;
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (gameObject.CompareTag("Kula"))
        {
            transform.Rotate(0f, 1f, 0f, Space.Self);
        }

        if (gameObject.CompareTag("KulaModel")) // MODELE PLANET
        {
            transform.Rotate(0f, 0.1f, 0f, Space.Self);
        }

            if (gameObject.CompareTag("Rakieta"))
        {
            if (Input.GetKeyDown(KeyCode.Alpha1)) // Wacza Virtual Camera 1
            {
                Kamera1.Priority = 10;
                Kamera2.Priority = 5;
                Kamera3.Priority = 5;
                Kamera4.Priority = 5;

                Kamera5Modele0.Priority = 5;
                Kamera6Modele1.Priority = 5;
                Kamera7Modele2.Priority = 5;
                Kamera8Modele3.Priority = 5;
                Kamera9Modele4.Priority = 5;
                Kamera10Modele5.Priority = 5;
                Kamera11Modele6.Priority = 5;
                Kamera12Modele7.Priority = 5;
                Kamera13Modele8.Priority = 5;
                Kamera14Modele9.Priority = 5;
                Kamera15Modele10.Priority = 5;

                aktualnaKamera = 1;

                rakietaStart = 0; //aktywowanie rakiety
            }

            if (Input.GetKeyDown(KeyCode.JoystickButton1)) // Wacza Virtual Camera 1 PAD
            {
                Kamera1.Priority = 10;
                Kamera2.Priority = 5;
                Kamera3.Priority = 5;
                Kamera4.Priority = 5;

                Kamera5Modele0.Priority = 5;
                Kamera6Modele1.Priority = 5;
                Kamera7Modele2.Priority = 5;
                Kamera8Modele3.Priority = 5;
                Kamera9Modele4.Priority = 5;
                Kamera10Modele5.Priority = 5;
                Kamera11Modele6.Priority = 5;
                Kamera12Modele7.Priority = 5;
                Kamera13Modele8.Priority = 5;
                Kamera14Modele9.Priority = 5;
                Kamera15Modele10.Priority = 5;

                aktualnaKamera = 1;

                rakietaStart = 0; //aktywowanie rakiety
            }

            if (Input.GetKeyDown(KeyCode.Alpha2)) // Wacza Virtual Camera 2
            {
                Kamera1.Priority = 5;
                Kamera2.Priority = 10;
                Kamera3.Priority = 5;
                Kamera4.Priority = 5;

                Kamera5Modele0.Priority = 5;
                Kamera6Modele1.Priority = 5;
                Kamera7Modele2.Priority = 5;
                Kamera8Modele3.Priority = 5;
                Kamera9Modele4.Priority = 5;
                Kamera10Modele5.Priority = 5;
                Kamera11Modele6.Priority = 5;
                Kamera12Modele7.Priority = 5;
                Kamera13Modele8.Priority = 5;
                Kamera14Modele9.Priority = 5;
                Kamera15Modele10.Priority = 5;

                aktualnaKamera = 2;

                rakietaStart = 1; //aktywowanie rakiety TU
            }
            if (Input.GetKeyDown(KeyCode.JoystickButton0)) // Wacza Virtual Camera 2 PAD
            {
                Kamera1.Priority = 5;
                Kamera2.Priority = 10;
                Kamera3.Priority = 5;
                Kamera4.Priority = 5;

                Kamera5Modele0.Priority = 5;
                Kamera6Modele1.Priority = 5;
                Kamera7Modele2.Priority = 5;
                Kamera8Modele3.Priority = 5;
                Kamera9Modele4.Priority = 5;
                Kamera10Modele5.Priority = 5;
                Kamera11Modele6.Priority = 5;
                Kamera12Modele7.Priority = 5;
                Kamera13Modele8.Priority = 5;
                Kamera14Modele9.Priority = 5;
                Kamera15Modele10.Priority = 5;

                aktualnaKamera = 2;

                rakietaStart = 1; //aktywowanie rakiety TU
            }
            if (Input.GetKeyDown(KeyCode.Alpha3)) // Wacza Virtual Camera 3
            {
                Kamera1.Priority = 5;
                Kamera2.Priority = 5;
                Kamera3.Priority = 10;
                Kamera4.Priority = 5;

                Kamera5Modele0.Priority = 5;
                Kamera6Modele1.Priority = 5;
                Kamera7Modele2.Priority = 5;
                Kamera8Modele3.Priority = 5;
                Kamera9Modele4.Priority = 5;
                Kamera10Modele5.Priority = 5;
                Kamera11Modele6.Priority = 5;
                Kamera12Modele7.Priority = 5;
                Kamera13Modele8.Priority = 5;
                Kamera14Modele9.Priority = 5;
                Kamera15Modele10.Priority = 5;

                aktualnaKamera = 3;

                rakietaStart = 0; //aktywowanie rakiety
            }
            if (Input.GetKeyDown(KeyCode.JoystickButton3)) // Wacza Virtual Camera 3 PAD
            {
                Kamera1.Priority = 5;
                Kamera2.Priority = 5;
                Kamera3.Priority = 10;
                Kamera4.Priority = 5;

                Kamera5Modele0.Priority = 5;
                Kamera6Modele1.Priority = 5;
                Kamera7Modele2.Priority = 5;
                Kamera8Modele3.Priority = 5;
                Kamera9Modele4.Priority = 5;
                Kamera10Modele5.Priority = 5;
                Kamera11Modele6.Priority = 5;
                Kamera12Modele7.Priority = 5;
                Kamera13Modele8.Priority = 5;
                Kamera14Modele9.Priority = 5;
                Kamera15Modele10.Priority = 5;

                aktualnaKamera = 3;

                rakietaStart = 0; //aktywowanie rakiety
            }
            if (Input.GetKeyDown(KeyCode.Alpha4)) // Wacza Virtual Camera 4
            {
                Kamera1.Priority = 5;
                Kamera2.Priority = 5;
                Kamera3.Priority = 5;
                Kamera4.Priority = 10;

                Kamera5Modele0.Priority = 5;
                Kamera6Modele1.Priority = 5;
                Kamera7Modele2.Priority = 5;
                Kamera8Modele3.Priority = 5;
                Kamera9Modele4.Priority = 5;
                Kamera10Modele5.Priority = 5;
                Kamera11Modele6.Priority = 5;
                Kamera12Modele7.Priority = 5;
                Kamera13Modele8.Priority = 5;
                Kamera14Modele9.Priority = 5;
                Kamera15Modele10.Priority = 5;

                aktualnaKamera = 4;

                rakietaStart = 0; //aktywowanie rakiety
            }
            if (Input.GetKeyDown(KeyCode.JoystickButton2)) // Wacza Virtual Camera 4 PAD
            {
                Kamera1.Priority = 5;
                Kamera2.Priority = 5;
                Kamera3.Priority = 5;
                Kamera4.Priority = 10;

                Kamera5Modele0.Priority = 5;
                Kamera6Modele1.Priority = 5;
                Kamera7Modele2.Priority = 5;
                Kamera8Modele3.Priority = 5;
                Kamera9Modele4.Priority = 5;
                Kamera10Modele5.Priority = 5;
                Kamera11Modele6.Priority = 5;
                Kamera12Modele7.Priority = 5;
                Kamera13Modele8.Priority = 5;
                Kamera14Modele9.Priority = 5;
                Kamera15Modele10.Priority = 5;

                aktualnaKamera = 4;

                rakietaStart = 0; //aktywowanie rakiety
            }

            if (Input.GetKeyDown(KeyCode.Alpha5)) // Wacza Virtual Camera 5 i reszte
            {
                Kamera1.Priority = 5;
                Kamera2.Priority = 5;
                Kamera3.Priority = 5;
                Kamera4.Priority = 5;

                aktualnaKamera = 5;
                Debug.Log(modeleKamera);

                rakietaStart = 0; //aktywowanie rakiety

                if (modeleKamera == 0)
                {
                    Kamera1.Priority = 5;
                    Kamera2.Priority = 5;
                    Kamera3.Priority = 5;
                    Kamera4.Priority = 5;

                    Kamera5Modele0.Priority = 10;
                    Kamera6Modele1.Priority = 5;
                    Kamera7Modele2.Priority = 5;
                    Kamera8Modele3.Priority = 5;
                    Kamera9Modele4.Priority = 5;
                    Kamera10Modele5.Priority = 5;
                    Kamera11Modele6.Priority = 5;
                    Kamera12Modele7.Priority = 5;
                    Kamera13Modele8.Priority = 5;
                    Kamera14Modele9.Priority = 5;
                    Kamera15Modele10.Priority = 5;
                }

                if (modeleKamera == 1)
                {
                    Kamera1.Priority = 5;
                    Kamera2.Priority = 5;
                    Kamera3.Priority = 5;
                    Kamera4.Priority = 5;

                    Kamera5Modele0.Priority = 5;
                    Kamera6Modele1.Priority = 10;
                    Kamera7Modele2.Priority = 5;
                    Kamera8Modele3.Priority = 5;
                    Kamera9Modele4.Priority = 5;
                    Kamera10Modele5.Priority = 5;
                    Kamera11Modele6.Priority = 5;
                    Kamera12Modele7.Priority = 5;
                    Kamera13Modele8.Priority = 5;
                    Kamera14Modele9.Priority = 5;
                    Kamera15Modele10.Priority = 5;
                }

                if (modeleKamera == 2)
                {
                    Kamera1.Priority = 5;
                    Kamera2.Priority = 5;
                    Kamera3.Priority = 5;
                    Kamera4.Priority = 5;

                    Kamera5Modele0.Priority = 5;
                    Kamera6Modele1.Priority = 5;
                    Kamera7Modele2.Priority = 10;
                    Kamera8Modele3.Priority = 5;
                    Kamera9Modele4.Priority = 5;
                    Kamera10Modele5.Priority = 5;
                    Kamera11Modele6.Priority = 5;
                    Kamera12Modele7.Priority = 5;
                    Kamera13Modele8.Priority = 5;
                    Kamera14Modele9.Priority = 5;
                    Kamera15Modele10.Priority = 5;
                }

                if (modeleKamera == 3)
                {
                    Kamera1.Priority = 5;
                    Kamera2.Priority = 5;
                    Kamera3.Priority = 5;
                    Kamera4.Priority = 5;

                    Kamera5Modele0.Priority = 5;
                    Kamera6Modele1.Priority = 5;
                    Kamera7Modele2.Priority = 5;
                    Kamera8Modele3.Priority = 10;
                    Kamera9Modele4.Priority = 5;
                    Kamera10Modele5.Priority = 5;
                    Kamera11Modele6.Priority = 5;
                    Kamera12Modele7.Priority = 5;
                    Kamera13Modele8.Priority = 5;
                    Kamera14Modele9.Priority = 5;
                    Kamera15Modele10.Priority = 5;
                }

                if (modeleKamera == 4)
                {
                    Kamera1.Priority = 5;
                    Kamera2.Priority = 5;
                    Kamera3.Priority = 5;
                    Kamera4.Priority = 5;

                    Kamera5Modele0.Priority = 5;
                    Kamera6Modele1.Priority = 5;
                    Kamera7Modele2.Priority = 5;
                    Kamera8Modele3.Priority = 5;
                    Kamera9Modele4.Priority = 10;
                    Kamera10Modele5.Priority = 5;
                    Kamera11Modele6.Priority = 5;
                    Kamera12Modele7.Priority = 5;
                    Kamera13Modele8.Priority = 5;
                    Kamera14Modele9.Priority = 5;
                    Kamera15Modele10.Priority = 5;
                }

                if (modeleKamera == 5)
                {
                    Kamera1.Priority = 5;
                    Kamera2.Priority = 5;
                    Kamera3.Priority = 5;
                    Kamera4.Priority = 5;

                    Kamera5Modele0.Priority = 5;
                    Kamera6Modele1.Priority = 5;
                    Kamera7Modele2.Priority = 5;
                    Kamera8Modele3.Priority = 5;
                    Kamera9Modele4.Priority = 5;
                    Kamera10Modele5.Priority = 10;
                    Kamera11Modele6.Priority = 5;
                    Kamera12Modele7.Priority = 5;
                    Kamera13Modele8.Priority = 5;
                    Kamera14Modele9.Priority = 5;
                    Kamera15Modele10.Priority = 5;
                }

                if (modeleKamera == 6)
                {
                    Kamera1.Priority = 5;
                    Kamera2.Priority = 5;
                    Kamera3.Priority = 5;
                    Kamera4.Priority = 5;

                    Kamera5Modele0.Priority = 5;
                    Kamera6Modele1.Priority = 5;
                    Kamera7Modele2.Priority = 5;
                    Kamera8Modele3.Priority = 5;
                    Kamera9Modele4.Priority = 5;
                    Kamera10Modele5.Priority = 5;
                    Kamera11Modele6.Priority = 10;
                    Kamera12Modele7.Priority = 5;
                    Kamera13Modele8.Priority = 5;
                    Kamera14Modele9.Priority = 5;
                    Kamera15Modele10.Priority = 5;
                }

                if (modeleKamera == 7)
                {
                    Kamera1.Priority = 5;
                    Kamera2.Priority = 5;
                    Kamera3.Priority = 5;
                    Kamera4.Priority = 5;

                    Kamera5Modele0.Priority = 5;
                    Kamera6Modele1.Priority = 5;
                    Kamera7Modele2.Priority = 5;
                    Kamera8Modele3.Priority = 5;
                    Kamera9Modele4.Priority = 5;
                    Kamera10Modele5.Priority = 5;
                    Kamera11Modele6.Priority = 5;
                    Kamera12Modele7.Priority = 10;
                    Kamera13Modele8.Priority = 5;
                    Kamera14Modele9.Priority = 5;
                    Kamera15Modele10.Priority = 5;
                }

                if (modeleKamera == 8)
                {
                    Kamera1.Priority = 5;
                    Kamera2.Priority = 5;
                    Kamera3.Priority = 5;
                    Kamera4.Priority = 5;

                    Kamera5Modele0.Priority = 5;
                    Kamera6Modele1.Priority = 5;
                    Kamera7Modele2.Priority = 5;
                    Kamera8Modele3.Priority = 5;
                    Kamera9Modele4.Priority = 5;
                    Kamera10Modele5.Priority = 5;
                    Kamera11Modele6.Priority = 5;
                    Kamera12Modele7.Priority = 5;
                    Kamera13Modele8.Priority = 10;
                    Kamera14Modele9.Priority = 5;
                    Kamera15Modele10.Priority = 5;
                }

                if (modeleKamera == 9)
                {
                    Kamera1.Priority = 5;
                    Kamera2.Priority = 5;
                    Kamera3.Priority = 5;
                    Kamera4.Priority = 5;

                    Kamera5Modele0.Priority = 5;
                    Kamera6Modele1.Priority = 5;
                    Kamera7Modele2.Priority = 5;
                    Kamera8Modele3.Priority = 5;
                    Kamera9Modele4.Priority = 5;
                    Kamera10Modele5.Priority = 5;
                    Kamera11Modele6.Priority = 5;
                    Kamera12Modele7.Priority = 5;
                    Kamera13Modele8.Priority = 5;
                    Kamera14Modele9.Priority = 10;
                    Kamera15Modele10.Priority = 5;
                }

                if (modeleKamera == 10)
                {
                    Kamera1.Priority = 5;
                    Kamera2.Priority = 5;
                    Kamera3.Priority = 5;
                    Kamera4.Priority = 5;

                    Kamera5Modele0.Priority = 5;
                    Kamera6Modele1.Priority = 5;
                    Kamera7Modele2.Priority = 5;
                    Kamera8Modele3.Priority = 5;
                    Kamera9Modele4.Priority = 5;
                    Kamera10Modele5.Priority = 5;
                    Kamera11Modele6.Priority = 5;
                    Kamera12Modele7.Priority = 5;
                    Kamera13Modele8.Priority = 5;
                    Kamera14Modele9.Priority = 5;
                    Kamera15Modele10.Priority = 10;
                }
            }

            if (aktualnaKamera == 5)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    modeleKamera = modeleKamera + 1;

                    if (modeleKamera == 11) // LOOP KAMERY MODELE
                    {
                        modeleKamera = 0;
                    }
                    Debug.Log(modeleKamera);

                    if (modeleKamera == 0)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 10;
                        Kamera6Modele1.Priority = 5;
                        Kamera7Modele2.Priority = 5;
                        Kamera8Modele3.Priority = 5;
                        Kamera9Modele4.Priority = 5;
                        Kamera10Modele5.Priority = 5;
                        Kamera11Modele6.Priority = 5;
                        Kamera12Modele7.Priority = 5;
                        Kamera13Modele8.Priority = 5;
                        Kamera14Modele9.Priority = 5;
                        Kamera15Modele10.Priority = 5;
                    }

                    if (modeleKamera == 1)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 5;
                        Kamera6Modele1.Priority = 10;
                        Kamera7Modele2.Priority = 5;
                        Kamera8Modele3.Priority = 5;
                        Kamera9Modele4.Priority = 5;
                        Kamera10Modele5.Priority = 5;
                        Kamera11Modele6.Priority = 5;
                        Kamera12Modele7.Priority = 5;
                        Kamera13Modele8.Priority = 5;
                        Kamera14Modele9.Priority = 5;
                        Kamera15Modele10.Priority = 5;
                    }

                    if (modeleKamera == 2)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 5;
                        Kamera6Modele1.Priority = 5;
                        Kamera7Modele2.Priority = 10;
                        Kamera8Modele3.Priority = 5;
                        Kamera9Modele4.Priority = 5;
                        Kamera10Modele5.Priority = 5;
                        Kamera11Modele6.Priority = 5;
                        Kamera12Modele7.Priority = 5;
                        Kamera13Modele8.Priority = 5;
                        Kamera14Modele9.Priority = 5;
                        Kamera15Modele10.Priority = 5;
                    }

                    if (modeleKamera == 3)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 5;
                        Kamera6Modele1.Priority = 5;
                        Kamera7Modele2.Priority = 5;
                        Kamera8Modele3.Priority = 10;
                        Kamera9Modele4.Priority = 5;
                        Kamera10Modele5.Priority = 5;
                        Kamera11Modele6.Priority = 5;
                        Kamera12Modele7.Priority = 5;
                        Kamera13Modele8.Priority = 5;
                        Kamera14Modele9.Priority = 5;
                        Kamera15Modele10.Priority = 5;
                    }

                    if (modeleKamera == 4)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 5;
                        Kamera6Modele1.Priority = 5;
                        Kamera7Modele2.Priority = 5;
                        Kamera8Modele3.Priority = 5;
                        Kamera9Modele4.Priority = 10;
                        Kamera10Modele5.Priority = 5;
                        Kamera11Modele6.Priority = 5;
                        Kamera12Modele7.Priority = 5;
                        Kamera13Modele8.Priority = 5;
                        Kamera14Modele9.Priority = 5;
                        Kamera15Modele10.Priority = 5;
                    }

                    if (modeleKamera == 5)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 5;
                        Kamera6Modele1.Priority = 5;
                        Kamera7Modele2.Priority = 5;
                        Kamera8Modele3.Priority = 5;
                        Kamera9Modele4.Priority = 5;
                        Kamera10Modele5.Priority = 10;
                        Kamera11Modele6.Priority = 5;
                        Kamera12Modele7.Priority = 5;
                        Kamera13Modele8.Priority = 5;
                        Kamera14Modele9.Priority = 5;
                        Kamera15Modele10.Priority = 5;
                    }

                    if (modeleKamera == 6)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 5;
                        Kamera6Modele1.Priority = 5;
                        Kamera7Modele2.Priority = 5;
                        Kamera8Modele3.Priority = 5;
                        Kamera9Modele4.Priority = 5;
                        Kamera10Modele5.Priority = 5;
                        Kamera11Modele6.Priority = 10;
                        Kamera12Modele7.Priority = 5;
                        Kamera13Modele8.Priority = 5;
                        Kamera14Modele9.Priority = 5;
                        Kamera15Modele10.Priority = 5;
                    }

                    if (modeleKamera == 7)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 5;
                        Kamera6Modele1.Priority = 5;
                        Kamera7Modele2.Priority = 5;
                        Kamera8Modele3.Priority = 5;
                        Kamera9Modele4.Priority = 5;
                        Kamera10Modele5.Priority = 5;
                        Kamera11Modele6.Priority = 5;
                        Kamera12Modele7.Priority = 10;
                        Kamera13Modele8.Priority = 5;
                        Kamera14Modele9.Priority = 5;
                        Kamera15Modele10.Priority = 5;
                    }

                    if (modeleKamera == 8)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 5;
                        Kamera6Modele1.Priority = 5;
                        Kamera7Modele2.Priority = 5;
                        Kamera8Modele3.Priority = 5;
                        Kamera9Modele4.Priority = 5;
                        Kamera10Modele5.Priority = 5;
                        Kamera11Modele6.Priority = 5;
                        Kamera12Modele7.Priority = 5;
                        Kamera13Modele8.Priority = 10;
                        Kamera14Modele9.Priority = 5;
                        Kamera15Modele10.Priority = 5;
                    }

                    if (modeleKamera == 9)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 5;
                        Kamera6Modele1.Priority = 5;
                        Kamera7Modele2.Priority = 5;
                        Kamera8Modele3.Priority = 5;
                        Kamera9Modele4.Priority = 5;
                        Kamera10Modele5.Priority = 5;
                        Kamera11Modele6.Priority = 5;
                        Kamera12Modele7.Priority = 5;
                        Kamera13Modele8.Priority = 5;
                        Kamera14Modele9.Priority = 10;
                        Kamera15Modele10.Priority = 5;
                    }

                    if (modeleKamera == 10)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 5;
                        Kamera6Modele1.Priority = 5;
                        Kamera7Modele2.Priority = 5;
                        Kamera8Modele3.Priority = 5;
                        Kamera9Modele4.Priority = 5;
                        Kamera10Modele5.Priority = 5;
                        Kamera11Modele6.Priority = 5;
                        Kamera12Modele7.Priority = 5;
                        Kamera13Modele8.Priority = 5;
                        Kamera14Modele9.Priority = 5;
                        Kamera15Modele10.Priority = 10;
                    }
                }

                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    modeleKamera = modeleKamera - 1;

                    if (modeleKamera == -1) // LOOP KAMERY MODELE
                    {
                        modeleKamera = 10;
                    }
                    Debug.Log(modeleKamera);

                    if (modeleKamera == 0)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 10;
                        Kamera6Modele1.Priority = 5;
                        Kamera7Modele2.Priority = 5;
                        Kamera8Modele3.Priority = 5;
                        Kamera9Modele4.Priority = 5;
                        Kamera10Modele5.Priority = 5;
                        Kamera11Modele6.Priority = 5;
                        Kamera12Modele7.Priority = 5;
                        Kamera13Modele8.Priority = 5;
                        Kamera14Modele9.Priority = 5;
                        Kamera15Modele10.Priority = 5;
                    }

                    if (modeleKamera == 1)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 5;
                        Kamera6Modele1.Priority = 10;
                        Kamera7Modele2.Priority = 5;
                        Kamera8Modele3.Priority = 5;
                        Kamera9Modele4.Priority = 5;
                        Kamera10Modele5.Priority = 5;
                        Kamera11Modele6.Priority = 5;
                        Kamera12Modele7.Priority = 5;
                        Kamera13Modele8.Priority = 5;
                        Kamera14Modele9.Priority = 5;
                        Kamera15Modele10.Priority = 5;
                    }

                    if (modeleKamera == 2)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 5;
                        Kamera6Modele1.Priority = 5;
                        Kamera7Modele2.Priority = 10;
                        Kamera8Modele3.Priority = 5;
                        Kamera9Modele4.Priority = 5;
                        Kamera10Modele5.Priority = 5;
                        Kamera11Modele6.Priority = 5;
                        Kamera12Modele7.Priority = 5;
                        Kamera13Modele8.Priority = 5;
                        Kamera14Modele9.Priority = 5;
                        Kamera15Modele10.Priority = 5;
                    }

                    if (modeleKamera == 3)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 5;
                        Kamera6Modele1.Priority = 5;
                        Kamera7Modele2.Priority = 5;
                        Kamera8Modele3.Priority = 10;
                        Kamera9Modele4.Priority = 5;
                        Kamera10Modele5.Priority = 5;
                        Kamera11Modele6.Priority = 5;
                        Kamera12Modele7.Priority = 5;
                        Kamera13Modele8.Priority = 5;
                        Kamera14Modele9.Priority = 5;
                        Kamera15Modele10.Priority = 5;
                    }

                    if (modeleKamera == 4)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 5;
                        Kamera6Modele1.Priority = 5;
                        Kamera7Modele2.Priority = 5;
                        Kamera8Modele3.Priority = 5;
                        Kamera9Modele4.Priority = 10;
                        Kamera10Modele5.Priority = 5;
                        Kamera11Modele6.Priority = 5;
                        Kamera12Modele7.Priority = 5;
                        Kamera13Modele8.Priority = 5;
                        Kamera14Modele9.Priority = 5;
                        Kamera15Modele10.Priority = 5;
                    }

                    if (modeleKamera == 5)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 5;
                        Kamera6Modele1.Priority = 5;
                        Kamera7Modele2.Priority = 5;
                        Kamera8Modele3.Priority = 5;
                        Kamera9Modele4.Priority = 5;
                        Kamera10Modele5.Priority = 10;
                        Kamera11Modele6.Priority = 5;
                        Kamera12Modele7.Priority = 5;
                        Kamera13Modele8.Priority = 5;
                        Kamera14Modele9.Priority = 5;
                        Kamera15Modele10.Priority = 5;
                    }

                    if (modeleKamera == 6)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 5;
                        Kamera6Modele1.Priority = 5;
                        Kamera7Modele2.Priority = 5;
                        Kamera8Modele3.Priority = 5;
                        Kamera9Modele4.Priority = 5;
                        Kamera10Modele5.Priority = 5;
                        Kamera11Modele6.Priority = 10;
                        Kamera12Modele7.Priority = 5;
                        Kamera13Modele8.Priority = 5;
                        Kamera14Modele9.Priority = 5;
                        Kamera15Modele10.Priority = 5;
                    }

                    if (modeleKamera == 7)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 5;
                        Kamera6Modele1.Priority = 5;
                        Kamera7Modele2.Priority = 5;
                        Kamera8Modele3.Priority = 5;
                        Kamera9Modele4.Priority = 5;
                        Kamera10Modele5.Priority = 5;
                        Kamera11Modele6.Priority = 5;
                        Kamera12Modele7.Priority = 10;
                        Kamera13Modele8.Priority = 5;
                        Kamera14Modele9.Priority = 5;
                        Kamera15Modele10.Priority = 5;
                    }

                    if (modeleKamera == 8)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 5;
                        Kamera6Modele1.Priority = 5;
                        Kamera7Modele2.Priority = 5;
                        Kamera8Modele3.Priority = 5;
                        Kamera9Modele4.Priority = 5;
                        Kamera10Modele5.Priority = 5;
                        Kamera11Modele6.Priority = 5;
                        Kamera12Modele7.Priority = 5;
                        Kamera13Modele8.Priority = 10;
                        Kamera14Modele9.Priority = 5;
                        Kamera15Modele10.Priority = 5;
                    }

                    if (modeleKamera == 9)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 5;
                        Kamera6Modele1.Priority = 5;
                        Kamera7Modele2.Priority = 5;
                        Kamera8Modele3.Priority = 5;
                        Kamera9Modele4.Priority = 5;
                        Kamera10Modele5.Priority = 5;
                        Kamera11Modele6.Priority = 5;
                        Kamera12Modele7.Priority = 5;
                        Kamera13Modele8.Priority = 5;
                        Kamera14Modele9.Priority = 10;
                        Kamera15Modele10.Priority = 5;
                    }

                    if (modeleKamera == 10)
                    {
                        Kamera1.Priority = 5;
                        Kamera2.Priority = 5;
                        Kamera3.Priority = 5;
                        Kamera4.Priority = 5;

                        Kamera5Modele0.Priority = 5;
                        Kamera6Modele1.Priority = 5;
                        Kamera7Modele2.Priority = 5;
                        Kamera8Modele3.Priority = 5;
                        Kamera9Modele4.Priority = 5;
                        Kamera10Modele5.Priority = 5;
                        Kamera11Modele6.Priority = 5;
                        Kamera12Modele7.Priority = 5;
                        Kamera13Modele8.Priority = 5;
                        Kamera14Modele9.Priority = 5;
                        Kamera15Modele10.Priority = 10;
                    }

                }

            }
        }

        if (Input.GetKeyDown(KeyCode.Escape)) // zamkniecie
        {
            Debug.Log("wylaczenie");
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.F5)) // zamkniecie
        {
            Debug.Log("reset");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (rakietaStart == 1) // RAKIETA
        {
            if (Input.GetKey(KeyCode.W)) // W przod
            {
                if (gameObject.CompareTag("Rakieta"))
                {
                    Debug.Log("W");
                    horizontalMove = Input.GetAxis("Horizontal") * transform.right;
                    verticalMove = Input.GetAxis("Vertical") * new Vector3(transform.forward.x, y: 0f, transform.forward.z);

                    Vector3 direction = horizontalMove + verticalMove;
                    Debug.Log(direction);
                    transform.position += direction * moveSpeed * Time.deltaTime;
                }
            }
            if (Input.GetKey(KeyCode.A)) // A lewo
            {
                if (gameObject.CompareTag("Rakieta"))
                {
                    Debug.Log("A");
                    transform.Rotate(0f, 0f, -1f, Space.Self);
                }
            }
            if (Input.GetKey(KeyCode.S)) // S tyl
            {
                if (gameObject.CompareTag("Rakieta"))
                {
                    Debug.Log("S");
                }
            }
            if (Input.GetKey(KeyCode.D)) // D prawo
            {
                if (gameObject.CompareTag("Rakieta"))
                {
                    Debug.Log("D");
                    transform.Rotate(0f, 0f, 1f, Space.Self);
                }
            }
        }
    }

    void FixedUpdate()
    {
        if (gameObject.CompareTag("Kula"))
        {
            kat += szybkosc * Time.fixedDeltaTime;
            // Obliczamy nowe wspolrzedne X i Z
            float x = Mathf.Cos(kat) * promien;
            float z = Mathf.Sin(kat) * promien;
            transform.position = new Vector3(x, transform.position.y, z);
        }
    }
}
