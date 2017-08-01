using System;

namespace human
{
   public class Human
    {
        public string name;
        public int strength=3;
        public int intelligence=3;
        public int dexterity=3;
        public int health=100;
        public Human(string name){
            this.name = name;
        }
        public Human(string myName, int myStrength, int myIntelligence, int myDexterity, int myHealth){
            name = myName;
            strength = myStrength;
            intelligence = myIntelligence;
            dexterity = myDexterity;
            health = myHealth;

        }
        public void Attack(Human enemy){
            enemy.health -= 5 * strength;
        }
        // public void attack(object target){
        //     Human enemy = target as Human;
        //     if(enemy != null) {
        //         enemy.health -= 5 * strength;
        //     }
        // }
    }
}

