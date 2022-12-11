using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    /// <summary>
    /// Скорость вращения монеты
    /// </summary>
    [SerializeField] float _rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        //Вражаем монету с определённой скоростью
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        ///Увеличиваем количество монет
        FindObjectOfType<CoinManager>().AddOne();
        //Уничтожаем монету при её взаимодействии с игроком
        Destroy(gameObject);

    }
}
