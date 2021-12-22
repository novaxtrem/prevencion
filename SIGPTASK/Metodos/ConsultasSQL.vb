Imports System.Data.Odbc

Module ConsultasSQL

    '////////////CONEXION BASE
    Function ConectoBase(ByVal conn As OdbcConnection, ByVal usuario As String, ByVal contrasena As String)
        Dim connetionString As String
        connetionString = "Dsn=task;Database=task;uid=" & usuario & ";pwd=" & contrasena
        conn = New OdbcConnection(connetionString)
        Try
            conn.Open()
        Catch ex As Exception
            ' MsgBox(ex.ToString)
        End Try
        Return conn
    End Function
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '                                                          _____ ______ _      ______ _____ _______ 
    '                                                         / ____|  ____| |    |  ____/ ____|__   __|
    '                                                        | (___ | |__  | |    | |__ | |       | |   
    '                                                         \___ \|  __| | |    |  __|| |       | |   
    '                                                         ____) | |____| |____| |___| |____   | |   
    '                                                        |_____/|______|______|______\_____|  |_|   
    '                                                        
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////// SELECT *CEDULA - *TIPO - *MATRICULA - *PREVENCIONISTAS - *PREGUNTAS - *ACCIONES - *OBJETOS (CON FILTRO SIN FILTRO) - RIESGOS - | *SUCURSALES  *(FILTRO ACTIVAS) - *(FILTRO ACTIVAS Y RUT) - *TODAS (ACTIVAS E INACTIVAS) |
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//// SELECT CEDULA
    Function consultoCedulaEmpleado(ByVal nombreUsuario As String, ByVal conn As OdbcConnection, ByVal cedula As String)
        Try
            Dim sqlquery As String = "SELECT empleado_cedula from empleado where empleado_username=?"
            Dim command As OdbcCommand = New OdbcCommand(sqlquery, conn) With {
              .CommandText = sqlquery,
              .Connection = conn
          }
            command.Parameters.AddWithValue("@?", nombreUsuario)
            cedula = command.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return cedula
    End Function

    'CONSULTO EXITENCIA DEL EMPLEADO
    Function consultoExistenciaEmpleado(ByVal empleadoUsername As String, ByVal empleadoCedula As Integer, ByVal conn As OdbcConnection, ByVal filasDevueltas As Integer)
        Try
            Dim sqlquery As String = "SELECT COUNT(*) from empleado where empleado_username=? or empleado_cedula=?"
            Dim command As OdbcCommand = New OdbcCommand(sqlquery, conn) With {
              .CommandText = sqlquery,
              .Connection = conn
          }
            command.Parameters.AddWithValue("@?", empleadoUsername)
            command.Parameters.AddWithValue("@?", empleadoCedula)
            filasDevueltas = command.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return filasDevueltas
    End Function

    'CONSULTO POR USERNAME
    Function consultoPorUSERNAME(ByVal empleado As Empleado, ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "select * from empleado where empleado.empleado_username=?"
            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            command.Parameters.AddWithValue("@?", empleado.empleadoUsername)
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                empleado.empleadoID = reader.GetValue(0)
                empleado.empleadoCedula = reader.GetValue(1)
                empleado.empleadoNombre = reader.GetValue(2)
                empleado.empleadoUsername = reader.GetValue(3)
                empleado.empleadoTipo = reader.GetValue(4)
                empleado.matricula = reader.GetValue(5)
                empleado.empleadoDireccion = reader.GetValue(6)
                empleado.empleadoTelefono = reader.GetValue(7)
                empleado.empleadoCelular = reader.GetValue(8)
                empleado.empleadoEmail = reader.GetValue(9)
            End While
        Catch ex As Exception
        End Try
        Return empleado
    End Function

    'CONSULTO EMPLEADOS
    Function consultoTodosEmpleados(ByVal listaEmpleadosSistema As List(Of Empleado), ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "select * from empleado"
            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                Dim empleado As New Empleado
                empleado.empleadoID = reader.GetValue(0)
                empleado.empleadoCedula = reader.GetValue(1)
                empleado.empleadoNombre = reader.GetValue(2)
                empleado.empleadoUsername = reader.GetValue(3)
                empleado.empleadoTipo = reader.GetValue(4)
                '///
                If reader.GetValue(5).Equals(Nothing) Then
                    empleado.matricula = ""
                Else
                    empleado.matricula = reader.GetValue(5)
                End If
                '///
                empleado.empleadoDireccion = reader.GetValue(6)
                '///
                If reader.GetValue(7).Equals(Nothing) Then
                    empleado.empleadoTelefono = ""
                Else
                    empleado.empleadoTelefono = reader.GetValue(7)
                End If
                '///
                If reader.GetValue(8).Equals(Nothing) Then
                    empleado.empleadoCelular = ""
                Else
                    empleado.empleadoCelular = reader.GetValue(8)
                End If
                '///
                If reader.GetValue(9).Equals(Nothing) Then
                    empleado.empleadoEmail = ""
                Else
                    empleado.empleadoEmail = reader.GetValue(9)
                End If
                '///
                listaEmpleadosSistema.Add(empleado)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return listaEmpleadosSistema
    End Function

    'CONSULTO EMPRESA POR NOMBRE
    Function consultoEmpresaPorNombre(ByVal listaSucursales As List(Of Sucursal), ByVal textoEnviado As String, ByVal conn As OdbcConnection)
        MessageBox.Show(textoEnviado)
        '/NO PUDE PARAMETRIZAR ESTA QUERY ...ALGO DEL LIKE, ME DETECATA EL "?" COMO CARACTER DE BUSQUEDA...BUE...TA
        Try
            Dim qUno As String = "select * from sucursal where sucursal.empresa_nombre LIKE '%" & textoEnviado & "%' ESCAPE '\' "
            Dim qDos As String = "or sucursal.sucursal_nombre LIKE '%" & textoEnviado & "%' ESCAPE '\' and sucursal.estado='A'"
            Dim sqlquery As String = qUno + qDos

            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            Console.WriteLine(sqlquery)
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                Dim nueva As New Sucursal
                nueva.sucursalID = reader.GetValue(0)
                nueva.empresaRUT = reader.GetValue(1)
                nueva.empresaNombre = reader.GetValue(2)
                nueva.sucursalNombre = reader.GetValue(3)
                nueva.sucursalDireccion = reader.GetValue(4)
                nueva.telefono = reader.GetValue(5)
                nueva.estado = reader.GetValue(6)
                nueva.totalEmpleadosSucursal = reader.GetValue(7)
                listaSucursales.Add(nueva)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return listaSucursales
    End Function


    'CONSULTO PREGUNTA POR NOMBRE
    Function consultoPreguntasPorTexto(ByVal listaPreguntas As List(Of Pregunta), ByVal textoEnviado As String, ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "select * from preguntas where preguntas.pregunta LIKE '%" & textoEnviado & "%' ESCAPE '\' "
            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                Dim nueva As New Pregunta
                nueva.preguntaID = reader.GetValue(0)
                nueva.pregunta = reader.GetValue(1)
                nueva.riesgoMuerte = reader.GetValue(2)
                listaPreguntas.Add(nueva)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return listaPreguntas
    End Function

    'CONSULTO ACCIONES POR NOMBRE
    Function consultoAccionesPorTexto(ByVal listaAcciones As List(Of Accion), ByVal textoEnviado As String, ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "select * from acciones where acciones.accion LIKE '%" & textoEnviado & "%' ESCAPE '\' "
            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                Dim nueva As New Accion
                nueva.AccionID = reader.GetValue(0)
                nueva.Accion = reader.GetValue(1)
                listaAcciones.Add(nueva)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return listaAcciones
    End Function





    '//// SELECT TIPO 
    Function consultoTipo(ByVal cedulaEmpleado As String, ByVal conn As OdbcConnection, ByVal tipoUsuario As String)
        Try
            Dim sqlquery As String = "SELECT empleado_tipo from empleado where empleado_cedula=?"
            Dim command As New OdbcCommand(sqlquery, conn)
            command.Parameters.AddWithValue("@?", cedulaEmpleado)
            tipoUsuario = command.ExecuteScalar()
        Catch ex As Exception
        End Try
        Return tipoUsuario
    End Function
    '// SELECT MATRICULA
    Function consultoMatricula(ByVal cedulaEmpleado As String, ByVal conn As OdbcConnection, ByVal matricula As String)
        Try
            Dim sqlquery As String = "SELECT matricula from empleado where empleado_cedula=?"
            Dim command As OdbcCommand = New OdbcCommand(sqlquery, conn) With {
             .CommandText = sqlquery,
             .Connection = conn
         }
            command.Parameters.AddWithValue("@?", cedulaEmpleado)
            matricula = command.ExecuteScalar()
        Catch ex As Exception
        End Try
        Return matricula
    End Function
    '/// SELECT PREVENCIONISTAS
    Function CargoTecnicosPrevencionistas(ByVal listaEmpleados As List(Of Empleado), ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "select * from empleado where empleado.empleado_tipo=?"
            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            command.Parameters.AddWithValue("@?", "PREVENCIONISTA")
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                Dim nueva As New Empleado
                nueva.empleadoCedula = reader.GetValue(0)
                nueva.empleadoNombre = reader.GetValue(1)
                nueva.matricula = reader.GetValue(3)
                listaEmpleados.Add(nueva)
            End While
        Catch ex As Exception
        End Try
        Return listaEmpleados
    End Function
    '//// SELECT PREGUNTAS
    Function ConsultoTodasLasPreguntas(ByVal listaPreguntas As List(Of Pregunta), ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "select * from preguntas"
            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                Dim nueva As New Pregunta
                nueva.preguntaID = reader.GetValue(0)
                nueva.pregunta = reader.GetValue(1)
                nueva.riesgoMuerte = reader.GetValue(2)
                listaPreguntas.Add(nueva)
            End While
        Catch ex As Exception
        End Try
        Return listaPreguntas
    End Function
    '/// SELECT ACCIONES
    Function ConsultoTodasLasAcciones(ByVal listaAcciones As List(Of Accion), ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "select * from acciones"
            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                Dim nueva As New Accion
                nueva.AccionID = reader.GetValue(0)
                nueva.Accion = reader.GetValue(1)
                listaAcciones.Add(nueva)
            End While
        Catch ex As Exception
        End Try
        Return listaAcciones
    End Function
    '/// SELECT OBJETOS SIN FILTRO
    Function ConsultoTodosLosObjetos(ByVal listaObjetos As List(Of objeto), ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "select * from objetos"
            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                Dim nueva As New objeto
                nueva.objetoID = reader.GetValue(0)
                nueva.objeto = reader.GetValue(1)
                listaObjetos.Add(nueva)
            End While
        Catch ex As Exception
        End Try
        Return listaObjetos
    End Function
    '/// RIESGOS
    Function ConsultoTodosLosRiesgos(ByVal listaRiesgos As List(Of Riesgo), ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "select * from riesgos"
            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                Dim nueva As New Riesgo
                nueva.riesgoID = reader.GetValue(0)
                nueva.nombreRiesgo = reader.GetValue(1)
                nueva.iconoRiesgo = reader.GetValue(2)
                listaRiesgos.Add(nueva)
            End While
        Catch ex As Exception
        End Try
        Return listaRiesgos
    End Function

    '/// SELECT SUCURSALES TODAS ACTIVAS
    Function ConsultoTodasLasSucursales(ByVal listaSucursales As List(Of Sucursal), ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "SELECT * from sucursal where estado=?"
            Dim command As OdbcCommand = New OdbcCommand(sqlquery, conn) With {
             .CommandText = sqlquery,
             .Connection = conn
         }
            command.Parameters.AddWithValue("@?", "A")
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                Dim nueva As New Sucursal
                nueva.sucursalID = reader.GetValue(0)
                nueva.empresaRUT = reader.GetValue(1)
                nueva.empresaNombre = reader.GetValue(2)
                nueva.sucursalNombre = reader.GetValue(3)
                nueva.sucursalDireccion = reader.GetValue(4)
                nueva.telefono = reader.GetValue(5)
                nueva.estado = reader.GetValue(6)
                nueva.totalEmpleadosSucursal = reader.GetValue(7)
                listaSucursales.Add(nueva)
            End While
        Catch ex As Exception
        End Try
        Return listaSucursales
    End Function
    '//// SELECT SUCURSALES POR RUT ACTIVAS
    Function consultoSucursalesPorRUT(ByVal listaSucursales As List(Of Sucursal), ByVal conn As OdbcConnection, ByVal rut As String)
        Try
            Dim sqlquery As String = "SELECT * from sucursal where empresa_rut=? and estado=?"
            Dim command As OdbcCommand = New OdbcCommand(sqlquery, conn) With {
             .CommandText = sqlquery,
             .Connection = conn
         }
            command.Parameters.AddWithValue("@?", rut)
            command.Parameters.AddWithValue("@?", "A")
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                Dim nueva As New Sucursal
                nueva.sucursalID = reader.GetValue(0)
                nueva.empresaRUT = reader.GetValue(1)
                nueva.empresaNombre = reader.GetValue(2)
                nueva.sucursalNombre = reader.GetValue(3)
                nueva.sucursalDireccion = reader.GetValue(4)
                nueva.telefono = reader.GetValue(5)
                nueva.estado = reader.GetValue(6)
                nueva.totalEmpleadosSucursal = reader.GetValue(7)
                listaSucursales.Add(nueva)
            End While
        Catch ex As Exception
        End Try
        Return listaSucursales
    End Function
    '///// SELECT SUCURSALES ACTIVAS E INACTIVAS
    Function CargoEmpresas(ByVal listaEmpresas As List(Of Sucursal), ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "select * from sucursal"
            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                Dim nueva As New Sucursal
                nueva.sucursalID = reader.GetValue(0)
                nueva.empresaRUT = reader.GetValue(1)
                nueva.empresaNombre = reader.GetValue(2)
                nueva.sucursalNombre = reader.GetValue(3)
                listaEmpresas.Add(nueva)
            End While
        Catch ex As Exception
        End Try
        Return listaEmpresas
    End Function

    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '                                                         _____ _   _  _____ ______ _____ _______   
    '                                                        |_   _| \ | |/ ____|  ____|  __ \__   __|  
    '                                                          | | |  \| | (___ | |__  | |__) | | |     
    '                                                          | | | . ` |\___ \|  __| |  _  /  | |     
    '                                                         _| |_| |\  |____) | |____| | \ \  | |     
    '                                                        |_____|_| \_|_____/|______|_|  \_\ |_|     
    '                                                                                                   
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//INSERT: EMPRESA - EMPLEADO - PREGUNTA - ACCION - OBJETO - RIESGO - MAPA RIESGO - INVENTARIO - CUESTIONARIO
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///// INSERT EMPRESA/SUCURSAL
    Function AgregoEmpresaNueva(ByVal empresaNueva As Sucursal, ByVal conn As OdbcConnection, ByVal estado As Boolean)
        Try
            Dim sqlquery As String = "INSERT into sucursal (sucursal_id, empresa_rut, empresa_nombre, sucursal_nombre, sucursal_direccion, telefono, estado, total_trabajadores) values(?, ?, ?, ?, ?, ?, ?, ?)"
            Dim command As OdbcCommand = New OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            command.Parameters.AddWithValue("@?", 0)
            command.Parameters.AddWithValue("@?", empresaNueva.empresaRUT)
            command.Parameters.AddWithValue("@?", empresaNueva.empresaNombre)
            command.Parameters.AddWithValue("@?", empresaNueva.sucursalNombre)
            command.Parameters.AddWithValue("@?", empresaNueva.sucursalDireccion)
            command.Parameters.AddWithValue("@?", empresaNueva.telefono)
            command.Parameters.AddWithValue("@?", empresaNueva.estado)
            command.Parameters.AddWithValue("@?", empresaNueva.totalEmpleadosSucursal)
            command.ExecuteNonQuery()
            estado = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            estado = False
        End Try
        Return estado
    End Function
    '///// INSERT EMPLEADO
    Function insertoEmpleado(ByVal empleado As Empleado, ByVal conn As OdbcConnection, ByVal estado As Boolean) As Boolean
        Try
            Dim sqlquery As String = "INSERT INTO empleado (empleado_id, empleado_cedula, empleado_nombre, empleado_username, empleado_tipo, matricula, " &
                "empleado_direccion, empleado_telefono, empleado_celular, empleado_email) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
            Dim command As OdbcCommand = New OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            command.Parameters.AddWithValue("@?", 0)
            command.Parameters.AddWithValue("@?", empleado.empleadoCedula)
            command.Parameters.AddWithValue("@?", empleado.empleadoNombre)
            command.Parameters.AddWithValue("@?", empleado.empleadoUsername)
            command.Parameters.AddWithValue("@?", empleado.empleadoTipo)
            command.Parameters.AddWithValue("@?", empleado.matricula)
            command.Parameters.AddWithValue("@?", empleado.empleadoDireccion)
            command.Parameters.AddWithValue("@?", empleado.empleadoTelefono)
            command.Parameters.AddWithValue("@?", empleado.empleadoCelular)
            command.Parameters.AddWithValue("@?", empleado.empleadoEmail)
            command.ExecuteNonQuery()
            estado = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            estado = False
        End Try
        Return estado
    End Function
    '/// INSERT PREGUNTA
    Function AgregoPreguntaNueva(ByVal pregunta As Pregunta, ByVal conn As OdbcConnection, ByVal estado As Boolean)
        Try
            Dim sqlquery As String = "INSERT INTO preguntas (pregunta_id, pregunta, riesgo_muerte) values (?, ?, ?)"
            Dim command As OdbcCommand = New OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            command.Parameters.AddWithValue("@?", 0)
            command.Parameters.AddWithValue("@?", pregunta.pregunta)
            command.Parameters.AddWithValue("@?", pregunta.riesgoMuerte)
            command.ExecuteNonQuery()
            estado = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            estado = False
        End Try
        Return estado
    End Function
    '//// INSERT ACCION
    Function AgregoAccionNueva(ByVal accion As Accion, ByVal conn As OdbcConnection, ByVal estado As Boolean)
        Try
            Dim sqlquery As String = "INSERT into acciones (accion_id, accion) values(?, ?)"
            Dim command As OdbcCommand = New OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            command.Parameters.AddWithValue("@?", 0)
            command.Parameters.AddWithValue("@?", accion.Accion)
            command.ExecuteNonQuery()
            estado = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            estado = False
        End Try
        Return estado
    End Function
    '//////INSERT OBJETOS
    Function AgregoObjetoNuevo(ByVal objeto As objeto, ByVal conn As OdbcConnection, ByVal estado As Boolean)
        Try
            Dim sqlquery As String = "INSERT into objetos (objeto_id, objeto_nombre) values(?, ?)"
            Dim command As OdbcCommand = New OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            command.Parameters.AddWithValue("@?", 0)
            command.Parameters.AddWithValue("@?", objeto.objeto)
            command.ExecuteNonQuery()
            estado = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            estado = False
        End Try
        Return estado
    End Function
    '////INSERT RIESGO
    Function InsertoRiesgo(ByVal riesgo As Riesgo, ByVal conn As OdbcConnection, ByVal estado As Boolean) As Boolean
        Try
            Dim sqlquery As String = "INSERT into riesgos (riesgo_id, nombre_riesgo, icono) values (?, ?, ?)"
            Dim command As OdbcCommand = New OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            command.Parameters.AddWithValue("@?", 0)
            command.Parameters.AddWithValue("@?", riesgo.nombreRiesgo)
            command.Parameters.AddWithValue("@?", riesgo.iconoRiesgo)
            command.ExecuteNonQuery()
            estado = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            estado = False
        End Try
        Return estado
    End Function
    '///////////// INSERT MAPA RIESGO (SE EJECUTAN ENCADENADAS)
    Function AgregoMapaRiesgo(ByVal mapa As Mapa, ByVal id_plano_ingresado As Integer, ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "INSERT into mapa_riesgo (mapa_id, sucursal_id, mapa_riesgo_nombre, empleado_cedula, controlado_por_matricula , fecha, plano_ruta_archivo, estado) values (?, ?, ?, ?, ?, ?, ?, ?)"
            Dim command As OdbcCommand = New OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            command.Parameters.AddWithValue("@?", 0)
            command.Parameters.AddWithValue("@?", mapa.sucursalID)
            command.Parameters.AddWithValue("@?", mapa.mapaRiesgoNombre)
            command.Parameters.AddWithValue("@?", mapa.empleadoCedula)
            command.Parameters.AddWithValue("@?", mapa.controladoPor)
            command.Parameters.AddWithValue("@?", mapa.fecha)
            command.Parameters.AddWithValue("@?", mapa.planoRutaArchivo)
            command.Parameters.AddWithValue("@?", mapa.estado)
            command.ExecuteNonQuery()
            '////////////
            Dim idSerialSQL As String = "SELECT DBINFO( 'sqlca.sqlerrd1' ) FROM systables WHERE tabid = 1;"
            Dim queryInformixCmd = New OdbcCommand(idSerialSQL, conn)
            Dim idSerial As Integer
            idSerial = queryInformixCmd.ExecuteScalar()
            id_plano_ingresado = idSerial
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return id_plano_ingresado
    End Function

    Function AgregoRiesgosMapa(ByVal riesgoUbicacion As RiesgoUbicacion, ByVal conn As OdbcConnection, ByVal estado As Boolean) As Boolean
        Try
            Dim sqlquery As String = "INSERT into ubicacion_riesgo (ubicacion_id, mapa_id, ubicacion_nombre, critico, riesgo_id, descripcion, solucion, plazo, cumplido_en_fecha, coordenada_x, coordenada_y) values(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
            Dim command As OdbcCommand = New OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
            .Connection = conn
            }
            command.Parameters.AddWithValue("@?", 0)
            command.Parameters.AddWithValue("@?", riesgoUbicacion.mapaID)
            command.Parameters.AddWithValue("@?", riesgoUbicacion.ubicacionNombre)
            command.Parameters.AddWithValue("@?", riesgoUbicacion.critico)
            command.Parameters.AddWithValue("@?", riesgoUbicacion.riesgoID)
            command.Parameters.AddWithValue("@?", riesgoUbicacion.descripcion)
            command.Parameters.AddWithValue("@?", riesgoUbicacion.solucion)
            command.Parameters.AddWithValue("@?", riesgoUbicacion.plazo)
            command.Parameters.AddWithValue("@?", riesgoUbicacion.cumplidoEnfecha)
            command.Parameters.AddWithValue("@?", riesgoUbicacion.coordendaX)
            command.Parameters.AddWithValue("@?", riesgoUbicacion.coordenadaY)
            command.ExecuteNonQuery()
            estado = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            estado = False
        End Try
        Return estado
    End Function
    '/////////////INSERT  INVENTARIO (SE EJECUTAN ENCADENADAS)
    Function AgregoInventario(ByVal inventario As Inventario, ByVal id_inventario_ingresado As String, ByVal conn As OdbcConnection) As String
        Try
            Dim sqlquery As String = "INSERT INTO inventario (inventario_id, sucursal_id, nombre_inventario, fecha, empleado_cedula, estado, nota) VALUES (?, ?, ?, ?, ?, ?, ?);"
            Dim command As OdbcCommand = New OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            command.Parameters.AddWithValue("@?", 0)
            command.Parameters.AddWithValue("@?", inventario.sucursal_id)
            command.Parameters.AddWithValue("@?", inventario.nombreInvetario)
            command.Parameters.AddWithValue("@?", inventario.fecha)
            command.Parameters.AddWithValue("@?", inventario.empleadoCedula)
            command.Parameters.AddWithValue("@?", inventario.estado)
            command.Parameters.AddWithValue("@?", inventario.nota)
            command.ExecuteNonQuery()
            '////////////
            Dim idSerialSQL As String = "SELECT DBINFO('sqlca.sqlerrd1') FROM systables WHERE tabid = 1;"
            Dim queryInformixCmd = New OdbcCommand(idSerialSQL, conn)
            Dim idSerial As Integer
            idSerial = queryInformixCmd.ExecuteScalar()
            id_inventario_ingresado = idSerial
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return id_inventario_ingresado
    End Function

    Function AgregoObjetosInventario(ByVal inventario As Inventario, ByVal conn As OdbcConnection, ByVal estado As Boolean) As Boolean
        Try
            Dim sqlquery As String = "INSERT into inventario_fila (fila_id, inventario_id, objeto_id, existencias, cantidad_requerida, estado) values (?, ?, ?, ?, ?, ?)"
            Dim command As OdbcCommand = New OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
            .Connection = conn
            }
            command.Parameters.AddWithValue("@?", 0)
            command.Parameters.AddWithValue("@?", inventario.InventarioID)
            command.Parameters.AddWithValue("@?", inventario.objetoID)
            command.Parameters.AddWithValue("@?", inventario.existencias)
            command.Parameters.AddWithValue("@?", inventario.cantidadRequerida)
            command.Parameters.AddWithValue("@?", inventario.estado)
            command.ExecuteNonQuery()
            estado = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            estado = False
        End Try
        Return estado
    End Function
    '///////////// INSERT CUESTIONARIO (SE EJECUTAN ENCADENADAS)
    Function AgregoCuestionario(ByVal cuestionario As Cuestionario, ByVal id_Cuestionario_ingresado As String, ByVal conn As OdbcConnection) As String
        Try
            Dim sqlquery As String = "INSERT INTO cuestionario (cuestionario_id, sucursal_id, empleado_cedula, nombre_cuestionario, fecha, estado, nota) VALUES (?, ?, ?, ?, ?, ?, ?);"
            Dim command As OdbcCommand = New OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            command.Parameters.AddWithValue("@?", 0)
            command.Parameters.AddWithValue("@?", cuestionario.sucursalID)
            command.Parameters.AddWithValue("@?", cuestionario.empleadoCedula)
            command.Parameters.AddWithValue("@?", cuestionario.cuestionarioNombre)
            command.Parameters.AddWithValue("@?", cuestionario.cuestionarioFecha)
            command.Parameters.AddWithValue("@?", cuestionario.cuestionarioEstado)
            command.Parameters.AddWithValue("@?", cuestionario.cuestionarioNota)
            command.ExecuteNonQuery()
            '////////////
            Dim idSerialSQL As String = "SELECT DBINFO('sqlca.sqlerrd1') FROM systables WHERE tabid = 1;"
            Dim queryInformixCmd = New OdbcCommand(idSerialSQL, conn)
            Dim idSerial As Integer
            idSerial = queryInformixCmd.ExecuteScalar()
            id_Cuestionario_ingresado = idSerial
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return id_Cuestionario_ingresado
    End Function

    Function AgregoIncidenciasCuestionario(ByVal preguntaAccion As PreguntaAccion, ByVal conn As OdbcConnection, ByVal estado As Boolean) As Boolean
        Try
            Dim sqlquery As String = "INSERT into incidencia (incidencia_id, cuestionario_id, pregunta_id, nivel_consecuencia, nivel_exposicion, " &
            "nivel_probabilidad, accion_id, respuesta, expuestos) values (?, ?, ?, ?, ?, ?, ?, ?, ?)"
            Dim command As OdbcCommand = New OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
            .Connection = conn
            }
            command.Parameters.AddWithValue("@?", 0)
            command.Parameters.AddWithValue("@?", preguntaAccion.cuestionario_ID)
            command.Parameters.AddWithValue("@?", preguntaAccion.preguntaID)
            command.Parameters.AddWithValue("@?", preguntaAccion.valorConsecuencia)
            command.Parameters.AddWithValue("@?", preguntaAccion.valorExposicion)
            command.Parameters.AddWithValue("@?", preguntaAccion.valorProvabilidad)
            command.Parameters.AddWithValue("@?", preguntaAccion.AccionID)
            command.Parameters.AddWithValue("@?", preguntaAccion.respuesta)
            command.Parameters.AddWithValue("@?", preguntaAccion.personasExpustas)
            command.ExecuteNonQuery()
            estado = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            estado = False
        End Try
        Return estado
    End Function

    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '                                                        
    '                                          _____ ______ _      ______ _____ _______    _____ _    _  _____ _______ ____  __  __ 
    '                                         / ____|  ____| |    |  ____/ ____|__   __|  / ____| |  | |/ ____|__   __/ __ \|  \/  |
    '                                        | (___ | |__  | |    | |__ | |       | |    | |    | |  | | (___    | | | |  | | \  / |
    '                                         \___ \|  __| | |    |  __|| |       | |    | |    | |  | |\___ \   | | | |  | | |\/| |
    '                                         ____) | |____| |____| |___| |____   | |    | |____| |__| |____) |  | | | |__| | |  | |
    '                                        |_____/|______|______|______\_____|  |_|     \_____|\____/|_____/   |_|  \____/|_|  |_|
    '
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///// CUESTIONARIO (SIN FILTROS)
    Function consultoCuestionariosNoFiltros(ByVal listaCuestionarios As List(Of CueSucEmp), ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "select cuestionario.cuestionario_id, cuestionario.sucursal_id, sucursal.empresa_rut, " &
            "sucursal.sucursal_nombre, cuestionario.empleado_cedula, empleado.empleado_nombre, empleado.matricula, " &
            "cuestionario.nombre_cuestionario, cuestionario.fecha, cuestionario.nota " &
            "from cuestionario INNER JOIN sucursal ON cuestionario.sucursal_id = sucursal.sucursal_id " &
            "INNER JOIN empleado ON cuestionario.empleado_cedula = empleado.empleado_cedula where cuestionario.estado=""T"""

            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                Dim nueva As New CueSucEmp
                nueva.cuestionarioID = reader.GetValue(0)
                nueva.sucursalID = reader.GetValue(1)
                nueva.empresaRUT = reader.GetValue(2)
                nueva.sucursalNombre = reader.GetValue(3)
                nueva.empleadoCedula = reader.GetValue(4)
                nueva.empleadoNombre = reader.GetValue(5)
                nueva.matricula = reader.GetValue(6)
                nueva.cuestionarioNombre = reader.GetValue(7)
                nueva.cuestionarioFecha = reader.GetValue(8)
                listaCuestionarios.Add(nueva)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return listaCuestionarios
    End Function

    '////
    Function consultoInventariosNoFiltros(ByVal listaInventarios As List(Of Inventario), ByVal conn As OdbcConnection)

        Try
            Dim sqlquery As String = "select inventario.inventario_id, inventario.sucursal_id," &
            "sucursal.sucursal_nombre, inventario.empleado_cedula, empleado.empleado_nombre, empleado.matricula, " &
            "inventario.nombre_inventario, inventario.fecha, inventario.nota " &
            "from inventario INNER JOIN sucursal ON inventario.sucursal_id = sucursal.sucursal_id " &
            "INNER JOIN empleado ON inventario.empleado_cedula = empleado.empleado_cedula where inventario.estado=""A"""

            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                Dim nueva As New Inventario
                nueva.InventarioID = reader.GetValue(0)
                nueva.sucursal_id = reader.GetValue(1)
                nueva.nombreInvetario = reader.GetValue(2)
                nueva.fecha = reader.GetValue(3)
                nueva.nota = reader.GetValue(4)
                listaInventarios.Add(nueva)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return listaInventarios
    End Function

    '/////////////////EPIC QUERY PARA GRAFICAR LOS CUESTIONARIOS
    Function consultoPreguntasYHagoGraficas(ByVal id_cuestionarioElejido As Int32, ByVal listaIncidenciasInfoCompleta As List(Of CueSucEmp), ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "select cuestionario.empleado_cedula, empleado_nombre, matricula, cuestionario.fecha, cuestionario.sucursal_id, " &
            "sucursal.sucursal_nombre, total_trabajadores, incidencia.cuestionario_id, incidencia.pregunta_id, pregunta, nivel_consecuencia, nivel_exposicion, " &
            "nivel_probabilidad, riesgo_muerte, respuesta, expuestos, incidencia.accion_id, acciones.accion, cuestionario.nota " &
            "FROM incidencia " &
            "INNER JOIN preguntas ON incidencia.pregunta_id = preguntas.pregunta_id " &
            "INNER JOIN cuestionario ON cuestionario.cuestionario_id = incidencia.cuestionario_id " &
            "INNER JOIN sucursal ON sucursal.sucursal_id = cuestionario.sucursal_id " &
            "INNER JOIN acciones ON incidencia.accion_id = acciones.accion_id " &
            "INNER JOIN empleado ON cuestionario.empleado_cedula = empleado.empleado_cedula " &
            "WHERE incidencia.cuestionario_id=?"
            Dim command As OdbcCommand = New OdbcCommand(sqlquery, conn) With {
             .CommandText = sqlquery,
             .Connection = conn
         }
            command.Parameters.AddWithValue("@?", id_cuestionarioElejido)
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                Dim nueva As New CueSucEmp
                nueva.empleadoNombre = reader.GetValue(1)
                nueva.matricula = reader.GetValue(2)
                nueva.cuestionarioFecha = reader.GetValue(3)
                nueva.sucursalID = reader.GetValue(4)
                nueva.sucursalNombre = reader.GetValue(5)
                nueva.totalEmpleadosSucursal = reader.GetValue(6)
                nueva.cuestionarioID = reader.GetValue(7)
                nueva.pregunta = reader.GetValue(9)
                nueva.nivelConsecuencia = reader.GetValue(10)
                nueva.nivelExposicion = reader.GetValue(11)
                nueva.nivelProbabilidad = reader.GetValue(12)
                nueva.riesgoMuerte = reader.GetValue(13)
                nueva.respuesta = reader.GetValue(14)
                nueva.expuestos = reader.GetValue(15)
                nueva.accion = reader.GetValue(17)
                nueva.cuestionarioNota = reader.GetValue(18)
                listaIncidenciasInfoCompleta.Add(nueva)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return listaIncidenciasInfoCompleta



    End Function

    '//// VENTANA CONTROL QUERY UNO


    Function ConsultoMapasPendientesDeEvaluacion(ByVal listaMapasPendientesEvaluar As List(Of Mapa), ByVal conn As OdbcConnection, ByVal variableDeCambiodeQuery As String)
        Try
            Dim sqlquery As String = "select * from mapa_riesgo where mapa_riesgo.estado=?"
            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            command.Parameters.AddWithValue("@?", variableDeCambiodeQuery)
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                Dim mapas As New Mapa
                mapas.mapaID = reader.GetValue(0)
                mapas.sucursalID = reader.GetValue(1)
                mapas.mapaRiesgoNombre = reader.GetValue(2)
                mapas.empleadoCedula = reader.GetValue(3)
                mapas.controladoPor = reader.GetValue(4)
                mapas.fecha = reader.GetValue(5)
                mapas.planoRutaArchivo = reader.GetValue(6)
                mapas.estado = reader.GetValue(7)
                listaMapasPendientesEvaluar.Add(mapas)
            End While
        Catch ex As Exception
        End Try
        Return listaMapasPendientesEvaluar
    End Function

    '//// VENTANA CONTROL QUERY DOS
    Function ConsultoMapaYHagoControl(ByVal ID_mapaRiesgo As Integer, ByVal conn As OdbcConnection, ByVal listaUbicacionesConRiesgos As List(Of RiesgoUbicacion), ByVal variableDeCambiodeQuery As String)
        Try
            Dim sqlquery As String = "select * from ubicacion_riesgo " &
            "inner join riesgos on ubicacion_riesgo.riesgo_id = riesgos.riesgo_id " &
            "inner join mapa_riesgo on ubicacion_riesgo.mapa_id = mapa_riesgo.mapa_id " &
            "where mapa_riesgo.estado=? and ubicacion_riesgo.mapa_id=?"
            Dim command As OdbcCommand = New OdbcCommand(sqlquery, conn) With {
             .CommandText = sqlquery,
             .Connection = conn
         }
            command.Parameters.AddWithValue("@?", variableDeCambiodeQuery)
            command.Parameters.AddWithValue("@?", ID_mapaRiesgo)
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                Dim riesgoUbicacion As New RiesgoUbicacion
                riesgoUbicacion.ubicacionID = reader.GetValue(0)
                riesgoUbicacion.mapaID = reader.GetValue(1)
                riesgoUbicacion.ubicacionNombre = reader.GetValue(2)
                riesgoUbicacion.critico = reader.GetValue(3)
                riesgoUbicacion.riesgoID = reader.GetValue(4)
                riesgoUbicacion.descripcion = reader.GetValue(5)
                riesgoUbicacion.solucion = reader.GetValue(6)
                riesgoUbicacion.plazo = reader.GetValue(7)
                riesgoUbicacion.cumplidoEnfecha = reader.GetValue(8)
                riesgoUbicacion.coordendaX = reader.GetValue(9)
                riesgoUbicacion.coordenadaY = reader.GetValue(10)
                '11
                '12
                riesgoUbicacion.riesgoIcono = reader.GetValue(13)
                '14
                '15
                '16
                '17
                '18
                '19
                riesgoUbicacion.estado = reader.GetValue(20)
                listaUbicacionesConRiesgos.Add(riesgoUbicacion)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return listaUbicacionesConRiesgos
    End Function


    '//// VENTANA CONTROL QUERY TRES


    Function ConsultoInformacionDelMapaElegido(ByVal mapaRiesgoElegido As Mapa, ByVal ID_MAPA As Integer, ByVal conn As OdbcConnection, ByVal variableDeCambiodeQuery As String)
        Try
            Dim sqlquery As String = "select * from mapa_riesgo where mapa_riesgo.mapa_id=? and mapa_riesgo.estado=?"
            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            command.Parameters.AddWithValue("@?", ID_MAPA)
            command.Parameters.AddWithValue("@?", variableDeCambiodeQuery)
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                mapaRiesgoElegido.mapaID = reader.GetValue(0)
                mapaRiesgoElegido.sucursalID = reader.GetValue(1)
                mapaRiesgoElegido.mapaRiesgoNombre = reader.GetValue(2)
                mapaRiesgoElegido.empleadoCedula = reader.GetValue(3)
                mapaRiesgoElegido.controladoPor = reader.GetValue(4)
                mapaRiesgoElegido.fecha = reader.GetValue(5)
                mapaRiesgoElegido.planoRutaArchivo = reader.GetValue(6)
                mapaRiesgoElegido.estado = reader.GetValue(7)
            End While
        Catch ex As Exception
        End Try
        Return mapaRiesgoElegido
    End Function

    ' '/// imnventario
    ' Function consultoFilasInventario(ByVal ID_INVENTARIO As Integer, ByVal conn As OdbcConnection, ByVal listaUbicacionesConRiesgos As List(Of RiesgoUbicacion))
    '     Try
    '         Dim sqlquery As String = "select * from inventario_fila where inventario_fila.inventario_id=? and inventario_fila.estado=?"
    '         Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
    '             .CommandText = sqlquery,
    '             .Connection = conn
    '         }
    '         command.Parameters.AddWithValue("@?", ID_INVENTARIO)
    '         command.Parameters.AddWithValue("@?", "A")
    '         Dim reader As OdbcDataReader
    '         reader = command.ExecuteReader
    '         While (reader.Read())
    '             Dim riesgoUbicacion As New RiesgoUbicacion
    '             riesgoUbicacion.ubicacionID = reader.GetValue(0)
    '             riesgoUbicacion.mapaID = reader.GetValue(1)
    '             riesgoUbicacion.ubicacionNombre = reader.GetValue(2)
    '             riesgoUbicacion.critico = reader.GetValue(3)
    '             riesgoUbicacion.riesgoID = reader.GetValue(4)
    '
    '             listaUbicacionesConRiesgos.Add(riesgoUbicacion)
    '         End While
    '     Catch ex As Exception
    '     End Try
    '     Return mapaRiesgoElegido
    ' End Function



    '///CONSULTO INFORMACION COMPLETA SUCURSAL POR ID_SUCURSAL
    Function ConsultoInformacionCOmpletaSucursalPorID_SUCURSAL(ByVal sucursalelegida As Sucursal, ByVal ID_SUCURSAL As Integer, ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "select * from sucursal where sucursal.sucursal_id=? and sucursal.estado=?"
            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            command.Parameters.AddWithValue("@?", ID_SUCURSAL)
            command.Parameters.AddWithValue("@?", "A")
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                sucursalelegida.sucursalID = reader.GetValue(0)
                sucursalelegida.empresaRUT = reader.GetValue(1)
                sucursalelegida.empresaNombre = reader.GetValue(2)
                sucursalelegida.sucursalNombre = reader.GetValue(3)
                sucursalelegida.sucursalDireccion = reader.GetValue(4)
                sucursalelegida.telefono = reader.GetValue(5)
                sucursalelegida.estado = reader.GetValue(6)
                sucursalelegida.totalEmpleadosSucursal = reader.GetValue(7)
            End While
        Catch ex As Exception
        End Try
        Return sucursalelegida
    End Function


    '///CONSULTO NOMBRE SUCURSAL POR ID_SUCURSAL
    Function ConsultoNombreSucursalPorID(ByVal NOMBRE_SUCURSAL As String, ByVal ID_SUCURSAL As Integer, ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "select sucursal_nombre from sucursal where sucursal.sucursal_id=? and sucursal.estado=?"
            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            command.Parameters.AddWithValue("@?", ID_SUCURSAL)
            command.Parameters.AddWithValue("@?", "A")
            NOMBRE_SUCURSAL = command.ExecuteScalar
        Catch ex As Exception
        End Try
        Return NOMBRE_SUCURSAL
    End Function

    '///CONSULTO MATRICULA SUCURSAL POR CEDULA
    Function ConsultoMatriculaPorCedula(ByVal matricula As String, ByVal cedula As Integer, ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "select empleado.matricula from empleado where empleado.empleado_cedula=? and empleado.empleado_tipo=?"
            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            command.Parameters.AddWithValue("@?", cedula)
            command.Parameters.AddWithValue("@?", "PREVENCIONISTA")
            matricula = command.ExecuteScalar
        Catch ex As Exception
        End Try
        Return matricula
    End Function

    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////                     
    '                                _____ _   _  _____ ______ _____ _______    _____ _    _  _____ _______ ____  __  __ 
    '                               |_   _| \ | |/ ____|  ____|  __ \__   __|  / ____| |  | |/ ____|__   __/ __ \|  \/  |
    '                                 | | |  \| | (___ | |__  | |__) | | |    | |    | |  | | (___    | | | |  | | \  / |
    '                                 | | | . ` |\___ \|  __| |  _  /  | |    | |    | |  | |\___ \   | | | |  | | |\/| |
    '                                _| |_| |\  |____) | |____| | \ \  | |    | |____| |__| |____) |  | | | |__| | |  | |
    '                               |_____|_| \_|_____/|______|_|  \_\ |_|     \_____|\____/|_____/   |_|  \____/|_|  |_|
    '                                                      
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    'ACTUALIZO NOMBRE EMPRESA
    Function actualizoNombreDeEmpresaParaTodasLasSucursalesConMismoRUT(ByVal empresa As Sucursal, ByVal estadoEdicion As Boolean, ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "update sucursal SET sucursal.empresa_nombre=? where sucursal.empresa_rut=?"
            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            command.Parameters.AddWithValue("@?", empresa.empresaNombre)
            command.Parameters.AddWithValue("@?", empresa.empresaRUT)
            estadoEdicion = command.ExecuteNonQuery
        Catch ex As Exception
        End Try
        Return estadoEdicion
    End Function

    'ACTUALIZO CAMPOS SUCURSALES
    Function actualizoCamposSucursal(ByVal empresa As Sucursal, ByVal estadoEdicion As Boolean, ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "update sucursal SET sucursal.empresa_nombre=?, sucursal.sucursal_nombre=?, " &
            "sucursal.sucursal_direccion=?, sucursal.telefono=?, sucursal.total_trabajadores=? " &
            "where sucursal.sucursal_id =?"
            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            command.Parameters.AddWithValue("@?", empresa.empresaNombre)
            command.Parameters.AddWithValue("@?", empresa.sucursalNombre)
            command.Parameters.AddWithValue("@?", empresa.sucursalDireccion)
            command.Parameters.AddWithValue("@?", empresa.telefono)
            command.Parameters.AddWithValue("@?", empresa.totalEmpleadosSucursal)
            command.Parameters.AddWithValue("@?", empresa.sucursalID)
            estadoEdicion = command.ExecuteNonQuery
            estadoEdicion = True
        Catch ex As Exception
            estadoEdicion = False
        End Try
        Return estadoEdicion
    End Function


    '/////////// UPDATE MAPA RIESGO SE EJECUTAN ENCADENADAS
    Function actualizoEstadoDelMapadeRiesgo(ByVal controladoPorMatricula As String, ByVal ID_MAPA_Riesgo As Integer, ByVal actualizado As Boolean, ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "update mapa_riesgo SET mapa_riesgo.controlado_por_matricula=?, " &
            "mapa_riesgo.estado=? where mapa_riesgo.mapa_id=?"
            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            command.Parameters.AddWithValue("@?", controladoPorMatricula)
            command.Parameters.AddWithValue("@?", "T")
            command.Parameters.AddWithValue("@?", ID_MAPA_Riesgo)
            actualizado = command.ExecuteNonQuery
            actualizado = True
        Catch ex As Exception
        End Try
        Return actualizado
    End Function

    Function actualizoCumplimiento(ByVal ID_MAPA_Riesgo As Integer, ByVal riesgo As RiesgoUbicacion, ByVal actualizoUbicaciones As Boolean, ByVal conn As OdbcConnection)
        Try
            Dim sqlquery As String = "update ubicacion_riesgo SET ubicacion_riesgo.cumplido_en_fecha=?" &
            "where ubicacion_riesgo.mapa_id=? and ubicacion_riesgo.ubicacion_id =?"
            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            command.Parameters.AddWithValue("@?", riesgo.cumplidoEnfecha)
            command.Parameters.AddWithValue("@?", ID_MAPA_Riesgo)
            command.Parameters.AddWithValue("@?", riesgo.ubicacionID)
            actualizoUbicaciones = command.ExecuteNonQuery
            actualizoUbicaciones = True

        Catch ex As Exception
        End Try
        Return actualizoUbicaciones
    End Function



    'CONSULTO EMPRESA POR NOMBRE
    Function consultoUsuarioPoTexto(ByVal listaEmpleados As List(Of Empleado), ByVal textoEnviado As String, ByVal conn As OdbcConnection)
        MessageBox.Show(textoEnviado)
        '/NO PUDE PARAMETRIZAR ESTA QUERY ...ALGO DEL LIKE, ME DETECATA EL "?" COMO CARACTER DE BUSQUEDA...BUE...TA
        Try
            Dim numero As Integer = 0
            Dim qUno As String = "select * from empleado where empleado.empleado_nombre LIKE '%" & textoEnviado & "%' ESCAPE '\' "
            Dim qDos As String = "or empleado.empleado_username LIKE '%" & textoEnviado & "%' ESCAPE '\' or empleado.empleado_cedula LIKE '%" & Integer.TryParse(textoEnviado, numero) & "%' ESCAPE '\'"
            Dim sqlquery As String = qUno + qDos

            Dim command As New Odbc.OdbcCommand(sqlquery, conn) With {
                .CommandText = sqlquery,
                .Connection = conn
            }
            Console.WriteLine(sqlquery)
            Dim reader As OdbcDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                Dim nueva As New Empleado
                nueva.empleadoID = reader.GetValue(0)
                nueva.empleadoCedula = reader.GetValue(1)
                nueva.empleadoNombre = reader.GetValue(2)
                nueva.empleadoUsername = reader.GetValue(3)
                nueva.empleadoTipo = reader.GetValue(4)
                nueva.matricula = reader.GetValue(5)
                nueva.empleadoDireccion = reader.GetValue(6)
                nueva.empleadoTelefono = reader.GetValue(7)
                nueva.empleadoCelular = reader.GetValue(8)
                nueva.empleadoEmail = reader.GetValue(9)
                listaEmpleados.Add(nueva)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return listaEmpleados
    End Function





End Module

