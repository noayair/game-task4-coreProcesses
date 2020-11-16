using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/**
 * This component should be attached to a TextMeshPro object.
 * It allows to feed an integer number to the text field.
 */
[RequireComponent(typeof(TextMeshPro))]
public class ScoreField : MonoBehaviour {
    private TextMeshPro textField;
    private int number = 0;
    void Start()    {
        textField = GetComponent<TextMeshPro>();
    }
    public void SetNumber(int newNumber) {
        this.number = newNumber;
        this.textField.text = newNumber.ToString();
    }
}
