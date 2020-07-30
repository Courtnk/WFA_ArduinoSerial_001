' arduinoVBserial
' Arduino and Visual Basic: Receiving Data From the Arduino
' A simple example of sending and receiving data to and from an Arduino.  Built on the example by Martyn Currey / martyncurrey.com
' 
' Updated code for the Moto-Mast serial port remote control app written by Courtney E. Krehbiel
' Started July 25, 2020
'


Imports System
Imports System.IO.Ports



Public Class Form1
    ' Global variables
    Dim comPORT As String
    Dim receivedData As String = ""
    Dim connected As Boolean = False
    Dim count = 0

    ' When the program starts, add the available COM ports to the COMport drop down list
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        populateCOMport()
    End Sub

    'The refresh button updates the COMport list
    Private Sub refreshCOM_BTN_Click(sender As Object, e As EventArgs) Handles refreshCOM_CB_BTN.Click
        SerialPort1.Close()
        populateCOMport()
    End Sub

    Private Sub populateCOMport()
        comPORT = ""
        comPort_ComboBox.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            comPort_ComboBox.Items.Add(sp)
        Next
    End Sub

    Private Sub comPort_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comPort_ComboBox.SelectedIndexChanged
        If (comPort_ComboBox.SelectedItem <> "") Then
            comPORT = comPort_ComboBox.SelectedItem
        End If
    End Sub

    ' When the Connect button is clicked; if a COM port has been selected, connect and send out a HELLO message.
    ' Then wait for the Arduino to respond with its own HELLO.
    ' When the HELLO is received we are connected; change the button text to Dis-connect.
    Private Sub connect_BTN_Click(sender As Object, e As EventArgs) Handles connect_BTN.Click
        comPORT = comPort_ComboBox.SelectedItem
        If (connect_BTN.Text = "Connect") Then
            If (comPORT <> "") Then
                SerialPort1.Close()
                SerialPort1.PortName = comPORT
                SerialPort1.BaudRate = 9600
                SerialPort1.DataBits = 8
                SerialPort1.Parity = Parity.None
                SerialPort1.StopBits = StopBits.One
                SerialPort1.Handshake = Handshake.None
                SerialPort1.Encoding = System.Text.Encoding.Default
                SerialPort1.ReadTimeout = 10000

                SerialPort1.Open()

                'See if the Arduino is there
                count = 0
                SerialPort1.WriteLine("HL#")    'This should create a reply with the HELLO response. 
                connect_BTN.Text = "Connecting..."
                connecting_Timer.Enabled = True
            Else
                MsgBox("Select a COM port first", , "Com Port Error")
            End If
        Else
            'connect_BTN.Text = "Dis-connect"
            'close the connection a reset the button and timer label
            ProgressBar1.Value = 0
            Timer1.Enabled = False
            Timer_LBL.Text = "Timer: OFF"
            SerialPort1.Close()
            connected = False
            RichTextBox1.Text = "Port closed" & vbCrLf & vbCrLf & RichTextBox1.Text
            connect_BTN.Text = "Connect"
            populateCOMport()
        End If


    End Sub

    'The connecting_Timer waits for the Arduino to say HELLO.
    ' If HELLO is not received in 2 seconds display an error message.
    ' The connecting_Timer is only used for connecting
    Private Sub connecting_Timer_Tick(sender As Object, e As EventArgs) Handles connecting_Timer.Tick
        Dim increment As Integer = 0

        connecting_Timer.Enabled = False
        count = count + 1

        If (count <= 8) Then
            receivedData = SerialPort1.ReadExisting()

            If (Microsoft.VisualBasic.Left(receivedData, 5) = "HELLO") Then
                'if we get an HELLO from the Arduino then we are connected
                ' Run the progress bar for effect
                For increment = 0 To 100
                    ProgressBar1.Value = increment
                    System.Threading.Thread.Sleep(10)
                Next increment

                connected = True
                    RichTextBox1.Text = vbCrLf & "Port connected!"
                    receivedData = RichTextBox1.Text    'Added to keep port connected in serial port log
                    connect_BTN.Text = "Disconnect"
                    Timer1.Enabled = True
                    Timer_LBL.Text = "Timer: ON"
                    '               receivedData = ReceiveSerialData()
                    '               receivedData = ""

                Else
                    'start the timer again and keep waiting for a signal from the Arduino
                    connecting_Timer.Enabled = True
            End If


        Else
            'time out (8 * 250 = 2 seconds)
            RichTextBox1.Text &= vbCrLf & "ERROR" & vbCrLf & "Can not connect" & vbCrLf
            connect_BTN.Text = "Connect"
            populateCOMport()
        End If

    End Sub

    ' Timer "interrupt" to check for incoming serial port data
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Incoming As String
        '        Timer1.Enabled = False
        Incoming = SerialPort1.ReadExisting()
        If (Incoming <> "") Then
            receivedData = Incoming & receivedData
            RichTextBox1.Text = receivedData
        End If

    End Sub


    'Clear the RecievedData test box
    Private Sub clear_BTN_Click(sender As Object, e As EventArgs) Handles clear_BTN.Click
        RichTextBox1.Text = ""
    End Sub



    ' ============================
    ' Code for each of the buttons
    ' ============================
    '
    ' Set Height to attain
    Private Sub SetHeight_BTN_Click(sender As Object, e As EventArgs) Handles SetHeight_BTN.Click
        Dim Str2Write As String

        If (connected) Then
            If (SetHeight_TB.Text <> "") Then
                Str2Write = "SH#" & SetHeight_TB.Text
                SerialPort1.WriteLine(Str2Write)
                SetHeight_TB.Text = ""
            Else
                MsgBox("No Value Set")
            End If
        Else
            MsgBox("Not connected")
        End If
    End Sub

    ' Set Speed of motor
    Private Sub SetSpeed_BTN_Click(sender As Object, e As EventArgs) Handles SetSpeed_BTN.Click
        Dim Str2Write As String

        If (connected) Then
            If (SetSpeed_TB.Text <> "") Then
                Str2Write = "SS#" & SetSpeed_TB.Text
                SerialPort1.WriteLine(Str2Write)
                SetSpeed_TB.Text = ""
            Else
                MsgBox("No Value Set")
            End If
        Else
            MsgBox("Not connected")
        End If
    End Sub

    ' Set Direction of travel
    Private Sub SetDir_BTN_Click(sender As Object, e As EventArgs) Handles SetDir_BTN.Click
        If (connected) Then
            If (Up_RB.Checked) Then
                SerialPort1.WriteLine("SD#111")
                Up_RB.Checked = False
            ElseIf (Down_RB.Checked) Then
                SerialPort1.WriteLine("SD#000")
                Down_RB.Checked = False
            Else
                MsgBox("No Choice Made")
            End If
        Else
            MsgBox("Not connected")
        End If
    End Sub

    ' Give command to Run with settings
    Private Sub Run_BTN_Click(sender As Object, e As EventArgs) Handles Run_BTN.Click
        If (connected) Then
            SerialPort1.WriteLine("CR#")
        Else
            MsgBox("Not connected")
        End If
    End Sub

    ' Give HALT command to stop any/all run routines
    Private Sub Halt_BTN_Click(sender As Object, e As EventArgs) Handles Halt_BTN.Click
        If (connected) Then
            SerialPort1.WriteLine("CH#")
        Else
            MsgBox("Not connected")
        End If
    End Sub

    ' Give command to initiate "Auto-Up" self-piloted routine to 24 feet.
    Private Sub AutoUp_BTN_Click(sender As Object, e As EventArgs) Handles AutoUp_BTN.Click
        If (connected) Then
            SerialPort1.WriteLine("AU#")
        Else
            MsgBox("Not connected")
        End If
    End Sub

    ' Give command to initiate "Auto-Down" self-piloted routine to dock at 10 feet.
    Private Sub AutoDown_BTN_Click(sender As Object, e As EventArgs) Handles AutoDown_BTN.Click
        If (connected) Then
            SerialPort1.WriteLine("AD#")
        Else
            MsgBox("Not connected")
        End If
    End Sub

    ' Command to get Set Height
    Private Sub GetHeight_BTN_Click(sender As Object, e As EventArgs) Handles GetHeight_BTN.Click
        If (connected) Then
            SerialPort1.WriteLine("GH#")
        Else
            MsgBox("Not connected")
        End If
    End Sub

    ' Command to get Current Height
    Private Sub GetSpeed_BTN_Click(sender As Object, e As EventArgs) Handles GetSpeed_BTN.Click
        If (connected) Then
            SerialPort1.WriteLine("GS#")
        Else
            MsgBox("Not connected")
        End If
    End Sub

    ' Command to get Direction
    Private Sub GetDir_BTN_Click(sender As Object, e As EventArgs) Handles GetDir_BTN.Click
        If (connected) Then
            SerialPort1.WriteLine("GD#")
        Else
            MsgBox("Not connected")
        End If
    End Sub

    ' Command to get current height status
    Private Sub GetNowHt_BTN_Click(sender As Object, e As EventArgs) Handles GetNowHt_BTN.Click
        If (connected) Then
            SerialPort1.WriteLine("GN#")
        Else
            MsgBox("Not connected")
        End If
    End Sub


    'Add the contents of the text box and then send to the Arduino.
    'Does not clear the contents
    Private Sub send_BTN_Click(sender As Object, e As EventArgs) Handles send_BTN.Click
        If (connected) Then
            Dim tmp As String
            tmp = send_TB.Text
            SerialPort1.WriteLine(tmp)
        End If
    End Sub

End Class
