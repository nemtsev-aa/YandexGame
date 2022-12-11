using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class CoinManager : MonoBehaviour
{
    /// <summary>
    /// Количество монет, собранных персонажем на уровне
    /// </summary>
    [SerializeField] int _numberOfCoinInLevel;
    /// <summary>
    /// Текстовое поле для отображения количества собранных монет
    /// </summary>
    [SerializeField] TextMeshProUGUI _text;

    /// <summary>
    /// Увеличение счётчика монет
    /// </summary>
    public void AddOne()
    {
        _numberOfCoinInLevel += 1;
        //Отображение счёта на экране
        _text.text = _numberOfCoinInLevel.ToString();
    }

}
