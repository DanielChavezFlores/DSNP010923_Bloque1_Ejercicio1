Module Module1

    Sub Main(Args As String())

        Dim bandera As Boolean
        bandera = True
        Dim seleccion As String

        While (bandera = True)

            Dim Edad As Integer


            Console.WriteLine("Ingrese la edad")
            Edad = Console.ReadLine()

            While (Edad < 0 Or Edad > 120) 'se excluye el 0 de los valores no aceptados para incluir a los niños menores de un año

                Console.WriteLine("Ingrese una edad Valida")
                Edad = Console.ReadLine()
                Console.Clear()

            End While

            If (Edad >= 18) Then
                Console.WriteLine("Eres mayor de edad")
            Else
                Console.WriteLine("Eres menor de edad")

            End If

            Console.WriteLine("Desea evaluar otra edad?  Presione Y para continuar o cualquier otra tecla para salir")
            seleccion = Console.ReadLine()
            If (seleccion = "Y" Or seleccion = "y") Then
                bandera = True
            Else
                bandera = False 'Para salir del while externo
            End If
            Console.Clear()
        End While

    End Sub

End Module
