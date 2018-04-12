using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Issou : MonoBehaviour
{
    public GameObject food1, food2, food3, food4, food5, food6, food7;
    public GameObject health1, health2, health3, health4, health5, health6, health7;

    public Vector3 posissou { get; set; }

    private Issou iss;

    [Range(1, 30)] public int timer = 5;
    public int Food { get; set; }

    public int Health { get; set; }
    public bool alive { get; set; }



    void Start()
    {
        iss = new Issou(this.gameObject);
        Debug.Log("Issou créé");
        Debug.Log("food au strat:"+iss.Food);
        Debug.Log("health au strat:" + iss.Health);

        StartCoroutine(InfiniteLoop());

        /*if (iss.alive == true)
        {
            StartCoroutine(Wait(5));
            iss.looseFood();
            //iss.Move(0.1f, 0, 0);
            Debug.Log(/*"alive: "+iss.alive+" Vie: " + iss.Health + " Nourriture: " + iss.Food + " Position: x: " + this.iss.posissou.x + " y: " + this.iss.posissou.y + " z: " + this.iss.posissou.z);
        }*/




    }

    void Update()
    {
        if (iss.Food >= 1)
            food1.GetComponent<Renderer>().material.color = Color.yellow;
        else food1.GetComponent<Renderer>().material.color = Color.white;
        if (iss.Food >= 2)
            food2.GetComponent<Renderer>().material.color = Color.yellow;
        else food2.GetComponent<Renderer>().material.color = Color.white;
        if (iss.Food >= 3)
            food3.GetComponent<Renderer>().material.color = Color.yellow;
        else food3.GetComponent<Renderer>().material.color = Color.white;
        if (iss.Food >= 4)
            food4.GetComponent<Renderer>().material.color = Color.yellow;
        else food4.GetComponent<Renderer>().material.color = Color.white;
        if (iss.Food >= 5)
            food5.GetComponent<Renderer>().material.color = Color.yellow;
        else food5.GetComponent<Renderer>().material.color = Color.white;
        if (iss.Food >= 6)
            food6.GetComponent<Renderer>().material.color = Color.yellow;
        else food6.GetComponent<Renderer>().material.color = Color.white;
        if (iss.Food >= 7)
            food7.GetComponent<Renderer>().material.color = Color.yellow;
        else food7.GetComponent<Renderer>().material.color = Color.white;






        if (iss.Health >= 1)
            health1.GetComponent<Renderer>().material.color = Color.red;
        else health1.GetComponent<Renderer>().material.color = Color.white;
        if (iss.Health >= 2)
            health2.GetComponent<Renderer>().material.color = Color.red;
        else health2.GetComponent<Renderer>().material.color = Color.white;
        if (iss.Health >= 3)
            health3.GetComponent<Renderer>().material.color = Color.red;
        else health3.GetComponent<Renderer>().material.color = Color.white;
        if (iss.Health >= 4)
            health4.GetComponent<Renderer>().material.color = Color.red;
        else health4.GetComponent<Renderer>().material.color = Color.white;
        if (iss.Health >= 5)
            health5.GetComponent<Renderer>().material.color = Color.red;
        else health5.GetComponent<Renderer>().material.color = Color.white;
        if (iss.Health >= 6)
            health6.GetComponent<Renderer>().material.color = Color.red;
        else health6.GetComponent<Renderer>().material.color = Color.white;
        if (iss.Health >= 7)
            health7.GetComponent<Renderer>().material.color = Color.red;
        else health7.GetComponent<Renderer>().material.color = Color.white;
        /*if (iss.alive == true)
        {
            StartCoroutine(Wait(5));
            iss.looseFood();
            //iss.Move(0.1f, 0, 0);
            Debug.Log(/*"alive: "+iss.alive+" Vie: " + iss.Health + " Nourriture: " + iss.Food + " Position: x: " + this.iss.posissou.x + " y: " + this.iss.posissou.y + " z: " + this.iss.posissou.z);
        }*/
    }



    public Issou(GameObject g)
    {
        this.Food = 7;
        this.Health = 7;
        this.posissou = g.transform.position;
        this.alive = true;
    }

    public void Die()
    {
        //fin du jeu
        Debug.Log("Fin du jeu: alive = 0");
        //Debug.Log("debug alive: "+  alive);
        alive = false;
        //Debug.Log("debug alive apres: " + alive);




    }

    public void looseFood()
    {
        if (Food == 0)
        {
            looseHealth();
            return;
        }
        Food = Food - 1;
        
    }

    public void looseHealth()
    {
        if (Health == 1)
        {
            Die();
            return;
        }
        Health = Health - 1;

    }

    public void Feed()
    {
        if (Food == 7) return;

        Food = Food + 1;
        Debug.Log("Le issou gagne 1 de nourriture");

    }

    public void Heal()
    {
        if (Food == 7)
        {
            if(Health < 7)
            {
                Health++;
                Debug.Log("Le issou gagne 1 de vie");

            }
        }
    }
    public void feed()
    {
        this.iss.Feed();
    }


    /* public void Move(float x, float y, float z)
     {
         this.posissou = new Vector3(x, y, z);
     }*/

        private void updateVie()
    {

    }

    private IEnumerator InfiniteLoop()
    {
        WaitForSeconds waitTime = new WaitForSeconds(timer);
        while (true)
        {
            if (iss.alive == true)
            {
                iss.Heal();
                iss.looseFood();
                Debug.Log("alive: " + iss.alive + " Vie: " + iss.Health + " Nourriture: " + iss.Food + " Position: x: " + this.iss.posissou.x + " y: " + this.iss.posissou.y + " z: " + this.iss.posissou.z);
            }
        

            yield return waitTime;
        }
    }
}

