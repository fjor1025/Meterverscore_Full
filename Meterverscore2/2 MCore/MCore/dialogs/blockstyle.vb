Public Class blockstyle

    Private Sub translateme()
        Select Case BTRegistry.GetValue(Regz.Language, "null")

            Case "AR"
                msgtitle.Text = "نوع الحظر"
                blackthemetxt.Text = "نمط الشاشة السوداء"
                blockmsgstr.Text = "رسالة الحظر"
                inputtext2.Watermark = "يقبل رسالة فارغة"
                comboblock.Items.Clear()
                comboblock.Items.AddRange(New String() {
                "عادي (شاشة سوداء)",
                "تحديث النظام",
                "تم قفل الجهاز",
                "نفدت البطارية"
            })
                Exit Select

            Case "CN" ' Chinese
                msgtitle.Text = "封锁类型"
                blackthemetxt.Text = "黑屏样式"
                blockmsgstr.Text = "封锁消息"
                inputtext2.Watermark = "接受空消息"
                comboblock.Items.Clear()
                comboblock.Items.AddRange(New String() {
                "正常（黑屏）",
                "系统更新",
                "设备已锁定",
                "电池耗尽"
            })
                Exit Select

            Case "RU" ' Russian
                msgtitle.Text = "Тип блокировки"
                blackthemetxt.Text = "Стиль чёрного экрана"
                blockmsgstr.Text = "Сообщение блокировки"
                inputtext2.Watermark = "Принимает пустое сообщение"
                comboblock.Items.Clear()
                comboblock.Items.AddRange(New String() {
                "Обычный (чёрный экран)",
                "Обновление системы",
                "Устройство заблокировано",
                "Батарея разряжена"
            })
                Exit Select

            Case "TR" ' Turkish
                msgtitle.Text = "Engelleme türü"
                blackthemetxt.Text = "Siyah ekran stili"
                blockmsgstr.Text = "Engelleme mesajı"
                inputtext2.Watermark = "Boş mesaj kabul edilir"
                comboblock.Items.Clear()
                comboblock.Items.AddRange(New String() {
                "Normal (Siyah ekran)",
                "Sistem güncellemesi",
                "Cihaz kilitlendi",
                "Pil bitti"
            })
                Exit Select

            Case "SP" ' Spanish
                msgtitle.Text = "Tipo de bloqueo"
                blackthemetxt.Text = "Estilo de pantalla negra"
                blockmsgstr.Text = "Mensaje de bloqueo"
                inputtext2.Watermark = "Acepta mensaje en blanco"
                comboblock.Items.Clear()
                comboblock.Items.AddRange(New String() {
                "Normal (pantalla negra)",
                "Actualización del sistema",
                "Dispositivo bloqueado",
                "Batería agotada"
            })
                Exit Select

            Case "PR" ' Brazilian Portuguese
                msgtitle.Text = "Tipo de bloqueio"
                blackthemetxt.Text = "Estilo de tela preta"
                blockmsgstr.Text = "Mensagem de bloqueio"
                inputtext2.Watermark = "Aceita mensagem em branco"
                comboblock.Items.Clear()
                comboblock.Items.AddRange(New String() {
                "Normal (tela preta)",
                "Atualização do sistema",
                "Dispositivo bloqueado",
                "Bateria descarregada"
            })
                Exit Select

            Case Else
                ' Handle any other cases or defaults here
        End Select
    End Sub


    Private Sub okbtn_Click(sender As Object, e As EventArgs) Handles okbtn.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub comboblock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboblock.SelectedIndexChanged
        If comboblock.SelectedIndex <> 0 Then
            inputtext2.Text = ""
            inputtext2.Enabled = False
        Else
            inputtext2.Enabled = True
        End If
    End Sub

    Private Sub nobtn_Click(sender As Object, e As EventArgs) Handles nobtn.Click
        Me.DialogResult = DialogResult.No
        Me.Close()
    End Sub

    Private Sub msgtitle_MouseDown(sender As Object, e As MouseEventArgs) Handles msgtitle.MouseDown
        Try
            If e.Button = Windows.Forms.MouseButtons.Left Then
                ReleaseCapture()
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        Try
            If e.Button = Windows.Forms.MouseButtons.Left Then
                ReleaseCapture()
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        Try
            If e.Button = Windows.Forms.MouseButtons.Left Then
                ReleaseCapture()
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub blockstyle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        translateme()
        comboblock.SelectedIndex = 0

    End Sub
End Class