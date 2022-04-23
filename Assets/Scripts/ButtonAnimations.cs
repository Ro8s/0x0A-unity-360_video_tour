using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ButtonAnimations class that declares the methods
/// OnPointerEnter and OnPointerExit used in EventTrigger component
/// </summary>
public class ButtonAnimations : MonoBehaviour
{

    /// <summary>
    /// panel GameObject with information
    /// </summary>
    public GameObject panel;

    /// <summary>
    /// isOpenChecks if the information it's already open
    /// </summary>
    private bool isOpen = false;

    /// <summary>
    /// OnPointerEnter method that changes the size when a button
    /// it's aim with a ray
    /// </summary>
    public void OnPointerEnter()
    {
        GameObject g = this.gameObject;
        g.transform.localScale = this.gameObject.transform.localScale * 1.5f;

    }
    /// <summary>
    /// OnPointerExit method that returns the normal size of the button
    /// when the ray it's not on it
    /// </summary>
    public void OnPointerExit()
    {
        GameObject g = this.gameObject;
        g.transform.localScale = this.gameObject.transform.localScale / 1.5f;
    }

    /// <summary>
    /// OnDisplayInfo method that displays the information
    /// </summary>
    public void OnDisplayInfo()
    {
        GameObject g = this.gameObject;
        if(isOpen == false)
        {
            g.transform.localScale = this.gameObject.transform.localScale * 1.5f;
            isOpen = true;
        }
        panel.SetActive(true);
    }

    /// <summary>
    /// OnHideInfo method that hides the information
    /// </summary>
    public void OnHideInfo()
    {
        GameObject g = this.gameObject;
        if(isOpen == true)
        g.transform.localScale = this.gameObject.transform.localScale / 1.5f;
        panel.SetActive(false);
        isOpen = false;
    }
}
