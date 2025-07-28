def numero_primo(numero):
    if numero <= 1:
        return False
    for i in range(2, int(numero**0.5) + 1):
        if numero % i == 0:
            return False    
    return True
num = (int(input("ingrese un numero: ")))
if numero_primo(num):

    print(f"el numero {num} es primo")
else:
    print(f"el numero {num} no es primo")