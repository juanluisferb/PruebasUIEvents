using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIElements : MonoBehaviour {

    Button _button;
    Slider _slider;
    Toggle _toggle;
    Dropdown _dropDown;
    InputField _inputField;

    private void Awake()
    {
        _button = GetComponentInChildren<Button>();
        _slider = GetComponentInChildren<Slider>();
        _toggle = GetComponentInChildren<Toggle>();
        _dropDown = GetComponentInChildren<Dropdown>();
        _inputField = GetComponentInChildren<InputField>();

    }

    private void Start()
    {
        _slider.value = 50;
        _toggle.isOn = true;
        _dropDown.value = 1;
        _inputField.text = ("Hola mundo");
    }

    public void ButtonPressed()
    {
        Debug.Log("Botón presionado");


    }

    public void TogglePressed(bool active)
    {
        Debug.Log("CheckBox pulsado " + active);

    }

    public void SliderValueChanged(float value)
    {
        Debug.Log("Slider arrastrado " + value);

    }

    public void DropdownValueChanged(int option)
    {
        Debug.Log("Menú opción seleccionada: " + option);


    }

    public void InputFieldValueChanged(string value)
    {
        Debug.Log("Campo texto cambiado: " + value);
    }

    public void InputFieldEndEditing(string value)
    {
        Debug.Log("Campo texto finalizó edición: " + value);
    }
}
