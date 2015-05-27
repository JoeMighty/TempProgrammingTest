Module Program

    ''' <summary>
    ''' Reverse words appearing within a sentence.
    ''' </summary>
    ''' <param name="str">Sentence with words in original order</param>
    Private Sub ReverseWords(Str As String)
        Console.WriteLine("Initial Phrase: {0}", Str)

        ' Write code to reverse the order of each word in the input phrase (str). For example
        '
        '     red green blue
        '
        ' would become
        '
        '     blue green red
        '
        ' You will need to modify the statement below to output the result.

        Console.WriteLine("Reversed Phrase: {0}", Str)
    End Sub

    Sub Main()
        ' You shouldn't need to modify this function.
        Dim inputPhrase As String = "This month I have mostly been eating fish fingers"
        ReverseWords(inputPhrase)
        Console.ReadKey()
    End Sub

End Module
