
Imports System.Net.Sockets
Imports System.Threading

Partial Public NotInheritable Class Client
    ' Called by producers to send data over the socket.

    Public Sub SendData(data As Byte())
        _sender.SendData(data)
    End Sub

    ' Consumers register to receive data.
    Public Event DataReceived As EventHandler(Of DataReceivedEventArgs)

    Public Sub New()
        _client = New TcpClient("127.0.0.1", 2202)
        _stream = _client.GetStream()

        _receiver = New Receiver(_stream)
        _sender = New Sender(_stream)

        AddHandler _receiver.DataReceived, AddressOf OnDataReceived
    End Sub

    Private Sub OnDataReceived(sender As Object, e As DataReceivedEventArgs)
        While (True)
            RaiseEvent DataReceived(Me, e)
        End While
        ' re-raise event
    End Sub

    Private _client As TcpClient
    Private _stream As NetworkStream
    Private _receiver As Receiver
    Private _sender As Sender






    Private NotInheritable Class Receiver
        Friend Event DataReceived As EventHandler(Of DataReceivedEventArgs)

        Friend Sub New(stream As NetworkStream)
            _stream = stream
            _thread = New Thread(AddressOf Run)
            _thread.Start()
        End Sub

        Private Sub Run()
            ' main thread loop for receiving data...

        End Sub

        Private _stream As NetworkStream
        Private _thread As Thread
    End Class



    Private NotInheritable Class Sender
        Friend Sub SendData(data As Byte())
            ' transition the data to the thread and send it...
        End Sub

        Friend Sub New(stream As NetworkStream)
            _stream = stream
            _thread = New Thread(AddressOf Run)
            _thread.Start()
        End Sub

        Private Sub Run()
            ' main thread loop for sending data...
        End Sub

        Private _stream As NetworkStream
        Private _thread As Thread
    End Class
End Class

