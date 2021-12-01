using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerRespawn : MonoBehaviour
{
    private float cheackPointPX, cheackPointPY;
    
    public Animator anim;
    public GameObject player;
    public Transform respawn;
    public GameObject colli1;
    public GameObject colli2;
    public GameObject lava;
    public Transform respawn2;

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
        player.transform.position = respawn.position;
        lava.transform.position = respawn2.position;
    }

    public void PlayerDamage2()
    {
        anim.Play("PlayerHit");
        Invoke("ReloadScene", 0);
        colli1.SetActive(true);
        colli2.SetActive(false);
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
