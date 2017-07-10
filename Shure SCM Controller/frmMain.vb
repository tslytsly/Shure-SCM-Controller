Imports System.Net.Sockets
Imports System.Threading

Public Class frmMain

    Public Class writeData
        Public asciiData As String
        Public messageToSend As Boolean
    End Class

    Private Sub btnMuteCh1_Click(sender As Object, e As EventArgs) Handles btnMuteCh1.Click
        'Translate the passed message into ASCII And store it as a Byte array.
        'Dim data As [Byte]() = System.Text.Encoding.ASCII.GetBytes("< SET 1 AUDIO_MUTE TOGGLE >")
        Dim write As New writeData

        write.asciiData = "< SET 1 AUDIO_MUTE TOGGLE >"
        write.messageToSend = True



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Text = ""
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '''''''OLD CODE
        ' Initialise the object that the background worker calls
        Dim SR As New clsStreamReader
        Dim SW As New clsStreamWriter

        ' Start background workers
        bgdWorkerNetRead.RunWorkerAsync(SR)
        bgdWorkerNetWrite.RunWorkerAsync(SW)

        ' Create TCPCLient
        Try
            Dim tcpPort As Int32 = 2202
            Dim client As New TcpClient("127.0.0.1", tcpPort)
            ' Get a client stream for reading and writing.
            Dim stream As NetworkStream = client.GetStream()

            ' Ask SCM for mute status of 8 mic channels
            For n As Integer = 1 To 8
                ' Translate the passed message into ASCII and store it as a Byte array.
                Dim data As [Byte]() = System.Text.Encoding.ASCII.GetBytes("< GET " & n & " AUDIO_MUTE >")

                ' Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length)
            Next

            client.Close()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        '''''''''''''




    End Sub



    Private Sub bgdWorkerNetRead_DoWork(
    ByVal sender As Object,
    ByVal e As System.ComponentModel.DoWorkEventArgs
  ) Handles bgdWorkerNetRead.DoWork

        ' This event handler is where the actual work is done.
        ' This method runs on the background thread.

        ' Get the BackgroundWorker object that raised this event.
        Dim worker As System.ComponentModel.BackgroundWorker
        worker = CType(sender, System.ComponentModel.BackgroundWorker)

        ' Get the clsStreamReader object and call the main method.
        Dim SR As clsStreamReader = CType(e.Argument, clsStreamReader)
        SR.Listen(worker, e)
    End Sub


    Private Sub bgdWorkerNetRead_RunWorkerCompleted(
    ByVal sender As Object,
    ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs
  ) Handles bgdWorkerNetRead.RunWorkerCompleted

    End Sub

    Private Sub bgdWorkerNetRead_ProgressChanged(
        ByVal sender As Object,
        ByVal e As System.ComponentModel.ProgressChangedEventArgs
      ) Handles bgdWorkerNetRead.ProgressChanged

        ' Initialise the Class that passes the data
        Dim dataIn As clsStreamReader.readData = CType(e.UserState, clsStreamReader.readData)

        ' If statements to check the incoming data for info we need

        ' Check for mute status updates, then check which channel and update the button color
        If dataIn.asciiData.StartsWith("< REP ") And dataIn.asciiData.Contains("AUDIO_MUTE ON >") Then
            ' Check which channel is being reported on and update the color
            Dim matches As Control() = Me.Controls.Find("btnMuteCh" & dataIn.asciiData.Chars(6), True)
            Dim btn As Button = DirectCast(matches(0), Button)
            btn.BackColor = Color.Red

            ' OLD CODE
            'If dataIn.asciiData.Chars(6) = "1"c Then
            '    btnMuteCh1.BackColor = Color.Red
            'End If

        ElseIf dataIn.asciiData.StartsWith("< REP ") And dataIn.asciiData.Contains("AUDIO_MUTE OFF >") Then
            ' Check which channel is being reported on and update the color
            Dim matches As Control() = Me.Controls.Find("btnMuteCh" & dataIn.asciiData.Chars(6), True)
            Dim btn As Button = DirectCast(matches(0), Button)
            btn.BackColor = Color.Green

            ' OLD CODE
            'If dataIn.asciiData.ToString.Chars(6) = "1"c Then
            '    btnMuteCh1.BackColor = Color.Green

        End If

        Me.TextBox1.AppendText(dataIn.asciiData.ToString)
    End Sub

    Private Sub bgdWorkerNetWrite_DoWork(
    ByVal sender As Object,
    ByVal e As System.ComponentModel.DoWorkEventArgs
  ) Handles bgdWorkerNetWrite.DoWork

        ' This event handler is where the actual work is done.
        ' This method runs on the background thread.

        ' Get the BackgroundWorker object that raised this event.
        Dim worker As System.ComponentModel.BackgroundWorker
        worker = CType(sender, System.ComponentModel.BackgroundWorker)

        ' Get the clsStreamWrite object and call the main method.
        Dim SW As clsStreamWriter = CType(e.Argument, clsStreamWriter)
        SW.Write(worker, e)
    End Sub


    Private Sub bgdWorkerNetWrite_RunWorkerCompleted(
    ByVal sender As Object,
    ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs
  ) Handles bgdWorkerNetWrite.RunWorkerCompleted

    End Sub

    Private Sub bgdWorkerNetWrite_ProgressChanged(
        ByVal sender As Object,
        ByVal e As System.ComponentModel.ProgressChangedEventArgs
      ) Handles bgdWorkerNetWrite.ProgressChanged

        ' Initialise the Class that passes the data
        Dim dataIn As clsStreamReader.readData = CType(e.UserState, clsStreamReader.readData)

        ' If statements to check the incoming data for info we need

        ' Check for mute status updates, then check which channel and update the button color
        If dataIn.asciiData.StartsWith("< REP ") And dataIn.asciiData.Contains("AUDIO_MUTE ON >") Then
            ' Check which channel is being reported on and update the color
            Dim matches As Control() = Me.Controls.Find("btnMuteCh" & dataIn.asciiData.Chars(6), True)
            Dim btn As Button = DirectCast(matches(0), Button)
            btn.BackColor = Color.Red


        ElseIf dataIn.asciiData.StartsWith("< REP ") And dataIn.asciiData.Contains("AUDIO_MUTE OFF >") Then
            ' Check which channel is being reported on and update the color
            Dim matches As Control() = Me.Controls.Find("btnMuteCh" & dataIn.asciiData.Chars(6), True)
            Dim btn As Button = DirectCast(matches(0), Button)
            btn.BackColor = Color.Green


        End If

        Me.TextBox1.AppendText(dataIn.asciiData.ToString)
    End Sub



End Class

