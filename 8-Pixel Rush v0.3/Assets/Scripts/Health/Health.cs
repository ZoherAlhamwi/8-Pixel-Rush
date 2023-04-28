using System.Collections;
using System.Collections.Generic;
using System.Threading;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth {get; private set;}
    private Animator anim;
    private bool dead;
    private DeathManager deathmanager;


    private void Start()
    {
        deathmanager = FindObjectOfType<DeathManager>();
    }

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage,0,startingHealth);

        if(currentHealth > 0)
        {
            anim.SetTrigger("isHurt");
        }
        else
        {
            if(!dead) {
            anim.SetTrigger("isDead");
            GetComponent<PlayerMovement>().enabled = false;
                dead = true;
                Die();
            }
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(1);
        }
    }
    private void Die()
    {
        deathmanager.PlayerDied();
    }


}
