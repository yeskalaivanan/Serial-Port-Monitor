Imports System.ComponentModel
Imports System.IO.Ports
Imports System.IO
Public Class Form1
    Private WithEvents serialPort As New SerialPort()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initiallization()
        Graphics()
    End Sub
    Private Sub Graphics()

        btn_connect.FlatStyle = FlatStyle.Popup ' Gives a 3D look
        btn_connect.FlatAppearance.BorderSize = 2
        btn_connect.FlatAppearance.BorderColor = Color.DarkGray

        btn_send.FlatStyle = FlatStyle.Popup ' Gives a 3D look
        btn_send.FlatAppearance.BorderSize = 2
        btn_send.FlatAppearance.BorderColor = Color.DarkGray

    End Sub
    Private Sub initiallization()
        LoadComPorts()
        btn_connect.Text = "Connect"
        Console.WriteLine("Program is Started")
        clearbox()
        ListBox1.Items.Add("AT")
        ListBox1.Items.Add("AT+CSQ")
        ListBox1.Items.Add("AT+QFLST=""*""")

        cmb_baud.Items.Add("9600")
        cmb_baud.Items.Add("115200")
        cmb_baud.SelectedIndex = 1

        cmb_bit.Items.Add(7)
        cmb_bit.Items.Add(8)
        cmb_bit.SelectedIndex = 1

        cmb_parity.Items.Add("None")
        cmb_parity.Items.Add("Add")
        cmb_parity.Items.Add("Even")
        cmb_parity.SelectedIndex = 0

        ToolStripStatusLabel1.Text = ""
        ToolStripStatusLabel2.Text = ""
        ToolStripStatusLabel3.Text = ""
        '' Set font for RichTextBox
        'rtxt_char.Font = New Font("Consolas", 11, FontStyle.Regular)
        '' Set font for RichTextBox
        'rtxt_hex.Font = New Font("Consolas", 11, FontStyle.Regular)
    End Sub
    Private Sub LoadComPorts()
        ' Clear existing items
        cmb_port.Items.Clear()

        ' Get the list of available COM ports and add them to the ComboBox
        For Each port As String In My.Computer.Ports.SerialPortNames
            cmb_port.Items.Add(port)
        Next

        ' Optionally, select the first item (if any are available)
        If cmb_port.Items.Count > 0 Then
            cmb_port.SelectedIndex = 0
        End If
    End Sub

    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click

        ' Toggle connection state based on whether the SerialPort is open
        If serialPort.IsOpen Then
            ' Disconnect: Close the COM port
            Try
                serialPort.Close()
                btn_connect.Text = "Connect"
                ToolStripStatusLabel2.Text = "COM port disconnected successfully."
                'rtxt_char.Text += ToolStripStatusLabel2.Text & vbCrLf
                AppendTextToRichTextBox($"{ToolStripStatusLabel2.Text}" & vbCrLf, Color.Red)
                cmb_port.Enabled = True
                cmb_baud.Enabled = True
                cmb_parity.Enabled = True
                cmb_bit.Enabled = True
            Catch ex As Exception
                MessageBox.Show($"Failed to disconnect COM port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                rtxt_char.Text += $"Failed To disconnect COM port: {ex.Message}" & vbCrLf
            End Try
        Else
            ' Connect: Open the COM port
            If cmb_port.SelectedItem IsNot Nothing Then
                Try
                    ' Configure the SerialPort object
                    serialPort.PortName = cmb_port.SelectedItem.ToString()
                    serialPort.BaudRate = cmb_baud.SelectedItem ' Set the desired baud rate
                    serialPort.DataBits = cmb_bit.SelectedItem
                    'serialPort.Parity = cmb_parity.SelectedItem
                    If cmb_parity.SelectedItem IsNot Nothing Then
                        serialPort.Parity = [Enum].Parse(GetType(IO.Ports.Parity), cmb_parity.SelectedItem.ToString())
                    Else
                        MessageBox.Show("Please select a parity setting.")
                    End If
                    serialPort.StopBits = StopBits.One
                    serialPort.ReadTimeout = 10000 ' Set a read timeout to 10 seconds
                    serialPort.WriteTimeout = 2000 ' Set a write timeout (optional)

                    ' Open the port
                    serialPort.Open()

                    ToolStripStatusLabel1.Text = $"{serialPort.PortName},{serialPort.BaudRate},{serialPort.DataBits},{serialPort.Parity}"
                    ToolStripStatusLabel2.Text = "COM port connected successfully."
                    'rtxt_char.Text += ToolStripStatusLabel2.Text & vbCrLf
                    AppendTextToRichTextBox($"{ToolStripStatusLabel2.Text}" & vbCrLf, Color.Blue)
                    btn_connect.Text = "Disconnect"
                    cmb_port.Enabled = False
                    cmb_baud.Enabled = False
                    cmb_parity.Enabled = False
                    cmb_bit.Enabled = False
                Catch ex As Exception
                    btn_connect.Text = "Connect"
                    cmb_port.Enabled = True
                    cmb_baud.Enabled = True
                    cmb_parity.Enabled = True
                    cmb_bit.Enabled = True
                    MessageBox.Show($"Failed to connect to COM port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Please select a COM port.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Private Sub SendATCommand(command As String)
        Try
            Dim atCommand As String = command ' Append carriage return
            'If chk_crlf.Checked = True Then
            atCommand = command & vbCr ' Append carriage return
            'End If
            serialPort.WriteLine(atCommand)
            ' Update RichTextBox with the sent command, current date/time, and blue color
            AppendTextToRichTextBox($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] TX: ", Color.Green)
            AppendTextToRichTextBox($"{command}" & vbCrLf, Color.Blue)

            ' Convert received data to hex and update the second RichTextBox
            Dim hexData As String = ConvertToHex(atCommand)
            AppendTextToRichTextBox2($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] TX: ", Color.Green)
            AppendTextToRichTextBox2($"{hexData}" & vbCrLf, Color.Blue)
        Catch ex As Exception
            MessageBox.Show($"Error sending command: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event handler for receiving data
    Private Sub serialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles serialPort.DataReceived
        System.Threading.Thread.Sleep(100) ' 1000 milliseconds = 1 second
        Try
            ' Read all available data from the serial port
            Dim receivedData As String = serialPort.ReadExisting()
            ' Update RichTextBox with the received data, current date/time, and green color
            AppendTextToRichTextBox($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] RX: ", Color.Green)
            AppendTextToRichTextBox($"{receivedData}" & vbCrLf, Color.Red)

            ' Convert received data to hex and update the second RichTextBox
            Dim hexData As String = ConvertToHex(receivedData)
            AppendTextToRichTextBox2($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] RX: ", Color.Green)
            AppendTextToRichTextBox2($"{hexData}" & vbCrLf, Color.Red)

        Catch ex As Exception
            MessageBox.Show($"Error reading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' Method to safely update the RichTextBox from a different thread
    Private Sub AppendTextToRichTextBox(text As String, textColor As Color)
        If rtxt_char.InvokeRequired Then
            rtxt_char.Invoke(New Action(Of String, Color)(AddressOf AppendTextToRichTextBox), text, textColor)
        Else
            ' Save the original color
            Dim originalColor As Color = rtxt_char.SelectionColor
            ' Change the color to the specified color
            rtxt_char.SelectionColor = textColor
            ' Append the text
            rtxt_char.AppendText(text & vbCrLf)
            ' Revert to the original color
            rtxt_char.SelectionColor = originalColor
            ' Scroll to the caret (last position)
            rtxt_char.ScrollToCaret()
        End If
    End Sub
    Private Sub AppendTextToRichTextBox2(text As String, textColor As Color)
        If rtxt_hex.InvokeRequired Then
            rtxt_hex.Invoke(New Action(Of String, Color)(AddressOf AppendTextToRichTextBox2), text, textColor)
        Else
            ' Save the original color
            Dim originalColor As Color = rtxt_char.SelectionColor
            ' Change the color to the specified color
            rtxt_hex.SelectionColor = textColor
            ' Append the text
            rtxt_hex.AppendText(text & vbCrLf)
            ' Revert to the original color
            rtxt_hex.SelectionColor = originalColor
            ' Scroll to the caret (last position)
            rtxt_hex.ScrollToCaret()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadComPorts()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        clearbox()
    End Sub


    ' Method to convert string data to hex format
    Private Function ConvertToHex(data As String) As String
        Dim hex As New System.Text.StringBuilder()
        For Each c As Char In data
            hex.AppendFormat("{0:X2} ", AscW(c)) ' Convert each character to its hex representation
        Next
        Return hex.ToString().TrimEnd() ' Remove trailing space
    End Function

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        clearbox()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        rtxt_char.SelectAll()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        rtxt_char.Copy()
    End Sub
    Private Sub clearbox()
        AppendRichTextBoxToFile()
        rtxt_char.Text = ""
        rtxt_hex.Text = ""
    End Sub
    Private Sub AppendRichTextBoxToFile()
        Try
            ' Define the file path where the content will be appended
            Dim filePath As String = Application.StartupPath & "\log.txt"

            ' Use StreamWriter in append mode (True for append)
            Using writer As New StreamWriter(filePath, True)
                writer.WriteLine(rtxt_char.Text) ' Append the RichTextBox content
            End Using

            'MessageBox.Show("Text appended successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Handle errors
            'MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If ListBox1.SelectedItem IsNot Nothing Then
            SendATCommand(ListBox1.SelectedItem.ToString())
        Else
            MessageBox.Show("No item is selected.")
        End If
    End Sub

    Private Sub btn_loadfile_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ButtonMoveUp()
        ' Check if an item is selected and if it's not the first item
        If ListBox1.SelectedIndex <> -1 AndAlso ListBox1.SelectedIndex > 0 Then
            ' Get the index of the selected item
            Dim selectedIndex As Integer = ListBox1.SelectedIndex
            ' Store the selected item
            Dim selectedItem As String = ListBox1.SelectedItem.ToString()

            ' Remove the item from its current position
            ListBox1.Items.RemoveAt(selectedIndex)
            ' Insert the item one position higher
            ListBox1.Items.Insert(selectedIndex - 1, selectedItem)
            ' Re-select the moved item
            ListBox1.SelectedIndex = selectedIndex - 1
        Else
            MessageBox.Show("Please select an item to move up.")
        End If
    End Sub
    Private Sub ButtonMoveDown()
        ' Check if an item is selected and if it's not the last item
        If ListBox1.SelectedIndex <> -1 AndAlso ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then
            ' Get the index of the selected item
            Dim selectedIndex As Integer = ListBox1.SelectedIndex
            ' Store the selected item
            Dim selectedItem As String = ListBox1.SelectedItem.ToString()

            ' Remove the item from its current position
            ListBox1.Items.RemoveAt(selectedIndex)
            ' Insert the item one position lower
            ListBox1.Items.Insert(selectedIndex + 1, selectedItem)
            ' Re-select the moved item
            ListBox1.SelectedIndex = selectedIndex + 1
        Else
            MessageBox.Show("Please select an item to move down.")
        End If
    End Sub

    Private Sub MoveUPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveUPToolStripMenuItem.Click
        ButtonMoveUp()
    End Sub

    Private Sub MoveDownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveDownToolStripMenuItem.Click
        ButtonMoveDown()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ADDToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ADDToolStripMenuItem1.Click
        edit_list_item()
    End Sub
    Private Sub edit_list_item()
        If ListBox1.SelectedIndex <> -1 Then
            Dim editedText As String = InputBox("Edit item:", "Edit Item", ListBox1.SelectedItem.ToString())
            If editedText <> "" Then
                ListBox1.Items(ListBox1.SelectedIndex) = editedText
            End If
        End If
    End Sub


    Private Sub ADDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDToolStripMenuItem.Click
        add_list_item()
    End Sub
    Private Sub add_list_item()
        Dim add_command As String = InputBox("Enter Command", "ADD Command")
        If Not String.IsNullOrWhiteSpace(add_command) Then ' Check if the input is not empty
            ListBox1.Items.Add(add_command)
        Else
            MessageBox.Show("No command entered.")
        End If
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        delete_list_item()
    End Sub
    Private Sub delete_list_item()
        If MessageBox.Show("Are you sure you want to Delete Command?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If ListBox1.SelectedItem IsNot Nothing Then
                ListBox1.Items.Remove(ListBox1.SelectedItem)
            End If
        End If

    End Sub

    Private Sub LoadFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadFileToolStripMenuItem.Click
        load_list_file()
    End Sub
    Private Sub load_list_file()
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        openFileDialog.Title = "Select a Text File"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            Dim lines() As String = System.IO.File.ReadAllLines(filePath)
            'lbl_filename.Text = filePath
            ListBox1.Items.Clear() ' Clear existing items in the ListBox
            For Each line As String In lines
                ListBox1.Items.Add(line)
            Next
            ToolStripStatusLabel3.Text = filePath
        Else
            ToolStripStatusLabel2.Text = "No file selected."
        End If
    End Sub

    Private Sub ClearToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem1.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        Else
            AppendRichTextBoxToFile()
        End If
    End Sub
    Private Sub Showlogs()
        Dim filePath As String = Application.StartupPath & "\log.txt"
        If File.Exists(filePath) Then
            Process.Start("notepad.exe", filePath)
        Else
            MessageBox.Show("File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ShowLogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowLogsToolStripMenuItem.Click
        Showlogs()
    End Sub
    Private Sub ApplyDualColorTextChar(textPart1 As String, textPart2 As String)
        ' Clear the RichTextBox for demonstration purposes
        'rtxt_char.Clear()

        ' Define the text and the parts with different colors
        'Dim textPart1 As String = "Hello "
        'Dim textPart2 As String = "World!"

        ' Append the first part of the text and set its color
        rtxt_char.AppendText(textPart1)
        rtxt_char.SelectionStart = rtxt_char.Text.Length - textPart1.Length
        rtxt_char.SelectionLength = textPart1.Length
        rtxt_char.SelectionColor = Color.Green

        ' Append the second part of the text and set its color
        rtxt_char.AppendText(textPart2)
        rtxt_char.SelectionStart = rtxt_char.Text.Length - textPart2.Length
        rtxt_char.SelectionLength = textPart2.Length
        rtxt_char.SelectionColor = Color.Red

        ' Reset selection to the end of the text
        rtxt_char.SelectionStart = rtxt_char.Text.Length
        rtxt_char.SelectionLength = 0
        rtxt_char.SelectionColor = Color.Black ' Reset color for future typing
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("Version 1.0", "Version", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub MenuStrip1_MouseHover(sender As Object, e As EventArgs) Handles MenuStrip1.MouseHover

    End Sub
    Private Sub filesave()
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        saveFileDialog.Title = "Save ListBox Items"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName

            ' Create a list to hold the items from the ListBox
            Dim items As New List(Of String)

            ' Loop through each item in the ListBox and add it to the list
            For Each item As String In ListBox1.Items
                items.Add(item)
            Next

            ' Write the items to the selected file
            System.IO.File.WriteAllLines(filePath, items)
            MessageBox.Show("Items saved successfully.")
        Else
            MessageBox.Show("Save operation canceled.")
        End If
    End Sub

    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem1.Click
        filesave()
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub ASCIIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ASCIIToolStripMenuItem.Click
        rtxt_char.Visible = True
        rtxt_hex.Visible = False
    End Sub

    Private Sub HEXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HEXToolStripMenuItem.Click
        rtxt_char.Visible = False
        rtxt_hex.Visible = True
    End Sub

    Private Sub EDITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITToolStripMenuItem.Click
        edit_list_item()
    End Sub

    Private Sub AddToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem2.Click
        add_list_item()
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        delete_list_item()
    End Sub

    Private Sub LoadDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDataToolStripMenuItem.Click
        load_list_file()
    End Sub

    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        SendATCommand(TextBox1.Text)
    End Sub

    Private Sub DarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem.Click
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
        ' Set font for RichTextBox
        rtxt_char.BackColor = Color.LightGray
        rtxt_hex.BackColor = Color.LightGray
        rtxt_char.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        rtxt_hex.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        'Segoe UI, 9.75pt
        ListBox1.BackColor = Color.LightGray

        btn_connect.FlatStyle = FlatStyle.Popup ' Gives a 3D look
        btn_connect.FlatAppearance.BorderSize = 2
        btn_connect.FlatAppearance.BorderColor = Color.DarkGray


        btn_send.FlatStyle = FlatStyle.Popup ' Gives a 3D look
        btn_send.FlatAppearance.BorderSize = 2
        btn_send.FlatAppearance.BorderColor = Color.DarkGray

        btn_connect.BackColor = Color.Brown
        btn_send.BackColor = Color.Brown

        btn_connect.ForeColor = Color.White
        btn_send.ForeColor = Color.White
    End Sub

    Private Sub LightModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightModeToolStripMenuItem.Click
        Me.BackColor = Color.Lavender
        Me.ForeColor = Color.Green
        ' Set font for RichTextBox
        rtxt_char.BackColor = Color.White
        rtxt_hex.BackColor = Color.White
        rtxt_char.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        rtxt_hex.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        ListBox1.BackColor = Color.White

        btn_connect.FlatStyle = FlatStyle.Popup ' Gives a 3D look
        btn_connect.FlatAppearance.BorderSize = 2
        btn_connect.FlatAppearance.BorderColor = Color.DarkGray

        btn_send.FlatStyle = FlatStyle.Popup ' Gives a 3D look
        btn_send.FlatAppearance.BorderSize = 2
        btn_send.FlatAppearance.BorderColor = Color.DarkGray

        btn_connect.BackColor = Color.Lavender
        btn_send.BackColor = Color.Lavender

        btn_connect.ForeColor = Color.Green
        btn_send.ForeColor = Color.Green
    End Sub

    Private Sub DarkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem1.Click
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
        ' Set font for RichTextBox
        rtxt_char.BackColor = Color.Black
        rtxt_hex.BackColor = Color.Black
        rtxt_char.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        rtxt_hex.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        ListBox1.BackColor = Color.LightGray

        btn_connect.FlatStyle = FlatStyle.Popup ' Gives a 3D look
        btn_connect.FlatAppearance.BorderSize = 2
        btn_connect.FlatAppearance.BorderColor = Color.DarkGray


        btn_send.FlatStyle = FlatStyle.Popup ' Gives a 3D look
        btn_send.FlatAppearance.BorderSize = 2
        btn_send.FlatAppearance.BorderColor = Color.DarkGray

        btn_connect.BackColor = Color.Brown
        btn_send.BackColor = Color.Brown

        btn_connect.ForeColor = Color.White
        btn_send.ForeColor = Color.White
    End Sub
End Class
