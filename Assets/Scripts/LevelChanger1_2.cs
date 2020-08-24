using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger1_2 : MonoBehaviour
{

    public Animator animator;

    private int levelToLoad;

    [SerializeField] private Animator myAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FadeToNextLevel();
        }
    }

    public void FadeToNextLevel()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("FadeOut", false);
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
