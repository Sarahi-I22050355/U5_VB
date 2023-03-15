Module Module1
    Sub Main()
        ' Declaration of the one-dimensional array to store names and identification numbers
        Dim students(4) As String

        ' Declaration of the multidimensional array to store the grades for each student
        Dim grades(4, 3) As Integer

        ' Ask the user to input data for each student
        For i As Integer = 0 To students.Length - 1
            Console.Clear()
            Console.WriteLine("Enter name and identification number for student " & (i + 1) & ":")
            students(i) = Console.ReadLine()

            For j As Integer = 0 To grades.GetLength(1) - 1
                Console.WriteLine("Enter grade for subject " & (j + 1) & " for student " & (i + 1) & ":")
                grades(i, j) = Convert.ToInt32(Console.ReadLine())
            Next

            Console.WriteLine()
        Next

        ' Print the names, identification numbers, grades, and final average for each student in a table
        Console.WriteLine("|{0,-20}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|{5,-10}|", "Student", "Subject 1", "Subject 2", "Subject 3", "Subject 4", "Final Average")

        For i As Integer = 0 To students.Length - 1
            Dim totalGrade As Integer = 0

            For j As Integer = 0 To grades.GetLength(1) - 1
                totalGrade += grades(i, j)
            Next

            Dim finalAverage As Double = totalGrade / grades.GetLength(1)

            Console.WriteLine("|{0,-20}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|{5,-10}   |", students(i), grades(i, 0), grades(i, 1), grades(i, 2), grades(i, 3), finalAverage)
        Next

        Console.ReadLine()
    End Sub
End Module

