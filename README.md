# Итоговая проверочная работа за первый блок обучения

## Задание
**Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При его решений не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.**

## Примеры
### ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

### ["1234", "1567", "-2", "computer science"] -> ["-2"]

### ["Russia", "Denmark", "Kazan"] -> [] 


# Решение задачи
## Ввод элемента массива с клавиатуры
***Согласно заданию, можно вводить элементы массива с клавиатуры или задать на старте алгоритма. В моем решений пользователь сам будет решать длинну массива а так же его элементы.***

- *Пользователю предлагается сначала ввести количество элементов которые он хотел бы ввести, для определения длинны массива.*
- *Затем пользователь по очередно будет вводить элементы массива.*

## PrintArray-метод для вывода массива в терминал
*Метод создан для вывдение элементов массива в [ ], и для разделение каждого элемента с запятой.* 

## FillNewArr - метод для формирования нового массива строк чья длинна ровна или меньше 3.
- *В этом методе было принято решение воспользоваться `rnd.Next` для введение переменной `newSize`.* 
- *В методе создаем массив с длинной  `newSize`*
-*Перебор и запись данных с изначального массива в новый массив будет проводится до тех пор пока i-тый элементе меньше или равен `newSize`*
```
    Random rnd = new Random();
    int newSize = rnd.Next(min, max);
    string[] newArr = new string[newSize];
    for (int i = 0; i <= newSize; i++)
    {
        newArr[i] = array[i];
    }
    return newArr;
```
- *В методе задаем minimum=1 и maximum = 3 как требуется в задаче*