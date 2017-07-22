using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEnergy : MonoBehaviour {
    public int energy;
    public Text ui;

    private int value;

    void Start() {
        UpdateUI();
    }

    public void DecreaseEnergy(int amount) {
        energy -= amount;
        UpdateUI();
    }

    public void IncreaseEnergy(int amount) {
        energy += amount;
        UpdateUI();
    }

    private void UpdateUI() {
        ui.text = energy.ToString();
    }
}
