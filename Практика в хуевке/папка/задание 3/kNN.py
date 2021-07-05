import numpy as np
import math

# вычисление евклидова расстояния между двумя точками
def dist(p1, p2):
    return math.sqrt(sum((p1 - p2)**2))

    # классификация методом k ближайших соседей
    # X - обучающее множество.
    #   Строки соответствуют объектам,
    #   столбцы - признакам.
    #   Последний столбец - номер класса
    # k - количество ближайших соседей (не более числа объектов в X)
    # obj - объект, который нужно классифицировать
def k_nearest(X, k, obj):
    sub_X = X[:, 0:-1]
    min = np.min(sub_X, axis=0)
    max = np.max(sub_X, axis=0)

    # TODO: выполнить нормализацию каждого столбца (кроме последнего)
    # матрицы X, пользуясь формулой с практики по k-means
    norm = (sub_X - min) / (max - min)


    # TODO: зная параметры среднего и среднеквадратического отклонения
    #       по каждому столбцу sub_X, выполнить нормализацию объекта obj
    sub_obj = (obj - min) / (max - min)

    # TODO: рассчитать евклидово расстояние от obj до каждого объекта sub_X (функция dist ниже).
    distances = np.zeros((np.shape(X)[0]))
    for i in range((np.shape(X)[0])):
        distances[i] = dist(sub_obj, norm[i])



    # TODO: Получить с помощью функции np.argsort индексы соседей по мере их удаления от obj.
    indx = np.argsort(distances)


    # TODO: выбрать в отдельный вектор классы k ближайших соседей
    nearest_classes = X[[indx[i] for i in range(k)], -1]

    # TODO: определить наиболее часто встречающийся класс в этом векторе.
    unique, counts = np.unique(nearest_classes, return_counts=True)
    object_class = unique[np.argmax(counts)]

    # TODO: вернуть полученное значение из функции. Искомый класс объекта obj хранится в переменной object_class
    return object_class


