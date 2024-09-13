' STRING MANIPULATION AND ARRAYS PROGRAMMING ASSIGNMENT
' To utilize string maniplulation and arrays
' Josiah Barringer
' I will not use code that was never covered in class Or in our textbook. If you do you must be
' able to explain your code when asked by the professor. Using code outside of the
' resources provided, it can be flagged And reported As an academic integrity violation
' if there Is any suspicion Of copying/cheating


Public Class Form1

    ' Declare static array to store hours for each mission
    Dim missionHours(3) As Integer
    ' Declare string array for mission names
    Dim missionNames() As String = {"Children's Ministry", "Usher Ministry", "Worship Team Ministry", "Community Outreach Ministry"}

    ' Form load event to initialize form data
    Private Sub FrmMissionHours_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Clear the listbox for donations
        lstTotals.Items.Clear()
        ' Load mission names into the mission listbox
        lstMissions.Items.AddRange(missionNames)
        ' Display the current date
        lstTotals.Items.Add("Date: " & DateTime.Now.ToString("MM/dd/yyyy"))
        ' Display user name
        lstTotals.Items.Add("Josiah Barringer")
    End Sub

    ' Add Hours Button Click event
    Private Sub BtnAddHours_Click(sender As Object, e As EventArgs) Handles btnAddHours.Click

        ' Validate user input for hours and mission selection
        If txtHoursInput.Text = String.Empty Then
            MessageBox.Show("Please enter the number of hours.", "Input Error")
            txtHoursInput.Focus()
            Exit Sub
        ElseIf Not IsNumeric(txtHoursInput.Text) OrElse CInt(txtHoursInput.Text) <= 0 Then
            MessageBox.Show("Please enter a valid positive number of hours.", "Input Error")
            txtHoursInput.Focus()
            Exit Sub
        End If

        If lstMissions.SelectedIndex = -1 Then
            MessageBox.Show("Please select a mission.", "Input Error")
            lstMissions.Focus()
            Exit Sub
        End If

        ' Get the number of hours and the selected mission index
        Dim hours As Integer = CInt(txtHoursInput.Text)
        Dim missionIndex As Integer = lstMissions.SelectedIndex

        ' Add hours to the appropriate mission in the array
        missionHours(missionIndex) += hours

        ' Get the user's name using an input box
        Dim fullName As String = InputBox("Enter you full name:", "Enter Name")
        If fullName = String.Empty Then
            MessageBox.Show("Name entry is required.", "Input Error")
            Exit Sub
        End If

        ' Extract the last name from the full name
        Dim lastName As String = GetLastName(fullName)

        ' Display the name and hours served in the listbox
        lstTotals.Items.Add("_________________")
        lstTotals.Items.Add(lastName & " served " & hours & " hours in the " & missionNames(missionIndex) & ".")

        ' Update the running totals for each mission in the corresponding labels
        txtChildrensMinistry.Text = missionHours(0).ToString()
        txtUsher.Text = missionHours(1).ToString()
        txtWorshipTeam.Text = missionHours(2).ToString()
        txtCommunityOutreach.Text = missionHours(3).ToString()

        ' Clear the hours textbox and reset the mission listbox selection
        txtHoursInput.Clear()
        lstMissions.ClearSelected()

    End Sub

    ' Function to return just the last name from a full name
    Private Function GetLastName(fullName As String) As String
        ' Split the full name by space and return the last part
        Dim nameParts() As String = fullName.Split(" "c)
        Return nameParts(nameParts.Length - 1)
    End Function

    ' Close Button Click event to close the application
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class


