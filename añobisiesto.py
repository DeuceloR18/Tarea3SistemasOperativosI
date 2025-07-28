def anio_bisiesto(anio):
    """
    Determina si un año es bisiesto.
    
    Un año es bisiesto si:
    - Es divisible por 4.
    - No es divisible por 100, a menos que también sea divisible por 400.
    
    :param anio: Año a evaluar.
    :return: True si el año es bisiesto, False en caso contrario.
    """
    if (anio % 4 == 0 and anio % 100 != 0) or (anio % 400 == 0):
        return True
    return False
anio = int(input("ingrese un año: "))
if anio_bisiesto(anio):
    print(f"el año {anio} es bisiesto")
else:
    print(f"el año {anio} no es bisiesto")