# Итоговая работа #

***Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина который меньше или равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.***

Для решения данной задачи сначала нам необоходимо создать первоначальный массив. Для определения его размера мы запрашиваем у пользователя сколько элементов он хочет видеть в своём массиве. Далее просим ввести его поочередно столько элементов, сколько он указал ранее. И формируем из этих элеметов массив yourArray.
Затем с помощью цикла мы сортируем элементы. Нам необходимо оставить элементы, длина которых не превышает 3 символа. Мы проходимся по каждому элементу и сравниваем его длину с 3. Если очередной элемент нам подходит, добавляем его в новый массив resultArray.
Далее выводим на экран оба массива. Для этого используем метод PrintArray.
***

![Блок-схема решения данной задачи](/Exam_diagram.png)