using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.Audio;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerrb;
    public float playerspeed;
    RepeatBg bg;
    PipeSpawn ps;
    AudioSource hitsound;
    public AudioClip hit;
    public AudioClip fly;
    public AudioClip point;
    public Score scoretxt;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        playerrb = GetComponent<Rigidbody2D>();
        bg = GameObject.Find("Background").GetComponent<RepeatBg>();
        ps = GameObject.Find("PipeSpawn").GetComponent<PipeSpawn>();
        hitsound = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="pipe" || collision.gameObject.tag == "Bottom")
        {
            // Destroy(this.gameObject);
            SceneManager.LoadScene(2);
            bg.offsetvalue = 0;
            ps.CancelInvoke("PipeSpawns");
            hitsound.clip = hit;
            hitsound.Play();
            animator.enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pipe")
        {
            //print("score is up");
            scoretxt.ScoreUp();
            hitsound.clip=point;
            hitsound.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerrb.velocity =new Vector2(0,playerspeed);
            hitsound.clip = fly;
            hitsound.Play();
            animator.SetTrigger("Fly");
        }
    }
}
