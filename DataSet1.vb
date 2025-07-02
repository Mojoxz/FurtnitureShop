Partial Class DataSet1
    Partial Public Class laporan_penjualanDataTable
        Private Sub laporan_penjualanDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.id_jualColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
