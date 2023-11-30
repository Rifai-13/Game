using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FighterAction : MonoBehaviour
{
    private GameObject hero;
    private GameObject enemy;

    [SerializeField]
    private GameObject meleePrefab;

    [SerializeField]
    private GameObject rangePrefab;

    [SerializeField]
    private Sprite faceIcon;

    private GameObject currentAttack;
    
    void Awake()
    {
        hero = GameObject.FindGameObjectWithTag("Hero");
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }
    public void SelectAttack(string btn)
    {
        GameObject victim = hero;
        try
        {
            if (tag == "Hero")
        {
            victim = enemy;
        }
        if (btn.CompareTo("BesickAttack") == 0)
        {
            Debug.Log("BesickAttack");
           // meleePrefab.GetComponent<AttackScript>().Attack(victim);

        } else if (btn.CompareTo("Health") == 0)
        {
            Debug.Log("Health");
           // rangePrefab.GetComponent<AttackScript>().Attack(victim);
        } else
        {
            Debug.Log("AttackUp");
        }
        }
        catch (System.NullReferenceException e)
        {
            
            Debug.Log("terjadi kesalahan" + e.Message);
        }
        
    }
}
