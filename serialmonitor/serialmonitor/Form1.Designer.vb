<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmb_port = New System.Windows.Forms.ComboBox()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rtxt_char = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtxt_hex = New System.Windows.Forms.RichTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveUPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommandsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASCIIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HEXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_baud = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_bit = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_parity = New System.Windows.Forms.ComboBox()
        Me.btn_send = New System.Windows.Forms.Button()
        Me.DarkToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_port
        '
        Me.cmb_port.FormattingEnabled = True
        Me.cmb_port.Location = New System.Drawing.Point(56, 33)
        Me.cmb_port.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_port.Name = "cmb_port"
        Me.cmb_port.Size = New System.Drawing.Size(95, 25)
        Me.cmb_port.TabIndex = 0
        '
        'btn_connect
        '
        Me.btn_connect.BackColor = System.Drawing.Color.Lavender
        Me.btn_connect.Location = New System.Drawing.Point(17, 101)
        Me.btn_connect.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(286, 36)
        Me.btn_connect.TabIndex = 2
        Me.btn_connect.Text = "Connect"
        Me.btn_connect.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "COM"
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox1.Location = New System.Drawing.Point(117, 145)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(186, 25)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "AT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 149)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Send Command"
        '
        'rtxt_char
        '
        Me.rtxt_char.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxt_char.BackColor = System.Drawing.Color.White
        Me.rtxt_char.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtxt_char.ContextMenuStrip = Me.ContextMenuStrip1
        Me.rtxt_char.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.rtxt_char.Location = New System.Drawing.Point(311, 32)
        Me.rtxt_char.Margin = New System.Windows.Forms.Padding(4)
        Me.rtxt_char.Name = "rtxt_char"
        Me.rtxt_char.Size = New System.Drawing.Size(483, 352)
        Me.rtxt_char.TabIndex = 7
        Me.rtxt_char.Text = "Char"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.SelectAllToolStripMenuItem, Me.CopyToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(123, 70)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.ToolStripMenuItem1.Text = "Clear"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'rtxt_hex
        '
        Me.rtxt_hex.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxt_hex.BackColor = System.Drawing.Color.White
        Me.rtxt_hex.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.rtxt_hex.ForeColor = System.Drawing.Color.Black
        Me.rtxt_hex.Location = New System.Drawing.Point(311, 33)
        Me.rtxt_hex.Margin = New System.Windows.Forms.Padding(4)
        Me.rtxt_hex.Name = "rtxt_hex"
        Me.rtxt_hex.Size = New System.Drawing.Size(483, 351)
        Me.rtxt_hex.TabIndex = 8
        Me.rtxt_hex.Text = "Hex"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Lavender
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 389)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(807, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Lavender
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.MoveUPToolStripMenuItem, Me.MoveDownToolStripMenuItem, Me.ClearToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.CommandsToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ThemeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(807, 26)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem1})
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.SaveToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem1
        '
        Me.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        Me.SaveToolStripMenuItem1.Size = New System.Drawing.Size(98, 22)
        Me.SaveToolStripMenuItem1.Text = "Save"
        '
        'MoveUPToolStripMenuItem
        '
        Me.MoveUPToolStripMenuItem.Image = CType(resources.GetObject("MoveUPToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MoveUPToolStripMenuItem.Name = "MoveUPToolStripMenuItem"
        Me.MoveUPToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.MoveUPToolStripMenuItem.Text = "MoveUP"
        '
        'MoveDownToolStripMenuItem
        '
        Me.MoveDownToolStripMenuItem.Image = CType(resources.GetObject("MoveDownToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MoveDownToolStripMenuItem.Name = "MoveDownToolStripMenuItem"
        Me.MoveDownToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.MoveDownToolStripMenuItem.Text = "MoveDown"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Image = CType(resources.GetObject("ClearToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'CommandsToolStripMenuItem
        '
        Me.CommandsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDToolStripMenuItem, Me.ADDToolStripMenuItem1, Me.DeleteToolStripMenuItem, Me.LoadFileToolStripMenuItem, Me.ClearToolStripMenuItem1, Me.ShowLogsToolStripMenuItem})
        Me.CommandsToolStripMenuItem.Image = CType(resources.GetObject("CommandsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CommandsToolStripMenuItem.Name = "CommandsToolStripMenuItem"
        Me.CommandsToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.CommandsToolStripMenuItem.Text = "Commands"
        '
        'ADDToolStripMenuItem
        '
        Me.ADDToolStripMenuItem.Name = "ADDToolStripMenuItem"
        Me.ADDToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ADDToolStripMenuItem.Text = "Add"
        '
        'ADDToolStripMenuItem1
        '
        Me.ADDToolStripMenuItem1.Name = "ADDToolStripMenuItem1"
        Me.ADDToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.ADDToolStripMenuItem1.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'LoadFileToolStripMenuItem
        '
        Me.LoadFileToolStripMenuItem.Name = "LoadFileToolStripMenuItem"
        Me.LoadFileToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.LoadFileToolStripMenuItem.Text = "Load File"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.ClearToolStripMenuItem1.Text = "Clear"
        '
        'ShowLogsToolStripMenuItem
        '
        Me.ShowLogsToolStripMenuItem.Name = "ShowLogsToolStripMenuItem"
        Me.ShowLogsToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ShowLogsToolStripMenuItem.Text = "Show Logs"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ASCIIToolStripMenuItem, Me.HEXToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ASCIIToolStripMenuItem
        '
        Me.ASCIIToolStripMenuItem.Name = "ASCIIToolStripMenuItem"
        Me.ASCIIToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.ASCIIToolStripMenuItem.Text = "ASCII"
        '
        'HEXToolStripMenuItem
        '
        Me.HEXToolStripMenuItem.Name = "HEXToolStripMenuItem"
        Me.HEXToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.HEXToolStripMenuItem.Text = "HEX"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ThemeToolStripMenuItem
        '
        Me.ThemeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LightModeToolStripMenuItem, Me.DarkToolStripMenuItem, Me.DarkToolStripMenuItem1})
        Me.ThemeToolStripMenuItem.Name = "ThemeToolStripMenuItem"
        Me.ThemeToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ThemeToolStripMenuItem.Text = "Theme"
        '
        'LightModeToolStripMenuItem
        '
        Me.LightModeToolStripMenuItem.Name = "LightModeToolStripMenuItem"
        Me.LightModeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LightModeToolStripMenuItem.Text = "Light Mode"
        '
        'DarkToolStripMenuItem
        '
        Me.DarkToolStripMenuItem.Name = "DarkToolStripMenuItem"
        Me.DarkToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DarkToolStripMenuItem.Text = "Dark Light"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.ListBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(17, 221)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(286, 155)
        Me.ListBox1.TabIndex = 11
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem2, Me.EDITToolStripMenuItem, Me.DeleteToolStripMenuItem1, Me.LoadDataToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(122, 92)
        '
        'AddToolStripMenuItem2
        '
        Me.AddToolStripMenuItem2.Name = "AddToolStripMenuItem2"
        Me.AddToolStripMenuItem2.Size = New System.Drawing.Size(121, 22)
        Me.AddToolStripMenuItem2.Text = "Add"
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.EDITToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'LoadDataToolStripMenuItem
        '
        Me.LoadDataToolStripMenuItem.Name = "LoadDataToolStripMenuItem"
        Me.LoadDataToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.LoadDataToolStripMenuItem.Text = "Load File"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 35)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Baud"
        '
        'cmb_baud
        '
        Me.cmb_baud.FormattingEnabled = True
        Me.cmb_baud.Location = New System.Drawing.Point(208, 31)
        Me.cmb_baud.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_baud.Name = "cmb_baud"
        Me.cmb_baud.Size = New System.Drawing.Size(95, 25)
        Me.cmb_baud.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 72)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "bit"
        '
        'cmb_bit
        '
        Me.cmb_bit.FormattingEnabled = True
        Me.cmb_bit.Location = New System.Drawing.Point(56, 68)
        Me.cmb_bit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_bit.Name = "cmb_bit"
        Me.cmb_bit.Size = New System.Drawing.Size(95, 25)
        Me.cmb_bit.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(166, 72)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Parity"
        '
        'cmb_parity
        '
        Me.cmb_parity.FormattingEnabled = True
        Me.cmb_parity.Location = New System.Drawing.Point(208, 68)
        Me.cmb_parity.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_parity.Name = "cmb_parity"
        Me.cmb_parity.Size = New System.Drawing.Size(95, 25)
        Me.cmb_parity.TabIndex = 21
        '
        'btn_send
        '
        Me.btn_send.BackColor = System.Drawing.Color.Lavender
        Me.btn_send.Location = New System.Drawing.Point(17, 177)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(287, 38)
        Me.btn_send.TabIndex = 23
        Me.btn_send.Text = "Send Command"
        Me.btn_send.UseVisualStyleBackColor = False
        '
        'DarkToolStripMenuItem1
        '
        Me.DarkToolStripMenuItem1.Name = "DarkToolStripMenuItem1"
        Me.DarkToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.DarkToolStripMenuItem1.Text = "Dark"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(52, 17)
        Me.ToolStripStatusLabel3.Text = "File Path"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(807, 411)
        Me.Controls.Add(Me.btn_send)
        Me.Controls.Add(Me.rtxt_char)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_parity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_bit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_baud)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_connect)
        Me.Controls.Add(Me.cmb_port)
        Me.Controls.Add(Me.rtxt_hex)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Serial Port Monitor"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_port As ComboBox
    Friend WithEvents btn_connect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rtxt_char As RichTextBox
    Friend WithEvents rtxt_hex As RichTextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoveUPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoveDownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_baud As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_bit As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_parity As ComboBox
    Friend WithEvents CommandsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADDToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ShowLogsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ASCIIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HEXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents EDITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LoadDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents btn_send As Button
    Friend WithEvents ThemeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
End Class
