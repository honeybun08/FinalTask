# Итоговая контрольная работа по основному блоку

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

### *P.S. Задача выполнена на языке C#*

## Последовательное выполнение задачи:

1. Задается одномерный массив №1 типа string с конкретными значениями

2. Задается одномерный массив №2 типа string такого же размера, как и массив №1, но без конкретных значений(используем [array1.Length])

3. Создается метод для решения задачи:

* Используется метод типа *void*, применяются исходные заданные массивы как входные значения

* Вводится счетчик count для массива №2 (исходное *count = 0*), счетчик i для массива №1

* Для счетчика i используется цикл for, где *i < array1.Length*

* Так как в задаче есть условие ```новый массив из строк, длина которых меньше, либо равна 3 символам```, в наш метод добавляется условие if (*array1[i].Length <= 3*)

* Если данное условие выполняется, то элемент массива №1 заносится в count элемента массива №2.

* После этого, соответсвенно, увеличиваются счетчики count и i на 1.

* Далее применяется метод к массиву №1 и массиву №2, после чего итоговый массив №2 распечатывается(так сказать выводится на экран терминала, к нему применяется метод *PrintArray* типа void)




