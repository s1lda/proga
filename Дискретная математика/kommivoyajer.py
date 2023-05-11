from itertools import permutations

# Ввод матрицы весов
n = int(input("Введите количество городов: "))
print("Введите матрицу весов:")
matrix = []
for i in range(n):
    row = list(map(int, input().split()))
    matrix.append(row)

# Вычисляем минимальные расстояния для всех путей
costs = {}
for path in permutations(range(n)):
    # Добавляем исходную точку в конец пути и вычисляем его длину
    p = path + (path[0],)
    distance = sum(matrix[p[i]][p[i+1]] for i in range(n))
    costs[p] = distance

# Находим оптимальный путь
shortest_path = min(costs, key=costs.get)

# Выводим результат
print("Оптимальный путь: ", end="")
for city in shortest_path:
    print(city + 1, end=" ")
distance = costs[shortest_path]
print(f"\nДлина пути: {distance}")