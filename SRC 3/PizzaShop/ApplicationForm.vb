' *
'   Brice Allard
'   Catterina's Pizza
'   November 3, 2018
'  
'   Description: 
'       Winforms application that allows the user to choose from preselected menu
'       items or create their own custom pizza with toppings of their choice.
'       Images overlayed to display the look of the pizza has been implemented.
' 


Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace PizzaShop
    Public Partial Class ApplicationForm
        Inherits Form
        Public Shared Images As List(Of Image) = New List(Of Image)()
        Public Shared Custom As CustomPizza = New CustomPizza()
        Public Shared Cstm_Price As Double = 0.00
        Public Shared Subtotal As Double = 0.00
        Public Shared Tax As Double = 0.00
        Public Shared Total As Double = 0.00
        Public Shared TaxRate As Double = 0.08
        Public Const WM_NCLBUTTONDOWN As Integer = &HA1
        Public Const HT_CAPTION As Integer = &H2

        ' Custom font library being loaded
        <DllImport("gdi32.dll")>
        Private Shared Function AddFontMemResourceEx(ByVal pbfont As IntPtr, ByVal cbfont As UInteger, ByVal pdv As IntPtr,
                                                <[In]> ByRef pcFonts As UInteger) As IntPtr
        End Function
        <DllImportAttribute("user32.dll")>
        Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
        End Function
        <DllImportAttribute("user32.dll")>
        Public Shared Function ReleaseCapture() As Boolean
        End Function

        Private ff As FontFamily
        Private font As Font

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub ApplicationForm_Load(ByVal sender As Object, ByVal e As EventArgs)
            loadFont()

            ' Initialize the custom pizza image
            Images.Add(Utilities.CRUST_PAN)
            Images.Add(Utilities.TOP_MOZZ)
            CustomImage()
        End Sub

        ' Draw new image from List of images replicating a overlay look
        Private Sub CustomImage()
            Dim width = 341
            Dim height = 316
            Dim image As Image = New Bitmap(width, height)

            Using graphics = Drawing.Graphics.FromImage(image)
                For Each i In Images
                    graphics.DrawImage(i, New Rectangle(0, 0, width, height))
                Next
            End Using

            PB_Cstm_PizzaImg.SizeMode = PictureBoxSizeMode.StretchImage
            PB_Cstm_PizzaImg.Image = image
        End Sub

        ' *
        '  
        '  
        '  FONT CUSTOMIZATION
        '  
        ' 

        Private Sub loadFont()
            Dim fontArray = Properties.Resources.Italiano
            Dim dataLength = Properties.Resources.Italiano.Length

            Dim ptrData = Marshal.AllocCoTaskMem(dataLength)

            Marshal.Copy(fontArray, 0, ptrData, dataLength)

            Dim cFonts As UInteger = 0

            AddFontMemResourceEx(ptrData, fontArray.Length, IntPtr.Zero, cFonts)

            Dim pfc As PrivateFontCollection = New PrivateFontCollection()
            pfc.AddMemoryFont(ptrData, dataLength)

            Marshal.FreeCoTaskMem(ptrData)

            ff = pfc.Families(0)
            font = New Font(ff, 15F, FontStyle.Regular)
        End Sub

        Private Sub AllocFont(ByVal f As Font, ByVal c As Control, ByVal size As Single)
            Dim fontStyle As FontStyle = FontStyle.Regular
            c.Font = New Font(ff, size, fontStyle)
        End Sub

        ' ************************************************************************
        '  
        '  
        '  MOUSE CLICK EVENTS, HOVER EFFECTS, AND WINDOW MANIBPULATION BELLOW
        '  
        '  
        ' ***********************************************************************

        ' *
        '  
        '  
        '  TITLE BAR CUSTOMIZATION
        '  
        ' 

        Private Sub Title_MouseDownEvent(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                Call ReleaseCapture()
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
            End If
        End Sub

        Private Sub PB_Exit_MouseEnterEvent(ByVal sender As Object, ByVal e As EventArgs)
            PB_Exit.Image = Properties.Resources.close_white_thick_16x16
        End Sub

        Private Sub PB_Exit_MouseLeaveEvent(ByVal sender As Object, ByVal e As EventArgs)
            PB_Exit.Image = Properties.Resources.close_white_thin_16x16
        End Sub

        Private Sub PB_Maximize_MouseEnterEvent(ByVal sender As Object, ByVal e As EventArgs)
            PB_Maximize.Image = Properties.Resources.maximize_inactive_white_16x16
        End Sub

        Private Sub PB_Maximize_MouseLeaveEvent(ByVal sender As Object, ByVal e As EventArgs)
            PB_Maximize.Image = Properties.Resources.maximize_active_white_16x16
        End Sub

        Private Sub PB_Maximize_ClickEvent(ByVal sender As Object, ByVal e As EventArgs)
            If WindowState = FormWindowState.Maximized Then
                WindowState = FormWindowState.Normal
            Else
                WindowState = FormWindowState.Maximized
            End If
        End Sub

        Private Sub PB_Minimize_ClickEvent(ByVal sender As Object, ByVal e As EventArgs)
            WindowState = FormWindowState.Minimized
        End Sub

        Private Sub PB_Exit_ClickEvent(ByVal sender As Object, ByVal e As EventArgs)
            Call Application.Exit()
        End Sub

        ' *
        '  
        '  
        '  NAVIGATION MENU CUSTOMIZATION
        '  
        ' 

        Private Sub PB_Minimize_MouseEnterEvent(ByVal sender As Object, ByVal e As EventArgs)
            PB_Minimize.Image = Properties.Resources.minimize_thick_white_16x16
        End Sub

        Private Sub PB_Minimize_MouseLeaveEvent(ByVal sender As Object, ByVal e As EventArgs)
            PB_Minimize.Image = Properties.Resources.minimize_thin_white_16x16
        End Sub

        Private Sub BTN_Nav_Menu_MouseEnterEvent(ByVal sender As Object, ByVal e As EventArgs)
            Lightup_Panel_Menu.BackColor = Utilities.ACCENT_COLOR
        End Sub

        Private Sub BTN_Nav_Menu_MouseLeaveEvent(ByVal sender As Object, ByVal e As EventArgs)
            If TC_Navigation.SelectedIndex = 0 Then
                Lightup_Panel_Menu.BackColor = Utilities.ACCENT_COLOR
            Else
                Lightup_Panel_Menu.BackColor = Utilities.SECONDARY_COLOR
            End If
        End Sub

        Private Sub BTN_Nav_Specialties_MouseEnterEvent(ByVal sender As Object, ByVal e As EventArgs)
            Lightup_Panel_Specialties.BackColor = Utilities.ACCENT_COLOR
        End Sub

        Private Sub BTN_Nav_Specialties_MouseLeaveEvent(ByVal sender As Object, ByVal e As EventArgs)
            If TC_Navigation.SelectedIndex = 1 Then
                Lightup_Panel_Specialties.BackColor = Utilities.ACCENT_COLOR
            Else
                Lightup_Panel_Specialties.BackColor = Utilities.SECONDARY_COLOR
            End If
        End Sub

        Private Sub BTN_Nav_Custom_MouseEnterEvent(ByVal sender As Object, ByVal e As EventArgs)
            Lightup_Panel_Custom.BackColor = Utilities.ACCENT_COLOR
        End Sub

        Private Sub BTN_Nav_Custom_MouseLeaveEvent(ByVal sender As Object, ByVal e As EventArgs)
            If TC_Navigation.SelectedIndex = 2 Then
                Lightup_Panel_Custom.BackColor = Utilities.ACCENT_COLOR
            Else
                Lightup_Panel_Custom.BackColor = Utilities.SECONDARY_COLOR
            End If
        End Sub

        Private Sub BTN_Nav_Order_MouseEnterEvent(ByVal sender As Object, ByVal e As EventArgs)
            Lightup_Panel_Order.BackColor = Utilities.ACCENT_COLOR
        End Sub

        Private Sub BTN_Nav_Order_MouseLeaveEvent(ByVal sender As Object, ByVal e As EventArgs)
            If TC_Navigation.SelectedIndex = 3 Then
                Lightup_Panel_Order.BackColor = Utilities.ACCENT_COLOR
            Else
                Lightup_Panel_Order.BackColor = Utilities.SECONDARY_COLOR
            End If
        End Sub

        Private Sub BTN_Nav_Menu_Click(ByVal sender As Object, ByVal e As EventArgs)
            TC_Navigation.SelectedIndex = 0
            Lightup_Panel_Menu.BackColor = Utilities.ACCENT_COLOR
            Lightup_Panel_Specialties.BackColor = Utilities.SECONDARY_COLOR
            Lightup_Panel_Custom.BackColor = Utilities.SECONDARY_COLOR
            Lightup_Panel_Order.BackColor = Utilities.SECONDARY_COLOR
        End Sub

        Private Sub BTN_Nav_Specialties_Click(ByVal sender As Object, ByVal e As EventArgs)
            TC_Navigation.SelectedIndex = 1
            Lightup_Panel_Menu.BackColor = Utilities.SECONDARY_COLOR
            Lightup_Panel_Specialties.BackColor = Utilities.ACCENT_COLOR
            Lightup_Panel_Custom.BackColor = Utilities.SECONDARY_COLOR
            Lightup_Panel_Order.BackColor = Utilities.SECONDARY_COLOR
        End Sub

        Private Sub BTN_Nav_Custom_Click(ByVal sender As Object, ByVal e As EventArgs)
            TC_Navigation.SelectedIndex = 2
            Lightup_Panel_Menu.BackColor = Utilities.SECONDARY_COLOR
            Lightup_Panel_Specialties.BackColor = Utilities.SECONDARY_COLOR
            Lightup_Panel_Custom.BackColor = Utilities.ACCENT_COLOR
            Lightup_Panel_Order.BackColor = Utilities.SECONDARY_COLOR
        End Sub

        Private Sub BTN_Nav_Order_Click(ByVal sender As Object, ByVal e As EventArgs)
            TC_Navigation.SelectedIndex = 3
            Lightup_Panel_Menu.BackColor = Utilities.SECONDARY_COLOR
            Lightup_Panel_Specialties.BackColor = Utilities.SECONDARY_COLOR
            Lightup_Panel_Custom.BackColor = Utilities.SECONDARY_COLOR
            Lightup_Panel_Order.BackColor = Utilities.ACCENT_COLOR
        End Sub

        ' *
        '  
        '  
        '  MENU TAB CUSTOMIZATION
        '  
        ' 

        Private Sub BTN_Order_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
            Dim btn = CType(sender, Button)
            btn.FlatAppearance.BorderColor = Utilities.ACCENT_COLOR
            btn.ForeColor = Utilities.ACCENT_COLOR
        End Sub

        Private Sub BTN_Order_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
            Dim btn = CType(sender, Button)
            btn.FlatAppearance.BorderColor = Color.Black
            btn.ForeColor = Color.Black
        End Sub

        Private Sub PNL_UpdatePrice(ByVal sender As Object, ByVal e As EventArgs)
            Dim name = CType(sender, ComboBox).Name

            If name.StartsWith("CB_Cheese_") Then
                Dim price = Utilities.getPrice(CB_Cheese_Size) + Utilities.getPrice(CB_Cheese_Crust) + Utilities.getPrice(CB_Cheese_Toppings)

                LBL_Cheese_Price.Text = $"${price.ToString()}"
            ElseIf name.StartsWith("CB_Pepperoni_") Then
                Dim price = Utilities.getPrice(CB_Pepperoni_Size) + Utilities.getPrice(CB_Pepperoni_Crust) + Utilities.getPrice(CB_Pepperoni_Toppings)

                LBL_Pepperoni_Price.Text = $"${price.ToString()}"
            ElseIf name.StartsWith("CB_BBQ_") Then
                Dim price = Utilities.getPrice(CB_BBQ_Size) + Utilities.getPrice(CB_BBQ_Crust) + Utilities.getPrice(CB_BBQ_Toppings)

                LBL_BBQ_Price.Text = $"${price.ToString()}"
            ElseIf name.StartsWith("CB_Supreme_") Then
                Dim price = Utilities.getPrice(CB_Supreme_Size) + Utilities.getPrice(CB_Supreme_Crust) + Utilities.getPrice(CB_Supreme_Toppings)

                LBL_Supreme_Price.Text = $"${price.ToString()}"
            ElseIf name.StartsWith("CB_Taco_") Then
                Dim price = Utilities.getPrice(CB_Taco_Size) + Utilities.getPrice(CB_Taco_Crust) + Utilities.getPrice(CB_Taco_Toppings)

                LBL_Taco_Price.Text = $"${price.ToString()}"
            ElseIf name.StartsWith("CB_Breakfast_") Then
                Dim price = Utilities.getPrice(CB_Breakfast_Size) + Utilities.getPrice(CB_Breakfast_Crust) + Utilities.getPrice(CB_Breakfast_Toppings)

                LBL_Breakfast_Price.Text = $"${price.ToString()}"
            ElseIf name.StartsWith("CB_Spinach_") Then
                Dim price = Utilities.getPrice(CB_Spinach_Size) + Utilities.getPrice(CB_Spinach_Crust) + Utilities.getPrice(CB_Spinach_Toppings)

                LBL_Spinach_Price.Text = $"${price.ToString()}"
            ElseIf name.StartsWith("CB_Potato_") Then
                Dim price = Utilities.getPrice(CB_Potato_Size) + Utilities.getPrice(CB_Potato_Crust) + Utilities.getPrice(CB_Potato_Toppings)

                LBL_Potato_Price.Text = $"${price.ToString()}"
            End If
        End Sub

        ' *
        '   
        '   Order Button Methods AND Checkout Configurations below
        '  
        ' 

        Private Sub BTN_Cheese_Order_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Equals(CB_Cheese_Size.Text, "- Size -") OrElse Equals(CB_Cheese_Crust.Text, "- Crust -") OrElse Equals(CB_Cheese_Toppings.Text, "- Toppings -") Then

                MessageBox.Show("Please Select From All Options")
                Return
            End If
            Dim item As ListViewItem = New ListViewItem("100")
            item.SubItems.Add("Cheese")
            item.SubItems.Add(Utilities.getName(CB_Cheese_Size))
            item.SubItems.Add(Utilities.getName(CB_Cheese_Crust))
            item.SubItems.Add(Utilities.getName(CB_Cheese_Toppings))
            item.SubItems.Add(LBL_Cheese_Price.Text)
            LV_Cart.Items.Add(item)

            Dim temp As Double = Nothing
            Double.TryParse(Utilities.getLabelPrice(LBL_Cheese_Price), temp)
            Subtotal += temp
            LBL_Order_Subtotal.Text = $"${Subtotal}"
            PB_Order_Notify.Visible = True
            MessageBox.Show("Cheese Pizza added to Order!" & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Go to 'Your Order' to Checkout ...")
        End Sub

        Private Sub BTN_Pepperoni_Order_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Equals(CB_Pepperoni_Size.Text, "- Size -") OrElse Equals(CB_Pepperoni_Crust.Text, "- Crust -") OrElse Equals(CB_Pepperoni_Toppings.Text, "- Toppings -") Then

                MessageBox.Show("Please Select From All Options")
                Return
            End If
            Dim item As ListViewItem = New ListViewItem("200")
            item.SubItems.Add("Pepperoni")
            item.SubItems.Add(Utilities.getName(CB_Pepperoni_Size))
            item.SubItems.Add(Utilities.getName(CB_Pepperoni_Crust))
            item.SubItems.Add(Utilities.getName(CB_Pepperoni_Toppings))
            item.SubItems.Add(LBL_Pepperoni_Price.Text)
            LV_Cart.Items.Add(item)

            Dim temp As Double = Nothing
            Double.TryParse(Utilities.getLabelPrice(LBL_Pepperoni_Price), temp)
            Subtotal += temp
            LBL_Order_Subtotal.Text = $"${Subtotal}"
            PB_Order_Notify.Visible = True
            MessageBox.Show("Pepperoni Pizza added to Order!" & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Go to 'Your Order' to Checkout ...")
        End Sub

        Private Sub BTN_BBQ_Order_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Equals(CB_BBQ_Size.Text, "- Size -") OrElse Equals(CB_BBQ_Crust.Text, "- Crust -") OrElse Equals(CB_BBQ_Toppings.Text, "- Toppings -") Then

                MessageBox.Show("Please Select From All Options")
                Return
            End If
            Dim item As ListViewItem = New ListViewItem("300")
            item.SubItems.Add("BBQ")
            item.SubItems.Add(Utilities.getName(CB_BBQ_Size))
            item.SubItems.Add(Utilities.getName(CB_BBQ_Crust))
            item.SubItems.Add(Utilities.getName(CB_BBQ_Toppings))
            item.SubItems.Add(LBL_BBQ_Price.Text)
            LV_Cart.Items.Add(item)

            Dim temp As Double = Nothing
            Double.TryParse(Utilities.getLabelPrice(LBL_BBQ_Price), temp)
            Subtotal += temp
            LBL_Order_Subtotal.Text = $"${Subtotal}"
            PB_Order_Notify.Visible = True
            MessageBox.Show("BBQ Pizza added to Order!" & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Go to 'Your Order' to Checkout ...")
        End Sub

        Private Sub BTN_Supreme_Order_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Equals(CB_Supreme_Size.Text, "- Size -") OrElse Equals(CB_Supreme_Crust.Text, "- Crust -") OrElse Equals(CB_Supreme_Toppings.Text, "- Toppings -") Then

                MessageBox.Show("Please Select From All Options")
                Return
            End If
            Dim item As ListViewItem = New ListViewItem("400")
            item.SubItems.Add("Supreme")
            item.SubItems.Add(Utilities.getName(CB_Supreme_Size))
            item.SubItems.Add(Utilities.getName(CB_Supreme_Crust))
            item.SubItems.Add(Utilities.getName(CB_Supreme_Toppings))
            item.SubItems.Add(LBL_Supreme_Price.Text)
            LV_Cart.Items.Add(item)

            Dim temp As Double = Nothing
            Double.TryParse(Utilities.getLabelPrice(LBL_Supreme_Price), temp)
            Subtotal += temp
            LBL_Order_Subtotal.Text = $"${Subtotal}"
            PB_Order_Notify.Visible = True
            MessageBox.Show("Supreme Pizza added to Order!" & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Go to 'Your Order' to Checkout ...")
        End Sub

        Private Sub BTN_Taco_Order_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Equals(CB_Taco_Size.Text, "- Size -") OrElse Equals(CB_Taco_Crust.Text, "- Crust -") OrElse Equals(CB_Taco_Toppings.Text, "- Toppings -") Then

                MessageBox.Show("Please Select From All Options")
                Return
            End If
            Dim item As ListViewItem = New ListViewItem("500")
            item.SubItems.Add("Taco")
            item.SubItems.Add(Utilities.getName(CB_Taco_Size))
            item.SubItems.Add(Utilities.getName(CB_Taco_Crust))
            item.SubItems.Add(Utilities.getName(CB_Taco_Toppings))
            item.SubItems.Add(LBL_Taco_Price.Text)
            LV_Cart.Items.Add(item)

            Dim temp As Double = Nothing
            Double.TryParse(Utilities.getLabelPrice(LBL_Taco_Price), temp)
            Subtotal += temp
            LBL_Order_Subtotal.Text = $"${Subtotal}"
            PB_Order_Notify.Visible = True
            PB_Order_Notify.Visible = True
            MessageBox.Show("Taco-Quesadilla Pizza added to Order!" & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Go to 'Your Order' to Checkout ...")
        End Sub

        Private Sub BTN_Breakfast_Order_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Equals(CB_Breakfast_Size.Text, "- Size -") OrElse Equals(CB_Breakfast_Crust.Text, "- Crust -") OrElse Equals(CB_Breakfast_Toppings.Text, "- Toppings -") Then

                MessageBox.Show("Please Select From All Options")
                Return
            End If
            Dim item As ListViewItem = New ListViewItem("600")
            item.SubItems.Add("Breakfast")
            item.SubItems.Add(Utilities.getName(CB_Breakfast_Size))
            item.SubItems.Add(Utilities.getName(CB_Breakfast_Crust))
            item.SubItems.Add(Utilities.getName(CB_Breakfast_Toppings))
            item.SubItems.Add(LBL_Breakfast_Price.Text)
            LV_Cart.Items.Add(item)

            Dim temp As Double = Nothing
            Double.TryParse(Utilities.getLabelPrice(LBL_Breakfast_Price), temp)
            Subtotal += temp
            LBL_Order_Subtotal.Text = $"${Subtotal}"
            PB_Order_Notify.Visible = True
            MessageBox.Show("Breakfast Pizza added to Order!" & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Go to 'Your Order' to Checkout ...")
        End Sub

        Private Sub BTN_Spinach_Order_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Equals(CB_Spinach_Size.Text, "- Size -") OrElse Equals(CB_Spinach_Crust.Text, "- Crust -") OrElse Equals(CB_Spinach_Toppings.Text, "- Toppings -") Then

                MessageBox.Show("Please Select From All Options")
                Return
            End If
            Dim item As ListViewItem = New ListViewItem("700")
            item.SubItems.Add("Spinach")
            item.SubItems.Add(Utilities.getName(CB_Spinach_Size))
            item.SubItems.Add(Utilities.getName(CB_Spinach_Crust))
            item.SubItems.Add(Utilities.getName(CB_Spinach_Toppings))
            item.SubItems.Add(LBL_Spinach_Price.Text)
            LV_Cart.Items.Add(item)

            Dim temp As Double = Nothing
            Double.TryParse(Utilities.getLabelPrice(LBL_Spinach_Price), temp)
            Subtotal += temp
            LBL_Order_Subtotal.Text = $"${Subtotal}"
            PB_Order_Notify.Visible = True
            MessageBox.Show("Spinach-Artichoke Pizza added to Order!" & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Go to 'Your Order' to Checkout ...")
        End Sub

        Private Sub BTN_Potato_Order_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Equals(CB_Potato_Size.Text, "- Size -") OrElse Equals(CB_Potato_Crust.Text, "- Crust -") OrElse Equals(CB_Potato_Toppings.Text, "- Toppings -") Then

                MessageBox.Show("Please Select From All Options")
                Return
            End If
            Dim item As ListViewItem = New ListViewItem("800")
            item.SubItems.Add("Potato")
            item.SubItems.Add(Utilities.getName(CB_Potato_Size))
            item.SubItems.Add(Utilities.getName(CB_Potato_Crust))
            item.SubItems.Add(Utilities.getName(CB_Potato_Toppings))
            item.SubItems.Add(LBL_Potato_Price.Text)
            LV_Cart.Items.Add(item)

            Dim temp As Double = Nothing
            Double.TryParse(Utilities.getLabelPrice(LBL_Potato_Price), temp)
            Subtotal += temp
            LBL_Order_Subtotal.Text = $"${Subtotal}"
            PB_Order_Notify.Visible = True
            MessageBox.Show("Baked-Potato Pizza added to Order!" & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Go to 'Your Order' to Checkout ...")
        End Sub

        Private Sub BTN_LV_RemoveItem(ByVal sender As Object, ByVal e As EventArgs)
            Dim Total = 0.00
            Dim temp As Double = Nothing

            For Each eachItem As ListViewItem In LV_Cart.SelectedItems
                Dim line = eachItem.SubItems(5).Text
                Dim split = line.Split("$"c)
                Double.TryParse(split(1), temp)
                Total += temp
                LV_Cart.Items.Remove(eachItem)
            Next

            Subtotal -= Total
            LBL_Order_Subtotal.Text = $"${Subtotal}"
        End Sub

        Private Sub BTN_LV_AddMore(ByVal sender As Object, ByVal e As EventArgs)
            TC_Navigation.SelectedIndex = 0
            Lightup_Panel_Menu.BackColor = Utilities.ACCENT_COLOR
            Lightup_Panel_Specialties.BackColor = Utilities.SECONDARY_COLOR
            Lightup_Panel_Custom.BackColor = Utilities.SECONDARY_COLOR
            Lightup_Panel_Order.BackColor = Utilities.SECONDARY_COLOR
        End Sub

        ' *
        '  
        '   Custom Order Custimization Begins here 
        '  
        ' 


        Private Sub RB_Cstm_Crust_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim rb = CType(sender, RadioButton)
            Dim name = rb.Name

            If Equals(name, "RB_Cstm_Crust_Pan") Then
                If rb.Checked Then
                    Custom.Crust = "Pan"
                    Cstm_Price += Utilities.PAN_CRUST
                    LBL_Cstm_Price.Text = $"${Cstm_Price}"
                Else
                    Custom.Crust = ""
                    Cstm_Price -= Utilities.PAN_CRUST
                    LBL_Cstm_Price.Text = $"${Cstm_Price}"
                End If
                Images.Remove(Utilities.CRUST_PAN)
                Images.Remove(Utilities.CRUST_HANDTOSSED)
                Images.Remove(Utilities.CRUST_THIN)
                Images.Remove(Utilities.CRUST_STUFFED)
                Images.Insert(0, Utilities.CRUST_PAN)
                CustomImage()
            ElseIf Equals(name, "RB_Cstm_Crust_HT") Then
                If rb.Checked Then
                    Custom.Crust = "Hand Tossed"
                    Cstm_Price += Utilities.HANDTOSSED_CRUST
                    LBL_Cstm_Price.Text = $"${Cstm_Price}"
                Else
                    Custom.Crust = ""
                    Cstm_Price -= Utilities.HANDTOSSED_CRUST
                    LBL_Cstm_Price.Text = $"${Cstm_Price}"
                End If
                Images.Remove(Utilities.CRUST_PAN)
                Images.Remove(Utilities.CRUST_HANDTOSSED)
                Images.Remove(Utilities.CRUST_THIN)
                Images.Remove(Utilities.CRUST_STUFFED)
                Images.Insert(0, Utilities.CRUST_HANDTOSSED)
                CustomImage()
            ElseIf Equals(name, "RB_Cstm_Crust_Thin") Then
                If rb.Checked Then
                    Custom.Crust = "Thin"
                    Cstm_Price += Utilities.THINNCRISPY_CRUST
                    LBL_Cstm_Price.Text = $"${Cstm_Price}"
                Else
                    Custom.Crust = ""
                    Cstm_Price -= Utilities.THINNCRISPY_CRUST
                    LBL_Cstm_Price.Text = $"${Cstm_Price}"
                End If
                Images.Remove(Utilities.CRUST_PAN)
                Images.Remove(Utilities.CRUST_HANDTOSSED)
                Images.Remove(Utilities.CRUST_THIN)
                Images.Remove(Utilities.CRUST_STUFFED)
                Images.Insert(0, Utilities.CRUST_THIN)
                CustomImage()
            ElseIf Equals(name, "RB_Cstm_Crust_Stuffed") Then
                If rb.Checked Then
                    Custom.Crust = "Stuffed"
                    Cstm_Price += Utilities.STUFFED_CRUST
                    LBL_Cstm_Price.Text = $"${Cstm_Price}"
                Else
                    Custom.Crust = ""
                    Cstm_Price -= Utilities.STUFFED_CRUST
                    LBL_Cstm_Price.Text = $"${Cstm_Price}"
                End If
                Images.Remove(Utilities.CRUST_PAN)
                Images.Remove(Utilities.CRUST_HANDTOSSED)
                Images.Remove(Utilities.CRUST_THIN)
                Images.Remove(Utilities.CRUST_STUFFED)
                Images.Insert(0, Utilities.CRUST_STUFFED)
                CustomImage()
            End If
        End Sub

        Private Sub RB_Cstm_Size_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim rb = CType(sender, RadioButton)
            Dim name = rb.Name

            If Equals(name, "RB_Cstm_Size_Small") Then
                If rb.Checked Then
                    Custom.Size = "Small"
                    Cstm_Price += Utilities.SMALL_PIZZA
                    LBL_Cstm_Price.Text = $"${Cstm_Price}"
                Else
                    Custom.Size = ""
                    Cstm_Price -= Utilities.SMALL_PIZZA
                    LBL_Cstm_Price.Text = $"${Cstm_Price}"
                End If
            ElseIf Equals(name, "RB_Cstm_Size_Med") Then
                If rb.Checked Then
                    Custom.Size = "Med"
                    Cstm_Price += Utilities.MEDIUM_PIZZA
                    LBL_Cstm_Price.Text = $"${Cstm_Price}"
                Else
                    Custom.Size = ""
                    Cstm_Price -= Utilities.MEDIUM_PIZZA
                    LBL_Cstm_Price.Text = $"${Cstm_Price}"
                End If
            ElseIf Equals(name, "RB_Cstm_Size_Large") Then
                If rb.Checked Then
                    Custom.Size = "Large"
                    Cstm_Price += Utilities.LARGE_PIZZA
                    LBL_Cstm_Price.Text = $"${Cstm_Price}"
                Else
                    Custom.Size = ""
                    Cstm_Price -= Utilities.LARGE_PIZZA
                    LBL_Cstm_Price.Text = $"${Cstm_Price}"
                End If
            End If
        End Sub

        Private Sub CB_Cstm_Pepperoni_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim cb = CType(sender, CheckBox)
            RB_Cstm_Pepperoni_reg.Checked = True

            If cb.Checked Then
                Custom.Pepperoni = True
                Images.Add(Utilities.TOP_PEPPERONI_L)
                Images.Add(Utilities.TOP_PEPPERONI_R)
                CustomImage()
                RB_Cstm_Pepperoni_reg.Enabled = True
                RB_Cstm_Pepperoni_Extra.Enabled = True
                PB_Cstm_Pepperoni_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED
                PB_Cstm_Pepperoni_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Pepperoni_R.Image = Utilities.PIZZA_RIGHT
                Cstm_Price += Utilities.PEPPORONI
                LBL_Cstm_Price.Text = $"${Cstm_Price}"
            Else
                Custom.Pepperoni = False
                Images.Remove(Utilities.TOP_PEPPERONI_L)
                Images.Remove(Utilities.TOP_PEPPERONI_R)
                Images.Remove(Utilities.TOP_PEPPERONI_X_L)
                Images.Remove(Utilities.TOP_PEPPERONI_X_R)
                CustomImage()
                RB_Cstm_Pepperoni_reg.Enabled = False
                RB_Cstm_Pepperoni_Extra.Enabled = False
                PB_Cstm_Pepperoni_Whole.Image = Utilities.PIZZA_WHOLE
                PB_Cstm_Pepperoni_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Pepperoni_R.Image = Utilities.PIZZA_RIGHT
                Cstm_Price -= Utilities.PEPPORONI
                LBL_Cstm_Price.Text = $"${Cstm_Price}"
            End If
        End Sub

        Private Sub RB_Cstm_Pepperoni_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim rb = CType(sender, RadioButton)
            Dim name = rb.Name

            If Equals(name, "RB_Cstm_Pepperoni_reg") Then
                If rb.Checked Then
                    If PB_Cstm_Pepperoni_L.Image Is Utilities.PIZZA_LEFT_SELECTED Then
                        Images.Remove(Utilities.TOP_PEPPERONI_L)
                        Images.Remove(Utilities.TOP_PEPPERONI_X_L)
                        Images.Remove(Utilities.TOP_PEPPERONI_R)
                        Images.Remove(Utilities.TOP_PEPPERONI_X_R)
                        Images.Add(Utilities.TOP_PEPPERONI_L)
                        CustomImage()
                    ElseIf PB_Cstm_Pepperoni_R.Image Is Utilities.PIZZA_RIGHT_SELECTED Then
                        Images.Remove(Utilities.TOP_PEPPERONI_L)
                        Images.Remove(Utilities.TOP_PEPPERONI_X_L)
                        Images.Remove(Utilities.TOP_PEPPERONI_R)
                        Images.Remove(Utilities.TOP_PEPPERONI_X_R)
                        Images.Add(Utilities.TOP_PEPPERONI_R)
                        CustomImage()
                    Else
                        Images.Remove(Utilities.TOP_PEPPERONI_L)
                        Images.Remove(Utilities.TOP_PEPPERONI_X_L)
                        Images.Remove(Utilities.TOP_PEPPERONI_R)
                        Images.Remove(Utilities.TOP_PEPPERONI_X_R)
                        Images.Add(Utilities.TOP_PEPPERONI_L)
                        Images.Add(Utilities.TOP_PEPPERONI_R)
                        CustomImage()
                    End If
                Else
                    If PB_Cstm_Pepperoni_L.Image Is Utilities.PIZZA_LEFT_SELECTED Then
                        Images.Remove(Utilities.TOP_PEPPERONI_L)
                        Images.Remove(Utilities.TOP_PEPPERONI_X_L)
                        Images.Remove(Utilities.TOP_PEPPERONI_R)
                        Images.Remove(Utilities.TOP_PEPPERONI_X_R)
                        Images.Add(Utilities.TOP_PEPPERONI_X_L)
                        CustomImage()
                    ElseIf PB_Cstm_Pepperoni_R.Image Is Utilities.PIZZA_RIGHT_SELECTED Then
                        Images.Remove(Utilities.TOP_PEPPERONI_L)
                        Images.Remove(Utilities.TOP_PEPPERONI_X_L)
                        Images.Remove(Utilities.TOP_PEPPERONI_R)
                        Images.Remove(Utilities.TOP_PEPPERONI_X_R)
                        Images.Add(Utilities.TOP_PEPPERONI_X_R)
                        CustomImage()
                    Else
                        Images.Remove(Utilities.TOP_PEPPERONI_L)
                        Images.Remove(Utilities.TOP_PEPPERONI_X_L)
                        Images.Remove(Utilities.TOP_PEPPERONI_R)
                        Images.Remove(Utilities.TOP_PEPPERONI_X_R)
                        Images.Add(Utilities.TOP_PEPPERONI_X_L)
                        Images.Add(Utilities.TOP_PEPPERONI_X_R)
                        CustomImage()
                    End If
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Pepperoni_Whole_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CB_Cstm_Pepperoni.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Pepperoni_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED
                PB_Cstm_Pepperoni_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Pepperoni_R.Image = Utilities.PIZZA_RIGHT

                If RB_Cstm_Pepperoni_Extra.Checked Then
                    Images.Remove(Utilities.TOP_PEPPERONI_L)
                    Images.Remove(Utilities.TOP_PEPPERONI_X_L)
                    Images.Remove(Utilities.TOP_PEPPERONI_R)
                    Images.Remove(Utilities.TOP_PEPPERONI_X_R)
                    Images.Add(Utilities.TOP_PEPPERONI_X_L)
                    Images.Add(Utilities.TOP_PEPPERONI_X_R)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_PEPPERONI_L)
                    Images.Remove(Utilities.TOP_PEPPERONI_X_L)
                    Images.Remove(Utilities.TOP_PEPPERONI_R)
                    Images.Remove(Utilities.TOP_PEPPERONI_X_R)
                    Images.Add(Utilities.TOP_PEPPERONI_L)
                    Images.Add(Utilities.TOP_PEPPERONI_R)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Pepperoni_R_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CB_Cstm_Pepperoni.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Pepperoni_R.Image = Utilities.PIZZA_RIGHT_SELECTED
                PB_Cstm_Pepperoni_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Pepperoni_Whole.Image = Utilities.PIZZA_WHOLE

                If RB_Cstm_Pepperoni_Extra.Checked Then
                    Images.Remove(Utilities.TOP_PEPPERONI_L)
                    Images.Remove(Utilities.TOP_PEPPERONI_X_L)
                    Images.Remove(Utilities.TOP_PEPPERONI_R)
                    Images.Remove(Utilities.TOP_PEPPERONI_X_R)
                    Images.Add(Utilities.TOP_PEPPERONI_X_R)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_PEPPERONI_L)
                    Images.Remove(Utilities.TOP_PEPPERONI_X_L)
                    Images.Remove(Utilities.TOP_PEPPERONI_R)
                    Images.Remove(Utilities.TOP_PEPPERONI_X_R)
                    Images.Add(Utilities.TOP_PEPPERONI_R)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Pepperoni_L_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CB_Cstm_Pepperoni.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Pepperoni_R.Image = Utilities.PIZZA_RIGHT
                PB_Cstm_Pepperoni_L.Image = Utilities.PIZZA_LEFT_SELECTED
                PB_Cstm_Pepperoni_Whole.Image = Utilities.PIZZA_WHOLE

                If RB_Cstm_Pepperoni_Extra.Checked Then
                    Images.Remove(Utilities.TOP_PEPPERONI_L)
                    Images.Remove(Utilities.TOP_PEPPERONI_X_L)
                    Images.Remove(Utilities.TOP_PEPPERONI_R)
                    Images.Remove(Utilities.TOP_PEPPERONI_X_R)
                    Images.Add(Utilities.TOP_PEPPERONI_X_L)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_PEPPERONI_L)
                    Images.Remove(Utilities.TOP_PEPPERONI_X_L)
                    Images.Remove(Utilities.TOP_PEPPERONI_R)
                    Images.Remove(Utilities.TOP_PEPPERONI_X_R)
                    Images.Add(Utilities.TOP_PEPPERONI_L)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub CB_Cstm_Sausage_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim cb = CType(sender, CheckBox)
            RB_Cstm_Sausage_Reg.Checked = True

            If cb.Checked Then
                Custom.Sausage = True
                Images.Add(Utilities.TOP_SAUSAGE_L)
                Images.Add(Utilities.TOP_SAUSAGE_R)
                CustomImage()
                RB_Cstm_Sausage_Reg.Enabled = True
                RB_Cstm_Sausage_Extra.Enabled = True
                PB_Cstm_Sausage_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED
                PB_Cstm_Sausage_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Sausage_R.Image = Utilities.PIZZA_RIGHT
                Cstm_Price += Utilities.SAUSAGE
                LBL_Cstm_Price.Text = $"${Cstm_Price}"
            Else
                Custom.Sausage = False
                Images.Remove(Utilities.TOP_SAUSAGE_L)
                Images.Remove(Utilities.TOP_SAUSAGE_R)
                Images.Remove(Utilities.TOP_SAUSAGE_X_L)
                Images.Remove(Utilities.TOP_SAUSAGE_X_R)
                CustomImage()
                RB_Cstm_Sausage_Reg.Enabled = False
                RB_Cstm_Sausage_Extra.Enabled = False
                PB_Cstm_Sausage_Whole.Image = Utilities.PIZZA_WHOLE
                PB_Cstm_Sausage_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Sausage_R.Image = Utilities.PIZZA_RIGHT
                Cstm_Price -= Utilities.SAUSAGE
                LBL_Cstm_Price.Text = $"${Cstm_Price}"
            End If
        End Sub

        Private Sub RB_Cstm_Sausage_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim rb = CType(sender, RadioButton)
            Dim name = rb.Name

            If Equals(name, "RB_Cstm_Sausage_reg") Then
                If rb.Checked Then
                    If PB_Cstm_Sausage_L.Image Is Utilities.PIZZA_LEFT_SELECTED Then
                        Images.Remove(Utilities.TOP_SAUSAGE_L)
                        Images.Remove(Utilities.TOP_SAUSAGE_X_L)
                        Images.Remove(Utilities.TOP_SAUSAGE_R)
                        Images.Remove(Utilities.TOP_SAUSAGE_X_R)
                        Images.Add(Utilities.TOP_SAUSAGE_L)
                        CustomImage()
                    ElseIf PB_Cstm_Sausage_R.Image Is Utilities.PIZZA_RIGHT_SELECTED Then
                        Images.Remove(Utilities.TOP_SAUSAGE_L)
                        Images.Remove(Utilities.TOP_SAUSAGE_X_L)
                        Images.Remove(Utilities.TOP_SAUSAGE_R)
                        Images.Remove(Utilities.TOP_SAUSAGE_X_R)
                        Images.Add(Utilities.TOP_SAUSAGE_R)
                        CustomImage()
                    Else
                        Images.Remove(Utilities.TOP_SAUSAGE_L)
                        Images.Remove(Utilities.TOP_SAUSAGE_X_L)
                        Images.Remove(Utilities.TOP_SAUSAGE_R)
                        Images.Remove(Utilities.TOP_SAUSAGE_X_R)
                        Images.Add(Utilities.TOP_SAUSAGE_L)
                        Images.Add(Utilities.TOP_SAUSAGE_R)
                        CustomImage()
                    End If
                Else
                    If PB_Cstm_Sausage_L.Image Is Utilities.PIZZA_LEFT_SELECTED Then
                        Images.Remove(Utilities.TOP_SAUSAGE_L)
                        Images.Remove(Utilities.TOP_SAUSAGE_X_L)
                        Images.Remove(Utilities.TOP_SAUSAGE_R)
                        Images.Remove(Utilities.TOP_SAUSAGE_X_R)
                        Images.Add(Utilities.TOP_SAUSAGE_X_L)
                        CustomImage()
                    ElseIf PB_Cstm_Sausage_R.Image Is Utilities.PIZZA_RIGHT_SELECTED Then
                        Images.Remove(Utilities.TOP_SAUSAGE_L)
                        Images.Remove(Utilities.TOP_SAUSAGE_X_L)
                        Images.Remove(Utilities.TOP_SAUSAGE_R)
                        Images.Remove(Utilities.TOP_SAUSAGE_X_R)
                        Images.Add(Utilities.TOP_SAUSAGE_X_R)
                        CustomImage()
                    Else
                        Images.Remove(Utilities.TOP_SAUSAGE_L)
                        Images.Remove(Utilities.TOP_SAUSAGE_X_L)
                        Images.Remove(Utilities.TOP_SAUSAGE_R)
                        Images.Remove(Utilities.TOP_SAUSAGE_X_R)
                        Images.Add(Utilities.TOP_SAUSAGE_X_L)
                        Images.Add(Utilities.TOP_SAUSAGE_X_R)
                        CustomImage()
                    End If
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Sausage_Whole_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CB_Cstm_Sausage.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Sausage_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED
                PB_Cstm_Sausage_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Sausage_R.Image = Utilities.PIZZA_RIGHT

                If RB_Cstm_Pepperoni_Extra.Checked Then
                    Images.Remove(Utilities.TOP_SAUSAGE_L)
                    Images.Remove(Utilities.TOP_SAUSAGE_X_L)
                    Images.Remove(Utilities.TOP_SAUSAGE_R)
                    Images.Remove(Utilities.TOP_SAUSAGE_X_R)
                    Images.Add(Utilities.TOP_SAUSAGE_X_L)
                    Images.Add(Utilities.TOP_SAUSAGE_X_R)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_SAUSAGE_L)
                    Images.Remove(Utilities.TOP_SAUSAGE_X_L)
                    Images.Remove(Utilities.TOP_SAUSAGE_R)
                    Images.Remove(Utilities.TOP_SAUSAGE_X_R)
                    Images.Add(Utilities.TOP_SAUSAGE_L)
                    Images.Add(Utilities.TOP_SAUSAGE_R)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Sausage_R_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CB_Cstm_Sausage.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Sausage_R.Image = Utilities.PIZZA_RIGHT_SELECTED
                PB_Cstm_Sausage_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Sausage_Whole.Image = Utilities.PIZZA_WHOLE

                If RB_Cstm_Pepperoni_Extra.Checked Then
                    Images.Remove(Utilities.TOP_SAUSAGE_L)
                    Images.Remove(Utilities.TOP_SAUSAGE_X_L)
                    Images.Remove(Utilities.TOP_SAUSAGE_R)
                    Images.Remove(Utilities.TOP_SAUSAGE_X_R)
                    Images.Add(Utilities.TOP_SAUSAGE_X_R)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_SAUSAGE_L)
                    Images.Remove(Utilities.TOP_SAUSAGE_X_L)
                    Images.Remove(Utilities.TOP_SAUSAGE_R)
                    Images.Remove(Utilities.TOP_SAUSAGE_X_R)
                    Images.Add(Utilities.TOP_SAUSAGE_R)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Sausage_L_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CB_Cstm_Sausage.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Sausage_R.Image = Utilities.PIZZA_RIGHT
                PB_Cstm_Sausage_L.Image = Utilities.PIZZA_LEFT_SELECTED
                PB_Cstm_Sausage_Whole.Image = Utilities.PIZZA_WHOLE

                If RB_Cstm_Sausage_Extra.Checked Then
                    Images.Remove(Utilities.TOP_SAUSAGE_L)
                    Images.Remove(Utilities.TOP_SAUSAGE_X_L)
                    Images.Remove(Utilities.TOP_SAUSAGE_R)
                    Images.Remove(Utilities.TOP_SAUSAGE_X_R)
                    Images.Add(Utilities.TOP_SAUSAGE_X_L)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_SAUSAGE_L)
                    Images.Remove(Utilities.TOP_SAUSAGE_X_L)
                    Images.Remove(Utilities.TOP_SAUSAGE_R)
                    Images.Remove(Utilities.TOP_SAUSAGE_X_R)
                    Images.Add(Utilities.TOP_SAUSAGE_L)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub CB_Cstm_Ham_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim cb = CType(sender, CheckBox)
            RB_Cstm_Ham_Reg.Checked = True

            If cb.Checked Then
                Custom.Ham = True
                Images.Add(Utilities.TOP_HAM_L)
                Images.Add(Utilities.TOP_HAM_R)
                CustomImage()
                RB_Cstm_Ham_Reg.Enabled = True
                RB_Cstm_Ham_Extra.Enabled = True
                PB_Cstm_Ham_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED
                PB_Cstm_Ham_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Ham_R.Image = Utilities.PIZZA_RIGHT
                Cstm_Price += Utilities.HAM
                LBL_Cstm_Price.Text = $"${Cstm_Price}"
            Else
                Custom.Ham = False
                Images.Remove(Utilities.TOP_HAM_L)
                Images.Remove(Utilities.TOP_HAM_R)
                Images.Remove(Utilities.TOP_HAM_X_L)
                Images.Remove(Utilities.TOP_HAM_X_R)
                CustomImage()
                RB_Cstm_Ham_Reg.Enabled = False
                RB_Cstm_Ham_Extra.Enabled = False
                PB_Cstm_Ham_Whole.Image = Utilities.PIZZA_WHOLE
                PB_Cstm_Ham_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Ham_R.Image = Utilities.PIZZA_RIGHT
                Cstm_Price -= Utilities.HAM
                LBL_Cstm_Price.Text = $"${Cstm_Price}"
            End If
        End Sub

        Private Sub RB_Cstm_Ham_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim rb = CType(sender, RadioButton)
            Dim name = rb.Name

            If Equals(name, "RB_Cstm_Ham_reg") Then
                If rb.Checked Then
                    If PB_Cstm_Ham_L.Image Is Utilities.PIZZA_LEFT_SELECTED Then
                        Images.Remove(Utilities.TOP_HAM_L)
                        Images.Remove(Utilities.TOP_HAM_X_L)
                        Images.Remove(Utilities.TOP_HAM_R)
                        Images.Remove(Utilities.TOP_HAM_X_R)
                        Images.Add(Utilities.TOP_HAM_L)
                        CustomImage()
                    ElseIf PB_Cstm_Ham_R.Image Is Utilities.PIZZA_RIGHT_SELECTED Then
                        Images.Remove(Utilities.TOP_HAM_L)
                        Images.Remove(Utilities.TOP_HAM_X_L)
                        Images.Remove(Utilities.TOP_HAM_R)
                        Images.Remove(Utilities.TOP_HAM_X_R)
                        Images.Add(Utilities.TOP_HAM_R)
                        CustomImage()
                    Else
                        Images.Remove(Utilities.TOP_HAM_L)
                        Images.Remove(Utilities.TOP_HAM_X_L)
                        Images.Remove(Utilities.TOP_HAM_R)
                        Images.Remove(Utilities.TOP_HAM_X_R)
                        Images.Add(Utilities.TOP_HAM_L)
                        Images.Add(Utilities.TOP_HAM_R)
                        CustomImage()
                    End If
                Else
                    If PB_Cstm_Ham_L.Image Is Utilities.PIZZA_LEFT_SELECTED Then
                        Images.Remove(Utilities.TOP_HAM_L)
                        Images.Remove(Utilities.TOP_HAM_X_L)
                        Images.Remove(Utilities.TOP_HAM_R)
                        Images.Remove(Utilities.TOP_HAM_X_R)
                        Images.Add(Utilities.TOP_HAM_X_L)
                        CustomImage()
                    ElseIf PB_Cstm_Ham_R.Image Is Utilities.PIZZA_RIGHT_SELECTED Then
                        Images.Remove(Utilities.TOP_HAM_L)
                        Images.Remove(Utilities.TOP_HAM_X_L)
                        Images.Remove(Utilities.TOP_HAM_R)
                        Images.Remove(Utilities.TOP_HAM_X_R)
                        Images.Add(Utilities.TOP_HAM_X_R)
                        CustomImage()
                    Else
                        Images.Remove(Utilities.TOP_HAM_L)
                        Images.Remove(Utilities.TOP_HAM_X_L)
                        Images.Remove(Utilities.TOP_HAM_R)
                        Images.Remove(Utilities.TOP_HAM_X_R)
                        Images.Add(Utilities.TOP_HAM_X_L)
                        Images.Add(Utilities.TOP_HAM_X_R)
                        CustomImage()
                    End If
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Ham_Whole_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CB_Cstm_Ham.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Ham_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED
                PB_Cstm_Ham_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Ham_R.Image = Utilities.PIZZA_RIGHT

                If RB_Cstm_Pepperoni_Extra.Checked Then
                    Images.Remove(Utilities.TOP_HAM_L)
                    Images.Remove(Utilities.TOP_HAM_X_L)
                    Images.Remove(Utilities.TOP_HAM_R)
                    Images.Remove(Utilities.TOP_HAM_X_R)
                    Images.Add(Utilities.TOP_HAM_X_L)
                    Images.Add(Utilities.TOP_HAM_X_R)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_HAM_L)
                    Images.Remove(Utilities.TOP_HAM_X_L)
                    Images.Remove(Utilities.TOP_HAM_R)
                    Images.Remove(Utilities.TOP_HAM_X_R)
                    Images.Add(Utilities.TOP_HAM_L)
                    Images.Add(Utilities.TOP_HAM_R)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Ham_R_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CB_Cstm_Ham.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Ham_R.Image = Utilities.PIZZA_RIGHT_SELECTED
                PB_Cstm_Ham_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Ham_Whole.Image = Utilities.PIZZA_WHOLE

                If RB_Cstm_Pepperoni_Extra.Checked Then
                    Images.Remove(Utilities.TOP_HAM_L)
                    Images.Remove(Utilities.TOP_HAM_X_L)
                    Images.Remove(Utilities.TOP_HAM_R)
                    Images.Remove(Utilities.TOP_HAM_X_R)
                    Images.Add(Utilities.TOP_HAM_X_R)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_HAM_L)
                    Images.Remove(Utilities.TOP_HAM_X_L)
                    Images.Remove(Utilities.TOP_HAM_R)
                    Images.Remove(Utilities.TOP_HAM_X_R)
                    Images.Add(Utilities.TOP_HAM_R)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Ham_L_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CB_Cstm_Ham.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Ham_R.Image = Utilities.PIZZA_RIGHT
                PB_Cstm_Ham_L.Image = Utilities.PIZZA_LEFT_SELECTED
                PB_Cstm_Ham_Whole.Image = Utilities.PIZZA_WHOLE

                If RB_Cstm_Ham_Extra.Checked Then
                    Images.Remove(Utilities.TOP_HAM_L)
                    Images.Remove(Utilities.TOP_HAM_X_L)
                    Images.Remove(Utilities.TOP_HAM_R)
                    Images.Remove(Utilities.TOP_HAM_X_R)
                    Images.Add(Utilities.TOP_HAM_X_L)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_HAM_L)
                    Images.Remove(Utilities.TOP_HAM_X_L)
                    Images.Remove(Utilities.TOP_HAM_R)
                    Images.Remove(Utilities.TOP_HAM_X_R)
                    Images.Add(Utilities.TOP_HAM_L)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub CB_Cstm_Bacon_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim cb = CType(sender, CheckBox)
            RB_Cstm_Bacon_Reg.Checked = True

            If cb.Checked Then
                Custom.Bacon = True
                Images.Add(Utilities.TOP_BACON_L)
                Images.Add(Utilities.TOP_BACON_R)
                CustomImage()
                RB_Cstm_Bacon_Reg.Enabled = True
                RB_Cstm_Bacon_Extra.Enabled = True
                PB_Cstm_Bacon_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED
                PB_Cstm_Bacon_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Bacon_R.Image = Utilities.PIZZA_RIGHT
                Cstm_Price += Utilities.BACON
                LBL_Cstm_Price.Text = $"${Cstm_Price}"
            Else
                Custom.Bacon = False
                Images.Remove(Utilities.TOP_BACON_L)
                Images.Remove(Utilities.TOP_BACON_R)
                Images.Remove(Utilities.TOP_BACON_X_L)
                Images.Remove(Utilities.TOP_BACON_X_R)
                CustomImage()
                RB_Cstm_Bacon_Reg.Enabled = False
                RB_Cstm_Bacon_Extra.Enabled = False
                PB_Cstm_Bacon_Whole.Image = Utilities.PIZZA_WHOLE
                PB_Cstm_Bacon_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Bacon_R.Image = Utilities.PIZZA_RIGHT
                Cstm_Price -= Utilities.BACON
                LBL_Cstm_Price.Text = $"${Cstm_Price}"
            End If
        End Sub

        Private Sub RB_Cstm_Bacon_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim rb = CType(sender, RadioButton)
            Dim name = rb.Name

            If Equals(name, "RB_Cstm_Bacon_reg") Then
                If rb.Checked Then
                    If PB_Cstm_Bacon_L.Image Is Utilities.PIZZA_LEFT_SELECTED Then
                        Images.Remove(Utilities.TOP_BACON_L)
                        Images.Remove(Utilities.TOP_BACON_X_L)
                        Images.Remove(Utilities.TOP_BACON_R)
                        Images.Remove(Utilities.TOP_BACON_X_R)
                        Images.Add(Utilities.TOP_BACON_L)
                        CustomImage()
                    ElseIf PB_Cstm_Bacon_R.Image Is Utilities.PIZZA_RIGHT_SELECTED Then
                        Images.Remove(Utilities.TOP_BACON_L)
                        Images.Remove(Utilities.TOP_BACON_X_L)
                        Images.Remove(Utilities.TOP_BACON_R)
                        Images.Remove(Utilities.TOP_BACON_X_R)
                        Images.Add(Utilities.TOP_BACON_R)
                        CustomImage()
                    Else
                        Images.Remove(Utilities.TOP_BACON_L)
                        Images.Remove(Utilities.TOP_BACON_X_L)
                        Images.Remove(Utilities.TOP_BACON_R)
                        Images.Remove(Utilities.TOP_BACON_X_R)
                        Images.Add(Utilities.TOP_BACON_L)
                        Images.Add(Utilities.TOP_BACON_R)
                        CustomImage()
                    End If
                Else
                    If PB_Cstm_Bacon_L.Image Is Utilities.PIZZA_LEFT_SELECTED Then
                        Images.Remove(Utilities.TOP_BACON_L)
                        Images.Remove(Utilities.TOP_BACON_X_L)
                        Images.Remove(Utilities.TOP_BACON_R)
                        Images.Remove(Utilities.TOP_BACON_X_R)
                        Images.Add(Utilities.TOP_BACON_X_L)
                        CustomImage()
                    ElseIf PB_Cstm_Bacon_R.Image Is Utilities.PIZZA_RIGHT_SELECTED Then
                        Images.Remove(Utilities.TOP_BACON_L)
                        Images.Remove(Utilities.TOP_BACON_X_L)
                        Images.Remove(Utilities.TOP_BACON_R)
                        Images.Remove(Utilities.TOP_BACON_X_R)
                        Images.Add(Utilities.TOP_BACON_X_R)
                        CustomImage()
                    Else
                        Images.Remove(Utilities.TOP_BACON_L)
                        Images.Remove(Utilities.TOP_BACON_X_L)
                        Images.Remove(Utilities.TOP_BACON_R)
                        Images.Remove(Utilities.TOP_BACON_X_R)
                        Images.Add(Utilities.TOP_BACON_X_L)
                        Images.Add(Utilities.TOP_BACON_X_R)
                        CustomImage()
                    End If
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Bacon_Whole_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CB_Cstm_Bacon.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Bacon_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED
                PB_Cstm_Bacon_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Bacon_R.Image = Utilities.PIZZA_RIGHT

                If RB_Cstm_Bacon_Extra.Checked Then
                    Images.Remove(Utilities.TOP_BACON_L)
                    Images.Remove(Utilities.TOP_BACON_X_L)
                    Images.Remove(Utilities.TOP_BACON_R)
                    Images.Remove(Utilities.TOP_BACON_X_R)
                    Images.Add(Utilities.TOP_BACON_X_L)
                    Images.Add(Utilities.TOP_BACON_X_R)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_BACON_L)
                    Images.Remove(Utilities.TOP_BACON_X_L)
                    Images.Remove(Utilities.TOP_BACON_R)
                    Images.Remove(Utilities.TOP_BACON_X_R)
                    Images.Add(Utilities.TOP_BACON_L)
                    Images.Add(Utilities.TOP_BACON_R)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Bacon_R_Click(ByVal sender As Object, ByVal e As EventArgs)
            If RB_Cstm_Bacon_Extra.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Bacon_R.Image = Utilities.PIZZA_RIGHT_SELECTED
                PB_Cstm_Bacon_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Bacon_Whole.Image = Utilities.PIZZA_WHOLE

                If RB_Cstm_Bacon_Extra.Checked Then
                    Images.Remove(Utilities.TOP_BACON_L)
                    Images.Remove(Utilities.TOP_BACON_X_L)
                    Images.Remove(Utilities.TOP_BACON_R)
                    Images.Remove(Utilities.TOP_BACON_X_R)
                    Images.Add(Utilities.TOP_BACON_X_R)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_BACON_L)
                    Images.Remove(Utilities.TOP_BACON_X_L)
                    Images.Remove(Utilities.TOP_BACON_R)
                    Images.Remove(Utilities.TOP_BACON_X_R)
                    Images.Add(Utilities.TOP_BACON_R)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Bacon_L_Click(ByVal sender As Object, ByVal e As EventArgs)
            If RB_Cstm_Bacon_Extra.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Bacon_R.Image = Utilities.PIZZA_RIGHT
                PB_Cstm_Bacon_L.Image = Utilities.PIZZA_LEFT_SELECTED
                PB_Cstm_Bacon_Whole.Image = Utilities.PIZZA_WHOLE

                If RB_Cstm_Bacon_Extra.Checked Then
                    Images.Remove(Utilities.TOP_BACON_L)
                    Images.Remove(Utilities.TOP_BACON_X_L)
                    Images.Remove(Utilities.TOP_BACON_R)
                    Images.Remove(Utilities.TOP_BACON_X_R)
                    Images.Add(Utilities.TOP_BACON_X_L)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_BACON_L)
                    Images.Remove(Utilities.TOP_BACON_X_L)
                    Images.Remove(Utilities.TOP_BACON_R)
                    Images.Remove(Utilities.TOP_BACON_X_R)
                    Images.Add(Utilities.TOP_BACON_L)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub CB_Cstm_Mushrooms_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim cb = CType(sender, CheckBox)
            RB_Cstm_Mushrooms_Reg.Checked = True

            If cb.Checked Then
                Custom.Mushrooms = True
                Images.Add(Utilities.TOP_MUSHROOM_L)
                Images.Add(Utilities.TOP_MUSHROOM_R)
                CustomImage()
                RB_Cstm_Mushrooms_Reg.Enabled = True
                RB_Cstm_Mushrooms_Extra.Enabled = True
                PB_Cstm_Mushrooms_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED
                PB_Cstm_Mushrooms_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Mushrooms_R.Image = Utilities.PIZZA_RIGHT
                Cstm_Price += Utilities.MUSHROOMS
                LBL_Cstm_Price.Text = $"${Cstm_Price}"
            Else
                Custom.Mushrooms = False
                Images.Remove(Utilities.TOP_MUSHROOM_L)
                Images.Remove(Utilities.TOP_MUSHROOM_R)
                Images.Remove(Utilities.TOP_MUSHROOM_X_L)
                Images.Remove(Utilities.TOP_MUSHROOM_X_R)
                CustomImage()
                RB_Cstm_Mushrooms_Reg.Enabled = False
                RB_Cstm_Mushrooms_Extra.Enabled = False
                PB_Cstm_Mushrooms_Whole.Image = Utilities.PIZZA_WHOLE
                PB_Cstm_Mushrooms_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Mushrooms_R.Image = Utilities.PIZZA_RIGHT
                Cstm_Price -= Utilities.MUSHROOMS
                LBL_Cstm_Price.Text = $"${Cstm_Price}"
            End If
        End Sub

        Private Sub RB_Cstm_Mushrooms_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim rb = CType(sender, RadioButton)
            Dim name = rb.Name

            If Equals(name, "RB_Cstm_Mushrooms_reg") Then
                If rb.Checked Then
                    If PB_Cstm_Mushrooms_L.Image Is Utilities.PIZZA_LEFT_SELECTED Then
                        Images.Remove(Utilities.TOP_MUSHROOM_L)
                        Images.Remove(Utilities.TOP_MUSHROOM_X_L)
                        Images.Remove(Utilities.TOP_MUSHROOM_R)
                        Images.Remove(Utilities.TOP_MUSHROOM_X_R)
                        Images.Add(Utilities.TOP_MUSHROOM_L)
                        CustomImage()
                    ElseIf PB_Cstm_Mushrooms_R.Image Is Utilities.PIZZA_RIGHT_SELECTED Then
                        Images.Remove(Utilities.TOP_MUSHROOM_L)
                        Images.Remove(Utilities.TOP_MUSHROOM_X_L)
                        Images.Remove(Utilities.TOP_MUSHROOM_R)
                        Images.Remove(Utilities.TOP_MUSHROOM_X_R)
                        Images.Add(Utilities.TOP_MUSHROOM_R)
                        CustomImage()
                    Else
                        Images.Remove(Utilities.TOP_MUSHROOM_L)
                        Images.Remove(Utilities.TOP_MUSHROOM_X_L)
                        Images.Remove(Utilities.TOP_MUSHROOM_R)
                        Images.Remove(Utilities.TOP_MUSHROOM_X_R)
                        Images.Add(Utilities.TOP_MUSHROOM_L)
                        Images.Add(Utilities.TOP_MUSHROOM_R)
                        CustomImage()
                    End If
                Else
                    If PB_Cstm_Mushrooms_L.Image Is Utilities.PIZZA_LEFT_SELECTED Then
                        Images.Remove(Utilities.TOP_MUSHROOM_L)
                        Images.Remove(Utilities.TOP_MUSHROOM_X_L)
                        Images.Remove(Utilities.TOP_MUSHROOM_R)
                        Images.Remove(Utilities.TOP_MUSHROOM_X_R)
                        Images.Add(Utilities.TOP_MUSHROOM_X_L)
                        CustomImage()
                    ElseIf PB_Cstm_Mushrooms_R.Image Is Utilities.PIZZA_RIGHT_SELECTED Then
                        Images.Remove(Utilities.TOP_MUSHROOM_L)
                        Images.Remove(Utilities.TOP_MUSHROOM_X_L)
                        Images.Remove(Utilities.TOP_MUSHROOM_R)
                        Images.Remove(Utilities.TOP_MUSHROOM_X_R)
                        Images.Add(Utilities.TOP_MUSHROOM_X_R)
                        CustomImage()
                    Else
                        Images.Remove(Utilities.TOP_MUSHROOM_L)
                        Images.Remove(Utilities.TOP_MUSHROOM_X_L)
                        Images.Remove(Utilities.TOP_MUSHROOM_R)
                        Images.Remove(Utilities.TOP_MUSHROOM_X_R)
                        Images.Add(Utilities.TOP_MUSHROOM_X_L)
                        Images.Add(Utilities.TOP_MUSHROOM_X_R)
                        CustomImage()
                    End If
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Mushrooms_Whole_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CB_Cstm_Mushrooms.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Mushrooms_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED
                PB_Cstm_Mushrooms_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Mushrooms_R.Image = Utilities.PIZZA_RIGHT

                If RB_Cstm_Pepperoni_Extra.Checked Then
                    Images.Remove(Utilities.TOP_MUSHROOM_L)
                    Images.Remove(Utilities.TOP_MUSHROOM_X_L)
                    Images.Remove(Utilities.TOP_MUSHROOM_R)
                    Images.Remove(Utilities.TOP_MUSHROOM_X_R)
                    Images.Add(Utilities.TOP_MUSHROOM_X_L)
                    Images.Add(Utilities.TOP_MUSHROOM_X_R)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_MUSHROOM_L)
                    Images.Remove(Utilities.TOP_MUSHROOM_X_L)
                    Images.Remove(Utilities.TOP_MUSHROOM_R)
                    Images.Remove(Utilities.TOP_MUSHROOM_X_R)
                    Images.Add(Utilities.TOP_MUSHROOM_L)
                    Images.Add(Utilities.TOP_MUSHROOM_R)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Mushrooms_R_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CB_Cstm_Mushrooms.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Mushrooms_R.Image = Utilities.PIZZA_RIGHT_SELECTED
                PB_Cstm_Mushrooms_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Mushrooms_Whole.Image = Utilities.PIZZA_WHOLE

                If RB_Cstm_Pepperoni_Extra.Checked Then
                    Images.Remove(Utilities.TOP_MUSHROOM_L)
                    Images.Remove(Utilities.TOP_MUSHROOM_X_L)
                    Images.Remove(Utilities.TOP_MUSHROOM_R)
                    Images.Remove(Utilities.TOP_MUSHROOM_X_R)
                    Images.Add(Utilities.TOP_MUSHROOM_X_R)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_MUSHROOM_L)
                    Images.Remove(Utilities.TOP_MUSHROOM_X_L)
                    Images.Remove(Utilities.TOP_MUSHROOM_R)
                    Images.Remove(Utilities.TOP_MUSHROOM_X_R)
                    Images.Add(Utilities.TOP_MUSHROOM_R)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Mushrooms_L_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CB_Cstm_Mushrooms.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Mushrooms_R.Image = Utilities.PIZZA_RIGHT
                PB_Cstm_Mushrooms_L.Image = Utilities.PIZZA_LEFT_SELECTED
                PB_Cstm_Mushrooms_Whole.Image = Utilities.PIZZA_WHOLE

                If RB_Cstm_Mushrooms_Extra.Checked Then
                    Images.Remove(Utilities.TOP_MUSHROOM_L)
                    Images.Remove(Utilities.TOP_MUSHROOM_X_L)
                    Images.Remove(Utilities.TOP_MUSHROOM_R)
                    Images.Remove(Utilities.TOP_MUSHROOM_X_R)
                    Images.Add(Utilities.TOP_MUSHROOM_X_L)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_MUSHROOM_L)
                    Images.Remove(Utilities.TOP_MUSHROOM_X_L)
                    Images.Remove(Utilities.TOP_MUSHROOM_R)
                    Images.Remove(Utilities.TOP_MUSHROOM_X_R)
                    Images.Add(Utilities.TOP_MUSHROOM_L)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub CB_Cstm_Onions_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim cb = CType(sender, CheckBox)
            RB_Cstm_Onions_Reg.Checked = True

            If cb.Checked Then
                Custom.Onions = True
                Images.Add(Utilities.TOP_ONION_L)
                Images.Add(Utilities.TOP_ONION_R)
                CustomImage()
                RB_Cstm_Onions_Reg.Enabled = True
                RB_Cstm_Onions_Extra.Enabled = True
                PB_Cstm_Onions_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED
                PB_Cstm_Onions_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Onions_R.Image = Utilities.PIZZA_RIGHT
                Cstm_Price += Utilities.ONIONS
                LBL_Cstm_Price.Text = $"${Cstm_Price}"
            Else
                Custom.Onions = False
                Images.Remove(Utilities.TOP_ONION_L)
                Images.Remove(Utilities.TOP_ONION_R)
                Images.Remove(Utilities.TOP_ONION_X_L)
                Images.Remove(Utilities.TOP_ONION_X_R)
                CustomImage()
                RB_Cstm_Onions_Reg.Enabled = False
                RB_Cstm_Onions_Extra.Enabled = False
                PB_Cstm_Onions_Whole.Image = Utilities.PIZZA_WHOLE
                PB_Cstm_Onions_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Onions_R.Image = Utilities.PIZZA_RIGHT
                Cstm_Price -= Utilities.ONIONS
                LBL_Cstm_Price.Text = $"${Cstm_Price}"
            End If
        End Sub

        Private Sub RB_Cstm_Onions_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim rb = CType(sender, RadioButton)
            Dim name = rb.Name

            If Equals(name, "RB_Cstm_Onions_reg") Then
                If rb.Checked Then
                    If PB_Cstm_Onions_L.Image Is Utilities.PIZZA_LEFT_SELECTED Then
                        Images.Remove(Utilities.TOP_ONION_L)
                        Images.Remove(Utilities.TOP_ONION_X_L)
                        Images.Remove(Utilities.TOP_ONION_R)
                        Images.Remove(Utilities.TOP_ONION_X_R)
                        Images.Add(Utilities.TOP_ONION_L)
                        CustomImage()
                    ElseIf PB_Cstm_Onions_R.Image Is Utilities.PIZZA_RIGHT_SELECTED Then
                        Images.Remove(Utilities.TOP_ONION_L)
                        Images.Remove(Utilities.TOP_ONION_X_L)
                        Images.Remove(Utilities.TOP_ONION_R)
                        Images.Remove(Utilities.TOP_ONION_X_R)
                        Images.Add(Utilities.TOP_ONION_R)
                        CustomImage()
                    Else
                        Images.Remove(Utilities.TOP_ONION_L)
                        Images.Remove(Utilities.TOP_ONION_X_L)
                        Images.Remove(Utilities.TOP_ONION_R)
                        Images.Remove(Utilities.TOP_ONION_X_R)
                        Images.Add(Utilities.TOP_ONION_L)
                        Images.Add(Utilities.TOP_ONION_R)
                        CustomImage()
                    End If
                Else
                    If PB_Cstm_Onions_L.Image Is Utilities.PIZZA_LEFT_SELECTED Then
                        Images.Remove(Utilities.TOP_ONION_L)
                        Images.Remove(Utilities.TOP_ONION_X_L)
                        Images.Remove(Utilities.TOP_ONION_R)
                        Images.Remove(Utilities.TOP_ONION_X_R)
                        Images.Add(Utilities.TOP_ONION_X_L)
                        CustomImage()
                    ElseIf PB_Cstm_Onions_R.Image Is Utilities.PIZZA_RIGHT_SELECTED Then
                        Images.Remove(Utilities.TOP_ONION_L)
                        Images.Remove(Utilities.TOP_ONION_X_L)
                        Images.Remove(Utilities.TOP_ONION_R)
                        Images.Remove(Utilities.TOP_ONION_X_R)
                        Images.Add(Utilities.TOP_ONION_X_R)
                        CustomImage()
                    Else
                        Images.Remove(Utilities.TOP_ONION_L)
                        Images.Remove(Utilities.TOP_ONION_X_L)
                        Images.Remove(Utilities.TOP_ONION_R)
                        Images.Remove(Utilities.TOP_ONION_X_R)
                        Images.Add(Utilities.TOP_ONION_X_L)
                        Images.Add(Utilities.TOP_ONION_X_R)
                        CustomImage()
                    End If
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Onions_Whole_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CB_Cstm_Onions.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Onions_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED
                PB_Cstm_Onions_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Onions_R.Image = Utilities.PIZZA_RIGHT

                If RB_Cstm_Pepperoni_Extra.Checked Then
                    Images.Remove(Utilities.TOP_ONION_L)
                    Images.Remove(Utilities.TOP_ONION_X_L)
                    Images.Remove(Utilities.TOP_ONION_R)
                    Images.Remove(Utilities.TOP_ONION_X_R)
                    Images.Add(Utilities.TOP_ONION_X_L)
                    Images.Add(Utilities.TOP_ONION_X_R)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_ONION_L)
                    Images.Remove(Utilities.TOP_ONION_X_L)
                    Images.Remove(Utilities.TOP_ONION_R)
                    Images.Remove(Utilities.TOP_ONION_X_R)
                    Images.Add(Utilities.TOP_ONION_L)
                    Images.Add(Utilities.TOP_ONION_R)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Onions_R_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CB_Cstm_Onions.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Onions_R.Image = Utilities.PIZZA_RIGHT_SELECTED
                PB_Cstm_Onions_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Onions_Whole.Image = Utilities.PIZZA_WHOLE

                If RB_Cstm_Pepperoni_Extra.Checked Then
                    Images.Remove(Utilities.TOP_ONION_L)
                    Images.Remove(Utilities.TOP_ONION_X_L)
                    Images.Remove(Utilities.TOP_ONION_R)
                    Images.Remove(Utilities.TOP_ONION_X_R)
                    Images.Add(Utilities.TOP_ONION_X_R)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_ONION_L)
                    Images.Remove(Utilities.TOP_ONION_X_L)
                    Images.Remove(Utilities.TOP_ONION_R)
                    Images.Remove(Utilities.TOP_ONION_X_R)
                    Images.Add(Utilities.TOP_ONION_R)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Onions_L_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CB_Cstm_Onions.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Onions_R.Image = Utilities.PIZZA_RIGHT
                PB_Cstm_Onions_L.Image = Utilities.PIZZA_LEFT_SELECTED
                PB_Cstm_Onions_Whole.Image = Utilities.PIZZA_WHOLE

                If RB_Cstm_Onions_Extra.Checked Then
                    Images.Remove(Utilities.TOP_ONION_L)
                    Images.Remove(Utilities.TOP_ONION_X_L)
                    Images.Remove(Utilities.TOP_ONION_R)
                    Images.Remove(Utilities.TOP_ONION_X_R)
                    Images.Add(Utilities.TOP_ONION_X_L)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_ONION_L)
                    Images.Remove(Utilities.TOP_ONION_X_L)
                    Images.Remove(Utilities.TOP_ONION_R)
                    Images.Remove(Utilities.TOP_ONION_X_R)
                    Images.Add(Utilities.TOP_ONION_L)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub CB_Cstm_Olives_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim cb = CType(sender, CheckBox)
            RB_Cstm_Olives_Reg.Checked = True

            If cb.Checked Then
                Custom.SetOlives(True)
                Images.Add(Utilities.TOP_OLIVE_L)
                Images.Add(Utilities.TOP_OLIVE_R)
                CustomImage()
                RB_Cstm_Olives_Reg.Enabled = True
                RB_Cstm_Olives_Extra.Enabled = True
                PB_Cstm_Olives_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED
                PB_Cstm_Olives_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Olives_R.Image = Utilities.PIZZA_RIGHT
                Cstm_Price += Utilities.OLIVES
                LBL_Cstm_Price.Text = $"${Cstm_Price}"
            Else
                Custom.SetOlives(False)
                Images.Remove(Utilities.TOP_OLIVE_L)
                Images.Remove(Utilities.TOP_OLIVE_R)
                Images.Remove(Utilities.TOP_OLIVE_X_L)
                Images.Remove(Utilities.TOP_OLIVE_X_R)
                CustomImage()
                RB_Cstm_Olives_Reg.Enabled = False
                RB_Cstm_Olives_Extra.Enabled = False
                PB_Cstm_Olives_Whole.Image = Utilities.PIZZA_WHOLE
                PB_Cstm_Olives_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Olives_R.Image = Utilities.PIZZA_RIGHT
                Cstm_Price -= Utilities.OLIVES
                LBL_Cstm_Price.Text = $"${Cstm_Price}"
            End If
        End Sub

        Private Sub RB_Cstm_Olives_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim rb = CType(sender, RadioButton)
            Dim name = rb.Name

            If Equals(name, "RB_Cstm_Olives_reg") Then
                If rb.Checked Then
                    If PB_Cstm_Olives_L.Image Is Utilities.PIZZA_LEFT_SELECTED Then
                        Images.Remove(Utilities.TOP_OLIVE_L)
                        Images.Remove(Utilities.TOP_OLIVE_X_L)
                        Images.Remove(Utilities.TOP_OLIVE_R)
                        Images.Remove(Utilities.TOP_OLIVE_X_R)
                        Images.Add(Utilities.TOP_OLIVE_L)
                        CustomImage()
                    ElseIf PB_Cstm_Olives_R.Image Is Utilities.PIZZA_RIGHT_SELECTED Then
                        Images.Remove(Utilities.TOP_OLIVE_L)
                        Images.Remove(Utilities.TOP_OLIVE_X_L)
                        Images.Remove(Utilities.TOP_OLIVE_R)
                        Images.Remove(Utilities.TOP_OLIVE_X_R)
                        Images.Add(Utilities.TOP_OLIVE_R)
                        CustomImage()
                    Else
                        Images.Remove(Utilities.TOP_OLIVE_L)
                        Images.Remove(Utilities.TOP_OLIVE_X_L)
                        Images.Remove(Utilities.TOP_OLIVE_R)
                        Images.Remove(Utilities.TOP_OLIVE_X_R)
                        Images.Add(Utilities.TOP_OLIVE_L)
                        Images.Add(Utilities.TOP_OLIVE_R)
                        CustomImage()
                    End If
                Else
                    If PB_Cstm_Olives_L.Image Is Utilities.PIZZA_LEFT_SELECTED Then
                        Images.Remove(Utilities.TOP_OLIVE_L)
                        Images.Remove(Utilities.TOP_OLIVE_X_L)
                        Images.Remove(Utilities.TOP_OLIVE_R)
                        Images.Remove(Utilities.TOP_OLIVE_X_R)
                        Images.Add(Utilities.TOP_OLIVE_X_L)
                        CustomImage()
                    ElseIf PB_Cstm_Olives_R.Image Is Utilities.PIZZA_RIGHT_SELECTED Then
                        Images.Remove(Utilities.TOP_OLIVE_L)
                        Images.Remove(Utilities.TOP_OLIVE_X_L)
                        Images.Remove(Utilities.TOP_OLIVE_R)
                        Images.Remove(Utilities.TOP_OLIVE_X_R)
                        Images.Add(Utilities.TOP_OLIVE_X_R)
                        CustomImage()
                    Else
                        Images.Remove(Utilities.TOP_OLIVE_L)
                        Images.Remove(Utilities.TOP_OLIVE_X_L)
                        Images.Remove(Utilities.TOP_OLIVE_R)
                        Images.Remove(Utilities.TOP_OLIVE_X_R)
                        Images.Add(Utilities.TOP_OLIVE_X_L)
                        Images.Add(Utilities.TOP_OLIVE_X_R)
                        CustomImage()
                    End If
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Olives_Whole_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CB_Cstm_Olives.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Olives_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED
                PB_Cstm_Olives_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Olives_R.Image = Utilities.PIZZA_RIGHT

                If RB_Cstm_Pepperoni_Extra.Checked Then
                    Images.Remove(Utilities.TOP_OLIVE_L)
                    Images.Remove(Utilities.TOP_OLIVE_X_L)
                    Images.Remove(Utilities.TOP_OLIVE_R)
                    Images.Remove(Utilities.TOP_OLIVE_X_R)
                    Images.Add(Utilities.TOP_OLIVE_X_L)
                    Images.Add(Utilities.TOP_OLIVE_X_R)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_OLIVE_L)
                    Images.Remove(Utilities.TOP_OLIVE_X_L)
                    Images.Remove(Utilities.TOP_OLIVE_R)
                    Images.Remove(Utilities.TOP_OLIVE_X_R)
                    Images.Add(Utilities.TOP_OLIVE_L)
                    Images.Add(Utilities.TOP_OLIVE_R)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Olives_R_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CB_Cstm_Olives.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Olives_R.Image = Utilities.PIZZA_RIGHT_SELECTED
                PB_Cstm_Olives_L.Image = Utilities.PIZZA_LEFT
                PB_Cstm_Olives_Whole.Image = Utilities.PIZZA_WHOLE

                If RB_Cstm_Pepperoni_Extra.Checked Then
                    Images.Remove(Utilities.TOP_OLIVE_L)
                    Images.Remove(Utilities.TOP_OLIVE_X_L)
                    Images.Remove(Utilities.TOP_OLIVE_R)
                    Images.Remove(Utilities.TOP_OLIVE_X_R)
                    Images.Add(Utilities.TOP_OLIVE_X_R)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_OLIVE_L)
                    Images.Remove(Utilities.TOP_OLIVE_X_L)
                    Images.Remove(Utilities.TOP_OLIVE_R)
                    Images.Remove(Utilities.TOP_OLIVE_X_R)
                    Images.Add(Utilities.TOP_OLIVE_R)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub PB_Cstm_Olives_L_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CB_Cstm_Olives.Checked Then
                Dim pb = CType(sender, PictureBox)
                PB_Cstm_Olives_R.Image = Utilities.PIZZA_RIGHT
                PB_Cstm_Olives_L.Image = Utilities.PIZZA_LEFT_SELECTED
                PB_Cstm_Olives_Whole.Image = Utilities.PIZZA_WHOLE

                If RB_Cstm_Olives_Extra.Checked Then
                    Images.Remove(Utilities.TOP_OLIVE_L)
                    Images.Remove(Utilities.TOP_OLIVE_X_L)
                    Images.Remove(Utilities.TOP_OLIVE_R)
                    Images.Remove(Utilities.TOP_OLIVE_X_R)
                    Images.Add(Utilities.TOP_OLIVE_X_L)
                    CustomImage()
                Else
                    Images.Remove(Utilities.TOP_OLIVE_L)
                    Images.Remove(Utilities.TOP_OLIVE_X_L)
                    Images.Remove(Utilities.TOP_OLIVE_R)
                    Images.Remove(Utilities.TOP_OLIVE_X_R)
                    Images.Add(Utilities.TOP_OLIVE_L)
                    CustomImage()
                End If
            End If
        End Sub

        Private Sub BTN_Cstm_Clear_ClickEvent(ByVal sender As Object, ByVal e As EventArgs)
            RB_Cstm_Crust_Pan.Checked = True
            RB_Cstm_Size_Large.Checked = True
            RB_Cstm_Sauce_Mar.Checked = True
            CB_Cstm_Pepperoni.Checked = False
            CB_Cstm_Sausage.Checked = False
            CB_Cstm_Ham.Checked = False
            CB_Cstm_Bacon.Checked = False
            CB_Cstm_Mushrooms.Checked = False
            CB_Cstm_Onions.Checked = False
            CB_Cstm_Olives.Checked = False
        End Sub

        Private Sub BTN_Cstm_Order_ClickEvent(ByVal sender As Object, ByVal e As EventArgs)
            Custom.Price = Double.Parse(Utilities.getLabelPrice(LBL_Cstm_Price))
            Call Custom.UpdateList()
            Dim Toppings As String = Custom.GetListToStrings()
            Dim CustomPrice = $"${Custom.Price}"
            Subtotal += Custom.Price
            LBL_Order_Subtotal.Text = $"${Subtotal}"

            Dim item As ListViewItem = New ListViewItem("CSTM")
            item.SubItems.Add("Custom")
            item.SubItems.Add(Custom.Size)
            item.SubItems.Add(Custom.Crust)
            item.SubItems.Add(Toppings)
            item.SubItems.Add(CustomPrice)
            LV_Cart.Items.Add(item)

            PB_Order_Notify.Visible = True
            MessageBox.Show("Custom Pizza added to Order!" & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Go to 'Your Order' to Checkout ...")
        End Sub

        Private Sub LBL_Order_Subtotal_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Tax = Subtotal * TaxRate
            Total = Subtotal + Tax
            LBL_Order_Tax.Text = $"${String.Format("{0:0.00}", Tax)}"
            LBL_Order_Total.Text = $"${String.Format("{0:0.00}", Total)}"
        End Sub

        Private Sub BTN_Order_Order_Click(ByVal sender As Object, ByVal e As EventArgs)
            MessageBox.Show($"We will pretend you entered payment data. Enjoy your pizza!")
        End Sub
    End Class
End Namespace
