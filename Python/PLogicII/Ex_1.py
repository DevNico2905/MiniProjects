# Make a program that allows the user to enter as many integers as they want until they enter a zero (sentinel value). The program should ultimately print the sum of the even numbers, the sum of the odd numbers, and the average of all the numbers.
import os,sys
print("\t\t¡Welcome to our game!\n")
print("Enter as many integers as you want until you enter a zero (sentinel value).\n")
numbers_array = []
even_numbers = 0
odd_numbers = 0
total_amount = 0

while True:
    num_1 = int(input("Enter a number: "))
    if num_1 == 0:
        print("\nYou entered the number 0, game over.\n")
        break;
    numbers_array.append(num_1)
    total_amount += num_1
    if num_1 % 2 == 0:
        even_numbers += num_1
    else:
        odd_numbers += num_1

if len(numbers_array) > 0:
    average = total_amount / len(numbers_array)
else:
    average = 0


print(f"- Sum of the even numbers: {even_numbers}")
print(f"- Sum of the odd numbers: {odd_numbers}")
print(f"- Average of all the numbers: {average}\n")

input("Presione Enter para salir...")
os.system("CLS")