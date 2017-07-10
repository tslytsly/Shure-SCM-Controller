Imports System.Net.Sockets

Public Class clsStreamReader

    Public Class readData
        Public asciiData As String
    End Class


    Sub Listen(
        ByVal worker As System.ComponentModel.BackgroundWorker,
        ByVal e As System.ComponentModel.DoWorkEventArgs
    )
        ' Create TCPCLient
        Dim tcpPort As Int32 = 2202
        Dim client As New TcpClient("127.0.0.1", tcpPort)

        ' Get a client stream for reading and writing.
        '  Stream stream = client.GetStream();
        Dim stream As NetworkStream = client.GetStream()

        ' Initialise the class to pass the info back to the main form
        Dim dataIn As New readData


        While (True)

            ' Receive the TcpServer.response.
            ' Buffer to store the response bytes.
            Dim data As [Byte]()
            data = New [Byte](256) {}


            ' String to store the response ASCII representation.
            Dim responseData As [String] = [String].Empty

            ' Read the first batch of the TcpServer response bytes.
            Dim bytes As Int32 = stream.Read(data, 0, data.Length)
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes)

            ' raise an event to pass the inbound data back to the main form
            dataIn.asciiData = responseData
            worker.ReportProgress(0, dataIn)


        End While
    End Sub

End Class
