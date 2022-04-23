using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// FadeInFadeOutAnim class that defines the events to the animation
/// Between scenes pressing the buttons
/// </summary>
public class FadeInFadeOutAnim : MonoBehaviour
{
    public Animator animator;


    private void Awake()
    {
        animator.Play("FadeIn");
    }
    /// <summary>
    /// OnFadeOut method that do the animation of Fadeout
    /// </summary>
    public void OnFadeOut()
    {
        animator.Play("FadeOut");
        Invoke("OnFadeIn", 2f);
    }
    /// <summary>
    /// OnFadeIn method that do the animation of FadeOut
    /// </summary>
    public void OnFadeIn()
    {
        animator.Play("FadeIn");
    }
}
