Imports System.Windows.Forms

Module GetScreenSize

    Sub Main()
        Dim rectangle  = Screen.PrimaryScreen.Bounds
        Dim workingArea  = Screen.PrimaryScreen.WorkingArea

        Console.WriteLine("Bounds: Height: " & rectangle.Height & ", Width: " & rectangle.Width)
        Console.WriteLine("WorkingArea: Height: " & workingArea.Height & ", Width: " & workingArea.Width)

        Console.ReadKey()
    End Sub

End Module
