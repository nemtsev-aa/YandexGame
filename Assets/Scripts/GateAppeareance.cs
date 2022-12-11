using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
/// <summary>
/// Тип деформации
/// </summary>
public enum DeformationType
{
    Width,
    Height
}

public class GateAppeareance : MonoBehaviour
{
    /// <summary>
    /// Текстовое поле для отображения значения ворот
    /// </summary>
    [SerializeField] TextMeshProUGUI _text;
    /// <summary>
    /// Изображение верхней понели
    /// </summary>
    [SerializeField] Image _topImage;
    /// <summary>
    /// Изображение стекла 
    /// </summary>
    [SerializeField] Image _glassImage;
    /// <summary>
    /// Цвет баф-эффектов
    /// </summary>
    [SerializeField] Color _colorPositive;
    /// <summary>
    /// Цвет дебаф-эффектов
    /// </summary>
    [SerializeField] Color _colorNegative;
   
    /// <summary>
    /// Отображение бафа в верхней панели ворот - "Увеличение ширины"
    /// </summary>
    [SerializeField] GameObject _expandLabel;
    /// <summary>
    /// Отображение бафа в верхней панели ворот - "Уменьшение ширины"
    /// </summary>
    [SerializeField] GameObject _shrinkLabel;
    /// <summary>
    /// Отображение бафа в верхней панели ворот - "Увеличение высоты"
    /// </summary>
    [SerializeField] GameObject _upLabel;
    /// <summary>
    /// Отображение бафа в верхней панели ворот - "Уменьшение высоты"
    /// </summary>
    [SerializeField] GameObject _downLabel;

    /// <summary>
    ///  Устанавливаем в редакторе значение ворот и их внешний вид изменяется в соответствии с установленным значением 
    /// </summary>
    public void UpdateVisual(DeformationType _deformationType, int _value)
    {
        string pref = "";

        if (_value > 0)
        {
            //Присваиваем верхней понели "позитивный" цвет
            //(Изменение с помощью команд)
            //_topImage.color = _colorPositive;
            //_glassImage.color = new Color(_colorPositive.r, _colorPositive.g, _colorPositive.b, 0.5f);

            //(Изменение с помощью функции с аргументом)
            SetColor(_colorPositive);

            pref = "+";
        }
        else if (_value == 0)
        {
            //(Изменение с помощью команд)
            //_topImage.color = Color.grey;
            //_glassImage.color = new Color(Color.gray.r, Color.gray.g, Color.gray.b, 0.5f);

            //(Изменение с помощью функции с аргументом)
            SetColor(Color.gray);
        }
        else
        {
            //Присваиваем верхней понели "негативный" цвет
            //(Изменение с помощью команд)
            //_topImage.color = _colorNegative;
            //_glassImage.color = new Color(_colorNegative.r, _colorNegative.g, _colorNegative.b, 0.5f);

            //(Изменение с помощью функции с аргументом)
            SetColor(_colorNegative);
        }

        //Текст на воротах
        _text.text = pref + _value.ToString();

        //Отключаем визуализацию эффектов верхней панели
        _expandLabel.SetActive(false);
        _shrinkLabel.SetActive(false);
        _upLabel.SetActive(false);
        _downLabel.SetActive(false);

        ///Если выбран тип деформации "Ширина"
        if (_deformationType == DeformationType.Width)
        {
            //И значение на воротах положительное
            if (_value > 0)
            {
                //Отображаем расходящиеся стрелки
                _expandLabel.SetActive(true);
            }
            else
            {
                //Отображаем сходящиеся стрелки
                _shrinkLabel.SetActive(true);
            }
        }
        else
        {
            if (_value > 0)
            {
                //Отображаем стрелку вверх
                _upLabel.SetActive(true);
            }
            else
            {
                //Отображаем стрелку вниз
                _downLabel.SetActive(true);
            }
        }
    }

    /// <summary>
    /// Изменение цвета ворот
    /// </summary>
    /// <param name="color"></param>
    void SetColor(Color color)
    {
        //Цвет верхней панели
        _topImage.color = new Color(color.r, color.g, color.b, 1f); 
        //Цвет стекла
        _glassImage.color = new Color(color.r, color.g, color.b, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
