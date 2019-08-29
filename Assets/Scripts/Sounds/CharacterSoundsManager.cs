using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundsManager : MonoBehaviour
{
    [SerializeField] private List<AudioClip> _footsteps = new List<AudioClip>();

    private AudioSource _audiosource;

    private void Awake()
    {
        _audiosource = GetComponent<AudioSource>();
        PlayFootstepsSound();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            PlayFootstepsSound();
        }
    }

    public void PlayFootstepsSound()
    {
        StartCoroutine(PlayEachFootSteps(4, 0.6f));
    }

    IEnumerator PlayEachFootSteps(int numberOfSteps, float timeBetweenSteps)
    {
        yield return new WaitForSeconds(Random.Range(0,0.5f));

        while (numberOfSteps > 0)
        {
            _audiosource.clip = _footsteps[Random.Range(0, _footsteps.Count)];
            _audiosource.pitch += Random.Range(-0.1f, 0.3f);
            _audiosource.Play();
            yield return new WaitForSeconds(timeBetweenSteps + Random.Range(-0.5f,0.5f));
            _audiosource.volume += 0.05f;
            _audiosource.pitch = 1;
            numberOfSteps--;
        }
        _audiosource.volume = 0.1f;
        _audiosource.pitch = 1;
    }
}
