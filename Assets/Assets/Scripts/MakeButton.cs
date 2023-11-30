using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeButton : MonoBehaviour
{
    [SerializeField]
    private bool physical;

    private GameObject hero;
    void Start()
    {
        string temp = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => AttachCallback(temp));
        hero = GameObject.FindGameObjectWithTag("Hero");
    }

    private void AttachCallback(string btn)
    {
        try
        {
            if (btn.CompareTo("BesickAttackBtn") == 0)
            {
                hero.GetComponent<FighterAction>().SelectAttack("BesickAttack");
            }
            else if (btn.CompareTo("RangeBtn") == 0)
            {
                hero.GetComponent<FighterAction>().SelectAttack("Health");
            }
            else
            {
                hero.GetComponent<FighterAction>().SelectAttack("AttackUp");
            }
        }
        catch (System.NullReferenceException e)
        {
            Debug.Log("terjadi kesalahan" + e.Message);
            
        }

    }
}
