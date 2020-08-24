using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger5_0 : MonoBehaviour
{
    public Animator animator;

    private int levelToLoad;

    [SerializeField] private Animator myAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FadeToLevel(0);
        }
    }
       

    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetBool("FadeOut", true);
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
