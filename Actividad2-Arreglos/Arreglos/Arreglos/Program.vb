Imports System

Module Program
    Dim tamano As Integer
    Sub Main(args As String())

        Dim opcion As Integer

        Console.WriteLine("1. Generar y rellenar un arreglo unidimensional,pedir la longitud del arreglo al usuario y debe contener valores pares partiendo desde el 2.")
        Console.WriteLine("2. Generar y rellenar un arreglo unidimensional,los valores a llenar será el resultado de la tabla de multiplicar del que desee el usuario.")
        Console.WriteLine("3. Generar y rellenar una matriz cuadrada de dimensión o longitud dada por el usuario, llenarla con números impares.")
        Console.WriteLine("4. Dada una matriz de dimensiones dadas por el usuario, llenarla con un valor único que daría el usuario y multiplicado por su posición.")
        Console.WriteLine("5. Generar una matriz cuadrada mostrar solo la diagonal principal con elemtos o (DP).")
        Console.WriteLine("6. Generar una matriz cuadrada mostrar solo la diagonal transversa con elementos o (DT).")
        Console.WriteLine("7. Generar una matriz cuadrada mostrar solo la diagonal principal y transversa.")
        Console.WriteLine("8. Genrar una matriz cuadrada mostrar solo las puntos de la matriz con elementos 0.")
        Console.WriteLine("9. Generar una matriz cuadrada dibujar un cuadrado con 0")
        Console.WriteLine("10. Generar una matriz cuadrada NxN (solo valores impares y mayores a 3) y generar el sgte relleno: N=5")
        Console.WriteLine("")

        Console.WriteLine("Digite la opción que decea:")
        Console.WriteLine("")

        opcion = Console.ReadLine()

        Select Case opcion
            Case 1
                Console.WriteLine("1. Generar y rellenar un arreglo unidimensional,pedir la longitud del arreglo al usuario y debe contener valores pares partiendo desde el 2.")
                arreglo1()
            Case 2
                Console.WriteLine("2. Generar y rellenar un arreglo unidimensional,los valores a llenar será el resultado de la tabla de multiplicar del que desee el usuario.")
                arreglo2()
            Case 3
                Console.WriteLine("3. Generar y rellenar una matriz cuadrada de dimensión o longitud dada por el usuario, llenarla con números impares.")
                arreglo3()
            Case 4
                Console.WriteLine("4. Dada una matriz de dimensiones dadas por el usuario, llenarla con un valor único que daría el usuario y multiplicado por su posición.")
                arreglo4()
            Case 5
                Console.WriteLine("5. Generar una matriz cuadrada mostrar solo la diagonal principal con elemtos o (DP).")
                arreglo5()
            Case 6
                Console.WriteLine("6. Generar una matriz cuadrada mostrar solo la diagonal transversa con elementos o (DT).")
                arreglo6()
            Case 7
                Console.WriteLine("7. Generar una matriz cuadrada mostrar solo la diagonal principal y transversa.")
                arreglo7()
            Case 8
                Console.WriteLine("8. Genrar una matriz cuadrada mostrar solo las puntos de la matriz con elementos 0.")
                arreglo8()
            Case 9
                Console.WriteLine("9. Generar una matriz cuadrada dibujar un cuadrado con 0")
                arreglo9()
            Case 10
                Console.WriteLine("10. Generar una matriz cuadrada NxN (solo valores impares y mayores a 3) y generar el sgte relleno: N=5")
                arreglo10()
            Case Else
                Console.WriteLine("Error verificar el número insertado")
        End Select

    End Sub
    Sub arreglo1()
        Dim par As Integer

        par = 2
        Do
            Console.WriteLine("Por favor digite el tamaño que decea el arreglo")
            tamano = Console.ReadLine()

            If (tamano < 3) Then
                Console.WriteLine("El tamaño del arreglo es muy pequeño")
            End If

        Loop While (tamano < 3)

        Dim array(tamano) As Integer
        For i = 0 To array.GetUpperBound(0) - 1
            array(i) += par
            par += 2
        Next
        'Se imprime el arreglo
        For i = 0 To array.GetUpperBound(0) - 1
            Console.WriteLine(array(i))
        Next
    End Sub
    Sub arreglo2()
        Dim multiplo As Integer

        Do
            Console.WriteLine("Por favor digite el tamaño que desea el arreglo")
            tamano = Console.ReadLine()
            If (tamano < 3) Then
                Console.WriteLine("El tamaño del arreglo es muy pequeño")
            End If
        Loop While (tamano < 3)

        Console.WriteLine("Por favor ingrese el multiplo el cual decea que se multiplique el arreglo")
        multiplo = Console.ReadLine()

        Dim arreglo(tamano) As Double

        For i = 0 To arreglo.GetUpperBound(0) - 1
            arreglo(i) = multiplo * (i + 1)
        Next
        'Se imprime el arreglo
        For i = 0 To arreglo.GetUpperBound(0) - 1
            Console.WriteLine(arreglo(i))
        Next
    End Sub
    Sub arreglo3()
        Dim impar As Integer

        impar = 1
        Do
            Console.WriteLine("Por favor digite el tamaño que desea en la matriz")
            tamano = Console.ReadLine()
            If (tamano < 2) Then
                Console.WriteLine("El tamaño de la matriz es muy pequeño")
            End If
        Loop While (tamano < 2)

        Dim matriz(tamano, tamano) As Integer

        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                matriz(i, j) = impar
                impar += 2
            Next
        Next
        'Se imprime la matriz
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & "|")
            Next
            Console.WriteLine()
        Next
    End Sub
    Sub arreglo4()
        Dim multiplo As Integer

        Do
            Console.WriteLine("Por favor digite el tamaño que desea en la matriz")
            tamano = Console.ReadLine()
            If (tamano < 2) Then
                Console.WriteLine("El tamaño de la matriz es muy pequeño")
            End If
        Loop While (tamano < 2)

        Console.WriteLine("Por favor digite el multiplo")
        multiplo = Console.ReadLine()

        Dim matriz(tamano, tamano) As String

        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                matriz(i, j) = multiplo * 1 & "-" & multiplo * j
            Next
        Next
        'Se imprime la matriz
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & "|")
            Next
            Console.WriteLine()
        Next
    End Sub
    Sub arreglo5()
        Dim matriz(10, 10) As String

        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                If (i = j) Then
                    matriz(i, j) = "0"
                End If
            Next
        Next
        'Se imprime la matriz
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & "|")
            Next
            Console.WriteLine()
        Next
    End Sub
    Sub arreglo6()
        Dim matriz(10, 10) As String

        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                If (i + j = matriz.GetUpperBound(0) - 1) Then
                    matriz(i, j) = "0"
                End If
            Next
        Next
        'Se imprime la matriz
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & "|")
            Next
            Console.WriteLine()
        Next
    End Sub
    Sub arreglo7()
        Dim matriz(10, 10) As String

        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                If (i = j) Then
                    matriz(i, j) = "$"
                ElseIf (i + j = matriz.GetUpperBound(0) - 1) Then
                    matriz(i, j) = "$"
                End If
            Next
        Next
        'Se imprime la matriz
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & "|")
            Next
            Console.WriteLine()
        Next
    End Sub
    Sub arreglo8()
        Dim matriz(10, 10) As String

        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                If (i = 0 Or i = matriz.GetUpperBound(0) - 1) And (j = 0 Or j = matriz.GetUpperBound(1) - 1) Then
                    matriz(i, j) = "0"
                End If
            Next
        Next
        'Se imprime la matriz
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & "|")
            Next
            Console.WriteLine()
        Next
    End Sub
    Sub arreglo9()
        Dim matriz(10, 10) As String

        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                If (i = 0 Or i = matriz.GetUpperBound(0) - 1 Or j = 0 Or j = matriz.GetUpperBound(1) - 1) Then
                    matriz(i, j) = "0"
                Else
                    matriz(i, j) = " "
                End If
            Next
        Next
        'Se imprime la matriz
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & "|")
            Next
            Console.WriteLine()
        Next
    End Sub
    Sub arreglo10()
        Dim media As Integer
        Do
            Console.WriteLine("Digita la dimensión de la matriz")
            tamano = Console.ReadLine()
            If (tamano <= 3 Or tamano Mod 2 = 0) Then
                Console.WriteLine("La dimensión debe ser impar y mayor a 3")
            End If
        Loop While (tamano <= 3 Or tamano Mod 2 = 0)
        Dim matriz(tamano, tamano) As Integer
        media = tamano / 2 + 1
        For i = 0 To media
            For j = i + 1 To tamano - 1 - (i + 1)
                matriz(i, j) = 1
                matriz(tamano - i - 1, j) = 1
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                If (matriz(i, j) <> 1) Then
                    matriz(i, j) = tamano - 1
                End If
                Console.Write(matriz(i, j) & "")
            Next
            Console.WriteLine()
        Next
    End Sub
End Module
