 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;

 public class Units : MonoBehaviour
 {
     public string unitsName;

     public int damage;

     public int maxHealth;
     public int currHealth;

     //takes damage
     public bool TakeDamage(int dmg)
     {
         currHealth -= dmg; //subtract damage from current health

         //if current system reaches zero, player dies
         if(currHealth <= 0) {
             return true; //if unit has died
         }
         else {
             return false; //if it hasnt
         }
     }

     //heals
     public void Heal(int amt)
     {
         currHealth += amt;
         if(currHealth > maxHealth)
             currHealth = maxHealth;
     }
 }
