Imports Microsoft.Office.Interop
Imports System

Public Class dalExcel
    Implements IDisposable
    Private _ExcelApplication As Excel.Application 'Exception.application
    Private _ExcelWorkBook As Excel.Workbook
    Private _ExcelWorkSheet As Excel.Worksheet
    Private FechaInicioProceso As Date
    Private _ExcelFunction As Excel.XlConsolidationFunction
    Public Enum ColoresFuente
        Rojo = 3
        Naranja = 44
        Verde = 10
        Azul = 41
        Violeta = 55
        VerdeClaro = 4
    End Enum
    Public Enum ColoresFondo
        Amarillo = 6 'Amarillo
        Turquesa = 8
        VerdeClaro = 35
        Celeste = 34
        Naranja = 40
        Azul = 37
    End Enum
    Public Enum OrientacionHoja
        Horizontal = 1
        Vertical = 2
    End Enum
    '---------------Variables mias--------------------------
    'Dim ObjExcel As Object
    'Dim objLibro As Object
    'Dim objHoja As Object
    '------------------FIN Variables mias---------
    '  Dim mCol As Parametros
    '   Dim strControlName As String
    'Dim objlibros As Excel.Workbook

    'Dim objHojas As Excel.Worksheet
    'Dim objName As Name
    '    Private mDTLPlantilla As New dtlPlantilla

    ' ''Private Sub CrearPlanilla(ByVal ObjExcel As Object, ByVal conn As dalConexion, ByRef arrErrores() As String)

    ' ''    Try
    ' ''        ObjExcel = CreateObject("Excel.Application")

    ' ''    Catch ex As Exception
    ' ''        agregar_error(arrErrores, "dalComando.crearComando: " & ex.Source & " - " & ex.TargetSite.Name & " - " & ex.Message)
    ' ''        If conn Is Nothing Then
    ' ''            agregar_error(arrErrores, "dalComando.crearComando error: conexion no seteada")
    ' ''        ElseIf conn.state = ConnectionState.Closed Then
    ' ''            agregar_error(arrErrores, "dalComando.crearComando error: conexion cerrada")
    ' ''        End If
    ' ''        Throw ex
    ' ''    End Try
    ' ''End Sub

    ''' <summary>
    ''' Crea una hoja de calculo nueva
    ''' </summary>
    ''' <param name="arrErrores"></param>
    ''' <param name="NombreHoja"></param>
    ''' <param name="NombreLibro"></param>
    ''' <param name="visible"></param>
    ''' <remarks></remarks>
    Public Overloads Sub crearHoja(ByRef arrErrores() As String, ByVal NombreHoja As String, ByVal NombreLibro As String, ByVal visible As Boolean)
        Try
            If Me._ExcelApplication Is Nothing Then init(arrErrores, visible)
            If Me._ExcelWorkBook Is Nothing Then crearLibro(arrErrores, visible)
            If NombreLibro Is Nothing Then
                Me._ExcelWorkSheet = Me._ExcelWorkBook.Worksheets.Add
            Else
                Me._ExcelWorkSheet = Me._ExcelApplication.Workbooks(NombreLibro).Worksheets.Add
            End If
            Me._ExcelWorkSheet.Name = NombreHoja

        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Abre una hoja de calculo en una ruta determinada
    ''' </summary>
    ''' <param name="arrErrores"></param>
    ''' <param name="strRuta"></param>
    ''' <param name="visible"></param>
    ''' <remarks></remarks>
    Public Overloads Sub AbrirLibro(ByRef arrErrores() As String, ByVal strRuta As String, ByVal visible As Boolean)
        Try
            If Me._ExcelApplication Is Nothing Then init(arrErrores, visible)

            Me._ExcelWorkBook = Me._ExcelApplication.Workbooks.Open(strRuta)
            Me._ExcelWorkSheet = Me._ExcelWorkBook.ActiveSheet
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Crea una hoja de cálculo nueva. Puede optar por ponerla visible o no.
    ''' </summary>
    ''' <param name="arrErrores"></param>
    ''' <param name="NombreHoja"></param>
    ''' <param name="visible"></param>
    ''' <remarks></remarks>
    Public Overloads Sub crearHoja(ByRef arrErrores() As String, ByVal NombreHoja As String, ByVal visible As Boolean)
        Try
            crearHoja(arrErrores, NombreHoja, Nothing, visible)
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Crea un libro de excel nuevo. Se puede enviar un template para que inicie con un formato predeterminado.
    ''' </summary>
    ''' <param name="arrErrores"></param>
    ''' <param name="LibroTemplate"></param>
    ''' <param name="visible"></param>
    ''' <remarks></remarks>
    Public Overloads Sub crearLibro(ByRef arrErrores() As String, ByVal LibroTemplate As String, ByVal visible As Boolean)
        Try
            If Me._ExcelApplication Is Nothing Then init(arrErrores, visible)
            If LibroTemplate Is Nothing Then
                Me._ExcelWorkBook = Me._ExcelApplication.Workbooks.Add
                Me._ExcelWorkSheet = Me._ExcelApplication.ActiveWorkbook.ActiveSheet
                FechaInicioProceso = Now
            Else
                Me._ExcelWorkBook = Me._ExcelApplication.Workbooks.Add(LibroTemplate)
                Me._ExcelWorkSheet = Me._ExcelApplication.ActiveWorkbook.ActiveSheet
                FechaInicioProceso = Now
            End If
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Crea un nuevo libro
    ''' </summary>
    ''' <param name="arrErrores"></param>
    ''' <param name="visible"></param>
    ''' <remarks></remarks>
    Public Overloads Sub crearLibro(ByRef arrErrores() As String, ByVal visible As Boolean)
        Try
            crearLibro(arrErrores, Nothing, visible)
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Private Sub init(ByRef arrErrores() As String, ByVal visible As Boolean)
        Try
            If Me._ExcelApplication Is Nothing Then
                Me._ExcelApplication = New Excel.Application
                Me._ExcelApplication.Visible = visible
            End If
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Obtiene todos los names de un libro de excel con N hojas
    ''' </summary>
    ''' <param name="arrErrores"></param>
    ''' <param name="visible"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function obtenerNames(ByRef arrErrores() As String, ByVal visible As Boolean) As Collection
        Dim Lista As New Collection
        Dim xlnames As Excel.Names
        Try

            If Me._ExcelApplication Is Nothing Then init(arrErrores, visible)
            xlnames = Me._ExcelApplication.Names
            For Each name As Excel.Name In xlnames
                Lista.Add(name.Name, name.Name)
            Next
            obtenerNames = Lista
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Obtiene un name en particular con un prefijo asignado.
    ''' </summary>
    ''' <param name="arrErrores"></param>
    ''' <param name="prefijo"></param>
    ''' <param name="visible"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function obtenerNames(ByRef arrErrores() As String, ByVal prefijo As String, ByVal visible As Boolean) As Collection
        Dim Lista As New Collection
        Dim xlnames As Excel.Names
        Try

            If Me._ExcelApplication Is Nothing Then init(arrErrores, visible)
            xlnames = Me._ExcelApplication.Names
            For Each name As Excel.Name In xlnames
                If Mid(name, 1, 3) = prefijo Then
                    Lista.Add(0, name.Name)
                End If
            Next
            obtenerNames = Lista
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Le asigna un valor en una celda definida
    ''' </summary>
    ''' <param name="arrErrores"></param>
    ''' <param name="row"></param>
    ''' <param name="col"></param>
    ''' <param name="value"></param>
    ''' <param name="workSheetName"></param>
    ''' <param name="workbookname"></param>
    ''' <param name="visible"></param>
    ''' <remarks></remarks>
    Public Overloads Sub asignarValor(ByRef arrErrores() As String, ByVal row As Integer, ByVal col As Integer, ByVal value As Object, ByVal workSheetName As String, ByVal workbookname As String, ByVal visible As Boolean)
        Try
            If Me._ExcelApplication Is Nothing Then init(arrErrores, visible)
            If Me._ExcelWorkBook Is Nothing Then crearLibro(arrErrores, workbookname)
            If Me._ExcelWorkSheet Is Nothing Then crearHoja(arrErrores, workSheetName, visible)

            Me._ExcelWorkSheet.Cells(row, col) = value
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Le asigna un valor en una celda definida
    ''' </summary>
    ''' <param name="arrErrores"></param>
    ''' <param name="row"></param>
    ''' <param name="col"></param>
    ''' <param name="value"></param>
    ''' <param name="workSheetName"></param>
    ''' <remarks></remarks>
    Public Overloads Sub asignarValor(ByRef arrErrores() As String, ByVal row As Integer, ByVal col As Integer, ByVal value As Object, ByVal workSheetName As String)
        Try
            If Not workSheetName Is Nothing Then
                Me._ExcelWorkSheet = Me._ExcelWorkBook.Worksheets(workSheetName)
            End If
            Me._ExcelWorkSheet.Cells(row, col) = value
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Le asigna un valor en una celda definida
    ''' </summary>
    ''' <param name="arrerrores"></param>
    ''' <param name="row"></param>
    ''' <param name="col"></param>
    ''' <param name="value"></param>
    ''' <remarks></remarks>
    Public Overloads Sub asignarValor(ByVal arrerrores() As String, ByVal row As Integer, ByVal col As Integer, ByVal value As Object)
        Try
            asignarValor(arrerrores, row, col, value, Nothing)
        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    
    ''' <summary>
    ''' Le asigna un valor en un name definido
    ''' </summary>
    ''' <param name="arrerrores"></param>
    ''' <param name="name"></param>
    ''' <param name="value"></param>
    ''' <param name="worksheetname"></param>
    ''' <remarks></remarks>
    Public Overloads Sub asignarValor(ByVal arrerrores() As String, ByVal name As String, ByVal value As Object, ByVal worksheetname As String)
        Try
            If Not worksheetname Is Nothing Then
                Me._ExcelWorkSheet = Me._ExcelWorkBook.Worksheets(worksheetname)
            End If
            Me.SeleccionarHoja(worksheetname)
            Me._ExcelWorkSheet.Range(name).Value = value
        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    


    ''' <summary>
    ''' Obtiene un valor determinado de una celda
    ''' </summary>
    ''' <param name="arrErrores"></param>
    ''' <param name="row"></param>
    ''' <param name="col"></param>
    ''' <param name="worksheetName"></param>
    ''' <param name="workbookname"></param>
    ''' <param name="visible"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function obtenerValor(ByRef arrErrores() As String, ByVal row As Integer, ByVal col As Integer, ByVal worksheetName As String, ByVal workbookname As String, ByVal visible As Boolean) As Object
        Try
            If Me._ExcelApplication Is Nothing Then init(arrErrores, visible)
            If Me._ExcelWorkBook Is Nothing Then crearLibro(arrErrores, workbookname)
            If Me._ExcelWorkSheet Is Nothing Then crearHoja(arrErrores, worksheetName, visible)

            obtenerValor = Me._ExcelWorkSheet.Cells(row, col)
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Function
    
    ''' <summary>
    '''  Obtiene un valor determinado de una celda
    ''' </summary>
    ''' <param name="arrErrores"></param>
    ''' <param name="row"></param>
    ''' <param name="col"></param>
    ''' <param name="worksheetName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function obtenerValor(ByRef arrErrores() As String, ByVal row As Integer, ByVal col As Integer, ByVal worksheetName As String) As Object
        obtenerValor = Nothing
        Try
            If Not worksheetName Is Nothing Then
                Me._ExcelWorkSheet = Me._ExcelWorkBook.Worksheets(worksheetName)
            End If
            obtenerValor = Me._ExcelWorkSheet.Cells(row, col)
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Function

    
    ''' <summary>
    '''  Obtiene un valor determinado de un name.
    ''' </summary>
    ''' <param name="arrErrores"></param>
    ''' <param name="name"></param>
    ''' <param name="worksheetName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function obtenerValor(ByRef arrErrores() As String, ByVal name As String, ByVal worksheetName As String) As Object
        obtenerValor = Nothing
        Try
            If Not worksheetName Is Nothing Then
                Me._ExcelWorkSheet = Me._ExcelWorkBook.Worksheets(worksheetName)
            End If
            obtenerValor = Me._ExcelWorkSheet.Range(name).Value
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Function
    ''' <summary>
    '''  Obtiene un valor determinado de una celda
    ''' </summary>
    ''' <param name="arrErrores"></param>
    ''' <param name="row"></param>
    ''' <param name="col"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function obtenerValor(ByRef arrErrores() As String, ByVal row As Integer, ByVal col As Integer) As Object

        Try
            obtenerValor = obtenerValor(arrErrores, row, col, Nothing)

        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Verifica si esxiste un name en un libro de N hojas
    ''' </summary>
    ''' <param name="arrerrores"></param>
    ''' <param name="name"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function existeName(ByRef arrerrores() As String, ByVal name As String) As Boolean
        Dim i As Integer
        existeName = False
        For i = 1 To Me._ExcelApplication.Names.Count
            If Me._ExcelApplication.Names.Item(i).Name = name Or Me._ExcelApplication.Names.Item(i).Name = name.ToUpper Then
                existeName = True
                Exit Function
            End If
        Next
    End Function

    ''' <summary>
    ''' Cierra el excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub close()
        Me._ExcelWorkSheet = Nothing
        Me._ExcelWorkBook.Close()
        Me._ExcelWorkBook = Nothing
        Me._ExcelApplication.Quit()
        Me._ExcelApplication = Nothing

    End Sub
    ''' <summary>
    ''' Determina si planilla va a estar visible o no
    ''' </summary>
    ''' <param name="arrErrores"></param>
    ''' <param name="valor"></param>
    ''' <remarks></remarks>
    Private Sub Planilla_Visible(ByVal arrErrores() As String, ByVal valor As Boolean)
        Try
            Me._ExcelApplication.Visible = valor
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Determina si los mensajes del tipo "desea guardar ?" estan habilitados
    ''' </summary>
    ''' <param name="arrErrores"></param>
    ''' <param name="valor"></param>
    ''' <remarks></remarks>
    Public Sub HabilitarMensajesdeAlerta(ByVal arrErrores() As String, ByVal valor As Boolean)
        Try
            Me._ExcelApplication.DisplayAlerts = valor
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Private Sub AgregarAddInsBusquedas(ByVal valor As Boolean)
        Me._ExcelApplication.AddIns("Asistente para búsquedas").Installed = valor
    End Sub

    Private Sub AgregarAddInsSumaCond(ByVal valor As Boolean)
        Me._ExcelApplication.AddIns("Asistente para suma condicional").Installed = valor
    End Sub

    Private Sub AgregarAddInsAnalisis(ByVal valor As Boolean)
        Me._ExcelApplication.AddIns("Herramientas para análisis").Installed = valor
    End Sub

    Private Sub AgregarAddInsEuro(ByVal valor As Boolean)
        Me._ExcelApplication.AddIns("Herramientas para el euro").Installed = valor
    End Sub

    Private Sub AgregarAddInsSolver(ByVal valor As Boolean)
        Me._ExcelApplication.AddIns("Solver").Installed = valor
    End Sub

    Private Sub AgregarAddInsAyudante(ByVal valor As Boolean)
        Me._ExcelApplication.AddIns("VBA del Ayudante para Internet").Installed = valor
    End Sub
    ''' <summary>
    ''' Selecciona un rango en una planilla de excel
    ''' </summary>
    ''' <param name="arrErrores"></param>
    ''' <param name="FilaDesde"></param>
    ''' <param name="FilaHasta"></param>
    ''' <param name="ColumnaDesde"></param>
    ''' <param name="ColumnaHasta"></param>
    ''' <remarks></remarks>
    Public Overloads Sub SeleccionarRango(ByVal arrErrores() As String, ByVal FilaDesde As Integer, _
    ByVal FilaHasta As Integer, ByVal ColumnaDesde As Integer, ByVal ColumnaHasta As Integer)

        Me._ExcelWorkSheet.Range(Me._ExcelWorkSheet.Cells(FilaDesde, ColumnaDesde), Me._ExcelWorkSheet.Cells(FilaHasta, ColumnaHasta)).Select()
        Me._ExcelWorkSheet.Range(Me._ExcelWorkSheet.Cells(FilaDesde, ColumnaDesde), Me._ExcelWorkSheet.Cells(FilaHasta, ColumnaHasta)).Activate()
    End Sub
    
    ''' <summary>
    ''' Selecciona un rango en una planilla de excel
    ''' </summary>
    ''' <param name="arrErrores"></param>
    ''' <param name="FilaDesde"></param>
    ''' <param name="FilaHasta"></param>
    ''' <param name="ColumnaDesde"></param>
    ''' <param name="ColumnaHasta"></param>
    ''' <param name="worksheetName"></param>
    ''' <remarks></remarks>
    Public Overloads Sub SeleccionarRango(ByVal arrErrores() As String, ByVal FilaDesde As Integer, _
    ByVal FilaHasta As Integer, ByVal ColumnaDesde As Integer, ByVal ColumnaHasta As Integer, ByVal worksheetName As String)
        Me._ExcelWorkBook.Worksheets(worksheetName).Range(Me._ExcelWorkSheet.Cells(FilaDesde, ColumnaDesde), Me._ExcelWorkSheet.Cells(FilaHasta, ColumnaHasta)).Select()
    End Sub

    ''' <summary>
    ''' Selecciona un rango en una planilla de excel
    ''' </summary>
    ''' <param name="arrErrores"></param>
    ''' <param name="FilaDesde"></param>
    ''' <param name="FilaHasta"></param>
    ''' <param name="ColumnaDesde"></param>
    ''' <param name="ColumnaHasta"></param>
    ''' <param name="worksheetName"></param>
    ''' <param name="workbookName"></param>
    ''' <remarks></remarks>
    Public Overloads Sub SeleccionarRango(ByVal arrErrores() As String, ByVal FilaDesde As Integer, _
   ByVal FilaHasta As Integer, ByVal ColumnaDesde As Integer, ByVal ColumnaHasta As Integer, ByVal worksheetName As String, ByVal workbookName As String)
        Me._ExcelApplication.Workbooks(workbookName).Worksheets(worksheetName).Range(Me._ExcelWorkSheet.Cells(FilaDesde, ColumnaDesde), Me._ExcelWorkSheet.Cells(FilaHasta, ColumnaHasta)).Select()
    End Sub
    Public Sub InsertarFila()
        Me._ExcelWorkBook.Application.Rows.Insert()
    End Sub
    Public Sub InsertarFila_()
        Me._ExcelApplication.Selection.EntireRow.Insert()
    End Sub
    Public Overloads Sub InsertarColumna()
        Me._ExcelWorkBook.Application.Columns.Insert()
    End Sub
    Public Overloads Sub InsertarColumna(ByVal arrerrores() As String)
        Try

            Me._ExcelApplication.Selection.insert(Shift:=Excel.XlDirection.xlToRight)
        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Selecciona una hoja de calculo.
    ''' </summary>
    ''' <param name="name"></param>
    ''' <remarks></remarks>
    Public Sub SeleccionarHoja(ByVal name As String)
        Me._ExcelWorkSheet = Me._ExcelWorkBook.Worksheets(name)
        Me._ExcelWorkSheet.Select()
    End Sub
    Public Sub Dispose() Implements System.IDisposable.Dispose
    End Sub
    ''' <summary>
    ''' Mata la aplicacion. La quita de los procesos que estan corriendo. Fundamental! Debe usarse cada vez que se 
    ''' utiliza la clase Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub MatarApp()
        Dim proceso As System.Diagnostics.Process()
        proceso = System.Diagnostics.Process.GetProcessesByName("EXCEL")

        For Each opro As System.Diagnostics.Process In proceso
            'antes de iniciar el proceso obtengo la fecha en que inicie el 
            'proceso para detener todos los procesos que excel que inicio
            'mi código durante el proceso
            'If opro.StartTime >= fechaInicioProceso Then
            opro.Kill()
            'End If
        Next
    End Sub
    ''' <summary>
    ''' Guarda en una ruta deseada con un nombre y el agregado de fecha y hora.
    ''' </summary>
    ''' <param name="NombreExcel"></param>
    ''' <param name="ruta"></param>
    ''' <remarks></remarks>
    Public Overloads Sub FormatearYGuardar(ByVal NombreExcel As String, ByVal ruta As String)
        Dim Fecha As String
        Dim Hora As String
        Fecha = QuitarBarras()
        Hora = QuitarPuntos()
        NombreExcel = NombreExcel & "_" & Fecha & "_" & Hora
        Me._ExcelWorkBook.SaveAs(ruta & NombreExcel & ".xls") ', FileFormat:=xlNormal, Password:="", WriteResPassword:="", ReadOnlyRecommended:=False, CreateBackup:=False
    End Sub
    Public Overloads Sub FormatearYGuardar(ByVal NombreExcel As String, ByVal ruta As String, ByVal FechaAux As Date)
        Dim Fecha As String
        Dim Hora As String
        Fecha = QuitarBarras(FechaAux)
        Hora = QuitarPuntos()
        NombreExcel = NombreExcel & "_" & Fecha & "_" & Hora
        Me._ExcelWorkBook.SaveAs(ruta & NombreExcel & ".xls") ', FileFormat:=xlNormal, Password:="", WriteResPassword:="", ReadOnlyRecommended:=False, CreateBackup:=False
    End Sub
    Public Overloads Sub FormatearYGuardar(ByVal NombreExcel As String, ByVal ruta As String, ByVal FechaDesdeAux As Date, ByVal FechaHastaAux As Date)
        Dim FechaDesde As String
        Dim FechaHasta As String
        Dim Hora As String
        FechaDesde = QuitarBarras(FechaDesdeAux)
        FechaHasta = QuitarBarras(FechaHastaAux)
        Hora = QuitarPuntos()
        NombreExcel = NombreExcel & "_" & FechaDesde & "_" & FechaHasta & "_" & Hora
        Me._ExcelWorkBook.SaveAs(ruta & NombreExcel & ".xls") ', FileFormat:=xlNormal, Password:="", WriteResPassword:="", ReadOnlyRecommended:=False, CreateBackup:=False
    End Sub
    Private Overloads Function QuitarBarras() As String
        Dim dia As String
        Dim mes As String
        Dim anio As String

        dia = Day(Now)
        If dia < 10 Then
            dia = "0" & dia
        End If

        mes = Month(Now)
        If mes < 10 Then
            mes = "0" & mes
        End If
        anio = Year(Now)

        QuitarBarras = dia & mes & anio

    End Function
    Private Overloads Function QuitarBarras(ByVal Fecha As Date) As String
        Dim dia As String
        Dim mes As String
        Dim anio As String

        dia = Day(Fecha)
        If dia < 10 Then
            dia = "0" & dia
        End If

        mes = Month(Fecha)
        If mes < 10 Then
            mes = "0" & mes
        End If
        anio = Year(Fecha)

        QuitarBarras = dia & mes & anio

    End Function

    Private Function QuitarPuntos()
        Dim hora As String
        Dim minutos As String
        Dim segundos As String

        hora = Hour(DateTime.Now)
        If hora < 10 Then
            hora = "0" & hora
        End If
        minutos = Minute(DateTime.Now)
        If minutos < 10 Then
            minutos = "0" & minutos
        End If

        segundos = Second(DateTime.Now)
        If segundos < 10 Then
            segundos = "0" & segundos
        End If

        QuitarPuntos = hora & minutos & segundos
    End Function

    Public Sub SumarRango(ByVal filaSumatoria As Integer, ByVal FilaDesdeSumatoria As Integer, _
    ByVal filaHastaSumatoria As Integer, ByVal columna As String, ByVal arrerrores() As String)
        Try

            'Me.SeleccionarRango(arrerrores, filaSumatoria, filaSumatoria, columna, columna)

            Me._ExcelWorkSheet.Range(columna & filaSumatoria).Select()

            Dim filaSum As Integer
            filaSum = (filaHastaSumatoria + 1) - FilaDesdeSumatoria
            'Me._ExcelWorkSheet.Range(columna & filaSumatoria).FormulaR1C1 = "=SUM(RC[-" & filaSum & "]:RC[-1])"

            Me._ExcelApplication.ActiveCell.FormulaR1C1 = "=SUM(R[-" & filaSum & "]C:R[-1]C)" '"=SUMA(RC[-" & columnaHastaSumatoria - 4 & "]:RC[-1] )"

            'ActiveCell.FormulaR1C1 = "=SUM(R[-5]C:R[-1]C)"

            '"=SUMA(" & columna & FilaDesdeSumatoria & ":" & columna & filaHastaSumatoria & ")"
            SetearFuente("Arial", 10, True, False)
        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try

    End Sub
    Public Sub SumarRangoPorFila(ByVal fila As Integer, ByVal columnaDesdeSumatoria As Integer, _
        ByVal columnaHastaSumatoria As Integer, ByVal columnaSumatoria As Integer, ByVal arrerrores() As String)
        Try


            Me.SeleccionarRango(arrerrores, fila, fila, columnaSumatoria, columnaSumatoria)

            ' Me._ExcelWorkSheet.Cells(fila, columnaSumatoria).Formula = "=SUM(" & Me._ExcelWorkSheet.Cells(fila, columnaDesdeSumatoria) & ":" & Me._ExcelWorkSheet.Cells(fila, columnaHastaSumatoria) & ")"
            'Cambie RC por FC debido  que comenzo a fallar. Error de inversiones! 12/05/2014 Diego Spinedi
            Me._ExcelApplication.ActiveCell.FormulaR1C1 = "=SUM(RC[-" & columnaHastaSumatoria & "]:RC[-1])" '"=SUMA(RC[-" & columnaHastaSumatoria - 4 & "]:RC[-1] )"
            '=SUM(" & columnaDesdeSumatoria & fila & ":" & columnaHastaSumatoria & fila & ")"
            SetearFuente("Arial", 10, True, False)
        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try

    End Sub
    Public Sub SumarRangoPorColumna(ByVal filaSumatoria As Integer, _
    ByVal columna As Integer, ByVal cantidadFilasHaciaArriba As Integer, ByVal arrerrores() As String)
        Try


            Me.SeleccionarRango(arrerrores, filaSumatoria, filaSumatoria, columna, columna)

            ' Me._ExcelWorkSheet.Cells(fila, columnaSumatoria).Formula = "=SUM(" & Me._ExcelWorkSheet.Cells(fila, columnaDesdeSumatoria) & ":" & Me._ExcelWorkSheet.Cells(fila, columnaHastaSumatoria) & ")"

            Me._ExcelApplication.ActiveCell.FormulaR1C1 = "=SUM(R[-" & cantidadFilasHaciaArriba & "]C:R[-1]C)"

            '=SUM(" & columnaDesdeSumatoria & fila & ":" & columnaHastaSumatoria & fila & ")"
            SetearFuente("Arial", 7, True, False)
        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try

    End Sub

    Public Overloads Sub SetearFuente(ByVal NombreFuente As String, ByVal Tamanio As Integer, ByVal Negrita As Boolean, ByVal Cursiva As Boolean)
        'Entablece el tipo de fuente de la hoja de un libro a Verdana 10

        With Me._ExcelApplication.Selection.Font
            .name = NombreFuente
            .Size = Tamanio
            .Strikethrough = False
            .Superscript = False
            .Subscript = False
            .OutlineFont = False
            .Shadow = False
            .Bold = Negrita
            .Italic = Cursiva

            'Constantes de excel= excel.Constants.
        End With
    End Sub
    Public Overloads Sub SetearFuente(ByVal NombreFuente As String, ByVal Tamanio As Integer, ByVal Negrita As Boolean, ByVal Cursiva As Boolean, ByVal subrayado As Boolean)
        'Entablece el tipo de fuente de la hoja de un libro a Verdana 10

        With Me._ExcelApplication.Selection.Font
            .name = NombreFuente
            .Size = Tamanio
            .Strikethrough = False
            .Superscript = False
            .Subscript = False
            .OutlineFont = False
            .Shadow = False
            .Bold = Negrita
            .Italic = Cursiva
            .Underline = subrayado
            'Constantes de excel= excel.Constants.
        End With
    End Sub
    Public Overloads Sub InsertarSubtotales(ByVal arrErrores() As String, ByVal TotalColumnas As Integer)
        Try
            Dim fiel(TotalColumnas - 1) As Integer
            Dim i As Integer
            Dim x As Integer
            x = 0
            For i = 0 To TotalColumnas - 1
                fiel(x) = i + 3
                x = x + 1
            Next
            Me.SeleccionarRango(arrErrores, 4, 4, 3, 3)
            Me.SeleccionarDatosHastaElFinal(arrErrores)
            Me.HabilitarMensajesdeAlerta(arrErrores, False)
            Me._ExcelApplication.Selection.Subtotal(GroupBy:=1, Function:=Excel.XlConsolidationFunction.xlSum, TotalList:=fiel, Replace:=True _
            , PageBreaks:=False, SummaryBelowData:=True)
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try

    End Sub
    Public Overloads Sub InsertarSubtotales(ByVal arrErrores() As String, ByVal TotalColumnas As Integer, ByVal FilaDesde As Integer, _
    ByVal FilaHasta As Integer, ByVal ColumnaDesde As Integer, ByVal ColumnaHasta As Integer)
        Try
            Dim fiel(TotalColumnas - 1) As Integer
            Dim i As Integer
            Dim x As Integer
            x = 0
            For i = 0 To TotalColumnas - 1
                fiel(x) = i + 4
                x = x + 1
            Next
            Me.SeleccionarRango(arrErrores, FilaDesde, FilaHasta, ColumnaDesde, ColumnaHasta)
            Me.SeleccionarDatosHastaElFinal(arrErrores)
            Me.HabilitarMensajesdeAlerta(arrErrores, False)
            Me._ExcelApplication.Selection.Subtotal(GroupBy:=1, Function:=Excel.XlConsolidationFunction.xlSum, TotalList:=fiel, Replace:=True _
            , PageBreaks:=False, SummaryBelowData:=True)
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try

    End Sub
    ''' <summary>
    ''' Selecciona datos para insertar subtotales.
    ''' </summary>
    ''' <param name="arrErrores"></param>
    ''' <remarks></remarks>
    Private Sub SeleccionarDatosHastaElFinal(ByVal arrErrores() As String)
        Try
            Me._ExcelApplication.Range(Me._ExcelApplication.Selection, Me._ExcelApplication.ActiveCell.SpecialCells(Excel.XlCellType.xlCellTypeLastCell)).Select()
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Sub PosicionarHoja(ByVal arrerrores() As String, ByVal NombreHoja As String, ByVal posicion As Integer)
        Try
            Me._ExcelApplication.Sheets(NombreHoja).Select()
            Me._ExcelApplication.Sheets(NombreHoja).Move(After:=Me._ExcelApplication.Sheets(posicion))
        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Sub PosicionarHoja(ByVal arrerrores() As String, ByVal NombreHoja As String)
        Try
            Me._ExcelApplication.Sheets(NombreHoja).Select()
        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Overloads Sub agregarSumaPorFila_Posicion(ByVal arrErrores() As String, ByVal columnaInicial As Integer, _
                                  ByVal columnaFinal As Integer, _
                                  ByVal ultimaFila As Integer)
        Try
            Dim i As Integer
            Dim Texto As String
            For i = 1 To ultimaFila + 1
                Texto = Me._ExcelApplication.Range("C" & i).Value
                If InStr(1, Texto, "Total") = 1 Then
                    SumarRangoPorFila(i, columnaInicial, columnaFinal, columnaFinal + 1, arrErrores)
                End If

            Next i
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Overloads Sub agregarSumaPorFila_Posicion(ByVal arrErrores() As String, ByVal columnaInicial As Integer, _
                                      ByVal columnaFinal As Integer, _
                                      ByVal ultimaFila As Integer, _
                                      ByVal columnaBusqueda As String)
        Try
            Dim i As Integer
            Dim Texto As String
            For i = 1 To ultimaFila + 1
                Texto = Me._ExcelApplication.Range(columnaBusqueda & i).Value
                If InStr(1, Texto, "Total") = 1 Then
                    SumarRangoPorFila(i, columnaInicial, columnaFinal, columnaFinal + 1, arrErrores)
                End If

            Next i
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Function LeerCelda(ByVal arrErrores() As String, ByVal FilaDesde As Integer, _
        ByVal FilaHasta As Integer, ByVal ColumnaDesde As Integer, ByVal ColumnaHasta As Integer) As String

        LeerCelda = Me._ExcelWorkSheet.Range(Me._ExcelWorkSheet.Cells(FilaDesde, ColumnaDesde), Me._ExcelWorkSheet.Cells(FilaHasta, ColumnaHasta)).FormulaR1C1

    End Function
    Public Function LeerCelda(ByVal arrErrores() As String, ByVal FilaDesde As Integer, _
           ByVal FilaHasta As Integer, ByVal ColumnaDesde As Integer, ByVal ColumnaHasta As Integer, ByVal NombreHoja As String) As String
        Try
            Me._ExcelApplication.Sheets(NombreHoja).Select()
            LeerCelda = Me._ExcelApplication.ActiveSheet.Range(Me._ExcelWorkSheet.Cells(FilaDesde, ColumnaDesde), Me._ExcelWorkSheet.Cells(FilaHasta, ColumnaHasta)).FormulaR1C1
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Function
    Public Sub SumarInstrumentosPorFila_Posicion(ByVal arrerrores() As String, _
                                                  ByVal columnaInstrumentos As Integer, _
                                                  ByVal columnaSumatoria As Integer, _
                                                  ByVal textoBuscar As String, _
                                                  ByVal FilaHasta As Integer)
        Try
            Dim i As Integer
            Dim Texto As String
            Dim FilaDesde As Integer
            For i = 1 To FilaHasta
                Texto = LeerCelda(arrerrores, i, i, columnaInstrumentos, columnaInstrumentos)
                If Texto = textoBuscar Then
                    FilaDesde = i
                    Exit For
                End If
            Next
            If FilaDesde > 0 Then
                Do While Not InStr(1, LeerCelda(arrerrores, FilaDesde, FilaDesde, columnaInstrumentos, columnaInstrumentos), "Total") = 1
                    If (LeerCelda(arrerrores, FilaDesde, FilaDesde, columnaInstrumentos, columnaInstrumentos) <> "") Or _
                       (LeerCelda(arrerrores, FilaDesde, FilaDesde, columnaInstrumentos + 1, columnaInstrumentos + 1)) <> "" Then
                        SumarRangoPorFila(FilaDesde, columnaInstrumentos + 2, columnaSumatoria - 1, columnaSumatoria + 1, arrerrores)

                    End If
                    FilaDesde = FilaDesde + 1
                Loop
            End If

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Sub SumarInstrumentosPorFila_PosicionAgrupado(ByVal arrerrores() As String, _
                                                     ByVal columnaInstrumentos As Integer, _
                                                     ByVal columnaSumatoria As Integer, _
                                                     ByVal textoBuscar As String, _
                                                     ByVal FilaHasta As Integer, _
                                                     ByVal columnaMonedas As Integer)
        Try
            Dim i As Integer
            Dim Texto As String
            Dim FilaDesde As Integer
            For i = 1 To FilaHasta
                Texto = LeerCelda(arrerrores, i, i, columnaInstrumentos, columnaInstrumentos)
                If Texto = textoBuscar Then
                    FilaDesde = i
                    Exit For
                End If
            Next
            If FilaDesde > 0 Then
                Do While Not InStr(1, LeerCelda(arrerrores, FilaDesde, FilaDesde, columnaInstrumentos, columnaInstrumentos), "Total") = 1
                    If (LeerCelda(arrerrores, FilaDesde, FilaDesde, columnaMonedas - 2, columnaMonedas - 2) <> "") Or _
                       (LeerCelda(arrerrores, FilaDesde, FilaDesde, columnaMonedas - 1, columnaMonedas - 1)) <> "" Then
                        SumarRangoPorFila(FilaDesde, columnaMonedas, columnaSumatoria - 1, columnaSumatoria, arrerrores)

                    End If
                    FilaDesde = FilaDesde + 1
                Loop
            End If

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub

    Public Sub CopiarHoja(ByVal arrerrores() As String, ByVal strNombreHoja As String, ByVal intIndiceHojaCopiar As Integer)
        Try
            Me._ExcelApplication.Sheets(strNombreHoja).Select()
            Me._ExcelApplication.Sheets(strNombreHoja).Copy(Before:=Me._ExcelApplication.Sheets(intIndiceHojaCopiar))
            Me._ExcelApplication.Sheets(strNombreHoja & " " & "(2)").Select()


        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try

    End Sub
    Public Sub CortarYPegarSeleccion(ByVal arrerrores() As String, ByVal filaDesde As Integer, _
    ByVal filaHasta As Integer, ByVal columnaDesde As Integer, _
    ByVal columnaHasta As Integer, ByVal filaDestino As Integer, ByVal columnaDestino As Integer)
        Try
            Me.SeleccionarRango(arrerrores, filaDesde, filaHasta, columnaDesde, columnaHasta)
            Me._ExcelApplication.Selection.Cut()
            Me.SeleccionarRango(arrerrores, filaDestino, filaDestino, columnaDestino, columnaDestino)
            Me._ExcelApplication.ActiveSheet.paste()

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try

    End Sub
    Public Sub CortarYPegarSeleccion(ByVal arrerrores() As String, ByVal filaDesde As Integer, _
        ByVal filaHasta As Integer, ByVal columnaDesde As Integer, _
        ByVal columnaHasta As Integer, ByVal filaDestino As Integer, ByVal columnaDestino As Integer, _
        ByVal strNombreHojaOrigen As String, ByVal strNombreHojaDestino As String)
        Try
            Me.SeleccionarHoja(strNombreHojaOrigen)
            Me.SeleccionarRango(arrerrores, filaDesde, filaHasta, columnaDesde, columnaHasta)
            Me._ExcelApplication.Selection.Cut()
            Me.SeleccionarHoja(strNombreHojaDestino)
            Me.SeleccionarRango(arrerrores, filaDestino, filaDestino, columnaDestino, columnaDestino)
            Me._ExcelApplication.ActiveSheet.paste()

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try

    End Sub
    Public Sub CopiarYPegarSeleccion(ByVal arrerrores() As String, ByVal filaDesde As Integer, _
            ByVal filaHasta As Integer, ByVal columnaDesde As Integer, _
            ByVal columnaHasta As Integer, ByVal filaDestino As Integer, ByVal columnaDestino As Integer, _
            ByVal strNombreHojaOrigen As String, ByVal strNombreHojaDestino As String)
        Try
            Me.SeleccionarHoja(strNombreHojaOrigen)
            Me.SeleccionarRango(arrerrores, filaDesde, filaHasta, columnaDesde, columnaHasta)
            Me._ExcelApplication.Selection.copy()
            Me.SeleccionarHoja(strNombreHojaDestino)
            Me.SeleccionarRango(arrerrores, filaDestino, filaDestino, columnaDestino, columnaDestino)
            Me._ExcelApplication.Selection.PasteSpecial(Paste:=Excel.XlPasteType.xlPasteValues, Operation:=Excel.Constants.xlNone, SkipBlanks:=False, Transpose:=False)

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try

    End Sub
    Public Sub EliminarColumna(ByVal arrerrores() As String, ByVal columnaDesde As String, ByVal columnaHasta As String)
        Try
            Me._ExcelApplication.Columns(columnaDesde & ":" & columnaHasta).Select()
            Me._ExcelApplication.Selection.Delete(Shift:=Excel.XlDirection.xlToLeft)

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Sub EliminarFilas(ByVal arrerrores() As String, ByVal filaDesde As Integer, ByVal filaHasta As Integer)
        Try
            Me._ExcelApplication.Rows(filaDesde & ":" & filaHasta).Select()
            Me._ExcelApplication.Selection.Delete(Shift:=Excel.XlDirection.xlUp)

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try

    End Sub
    Public Sub SeleccionarCeldas(ByVal arrerrores() As String)
        Try
            Me._ExcelApplication.Cells.Select()

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Sub FormateoConLineas(ByVal arrerrores() As String, ByVal filaDesde As Integer, _
                                  ByVal filaHasta As Integer, ByVal columnaDesde As Integer, _
                                  ByVal columnaHasta As Integer, ByVal borderDiagDown As Boolean, _
                                  ByVal borderDiagUp As Boolean, ByVal borderEdgeLeft As Boolean, _
                                  ByVal borderEdgeTop As Boolean, ByVal borderEdgeBottom As Boolean, _
                                  ByVal borderEdgeRight As Boolean, ByVal borderInsideVertical As Boolean, _
                                  ByVal borderInsideHorizontal As Boolean, ByVal lineaGruesa As Boolean, _
                                  ByVal lngColor As Integer)


        Me.SeleccionarRango(arrerrores, filaDesde, filaHasta, columnaDesde, columnaHasta)
        If borderDiagDown Then
            With Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlDiagonalDown)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                If lineaGruesa Then
                    .Weight = Excel.XlBorderWeight.xlMedium
                Else
                    .Weight = Excel.XlBorderWeight.xlThin
                End If
                .ColorIndex = lngColor
            End With
        End If
        If borderDiagUp Then
            With Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlDiagonalUp)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                If lineaGruesa Then
                    .Weight = Excel.XlBorderWeight.xlMedium
                Else
                    .Weight = Excel.XlBorderWeight.xlThin
                End If
                .ColorIndex = lngColor
            End With
        End If
        If borderEdgeLeft Then
            With Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                If lineaGruesa Then
                    .Weight = Excel.XlBorderWeight.xlMedium
                Else
                    .Weight = Excel.XlBorderWeight.xlThin
                End If
                .ColorIndex = lngColor
            End With
        End If
        If borderEdgeTop Then
            With Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlEdgeTop)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                If lineaGruesa Then
                    .Weight = Excel.XlBorderWeight.xlMedium
                Else
                    .Weight = Excel.XlBorderWeight.xlThin
                End If
                .ColorIndex = lngColor
            End With
        End If
        If borderEdgeBottom Then
            With Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                If lineaGruesa Then
                    .Weight = Excel.XlBorderWeight.xlMedium
                Else
                    .Weight = Excel.XlBorderWeight.xlThin
                End If
                .ColorIndex = lngColor
            End With
        End If
        If borderEdgeRight Then
            With Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlEdgeRight)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                If lineaGruesa Then
                    .Weight = Excel.XlBorderWeight.xlMedium
                Else
                    .Weight = Excel.XlBorderWeight.xlThin
                End If
                .ColorIndex = lngColor
            End With
        End If
        If borderInsideVertical Then
            With Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlInsideVertical)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                If lineaGruesa Then
                    .Weight = Excel.XlBorderWeight.xlMedium
                Else
                    .Weight = Excel.XlBorderWeight.xlThin
                End If
                .ColorIndex = lngColor
            End With
        End If
        If borderInsideHorizontal Then
            With Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlInsideHorizontal)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                If lineaGruesa Then
                    .Weight = Excel.XlBorderWeight.xlMedium
                Else
                    .Weight = Excel.XlBorderWeight.xlThin
                End If
                .ColorIndex = lngColor
            End With
        End If
        
    End Sub
    Public Sub FormateoListadoConLineas(ByVal arrerrores() As String)
        Try

            Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlDiagonalDown).LineStyle = Excel.Constants.xlNone
            Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlDiagonalUp).LineStyle = Excel.Constants.xlNone
            With Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlThick
                .ColorIndex = Excel.Constants.xlAutomatic
            End With
            With Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlEdgeTop)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlThick
                .ColorIndex = Excel.Constants.xlAutomatic
            End With
            With Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlThick
                .ColorIndex = Excel.Constants.xlAutomatic
            End With
            With Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlEdgeRight)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlThick
                .ColorIndex = Excel.Constants.xlAutomatic
            End With
            With Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlInsideVertical)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.Constants.xlAutomatic
            End With
            With Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlInsideHorizontal)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.Constants.xlAutomatic
            End With

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Sub FormatearCeldaConLinea(ByVal arrerrores() As String)
        Try
            Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlDiagonalDown).LineStyle = Excel.Constants.xlNone
            Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlDiagonalUp).LineStyle = Excel.Constants.xlNone
            With Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlMedium
                .ColorIndex = Excel.Constants.xlAutomatic
            End With
            With Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlEdgeTop)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlMedium
                .ColorIndex = Excel.Constants.xlAutomatic
            End With
            With Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlMedium
                .ColorIndex = Excel.Constants.xlAutomatic
            End With
            With Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlEdgeRight)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlMedium
                .ColorIndex = Excel.Constants.xlAutomatic
            End With
            Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.Constants.xlNone
        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Sub FormatearSeleccionConLineasInteriores(ByVal arrerrores() As String)
        Try

            With Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlInsideVertical)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlMedium
                .ColorIndex = Excel.Constants.xlAutomatic
            End With
            With Me._ExcelApplication.Selection.Borders(Excel.XlBordersIndex.xlInsideHorizontal)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlMedium
                .ColorIndex = Excel.Constants.xlAutomatic
            End With

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub

    Public Sub AutoajustarCeldas(ByVal arrerrores() As String)
        Try

            Me._ExcelApplication.Cells.EntireColumn.AutoFit()

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Sub AjustarAnchoColumnas(ByVal arrerrores() As String, ByVal columnaDesde As String, ByVal columnaHasta As String, ByVal tamanio As Double)
        Try

            Me._ExcelApplication.Columns(columnaDesde & ":" & columnaHasta).Select()
            Me._ExcelApplication.Selection.ColumnWidth = tamanio
        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Sub AjustarAltoFilas(ByVal arrerrores() As String, ByVal filaDesde As Integer, ByVal filaHasta As Integer, ByVal tamanio As Double)
        Try
            Me._ExcelApplication.Rows(filaDesde & ":" & filaHasta).Select()
            Me._ExcelApplication.Selection.RowHeight = tamanio
            Me._ExcelApplication.Rows(filaDesde & ":" & filaHasta).EntireRow.AutoFit()
        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Sub ConfigurarPagina(ByVal arrerrores() As String)
        Try

            With Me._ExcelApplication.ActiveSheet.PageSetup
                .PrintTitleRows = "$3:$3"
                .PrintTitleColumns = "$A:$A"
            End With
            Me._ExcelApplication.ActiveSheet.PageSetup.PrintArea = ""
            With Me._ExcelApplication.ActiveSheet.PageSetup
                .LeftHeader = ""
                .CenterHeader = ""
                .RightHeader = ""
                .LeftFooter = ""
                .CenterFooter = "&P de &N"
                .RightFooter = ""
                .LeftMargin = Me._ExcelApplication.InchesToPoints(0.787401575)
                .RightMargin = Me._ExcelApplication.InchesToPoints(0.787401575)
                .TopMargin = Me._ExcelApplication.InchesToPoints(0.984251969)
                .BottomMargin = Me._ExcelApplication.InchesToPoints(0.984251969)
                .HeaderMargin = Me._ExcelApplication.InchesToPoints(0)
                .FooterMargin = Me._ExcelApplication.InchesToPoints(0)
                .PrintHeadings = False
                .PrintGridlines = False
                .PrintComments = Excel.XlPrintLocation.xlPrintNoComments
                '.PrintQuality = 600
                .CenterHorizontally = False
                .CenterVertically = False
                .Orientation = Excel.XlPageOrientation.xlLandscape
                .Draft = False
                .PaperSize = Excel.XlPaperSize.xlPaperA4
                .FirstPageNumber = Excel.Constants.xlAutomatic
                .Order = Excel.XlOrder.xlDownThenOver
                .BlackAndWhite = False
                .Zoom = 100
                .PrintErrors = Excel.XlPrintErrors.xlPrintErrorsDisplayed
            End With
            With Me._ExcelApplication.ActiveSheet.PageSetup
                .PrintTitleRows = "$3:$3"
                .PrintTitleColumns = "$A:$A"
            End With
            Me._ExcelApplication.ActiveSheet.PageSetup.PrintArea = ""

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Sub ConfigurarPagina(ByVal arrerrores() As String, ByVal orientaHoja As OrientacionHoja, _
                                ByVal ajustara1hojaHorizontal As Boolean, _
                                ByVal ajustara1hojaVertical As Boolean)
        Try

            With Me._ExcelApplication.ActiveSheet.PageSetup
                .PrintTitleRows = "$3:$3"
                .PrintTitleColumns = "$A:$A"
            End With
            Me._ExcelApplication.ActiveSheet.PageSetup.PrintArea = ""
            With Me._ExcelApplication.ActiveSheet.PageSetup
                .LeftHeader = ""
                .CenterHeader = ""
                .RightHeader = ""
                .LeftFooter = ""
                .CenterFooter = "&P de &N"
                .RightFooter = ""
                .LeftMargin = Me._ExcelApplication.InchesToPoints(0.787401575)
                .RightMargin = Me._ExcelApplication.InchesToPoints(0.787401575)
                .TopMargin = Me._ExcelApplication.InchesToPoints(0.984251969)
                .BottomMargin = Me._ExcelApplication.InchesToPoints(0.984251969)
                .HeaderMargin = Me._ExcelApplication.InchesToPoints(0)
                .FooterMargin = Me._ExcelApplication.InchesToPoints(0)
                .PrintHeadings = False
                .PrintGridlines = False
                .PrintComments = Excel.XlPrintLocation.xlPrintNoComments
                '.PrintQuality = 600
                .CenterHorizontally = False
                .CenterVertically = False
                If orientaHoja = OrientacionHoja.Horizontal Then
                    .Orientation = Excel.XlPageOrientation.xlLandscape ' Horizonatal
                Else
                    .Orientation = Excel.XlPageOrientation.xlPortrait ' Vertical
                End If
                .Draft = False
                .PaperSize = Excel.XlPaperSize.xlPaperA4
                .FirstPageNumber = Excel.Constants.xlAutomatic
                .Order = Excel.XlOrder.xlDownThenOver
                .BlackAndWhite = False
                .PrintErrors = Excel.XlPrintErrors.xlPrintErrorsDisplayed
                If ajustara1hojaHorizontal = True Then
                    .Zoom = False
                    .FitToPagesWide = 1
                End If
                If ajustara1hojaVertical = True Then
                    .FitToPagesTall = 1
                End If
            End With


        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Sub AjustarTextoenFila(ByVal arrerrores() As String, ByVal filaDesde As Integer, ByVal filaHasta As Integer)
        Try
            Me._ExcelApplication.Rows(filaDesde & ":" & filaHasta).Select()
            Me._ExcelApplication.Selection.wraptext = True

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Sub FormatearNumeros(ByVal arrerrores() As String)
        Try

            Me._ExcelApplication.Selection.NumberFormat = "#,##0.00" '"#.##0,00" Cambie el formato porque me daba error


        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Sub FormatearNumeros(ByVal arrerrores() As String, ByVal cantDecimales As Integer)
        Try
            Dim i As Integer
            Dim strdecimales As String = ""
            If cantDecimales > 0 Then
                For i = 1 To cantDecimales
                    strdecimales = strdecimales + "0"
                Next
                Me._ExcelApplication.Selection.NumberFormat = "#,##0." & strdecimales ''"#.##0,
            Else
                Me._ExcelApplication.Selection.NumberFormat = "#,##0" '"#.##0"
            End If



        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Sub FormatearNumeros(ByVal arrerrores() As String, ByVal cantDecimales As Integer, ByVal signo As String)
        Try
            Dim i As Integer
            Dim strdecimales As String = ""
            If cantDecimales > 0 Then
                For i = 1 To cantDecimales
                    strdecimales = strdecimales + "0"
                Next
                Me._ExcelApplication.Selection.NumberFormat = signo & "#,##0" & "." & strdecimales
            Else
                Me._ExcelApplication.Selection.NumberFormat = signo & "#,##0"
            End If

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub



    Public Sub PintarCelda(ByVal arrerrores() As String, ByVal lngcolor As Integer)
        Try
            With Me._ExcelApplication.Selection.Interior
                .ColorIndex = lngcolor
                .Pattern = Excel.Constants.xlSolid
            End With
        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Sub FormatearListadoPosicion(ByVal arrerrores() As String, ByVal FilaHasta As Integer, ByVal cantColumnas As Integer)
        Try
            Dim i As Integer
            Dim strTexto As String
            Dim FilaAux As Integer
            Dim FilaFin As Integer
            Dim strTipoFondo As String
            CopiarHoja(arrerrores, "Hoja1", 1)
            Me.SeleccionarHoja("Hoja1 (2)")

            For i = 1 To FilaHasta
                'Recorro hasta encontrar texto
                strTexto = LeerCelda(arrerrores, i, i, 3, 3)
                If strTexto <> "Total general" Then
                    If strTexto <> "" Then
                        strTipoFondo = LeerCelda(arrerrores, i, i, 2, 2)

                        Me.SeleccionarRango(arrerrores, i, i, 3, 3)
                        InsertarFila_()
                        'Corto y Pego el instrumento financiero*******************************
                        CortarYPegarSeleccion(arrerrores, i + 1, i + 1, 3, 3, i, 2)
                        'Busco desde donde empiezan las monedas hasta donde terminan**********
                        FilaAux = i + 1
                        Do While Not (InStr(1, LeerCelda(arrerrores, i, i, 3, 3), "Total") = 1)
                            i = i + 1
                        Loop
                        FilaFin = i - 1
                        'corto y pego las monedas***********************************************
                        Me.CortarYPegarSeleccion(arrerrores, FilaAux, FilaFin, 4, 4, FilaAux, 2)
                        '**************Le agrego la leyenda de tipod e fondo cuando es distinto de Previsional

                        'Corto y pego el total**************************************************
                        Me.CortarYPegarSeleccion(arrerrores, i, i, 3, 3, i, 2)

                        '***********************************************************************
                    End If
                Else
                    Me.SeleccionarRango(arrerrores, i, i, 3, 3)
                    CortarYPegarSeleccion(arrerrores, i, i, 3, 3, i, 2)

                End If
            Next
            Me.asignarValor(arrerrores, 3, cantColumnas, "Total")
            Me.EliminarColumna(arrerrores, "A", "A")
            Me.EliminarColumna(arrerrores, "C", "C")
            Me.EliminarColumna(arrerrores, "B", "B")
            Me.SeleccionarCeldas(arrerrores)
            Me.FormatearNumeros(arrerrores)
            Me.SetearFuente("Arial", 7, False, False)
            Me.FormateoListadoConLineas(arrerrores)
            Me.AutoajustarCeldas(arrerrores)
            Me.ConfigurarPagina(arrerrores)
            Me.AutoajustarCeldas(arrerrores)
            Me.AjustarAnchoColumnas(arrerrores, "B", "AZ", 8)
            Me.AjustarAltoFilas(arrerrores, 3, 3, 27.75)
            Me.AjustarTextoenFila(arrerrores, 3, 3)
            Me.EliminarFilas(arrerrores, 1, 2)

            ' Formatear los totales, pintar los totales.
            For i = 1 To FilaHasta
                strTexto = LeerCelda(arrerrores, i, i, 1, 1)
                If InStr(1, strTexto, "Total") = 1 Then
                    Me.SeleccionarRango(arrerrores, i, i, 1, cantColumnas - 3)
                    Me.SetearFuente("Arial", 7, True, False)
                    FormatearCeldaConLinea(arrerrores)
                    Me.PintarCelda(arrerrores, 15) '***15 Color Gris claro
                ElseIf InStr(1, strTexto, "SUBTOTAL") = 1 Then
                    Me.SeleccionarRango(arrerrores, i, i, 1, cantColumnas - 3)
                    Me.SetearFuente("Arial", 7, True, False)
                    FormatearCeldaConLinea(arrerrores)
                    Me.PintarCelda(arrerrores, 34) '***15 Color Celeste
                End If

            Next
            Me.AutoajustarCeldas(arrerrores)

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try

    End Sub
    Public Function TomarValorCelda(ByRef arrErrores() As String, ByVal row As Integer, ByVal col As Integer) As Double
        Try
            TomarValorCelda = Me._ExcelWorkSheet.Range(Me._ExcelWorkSheet.Cells(row, col), Me._ExcelWorkSheet.Cells(row, col)).Value
        Catch ex As Exception
            agregar_error(arrErrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Function
    Public Sub ArmarListadeValores(ByVal arrerrores() As String, ByVal arrListaValores() As String, ByVal indicelista As Integer)
        Dim i As Integer
        Try
            For i = 1 To arrListaValores.Length
                Me._ExcelWorkSheet.Range("IV" & i).Select()
                Me._ExcelApplication.ActiveCell.FormulaR1C1 = arrListaValores(i - 1)
            Next
            Me._ExcelApplication.ActiveSheet.ListObjects.Add(Excel.XlListObjectSourceType.xlSrcRange, Me._ExcelWorkSheet.Range("$IV$" & 1 & ":$IV$" & arrListaValores.Length), , Excel.XlYesNoGuess.xlNo).Name = "Lista" & arrListaValores.Length

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try

    End Sub
    Public Sub InsertarListadeValoresEnRango(ByVal filaDesde As Integer, ByVal filahasta As Integer, ByVal columnadesde As Integer, ByVal columnahasta As Integer, ByVal CantidadListaValores As Integer)

        Me._ExcelWorkSheet.Range(Me._ExcelWorkSheet.Cells(filaDesde, columnadesde), Me._ExcelWorkSheet.Cells(filahasta, columnahasta)).Select()
        With Me._ExcelApplication.Selection.Validation
            .Delete()
            .Add(Type:=Excel.XlDVType.xlValidateList, AlertStyle:=Excel.XlDVAlertStyle.xlValidAlertStop, Operator:= _
            Excel.XlFormatConditionOperator.xlBetween, Formula1:="=$IV$2:$IV$" & CantidadListaValores + 1)
            .IgnoreBlank = True
            .InCellDropdown = True
            .InputTitle = ""
            .ErrorTitle = ""
            .InputMessage = ""
            .ErrorMessage = ""
            .ShowInput = True
            .ShowError = True
        End With
    End Sub
    Public Sub AjustarCeldas(ByVal arrerrores() As String, ByVal FilaDesde As Integer, ByVal ColumnaDesde As Integer, ByVal FilaHasta As Integer, ByVal ColumnaHasta As Integer)
        Try
            'Me._ExcelWorkSheet.Range(Me._ExcelWorkSheet.Cells(FilaDesde, ColumnaDesde), Me._ExcelWorkSheet.Cells(FilaHasta, ColumnaHasta)).Merge()
            Me.SeleccionarRango(arrerrores, FilaDesde, FilaHasta, ColumnaDesde, ColumnaHasta)
            With Me._ExcelApplication.Selection
                .HorizontalAlignment = Excel.Constants.xlGeneral
                .VerticalAlignment = Excel.Constants.xlBottom
                .WrapText = True
                .Orientation = 0
                .AddIndent = False
                .IndentLevel = 0
                .ShrinkToFit = False
                .ReadingOrder = Excel.Constants.xlContext
                .MergeCells = False
            End With

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try

    End Sub

    Public Sub CentrarTexto(ByVal arrerrores() As String, ByVal FilaDesde As Integer, ByVal ColumnaDesde As Integer, ByVal FilaHasta As Integer, ByVal ColumnaHasta As Integer)
        Try
            Me.SeleccionarRango(arrerrores, FilaDesde, FilaHasta, ColumnaDesde, ColumnaHasta)
            With Me._ExcelApplication.Selection
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.Constants.xlBottom
                .WrapText = False
                .Orientation = 0
                .AddIndent = False
                .IndentLevel = 0
                .ShrinkToFit = False
                .ReadingOrder = Excel.Constants.xlContext
                .MergeCells = False
            End With

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try

    End Sub
    'Public Overloads Sub AplicarFormatoCondicional(ByVal arrerrores() As String, ByVal FilaDesde As Integer, ByVal FilaHasta As Integer, _
    '                                     ByVal ColumnaDesde As Integer, ByVal ColumnaHasta As Integer, _
    '                                     ByVal valorComparar As String, ByVal Negrita As Boolean, ByVal Italica As Boolean, _
    '                                     ByVal Subrayado As Boolean, ByVal Color As ColoresFuente)
    '    Try

    '        Me.SeleccionarRango(arrerrores, FilaDesde, FilaHasta, ColumnaDesde, ColumnaHasta)

    '        Me._ExcelApplication.Selection.FormatConditions.Delete()

    '        Me._ExcelApplication.Selection.FormatConditions.Add(Type:=Excel.XlFormatConditionType.xlExpression, Formula1:="=VALOR(A9)=" & valorComparar)

    '        With Me._ExcelApplication.Selection.FormatConditions(1).Font

    '            .Bold = Negrita
    '            .Italic = Italica
    '            If Subrayado Then
    '                .Underline = Excel.XlUnderlineStyle.xlUnderlineStyleSingle
    '            End If
    '            .ColorIndex = Color

    '        End With

    '    Catch ex As Exception
    '        agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
    '        Throw ex
    '    End Try
    'End Sub
    Public Sub AplicarFormatoCondicional(ByVal arrerrores() As String, ByVal FilaDesdeValor As Integer, ByVal FilaHastaValor As Integer, _
                                         ByVal ColumnaDesdeValor As Integer, ByVal ColumnaHastaValor As Integer, ByVal FilaDesdeFormato As Integer, _
                                         ByVal FilaHastaFormato As Integer, ByVal FilaHastaCopiaFormato As Integer, ByVal ColumnaDesdeFormato As Integer, ByVal ColumnaHAstaFormato As Integer, ByVal Negrita As Boolean, ByVal Italica As Boolean, _
                                         ByVal Subrayado As Boolean, ByVal Color As ColoresFuente, ByVal ColorFondo As ColoresFondo)
        Try

            Dim valor As String
            Dim celda As Object

            valor = Me.LeerCelda(arrerrores, FilaDesdeValor, FilaHastaValor, ColumnaDesdeValor, ColumnaHastaValor)

            celda = Me._ExcelWorkSheet.Range(Me._ExcelWorkSheet.Cells(FilaDesdeValor, ColumnaDesdeValor), Me._ExcelWorkSheet.Cells(FilaHastaValor, ColumnaHastaValor)).Address(False, False)
            Me.SeleccionarRango(arrerrores, FilaDesdeFormato, FilaHastaFormato, ColumnaDesdeFormato, ColumnaHAstaFormato)

            Me._ExcelApplication.Selection.FormatConditions.Delete()

            Me._ExcelApplication.Selection.FormatConditions.Add _
            (Type:=Excel.XlFormatConditionType.xlExpression, Formula1:= _
             "=VALOR(" & celda & ")=" & valor)

            With Me._ExcelApplication.Selection.FormatConditions(1).Font

                .Bold = Negrita
                .Italic = Italica
                If Subrayado Then
                    .Underline = Excel.XlUnderlineStyle.xlUnderlineStyleSingle
                End If
                .ColorIndex = Color

            End With
            With Me._ExcelApplication.Selection.FormatConditions(1).Interior

                .ColorIndex = ColorFondo

                .Pattern = Excel.Constants.xlSolid

            End With
            Me._ExcelApplication.Selection.Copy()
            Me.SeleccionarRango(arrerrores, FilaDesdeFormato, FilaHastaCopiaFormato, ColumnaDesdeFormato, ColumnaHAstaFormato)
            Me._ExcelApplication.Selection.PasteSpecial(Paste:=Excel.XlPasteType.xlPasteFormats, Operation:=Excel.Constants.xlNone, _
                SkipBlanks:=False, Transpose:=False)
            Me._ExcelApplication.CutCopyMode = False

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Sub NombreColumna(ByVal arrerrores() As String, ByVal filaDesde As Integer, _
    ByVal FilaHasta As Integer, ByVal ColumnaDesde As Integer, _
    ByVal columnaHasta As Integer, ByRef NombreColumnaDesde As String, ByRef NombreColumnaHasta As String)
        Dim NombreCol As String

        Me.SeleccionarRango(arrerrores, filaDesde, FilaHasta, ColumnaDesde, columnaHasta)
        NombreCol = Me._ExcelApplication.Selection.Address
        NombreColumnaDesde = Mid(NombreCol, InStr(NombreCol, "$") + 1, InStr(2, NombreCol, "$") - 2)
        NombreColumnaHasta = Mid(NombreCol, InStr(2, NombreCol, ":") + 2, InStr(2, NombreCol, "$") - 2)
    End Sub
    Public Sub CambiarNombreHoja(ByVal arrerrores() As String, ByVal NombreActual As String, ByVal NombreNuevo As String)
        Try
            Me._ExcelApplication.Sheets(NombreActual).Select()
            Me._ExcelApplication.Sheets(NombreActual).Name = NombreNuevo

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub

    Public Function ExisteHoja(ByVal arrerrores() As String, ByVal NombreHoja As String) As Boolean
        Try
            Dim i As Integer
            ExisteHoja = False
            For i = 1 To Me._ExcelApplication.Sheets.Count
                If Me._ExcelApplication.Sheets(i).Name = NombreHoja Then
                    ExisteHoja = True
                    Exit Function
                End If
            Next
        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Function

    Public Sub OrdenarValores(ByVal arrerrores() As String, ByVal NombreHoja As String, ByVal FilaDesdeOrden As Integer, _
    ByVal FilaHastaOrden As Integer, ByVal ColumnaDesdeOrden As Integer, ByVal ColumnaHastaOrden As Integer)
        Try

            Me.SeleccionarRango(arrerrores, FilaDesdeOrden, FilaHastaOrden, ColumnaDesdeOrden, ColumnaHastaOrden)

            Me._ExcelApplication.Selection.Sort(Key1:=Me._ExcelApplication.Selection, Order1:=Excel.XlSortOrder.xlAscending, Header:=Excel.XlYesNoGuess.xlGuess, _
        OrderCustom:=1, MatchCase:=False, Orientation:=Excel.Constants.xlTopToBottom, _
        DataOption1:=Excel.XlSortDataOption.xlSortNormal)

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub

    Public Sub OcultarColumna(ByVal arrerrores() As String, ByVal columnaDesde As String, ByVal columnaHasta As String)
        Try
            Me._ExcelApplication.Columns(columnaDesde & ":" & columnaHasta).Select()
            Me._ExcelApplication.Selection.EntireColumn.Hidden = True

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub

    Public Sub QuitarFormatoNumeros(ByVal arrerrores() As String)
        Try

            Me._ExcelApplication.Selection.NumberFormat = "General"

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try
    End Sub
    Public Sub CalculosAutomaticos(ByVal arrerrores() As String, ByVal valor As Boolean, ByVal manual As Boolean)

        Try
            If manual = True Then
                Me._ExcelApplication.Calculation = Excel.XlCalculation.xlCalculationManual
            Else
                Me._ExcelApplication.Calculation = Excel.XlCalculation.xlCalculationAutomatic
            End If
            Me._ExcelWorkBook.PrecisionAsDisplayed = valor

        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
        End Try

    End Sub
    '''<summary>
    ''' Aplica el formato indicado a la seleccion. Permite ingresar cualquier valor
    ''' siempre que sea vlida con los formatos de excel.
    ''' "@" = Texto
    ''' "General" = General
    ''' "0.00" = Numrico 2 decimales
    ''' </summary>
    ''' <param name="arrerrores"></param>
    ''' <param name="strTpoFormato"></param>
    ''' <remarks></remarks>

    Public Sub EstablecerFormato(ByVal arrerrores() As String, ByVal strTpoFormato As String)
        Try
            Me._ExcelApplication.Selection.NumberFormat = strTpoFormato
        Catch ex As Exception
            agregar_error(arrerrores, ex.StackTrace & " - Error:" & ex.Message)
            Throw ex
        End Try

    End Sub
End Class
