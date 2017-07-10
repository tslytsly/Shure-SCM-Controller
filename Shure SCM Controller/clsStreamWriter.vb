Imports System.Net.Sockets

Public Class clsStreamWriter

    Public Sub Write(
        ByVal worker As System.ComponentModel.BackgroundWorker,
        ByVal e As System.ComponentModel.DoWorkEventArgs
    )

        'Try

        ' Create TcpClient
        Dim tcpPort As Int32 = 2202
            Dim client As New TcpClient("127.0.0.1", tcpPort)

            ' Get a client stream for reading and writing.
            '  Stream stream = client.GetStream();
            Dim stream As NetworkStream = client.GetStream()

            ' Initialise the class to get the info from the main form
            Dim dataOut As New frmMain.writeData



        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical)
        'End Try

    End Sub

    Public Sub messageToSend(ByVal message As String)

        ' Write anything we get to TcpServer as in bytes.
        Dim data As [Byte]() = System.Text.Encoding.ASCII.GetBytes(message)

        stream.Write(data, 0, data.Length)


    End Sub

End Class
