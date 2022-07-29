# Алгоритм решения итоговой проверочной работы: #

**Задача:** Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Алгоритм решения задачи:**
1. Инициализируем метод ***SearchStringsWithLimitedNumberSymbols***, который на фход принимает массив и максимальную длину строки.
2. Инициализируем вспомогатенльную переменную ***countString***, в которую будем записывать количество строк, длина ктороых не превышает ***maxLength*** символов.
3. Используя цикл ***for***, проходим по каждой строке массива.
	>Если длина строки меньше или равна ***maxLength***, увеличиваем переменную ***countString*** и счетчик цикла ***i***. Если длина больше ***maxLength***, увеличиваем только счетчик цикла ***i***.
4. Инициализируем новый массив размером ***countString***.
5. Используя цикл ***for***, проходим по каждой строке массива.
	> Если длина строки меньше или равна ***maxLength***, уменьшаем переменную ***countString***(необходимо для правильного заполнения массива) и добавляем ее в новый массив.
6. Возвращаем новый массив.
7. Для красивого вывода массива создаем метод ***PrintArray***.