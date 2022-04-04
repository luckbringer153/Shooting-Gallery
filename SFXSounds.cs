using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXSounds : MonoBehaviour
{
    public AudioSource gunShoots;
    public AudioSource hit;
    public AudioSource click;

    public void PlaygunShoots()
    {
        gunShoots.Play();
    }

    public void Playhit()
    {
        hit.Play();
    }

    public void Playclick()
    {
        click.Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hit.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hit.Play();
    }


}
