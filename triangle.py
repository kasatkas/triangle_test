import random

rows = 5
triangle = list(range(rows))

for i in range(rows):
    triangle[i] = list(random.sample(range(rows), i + 1))

def print_triangle(triangle):
    for i in range(rows):
        print(' '*(rows-i), triangle[i])
        
def count_way(triangle):
    for i in range(len(triangle) - 2, -1, -1):
        for j in range(i + 1):
            triangle[i][j] += max(triangle[i + 1][j], triangle[i + 1][j + 1])
    return triangle[0][0]

print_triangle(triangle)
print("\nMax weight: ", count_way(triangle))