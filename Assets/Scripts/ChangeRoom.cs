using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ChangeRoom Class defines the change between rooms
/// </summary>
public class ChangeRoom : MonoBehaviour
{
    /// <summary>
    /// ActiveScene
    /// </summary>
    private GameObject[] ActiveScene;

    /// <summary>
    /// LivingRoom gameobject with sphere and buttons
    /// </summary>
    public GameObject[] LivingRoom;

    /// <summary>
    /// Cantina GameObject with sphere and buttons
    /// </summary>
    public GameObject[] Cantina;

    /// <summary>
    /// Cube GameObject with sphere and buttons
    /// </summary>
    public GameObject[] Cube;

    /// <summary>
    /// Mezzanie GameObject with sphere and buttons
    /// </summary>
    public GameObject[] Mezzanine;

    private void Start()
    {
        ActiveScene = LivingRoom;
    }

    /// <summary>
    /// Method to go to the Cantina
    /// </summary>
    public void ToCantina()
    {
        foreach(GameObject objects in ActiveScene)
        {
            objects.SetActive(false);
        }

        foreach(GameObject elements in Cantina)
        {
            elements.SetActive(true);
        }
        ActiveScene = Cantina;
    }

    /// <summary>
    /// ToCube method to go to the cube
    /// </summary>
    public void ToCube()
    {
        foreach (GameObject objects in ActiveScene)
        {
            objects.SetActive(false);
        }

        foreach(GameObject element in Cube)
        {
            element.SetActive(true);
        }
        ActiveScene = Cube;
    }
    /// <summary>
    /// ToLivingRoom method to go to the LivingRoom
    /// </summary>
    public void ToLivingRoom()
    {
        foreach (GameObject objects in ActiveScene)
        {
            objects.SetActive(false);
        }

        foreach(GameObject element in LivingRoom)
        {
            element.SetActive(true);
        }
        ActiveScene = LivingRoom;

    }
    /// <summary>
    /// ToMezzanie method to go to the Mezzanine
    /// </summary>
    public void ToMezzanine()
    {
        foreach (GameObject objects in ActiveScene)
        {
            objects.SetActive(false);
        }

        foreach(GameObject elements in Mezzanine)
        {
            elements.SetActive(true);
        }
        ActiveScene = Mezzanine;
    }
}
