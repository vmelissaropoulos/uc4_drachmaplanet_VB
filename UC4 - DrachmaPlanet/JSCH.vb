Imports com.uc4.api
Imports com.uc4.api.objects
Imports com.uc4.communication
Imports com.uc4.communication.requests

Module JSCH

    Public Sub addTaskToSchedule(ByVal mySchedule As String, ByVal myObjectList As List(Of String), ByVal con As Connection)

        LOG("Working on schedule: " + mySchedule, True)
        For Each obj In myObjectList
            obj = obj.ToUpper
            Dim mySplit As String() = obj.Split("|")
            Dim myLaunches As String() = mySplit(2).Split(";")
            Dim myObject = mySplit(0)
            Dim myCaleKeyword As String = mySplit(1)

            Dim objName As UC4ObjectName = New UC4ObjectName(mySchedule)
            Dim open As OpenObject = New OpenObject(objName, False, True)


            Try
                con.sendRequestAndWait(open)
            Catch ex As Exception
                LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
                Exit Sub
            End Try

            If Not open.getMessageBox Is Nothing Then
                LOG("ERROR: " + open.getMessageBox().getText() + " %% Object: JSCH.ROMANIA returned a message box: ") ' + open.getMessageBox().getNumber())
                Exit Sub
            Else

                Dim openObject As UC4Object = open.getUC4Object

                If Not openObject.getType.StartsWith("JSCH") Then Exit Sub
                Dim myJSCH As Schedule = openObject


                addTask(myJSCH, myObject, myLaunches, "CALE.LV02.RULES", myCaleKeyword, con)


                Dim close As CloseObject = New CloseObject(openObject)
                Try
                    con.sendRequestAndWait(close)
                Catch ex As Exception
                    LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
                    Exit Sub
                End Try
            End If
        Next
        LOG("Finished")
    End Sub


    Private Function addTask(ByVal myJSCH As Schedule, ByVal myObject As String, ByVal myLaunches As String(), ByVal myCalendar As String, ByVal myCaleKeyword As String, ByVal con As Connection) As Boolean
        Dim flagAlreadyExists As Boolean = False
        For Each launch In myLaunches

            'get existing task and skip if already exist (= same objName, calendar and launch)
            Dim itJSCHTasks As java.util.Iterator = myJSCH.taskIterator
            While itJSCHTasks.hasNext
                Dim itTask As ScheduleTask = itJSCHTasks.next
                With itTask
                    If .getTaskName.ToString = myObject And .getStartTime.toString = launch Then
                        Dim itTaskCalendars As java.util.Iterator = .calendar.iterator
                        While itTaskCalendars.hasNext
                            Dim itTaskCale As CalendarCondition = itTaskCalendars.next
                            If itTaskCale.getName.toString = myCalendar And itTaskCale.getKeywordAsString = myCaleKeyword Then
                                flagAlreadyExists = True
                                LOG("TASK: Already in schedule " + myJSCH.getName.ToString + ": " + myObject + ": [" + myCalendar + " - " + myCaleKeyword + " - " + launch + "]")
                                Return False
                            End If
                        End While

                    End If
                End With
            End While



            If Not flagAlreadyExists Then
                LOG("TASK: Adding to schedule " + myJSCH.getName.ToString + ": " + myObject + ": [" + myCalendar + " - " + myCaleKeyword + " - " + launch + "]")
                Dim add As AddScheduleTask = New AddScheduleTask(New UC4ObjectName(myObject))


                Try
                    con.sendRequestAndWait(add)
                Catch ex As Exception
                    LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
                    Return False
                End Try

                Dim task As ScheduleTask = Nothing
                task = add.getScheduleTask()
                Try
                    con.sendRequestAndWait(add)

                    task.setActive(False)
                    task.setStartTime(New Time(launch))
                    Dim cale As UC4ObjectName = New UC4ObjectName(myCalendar)
                    Dim caleKey As UC4ObjectName = New UC4ObjectName(myCaleKeyword)
                    Dim caleCond As CalendarCondition = New CalendarCondition(cale, caleKey)

                    task.calendar.addCalendarCondition(caleCond)

                    myJSCH.addTask(task)

                Catch ex As Exception
                    LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
                    Return False
                End Try


                Dim save As SaveObject = New SaveObject(myJSCH)
                Try
                    con.sendRequestAndWait(save)
                Catch ex As Exception
                    LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
                    Return False
                End Try
            End If
        Next
        
        Return flagAlreadyExists
    End Function
End Module
