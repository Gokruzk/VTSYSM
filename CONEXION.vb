Imports MySql.Data.MySqlClient

Module CONEXIONES

    Public conexion As New MySqlConnection
    Public comm, comm1, comm2, comm3, comm4, comm5, comm6, comm7, comm8, comm9 As New MySqlCommand
    Public dr, dr1, dr2, dr3, dr4, dr5 As MySqlDataReader
    Public estado, status, query, query1, query2, query3, query4, query5, query6, query7, query8, query9, nom_inst, num_listas, cedulap, nombresp, apellidosp, cedulav, nombresv, apellidosv As String

    Public ruta1 As String = Application.StartupPath & "\listas\a.jpg"
    Public ruta2 As String = Application.StartupPath & "\listas\b.jpg"
    Public ruta3 As String = Application.StartupPath & "\listas\c.jpg"
    Public ruta4 As String = Application.StartupPath & "\sello\sello.jpg"

    Public num_votos As Integer
    Public adap, adap1, adap2 As New MySqlDataAdapter
    Public dt, dt1, dt2 As New DataSet

    'CONEXION
    Public Sub conn()
        Try
            conexion = New MySqlConnection("datasource=localhost;port=3306;user = root; password=''; database=votaciones")
            conexion.Open()
            estado = "CONECTADO"
        Catch ex As Exception
            estado = "NO CONECTADO"
            MsgBox(ex.Message)
        End Try
    End Sub

    'CONSULTAR UN DATO
    Public Sub constatus(ByRef dato_referencia As String, ByRef campo As String, ByRef tabla As String, ByRef iff As String)

        comm.Connection = conexion
        comm.CommandType = CommandType.Text

        'CAMPO, TABLA, CONDICION A CONSULTAR

        query = ("select " & campo & " from " & tabla & " where " & iff & "='" & dato_referencia & "'")
        comm = New MySqlCommand(query, conexion)
        comm.ExecuteNonQuery()

        Try
            dr = comm.ExecuteReader()
            If dr.HasRows() Then
                While dr.Read()

                    status = dr(0).ToString

                End While
            Else
                status = "votado"
            End If

            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'INSERTAR VOTANTE
    Public Sub insert_votante(ByRef cedula As String, ByRef nombres As String, ByRef apellidos As String)

        comm.Connection = conexion
        comm.CommandType = CommandType.Text

        Try
            query = ("insert into votantes(cedula,nombres,apellidos,estado) values('" & cedula & "','" & nombres & "','" & apellidos & "','sin votar')")
            comm = New MySqlCommand(query, conexion)

            If comm.ExecuteNonQuery Then
                MsgBox("VOTANTE REGISTRADO", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("VOTANTE YA REGISTRADO", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)
        End Try

    End Sub

    'VOTO
    Public Sub votar(ByRef lista As String, ByRef campo As String)

        comm.Connection = conexion
        comm.CommandType = CommandType.Text

        Try
            query = ("insert into " & lista & "(" & campo & ") values(" & 0 + 1 & ")")
            comm = New MySqlCommand(query, conexion)

            If comm.ExecuteNonQuery Then
                MsgBox("¡VOTO REALIZADO!", MsgBoxStyle.Information, "VTSYSM")
            End If


        Catch ex As Exception
            MsgBox("DATOS NO INSERTADOS", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)
        End Try

    End Sub

    'RESET VOTOS
    Public Sub reset_votos()
        Try

            If (num_listas = 3) Then
                query1 = ("delete from listaa where id <> 1")
                comm1 = New MySqlCommand(query1, conexion)
                comm1.ExecuteNonQuery()
                query2 = ("delete from listab where id <> 1")
                comm2 = New MySqlCommand(query2, conexion)
                comm2.ExecuteNonQuery()
                query3 = ("delete from listac where id <> 1")
                comm3 = New MySqlCommand(query3, conexion)
                comm3.ExecuteNonQuery()
                query6 = ("truncate blancos")
                comm6 = New MySqlCommand(query6, conexion)
                comm6.ExecuteNonQuery()
                query7 = ("truncate nulos")
                comm7 = New MySqlCommand(query7, conexion)
                comm7.ExecuteNonQuery()
            Else
                If (num_listas = 2) Then
                    query4 = ("delete from listaa where id <> 1")
                    comm4 = New MySqlCommand(query4, conexion)
                    comm4.ExecuteNonQuery()
                    query5 = ("delete from listab where id <> 1")
                    comm5 = New MySqlCommand(query5, conexion)
                    comm5.ExecuteNonQuery()
                    query8 = ("truncate blancos")
                    comm8 = New MySqlCommand(query8, conexion)
                    comm8.ExecuteNonQuery()
                    query9 = ("truncate nulos")
                    comm9 = New MySqlCommand(query9, conexion)
                    comm9.ExecuteNonQuery()
                End If
            End If

            query = ("update votantes set estado = 'sin votar'")
            comm = New MySqlCommand(query, conexion)
            comm.ExecuteNonQuery()

            MsgBox("CONTEO REINICIADO", MsgBoxStyle.Information)
            CONTEO.Show()
            Reset_datos.Close()
            Reset_datos.Show()
        Catch ex As Exception
            MsgBox("CONTEO NO REINICIADO", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)
        End Try
    End Sub

    'UPDATE_ESTADO
    Public Sub up_estado(ByRef cedula As String)
        Try
            query = ("update votantes set ESTADO = 'votado' where cedula ='" & cedula & "'")
            comm = New MySqlCommand(query, conexion)
            comm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'RESET TOTAL
    Public Sub reset_all()

        Try
            comm.Connection = conexion
            comm.CommandType = CommandType.Text
            query = ("truncate votantes")
            comm = New MySqlCommand(query, conexion)
            comm.ExecuteNonQuery()

            comm6.Connection = conexion
            comm6.CommandType = CommandType.Text
            query6 = ("truncate num_listas")
            comm6 = New MySqlCommand(query6, conexion)
            comm6.ExecuteNonQuery()
            comm7.Connection = conexion
            comm7.CommandType = CommandType.Text
            query7 = ("truncate presidentes")
            comm7 = New MySqlCommand(query7, conexion)
            comm7.ExecuteNonQuery()
            comm8.Connection = conexion
            comm8.CommandType = CommandType.Text
            query8 = ("truncate vicepresidentes")
            comm8 = New MySqlCommand(query8, conexion)
            comm8.ExecuteNonQuery()
            comm9.Connection = conexion
            comm9.CommandType = CommandType.Text
            query9 = ("truncate votantes")
            comm9 = New MySqlCommand(query9, conexion)
            comm9.ExecuteNonQuery()

            If (num_listas = 3) Then
                comm1.Connection = conexion
                comm1.CommandType = CommandType.Text
                query1 = ("drop table listaa")
                comm1 = New MySqlCommand(query1, conexion)
                comm1.ExecuteNonQuery()
                comm2.Connection = conexion
                comm2.CommandType = CommandType.Text
                query2 = ("drop table listab")
                comm2 = New MySqlCommand(query2, conexion)
                comm2.ExecuteNonQuery()
                comm3.Connection = conexion
                comm3.CommandType = CommandType.Text
                query3 = ("drop table listac")
                comm3 = New MySqlCommand(query3, conexion)
                comm3.ExecuteNonQuery()
            Else
                If (num_listas = 2) Then
                    comm4.Connection = conexion
                    comm4.CommandType = CommandType.Text
                    query4 = ("drop table listaa")
                    comm4 = New MySqlCommand(query4, conexion)
                    comm4.ExecuteNonQuery()
                    comm5.Connection = conexion
                    comm5.CommandType = CommandType.Text
                    query5 = ("drop table listab")
                    comm5 = New MySqlCommand(query5, conexion)
                    comm5.ExecuteNonQuery()
                End If
            End If

            MsgBox("DATOS RESETEADOS", MsgBoxStyle.Information)
            CONTEO.Show()
            Reset_datos.Close()
            Reset_datos.Show()
        Catch ex As Exception
            MsgBox("DATOS NO RESETEADOS", MsgBoxStyle.Critical)
            MsgBox(ex.Message)
        End Try

    End Sub

    'CONTEO
    Public Sub cont(ByRef campo As String, ByRef lista As String)

        comm.Connection = conexion
        comm.CommandType = CommandType.Text

        query = ("select sum(" & campo & ") as " & campo & " from " & lista & "")
        comm = New MySqlCommand(query, conexion)

        Try
            dr = comm.ExecuteReader()
            If dr.HasRows() Then
                While dr.Read()

                    num_votos = dr(0).ToString

                End While

            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
            num_votos = "0"
        End Try

    End Sub

    'NOMBRE INSTITUCION
    Public Sub nom_institucion(ByRef nombre As String)

        comm.Connection = conexion
        comm.CommandType = CommandType.Text

        Try
            query = ("update institucion set nombre = '" & nombre & "'")
            comm = New MySqlCommand(query, conexion)

            If comm.ExecuteNonQuery Then
                MsgBox("GUARDADO", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'CONSULTAR NOMBRE DE INSTITUCION
    Public Sub coninst()

        comm.Connection = conexion
        comm.CommandType = CommandType.Text

        query = ("select nombre from institucion")
        comm = New MySqlCommand(query, conexion)

        Try
            dr = comm.ExecuteReader()
            If dr.HasRows() Then
                While dr.Read()

                    nom_inst = dr(0).ToString

                End While

            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
            'MsgBox(ex.Message)
        End Try

    End Sub

    'INSERTAR PRESI Y VICE
    Public Sub insert_presi_vice(ByRef nom As String, ByRef ced1 As String, ByRef nom_presi As String, ByRef apel1 As String, ByRef ced2 As String, ByRef nom_vice As String, ByRef apel2 As String, ByRef letra As String)
        Try
            'listas(letra, nom_presi, apel1, ced2, nom_vice, apel2)
            query1 = ("insert into presidentes(cedula,nombres,apellidos) values('" & ced1 & "', '" & nom_presi & "','" & apel1 & "')")
            comm1 = New MySqlCommand(query1, conexion)
            comm1.ExecuteNonQuery()
            query2 = ("insert into vicepresidentes(cedula,nombres,apellidos) values('" & ced2 & "', '" & nom_vice & "','" & apel2 & "')")
            comm2 = New MySqlCommand(query2, conexion)
            comm2.ExecuteNonQuery()
            'listas(letra, nom_presi, apel1, ced2, nom_vice, apel2)
            'MsgBox("LISTA CREADA", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("          POSIBLES ERRORES:" & vbNewLine & "           -PRESIDENTE YA REGISTRADO" & vbNewLine & "      -VICEPRESIDENTE YA REGISTRADO", MsgBoxStyle.Critical, "VTSYSM")
            query3 = ("drop table lista" & nom & "")
            comm3 = New MySqlCommand(query3, conexion)
            comm3.ExecuteNonQuery()
            query4 = ("delete from num_listas where letra='" & letra & "'")
            comm4 = New MySqlCommand(query4, conexion)
            comm4.ExecuteNonQuery()
            'MsgBox(ex.Message)
        End Try
    End Sub

    'AGREGAR LISTA
    Public Sub listas(ByRef nom_presi As String, ByRef nom_vice As String, ByRef letra As String, ByRef ced1 As String, ByRef ced2 As String, ByRef apel1 As String, ByRef apel2 As String)

        Try

            query4 = ("insert into presidentes(cedula,nombres,apellidos,lista) values('" & ced1 & "', '" & nom_presi & "','" & apel1 & "','" & letra & "');
                      insert into vicepresidentes(cedula,nombres,apellidos,lista) values('" & ced2 & "', '" & nom_vice & "','" & apel2 & "','" & letra & "')")
            comm4 = New MySqlCommand(query4, conexion)
            comm4.ExecuteNonQuery()

            query = ("create table lista" & letra & "( 
            id Int auto_increment primary key, 
            num_votos int,
            nom_presi varchar(30),
            nom_vice varchar(30)
            );")

            comm = New MySqlCommand(query, conexion)
            comm.ExecuteNonQuery()

            query1 = ("insert into lista" & letra & "(id,num_votos,nom_presi,nom_vice) values(default,'','" & nom_presi & "','" & nom_vice & "')")
            comm1 = New MySqlCommand(query1, conexion)
            comm1.ExecuteNonQuery()

            query3 = ("insert into num_listas values(default," & 0 + 1 & ",'" & letra & "')")
            comm3 = New MySqlCommand(query3, conexion)
            comm3.ExecuteNonQuery()

            MsgBox("LISTA CREADA", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("          POSIBLES ERRORES:" & vbNewLine & "           -ESTA LISTA YA EXISTE" & vbNewLine & "           -PRESIDENTE YA REGISTRADO" & vbNewLine & "      -VICEPRESIDENTE YA REGISTRADO", MsgBoxStyle.Critical, "VTSYSM")
            'MsgBox(ex.Message)

            query6 = ("delete from presidentes where cedula='" & ced1 & "'")
            comm6 = New MySqlCommand(query6, conexion)
            comm6.ExecuteNonQuery()

            query7 = ("delete from vicepresidentes where cedula='" & ced2 & "'")
            comm7 = New MySqlCommand(query7, conexion)
            comm7.ExecuteNonQuery()

        End Try

    End Sub

    'CONSULTAR NÚMERO DE LISTAS
    Public Sub conlistas()

        comm.Connection = conexion
        comm.CommandType = CommandType.Text

        query = ("select sum(numero) as numero from num_listas")
        comm = New MySqlCommand(query, conexion)

        Try
            dr = comm.ExecuteReader()
            If dr.HasRows() Then
                While dr.Read()
                    If dr(0).ToString = Nothing Then
                        num_listas = 0
                    Else
                        num_listas = dr(0).ToString
                    End If
                End While
            End If

            dr.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    'CONSULTAR DATOS_PRESIDENTE DE LISTA
    Public Sub dat_presi(lista)

        comm.Connection = conexion
        comm.CommandType = CommandType.Text

        'CAMPO, TABLA, CONDICION A CONSULTAR

        query = ("select cedula from presidentes where lista='" & lista & "'")
        comm = New MySqlCommand(query, conexion)
        comm.ExecuteNonQuery()

        query1 = ("select nombres from presidentes where lista='" & lista & "'")
        comm1 = New MySqlCommand(query1, conexion)
        comm1.ExecuteNonQuery()

        query2 = ("select apellidos from presidentes where lista='" & lista & "'")
        comm2 = New MySqlCommand(query2, conexion)
        comm2.ExecuteNonQuery()

        Try
            dr = comm.ExecuteReader()
            If dr.HasRows() Then
                While dr.Read()

                    cedulap = dr(0).ToString

                End While
            Else

            End If

            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            dr1 = comm1.ExecuteReader()
            If dr1.HasRows() Then
                While dr1.Read()

                    nombresp = dr1(0).ToString

                End While
            Else

            End If

            dr1.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            dr2 = comm2.ExecuteReader()
            If dr2.HasRows() Then
                While dr2.Read()

                    apellidosp = dr2(0).ToString

                End While
            Else

            End If

            dr2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'CONSULTAR DATOS_VICEPRESIDENTE DE LISTA
    Public Sub dat_vice(lista)
        query3 = ("select cedula from vicepresidentes where lista='" & lista & "'")
        comm3 = New MySqlCommand(query3, conexion)
        comm3.ExecuteNonQuery()

        query4 = ("select nombres from vicepresidentes where lista='" & lista & "'")
        comm4 = New MySqlCommand(query4, conexion)
        comm4.ExecuteNonQuery()

        query5 = ("select apellidos from vicepresidentes where lista='" & lista & "'")
        comm5 = New MySqlCommand(query5, conexion)
        comm5.ExecuteNonQuery()

        Try
            dr3 = comm3.ExecuteReader()
            If dr3.HasRows() Then
                While dr3.Read()

                    cedulav = dr3(0).ToString

                End While
            Else

            End If
            dr3.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            dr4 = comm4.ExecuteReader()
            If dr4.HasRows() Then
                While dr4.Read()

                    nombresv = dr4(0).ToString

                End While
            Else

            End If
            dr4.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            dr5 = comm5.ExecuteReader()
            If dr5.HasRows() Then
                While dr5.Read()

                    apellidosv = dr5(0).ToString

                End While
            Else

            End If
            dr5.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Module