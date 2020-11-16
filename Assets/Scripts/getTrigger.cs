using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class getTrigger : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField] LifeField lifeField;
    [SerializeField] ScoreField scoreField;
    static int lifePoints = 3;
    static int scorePoints = 0;
    Material balloonMaterial;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            balloonMaterial = other.GetComponent<Renderer>().material;
            if (balloonMaterial.color == Color.red) {
                lifePoints--;
                lifeField.SetNumber(lifePoints);
                if (lifePoints == 0 ){
                    Destroy(this.gameObject);
                }
                Destroy(other.gameObject);
            }
            else { //color == blue
                scorePoints++;
                scoreField.SetNumber(scorePoints);
                Destroy(other.gameObject);
            }
        }
    }
}
