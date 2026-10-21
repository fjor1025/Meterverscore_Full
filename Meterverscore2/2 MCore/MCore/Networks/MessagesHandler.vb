Imports System.Threading
Imports DrakeUI.Framework

Imports System.Collections.Concurrent


Public Class MessagesHandler
    Private isRunning As Boolean = False
    Private Shared ReadOnly messageQueue As New ConcurrentQueue(Of String)()
    Private processingThread As Thread

    Public Sub New()
        isRunning = True
        processingThread = New Thread(AddressOf ProcessMessageQueue)
        processingThread.IsBackground = True
        processingThread.Start()
    End Sub

    ' Enqueue a message from the WebSocket
    Public Shared Sub EnqueueMessage(message As String)
        messageQueue.Enqueue(message)
    End Sub

    ' Graceful stop
    Public Sub [Stop]()
        isRunning = False
        'processingThread.Join() ' Optional: Wait for thread to finish
    End Sub

    Private Sub ProcessMessageQueue()
        While isRunning
            Dim message As String = Nothing

            If messageQueue.TryDequeue(message) Then
                Try
                    SyncLock BTEngine.lockworker
                        BTEngine.HandleMessage(message)
                    End SyncLock
                Catch ex As Exception
                    Log_e("ProcessMessageQueue", EXtoString(ex))
                End Try
            Else
                Thread.Sleep(5) ' Prevent busy loop
            End If
        End While
    End Sub
End Class
