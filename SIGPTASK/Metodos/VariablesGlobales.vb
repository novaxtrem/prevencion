
Imports System.Data.Odbc
'/////ya se que esto no se debe hacer jaja perdon, al refactorizar corregimos, saludos
Module VariablesGlobales

    Public conn As OdbcConnection
    '////
    Public Const stringfechaFormatoSalidaInformix As String = "MM/dd/yyyy"
    '////
    Public cedulaUsuarioConectado As String = ""
    Public tipoUsuario As String = ""
    Public matricula As String = ""
    '////
    Public totalEmpleadosSucursal As Integer = 0
    Public IsFormBeingDragged As Boolean
    '////
    Public MouseDownX As Integer
    Public MouseDownY As Integer
    Public idiomaSeleccionado As String = "ESP"
    '////
    Public ID_Riesgo As String = ""
    Public NOMBRE_Riesgo As String = ""
    Public RUTA_icono As String = ""
    Public esImagen As Boolean = False

    '////
    'MAXIMO CAMPOS PARA TODA LA APLICACION
    Public Const varCaracteresMaximoRUT As Integer = 12
    Public Const varCaracteresMaximoNombreEmppresa As Integer = 80
    Public Const varCaracteresMaximoSucursalNombre As Integer = 80
    Public Const varCaracteresMaximoTelefono As Integer = 9
    Public Const varCaracteresMaximoEmpleadosSucursal As Integer = 10
    Public Const varCaracteresMaximoTextBoxBuscarEmpresa As Integer = 80
    Public Const varCaracteresMaximoSucursalDireccion As Integer = 80



End Module
