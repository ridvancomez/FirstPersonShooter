using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private RaycastHit hit;


    [SerializeField]
    private GameObject rayPoint;

    [SerializeField, Tooltip("Menzil")]
    private float range;


    [SerializeField, Tooltip("Ateþ Sesi")]
    private AudioSource gunSound;

    [SerializeField]
    private ParticleSystem gunEffect;

    [SerializeField]
    private Camera camera;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }
    }

    private void Fire()
    {
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, range))
        {

            hit.transform.gameObject.SetActive(false);  

            gunSound.Play();
            gunEffect.Play();
        }
    }
}
