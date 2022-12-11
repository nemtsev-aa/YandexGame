using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    /// <summary>
    /// Очки на воротах
    /// </summary>
    [SerializeField] int _value;
    /// <summary>
    /// Тип деформации
    /// </summary>
    [SerializeField] DeformationType _deformationType;
    /// <summary>
    /// Класс изменяющий внешний вид ворот
    /// </summary>
    [SerializeField] GateAppeareance _gateAppeareance;

    private void OnValidate()
    {
        //Вызываем процедуру изменения внешнего вида ворот
        _gateAppeareance.UpdateVisual(_deformationType, _value);
    }
}