using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpTownFunctionYouUp : MonoBehaviour {
    int health = 100;
    int attackPower = 25;
    bool shieldOn = true;
    int shieldAmt = 15;
    // Use this for initialization
    void Start()
    {
        Debug.Log("Helath at start: " + health);
    }
    public void Attack()
    {
        int damageToInflict = GetAttackDamage(shieldOn, shieldAmt, attackPower);
        health -= damageToInflict;
        Debug.Log("Health After Attack: " + health);
    }
	public void Heal()
    {
        int healAmount = GetRandomNumber();
        health += healAmount;
        Debug.Log("Recieved " + healAmount + " health");
        Debug.Log("You now have " + health);
    }
    private int GetAttackDamage(bool isShieldOn, int theShieldAmt, int AttackPower)
    {
        int damage = 0;
        if (isShieldOn)
        {
            damage = AttackPower - (int)((float)theShieldAmt * 0.10f);
        }
        else
        {
            damage = AttackPower;
        }
        return damage;
    }
    private int GetRandomNumber()
    {
        return Random.Range(2, 10); //Inclusive Unity Function
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
