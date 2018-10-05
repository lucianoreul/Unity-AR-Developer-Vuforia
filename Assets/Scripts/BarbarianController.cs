using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarbarianController : MonoBehaviour
{
    public Animator barbarianAnimator;
    public Animator menuPainelAnimator;
    public Button openPainel;
    public Button walk;
    public Button idle;
    public Button smile;
    public Button frown;
    public Button suprise;
    public Button wink;
    public Button run;
    public Button roundKick;
    public Button cry;
    public Button mean;

    private bool isOpen = false;

    private void Start()
    {
        openPainel.onClick.AddListener(delegate 
        {
            isOpen = !isOpen;
            menuPainelAnimator.SetBool("isOpen", isOpen);
        });

        walk.onClick.AddListener(delegate 
        {
            barbarianAnimator.SetTrigger("Walk");
        });
        idle.onClick.AddListener(delegate 
        {
            barbarianAnimator.SetTrigger("Idle");
        });
        smile.onClick.AddListener(delegate
        {
            barbarianAnimator.SetTrigger("Smile");
        });
        frown.onClick.AddListener(delegate
        {
            barbarianAnimator.SetTrigger("Frown");
        });
        suprise.onClick.AddListener(delegate
        {
            barbarianAnimator.SetTrigger("Suprise");
        });
        wink.onClick.AddListener(delegate
        {
            barbarianAnimator.SetTrigger("Wink");
        });
        run.onClick.AddListener(delegate
        {
            barbarianAnimator.SetTrigger("Run");
        });
        roundKick.onClick.AddListener(delegate
        {
            barbarianAnimator.SetTrigger("RoundKick");
        });
        cry.onClick.AddListener(delegate
        {
            barbarianAnimator.SetTrigger("Cry");
        });
        mean.onClick.AddListener(delegate
        {
            barbarianAnimator.SetTrigger("Mean");
        });

    }

}
