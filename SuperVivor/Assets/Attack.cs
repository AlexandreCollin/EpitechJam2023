using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator animator;
    public GameObject bullet;

    [SerializeField] private AudioSource hitSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            animator.SetTrigger("isAttack");
            hitSoundEffect.Play();
            Instantiate(bullet, transform.position, Quaternion.identity);
        } 
    }

}
