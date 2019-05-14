Public Class TicketSales
    Dim AmtDue As Integer
    Dim Qty As Decimal
    Dim totals As Decimal
    Dim price AS Decimal
    
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
     idx=ListBox1_SelectedIndexChanged

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
     Dim priceArray = New Integer() {25, 30, 35, 40} 
     For idx=0 to 5
    totals(idx)
     ListBox1_SelectedIndexChanged(idx)

     AmtDue=Qty*price(idx)

     totals(idx)+=Qty
     
    Dim n as integer = 3
    Dim ticketarray(n) as string
    Do Until ticketarray (n)=45
        ticketarray(0) = "watermelon"
        ticketarray(1) = "watermelon"
        ticketarray(2) = "watermelon"
        ticketarray(3) = "watermelon"
        ListBox1_SelectedIndexChanged.Items.Add(CStr(n))
    Loop
    int n = 10;
    string[] ticketarray = new string[n]

    Dim message, title As String 
    message = "Enter your value" 
    title = "Ticket Sales"


    for(int i=0;i<45;i++)
    {
        ticketarray[i]=InputBox(message, title, defaultValue)        
     }


   for(int i=0;i<45;i++)
   {
      ListBox1_SelectedIndexChanged.Items.Add(ticketarray[i]);
   }

MessageBox.Show(message)
   
   End If
End Sub 


End Class

