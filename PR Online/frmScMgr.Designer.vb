﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmScMgr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScMgr))
        Me.lbUserID = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbFbReject = New System.Windows.Forms.TextBox()
        Me.pbReject = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbFbApprove = New System.Windows.Forms.TextBox()
        Me.pbApprove = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pbStatus = New System.Windows.Forms.PictureBox()
        Me.lbStatusPR = New System.Windows.Forms.Label()
        Me.lbPrTag = New System.Windows.Forms.Label()
        Me.lbTagID = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbTotalQty = New System.Windows.Forms.Label()
        Me.lbTotalAmount = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dgvItemPR = New System.Windows.Forms.DataGridView()
        Me.btnStatus = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbAssignTo = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbAssignTo = New System.Windows.Forms.ComboBox()
        Me.lbPrepareName = New System.Windows.Forms.Label()
        Me.lbPrepareEmail = New System.Windows.Forms.Label()
        Me.lbGlOwner = New System.Windows.Forms.Label()
        Me.tbGlDe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbGlAc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnOpenPdf = New System.Windows.Forms.Button()
        Me.lbReqBy = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbDept = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lbPrDate = New System.Windows.Forms.Label()
        Me.lbAttachFile = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pbUrgent = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.pbReject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbApprove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvItemPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUrgent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbUserID
        '
        Me.lbUserID.AutoSize = True
        Me.lbUserID.BackColor = System.Drawing.Color.White
        Me.lbUserID.Location = New System.Drawing.Point(1161, 16)
        Me.lbUserID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbUserID.Name = "lbUserID"
        Me.lbUserID.Size = New System.Drawing.Size(60, 16)
        Me.lbUserID.TabIndex = 438
        Me.lbUserID.Text = "lbUserID"
        Me.lbUserID.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(689, 594)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(383, 34)
        Me.Label8.TabIndex = 434
        Me.Label8.Text = "Feedback Message"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbFbReject
        '
        Me.tbFbReject.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbFbReject.Location = New System.Drawing.Point(689, 629)
        Me.tbFbReject.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbFbReject.Multiline = True
        Me.tbFbReject.Name = "tbFbReject"
        Me.tbFbReject.Size = New System.Drawing.Size(383, 117)
        Me.tbFbReject.TabIndex = 433
        '
        'pbReject
        '
        Me.pbReject.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbReject.BackColor = System.Drawing.Color.DodgerBlue
        Me.pbReject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbReject.Image = CType(resources.GetObject("pbReject.Image"), System.Drawing.Image)
        Me.pbReject.Location = New System.Drawing.Point(1085, 594)
        Me.pbReject.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbReject.Name = "pbReject"
        Me.pbReject.Size = New System.Drawing.Size(188, 153)
        Me.pbReject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbReject.TabIndex = 432
        Me.pbReject.TabStop = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(675, 582)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(617, 178)
        Me.Label9.TabIndex = 431
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 594)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(391, 34)
        Me.Label2.TabIndex = 430
        Me.Label2.Text = "Feedback Message"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbFbApprove
        '
        Me.tbFbApprove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbFbApprove.Location = New System.Drawing.Point(36, 629)
        Me.tbFbApprove.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbFbApprove.Multiline = True
        Me.tbFbApprove.Name = "tbFbApprove"
        Me.tbFbApprove.Size = New System.Drawing.Size(391, 117)
        Me.tbFbApprove.TabIndex = 429
        '
        'pbApprove
        '
        Me.pbApprove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbApprove.BackColor = System.Drawing.Color.DodgerBlue
        Me.pbApprove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbApprove.Image = CType(resources.GetObject("pbApprove.Image"), System.Drawing.Image)
        Me.pbApprove.Location = New System.Drawing.Point(436, 594)
        Me.pbApprove.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbApprove.Name = "pbApprove"
        Me.pbApprove.Size = New System.Drawing.Size(188, 153)
        Me.pbApprove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbApprove.TabIndex = 428
        Me.pbApprove.TabStop = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 582)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(617, 178)
        Me.Label7.TabIndex = 422
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.UseCompatibleTextRendering = True
        '
        'pbStatus
        '
        Me.pbStatus.BackColor = System.Drawing.Color.White
        Me.pbStatus.Image = Global.PR_Online.My.Resources.Resources.approved__1_
        Me.pbStatus.Location = New System.Drawing.Point(1017, 122)
        Me.pbStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(272, 176)
        Me.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbStatus.TabIndex = 421
        Me.pbStatus.TabStop = False
        '
        'lbStatusPR
        '
        Me.lbStatusPR.BackColor = System.Drawing.Color.White
        Me.lbStatusPR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStatusPR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStatusPR.Location = New System.Drawing.Point(1017, 81)
        Me.lbStatusPR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbStatusPR.Name = "lbStatusPR"
        Me.lbStatusPR.Size = New System.Drawing.Size(271, 36)
        Me.lbStatusPR.TabIndex = 420
        Me.lbStatusPR.Text = "Status PR Online"
        Me.lbStatusPR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbStatusPR.UseCompatibleTextRendering = True
        '
        'lbPrTag
        '
        Me.lbPrTag.BackColor = System.Drawing.Color.White
        Me.lbPrTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbPrTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPrTag.Location = New System.Drawing.Point(145, 58)
        Me.lbPrTag.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPrTag.Name = "lbPrTag"
        Me.lbPrTag.Size = New System.Drawing.Size(307, 36)
        Me.lbPrTag.TabIndex = 412
        Me.lbPrTag.Text = "lbPrTag"
        Me.lbPrTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbPrTag.UseCompatibleTextRendering = True
        '
        'lbTagID
        '
        Me.lbTagID.AutoSize = True
        Me.lbTagID.BackColor = System.Drawing.Color.White
        Me.lbTagID.Location = New System.Drawing.Point(1229, 16)
        Me.lbTagID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTagID.Name = "lbTagID"
        Me.lbTagID.Size = New System.Drawing.Size(56, 16)
        Me.lbTagID.TabIndex = 409
        Me.lbTagID.Text = "lbTagID"
        Me.lbTagID.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(21, 58)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 36)
        Me.Label15.TabIndex = 407
        Me.Label15.Text = "PR No. : "
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label15.UseCompatibleTextRendering = True
        '
        'lbTotalQty
        '
        Me.lbTotalQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbTotalQty.BackColor = System.Drawing.Color.White
        Me.lbTotalQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTotalQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalQty.Location = New System.Drawing.Point(443, 524)
        Me.lbTotalQty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTotalQty.Name = "lbTotalQty"
        Me.lbTotalQty.Size = New System.Drawing.Size(413, 48)
        Me.lbTotalQty.TabIndex = 406
        Me.lbTotalQty.Text = "Total Q'ty : -"
        Me.lbTotalQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbTotalQty.UseCompatibleTextRendering = True
        '
        'lbTotalAmount
        '
        Me.lbTotalAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbTotalAmount.BackColor = System.Drawing.Color.White
        Me.lbTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalAmount.Location = New System.Drawing.Point(864, 524)
        Me.lbTotalAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTotalAmount.Name = "lbTotalAmount"
        Me.lbTotalAmount.Size = New System.Drawing.Size(427, 48)
        Me.lbTotalAmount.TabIndex = 405
        Me.lbTotalAmount.Text = "Total Amount : -"
        Me.lbTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbTotalAmount.UseCompatibleTextRendering = True
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(21, 217)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(227, 81)
        Me.Label14.TabIndex = 404
        Me.Label14.Text = "Item in PR :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label14.UseCompatibleTextRendering = True
        '
        'dgvItemPR
        '
        Me.dgvItemPR.AllowUserToAddRows = False
        Me.dgvItemPR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvItemPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemPR.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvItemPR.Location = New System.Drawing.Point(21, 305)
        Me.dgvItemPR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvItemPR.Name = "dgvItemPR"
        Me.dgvItemPR.ReadOnly = True
        Me.dgvItemPR.RowHeadersWidth = 51
        Me.dgvItemPR.Size = New System.Drawing.Size(1271, 215)
        Me.dgvItemPR.TabIndex = 402
        '
        'btnStatus
        '
        Me.btnStatus.BackColor = System.Drawing.Color.White
        Me.btnStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnStatus.ForeColor = System.Drawing.Color.Black
        Me.btnStatus.Location = New System.Drawing.Point(684, 11)
        Me.btnStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(128, 41)
        Me.btnStatus.TabIndex = 400
        Me.btnStatus.Text = "Server Status"
        Me.btnStatus.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(119, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(522, 41)
        Me.Label1.TabIndex = 399
        Me.Label1.Text = "P.R. ( Purchase Request ) Online"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(4, 7)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(1301, 798)
        Me.Label17.TabIndex = 408
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 523)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(413, 49)
        Me.Label12.TabIndex = 439
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.UseCompatibleTextRendering = True
        '
        'lbAssignTo
        '
        Me.lbAssignTo.AutoSize = True
        Me.lbAssignTo.BackColor = System.Drawing.Color.White
        Me.lbAssignTo.Location = New System.Drawing.Point(1056, 16)
        Me.lbAssignTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbAssignTo.Name = "lbAssignTo"
        Me.lbAssignTo.Size = New System.Drawing.Size(76, 16)
        Me.lbAssignTo.TabIndex = 442
        Me.lbAssignTo.Text = "lbAssignTo"
        Me.lbAssignTo.Visible = False
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(40, 537)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 27)
        Me.Label13.TabIndex = 440
        Me.Label13.Text = "Assign to"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbAssignTo
        '
        Me.cbAssignTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbAssignTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.cbAssignTo.Location = New System.Drawing.Point(163, 533)
        Me.cbAssignTo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbAssignTo.Name = "cbAssignTo"
        Me.cbAssignTo.Size = New System.Drawing.Size(264, 33)
        Me.cbAssignTo.TabIndex = 443
        '
        'lbPrepareName
        '
        Me.lbPrepareName.AutoSize = True
        Me.lbPrepareName.BackColor = System.Drawing.Color.White
        Me.lbPrepareName.Location = New System.Drawing.Point(941, 16)
        Me.lbPrepareName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPrepareName.Name = "lbPrepareName"
        Me.lbPrepareName.Size = New System.Drawing.Size(104, 16)
        Me.lbPrepareName.TabIndex = 444
        Me.lbPrepareName.Text = "lbPrepareName"
        Me.lbPrepareName.Visible = False
        '
        'lbPrepareEmail
        '
        Me.lbPrepareEmail.AutoSize = True
        Me.lbPrepareEmail.BackColor = System.Drawing.Color.White
        Me.lbPrepareEmail.Location = New System.Drawing.Point(831, 16)
        Me.lbPrepareEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPrepareEmail.Name = "lbPrepareEmail"
        Me.lbPrepareEmail.Size = New System.Drawing.Size(101, 16)
        Me.lbPrepareEmail.TabIndex = 445
        Me.lbPrepareEmail.Text = "lbPrepareEmail"
        Me.lbPrepareEmail.Visible = False
        '
        'lbGlOwner
        '
        Me.lbGlOwner.AutoSize = True
        Me.lbGlOwner.BackColor = System.Drawing.Color.White
        Me.lbGlOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbGlOwner.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbGlOwner.Location = New System.Drawing.Point(20, 177)
        Me.lbGlOwner.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbGlOwner.Name = "lbGlOwner"
        Me.lbGlOwner.Size = New System.Drawing.Size(119, 30)
        Me.lbGlOwner.TabIndex = 459
        Me.lbGlOwner.Text = "GL Owner : -"
        Me.lbGlOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbGlOwner.UseCompatibleTextRendering = True
        '
        'tbGlDe
        '
        Me.tbGlDe.AutoCompleteCustomSource.AddRange(New String() {"6001", "6002", "6010", "6012", "6013", "6020", "6021", "6022", "6030", "6040", "6050", "6060", "6070", "2000", "2060", "2070", "2071", "2072", "2080", "2081", "2082", "2083", "2084", "2010", "2020", "2030", "2040", "2041", "2050", "1090", "1080", "1070", "1000", "1010", "1020", "1030", "1040", "1050", "1060", "3010", "3015", "3020", "3025", "3030", "3000", "3090", "3050", "3055", "4010", "4015", "4020", "4050", "4000", "5000", "5005", "5010", "5011", "5012", "5050", "5060", "5070", "0050", "0001", "0002", "0020"})
        Me.tbGlDe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbGlDe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbGlDe.BackColor = System.Drawing.Color.White
        Me.tbGlDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGlDe.Location = New System.Drawing.Point(724, 140)
        Me.tbGlDe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbGlDe.Multiline = True
        Me.tbGlDe.Name = "tbGlDe"
        Me.tbGlDe.ReadOnly = True
        Me.tbGlDe.Size = New System.Drawing.Size(272, 30)
        Me.tbGlDe.TabIndex = 458
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(461, 140)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 30)
        Me.Label3.TabIndex = 457
        Me.Label3.Text = "GL. Detail / รายละเอียดรหัส : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.UseCompatibleTextRendering = True
        '
        'tbGlAc
        '
        Me.tbGlAc.AutoCompleteCustomSource.AddRange(New String() {"6001", "6002", "6010", "6012", "6013", "6020", "6021", "6022", "6030", "6040", "6050", "6060", "6070", "2000", "2060", "2070", "2071", "2072", "2080", "2081", "2082", "2083", "2084", "2010", "2020", "2030", "2040", "2041", "2050", "1090", "1080", "1070", "1000", "1010", "1020", "1030", "1040", "1050", "1060", "3010", "3015", "3020", "3025", "3030", "3000", "3090", "3050", "3055", "4010", "4015", "4020", "4050", "4000", "5000", "5005", "5010", "5011", "5012", "5050", "5060", "5070", "0050", "0001", "0002", "0020"})
        Me.tbGlAc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbGlAc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbGlAc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.tbGlAc.Location = New System.Drawing.Point(256, 140)
        Me.tbGlAc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbGlAc.Name = "tbGlAc"
        Me.tbGlAc.Size = New System.Drawing.Size(196, 29)
        Me.tbGlAc.TabIndex = 456
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 140)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 30)
        Me.Label4.TabIndex = 455
        Me.Label4.Text = "GL. Account / รหัสสินค้า :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.UseCompatibleTextRendering = True
        '
        'btnOpenPdf
        '
        Me.btnOpenPdf.AutoSize = True
        Me.btnOpenPdf.Location = New System.Drawing.Point(841, 177)
        Me.btnOpenPdf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOpenPdf.Name = "btnOpenPdf"
        Me.btnOpenPdf.Size = New System.Drawing.Size(156, 31)
        Me.btnOpenPdf.TabIndex = 454
        Me.btnOpenPdf.Text = "Open PDF"
        Me.btnOpenPdf.UseVisualStyleBackColor = True
        '
        'lbReqBy
        '
        Me.lbReqBy.BackColor = System.Drawing.Color.White
        Me.lbReqBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbReqBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbReqBy.Location = New System.Drawing.Point(617, 64)
        Me.lbReqBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbReqBy.Name = "lbReqBy"
        Me.lbReqBy.Size = New System.Drawing.Size(379, 30)
        Me.lbReqBy.TabIndex = 453
        Me.lbReqBy.Text = "lbReqBy"
        Me.lbReqBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbReqBy.UseCompatibleTextRendering = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(461, 64)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 30)
        Me.Label5.TabIndex = 452
        Me.Label5.Text = "Requested by :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label5.UseCompatibleTextRendering = True
        '
        'lbDept
        '
        Me.lbDept.BackColor = System.Drawing.Color.White
        Me.lbDept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDept.Location = New System.Drawing.Point(247, 100)
        Me.lbDept.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDept.Name = "lbDept"
        Me.lbDept.Size = New System.Drawing.Size(206, 30)
        Me.lbDept.TabIndex = 451
        Me.lbDept.Text = "lbDept"
        Me.lbDept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbDept.UseCompatibleTextRendering = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.White
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label34.Location = New System.Drawing.Point(20, 100)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(202, 30)
        Me.Label34.TabIndex = 450
        Me.Label34.Text = "Requested from Dept :"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label34.UseCompatibleTextRendering = True
        '
        'lbPrDate
        '
        Me.lbPrDate.BackColor = System.Drawing.Color.White
        Me.lbPrDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbPrDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPrDate.Location = New System.Drawing.Point(639, 101)
        Me.lbPrDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPrDate.Name = "lbPrDate"
        Me.lbPrDate.Size = New System.Drawing.Size(358, 30)
        Me.lbPrDate.TabIndex = 449
        Me.lbPrDate.Text = "lbPrDate"
        Me.lbPrDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbPrDate.UseCompatibleTextRendering = True
        '
        'lbAttachFile
        '
        Me.lbAttachFile.BackColor = System.Drawing.Color.White
        Me.lbAttachFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbAttachFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbAttachFile.Location = New System.Drawing.Point(587, 177)
        Me.lbAttachFile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbAttachFile.Name = "lbAttachFile"
        Me.lbAttachFile.Size = New System.Drawing.Size(246, 30)
        Me.lbAttachFile.TabIndex = 448
        Me.lbAttachFile.Text = "lbAttachFile"
        Me.lbAttachFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbAttachFile.UseCompatibleTextRendering = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(461, 177)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 30)
        Me.Label6.TabIndex = 447
        Me.Label6.Text = "Attach file : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.UseCompatibleTextRendering = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(461, 101)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(158, 30)
        Me.Label10.TabIndex = 446
        Me.Label10.Text = "PR Online Date : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label10.UseCompatibleTextRendering = True
        '
        'pbUrgent
        '
        Me.pbUrgent.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pbUrgent.Image = CType(resources.GetObject("pbUrgent.Image"), System.Drawing.Image)
        Me.pbUrgent.Location = New System.Drawing.Point(257, 217)
        Me.pbUrgent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbUrgent.Name = "pbUrgent"
        Me.pbUrgent.Size = New System.Drawing.Size(740, 81)
        Me.pbUrgent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbUrgent.TabIndex = 524
        Me.pbUrgent.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(1017, 38)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(272, 39)
        Me.btnCancel.TabIndex = 525
        Me.btnCancel.Text = "Cancel PR"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmScMgr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1311, 812)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.pbUrgent)
        Me.Controls.Add(Me.lbGlOwner)
        Me.Controls.Add(Me.tbGlDe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbGlAc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnOpenPdf)
        Me.Controls.Add(Me.lbReqBy)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbDept)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.lbPrDate)
        Me.Controls.Add(Me.lbAttachFile)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbPrepareEmail)
        Me.Controls.Add(Me.lbPrepareName)
        Me.Controls.Add(Me.cbAssignTo)
        Me.Controls.Add(Me.lbAssignTo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbUserID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbFbReject)
        Me.Controls.Add(Me.pbReject)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbFbApprove)
        Me.Controls.Add(Me.pbApprove)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pbStatus)
        Me.Controls.Add(Me.lbStatusPR)
        Me.Controls.Add(Me.lbPrTag)
        Me.Controls.Add(Me.lbTagID)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lbTotalQty)
        Me.Controls.Add(Me.lbTotalAmount)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dgvItemPR)
        Me.Controls.Add(Me.btnStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmScMgr"
        Me.Text = "P.R. ( Purchase Request ) Online"
        CType(Me.pbReject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbApprove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvItemPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUrgent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbUserID As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbFbReject As TextBox
    Friend WithEvents pbReject As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbFbApprove As TextBox
    Friend WithEvents pbApprove As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents pbStatus As PictureBox
    Friend WithEvents lbStatusPR As Label
    Friend WithEvents lbPrTag As Label
    Friend WithEvents lbTagID As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lbTotalQty As Label
    Friend WithEvents lbTotalAmount As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents dgvItemPR As DataGridView
    Friend WithEvents btnStatus As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbAssignTo As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cbAssignTo As ComboBox
    Friend WithEvents lbPrepareName As Label
    Friend WithEvents lbPrepareEmail As Label
    Friend WithEvents lbGlOwner As Label
    Friend WithEvents tbGlDe As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbGlAc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnOpenPdf As Button
    Friend WithEvents lbReqBy As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbDept As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents lbPrDate As Label
    Friend WithEvents lbAttachFile As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents pbUrgent As PictureBox
    Friend WithEvents btnCancel As Button
End Class
