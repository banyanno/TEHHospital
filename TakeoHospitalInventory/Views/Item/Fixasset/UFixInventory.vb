Public Class UFixInventory
    Dim DA_DEP As New DS_FIXASSETTableAdapters.tblDepartmentTableAdapter
    Dim DA_Fixasset As New DS_FIXASSETTableAdapters.FIX_ASSETTableAdapter
    Dim DA_CheckFixAsset As New DS_FIXASSETTableAdapters.FIX_ASSET_CHECKTableAdapter
    Dim DA_VIEW_FIXASSET As New DS_FIXASSETTableAdapters.VIEW_FIXASSETTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboDepartment
            .DataSource = DA_DEP.GetData
            .ValueMember = "DepartID"
            .DisplayMember = "DepartName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub PopulateNodesFloor(ByVal dtbl As DataTable, ByVal nodes As TreeNodeCollection)
        nodes.Clear()
        For Each dr As DataRow In dtbl.Rows
            Dim tn As New TreeNode
            tn.Name = dr("DepartID").ToString
            tn.Text = dr("DepartName").ToString
            'tn.Tag = dr("FLOOR_DESCRIP").ToString
            nodes.Add(tn)
            'tn.ImageIndex = 0
        Next
    End Sub
    Sub RefreshDepart()
        Dim TblDep As DataTable = DA_DEP.GetData
        PopulateNodesFloor(TblDep, TreeDepartment.Nodes)
    End Sub

    Private Sub UFixInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SplitContainer2.Visible = True
        SplitContainer2.Dock = DockStyle.Fill
        CRVFixAsset.Visible = False
        RefreshDepart()
        TreeDepartment.Focus()
        TreeDepartment.Select()
        Try
            LoadFixAsset(TreeDepartment.SelectedNode.Name)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LoadingFixAsset()
        GridFixAsset.DataSource = DA_Fixasset.GetData

    End Sub
    Private Sub LoadFixAsset(ByVal DepID As Integer)
        GridFixAsset.DataSource = DA_Fixasset.SelectFixAssetByDepID(DepID)
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim FixAsset As New FormFixAsset
        If FixAsset.ShowDialog() = DialogResult.OK Then

            Try
                Dim dNode As TreeNode = TreeDepartment.SelectedNode
                GridFixAsset.DataSource = DA_Fixasset.SelectFixAssetByDepID(FixAsset.CboDepartment.SelectedValue)
            Catch ex As Exception

            End Try
            FixAsset.Dispose()
        End If
    End Sub

    
    Private Sub BtnUpdateFixAsset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateFixAsset.Click
        If GridFixAsset.SelectedItems.Count = 0 Then Exit Sub
        Dim FFixAsset As New FormFixAsset
        FFixAsset.LblSaveOption.Text = GridFixAsset.GetRow.Cells("FIX_ASS_ID").Value
        FFixAsset.DateBuy.Checked = True
        FFixAsset.DateBuy.Value = GridFixAsset.GetRow.Cells("DATE_BUY").Value
        FFixAsset.CboDepartment.SelectedValue = GridFixAsset.GetRow.Cells("DEP_ID").Value
        FFixAsset.TxtProductName.Text = GridFixAsset.GetRow.Cells("PRODUCT_NAME").Value
        FFixAsset.TxtProductCOde.Text = GridFixAsset.GetRow.Cells("PRODUCT_CODE").Value
        FFixAsset.TxtProductPrice.Text = GridFixAsset.GetRow.Cells("PRODUCT_PRICE").Value
        FFixAsset.TxtBuyer.Text = GridFixAsset.GetRow.Cells("BUYER").Value
        FFixAsset.TxtNote.Text = GridFixAsset.GetRow.Cells("DESCRIPTION").Value
        If FFixAsset.ShowDialog = DialogResult.OK Then
            GridFixAsset.DataSource = DA_Fixasset.SelectByFixAssetID(FFixAsset.LblSaveOption.Text)
        End If
        FFixAsset.Dispose()
    End Sub

    Private Sub TreeDepartment_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeDepartment.AfterSelect
        Try
            SplitContainer2.Visible = True
            SplitContainer2.Dock = DockStyle.Fill
            CRVFixAsset.Visible = False

            GridAssetCheck.DataSource = Nothing
            LoadFixAsset(TreeDepartment.SelectedNode.Name)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ViewAsset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAsset.Click
        SplitContainer2.Visible = True
        SplitContainer2.Dock = DockStyle.Fill
        CRVFixAsset.Visible = False
        GridFixAsset.DataSource = DA_Fixasset.GetData
    End Sub

    Private Sub BtnNewCheckAsset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewCheckAsset.Click
        If GridFixAsset.SelectedItems.Count = 0 Then Exit Sub
        Dim FCheckAsset As New FormCheckItemFixAsset
        FCheckAsset.LblFixAssetID.Text = GridFixAsset.GetRow.Cells("FIX_ASS_ID").Value
        FCheckAsset.TxtProductName.Text = GridFixAsset.GetRow.Cells("PRODUCT_NAME").Value
        FCheckAsset.TxtProductCode.Text = GridFixAsset.GetRow.Cells("PRODUCT_CODE").Value
        If FCheckAsset.ShowDialog = DialogResult.OK Then
            GridAssetCheck.DataSource = DA_CheckFixAsset.SelectCheckByAssetID(GridFixAsset.GetRow.Cells("FIX_ASS_ID").Value)
        End If
    End Sub

    Private Sub GridFixAsset_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridFixAsset.SelectionChanged
        Try
            GridAssetCheck.DataSource = DA_CheckFixAsset.SelectCheckByAssetID(GridFixAsset.GetRow.Cells("FIX_ASS_ID").Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridFixAsset_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridFixAsset.RowDoubleClick
        If GridFixAsset.SelectedItems.Count = 0 Then Exit Sub
        Dim FFixAsset As New FormFixAsset
        FFixAsset.LblSaveOption.Text = GridFixAsset.GetRow.Cells("FIX_ASS_ID").Value
        FFixAsset.DateBuy.Checked = True
        FFixAsset.DateBuy.Value = GridFixAsset.GetRow.Cells("DATE_BUY").Value
        FFixAsset.CboDepartment.SelectedValue = GridFixAsset.GetRow.Cells("DEP_ID").Value
        FFixAsset.TxtProductName.Text = GridFixAsset.GetRow.Cells("PRODUCT_NAME").Value
        FFixAsset.TxtProductCOde.Text = GridFixAsset.GetRow.Cells("PRODUCT_CODE").Value
        FFixAsset.TxtProductPrice.Text = GridFixAsset.GetRow.Cells("PRODUCT_PRICE").Value
        FFixAsset.TxtBuyer.Text = GridFixAsset.GetRow.Cells("BUYER").Value
        FFixAsset.TxtNote.Text = GridFixAsset.GetRow.Cells("DESCRIPTION").Value
        If FFixAsset.ShowDialog = DialogResult.OK Then
            GridFixAsset.DataSource = DA_Fixasset.SelectByFixAssetID(GridFixAsset.GetRow.Cells("FIX_ASS_ID").Value)
        End If
        FFixAsset.Dispose()
    End Sub

    Private Sub GridAssetCheck_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridAssetCheck.RowDoubleClick
        If GridAssetCheck.SelectedItems.Count = 0 Then Exit Sub
        Dim FCheckAsset As New FormCheckItemFixAsset
        FCheckAsset.LblSaveOption.Text = GridAssetCheck.GetRow.Cells("ASS_CHECK_ID").Value
        FCheckAsset.TxtProductName.Text = GridFixAsset.GetRow.Cells("PRODUCT_NAME").Value
        FCheckAsset.TxtProductCode.Text = GridFixAsset.GetRow.Cells("PRODUCT_CODE").Value
        FCheckAsset.DateCheck.Checked = True
        FCheckAsset.DateCheck.Value = GridAssetCheck.GetRow.Cells("DATE_CHECK").Value
        FCheckAsset.TxtNote.Text = GridAssetCheck.GetRow.Cells("CHECK_DESCRIPTION").Value

        If FCheckAsset.ShowDialog = DialogResult.OK Then
            GridFixAsset.DataSource = DA_Fixasset.SelectByFixAssetID(GridFixAsset.GetRow.Cells("FIX_ASS_ID").Value)
        End If
    End Sub

    Private Sub ChDepartment_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChDepartment.CheckedChanged
        CboDepartment.Enabled = ChDepartment.Checked
        CboDepartment.SelectedIndex = -1
    End Sub

    
    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        SplitContainer2.Visible = False
        CRVFixAsset.Visible = True
        CRVFixAsset.Dock = DockStyle.Fill

        Dim TblViewAsset As DataTable
        If ChDepartment.Checked = True Then
            TblViewAsset = DA_VIEW_FIXASSET.SelectCheckWithDP(CboDepartment.SelectedValue.ToString, DateFrom.Value.Date, DateTo.Value.Date)
        Else
            TblViewAsset = DA_VIEW_FIXASSET.SelectCheckDate(DateFrom.Value.Date, DateTo.Value.Date)
        End If
        Dim CFixAsset As New CryFixAsset
        CFixAsset.SetDataSource(TblViewAsset)
        CFixAsset.SetParameterValue("Title", "Up date From: " & DateFrom.Text & " To: " & DateTo.Text)
        CRVFixAsset.ReportSource = CFixAsset
    End Sub

    Private Sub BtnDeleteAsset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteAsset.Click
        If GridFixAsset.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_Fixasset.DeleteFixAsset(1, GridFixAsset.GetRow.Cells("FIX_ASS_ID").Value) = 1 Then
                GridFixAsset.DataSource = DA_Fixasset.SelectByFixAssetID(GridFixAsset.GetRow.Cells("FIX_ASS_ID").Value)
            End If
        End If
    End Sub
End Class
