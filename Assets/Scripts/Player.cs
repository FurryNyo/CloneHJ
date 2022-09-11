using Assets.Scripts;
using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float BounceSpeed;
    public Rigidbody Rigidbody;
    public Game Game;
    public Platform CurrentPlatform;
    public GameObject SplashParticle;
    public AudioSource ballBounce;
    public AudioSource platformBreak;
    public static int Score;
    private GameObject platform;

    public void ReachFinish()
    {
        Game.OnPlayerReachedFinish();
        Rigidbody.velocity = Vector3.zero;
    }

    public void Bounce()
    {
        ballBounce.Play();
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
    }

    public void Die()
    {
        Game.OnPlayerDied();
        Rigidbody.velocity = Vector3.zero;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            GameObject Splash = Instantiate(SplashParticle, transform.position, transform.rotation);
            Splash.transform.parent = collision.gameObject.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CountBreakingPlatforms();

    }

    private int CountBreakingPlatforms()
    {
        Score++;
        platformBreak.Play();
        Destroy(platform);

        return Score;
    }

    private void Start()
    {
        Score = 0;
    }

    private void Update()
    {
        platform = GameObject.FindGameObjectWithTag("Platform");

    }

}
