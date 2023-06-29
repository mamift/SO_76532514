Imports OneTrain.infofer
Imports System.Xml
Imports System.Xml.Serialization

Module Module1

    Sub Main(args As String())
        Dim fullPath = args.First()

        Dim obj As PathDetailsMessage
        Dim ser As New XmlSerializer(GetType(PathDetailsMessage))
        Using reader As XmlReader = XmlReader.Create(fullPath)
            obj = CType(ser.Deserialize(reader), PathDetailsMessage)
        End Using

        Console.WriteLine(obj)

        If (obj.PathInformation Is Nothing) Then
            Console.WriteLine("obj.PathInformation was null")
        End If

        If obj.CFRTrainInfo Is Nothing Then
            Console.WriteLine("obj.CFRTrainInfo was null")
        End If

    End Sub

End Module
