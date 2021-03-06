using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    private float cheackPointPX, cheackPointPY;

    public Animator anim;
    public GameObject transition;
    void Start()
    {
        if (PlayerPrefs.GetFloat("cheackPointPX") != 0)
        {
            transform.position = (new Vector2(PlayerPrefs.GetFloat("cheackPointPX"), PlayerPrefs.GetFloat("cheackPointPY")));
        }
    }
    public void reachedCheckPoint(float x, float y)
    {
        PlayerPrefs.SetFloat("cheackPointPX",x);
        PlayerPrefs.SetFloat("cheackPointPX",y);
    }

    public void PlayerDamage()
    {
        anim.Play("PlayerHit");
        transition.SetActive(true);      
        Invoke("ReloadScene", 0);
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
