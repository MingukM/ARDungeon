using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class CharacterStats : MonoBehaviour {

	public float maxHealth;
	public float currentHealth { get; set; }

	public Stats damage;
	public Stats defense;

	void Awake() {

		currentHealth = maxHealth;
	}

	void Update(){

		if(CrossPlatformInputManager.GetButtonDown("Attack")){

			TakeDamage (10);
		}
	}

	public void TakeDamage(float damage) {


		damage -= defense.BaseValue;

		// preventing the sign change
		damage = Mathf.Clamp (damage, 0, int.MaxValue);

		currentHealth -= damage;
		Debug.Log (transform.name + " takes " + damage + " damage.");

		if (currentHealth <= 0) {
			Die ();
		}
	}

	public void Die(){

		// changes scene to the base when character is defeated
		SceneManager.LoadScene ("Base");
	}

}
