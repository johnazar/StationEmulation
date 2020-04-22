Public Class FrmStation

    Dim MachineConnect As Boolean = False
    Dim index As UInteger = 0
    Dim Obnovit As UInt16 = 0
    Dim StepperSpd As UInt16 = 0
    Dim StpSpdMsgReply As String = vbNullString

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click

        TmrConnect.Enabled = True
        TmrConnect.Start()

        SerBluetooth.PortName = CmbCOMPorts.SelectedItem.ToString()



        SerBluetooth.BaudRate = 9600
        SerBluetooth.DataBits = 8
        SerBluetooth.Parity = IO.Ports.Parity.None
        SerBluetooth.StopBits = IO.Ports.StopBits.One

        SerBluetooth.Open()

        If SerBluetooth.IsOpen() Then
            lblSerialDisp.BackColor = Color.LightSkyBlue
            lblSerialDisp.Text = "ON"

            'bolConn2OK = True

            'If bolConn1OK = True Then BtnStartSend.Enabled = True
        End If

        BtnConnect.Enabled = False
        BtnClose.Enabled = True

        TxtReceived.Text = ""
    End Sub

    Private Sub TmrConnect_Tick(sender As Object, e As EventArgs) Handles TmrConnect.Tick
        Dim strData As String = vbNullString
        strData = SerBluetooth.ReadExisting()
        index = 0

        TxtReceived.Text += strData
        LblReadSize.Text = Len(strData)


        While (index < Len(strData))
            TxtRecHex.Text += Hex(Asc(strData(index))) + " "

            index += 1
        End While

        index = 0
        'Get Commands Fill Data
        While ((index < strData.Length()) And (Len(strData) = 5))

            'Update message handler
            If ((strData(index) = "P") And (strData(index + 1) = "I") And (Hex(Asc(strData(index + 4))) = 0)) Then

                If ((Hex(Asc(strData(index + 2))) = 0) And (Asc(strData(index + 3))) = 0) Then

                    Obnovit += 1
                    LST.BackColor = Color.Green
                    LST.Text = Obnovit.ToString

                    SerBluetooth.Write("ATPI")
                Else

                    LST.BackColor = Color.WhiteSmoke

                End If

                'Stepper + message handler

                If (Asc(strData(index + 2)) = 1) Then

                    StepperSpd += 1
                    LblStep.BackColor = Color.Green
                    LblStep.Text = StepperSpd.ToString

                    LblStepSPD.Text = Asc(strData(index + 3)).ToString
                    StpSpdMsgReply = "ATFS" + strData(index + 3)
                    SerBluetooth.Write(StpSpdMsgReply)

                Else

                    LblStep.BackColor = Color.WhiteSmoke

                End If

                index += 5
            End If


        End While
    End Sub

    Private Sub FrmStation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        TmrConnect.Stop()
        TmrConnect.Enabled = False
        MachineConnect = False
        SerBluetooth.Close()

        If Not SerBluetooth.IsOpen() Then
            lblSerialDisp.BackColor = Color.White
            lblSerialDisp.Text = "OFF"
        End If

        BtnConnect.Enabled = True
        BtnClose.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub TxtRecHex_TextChanged(sender As Object, e As EventArgs) Handles TxtRecHex.TextChanged

    End Sub
End Class