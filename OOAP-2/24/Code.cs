﻿// Пример факторизации:
// Предположим, у нас есть классы "Треугольник" и "Прямоугольник". Спустя время мы понимаем, что эти классы имеют общие свойства "площадь" и "периметр".
// Для улучшения структуры проекта мы можем создать общий родительский класс "Многоугольник", который будет содержать общие методы и свойства.

// Пример абстрагирования:
// Класс "Многоугольник" кажется универсальным решением, но позже в проект добавляются криволинейные фигуры. Можно абстрагировать все типы фигур классом "ГеометрическаяФигура", и наследовать класс "Многоугольник" от него.