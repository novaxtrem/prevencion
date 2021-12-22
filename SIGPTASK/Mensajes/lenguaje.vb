Public Class lenguaje
    
    Shared Function debeIngresarUsuario(ByVal debeIngresarUsuario1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            debeIngresarUsuario = "debe ingresar un usuario"
        Else
            debeIngresarUsuario = "insert a username"
        End If
        Return debeIngresarUsuario
    End Function
    Shared Function debeIngresarContrasenia(ByVal debeIngresarContrasenia1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            debeIngresarContrasenia = "debe ingresar una contraseña"
        Else
            debeIngresarContrasenia = "insert password"
        End If
        Return debeIngresarContrasenia
    End Function
    Shared Function usuarioOContraseniaError(ByVal usuarioOContraseniaError1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            usuarioOContraseniaError = "error con el usuario y/o la contraseña"
        Else
            usuarioOContraseniaError = "user or password error"
        End If
        Return usuarioOContraseniaError
    End Function
    Shared Function ingresarEmpleadoEnBase(ByVal ingresarEmpleadoEnBase1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            ingresarEmpleadoEnBase = "el usuario no hallado en la base de datos" + vbLf + "hable con un administrador"
        Else
            ingresarEmpleadoEnBase = "username not found in database" + vbLf + "contact system Admin"
        End If
        Return ingresarEmpleadoEnBase
    End Function

    Shared Function varIDcuestionario(ByVal varIDcuestionario1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varIDcuestionario = "Cuestionario ID"
        Else
            varIDcuestionario = "Questionary ID"
        End If
        Return varIDcuestionario

    End Function
    Shared Function varSucursalID(ByVal varSucursalID1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varSucursalID = "Sucursal ID"
        Else
            varSucursalID = "Subsidiary ID"
        End If
        Return varSucursalID
    End Function

    Shared Function varEmpleadoCedula(ByVal varEmpleadoCedula1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varEmpleadoCedula = "Cedula Empelado"
        Else
            varEmpleadoCedula = "Employee ID"
        End If
        Return varEmpleadoCedula
    End Function

    Shared Function varCuestionarioNombre(ByVal varCuestionarioNombre1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varCuestionarioNombre = "Nombre Cuestionario"
        Else
            varCuestionarioNombre = "Questionary name"
        End If
        Return varCuestionarioNombre
    End Function

    Shared Function varCuestionarioFecha(ByVal varCuestionarioFecha1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varCuestionarioFecha = "Fecha"
        Else
            varCuestionarioFecha = "Date"
        End If
        Return varCuestionarioFecha

    End Function
    Shared Function varCuestionarioNota(ByVal varCuestionarioNota1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varCuestionarioNota = "Nota"
        Else
            varCuestionarioNota = "Note"
        End If
        Return varCuestionarioNota

    End Function

    Shared Function varEmpresaRut(ByVal varEmpresaRut1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varEmpresaRut = "RUT"
        Else
            varEmpresaRut = "Company RUT"
        End If
        Return varEmpresaRut
    End Function

    Shared Function varSucursalNombre(ByVal varSucursalNombre1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varSucursalNombre = "Nombre Sucursal"
        Else
            varSucursalNombre = "Subsidiary Name"
        End If
        Return varSucursalNombre
    End Function

    Shared Function varEmpleadoNombre(ByVal varEmpleadoNombre1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varEmpleadoNombre = "Nombre del Tecnico"
        Else
            varEmpleadoNombre = "Technician Name"
        End If
        Return varEmpleadoNombre
    End Function

    Shared Function varEmpleadoMatricula(ByVal varEmpleadoMatricula1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varEmpleadoMatricula = "Matricula Tecnico"
        Else
            varEmpleadoMatricula = "Technician ID"
        End If
        Return varEmpleadoMatricula
    End Function

    Shared Function varEmpresaNombre(ByVal varEmpresaNombre1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varEmpresaNombre = "Nombre Empresa"
        Else
            varEmpresaNombre = "Company Name"
        End If
        Return varEmpresaNombre
    End Function

    Shared Function varSucursalTelefono(ByVal varSucursalTelefono1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varSucursalTelefono = "Telefono de la Sucursal"
        Else
            varSucursalTelefono = "Subsidiary Phone"
        End If
        Return varSucursalTelefono
    End Function

    Shared Function varSucursalDireccion(ByVal varSucursalDireccion1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varSucursalDireccion = "Direccion de la Sucursal"
        Else
            varSucursalDireccion = "Subsidiary Address"
        End If
        Return varSucursalDireccion
    End Function

    Shared Function varEmpresaEstado(ByVal varEmpresaEstado1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varEmpresaEstado = "Estado"
        Else
            varEmpresaEstado = "Estade"
        End If
        Return varEmpresaEstado
    End Function

    Shared Function varEmpresaTotalEmpleados(ByVal varEmpresaTotalEmpleados1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varEmpresaTotalEmpleados = "Empleados de la Sucursal"
        Else
            varEmpresaTotalEmpleados = "Subsidiary Workers amount"
        End If
        Return varEmpresaTotalEmpleados
    End Function

    Shared Function empresaSeleccionada(ByVal empresaSeleccionada1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            empresaSeleccionada = "Sucursal Seleccionada: "
        Else
            empresaSeleccionada = "Selected Subsidiary: "
        End If
        Return empresaSeleccionada
    End Function

    Shared Function varObjetoID(ByVal varObjetoID1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varObjetoID = "ID de Objeto"
        Else
            varObjetoID = "Object ID"
        End If
        Return varObjetoID
    End Function

    Shared Function varObjetoNombre(ByVal varObjetoNombre1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varObjetoNombre = "Objeto"
        Else
            varObjetoNombre = "Object"
        End If
        Return varObjetoNombre
    End Function

    Shared Function varPreguntaID(ByVal varPreguntaID1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varPreguntaID = "Pregunta ID"
        Else
            varPreguntaID = "Question ID"
        End If
        Return varPreguntaID
    End Function

    Shared Function varPregunta(ByVal varPregunta1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varPregunta = "Pregunta"
        Else
            varPregunta = "Question"
        End If
        Return varPregunta
    End Function

    Shared Function varRiesgoMuerte(ByVal varRiesgoMuerte1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varRiesgoMuerte = "Riesgo de Muerte"
        Else
            varRiesgoMuerte = "Death's Risk"
        End If
        Return varRiesgoMuerte
    End Function

    Shared Function varAccionID(ByVal varAccionID1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varAccionID = "Accion ID"
        Else
            varAccionID = "Action ID"
        End If
        Return varAccionID
    End Function

    Shared Function varAccion(ByVal varAccion1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varAccion = "Accion"
        Else
            varAccion = "Contingency"
        End If
        Return varAccion
    End Function

    Shared Function noSeleccionoNingunRiesgo(ByVal noSeleccionoNingunRiesgo1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            noSeleccionoNingunRiesgo = "No selecciono ningun Riesgo"
        Else
            noSeleccionoNingunRiesgo = "No Risk selected"
        End If
        Return noSeleccionoNingunRiesgo
    End Function

    Shared Function SeborraranloscambiosEfectuados(ByVal SeborraranloscambiosEfectuados1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            SeborraranloscambiosEfectuados = "Hay Riesgos ingresados, si continua se borraran los cambios" + vbLf + "contnuar?"
        Else
            SeborraranloscambiosEfectuados = "Risk's added in the window, if contue the changes may be lost" + vbLf + "contnue anyway?"
        End If
        Return SeborraranloscambiosEfectuados
    End Function

    Shared Function TipoImagen(ByVal TipoImagen1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            TipoImagen = "Tipo img"
        Else
            TipoImagen = "Tipe img"
        End If
        Return TipoImagen
    End Function

    Shared Function noSeleccionoArchivo(ByVal noSeleccionoArchivo1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            noSeleccionoArchivo = "No selecciono ningun archivo o el archivo no es compatible"
        Else
            noSeleccionoArchivo = "No file selected or file it's not compatible"
        End If
        Return noSeleccionoArchivo
    End Function

    Shared Function riesgoAgregadoConExito(ByVal riesgoAgregadoConExito1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            riesgoAgregadoConExito = "Riesgo cargado con Exito"
        Else
            riesgoAgregadoConExito = "Risk correctly loaded"
        End If
        Return riesgoAgregadoConExito
    End Function

    Shared Function riesgoNOagregado(ByVal riesgoNOagregado1 As String) As String
        '//Si la base esta corriendo es muy inprobable que algun dia llegue a ver este mensaje de error jajaja
        If idiomaSeleccionado.Equals("ESP") Then
            riesgoNOagregado = "Riesgo no cargado, reinicie el ordenador," + vbLf + "tome unos mates o cafe con bizcochos y contacte a sistemas"
        Else
            riesgoNOagregado = "Risk not loaded, restart your computer, if this doesn't work" + vbLf + " take a mates or coffee with bizcochos and contact IT support"
        End If
        Return riesgoNOagregado
    End Function

    Shared Function planoIngresadoConExitoGenerandoReporte(ByVal planoIngresadoConExitoGenerandoReporte1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            planoIngresadoConExitoGenerandoReporte = "Mapa de riesgo generado con exito"
        Else
            planoIngresadoConExitoGenerandoReporte = "Risk map sucefull"
        End If
        Return planoIngresadoConExitoGenerandoReporte
    End Function

    Shared Function hayUbicacionesSinNombreRectifique(ByVal hayUbicacionesSinNombreRectifique1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            hayUbicacionesSinNombreRectifique = "Hay ubicaciones sin nombre, rectifique por favor"
        Else
            hayUbicacionesSinNombreRectifique = "The map cantains ubications with no name, check please"
        End If
        Return hayUbicacionesSinNombreRectifique
    End Function

    Shared Function solonumeros(ByVal solonumeros1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            solonumeros = "Solo numeros"
        Else
            solonumeros = "Only numbers"
        End If
        Return solonumeros
    End Function

    Shared Function numeroExcedemaximo(ByVal numeroExcedemaximo1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            numeroExcedemaximo = "el numero supera el maximo permitido por la aplicacion, rectifique"
        Else
            numeroExcedemaximo = "The number it's too large than application can handle, verify"
        End If
        Return numeroExcedemaximo
    End Function

    Shared Function varPreguntaRealizada(ByVal varPreguntaRealizada1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varPreguntaRealizada = "Pregunta Realizada"
        Else
            varPreguntaRealizada = "question asked"
        End If
        Return varPreguntaRealizada
    End Function

    Shared Function varAccionSugerida(ByVal varAccionSugerida1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varAccionSugerida = "Accion Sugerida"
        Else
            varAccionSugerida = "attached action"
        End If
        Return varAccionSugerida
    End Function

    Shared Function ValoresDeconsecuenciaExtremos(ByVal ValoresDeconsecuenciaExtremos1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            ValoresDeconsecuenciaExtremos = "Valores de consecuencia Extremos"
        Else
            ValoresDeconsecuenciaExtremos = "Extreme Consequence Values"
        End If
        Return ValoresDeconsecuenciaExtremos
    End Function

    Shared Function varRespuestaObetenida(ByVal varRespuestaObetenida1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varRespuestaObetenida = "Respuesta obtenida"
        Else
            varRespuestaObetenida = "Response obtained"
        End If
        Return varRespuestaObetenida
    End Function

    Shared Function varRiesgoDeMuerte(ByVal varRiesgoDeMuerte1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varRiesgoDeMuerte = "Riesgo de Muerte"
        Else
            varRiesgoDeMuerte = "Death Risk"
        End If
        Return varRiesgoDeMuerte
    End Function

    Shared Function varGradoExposicion(ByVal varGradoExposicion1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varGradoExposicion = "Grado Exposicion"
        Else
            varGradoExposicion = "Exposition  Grade"
        End If
        Return varGradoExposicion
    End Function

    Shared Function varGradoProbabilidad(ByVal varGradoProbabilidad1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varGradoProbabilidad = "Grado Probabilidad"
        Else
            varGradoProbabilidad = "Degree Probability"
        End If
        Return varGradoProbabilidad
    End Function

    Shared Function varGradoConsecuencia(ByVal varGradoConsecuencia1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varGradoConsecuencia = "Grado Consecuencia"
        Else
            varGradoConsecuencia = "Consequence Degree"
        End If
        Return varGradoConsecuencia
    End Function

    Shared Function varTecnicoResponsable(ByVal varTecnicoResponsable1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varTecnicoResponsable = "Tecnico Responsable"
        Else
            varTecnicoResponsable = "Responsible Technician"
        End If
        Return varTecnicoResponsable
    End Function

    Shared Function varFecha(ByVal varFecha1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varFecha = "Fecha"
        Else
            varFecha = "Date"
        End If
        Return varFecha
    End Function

    Shared Function varNombreCuestionario(ByVal varNombreCuestionario1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varNombreCuestionario = "Nombre del Cuestionario"
        Else
            varNombreCuestionario = "Questionary Name"
        End If
        Return varNombreCuestionario
    End Function

    Shared Function varNombreSucursal(ByVal varNombreSucursal1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varNombreSucursal = "Nombre de la Sucursal"
        Else
            varNombreSucursal = "Subsidiary name"
        End If
        Return varNombreSucursal
    End Function

    Shared Function estadoSucursal(ByVal estadoSucursal1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            estadoSucursal = "Estado de la sucursal"
        Else
            estadoSucursal = "Subsidiary estate"
        End If
        Return estadoSucursal
    End Function

    Shared Function varRiesgoMuyBajo(ByVal varRiesgoMuyBajo1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varRiesgoMuyBajo = "No hay riesgos relevantes"
        Else
            varRiesgoMuyBajo = "No relevant Risks"
        End If
        Return varRiesgoMuyBajo
    End Function

    Shared Function varRiesgoBajo(ByVal varRiesgoBajo1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varRiesgoBajo = "Riesgo Bajo"
        Else
            varRiesgoBajo = "Low Risk"
        End If
        Return varRiesgoBajo
    End Function

    Shared Function varRiesgoModerado(ByVal varRiesgoModerado1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varRiesgoModerado = "Riesgo Moderado"
        Else
            varRiesgoModerado = "Moderate Risk"
        End If
        Return varRiesgoModerado
    End Function

    Shared Function varRiesgoALto(ByVal varRiesgoALto1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varRiesgoALto = "Riesgo Alto"
        Else
            varRiesgoALto = "Higt Risk"
        End If
        Return varRiesgoALto
    End Function

    Shared Function vaRiesgoExtremo(ByVal vaRiesgoExtremo1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            vaRiesgoExtremo = "Riesgo Extremo"
        Else
            vaRiesgoExtremo = "Extreme Risk"
        End If
        Return vaRiesgoExtremo
    End Function

    Shared Function EstaPreguntaImplicaRiesgoDeMuerte(ByVal EstaPreguntaImplicaRiesgoDeMuerte1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            EstaPreguntaImplicaRiesgoDeMuerte = "Esta Pregunta implica riesgo de Muerte"
        Else
            EstaPreguntaImplicaRiesgoDeMuerte = "This Question implies death risk"
        End If
        Return EstaPreguntaImplicaRiesgoDeMuerte
    End Function

    Shared Function NoHayRiesgoDeMuerteAsociadoAEstaPregunta(ByVal NoHayRiesgoDeMuerteAsociadoAEstaPregunta1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            NoHayRiesgoDeMuerteAsociadoAEstaPregunta = "No hay riesgo de muerte asociado a esta pregunta"
        Else
            NoHayRiesgoDeMuerteAsociadoAEstaPregunta = "There is no risk of death associated with this question"
        End If
        Return NoHayRiesgoDeMuerteAsociadoAEstaPregunta
    End Function

    Shared Function RespuestaContestadaInsactisfactoriamente(ByVal RespuestaContestadaInsactisfactoriamente1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            RespuestaContestadaInsactisfactoriamente = "Respuesta contestada insactisfactoriamente"
        Else
            RespuestaContestadaInsactisfactoriamente = "Answer answered unsatisfactorily"
        End If
        Return RespuestaContestadaInsactisfactoriamente
    End Function

    Shared Function ValoresDeProbabiliadInfimos(ByVal ValoresDeProbabiliadInfimos1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            ValoresDeProbabiliadInfimos = "Valores de probabiliad infimos"
        Else
            ValoresDeProbabiliadInfimos = "Very low Probability values"
        End If
        Return ValoresDeProbabiliadInfimos
    End Function

    Shared Function ValoresDeProbabiliadBajos(ByVal ValoresDeProbabiliadBajos1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            ValoresDeProbabiliadBajos = "Valores de probabiliad bajos"
        Else
            ValoresDeProbabiliadBajos = "Probability values ​​low"
        End If
        Return ValoresDeProbabiliadBajos
    End Function

    Shared Function ValoresDeProbabiliadMedios(ByVal ValoresDeProbabiliadMedios1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            ValoresDeProbabiliadMedios = "Valores de probabiliad medios"
        Else
            ValoresDeProbabiliadMedios = "Probability values ​​medium"
        End If
        Return ValoresDeProbabiliadMedios
    End Function

    Shared Function ValoresDeProbabiliadAltos(ByVal ValoresDeProbabiliadAltos1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            ValoresDeProbabiliadAltos = "Valores de probabiliad altos"
        Else
            ValoresDeProbabiliadAltos = "higth Probability values"
        End If
        Return ValoresDeProbabiliadAltos
    End Function

    Shared Function ValoresDeProbabiliadExtremos(ByVal ValoresDeProbabiliadExtremos1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            ValoresDeProbabiliadExtremos = "Valores de probabiliad extremos"
        Else
            ValoresDeProbabiliadExtremos = "extreme Probability values"
        End If
        Return ValoresDeProbabiliadExtremos
    End Function

    Shared Function ValoresDeExposicionInfimos(ByVal ValoresDeExposicionInfimos1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            ValoresDeExposicionInfimos = "Valores de exposicion infimos"
        Else
            ValoresDeExposicionInfimos = "Very low Exposure Values"
        End If
        Return ValoresDeExposicionInfimos
    End Function

    Shared Function ValoresDeExposicionBajos(ByVal ValoresDeExposicionBajos1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            ValoresDeExposicionBajos = "Valores de exposicion bajos"
        Else
            ValoresDeExposicionBajos = "low Exposure Values"
        End If
        Return ValoresDeExposicionBajos
    End Function

    Shared Function ValoresDeExposicionMedios(ByVal ValoresDeExposicionMedios1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            ValoresDeExposicionMedios = "Valores de exposicion medios"
        Else
            ValoresDeExposicionMedios = "medium Exposure Values"
        End If
        Return ValoresDeExposicionMedios
    End Function

    Shared Function ValoresDeExposicionAltos(ByVal ValoresDeExposicionAltos1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            ValoresDeExposicionAltos = "Valores de exposicion altos"
        Else
            ValoresDeExposicionAltos = "higth Exposure Values"
        End If
        Return ValoresDeExposicionAltos
    End Function

    Shared Function ValoresDeExposicionExtremos(ByVal ValoresDeExposicionExtremos1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            ValoresDeExposicionExtremos = "Valores de exposicion extremos"
        Else
            ValoresDeExposicionExtremos = "extreme Exposure Values"
        End If
        Return ValoresDeExposicionExtremos
    End Function

    Shared Function ValoresDeConsecuenciaInfimos(ByVal ValoresDeConsecuenciaInfimos1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            ValoresDeConsecuenciaInfimos = "Valores de consecuencia infimos"
        Else
            ValoresDeConsecuenciaInfimos = "Very low Consequence Values"
        End If
        Return ValoresDeConsecuenciaInfimos
    End Function

    Shared Function ValoresDeConsecuenciaBajos(ByVal ValoresDeConsecuenciaBajos1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            ValoresDeConsecuenciaBajos = "Valores de consecuencia bajos"
        Else
            ValoresDeConsecuenciaBajos = "low Consequence Values"
        End If
        Return ValoresDeConsecuenciaBajos
    End Function

    Shared Function ValoresDeConsecuenciaMedios(ByVal ValoresDeConsecuenciaMedios1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            ValoresDeConsecuenciaMedios = "Valores de consecuencia medios"
        Else
            ValoresDeConsecuenciaMedios = "medium Consequence Values"
        End If
        Return ValoresDeConsecuenciaMedios
    End Function

    Shared Function ValoresDeConsecuenciaAltos(ByVal ValoresDeConsecuenciaAltos1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            ValoresDeConsecuenciaAltos = "Valores de consecuencia altos"
        Else
            ValoresDeConsecuenciaAltos = "higth Consequence Values"
        End If
        Return ValoresDeConsecuenciaAltos
    End Function

    Shared Function RespuestaContestadaSatisfactoriamente(ByVal RespuestaContestadaSatisfactoriamente1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            RespuestaContestadaSatisfactoriamente = "Respuesta contestada satisfactoriamente"
        Else
            RespuestaContestadaSatisfactoriamente = "Answer answered satisfactorily"
        End If
        Return RespuestaContestadaSatisfactoriamente
    End Function

    Shared Function noSeleccionoNada(ByVal noSeleccionoNada1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            noSeleccionoNada = "no selecciono nada"
        Else
            noSeleccionoNada = "anything selected"
        End If
        Return noSeleccionoNada
    End Function

    Shared Function OcultarDetalles(ByVal OcultarDetalles1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            OcultarDetalles = "Ocultar Detalles"
        Else
            OcultarDetalles = "Hide Details"
        End If
        Return OcultarDetalles
    End Function

    Shared Function MostrarDetalles(ByVal MostrarDetalles1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            MostrarDetalles = "Mostar Detalles"
        Else
            MostrarDetalles = "Show Details"
        End If
        Return MostrarDetalles
    End Function

    Shared Function OcultarNotas(ByVal OcultarNotas1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            OcultarNotas = "Ocultar Notas"
        Else
            OcultarNotas = "Hide Notes"
        End If
        Return OcultarNotas
    End Function

    Shared Function MostrarNotas(ByVal MostrarNotas1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            MostrarNotas = "Mostrar Notas"
        Else
            MostrarNotas = "Show Notes"
        End If
        Return MostrarNotas
    End Function

    Shared Function noTienePermisoParaAccederAlsistema(ByVal noTienePermisoParaAccederAlsistema1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            noTienePermisoParaAccederAlsistema = "No tiene permiso para acceder al sistema"
        Else
            noTienePermisoParaAccederAlsistema = "You Dont have privegies to access the system"
        End If
        Return noTienePermisoParaAccederAlsistema
    End Function

    Shared Function laCedulaOElusuarioYaExisteEnlaBase(ByVal laCedulaOElusuarioYaExisteEnlaBase1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            laCedulaOElusuarioYaExisteEnlaBase = "Usuario NO agregado" + vbLf + "Cedula o nombre de Usuario ya existente en la base"
        Else
            laCedulaOElusuarioYaExisteEnlaBase = "User NOT added" + vbLf + "ID or Username already exists in database"
        End If
        Return laCedulaOElusuarioYaExisteEnlaBase
    End Function

    Shared Function empleadoAgregadoConExito(ByVal empleadoAgregadoConExito1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            empleadoAgregadoConExito = "Usuario agregado con exito"
        Else
            empleadoAgregadoConExito = "User added sussefully"
        End If
        Return empleadoAgregadoConExito
    End Function

    Shared Function haOcurridoUnProblemaContacteASistemas(ByVal haOcurridoUnProblemaContacteASistemas1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            haOcurridoUnProblemaContacteASistemas = "Ha ocurrido un problema, contacte asistemas"
        Else
            haOcurridoUnProblemaContacteASistemas = "Something wrong happends, contac IT Support"
        End If
        Return haOcurridoUnProblemaContacteASistemas
    End Function

    Shared Function noAdmitido(ByVal noAdmitido1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            noAdmitido = "No admitido, solo numeros enteros, no negativos"
        Else
            noAdmitido = "Not admitted, only integers, not negatives"
        End If
        Return noAdmitido
    End Function

    Shared Function varIDUsuario(ByVal varIDUsuario1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varIDUsuario = "ID de usuario"
        Else
            varIDUsuario = "User ID"
        End If
        Return varIDUsuario
    End Function

    Shared Function varUSUARIONombre(ByVal varUSUARIONombre1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varUSUARIONombre = "Nombre"
        Else
            varUSUARIONombre = "Employee Name"
        End If
        Return varUSUARIONombre
    End Function

    Shared Function varEmpleadoUSERNAME(ByVal varEmpleadoUSERNAME1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varEmpleadoUSERNAME = "Nombre de usuario"
        Else
            varEmpleadoUSERNAME = "Username"
        End If
        Return varEmpleadoUSERNAME
    End Function

    Shared Function varEmpleadoTIPO(ByVal varEmpleadoTIPO1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varEmpleadoTIPO = "Tipo"
        Else
            varEmpleadoTIPO = "Type"
        End If
        Return varEmpleadoTIPO
    End Function

    Shared Function varEmpleadoDireccion(ByVal varEmpleadoDireccion1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varEmpleadoDireccion = "Direccion"
        Else
            varEmpleadoDireccion = "Address"
        End If
        Return varEmpleadoDireccion
    End Function

    Shared Function varEmpleadoTelefono(ByVal varEmpleadoTelefono1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varEmpleadoTelefono = "Telefono"
        Else
            varEmpleadoTelefono = "Phone"
        End If
        Return varEmpleadoTelefono
    End Function

    Shared Function varEmpleadoCelular(ByVal varEmpleadoCelular1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varEmpleadoCelular = "Celular"
        Else
            varEmpleadoCelular = "Cellphone"
        End If
        Return varEmpleadoCelular
    End Function

    Shared Function varEmpleadoEmail(ByVal varEmpleadoEmail1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varEmpleadoEmail = "Email"
        Else
            varEmpleadoEmail = "Email"
        End If
        Return varEmpleadoEmail
    End Function

    Shared Function varMapaID(ByVal varMapaID1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varMapaID = "Mapa ID"
        Else
            varMapaID = "Map ID"
        End If
        Return varMapaID
    End Function

    Shared Function varPlanoRutaArchivo(ByVal varPlanoRutaArchivo1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varPlanoRutaArchivo = "Ruta Plano"
        Else
            varPlanoRutaArchivo = "Floor plan location"
        End If
        Return varPlanoRutaArchivo
    End Function

    Shared Function varEstado(ByVal varEstado1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varEstado = "Estado"
        Else
            varEstado = "status"
        End If
        Return varEstado
    End Function

    Shared Function varMapaRiesgoNombre(ByVal varMapaRiesgoNombre1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varMapaRiesgoNombre = "Nombre Mapa de Riesgo"
        Else
            varMapaRiesgoNombre = "Risk Map Name"
        End If
        Return varMapaRiesgoNombre
    End Function

    Shared Function atencionSeActualizaraElNombreDeEmpresaParaTodasLasSucursales(ByVal atencionSeActualizaraElNombreDeEmpresaParaTodasLasSucursales1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            atencionSeActualizaraElNombreDeEmpresaParaTodasLasSucursales = "Atencion: se actualizara el nombre de empresa" + vbLf + "para las sucursales"
        Else
            atencionSeActualizaraElNombreDeEmpresaParaTodasLasSucursales = "Atention: the Company name can be updated for subsidiaries"
        End If
        Return atencionSeActualizaraElNombreDeEmpresaParaTodasLasSucursales
    End Function

    Shared Function sucursalEditadaCorrectamente(ByVal sucursalEditadaCorrectamente1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            sucursalEditadaCorrectamente = "Sucursal actualizada exitosamente"
        Else
            sucursalEditadaCorrectamente = "Subsidiary succefully updated"
        End If
        Return sucursalEditadaCorrectamente
    End Function

    Shared Function empresaEditadaCorrectamente(ByVal empresaEditadaCorrectamente1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            empresaEditadaCorrectamente = "Empresa actualizada exitosamente"
        Else
            empresaEditadaCorrectamente = "Company succefully updated"
        End If
        Return empresaEditadaCorrectamente
    End Function

    Shared Function varCasaCentral(ByVal varCasaCentral1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            varCasaCentral = "Casa Central"
        Else
            varCasaCentral = "main subsidiary"
        End If
        Return varCasaCentral
    End Function

    Shared Function elNombreDeLaEmpresaNoPuedeEstarEnBlanco(ByVal elNombreDeLaEmpresaNoPuedeEstarEnBlanco1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            elNombreDeLaEmpresaNoPuedeEstarEnBlanco = "el Nombre De La Empresa No Puede Estar En Blanco"
        Else
            elNombreDeLaEmpresaNoPuedeEstarEnBlanco = "The company name canoot be empty"
        End If
        Return elNombreDeLaEmpresaNoPuedeEstarEnBlanco
    End Function

    Shared Function elNombredeLaSucursalNopuedeEstarEnBlanco(ByVal elNombredeLaSucursalNopuedeEstarEnBlanco1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            elNombredeLaSucursalNopuedeEstarEnBlanco = "el Nombre de La Sucursal No puede Estar En Blanco"
        Else
            elNombredeLaSucursalNopuedeEstarEnBlanco = "The subsidiary name canot be empty"
        End If
        Return elNombredeLaSucursalNopuedeEstarEnBlanco
    End Function

    Shared Function laDireccionNoPuedeEstarEnBlanco(ByVal laDireccionNoPuedeEstarEnBlanco1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            laDireccionNoPuedeEstarEnBlanco = "la Direccion No Puede Estar En Blanco"
        Else
            laDireccionNoPuedeEstarEnBlanco = "the adress canot be empty"
        End If
        Return laDireccionNoPuedeEstarEnBlanco
    End Function

    Shared Function IngreseLacantidadDeEmpleados(ByVal IngreseLacantidadDeEmpleados1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            IngreseLacantidadDeEmpleados = "Ingrese La cantidad De Empleados"
        Else
            IngreseLacantidadDeEmpleados = "insert employee number"
        End If
        Return IngreseLacantidadDeEmpleados
    End Function

    Shared Function correcto(ByVal correcto1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            correcto = "correcto"
        Else
            correcto = "sucefull"
        End If
        Return correcto
    End Function

    Shared Function elRutNoPuedeEstarEnblanco(ByVal elRutNoPuedeEstarEnblanco1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            elRutNoPuedeEstarEnblanco = "el Rut No Puede Estar En blanco"
        Else
            elRutNoPuedeEstarEnblanco = "the RUT canot be empty"
        End If
        Return elRutNoPuedeEstarEnblanco
    End Function

    Shared Function debeCompletarLaInformacionParaAgregarLaEmpresa(ByVal p1 As Object) As Object
        If idiomaSeleccionado.Equals("ESP") Then
            debeCompletarLaInformacionParaAgregarLaEmpresa = "debe Completar La Informacion Para Agregar La Empresa"
        Else
            debeCompletarLaInformacionParaAgregarLaEmpresa = "we need to complete information to add company"
        End If
        Return debeCompletarLaInformacionParaAgregarLaEmpresa
    End Function

    Shared Function estaCompletamenteSeguroEstaAccionNOsepuedeDesaser(ByVal estaCompletamenteSeguroEstaAccionNOsepuedeDesaser1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            estaCompletamenteSeguroEstaAccionNOsepuedeDesaser = "si confirma Esta Ventana Dara eL Alt aAl cuestionario Continuar?"
        Else
            estaCompletamenteSeguroEstaAccionNOsepuedeDesaser = "if confirm this windows , yo add a new questionary, are you sure?"
        End If
        Return estaCompletamenteSeguroEstaAccionNOsepuedeDesaser
    End Function

    Shared Function siconfirmaEstaVentanaDaraeLAltaAlcuestionarioContinuar(ByVal siconfirmaEstaVentanaDaraeLAltaAlcuestionarioContinuar1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            siconfirmaEstaVentanaDaraeLAltaAlcuestionarioContinuar = "recuerde haber verificado todas las preguntas antes"
        Else
            siconfirmaEstaVentanaDaraeLAltaAlcuestionarioContinuar = "verify the questions before continue"
        End If
        Return siconfirmaEstaVentanaDaraeLAltaAlcuestionarioContinuar
    End Function

    Shared Function ubicacionSinNombre(ByVal ubicacionSinNombre1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            ubicacionSinNombre = "ubicacion sin nombre"
        Else
            ubicacionSinNombre = "ubication with no name"
        End If
        Return ubicacionSinNombre
    End Function

    Shared Function sinDescripcion(ByVal sinDescripcion1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            sinDescripcion = "ubicacion sin descripcion"
        Else
            sinDescripcion = "the ubication has not desciption"
        End If
        Return sinDescripcion
    End Function

    Shared Function sinAgregarSolucion(ByVal sinAgregarSolucion1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            sinAgregarSolucion = "no se agrego una solucion"
        Else
            sinAgregarSolucion = "no solution added"
        End If
        Return sinAgregarSolucion
    End Function

    Shared Function debeAgregarRiesgosAlMapa(ByVal debeAgregarRiesgosAlMapa1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            debeAgregarRiesgosAlMapa = "debe agregar riesgos para crear un mapa"
        Else
            debeAgregarRiesgosAlMapa = "we need to add risk for make map"
        End If
        Return debeAgregarRiesgosAlMapa
    End Function

    Shared Function accionAgregadaConexito(ByVal accionAgregadaConexito1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            accionAgregadaConexito = "accion agregada con exito"
        Else
            accionAgregadaConexito = "sucefull"
        End If
        Return accionAgregadaConexito
    End Function

    Shared Function laAccionRequiereContenido(ByVal laAccionRequiereContenido1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            laAccionRequiereContenido = "la accion requiere contenido"
        Else
            laAccionRequiereContenido = "the action need content"
        End If
        Return laAccionRequiereContenido
    End Function

    Shared Function PreguntaAgregadaConExito(ByVal PreguntaAgregadaConExito1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            PreguntaAgregadaConExito = "pregunta agregada con exito"
        Else
            PreguntaAgregadaConExito = "sucefull"
        End If
        Return PreguntaAgregadaConExito
    End Function

    Shared Function laPreguntaDebeTenerContenido(ByVal laPreguntaDebeTenerContenido1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            laPreguntaDebeTenerContenido = "la pregunta requiere un contenido"
        Else
            laPreguntaDebeTenerContenido = "the question need content"
        End If
        Return laPreguntaDebeTenerContenido
    End Function

    Shared Function objetoAgregadoConexito(ByVal objetoAgregadoConexito1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            objetoAgregadoConexito = "objeto agregado con exito"
        Else
            objetoAgregadoConexito = "sucefull"
        End If
        Return objetoAgregadoConexito
    End Function

    Shared Function elObjetoDebeTenerContenido(ByVal elObjetoDebeTenerContenido1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            elObjetoDebeTenerContenido = "el objeto requiere un contenido"
        Else
            elObjetoDebeTenerContenido = "the objetc need content"
        End If
        Return elObjetoDebeTenerContenido
    End Function

    Shared Function controlRealizadosatisfactoriamente(ByVal controlRealizadosatisfactoriamente1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            controlRealizadosatisfactoriamente = "inspeccion realizada correctamente" + vbLf + "puede ver el reporte en la seccion de reportes"
        Else
            controlRealizadosatisfactoriamente = "inspectoin sucefull" + vbLf + "report inside reports area"
        End If
        Return controlRealizadosatisfactoriamente
    End Function

    Shared Function algofallo(ByVal algofallo1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            algofallo = "Algo fallo, contate a sistemas"
        Else
            algofallo = "something fails contact IT support"
        End If
        Return algofallo
    End Function

    Shared Function eliminadoExitoso(ByVal eliminadoExitoso1 As String) As String
        If idiomaSeleccionado.Equals("ESP") Then
            eliminadoExitoso = "Eliminacion correcta"
        Else
            eliminadoExitoso = "Sucefull deleting data"
        End If
        Return eliminadoExitoso
    End Function

End Class
