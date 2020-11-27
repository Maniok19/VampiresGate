using UnityEngine.UI;
using UnityEngine;

public class LivesUI : MonoBehaviour {

    public Text livesTexte;

	void Update () {
        livesTexte.text = PlayerStats.lives + " LIVES";
	}
}
