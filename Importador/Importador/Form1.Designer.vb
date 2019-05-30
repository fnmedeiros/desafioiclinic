<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnOpenCsv = New System.Windows.Forms.Button()
        Me.tblRegistros = New System.Windows.Forms.DataGridView()
        Me.btnOpenXml = New System.Windows.Forms.Button()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValortotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorcomdescontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PessoaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.tblRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PessoaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpenCsv
        '
        Me.btnOpenCsv.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnOpenCsv.FlatAppearance.BorderSize = 0
        Me.btnOpenCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenCsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenCsv.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnOpenCsv.Location = New System.Drawing.Point(109, 412)
        Me.btnOpenCsv.Name = "btnOpenCsv"
        Me.btnOpenCsv.Size = New System.Drawing.Size(100, 42)
        Me.btnOpenCsv.TabIndex = 0
        Me.btnOpenCsv.Text = "Abrir .Csv"
        Me.btnOpenCsv.UseVisualStyleBackColor = False
        '
        'tblRegistros
        '
        Me.tblRegistros.AllowUserToAddRows = False
        Me.tblRegistros.AllowUserToDeleteRows = False
        Me.tblRegistros.AutoGenerateColumns = False
        Me.tblRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblRegistros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TelefoneDataGridViewTextBoxColumn, Me.ValortotalDataGridViewTextBoxColumn, Me.ValorcomdescontoDataGridViewTextBoxColumn})
        Me.tblRegistros.DataSource = Me.PessoaBindingSource
        Me.tblRegistros.Location = New System.Drawing.Point(3, 2)
        Me.tblRegistros.Name = "tblRegistros"
        Me.tblRegistros.Size = New System.Drawing.Size(855, 404)
        Me.tblRegistros.TabIndex = 1
        '
        'btnOpenXml
        '
        Me.btnOpenXml.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnOpenXml.FlatAppearance.BorderSize = 0
        Me.btnOpenXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenXml.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenXml.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnOpenXml.Location = New System.Drawing.Point(3, 412)
        Me.btnOpenXml.Name = "btnOpenXml"
        Me.btnOpenXml.Size = New System.Drawing.Size(100, 42)
        Me.btnOpenXml.TabIndex = 2
        Me.btnOpenXml.Text = "Abrir Xml"
        Me.btnOpenXml.UseVisualStyleBackColor = False
        '
        'btnImportar
        '
        Me.btnImportar.BackColor = System.Drawing.Color.DarkRed
        Me.btnImportar.FlatAppearance.BorderSize = 0
        Me.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportar.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnImportar.Location = New System.Drawing.Point(215, 412)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(100, 42)
        Me.btnImportar.TabIndex = 3
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = False
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 50
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "Nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        Me.NomeDataGridViewTextBoxColumn.Width = 200
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 200
        '
        'TelefoneDataGridViewTextBoxColumn
        '
        Me.TelefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone"
        Me.TelefoneDataGridViewTextBoxColumn.HeaderText = "Telefone"
        Me.TelefoneDataGridViewTextBoxColumn.Name = "TelefoneDataGridViewTextBoxColumn"
        '
        'ValortotalDataGridViewTextBoxColumn
        '
        Me.ValortotalDataGridViewTextBoxColumn.DataPropertyName = "Valor_total"
        Me.ValortotalDataGridViewTextBoxColumn.HeaderText = "Vlr Total"
        Me.ValortotalDataGridViewTextBoxColumn.Name = "ValortotalDataGridViewTextBoxColumn"
        Me.ValortotalDataGridViewTextBoxColumn.Width = 120
        '
        'ValorcomdescontoDataGridViewTextBoxColumn
        '
        Me.ValorcomdescontoDataGridViewTextBoxColumn.DataPropertyName = "Valor_com_desconto"
        Me.ValorcomdescontoDataGridViewTextBoxColumn.HeaderText = "Vlr com Desconto"
        Me.ValorcomdescontoDataGridViewTextBoxColumn.Name = "ValorcomdescontoDataGridViewTextBoxColumn"
        Me.ValorcomdescontoDataGridViewTextBoxColumn.Width = 120
        '
        'PessoaBindingSource
        '
        Me.PessoaBindingSource.DataSource = GetType(Importador.Pessoa)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 464)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.btnOpenXml)
        Me.Controls.Add(Me.tblRegistros)
        Me.Controls.Add(Me.btnOpenCsv)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(875, 503)
        Me.MinimumSize = New System.Drawing.Size(875, 503)
        Me.Name = "Form1"
        Me.Text = "Importador"
        CType(Me.tblRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PessoaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOpenCsv As Button
    Friend WithEvents tblRegistros As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValortotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorcomdescontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PessoaBindingSource As BindingSource
    Friend WithEvents btnOpenXml As Button
    Friend WithEvents btnImportar As Button
End Class
