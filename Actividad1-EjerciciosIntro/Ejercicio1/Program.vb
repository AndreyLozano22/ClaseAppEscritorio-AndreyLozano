Imports System

Module Program
    Sub Main(args As String())
        Dim opcion As Integer
        Console.WriteLine("1. Determinar si el número es positivo y par")
        Console.WriteLine("2. Calcular el cubo de un Número entero ingresado por el usuauio solo sí, el número es multiplo de 3 y 5")
        Console.WriteLine("3. Calcular el cuadradro de un número entero ingresado por el usuario solo sí,el número es múltiplo de 4 y 16")
        Console.WriteLine("4. Realizar un algoritmo que permita dar una ponderación cualitativa, según una nota cuantitativa:.")
        Console.WriteLine("      Rango: 0 y 40:Pésimo, Aplazado sin oportunidad")
        Console.WriteLine("      Rango: 41 y 45: Deficiente, Aplazado a reparación")
        Console.WriteLine("      Rango: 46y 50:Bajo, Aplazadorepetir examen")
        Console.WriteLine("      Rango: 51 y 60: Regular, No aplazado – Remedial")
        Console.WriteLine("      Rango: 61 y 70: Bien")
        Console.WriteLine("      Rango: 71 y 80: Muy Bien")
        Console.WriteLine("      Rango: 81 y100:Excelente")
        Console.WriteLine("5. Calcular el pago por galones degasolinade una estaciónde servicio, según el tipo de gasolina: ")
        Console.WriteLine("      Gasolina Premium Extra: 1 litro: 5.000 pesos")
        Console.WriteLine("      Gasolina Premium: 1 litro: 3.900 pesos")
        Console.WriteLine("      Gasolina Corriente: 1 litro 3.200 pesos")
        Console.WriteLine("  Nota: Se debe mostrar la cantidad de gasolina expresada en galones y litros, el cliente pide en galones.")
        Console.WriteLine("6. Calcular el monto a pagar por el servicio de internet según el nivel del cliente y la cantidad de MB:")
        Console.WriteLine("  Cada MB tiene un precio de:")
        Console.WriteLine("      Nivel 1: 5000 mil pesos")
        Console.WriteLine("      Nivel 2: 7000 mil pesos")
        Console.WriteLine("      Nivel 3: 9000 mil pesos")
        Console.WriteLine("      Nivel 4: 15000 mil pesos")
        Console.WriteLine("      Nivel 5: 22000 mil pesos")
        Console.WriteLine("      Nivel 6: 30000mil pesos")
        Console.WriteLine("      Todos los demás niveles 35000 mil pesos")
        Console.WriteLine("7. Calcular el sueldo a pagar de un trabajador dado que se debe ingresar la cantidad de horas trabajadas y el valor de la hora en pesos. ")
        Console.WriteLine("8. Calcular el interés a pagar por un dinero,colocado a generar interés diario.  Se debe ingresar la cantidad de dinero, los días que lleva generando interés")
        Console.WriteLine("   y el interés.  Se debe imprimir el interés y la cantidad de dinero más el interés. ")
        Console.WriteLine("9. Leer dos números enteros y determinar ¿cuálde los dos es positivo?")
        Console.WriteLine("10. Realizar un pseudocódigo que sume 3 números e imprima la suma.")
        Console.WriteLine("11. Realizar un pseudocódigo que sume 3 números impares e imprima la suma. ")
        Console.WriteLine("12.Dado una compra realizada calcular: el iva e imprimir: la compra sin iva, el iva en pesos y el monto con el iva.  Tomar en cuenta que el iva es el 19%. ")
        Console.WriteLine("")
        Console.WriteLine("")

        Console.WriteLine("Introduzca el número correspondiente")
        opcion = Console.ReadLine
        Console.WriteLine("La opción seleccionada es: {0}", opcion)
        Select Case opcion
            Case 1
                Console.WriteLine("1. Determinar si el número es positivo y par")
                punto1()
            Case 2
                Console.WriteLine("2. Calcular el cubo de un Número entero ingresado por el usuauio solo sí, el número es multiplo de 3 y 5")
                punto2()
            Case 3
                Console.WriteLine("3. Calcular el cuadradro de un número entero ingresado por el usuario solo sí,el número es múltiplo de 4 y 16")
                punto3()
            Case 4
                Console.WriteLine("4. Realizar un algoritmo que permita dar una ponderación cualitativa, según una nota cuantitativa:.")
                Console.WriteLine("      Rango: 0 y 40:Pésimo, Aplazado sin oportunidad")
                Console.WriteLine("      Rango: 41 y 45: Deficiente, Aplazado a reparación")
                Console.WriteLine("      Rango: 46y 50:Bajo, Aplazadorepetir examen")
                Console.WriteLine("      Rango: 51 y 60: Regular, No aplazado – Remedial")
                Console.WriteLine("      Rango: 61 y 70: Bien")
                Console.WriteLine("      Rango: 71 y 80: Muy Bien")
                Console.WriteLine("      Rango: 81 y100:Excelente")
                punto4()
            Case 5
                Console.WriteLine("5. Calcular el pago por galones degasolinade una estaciónde servicio, según el tipo de gasolina: ")
                Console.WriteLine("      Gasolina Premium Extra: 1 litro: 5.000 pesos")
                Console.WriteLine("      Gasolina Premium: 1 litro: 3.900 pesos")
                Console.WriteLine("      Gasolina Corriente: 1 litro 3.200 pesos")
                Console.WriteLine("  Nota: Se debe mostrar la cantidad de gasolina expresada en galones y litros, el cliente pide en galones.")
                punto5()
            Case 6
                Console.WriteLine("6. Calcular el monto a pagar por el servicio de internet según el nivel del cliente y la cantidad de MB:")
                Console.WriteLine("  Cada MB tiene un precio de:")
                Console.WriteLine("      Nivel 1: 5000 mil pesos")
                Console.WriteLine("      Nivel 2: 7000 mil pesos")
                Console.WriteLine("      Nivel 3: 9000 mil pesos")
                Console.WriteLine("      Nivel 4: 15000 mil pesos")
                Console.WriteLine("      Nivel 5: 22000 mil pesos")
                Console.WriteLine("      Nivel 6: 30000mil pesos")
                Console.WriteLine("      Todos los demás niveles 35000 mil pesos")
                punto6()
            Case 7
                Console.WriteLine("7. Calcular el sueldo a pagar de un trabajador dado que se debe ingresar la cantidad de horas trabajadas y el valor de la hora en pesos. ")
                punto7()
            Case 8
                Console.WriteLine("8. Calcular el interés a pagar porun dinero,colocado a generar interés diario.  Se debe ingresar la cantidad de dinero, los días que lleva generando interés")
                Console.WriteLine("   y el interés.  Se debe imprimir el interés y la cantidad de dinero más el interés. ")
                punto8()
            Case 9
                Console.WriteLine("9. Leer dos números enteros y determinar ¿cuálde los dos es positivo?")
                punto9()
            Case 10
                Console.WriteLine("10. Realizar un pseudocódigo que sume 3 números e imprima la suma.")
                punto10()
            Case 11
                Console.WriteLine("11. Realizar un pseudocódigo que sume 3 números impares e imprima la suma.")
                punto11()
            Case 12
                Console.WriteLine("12.Dado una compra realizada calcular: el iva e imprimir: la compra sin iva, el iva en pesos y el monto con el iva.  Tomar en cuenta que el iva es el 19%. ")
                punto12()
        End Select
    End Sub
    Sub punto1()
        Dim num1 As Integer
        Console.WriteLine("Introduzca un numero")
        num1 = Console.ReadLine
        Const positivo As Integer = 1
        If (num1 >= positivo) And (num1 Mod 2) Then
            Console.WriteLine("El número es positivo y par")
        Else
            Console.WriteLine("ERROR, El número no cumple con las condiciones")
        End If

    End Sub
    Sub punto2()
        Dim cubo As Integer
        Dim num1 As Integer
        Console.WriteLine("Introduzca un numero")
        num1 = Console.ReadLine
        If (num1 Mod 3 = 0 And num1 Mod 5 = 0) Then
            cubo = num1 ^ 3
            Console.WriteLine("El número ingresado es: {0} y el cubo es: {1}", num1, cubo)
        Else
            Console.WriteLine("ERROR, El número no cumple con las condiciones")
        End If
    End Sub
    Sub punto3()
        Dim cuadrado As Integer
        Dim num1 As Integer
        Console.WriteLine("Introduzca un numero")
        num1 = Console.ReadLine
        If (num1 Mod 4 = 0 And num1 Mod 16 = 0) Then
            Console.WriteLine("Entro al if")
            cuadrado = num1 ^ 2
            Console.WriteLine("El número ingresado es: {0} y el cuadrado es: {1}", num1, cuadrado)
        Else
            Console.WriteLine("ERROR, El número no cumple con las condiciones")
        End If
    End Sub
    Sub punto4()
        Dim nota As Double
        Console.WriteLine("Ingrese la nota que decea hacer la ponderación Cualitativa")
        nota = Console.ReadLine
        If (nota >= 0 And nota <= 40) Then
            Console.WriteLine("Pésimo, Aplazado sin oportunidad")
        ElseIf (nota >= 41 And nota <= 45) Then
            Console.WriteLine(" Deficiente, Aplazado a reparación")
        ElseIf (nota >= 46 And nota <= 50) Then
            Console.WriteLine("Bajo, Aplazado repetir examen")
        ElseIf (nota >= 51 And nota <= 60) Then
            Console.WriteLine("Regular, No aplazado – Remedial")
        ElseIf (nota >= 61 And nota <= 70) Then
            Console.WriteLine("Bien")
        ElseIf (nota >= 71 And nota <= 80) Then
            Console.WriteLine("Muy Bien")
        ElseIf (nota >= 81 And nota <= 100) Then
            Console.WriteLine("Excelente")
        Else
            Console.WriteLine("Error, Verificar el dato insertado")
        End If
    End Sub
    Sub punto5()
        Dim opcion As Integer

        Dim precioGaPExtra As Integer
        Dim precioGaPre As Integer
        Dim precioGaCoo As Integer
        Dim litro As Double

        Dim precioNuevoGaPExtra As Integer
        Dim precioNuevoGaPre As Integer
        Dim precioNuevoGaCoo As Integer
        Dim precioLitro As Integer
        Dim precioGalon As Integer

        Dim cantGalones As Double
        Dim cantLitros As Double

        precioGaPExtra = 5000
        precioGaPre = 3900
        precioGaCoo = 3200
        litro = 3.78

        Console.WriteLine("Inserte la cantidad de galones")
        cantGalones = Console.ReadLine

        Console.WriteLine("1. Gasolina Premium Extra: 1 Litro: $5.000")
        Console.WriteLine("2. Gasolina Premium : 1 Litro: $3.900")
        Console.WriteLine("3. Gasolina Corriente: 1 Litro: $3.200")

        Console.WriteLine("Inserte el tipo de gasolina")
        opcion = Console.ReadLine

        Select Case opcion
            Case 1
                Console.WriteLine("1. Gasolina Premium Extra: 1 Litro: $5.000")
                Console.WriteLine("Cantidad de galones insertado {0}", cantGalones)
                cantLitros = cantGalones / litro
                Console.WriteLine("Cantidad de litros insertado {0}", cantLitros)
                precioLitro = cantLitros * precioGaPExtra
                Console.WriteLine("Valor a pagar (Litros): ${0}", precioLitro)
                precioGalon = cantGalones * precioNuevoGaPExtra
                Console.WriteLine("Valor a pagar (Galones): ${0}", precioGalon)
            Case 2
                Console.WriteLine("2. Gasolina Premium : 1 Litro: $3.900")
                Console.WriteLine("Cantidad de galones insertado {0}", cantGalones)
                cantLitros = cantGalones / litro
                Console.WriteLine("Cantidad de litros insertado {0}", cantLitros)
                precioLitro = cantLitros * precioGaPre
                Console.WriteLine("Valor a pagar (Litros): $ {0}", precioLitro)
                precioGalon = cantGalones * precioNuevoGaPre
                Console.WriteLine("Valor a pagar (Galones): $ {0}", precioGalon)
            Case 3
                Console.WriteLine("3. Gasolina Corriente: 1 Litro: $3.200")
                Console.WriteLine("Cantidad de galones insertado {0}", cantGalones)
                cantLitros = cantGalones / litro
                Console.WriteLine("Cantidad de litros insertado {0}", cantLitros)
                precioLitro = cantLitros * precioGaCoo
                Console.WriteLine("Valor a pagar (Litros): $ {0}", precioLitro)
                precioGalon = cantGalones * precioNuevoGaCoo
                Console.WriteLine("Valor a pagar (Galones): $ {0}", precioGalon)
        End Select
    End Sub
    Sub punto6()
        Dim nivelMB As Integer

        Console.WriteLine("Por favor revise su nivel de MB")
        Console.WriteLine("")
        Console.WriteLine("Nivel 1")
        Console.WriteLine("Nivel 2")
        Console.WriteLine("Nivel 3")
        Console.WriteLine("Nivel 4")
        Console.WriteLine("Nivel 5")
        Console.WriteLine("Nivel 6")
        Console.WriteLine("Nivel 7")
        Console.WriteLine("")
        Console.WriteLine("Ingrese su nivel de MB")
        nivelMB = Console.ReadLine
        Select Case nivelMB
            Case 1
                Console.WriteLine("Su nive es: Nivel 1")
                Console.WriteLine("Le toca pagar: $50.000 pesos")
            Case 2
                Console.WriteLine("Su nive es: Nivel 2")
                Console.WriteLine("Le toca pagar: $70.000 pesos")
            Case 3
                Console.WriteLine("Su nive es: Nivel 3")
                Console.WriteLine("Le toca pagar: $90.000 pesos")
            Case 4
                Console.WriteLine("Su nive es: Nivel 4")
                Console.WriteLine("Le toca pagar: $150.000 pesos")
            Case 5
                Console.WriteLine("Su nive es: Nivel 5")
                Console.WriteLine("Le toca pagar: $220.000 pesos")
            Case 6
                Console.WriteLine("Su nive es: Nivel 6")
                Console.WriteLine("Le toca pagar: $300.000 pesos")
            Case 7
                Console.WriteLine("Su nive es: Nivel 7")
                Console.WriteLine("Le toca pagar: $350.000 pesos")
        End Select

    End Sub
    Sub punto7()

        Dim cantHoras As Double
        Dim valorHora As Double
        Dim sueldoF As Double

        Console.WriteLine("Inserte la cantidad de horas trabajadas")
        cantHoras = Console.ReadLine

        Console.WriteLine("Inserte el valor por hora (sin puntos, ni comas)")
        valorHora = Console.ReadLine

        sueldoF = cantHoras * valorHora

        Console.WriteLine("El valor a pagar es: {0}", sueldoF)
    End Sub
    Sub punto8()

        Dim dinero As Integer
        Dim interes As Double
        Dim newInteres As Double
        Dim cantDias As Integer
        Dim valorInteresTotal As Double
        Dim valorInteres As Integer
        Dim valorPagar As Double

        Console.WriteLine("Inserte el valor del prestamo")
        dinero = Console.ReadLine
        Console.WriteLine("Inserte el interes sin el simbolo %")
        interes = Console.ReadLine
        Console.WriteLine("Inserte la cantidad de dias del prestamo")
        cantDias = Console.ReadLine

        newInteres = interes / 100
        valorInteres = dinero * newInteres
        valorInteresTotal = valorInteres * cantDias
        valorPagar = dinero + valorInteresTotal

        Console.WriteLine("Valor prestado: {0}", dinero)
        Console.WriteLine("Interes: {0}%", interes)
        Console.WriteLine("Cantidad de dias del prestamo:{0}", cantDias)
        Console.WriteLine("Valor total a pagar por el prestamo: {0} ", valorPagar)

    End Sub
    Sub punto9()
        Dim num1 As Integer
        Dim num2 As Integer
        Dim positivo As Integer

        positivo = 1

        Console.WriteLine("Inserte el primer número")
        num1 = Console.ReadLine
        Console.WriteLine("Inserte el segundo número")
        num2 = Console.ReadLine


        If (num1 >= positivo And num2 >= positivo) Then
            Console.WriteLine("Ambos números son positivos")
        ElseIf (num1 >= positivo) Then
            Console.WriteLine("El número 1 es: {0} y es POSITIVO", num1)
        ElseIf (num2 >= positivo) Then
            Console.WriteLine("El número 2 es: {0} y es POSITIVO", num2)
        End If
    End Sub
    Sub punto10()
        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double
        Dim suma As Double

        Console.WriteLine("Inserte el primer número")
        num1 = Console.ReadLine
        Console.WriteLine("Inserte el segundo número")
        num2 = Console.ReadLine
        Console.WriteLine("Inserte el tercer número")
        num3 = Console.ReadLine

        Console.WriteLine("Los numeros insertados son:  Numero 1 : {0} Numero 2 : {1} Numero 3 : {2}", num1, num2, num3)

        suma = num1 + num2 + num3
        Console.WriteLine("La suma de los tres números es: {0}", suma)
    End Sub
    Sub punto11()
        Dim num As Double
        Dim suma As Double

        For i As Integer = 0 To 2 Step 1
            Console.WriteLine("Digite un número {0}", (i + 1))
            num = Console.ReadLine
            If (num Mod 2 <> 0) Then
                suma += num
            Else
                Console.WriteLine("Verifique el número digitado")
                i -= 1
            End If
        Next
        Console.WriteLine("El resultado de la Suma es: {0}", suma)

    End Sub
    Sub punto12()
        Dim valorCompra As Double
        Const iva As Double = 0.19
        Dim compraIva As Double
        Dim valorTotal As Double

        Console.WriteLine("Digite el valor total de la compra")
        valorCompra = Console.ReadLine
        compraIva = valorCompra * iva
        valorTotal = valorCompra + compraIva

        Console.WriteLine("El valor de la compra sin IVA: {0}", valorCompra)
        Console.WriteLine("El valor de IVA a pagar: {0}", compraIva)
        Console.WriteLine("El valor total a pagar es: {0}", valorTotal)
    End Sub
End Module