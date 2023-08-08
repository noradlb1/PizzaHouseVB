Imports System

Namespace PizzaShop
    Partial Class ApplicationForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ApplicationForm))
            panel6 = New Windows.Forms.Panel()
            PB_Minimize = New Windows.Forms.PictureBox()
            PB_Exit = New Windows.Forms.PictureBox()
            PB_Maximize = New Windows.Forms.PictureBox()
            panel5 = New Windows.Forms.Panel()
            TC_Navigation = New MaterialSkin.Controls.MaterialTabControl()
            TC_Tab_Menu = New Windows.Forms.TabPage()
            PNL_Pizza_Grid = New Windows.Forms.TableLayoutPanel()
            PNL_Cheese = New Windows.Forms.Panel()
            LBL_Cheese_Description = New Windows.Forms.Label()
            LBL_Cheese_Desc = New Windows.Forms.Label()
            LBL_Cheese_Price = New Windows.Forms.Label()
            BTN_Cheese_Order = New Windows.Forms.Button()
            LBL_Cheese_Subtotal = New Windows.Forms.Label()
            LBL_Cheese_Toppings = New Windows.Forms.Label()
            LBL_Cheese_Crust = New Windows.Forms.Label()
            LBL_Cheese_Size = New Windows.Forms.Label()
            LBL_Cheese_Options = New Windows.Forms.Label()
            CB_Cheese_Crust = New Windows.Forms.ComboBox()
            CB_Cheese_Size = New Windows.Forms.ComboBox()
            LBL_Cheese = New Windows.Forms.Label()
            PB_Cheese = New Windows.Forms.PictureBox()
            CB_Cheese_Toppings = New Windows.Forms.ComboBox()
            PNL_Pepperoni = New Windows.Forms.Panel()
            label3 = New Windows.Forms.Label()
            LBL_Pepperoni_Desc = New Windows.Forms.Label()
            LBL_Pepperoni_Price = New Windows.Forms.Label()
            BTN_Pepperoni_Order = New Windows.Forms.Button()
            LBL_Pepperoni_Subtotal = New Windows.Forms.Label()
            LBL_Pepperoni_Toppings = New Windows.Forms.Label()
            LBL_Pepperoni_Crust = New Windows.Forms.Label()
            LBL_Pepperoni_Size = New Windows.Forms.Label()
            LBL_Pepperoni_Options = New Windows.Forms.Label()
            CB_Pepperoni_Crust = New Windows.Forms.ComboBox()
            CB_Pepperoni_Size = New Windows.Forms.ComboBox()
            LBL_Pepperoni = New Windows.Forms.Label()
            pictureBox2 = New Windows.Forms.PictureBox()
            CB_Pepperoni_Toppings = New Windows.Forms.ComboBox()
            PNL_BBQ = New Windows.Forms.Panel()
            LBL_BBQ_Description = New Windows.Forms.Label()
            LBL_BBQ_Desc = New Windows.Forms.Label()
            LBL_BBQ_Price = New Windows.Forms.Label()
            BTN_BBQ_Order = New Windows.Forms.Button()
            LBL_BBQ_Subtotal = New Windows.Forms.Label()
            LBL_BBQ_Toppings = New Windows.Forms.Label()
            LBL_BBQ_Crust = New Windows.Forms.Label()
            LBL_BBQ_Size = New Windows.Forms.Label()
            LBL_BBQ_Options = New Windows.Forms.Label()
            CB_BBQ_Crust = New Windows.Forms.ComboBox()
            CB_BBQ_Size = New Windows.Forms.ComboBox()
            LBL_BBQ = New Windows.Forms.Label()
            PB_BBQ = New Windows.Forms.PictureBox()
            CB_BBQ_Toppings = New Windows.Forms.ComboBox()
            PNL_Supreme = New Windows.Forms.Panel()
            LBL_Supreme_Description = New Windows.Forms.Label()
            LBL_Supreme_Desc = New Windows.Forms.Label()
            LBL_Supreme_Price = New Windows.Forms.Label()
            BTN_Supreme_Order = New Windows.Forms.Button()
            LBL_Supreme_Subtotal = New Windows.Forms.Label()
            LBL_Supreme_Toppings = New Windows.Forms.Label()
            LBL_Supreme_Crust = New Windows.Forms.Label()
            LBL_Supreme_Size = New Windows.Forms.Label()
            LBL_Supreme_Options = New Windows.Forms.Label()
            CB_Supreme_Crust = New Windows.Forms.ComboBox()
            CB_Supreme_Size = New Windows.Forms.ComboBox()
            LBL_Supreme = New Windows.Forms.Label()
            PB_Supreme = New Windows.Forms.PictureBox()
            CB_Supreme_Toppings = New Windows.Forms.ComboBox()
            LBL_Menu_Pizza = New Windows.Forms.Label()
            PB_Menu_Title = New Windows.Forms.PictureBox()
            TC_Tab_Specialties = New Windows.Forms.TabPage()
            tableLayoutPanel1 = New Windows.Forms.TableLayoutPanel()
            panel4 = New Windows.Forms.Panel()
            label2 = New Windows.Forms.Label()
            label4 = New Windows.Forms.Label()
            LBL_Taco_Price = New Windows.Forms.Label()
            BTN_Taco_Order = New Windows.Forms.Button()
            LBL_Taco_Subtotal = New Windows.Forms.Label()
            label7 = New Windows.Forms.Label()
            label8 = New Windows.Forms.Label()
            label9 = New Windows.Forms.Label()
            label10 = New Windows.Forms.Label()
            CB_Taco_Crust = New Windows.Forms.ComboBox()
            CB_Taco_Size = New Windows.Forms.ComboBox()
            label11 = New Windows.Forms.Label()
            pictureBox3 = New Windows.Forms.PictureBox()
            CB_Taco_Toppings = New Windows.Forms.ComboBox()
            panel9 = New Windows.Forms.Panel()
            label12 = New Windows.Forms.Label()
            label13 = New Windows.Forms.Label()
            LBL_Breakfast_Price = New Windows.Forms.Label()
            BTN_Breakfast_Order = New Windows.Forms.Button()
            LBL_Breakfast_Subtotal = New Windows.Forms.Label()
            label16 = New Windows.Forms.Label()
            label17 = New Windows.Forms.Label()
            label18 = New Windows.Forms.Label()
            label19 = New Windows.Forms.Label()
            CB_Breakfast_Crust = New Windows.Forms.ComboBox()
            CB_Breakfast_Size = New Windows.Forms.ComboBox()
            label20 = New Windows.Forms.Label()
            pictureBox4 = New Windows.Forms.PictureBox()
            CB_Breakfast_Toppings = New Windows.Forms.ComboBox()
            panel10 = New Windows.Forms.Panel()
            label21 = New Windows.Forms.Label()
            label22 = New Windows.Forms.Label()
            LBL_Spinach_Price = New Windows.Forms.Label()
            BTN_Spinach_Order = New Windows.Forms.Button()
            LBL_Spinach_Subtotal = New Windows.Forms.Label()
            label25 = New Windows.Forms.Label()
            label26 = New Windows.Forms.Label()
            label27 = New Windows.Forms.Label()
            label28 = New Windows.Forms.Label()
            CB_Spinach_Crust = New Windows.Forms.ComboBox()
            CB_Spinach_Size = New Windows.Forms.ComboBox()
            label29 = New Windows.Forms.Label()
            pictureBox5 = New Windows.Forms.PictureBox()
            CB_Spinach_Toppings = New Windows.Forms.ComboBox()
            panel11 = New Windows.Forms.Panel()
            label30 = New Windows.Forms.Label()
            label31 = New Windows.Forms.Label()
            LBL_Potato_Price = New Windows.Forms.Label()
            BTN_Potato_Order = New Windows.Forms.Button()
            LBL_Potato_Subtotal = New Windows.Forms.Label()
            label34 = New Windows.Forms.Label()
            label35 = New Windows.Forms.Label()
            label36 = New Windows.Forms.Label()
            label37 = New Windows.Forms.Label()
            CB_Potato_Crust = New Windows.Forms.ComboBox()
            CB_Potato_Size = New Windows.Forms.ComboBox()
            label38 = New Windows.Forms.Label()
            pictureBox6 = New Windows.Forms.PictureBox()
            CB_Potato_Toppings = New Windows.Forms.ComboBox()
            label1 = New Windows.Forms.Label()
            PB_Specials_Title = New Windows.Forms.PictureBox()
            TC_Tab_Custom = New Windows.Forms.TabPage()
            LBL_Cstm_Price = New Windows.Forms.Label()
            label15 = New Windows.Forms.Label()
            panel12 = New Windows.Forms.Panel()
            panel16 = New Windows.Forms.Panel()
            PNL_Olives_Cstm = New Windows.Forms.Panel()
            RB_Cstm_Olives_Extra = New Windows.Forms.RadioButton()
            PB_Cstm_Olives_Whole = New Windows.Forms.PictureBox()
            PB_Cstm_Olives_R = New Windows.Forms.PictureBox()
            PB_Cstm_Olives_L = New Windows.Forms.PictureBox()
            RB_Cstm_Olives_Reg = New Windows.Forms.RadioButton()
            CB_Cstm_Olives = New Windows.Forms.CheckBox()
            PNL_Onions_Cstm = New Windows.Forms.Panel()
            RB_Cstm_Onions_Extra = New Windows.Forms.RadioButton()
            PB_Cstm_Onions_Whole = New Windows.Forms.PictureBox()
            PB_Cstm_Onions_R = New Windows.Forms.PictureBox()
            PB_Cstm_Onions_L = New Windows.Forms.PictureBox()
            RB_Cstm_Onions_Reg = New Windows.Forms.RadioButton()
            CB_Cstm_Onions = New Windows.Forms.CheckBox()
            PNL_Mushrooms_Cstm = New Windows.Forms.Panel()
            RB_Cstm_Mushrooms_Extra = New Windows.Forms.RadioButton()
            PB_Cstm_Mushrooms_Whole = New Windows.Forms.PictureBox()
            PB_Cstm_Mushrooms_R = New Windows.Forms.PictureBox()
            PB_Cstm_Mushrooms_L = New Windows.Forms.PictureBox()
            RB_Cstm_Mushrooms_Reg = New Windows.Forms.RadioButton()
            CB_Cstm_Mushrooms = New Windows.Forms.CheckBox()
            PNL_Bacon_Cstm = New Windows.Forms.Panel()
            RB_Cstm_Bacon_Extra = New Windows.Forms.RadioButton()
            PB_Cstm_Bacon_Whole = New Windows.Forms.PictureBox()
            PB_Cstm_Bacon_R = New Windows.Forms.PictureBox()
            PB_Cstm_Bacon_L = New Windows.Forms.PictureBox()
            RB_Cstm_Bacon_Reg = New Windows.Forms.RadioButton()
            CB_Cstm_Bacon = New Windows.Forms.CheckBox()
            PNL_Ham_Cstm = New Windows.Forms.Panel()
            RB_Cstm_Ham_Extra = New Windows.Forms.RadioButton()
            PB_Cstm_Ham_Whole = New Windows.Forms.PictureBox()
            PB_Cstm_Ham_R = New Windows.Forms.PictureBox()
            PB_Cstm_Ham_L = New Windows.Forms.PictureBox()
            RB_Cstm_Ham_Reg = New Windows.Forms.RadioButton()
            CB_Cstm_Ham = New Windows.Forms.CheckBox()
            PNL_Sausage_Cstm = New Windows.Forms.Panel()
            RB_Cstm_Sausage_Extra = New Windows.Forms.RadioButton()
            PB_Cstm_Sausage_Whole = New Windows.Forms.PictureBox()
            PB_Cstm_Sausage_R = New Windows.Forms.PictureBox()
            PB_Cstm_Sausage_L = New Windows.Forms.PictureBox()
            RB_Cstm_Sausage_Reg = New Windows.Forms.RadioButton()
            CB_Cstm_Sausage = New Windows.Forms.CheckBox()
            PNL_Pepperoni_Cstm = New Windows.Forms.Panel()
            RB_Cstm_Pepperoni_Extra = New Windows.Forms.RadioButton()
            PB_Cstm_Pepperoni_Whole = New Windows.Forms.PictureBox()
            PB_Cstm_Pepperoni_R = New Windows.Forms.PictureBox()
            PB_Cstm_Pepperoni_L = New Windows.Forms.PictureBox()
            RB_Cstm_Pepperoni_reg = New Windows.Forms.RadioButton()
            CB_Cstm_Pepperoni = New Windows.Forms.CheckBox()
            BTN_Cstm_Order = New Windows.Forms.Button()
            BTN_Cstm_Clear = New Windows.Forms.Button()
            label24 = New Windows.Forms.Label()
            panel15 = New Windows.Forms.Panel()
            RB_Cstm_Sauce_Buf = New Windows.Forms.RadioButton()
            RB_Cstm_Sauce_BBQ = New Windows.Forms.RadioButton()
            RB_Cstm_Sauce_GP = New Windows.Forms.RadioButton()
            RB_Cstm_Sauce_Mar = New Windows.Forms.RadioButton()
            label14 = New Windows.Forms.Label()
            panel13 = New Windows.Forms.Panel()
            RB_Cstm_Size_Large = New Windows.Forms.RadioButton()
            RB_Cstm_Size_Med = New Windows.Forms.RadioButton()
            RB_Cstm_Size_Small = New Windows.Forms.RadioButton()
            label5 = New Windows.Forms.Label()
            panel14 = New Windows.Forms.Panel()
            RB_Cstm_Crust_Pan = New Windows.Forms.RadioButton()
            RB_Cstm_Crust_HT = New Windows.Forms.RadioButton()
            RB_Cstm_Crust_Stuffed = New Windows.Forms.RadioButton()
            RB_Cstm_Crust_Thin = New Windows.Forms.RadioButton()
            label6 = New Windows.Forms.Label()
            PNL_Custom_ImageHolder = New Windows.Forms.Panel()
            PB_Cstm_PizzaImg = New Windows.Forms.PictureBox()
            PB_Custom_Title = New Windows.Forms.PictureBox()
            TC_Tab_Cart = New Windows.Forms.TabPage()
            panel17 = New Windows.Forms.Panel()
            panel19 = New Windows.Forms.Panel()
            BTN_Order_Order = New Windows.Forms.Button()
            LBL_Order_Tax = New Windows.Forms.Label()
            LBL_Order_Total = New Windows.Forms.Label()
            label40 = New Windows.Forms.Label()
            label39 = New Windows.Forms.Label()
            LBL_Order_Subtotal = New Windows.Forms.Label()
            label32 = New Windows.Forms.Label()
            button1 = New Windows.Forms.Button()
            BTN_Cart_Remove = New Windows.Forms.Button()
            panel18 = New Windows.Forms.Panel()
            LV_Cart = New Windows.Forms.ListView()
            LV_Sku = CType((New Windows.Forms.ColumnHeader()), Windows.Forms.ColumnHeader)
            LV_Pizza = CType((New Windows.Forms.ColumnHeader()), Windows.Forms.ColumnHeader)
            LV_Size = CType((New Windows.Forms.ColumnHeader()), Windows.Forms.ColumnHeader)
            LV_Crust = CType((New Windows.Forms.ColumnHeader()), Windows.Forms.ColumnHeader)
            LV_Toppings = CType((New Windows.Forms.ColumnHeader()), Windows.Forms.ColumnHeader)
            LV_Price = CType((New Windows.Forms.ColumnHeader()), Windows.Forms.ColumnHeader)
            label23 = New Windows.Forms.Label()
            PB_Order_Title = New Windows.Forms.PictureBox()
            panel1 = New Windows.Forms.Panel()
            PB_Order_Notify = New Windows.Forms.PictureBox()
            BTN_Nav_Order = New Windows.Forms.Button()
            BTN_Nav_Custom = New Windows.Forms.Button()
            BTN_Nav_Specialties = New Windows.Forms.Button()
            BTN_Nav_Menu = New Windows.Forms.Button()
            panel7 = New Windows.Forms.Panel()
            Lightup_Panel_Order = New Windows.Forms.Panel()
            Lightup_Panel_Custom = New Windows.Forms.Panel()
            Lightup_Panel_Specialties = New Windows.Forms.Panel()
            Lightup_Panel_Menu = New Windows.Forms.Panel()
            panel3 = New Windows.Forms.Panel()
            pictureBox1 = New Windows.Forms.PictureBox()
            panel2 = New Windows.Forms.Panel()
            panel6.SuspendLayout()
            CType(PB_Minimize, ComponentModel.ISupportInitialize).BeginInit()
            CType(PB_Exit, ComponentModel.ISupportInitialize).BeginInit()
            CType(PB_Maximize, ComponentModel.ISupportInitialize).BeginInit()
            panel5.SuspendLayout()
            TC_Navigation.SuspendLayout()
            TC_Tab_Menu.SuspendLayout()
            PNL_Pizza_Grid.SuspendLayout()
            PNL_Cheese.SuspendLayout()
            CType(PB_Cheese, ComponentModel.ISupportInitialize).BeginInit()
            PNL_Pepperoni.SuspendLayout()
            CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
            PNL_BBQ.SuspendLayout()
            CType(PB_BBQ, ComponentModel.ISupportInitialize).BeginInit()
            PNL_Supreme.SuspendLayout()
            CType(PB_Supreme, ComponentModel.ISupportInitialize).BeginInit()
            CType(PB_Menu_Title, ComponentModel.ISupportInitialize).BeginInit()
            TC_Tab_Specialties.SuspendLayout()
            tableLayoutPanel1.SuspendLayout()
            panel4.SuspendLayout()
            CType(pictureBox3, ComponentModel.ISupportInitialize).BeginInit()
            panel9.SuspendLayout()
            CType(pictureBox4, ComponentModel.ISupportInitialize).BeginInit()
            panel10.SuspendLayout()
            CType(pictureBox5, ComponentModel.ISupportInitialize).BeginInit()
            panel11.SuspendLayout()
            CType(pictureBox6, ComponentModel.ISupportInitialize).BeginInit()
            CType(PB_Specials_Title, ComponentModel.ISupportInitialize).BeginInit()
            TC_Tab_Custom.SuspendLayout()
            panel12.SuspendLayout()
            panel16.SuspendLayout()
            PNL_Olives_Cstm.SuspendLayout()
            CType(PB_Cstm_Olives_Whole, ComponentModel.ISupportInitialize).BeginInit()
            CType(PB_Cstm_Olives_R, ComponentModel.ISupportInitialize).BeginInit()
            CType(PB_Cstm_Olives_L, ComponentModel.ISupportInitialize).BeginInit()
            PNL_Onions_Cstm.SuspendLayout()
            CType(PB_Cstm_Onions_Whole, ComponentModel.ISupportInitialize).BeginInit()
            CType(PB_Cstm_Onions_R, ComponentModel.ISupportInitialize).BeginInit()
            CType(PB_Cstm_Onions_L, ComponentModel.ISupportInitialize).BeginInit()
            PNL_Mushrooms_Cstm.SuspendLayout()
            CType(PB_Cstm_Mushrooms_Whole, ComponentModel.ISupportInitialize).BeginInit()
            CType(PB_Cstm_Mushrooms_R, ComponentModel.ISupportInitialize).BeginInit()
            CType(PB_Cstm_Mushrooms_L, ComponentModel.ISupportInitialize).BeginInit()
            PNL_Bacon_Cstm.SuspendLayout()
            CType(PB_Cstm_Bacon_Whole, ComponentModel.ISupportInitialize).BeginInit()
            CType(PB_Cstm_Bacon_R, ComponentModel.ISupportInitialize).BeginInit()
            CType(PB_Cstm_Bacon_L, ComponentModel.ISupportInitialize).BeginInit()
            PNL_Ham_Cstm.SuspendLayout()
            CType(PB_Cstm_Ham_Whole, ComponentModel.ISupportInitialize).BeginInit()
            CType(PB_Cstm_Ham_R, ComponentModel.ISupportInitialize).BeginInit()
            CType(PB_Cstm_Ham_L, ComponentModel.ISupportInitialize).BeginInit()
            PNL_Sausage_Cstm.SuspendLayout()
            CType(PB_Cstm_Sausage_Whole, ComponentModel.ISupportInitialize).BeginInit()
            CType(PB_Cstm_Sausage_R, ComponentModel.ISupportInitialize).BeginInit()
            CType(PB_Cstm_Sausage_L, ComponentModel.ISupportInitialize).BeginInit()
            PNL_Pepperoni_Cstm.SuspendLayout()
            CType(PB_Cstm_Pepperoni_Whole, ComponentModel.ISupportInitialize).BeginInit()
            CType(PB_Cstm_Pepperoni_R, ComponentModel.ISupportInitialize).BeginInit()
            CType(PB_Cstm_Pepperoni_L, ComponentModel.ISupportInitialize).BeginInit()
            panel15.SuspendLayout()
            panel13.SuspendLayout()
            panel14.SuspendLayout()
            PNL_Custom_ImageHolder.SuspendLayout()
            CType(PB_Cstm_PizzaImg, ComponentModel.ISupportInitialize).BeginInit()
            CType(PB_Custom_Title, ComponentModel.ISupportInitialize).BeginInit()
            TC_Tab_Cart.SuspendLayout()
            panel17.SuspendLayout()
            panel19.SuspendLayout()
            panel18.SuspendLayout()
            CType(PB_Order_Title, ComponentModel.ISupportInitialize).BeginInit()
            panel1.SuspendLayout()
            CType(PB_Order_Notify, ComponentModel.ISupportInitialize).BeginInit()
            panel7.SuspendLayout()
            panel3.SuspendLayout()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            panel2.SuspendLayout()
            SuspendLayout()
            ' 
            ' panel6
            ' 
            panel6.Controls.Add(PB_Minimize)
            panel6.Controls.Add(PB_Exit)
            panel6.Controls.Add(PB_Maximize)
            panel6.Dock = Windows.Forms.DockStyle.Right
            panel6.Location = New Drawing.Point(1033, 0)
            panel6.Name = "panel6"
            panel6.Size = New Drawing.Size(93, 24)
            panel6.TabIndex = 1
            ' 
            ' PB_Minimize
            ' 
            PB_Minimize.BackColor = Drawing.Color.Transparent
            PB_Minimize.BackgroundImage = Global.PizzaShop.Properties.Resources.minimize_thin_white_16x16
            PB_Minimize.Location = New Drawing.Point(26, 4)
            PB_Minimize.Name = "PB_Minimize"
            PB_Minimize.Size = New Drawing.Size(16, 16)
            PB_Minimize.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            PB_Minimize.TabIndex = 0
            PB_Minimize.TabStop = False
            AddHandler PB_Minimize.Click, New EventHandler(AddressOf PB_Minimize_ClickEvent)
            AddHandler PB_Minimize.MouseEnter, New EventHandler(AddressOf PB_Minimize_MouseEnterEvent)
            AddHandler PB_Minimize.MouseLeave, New EventHandler(AddressOf PB_Minimize_MouseLeaveEvent)
            ' 
            ' PB_Exit
            ' 
            PB_Exit.BackColor = Drawing.Color.Transparent
            PB_Exit.BackgroundImage = CType(resources.GetObject("PB_Exit.BackgroundImage"), Drawing.Image)
            PB_Exit.BackgroundImageLayout = Windows.Forms.ImageLayout.Stretch
            PB_Exit.Location = New Drawing.Point(70, 4)
            PB_Exit.Name = "PB_Exit"
            PB_Exit.Size = New Drawing.Size(16, 16)
            PB_Exit.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Exit.TabIndex = 0
            PB_Exit.TabStop = False
            AddHandler PB_Exit.Click, New EventHandler(AddressOf PB_Exit_ClickEvent)
            AddHandler PB_Exit.MouseEnter, New EventHandler(AddressOf PB_Exit_MouseEnterEvent)
            AddHandler PB_Exit.MouseLeave, New EventHandler(AddressOf PB_Exit_MouseLeaveEvent)
            ' 
            ' PB_Maximize
            ' 
            PB_Maximize.BackColor = Drawing.Color.Transparent
            PB_Maximize.Image = Global.PizzaShop.Properties.Resources.maximize_active_white_16x16
            PB_Maximize.Location = New Drawing.Point(48, 4)
            PB_Maximize.Name = "PB_Maximize"
            PB_Maximize.Size = New Drawing.Size(16, 16)
            PB_Maximize.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            PB_Maximize.TabIndex = 0
            PB_Maximize.TabStop = False
            AddHandler PB_Maximize.Click, New EventHandler(AddressOf PB_Maximize_ClickEvent)
            AddHandler PB_Maximize.MouseEnter, New EventHandler(AddressOf PB_Maximize_MouseEnterEvent)
            AddHandler PB_Maximize.MouseLeave, New EventHandler(AddressOf PB_Maximize_MouseLeaveEvent)
            ' 
            ' panel5
            ' 
            panel5.Controls.Add(TC_Navigation)
            panel5.Controls.Add(panel1)
            panel5.Controls.Add(panel2)
            panel5.Dock = Windows.Forms.DockStyle.Fill
            panel5.Location = New Drawing.Point(0, 0)
            panel5.Name = "panel5"
            panel5.Size = New Drawing.Size(1126, 688)
            panel5.TabIndex = 4
            ' 
            ' TC_Navigation
            ' 
            TC_Navigation.Controls.Add(TC_Tab_Menu)
            TC_Navigation.Controls.Add(TC_Tab_Specialties)
            TC_Navigation.Controls.Add(TC_Tab_Custom)
            TC_Navigation.Controls.Add(TC_Tab_Cart)
            TC_Navigation.Depth = 0
            TC_Navigation.Dock = Windows.Forms.DockStyle.Fill
            TC_Navigation.Location = New Drawing.Point(156, 24)
            TC_Navigation.MouseState = MaterialSkin.MouseState.HOVER
            TC_Navigation.Name = "TC_Navigation"
            TC_Navigation.SelectedIndex = 0
            TC_Navigation.Size = New Drawing.Size(970, 664)
            TC_Navigation.TabIndex = 5
            ' 
            ' TC_Tab_Menu
            ' 
            TC_Tab_Menu.AutoScroll = True
            TC_Tab_Menu.BackColor = Drawing.Color.FromArgb(90, 109, 123)
            TC_Tab_Menu.Controls.Add(PNL_Pizza_Grid)
            TC_Tab_Menu.Controls.Add(LBL_Menu_Pizza)
            TC_Tab_Menu.Controls.Add(PB_Menu_Title)
            TC_Tab_Menu.ForeColor = Drawing.Color.White
            TC_Tab_Menu.Location = New Drawing.Point(4, 30)
            TC_Tab_Menu.Name = "TC_Tab_Menu"
            TC_Tab_Menu.Padding = New Windows.Forms.Padding(3)
            TC_Tab_Menu.Size = New Drawing.Size(962, 630)
            TC_Tab_Menu.TabIndex = 0
            TC_Tab_Menu.Text = "Menu"
            ' 
            ' PNL_Pizza_Grid
            ' 
            PNL_Pizza_Grid.BackColor = Drawing.Color.Transparent
            PNL_Pizza_Grid.ColumnCount = 2
            PNL_Pizza_Grid.ColumnStyles.Add(New Windows.Forms.ColumnStyle(Windows.Forms.SizeType.Percent, 50.0F))
            PNL_Pizza_Grid.ColumnStyles.Add(New Windows.Forms.ColumnStyle(Windows.Forms.SizeType.Percent, 50.0F))
            PNL_Pizza_Grid.Controls.Add(PNL_Cheese, 0, 0)
            PNL_Pizza_Grid.Controls.Add(PNL_Pepperoni, 1, 0)
            PNL_Pizza_Grid.Controls.Add(PNL_BBQ, 0, 1)
            PNL_Pizza_Grid.Controls.Add(PNL_Supreme, 1, 1)
            PNL_Pizza_Grid.Dock = Windows.Forms.DockStyle.Top
            PNL_Pizza_Grid.ForeColor = Drawing.Color.Black
            PNL_Pizza_Grid.Location = New Drawing.Point(3, 352)
            PNL_Pizza_Grid.Name = "PNL_Pizza_Grid"
            PNL_Pizza_Grid.RowCount = 2
            PNL_Pizza_Grid.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Percent, 50.0F))
            PNL_Pizza_Grid.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Percent, 50.0F))
            PNL_Pizza_Grid.Size = New Drawing.Size(939, 1202)
            PNL_Pizza_Grid.TabIndex = 2
            ' 
            ' PNL_Cheese
            ' 
            PNL_Cheese.Controls.Add(LBL_Cheese_Description)
            PNL_Cheese.Controls.Add(LBL_Cheese_Desc)
            PNL_Cheese.Controls.Add(LBL_Cheese_Price)
            PNL_Cheese.Controls.Add(BTN_Cheese_Order)
            PNL_Cheese.Controls.Add(LBL_Cheese_Subtotal)
            PNL_Cheese.Controls.Add(LBL_Cheese_Toppings)
            PNL_Cheese.Controls.Add(LBL_Cheese_Crust)
            PNL_Cheese.Controls.Add(LBL_Cheese_Size)
            PNL_Cheese.Controls.Add(LBL_Cheese_Options)
            PNL_Cheese.Controls.Add(CB_Cheese_Crust)
            PNL_Cheese.Controls.Add(CB_Cheese_Size)
            PNL_Cheese.Controls.Add(LBL_Cheese)
            PNL_Cheese.Controls.Add(PB_Cheese)
            PNL_Cheese.Controls.Add(CB_Cheese_Toppings)
            PNL_Cheese.Dock = Windows.Forms.DockStyle.Fill
            PNL_Cheese.Location = New Drawing.Point(3, 3)
            PNL_Cheese.Name = "PNL_Cheese"
            PNL_Cheese.Size = New Drawing.Size(463, 595)
            PNL_Cheese.TabIndex = 0
            ' 
            ' LBL_Cheese_Description
            ' 
            LBL_Cheese_Description.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            LBL_Cheese_Description.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            LBL_Cheese_Description.Location = New Drawing.Point(76, 263)
            LBL_Cheese_Description.Name = "LBL_Cheese_Description"
            LBL_Cheese_Description.Size = New Drawing.Size(344, 93)
            LBL_Cheese_Description.TabIndex = 14
            LBL_Cheese_Description.Text = "Your favorite cheese pizza made with classic marinara sauce topped with mozzarell" & "a cheese. When it comes to America's best, think Catterina's."
            LBL_Cheese_Description.TextAlign = Drawing.ContentAlignment.TopCenter
            ' 
            ' LBL_Cheese_Desc
            ' 
            LBL_Cheese_Desc.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            LBL_Cheese_Desc.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            LBL_Cheese_Desc.Location = New Drawing.Point(119, 218)
            LBL_Cheese_Desc.Name = "LBL_Cheese_Desc"
            LBL_Cheese_Desc.Size = New Drawing.Size(263, 41)
            LBL_Cheese_Desc.TabIndex = 13
            LBL_Cheese_Desc.Text = "- Description -"
            LBL_Cheese_Desc.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' LBL_Cheese_Price
            ' 
            LBL_Cheese_Price.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Cheese_Price.Location = New Drawing.Point(252, 502)
            LBL_Cheese_Price.Name = "LBL_Cheese_Price"
            LBL_Cheese_Price.Size = New Drawing.Size(168, 25)
            LBL_Cheese_Price.TabIndex = 12
            LBL_Cheese_Price.Text = "$0.00"
            LBL_Cheese_Price.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' BTN_Cheese_Order
            ' 
            BTN_Cheese_Order.Anchor = Windows.Forms.AnchorStyles.Top
            BTN_Cheese_Order.BackColor = Drawing.Color.FromArgb(52, 73, 94)
            BTN_Cheese_Order.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(44, 62, 80)
            BTN_Cheese_Order.FlatStyle = Windows.Forms.FlatStyle.Flat
            BTN_Cheese_Order.Location = New Drawing.Point(252, 542)
            BTN_Cheese_Order.Name = "BTN_Cheese_Order"
            BTN_Cheese_Order.Size = New Drawing.Size(168, 40)
            BTN_Cheese_Order.TabIndex = 7
            BTN_Cheese_Order.Text = "Order Now"
            BTN_Cheese_Order.UseVisualStyleBackColor = False
            AddHandler BTN_Cheese_Order.Click, New EventHandler(AddressOf BTN_Cheese_Order_Click)
            AddHandler BTN_Cheese_Order.MouseEnter, New EventHandler(AddressOf BTN_Order_MouseEnter)
            AddHandler BTN_Cheese_Order.MouseLeave, New EventHandler(AddressOf BTN_Order_MouseLeave)
            ' 
            ' LBL_Cheese_Subtotal
            ' 
            LBL_Cheese_Subtotal.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Cheese_Subtotal.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Underline, Drawing.GraphicsUnit.Point, 0)
            LBL_Cheese_Subtotal.Location = New Drawing.Point(115, 502)
            LBL_Cheese_Subtotal.Name = "LBL_Cheese_Subtotal"
            LBL_Cheese_Subtotal.Size = New Drawing.Size(131, 25)
            LBL_Cheese_Subtotal.TabIndex = 11
            LBL_Cheese_Subtotal.Text = "Subtotal: "
            LBL_Cheese_Subtotal.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' LBL_Cheese_Toppings
            ' 
            LBL_Cheese_Toppings.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Cheese_Toppings.Location = New Drawing.Point(115, 461)
            LBL_Cheese_Toppings.Name = "LBL_Cheese_Toppings"
            LBL_Cheese_Toppings.Size = New Drawing.Size(131, 25)
            LBL_Cheese_Toppings.TabIndex = 10
            LBL_Cheese_Toppings.Text = "Toppings: "
            LBL_Cheese_Toppings.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' LBL_Cheese_Crust
            ' 
            LBL_Cheese_Crust.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Cheese_Crust.Location = New Drawing.Point(115, 430)
            LBL_Cheese_Crust.Name = "LBL_Cheese_Crust"
            LBL_Cheese_Crust.Size = New Drawing.Size(131, 25)
            LBL_Cheese_Crust.TabIndex = 9
            LBL_Cheese_Crust.Text = "Crust: "
            LBL_Cheese_Crust.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' LBL_Cheese_Size
            ' 
            LBL_Cheese_Size.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Cheese_Size.Location = New Drawing.Point(119, 399)
            LBL_Cheese_Size.Name = "LBL_Cheese_Size"
            LBL_Cheese_Size.Size = New Drawing.Size(127, 25)
            LBL_Cheese_Size.TabIndex = 8
            LBL_Cheese_Size.Text = "Size: "
            LBL_Cheese_Size.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' LBL_Cheese_Options
            ' 
            LBL_Cheese_Options.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            LBL_Cheese_Options.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            LBL_Cheese_Options.Location = New Drawing.Point(119, 356)
            LBL_Cheese_Options.Name = "LBL_Cheese_Options"
            LBL_Cheese_Options.Size = New Drawing.Size(263, 41)
            LBL_Cheese_Options.TabIndex = 6
            LBL_Cheese_Options.Text = "- Options -"
            LBL_Cheese_Options.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' CB_Cheese_Crust
            ' 
            CB_Cheese_Crust.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Cheese_Crust.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Cheese_Crust.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Cheese_Crust.FormattingEnabled = True
            CB_Cheese_Crust.Items.AddRange(New Object() {"Hand Tossed - $0.00", "Thin 'n Crispy - $0.00", "Original Pan - $0.99", "Stuffed Crust - $1.99"})
            CB_Cheese_Crust.Location = New Drawing.Point(252, 430)
            CB_Cheese_Crust.Name = "CB_Cheese_Crust"
            CB_Cheese_Crust.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Cheese_Crust.Size = New Drawing.Size(168, 25)
            CB_Cheese_Crust.TabIndex = 5
            CB_Cheese_Crust.Text = "- Crust -"
            AddHandler CB_Cheese_Crust.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' CB_Cheese_Size
            ' 
            CB_Cheese_Size.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Cheese_Size.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Cheese_Size.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Cheese_Size.FormattingEnabled = True
            CB_Cheese_Size.Items.AddRange(New Object() {"Small - $7.99", "Medium - $9.99", "Large - $ 11.99"})
            CB_Cheese_Size.Location = New Drawing.Point(252, 399)
            CB_Cheese_Size.Name = "CB_Cheese_Size"
            CB_Cheese_Size.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Cheese_Size.Size = New Drawing.Size(168, 25)
            CB_Cheese_Size.TabIndex = 4
            CB_Cheese_Size.Text = "- Size -"
            AddHandler CB_Cheese_Size.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' LBL_Cheese
            ' 
            LBL_Cheese.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            LBL_Cheese.Font = New Drawing.Font("Century Gothic", 15.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            LBL_Cheese.ForeColor = Drawing.Color.Black
            LBL_Cheese.Location = New Drawing.Point(119, 0)
            LBL_Cheese.Name = "LBL_Cheese"
            LBL_Cheese.Size = New Drawing.Size(263, 51)
            LBL_Cheese.TabIndex = 3
            LBL_Cheese.Text = "Cheese"
            LBL_Cheese.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' PB_Cheese
            ' 
            PB_Cheese.Anchor = Windows.Forms.AnchorStyles.Top
            PB_Cheese.Image = Global.PizzaShop.Properties.Resources.cheese_pizza
            PB_Cheese.Location = New Drawing.Point(119, 51)
            PB_Cheese.Name = "PB_Cheese"
            PB_Cheese.Size = New Drawing.Size(263, 164)
            PB_Cheese.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            PB_Cheese.TabIndex = 2
            PB_Cheese.TabStop = False
            ' 
            ' CB_Cheese_Toppings
            ' 
            CB_Cheese_Toppings.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Cheese_Toppings.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Cheese_Toppings.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Cheese_Toppings.FormattingEnabled = True
            CB_Cheese_Toppings.Items.AddRange(New Object() {"Regular - $0.00", "More - $0.99", "Much More - $1.99"})
            CB_Cheese_Toppings.Location = New Drawing.Point(252, 461)
            CB_Cheese_Toppings.Name = "CB_Cheese_Toppings"
            CB_Cheese_Toppings.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Cheese_Toppings.Size = New Drawing.Size(168, 25)
            CB_Cheese_Toppings.TabIndex = 1
            CB_Cheese_Toppings.Text = "- Toppings -"
            AddHandler CB_Cheese_Toppings.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' PNL_Pepperoni
            ' 
            PNL_Pepperoni.Controls.Add(label3)
            PNL_Pepperoni.Controls.Add(LBL_Pepperoni_Desc)
            PNL_Pepperoni.Controls.Add(LBL_Pepperoni_Price)
            PNL_Pepperoni.Controls.Add(BTN_Pepperoni_Order)
            PNL_Pepperoni.Controls.Add(LBL_Pepperoni_Subtotal)
            PNL_Pepperoni.Controls.Add(LBL_Pepperoni_Toppings)
            PNL_Pepperoni.Controls.Add(LBL_Pepperoni_Crust)
            PNL_Pepperoni.Controls.Add(LBL_Pepperoni_Size)
            PNL_Pepperoni.Controls.Add(LBL_Pepperoni_Options)
            PNL_Pepperoni.Controls.Add(CB_Pepperoni_Crust)
            PNL_Pepperoni.Controls.Add(CB_Pepperoni_Size)
            PNL_Pepperoni.Controls.Add(LBL_Pepperoni)
            PNL_Pepperoni.Controls.Add(pictureBox2)
            PNL_Pepperoni.Controls.Add(CB_Pepperoni_Toppings)
            PNL_Pepperoni.Dock = Windows.Forms.DockStyle.Fill
            PNL_Pepperoni.Location = New Drawing.Point(472, 3)
            PNL_Pepperoni.Name = "PNL_Pepperoni"
            PNL_Pepperoni.Size = New Drawing.Size(464, 595)
            PNL_Pepperoni.TabIndex = 1
            ' 
            ' label3
            ' 
            label3.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            label3.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label3.Location = New Drawing.Point(61, 263)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(344, 93)
            label3.TabIndex = 27
            label3.Text = resources.GetString("label3.Text")
            label3.TextAlign = Drawing.ContentAlignment.TopCenter
            ' 
            ' LBL_Pepperoni_Desc
            ' 
            LBL_Pepperoni_Desc.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            LBL_Pepperoni_Desc.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            LBL_Pepperoni_Desc.Location = New Drawing.Point(103, 224)
            LBL_Pepperoni_Desc.Name = "LBL_Pepperoni_Desc"
            LBL_Pepperoni_Desc.Size = New Drawing.Size(263, 41)
            LBL_Pepperoni_Desc.TabIndex = 26
            LBL_Pepperoni_Desc.Text = "- Description -"
            LBL_Pepperoni_Desc.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' LBL_Pepperoni_Price
            ' 
            LBL_Pepperoni_Price.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Pepperoni_Price.Location = New Drawing.Point(236, 502)
            LBL_Pepperoni_Price.Name = "LBL_Pepperoni_Price"
            LBL_Pepperoni_Price.Size = New Drawing.Size(169, 25)
            LBL_Pepperoni_Price.TabIndex = 24
            LBL_Pepperoni_Price.Text = "$0.00"
            LBL_Pepperoni_Price.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' BTN_Pepperoni_Order
            ' 
            BTN_Pepperoni_Order.Anchor = Windows.Forms.AnchorStyles.Top
            BTN_Pepperoni_Order.BackColor = Drawing.Color.FromArgb(52, 73, 94)
            BTN_Pepperoni_Order.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(44, 62, 80)
            BTN_Pepperoni_Order.FlatStyle = Windows.Forms.FlatStyle.Flat
            BTN_Pepperoni_Order.Location = New Drawing.Point(236, 542)
            BTN_Pepperoni_Order.Name = "BTN_Pepperoni_Order"
            BTN_Pepperoni_Order.Size = New Drawing.Size(169, 40)
            BTN_Pepperoni_Order.TabIndex = 19
            BTN_Pepperoni_Order.Text = "Order Now"
            BTN_Pepperoni_Order.UseVisualStyleBackColor = False
            AddHandler BTN_Pepperoni_Order.Click, New EventHandler(AddressOf BTN_Pepperoni_Order_Click)
            AddHandler BTN_Pepperoni_Order.MouseEnter, New EventHandler(AddressOf BTN_Order_MouseEnter)
            AddHandler BTN_Pepperoni_Order.MouseLeave, New EventHandler(AddressOf BTN_Order_MouseLeave)
            ' 
            ' LBL_Pepperoni_Subtotal
            ' 
            LBL_Pepperoni_Subtotal.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Pepperoni_Subtotal.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Underline, Drawing.GraphicsUnit.Point, 0)
            LBL_Pepperoni_Subtotal.Location = New Drawing.Point(99, 502)
            LBL_Pepperoni_Subtotal.Name = "LBL_Pepperoni_Subtotal"
            LBL_Pepperoni_Subtotal.Size = New Drawing.Size(131, 25)
            LBL_Pepperoni_Subtotal.TabIndex = 23
            LBL_Pepperoni_Subtotal.Text = "Subtotal: "
            LBL_Pepperoni_Subtotal.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' LBL_Pepperoni_Toppings
            ' 
            LBL_Pepperoni_Toppings.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Pepperoni_Toppings.Location = New Drawing.Point(99, 461)
            LBL_Pepperoni_Toppings.Name = "LBL_Pepperoni_Toppings"
            LBL_Pepperoni_Toppings.Size = New Drawing.Size(131, 25)
            LBL_Pepperoni_Toppings.TabIndex = 22
            LBL_Pepperoni_Toppings.Text = "Toppings: "
            LBL_Pepperoni_Toppings.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' LBL_Pepperoni_Crust
            ' 
            LBL_Pepperoni_Crust.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Pepperoni_Crust.Location = New Drawing.Point(99, 430)
            LBL_Pepperoni_Crust.Name = "LBL_Pepperoni_Crust"
            LBL_Pepperoni_Crust.Size = New Drawing.Size(131, 25)
            LBL_Pepperoni_Crust.TabIndex = 21
            LBL_Pepperoni_Crust.Text = "Crust: "
            LBL_Pepperoni_Crust.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' LBL_Pepperoni_Size
            ' 
            LBL_Pepperoni_Size.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Pepperoni_Size.Location = New Drawing.Point(103, 399)
            LBL_Pepperoni_Size.Name = "LBL_Pepperoni_Size"
            LBL_Pepperoni_Size.Size = New Drawing.Size(127, 25)
            LBL_Pepperoni_Size.TabIndex = 20
            LBL_Pepperoni_Size.Text = "Size: "
            LBL_Pepperoni_Size.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' LBL_Pepperoni_Options
            ' 
            LBL_Pepperoni_Options.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            LBL_Pepperoni_Options.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            LBL_Pepperoni_Options.Location = New Drawing.Point(103, 356)
            LBL_Pepperoni_Options.Name = "LBL_Pepperoni_Options"
            LBL_Pepperoni_Options.Size = New Drawing.Size(263, 41)
            LBL_Pepperoni_Options.TabIndex = 18
            LBL_Pepperoni_Options.Text = "- Options -"
            LBL_Pepperoni_Options.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' CB_Pepperoni_Crust
            ' 
            CB_Pepperoni_Crust.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Pepperoni_Crust.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Pepperoni_Crust.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Pepperoni_Crust.FormattingEnabled = True
            CB_Pepperoni_Crust.Items.AddRange(New Object() {"Hand Tossed - $0.00", "Thin 'n Crispy - $0.00", "Original Pan - $0.99", "Stuffed Crust - $1.99"})
            CB_Pepperoni_Crust.Location = New Drawing.Point(236, 430)
            CB_Pepperoni_Crust.Name = "CB_Pepperoni_Crust"
            CB_Pepperoni_Crust.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Pepperoni_Crust.Size = New Drawing.Size(169, 25)
            CB_Pepperoni_Crust.TabIndex = 17
            CB_Pepperoni_Crust.Text = "- Crust -"
            AddHandler CB_Pepperoni_Crust.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' CB_Pepperoni_Size
            ' 
            CB_Pepperoni_Size.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Pepperoni_Size.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Pepperoni_Size.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Pepperoni_Size.FormattingEnabled = True
            CB_Pepperoni_Size.Items.AddRange(New Object() {"Small - $8.99", "Medium - $10.99", "Large - $ 12.99"})
            CB_Pepperoni_Size.Location = New Drawing.Point(236, 399)
            CB_Pepperoni_Size.Name = "CB_Pepperoni_Size"
            CB_Pepperoni_Size.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Pepperoni_Size.Size = New Drawing.Size(169, 25)
            CB_Pepperoni_Size.TabIndex = 16
            CB_Pepperoni_Size.Text = "- Size -"
            AddHandler CB_Pepperoni_Size.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' LBL_Pepperoni
            ' 
            LBL_Pepperoni.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            LBL_Pepperoni.Font = New Drawing.Font("Century Gothic", 15.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            LBL_Pepperoni.ForeColor = Drawing.Color.Black
            LBL_Pepperoni.Location = New Drawing.Point(103, 6)
            LBL_Pepperoni.Name = "LBL_Pepperoni"
            LBL_Pepperoni.Size = New Drawing.Size(263, 51)
            LBL_Pepperoni.TabIndex = 15
            LBL_Pepperoni.Text = "Pepperoni"
            LBL_Pepperoni.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' pictureBox2
            ' 
            pictureBox2.Anchor = Windows.Forms.AnchorStyles.Top
            pictureBox2.Image = Global.PizzaShop.Properties.Resources.pepperoni_pizza
            pictureBox2.Location = New Drawing.Point(103, 57)
            pictureBox2.Name = "pictureBox2"
            pictureBox2.Size = New Drawing.Size(263, 164)
            pictureBox2.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox2.TabIndex = 14
            pictureBox2.TabStop = False
            ' 
            ' CB_Pepperoni_Toppings
            ' 
            CB_Pepperoni_Toppings.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Pepperoni_Toppings.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Pepperoni_Toppings.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Pepperoni_Toppings.FormattingEnabled = True
            CB_Pepperoni_Toppings.Items.AddRange(New Object() {"Regular - $0.00", "More - $0.99", "Much More - $1.99"})
            CB_Pepperoni_Toppings.Location = New Drawing.Point(236, 461)
            CB_Pepperoni_Toppings.Name = "CB_Pepperoni_Toppings"
            CB_Pepperoni_Toppings.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Pepperoni_Toppings.Size = New Drawing.Size(169, 25)
            CB_Pepperoni_Toppings.TabIndex = 13
            CB_Pepperoni_Toppings.Text = "- Toppings -"
            AddHandler CB_Pepperoni_Toppings.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' PNL_BBQ
            ' 
            PNL_BBQ.Controls.Add(LBL_BBQ_Description)
            PNL_BBQ.Controls.Add(LBL_BBQ_Desc)
            PNL_BBQ.Controls.Add(LBL_BBQ_Price)
            PNL_BBQ.Controls.Add(BTN_BBQ_Order)
            PNL_BBQ.Controls.Add(LBL_BBQ_Subtotal)
            PNL_BBQ.Controls.Add(LBL_BBQ_Toppings)
            PNL_BBQ.Controls.Add(LBL_BBQ_Crust)
            PNL_BBQ.Controls.Add(LBL_BBQ_Size)
            PNL_BBQ.Controls.Add(LBL_BBQ_Options)
            PNL_BBQ.Controls.Add(CB_BBQ_Crust)
            PNL_BBQ.Controls.Add(CB_BBQ_Size)
            PNL_BBQ.Controls.Add(LBL_BBQ)
            PNL_BBQ.Controls.Add(PB_BBQ)
            PNL_BBQ.Controls.Add(CB_BBQ_Toppings)
            PNL_BBQ.Dock = Windows.Forms.DockStyle.Fill
            PNL_BBQ.Location = New Drawing.Point(3, 604)
            PNL_BBQ.Name = "PNL_BBQ"
            PNL_BBQ.Size = New Drawing.Size(463, 595)
            PNL_BBQ.TabIndex = 2
            ' 
            ' LBL_BBQ_Description
            ' 
            LBL_BBQ_Description.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            LBL_BBQ_Description.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            LBL_BBQ_Description.Location = New Drawing.Point(79, 265)
            LBL_BBQ_Description.Name = "LBL_BBQ_Description"
            LBL_BBQ_Description.Size = New Drawing.Size(341, 83)
            LBL_BBQ_Description.TabIndex = 26
            LBL_BBQ_Description.Text = "A BBQ pizza topped with grilled chicken, bacon and red onion? Sign us up! This ov" & "en-hot pizza is also perfect for a group lunch or home delivery this Friday nigh" & "t."
            LBL_BBQ_Description.TextAlign = Drawing.ContentAlignment.TopCenter
            ' 
            ' LBL_BBQ_Desc
            ' 
            LBL_BBQ_Desc.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            LBL_BBQ_Desc.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            LBL_BBQ_Desc.Location = New Drawing.Point(102, 224)
            LBL_BBQ_Desc.Name = "LBL_BBQ_Desc"
            LBL_BBQ_Desc.Size = New Drawing.Size(263, 41)
            LBL_BBQ_Desc.TabIndex = 25
            LBL_BBQ_Desc.Text = "- Description -"
            LBL_BBQ_Desc.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' LBL_BBQ_Price
            ' 
            LBL_BBQ_Price.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_BBQ_Price.Location = New Drawing.Point(235, 494)
            LBL_BBQ_Price.Name = "LBL_BBQ_Price"
            LBL_BBQ_Price.Size = New Drawing.Size(185, 25)
            LBL_BBQ_Price.TabIndex = 24
            LBL_BBQ_Price.Text = "$0.00"
            LBL_BBQ_Price.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' BTN_BBQ_Order
            ' 
            BTN_BBQ_Order.Anchor = Windows.Forms.AnchorStyles.Top
            BTN_BBQ_Order.BackColor = Drawing.Color.FromArgb(52, 73, 94)
            BTN_BBQ_Order.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(44, 62, 80)
            BTN_BBQ_Order.FlatStyle = Windows.Forms.FlatStyle.Flat
            BTN_BBQ_Order.Location = New Drawing.Point(235, 534)
            BTN_BBQ_Order.Name = "BTN_BBQ_Order"
            BTN_BBQ_Order.Size = New Drawing.Size(185, 40)
            BTN_BBQ_Order.TabIndex = 19
            BTN_BBQ_Order.Text = "Order Now"
            BTN_BBQ_Order.UseVisualStyleBackColor = False
            AddHandler BTN_BBQ_Order.Click, New EventHandler(AddressOf BTN_BBQ_Order_Click)
            AddHandler BTN_BBQ_Order.MouseEnter, New EventHandler(AddressOf BTN_Order_MouseEnter)
            AddHandler BTN_BBQ_Order.MouseLeave, New EventHandler(AddressOf BTN_Order_MouseLeave)
            ' 
            ' LBL_BBQ_Subtotal
            ' 
            LBL_BBQ_Subtotal.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_BBQ_Subtotal.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Underline, Drawing.GraphicsUnit.Point, 0)
            LBL_BBQ_Subtotal.Location = New Drawing.Point(98, 494)
            LBL_BBQ_Subtotal.Name = "LBL_BBQ_Subtotal"
            LBL_BBQ_Subtotal.Size = New Drawing.Size(131, 25)
            LBL_BBQ_Subtotal.TabIndex = 23
            LBL_BBQ_Subtotal.Text = "Subtotal: "
            LBL_BBQ_Subtotal.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' LBL_BBQ_Toppings
            ' 
            LBL_BBQ_Toppings.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_BBQ_Toppings.Location = New Drawing.Point(98, 453)
            LBL_BBQ_Toppings.Name = "LBL_BBQ_Toppings"
            LBL_BBQ_Toppings.Size = New Drawing.Size(131, 25)
            LBL_BBQ_Toppings.TabIndex = 22
            LBL_BBQ_Toppings.Text = "Toppings: "
            LBL_BBQ_Toppings.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' LBL_BBQ_Crust
            ' 
            LBL_BBQ_Crust.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_BBQ_Crust.Location = New Drawing.Point(98, 422)
            LBL_BBQ_Crust.Name = "LBL_BBQ_Crust"
            LBL_BBQ_Crust.Size = New Drawing.Size(131, 25)
            LBL_BBQ_Crust.TabIndex = 21
            LBL_BBQ_Crust.Text = "Crust: "
            LBL_BBQ_Crust.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' LBL_BBQ_Size
            ' 
            LBL_BBQ_Size.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_BBQ_Size.Location = New Drawing.Point(102, 391)
            LBL_BBQ_Size.Name = "LBL_BBQ_Size"
            LBL_BBQ_Size.Size = New Drawing.Size(127, 25)
            LBL_BBQ_Size.TabIndex = 20
            LBL_BBQ_Size.Text = "Size: "
            LBL_BBQ_Size.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' LBL_BBQ_Options
            ' 
            LBL_BBQ_Options.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            LBL_BBQ_Options.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            LBL_BBQ_Options.Location = New Drawing.Point(102, 348)
            LBL_BBQ_Options.Name = "LBL_BBQ_Options"
            LBL_BBQ_Options.Size = New Drawing.Size(263, 41)
            LBL_BBQ_Options.TabIndex = 18
            LBL_BBQ_Options.Text = "- Options -"
            LBL_BBQ_Options.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' CB_BBQ_Crust
            ' 
            CB_BBQ_Crust.Anchor = Windows.Forms.AnchorStyles.Top
            CB_BBQ_Crust.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_BBQ_Crust.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_BBQ_Crust.FormattingEnabled = True
            CB_BBQ_Crust.Items.AddRange(New Object() {"Hand Tossed - $0.00", "Thin 'n Crispy - $0.00", "Original Pan - $0.99", "Stuffed Crust - $1.99"})
            CB_BBQ_Crust.Location = New Drawing.Point(235, 422)
            CB_BBQ_Crust.Name = "CB_BBQ_Crust"
            CB_BBQ_Crust.RightToLeft = Windows.Forms.RightToLeft.No
            CB_BBQ_Crust.Size = New Drawing.Size(185, 25)
            CB_BBQ_Crust.TabIndex = 17
            CB_BBQ_Crust.Text = "- Crust -"
            AddHandler CB_BBQ_Crust.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' CB_BBQ_Size
            ' 
            CB_BBQ_Size.Anchor = Windows.Forms.AnchorStyles.Top
            CB_BBQ_Size.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_BBQ_Size.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_BBQ_Size.FormattingEnabled = True
            CB_BBQ_Size.Items.AddRange(New Object() {"Small - $8.99", "Medium - $10.99", "Large - $ 12.99"})
            CB_BBQ_Size.Location = New Drawing.Point(235, 391)
            CB_BBQ_Size.Name = "CB_BBQ_Size"
            CB_BBQ_Size.RightToLeft = Windows.Forms.RightToLeft.No
            CB_BBQ_Size.Size = New Drawing.Size(185, 25)
            CB_BBQ_Size.TabIndex = 16
            CB_BBQ_Size.Text = "- Size -"
            AddHandler CB_BBQ_Size.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' LBL_BBQ
            ' 
            LBL_BBQ.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            LBL_BBQ.Font = New Drawing.Font("Century Gothic", 15.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            LBL_BBQ.ForeColor = Drawing.Color.Black
            LBL_BBQ.Location = New Drawing.Point(102, 6)
            LBL_BBQ.Name = "LBL_BBQ"
            LBL_BBQ.Size = New Drawing.Size(263, 51)
            LBL_BBQ.TabIndex = 15
            LBL_BBQ.Text = "BBQ Chicken"
            LBL_BBQ.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' PB_BBQ
            ' 
            PB_BBQ.Anchor = Windows.Forms.AnchorStyles.Top
            PB_BBQ.Image = CType(resources.GetObject("PB_BBQ.Image"), Drawing.Image)
            PB_BBQ.Location = New Drawing.Point(102, 57)
            PB_BBQ.Name = "PB_BBQ"
            PB_BBQ.Size = New Drawing.Size(263, 164)
            PB_BBQ.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            PB_BBQ.TabIndex = 14
            PB_BBQ.TabStop = False
            ' 
            ' CB_BBQ_Toppings
            ' 
            CB_BBQ_Toppings.Anchor = Windows.Forms.AnchorStyles.Top
            CB_BBQ_Toppings.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_BBQ_Toppings.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_BBQ_Toppings.FormattingEnabled = True
            CB_BBQ_Toppings.Items.AddRange(New Object() {"Regular - $0.00", "More - $0.99", "Much More - $1.99"})
            CB_BBQ_Toppings.Location = New Drawing.Point(235, 453)
            CB_BBQ_Toppings.Name = "CB_BBQ_Toppings"
            CB_BBQ_Toppings.RightToLeft = Windows.Forms.RightToLeft.No
            CB_BBQ_Toppings.Size = New Drawing.Size(185, 25)
            CB_BBQ_Toppings.TabIndex = 13
            CB_BBQ_Toppings.Text = "- Toppings -"
            AddHandler CB_BBQ_Toppings.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' PNL_Supreme
            ' 
            PNL_Supreme.Controls.Add(LBL_Supreme_Description)
            PNL_Supreme.Controls.Add(LBL_Supreme_Desc)
            PNL_Supreme.Controls.Add(LBL_Supreme_Price)
            PNL_Supreme.Controls.Add(BTN_Supreme_Order)
            PNL_Supreme.Controls.Add(LBL_Supreme_Subtotal)
            PNL_Supreme.Controls.Add(LBL_Supreme_Toppings)
            PNL_Supreme.Controls.Add(LBL_Supreme_Crust)
            PNL_Supreme.Controls.Add(LBL_Supreme_Size)
            PNL_Supreme.Controls.Add(LBL_Supreme_Options)
            PNL_Supreme.Controls.Add(CB_Supreme_Crust)
            PNL_Supreme.Controls.Add(CB_Supreme_Size)
            PNL_Supreme.Controls.Add(LBL_Supreme)
            PNL_Supreme.Controls.Add(PB_Supreme)
            PNL_Supreme.Controls.Add(CB_Supreme_Toppings)
            PNL_Supreme.Dock = Windows.Forms.DockStyle.Fill
            PNL_Supreme.Location = New Drawing.Point(472, 604)
            PNL_Supreme.Name = "PNL_Supreme"
            PNL_Supreme.Size = New Drawing.Size(464, 595)
            PNL_Supreme.TabIndex = 3
            ' 
            ' LBL_Supreme_Description
            ' 
            LBL_Supreme_Description.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            LBL_Supreme_Description.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            LBL_Supreme_Description.Location = New Drawing.Point(61, 265)
            LBL_Supreme_Description.Name = "LBL_Supreme_Description"
            LBL_Supreme_Description.Size = New Drawing.Size(341, 83)
            LBL_Supreme_Description.TabIndex = 26
            LBL_Supreme_Description.Text = "Featuring all the classic vegetable toppings you know and love—like mushrooms, re" & "d onions, green bell peppers, Roma tomatoes and black olives—this veggie pizza a" & " garden lover's dream!"
            LBL_Supreme_Description.TextAlign = Drawing.ContentAlignment.TopCenter
            ' 
            ' LBL_Supreme_Desc
            ' 
            LBL_Supreme_Desc.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            LBL_Supreme_Desc.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            LBL_Supreme_Desc.Location = New Drawing.Point(103, 224)
            LBL_Supreme_Desc.Name = "LBL_Supreme_Desc"
            LBL_Supreme_Desc.Size = New Drawing.Size(263, 41)
            LBL_Supreme_Desc.TabIndex = 25
            LBL_Supreme_Desc.Text = "- Description -"
            LBL_Supreme_Desc.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' LBL_Supreme_Price
            ' 
            LBL_Supreme_Price.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Supreme_Price.Location = New Drawing.Point(236, 494)
            LBL_Supreme_Price.Name = "LBL_Supreme_Price"
            LBL_Supreme_Price.Size = New Drawing.Size(169, 25)
            LBL_Supreme_Price.TabIndex = 24
            LBL_Supreme_Price.Text = "$0.00"
            LBL_Supreme_Price.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' BTN_Supreme_Order
            ' 
            BTN_Supreme_Order.Anchor = Windows.Forms.AnchorStyles.Top
            BTN_Supreme_Order.BackColor = Drawing.Color.FromArgb(52, 73, 94)
            BTN_Supreme_Order.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(44, 62, 80)
            BTN_Supreme_Order.FlatStyle = Windows.Forms.FlatStyle.Flat
            BTN_Supreme_Order.Location = New Drawing.Point(236, 534)
            BTN_Supreme_Order.Name = "BTN_Supreme_Order"
            BTN_Supreme_Order.Size = New Drawing.Size(169, 40)
            BTN_Supreme_Order.TabIndex = 19
            BTN_Supreme_Order.Text = "Order Now"
            BTN_Supreme_Order.UseVisualStyleBackColor = False
            AddHandler BTN_Supreme_Order.Click, New EventHandler(AddressOf BTN_Supreme_Order_Click)
            AddHandler BTN_Supreme_Order.MouseEnter, New EventHandler(AddressOf BTN_Order_MouseEnter)
            AddHandler BTN_Supreme_Order.MouseLeave, New EventHandler(AddressOf BTN_Order_MouseLeave)
            ' 
            ' LBL_Supreme_Subtotal
            ' 
            LBL_Supreme_Subtotal.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Supreme_Subtotal.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Underline, Drawing.GraphicsUnit.Point, 0)
            LBL_Supreme_Subtotal.Location = New Drawing.Point(99, 494)
            LBL_Supreme_Subtotal.Name = "LBL_Supreme_Subtotal"
            LBL_Supreme_Subtotal.Size = New Drawing.Size(131, 25)
            LBL_Supreme_Subtotal.TabIndex = 23
            LBL_Supreme_Subtotal.Text = "Subtotal: "
            LBL_Supreme_Subtotal.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' LBL_Supreme_Toppings
            ' 
            LBL_Supreme_Toppings.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Supreme_Toppings.Location = New Drawing.Point(99, 453)
            LBL_Supreme_Toppings.Name = "LBL_Supreme_Toppings"
            LBL_Supreme_Toppings.Size = New Drawing.Size(131, 25)
            LBL_Supreme_Toppings.TabIndex = 22
            LBL_Supreme_Toppings.Text = "Toppings: "
            LBL_Supreme_Toppings.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' LBL_Supreme_Crust
            ' 
            LBL_Supreme_Crust.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Supreme_Crust.Location = New Drawing.Point(99, 422)
            LBL_Supreme_Crust.Name = "LBL_Supreme_Crust"
            LBL_Supreme_Crust.Size = New Drawing.Size(131, 25)
            LBL_Supreme_Crust.TabIndex = 21
            LBL_Supreme_Crust.Text = "Crust: "
            LBL_Supreme_Crust.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' LBL_Supreme_Size
            ' 
            LBL_Supreme_Size.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Supreme_Size.Location = New Drawing.Point(103, 391)
            LBL_Supreme_Size.Name = "LBL_Supreme_Size"
            LBL_Supreme_Size.Size = New Drawing.Size(127, 25)
            LBL_Supreme_Size.TabIndex = 20
            LBL_Supreme_Size.Text = "Size: "
            LBL_Supreme_Size.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' LBL_Supreme_Options
            ' 
            LBL_Supreme_Options.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            LBL_Supreme_Options.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            LBL_Supreme_Options.Location = New Drawing.Point(103, 348)
            LBL_Supreme_Options.Name = "LBL_Supreme_Options"
            LBL_Supreme_Options.Size = New Drawing.Size(263, 41)
            LBL_Supreme_Options.TabIndex = 18
            LBL_Supreme_Options.Text = "- Options -"
            LBL_Supreme_Options.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' CB_Supreme_Crust
            ' 
            CB_Supreme_Crust.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Supreme_Crust.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Supreme_Crust.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Supreme_Crust.FormattingEnabled = True
            CB_Supreme_Crust.Items.AddRange(New Object() {"Hand Tossed - $0.00", "Thin 'n Crispy - $0.00", "Original Pan - $0.99", "Stuffed Crust - $1.99"})
            CB_Supreme_Crust.Location = New Drawing.Point(236, 422)
            CB_Supreme_Crust.Name = "CB_Supreme_Crust"
            CB_Supreme_Crust.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Supreme_Crust.Size = New Drawing.Size(169, 25)
            CB_Supreme_Crust.TabIndex = 17
            CB_Supreme_Crust.Text = "- Crust -"
            AddHandler CB_Supreme_Crust.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' CB_Supreme_Size
            ' 
            CB_Supreme_Size.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Supreme_Size.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Supreme_Size.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Supreme_Size.FormattingEnabled = True
            CB_Supreme_Size.Items.AddRange(New Object() {"Small - $9.99", "Medium - $11.99", "Large - $ 13.99"})
            CB_Supreme_Size.Location = New Drawing.Point(236, 391)
            CB_Supreme_Size.Name = "CB_Supreme_Size"
            CB_Supreme_Size.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Supreme_Size.Size = New Drawing.Size(169, 25)
            CB_Supreme_Size.TabIndex = 16
            CB_Supreme_Size.Text = "- Size -"
            AddHandler CB_Supreme_Size.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' LBL_Supreme
            ' 
            LBL_Supreme.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            LBL_Supreme.Font = New Drawing.Font("Century Gothic", 15.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            LBL_Supreme.ForeColor = Drawing.Color.Black
            LBL_Supreme.Location = New Drawing.Point(103, 6)
            LBL_Supreme.Name = "LBL_Supreme"
            LBL_Supreme.Size = New Drawing.Size(263, 51)
            LBL_Supreme.TabIndex = 15
            LBL_Supreme.Text = "Supreme"
            LBL_Supreme.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' PB_Supreme
            ' 
            PB_Supreme.Anchor = Windows.Forms.AnchorStyles.Top
            PB_Supreme.Image = Global.PizzaShop.Properties.Resources.supreme_pizza
            PB_Supreme.Location = New Drawing.Point(103, 57)
            PB_Supreme.Name = "PB_Supreme"
            PB_Supreme.Size = New Drawing.Size(263, 164)
            PB_Supreme.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            PB_Supreme.TabIndex = 14
            PB_Supreme.TabStop = False
            ' 
            ' CB_Supreme_Toppings
            ' 
            CB_Supreme_Toppings.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Supreme_Toppings.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Supreme_Toppings.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Supreme_Toppings.FormattingEnabled = True
            CB_Supreme_Toppings.Items.AddRange(New Object() {"Regular - $0.00", "More - $0.99", "Much More - $1.99"})
            CB_Supreme_Toppings.Location = New Drawing.Point(236, 453)
            CB_Supreme_Toppings.Name = "CB_Supreme_Toppings"
            CB_Supreme_Toppings.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Supreme_Toppings.Size = New Drawing.Size(169, 25)
            CB_Supreme_Toppings.TabIndex = 13
            CB_Supreme_Toppings.Text = "- Toppings -"
            AddHandler CB_Supreme_Toppings.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' LBL_Menu_Pizza
            ' 
            LBL_Menu_Pizza.BackColor = Drawing.Color.Transparent
            LBL_Menu_Pizza.Dock = Windows.Forms.DockStyle.Top
            LBL_Menu_Pizza.FlatStyle = Windows.Forms.FlatStyle.Flat
            LBL_Menu_Pizza.Font = New Drawing.Font("Century Gothic", 20.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            LBL_Menu_Pizza.ForeColor = Drawing.Color.Black
            LBL_Menu_Pizza.Location = New Drawing.Point(3, 252)
            LBL_Menu_Pizza.Name = "LBL_Menu_Pizza"
            LBL_Menu_Pizza.Size = New Drawing.Size(939, 100)
            LBL_Menu_Pizza.TabIndex = 1
            LBL_Menu_Pizza.Text = "Pizza"
            LBL_Menu_Pizza.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' PB_Menu_Title
            ' 
            PB_Menu_Title.BackColor = Drawing.Color.Transparent
            PB_Menu_Title.BackgroundImageLayout = Windows.Forms.ImageLayout.Center
            PB_Menu_Title.Dock = Windows.Forms.DockStyle.Top
            PB_Menu_Title.Image = Global.PizzaShop.Properties.Resources.Menu_920x250
            PB_Menu_Title.Location = New Drawing.Point(3, 3)
            PB_Menu_Title.Name = "PB_Menu_Title"
            PB_Menu_Title.Size = New Drawing.Size(939, 249)
            PB_Menu_Title.SizeMode = Windows.Forms.PictureBoxSizeMode.CenterImage
            PB_Menu_Title.TabIndex = 0
            PB_Menu_Title.TabStop = False
            ' 
            ' TC_Tab_Specialties
            ' 
            TC_Tab_Specialties.AutoScroll = True
            TC_Tab_Specialties.BackColor = Drawing.Color.FromArgb(90, 109, 123)
            TC_Tab_Specialties.Controls.Add(tableLayoutPanel1)
            TC_Tab_Specialties.Controls.Add(label1)
            TC_Tab_Specialties.Controls.Add(PB_Specials_Title)
            TC_Tab_Specialties.ForeColor = Drawing.Color.White
            TC_Tab_Specialties.Location = New Drawing.Point(4, 30)
            TC_Tab_Specialties.Name = "TC_Tab_Specialties"
            TC_Tab_Specialties.Padding = New Windows.Forms.Padding(3)
            TC_Tab_Specialties.Size = New Drawing.Size(962, 630)
            TC_Tab_Specialties.TabIndex = 1
            TC_Tab_Specialties.Text = "Specialties"
            ' 
            ' tableLayoutPanel1
            ' 
            tableLayoutPanel1.BackColor = Drawing.Color.Transparent
            tableLayoutPanel1.ColumnCount = 2
            tableLayoutPanel1.ColumnStyles.Add(New Windows.Forms.ColumnStyle(Windows.Forms.SizeType.Percent, 50.0F))
            tableLayoutPanel1.ColumnStyles.Add(New Windows.Forms.ColumnStyle(Windows.Forms.SizeType.Percent, 50.0F))
            tableLayoutPanel1.Controls.Add(panel4, 0, 0)
            tableLayoutPanel1.Controls.Add(panel9, 1, 0)
            tableLayoutPanel1.Controls.Add(panel10, 0, 1)
            tableLayoutPanel1.Controls.Add(panel11, 1, 1)
            tableLayoutPanel1.Dock = Windows.Forms.DockStyle.Top
            tableLayoutPanel1.ForeColor = Drawing.Color.Black
            tableLayoutPanel1.Location = New Drawing.Point(3, 352)
            tableLayoutPanel1.Name = "tableLayoutPanel1"
            tableLayoutPanel1.RowCount = 2
            tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Percent, 50.0F))
            tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Percent, 50.0F))
            tableLayoutPanel1.Size = New Drawing.Size(939, 1202)
            tableLayoutPanel1.TabIndex = 3
            ' 
            ' panel4
            ' 
            panel4.Controls.Add(label2)
            panel4.Controls.Add(label4)
            panel4.Controls.Add(LBL_Taco_Price)
            panel4.Controls.Add(BTN_Taco_Order)
            panel4.Controls.Add(LBL_Taco_Subtotal)
            panel4.Controls.Add(label7)
            panel4.Controls.Add(label8)
            panel4.Controls.Add(label9)
            panel4.Controls.Add(label10)
            panel4.Controls.Add(CB_Taco_Crust)
            panel4.Controls.Add(CB_Taco_Size)
            panel4.Controls.Add(label11)
            panel4.Controls.Add(pictureBox3)
            panel4.Controls.Add(CB_Taco_Toppings)
            panel4.Dock = Windows.Forms.DockStyle.Fill
            panel4.Location = New Drawing.Point(3, 3)
            panel4.Name = "panel4"
            panel4.Size = New Drawing.Size(463, 595)
            panel4.TabIndex = 0
            ' 
            ' label2
            ' 
            label2.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            label2.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label2.Location = New Drawing.Point(76, 263)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(344, 93)
            label2.TabIndex = 14
            label2.Text = "Taco meat and cheese stuffed quesadillas made pizza style topped with salsa and e" & "ven more melted cheese. Spicy jalapenos for just the right amount of spice!"
            label2.TextAlign = Drawing.ContentAlignment.TopCenter
            ' 
            ' label4
            ' 
            label4.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            label4.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label4.Location = New Drawing.Point(119, 218)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(263, 41)
            label4.TabIndex = 13
            label4.Text = "- Description -"
            label4.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' LBL_Taco_Price
            ' 
            LBL_Taco_Price.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Taco_Price.Location = New Drawing.Point(252, 502)
            LBL_Taco_Price.Name = "LBL_Taco_Price"
            LBL_Taco_Price.Size = New Drawing.Size(168, 25)
            LBL_Taco_Price.TabIndex = 12
            LBL_Taco_Price.Text = "$0.00"
            LBL_Taco_Price.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' BTN_Taco_Order
            ' 
            BTN_Taco_Order.Anchor = Windows.Forms.AnchorStyles.Top
            BTN_Taco_Order.BackColor = Drawing.Color.FromArgb(52, 73, 94)
            BTN_Taco_Order.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(44, 62, 80)
            BTN_Taco_Order.FlatStyle = Windows.Forms.FlatStyle.Flat
            BTN_Taco_Order.Location = New Drawing.Point(252, 542)
            BTN_Taco_Order.Name = "BTN_Taco_Order"
            BTN_Taco_Order.Size = New Drawing.Size(168, 40)
            BTN_Taco_Order.TabIndex = 7
            BTN_Taco_Order.Text = "Order Now"
            BTN_Taco_Order.UseVisualStyleBackColor = False
            AddHandler BTN_Taco_Order.Click, New EventHandler(AddressOf BTN_Taco_Order_Click)
            AddHandler BTN_Taco_Order.MouseEnter, New EventHandler(AddressOf BTN_Order_MouseEnter)
            AddHandler BTN_Taco_Order.MouseLeave, New EventHandler(AddressOf BTN_Order_MouseLeave)
            ' 
            ' LBL_Taco_Subtotal
            ' 
            LBL_Taco_Subtotal.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Taco_Subtotal.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Underline, Drawing.GraphicsUnit.Point, 0)
            LBL_Taco_Subtotal.Location = New Drawing.Point(115, 502)
            LBL_Taco_Subtotal.Name = "LBL_Taco_Subtotal"
            LBL_Taco_Subtotal.Size = New Drawing.Size(131, 25)
            LBL_Taco_Subtotal.TabIndex = 11
            LBL_Taco_Subtotal.Text = "Subtotal: "
            LBL_Taco_Subtotal.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' label7
            ' 
            label7.Anchor = Windows.Forms.AnchorStyles.Top
            label7.Location = New Drawing.Point(115, 461)
            label7.Name = "label7"
            label7.Size = New Drawing.Size(131, 25)
            label7.TabIndex = 10
            label7.Text = "Toppings: "
            label7.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' label8
            ' 
            label8.Anchor = Windows.Forms.AnchorStyles.Top
            label8.Location = New Drawing.Point(115, 430)
            label8.Name = "label8"
            label8.Size = New Drawing.Size(131, 25)
            label8.TabIndex = 9
            label8.Text = "Crust: "
            label8.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' label9
            ' 
            label9.Anchor = Windows.Forms.AnchorStyles.Top
            label9.Location = New Drawing.Point(119, 399)
            label9.Name = "label9"
            label9.Size = New Drawing.Size(127, 25)
            label9.TabIndex = 8
            label9.Text = "Size: "
            label9.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' label10
            ' 
            label10.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            label10.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label10.Location = New Drawing.Point(119, 356)
            label10.Name = "label10"
            label10.Size = New Drawing.Size(263, 41)
            label10.TabIndex = 6
            label10.Text = "- Options -"
            label10.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' CB_Taco_Crust
            ' 
            CB_Taco_Crust.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Taco_Crust.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Taco_Crust.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Taco_Crust.FormattingEnabled = True
            CB_Taco_Crust.Items.AddRange(New Object() {"Hand Tossed - $0.00", "Thin 'n Crispy - $0.00", "Original Pan - $0.99", "Stuffed Crust - $1.99"})
            CB_Taco_Crust.Location = New Drawing.Point(252, 430)
            CB_Taco_Crust.Name = "CB_Taco_Crust"
            CB_Taco_Crust.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Taco_Crust.Size = New Drawing.Size(168, 25)
            CB_Taco_Crust.TabIndex = 5
            CB_Taco_Crust.Text = "- Crust -"
            AddHandler CB_Taco_Crust.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' CB_Taco_Size
            ' 
            CB_Taco_Size.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Taco_Size.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Taco_Size.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Taco_Size.FormattingEnabled = True
            CB_Taco_Size.Items.AddRange(New Object() {"Small - $9.99", "Medium - $12.99", "Large - $ 14.99"})
            CB_Taco_Size.Location = New Drawing.Point(252, 399)
            CB_Taco_Size.Name = "CB_Taco_Size"
            CB_Taco_Size.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Taco_Size.Size = New Drawing.Size(168, 25)
            CB_Taco_Size.TabIndex = 4
            CB_Taco_Size.Text = "- Size -"
            AddHandler CB_Taco_Size.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' label11
            ' 
            label11.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            label11.Font = New Drawing.Font("Century Gothic", 15.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label11.ForeColor = Drawing.Color.Black
            label11.Location = New Drawing.Point(119, 0)
            label11.Name = "label11"
            label11.Size = New Drawing.Size(263, 51)
            label11.TabIndex = 3
            label11.Text = "Taco-Quesadilla"
            label11.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' pictureBox3
            ' 
            pictureBox3.Anchor = Windows.Forms.AnchorStyles.Top
            pictureBox3.Image = Global.PizzaShop.Properties.Resources.taco_pizza
            pictureBox3.Location = New Drawing.Point(119, 51)
            pictureBox3.Name = "pictureBox3"
            pictureBox3.Size = New Drawing.Size(263, 164)
            pictureBox3.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox3.TabIndex = 2
            pictureBox3.TabStop = False
            ' 
            ' CB_Taco_Toppings
            ' 
            CB_Taco_Toppings.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Taco_Toppings.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Taco_Toppings.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Taco_Toppings.FormattingEnabled = True
            CB_Taco_Toppings.Items.AddRange(New Object() {"Regular - $0.00", "More - $0.99", "Much More - $1.99"})
            CB_Taco_Toppings.Location = New Drawing.Point(252, 461)
            CB_Taco_Toppings.Name = "CB_Taco_Toppings"
            CB_Taco_Toppings.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Taco_Toppings.Size = New Drawing.Size(168, 25)
            CB_Taco_Toppings.TabIndex = 1
            CB_Taco_Toppings.Text = "- Toppings -"
            AddHandler CB_Taco_Toppings.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' panel9
            ' 
            panel9.Controls.Add(label12)
            panel9.Controls.Add(label13)
            panel9.Controls.Add(LBL_Breakfast_Price)
            panel9.Controls.Add(BTN_Breakfast_Order)
            panel9.Controls.Add(LBL_Breakfast_Subtotal)
            panel9.Controls.Add(label16)
            panel9.Controls.Add(label17)
            panel9.Controls.Add(label18)
            panel9.Controls.Add(label19)
            panel9.Controls.Add(CB_Breakfast_Crust)
            panel9.Controls.Add(CB_Breakfast_Size)
            panel9.Controls.Add(label20)
            panel9.Controls.Add(pictureBox4)
            panel9.Controls.Add(CB_Breakfast_Toppings)
            panel9.Dock = Windows.Forms.DockStyle.Fill
            panel9.Location = New Drawing.Point(472, 3)
            panel9.Name = "panel9"
            panel9.Size = New Drawing.Size(464, 595)
            panel9.TabIndex = 1
            ' 
            ' label12
            ' 
            label12.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            label12.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label12.Location = New Drawing.Point(61, 263)
            label12.Name = "label12"
            label12.Size = New Drawing.Size(344, 93)
            label12.TabIndex = 27
            label12.Text = resources.GetString("label12.Text")
            label12.TextAlign = Drawing.ContentAlignment.TopCenter
            ' 
            ' label13
            ' 
            label13.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            label13.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label13.Location = New Drawing.Point(103, 224)
            label13.Name = "label13"
            label13.Size = New Drawing.Size(263, 41)
            label13.TabIndex = 26
            label13.Text = "- Description -"
            label13.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' LBL_Breakfast_Price
            ' 
            LBL_Breakfast_Price.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Breakfast_Price.Location = New Drawing.Point(236, 502)
            LBL_Breakfast_Price.Name = "LBL_Breakfast_Price"
            LBL_Breakfast_Price.Size = New Drawing.Size(169, 25)
            LBL_Breakfast_Price.TabIndex = 24
            LBL_Breakfast_Price.Text = "$0.00"
            LBL_Breakfast_Price.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' BTN_Breakfast_Order
            ' 
            BTN_Breakfast_Order.Anchor = Windows.Forms.AnchorStyles.Top
            BTN_Breakfast_Order.BackColor = Drawing.Color.FromArgb(52, 73, 94)
            BTN_Breakfast_Order.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(44, 62, 80)
            BTN_Breakfast_Order.FlatStyle = Windows.Forms.FlatStyle.Flat
            BTN_Breakfast_Order.Location = New Drawing.Point(236, 542)
            BTN_Breakfast_Order.Name = "BTN_Breakfast_Order"
            BTN_Breakfast_Order.Size = New Drawing.Size(169, 40)
            BTN_Breakfast_Order.TabIndex = 19
            BTN_Breakfast_Order.Text = "Order Now"
            BTN_Breakfast_Order.UseVisualStyleBackColor = False
            AddHandler BTN_Breakfast_Order.Click, New EventHandler(AddressOf BTN_Breakfast_Order_Click)
            AddHandler BTN_Breakfast_Order.MouseEnter, New EventHandler(AddressOf BTN_Order_MouseEnter)
            AddHandler BTN_Breakfast_Order.MouseLeave, New EventHandler(AddressOf BTN_Order_MouseLeave)
            ' 
            ' LBL_Breakfast_Subtotal
            ' 
            LBL_Breakfast_Subtotal.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Breakfast_Subtotal.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Underline, Drawing.GraphicsUnit.Point, 0)
            LBL_Breakfast_Subtotal.Location = New Drawing.Point(99, 502)
            LBL_Breakfast_Subtotal.Name = "LBL_Breakfast_Subtotal"
            LBL_Breakfast_Subtotal.Size = New Drawing.Size(131, 25)
            LBL_Breakfast_Subtotal.TabIndex = 23
            LBL_Breakfast_Subtotal.Text = "Subtotal: "
            LBL_Breakfast_Subtotal.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' label16
            ' 
            label16.Anchor = Windows.Forms.AnchorStyles.Top
            label16.Location = New Drawing.Point(99, 461)
            label16.Name = "label16"
            label16.Size = New Drawing.Size(131, 25)
            label16.TabIndex = 22
            label16.Text = "Toppings: "
            label16.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' label17
            ' 
            label17.Anchor = Windows.Forms.AnchorStyles.Top
            label17.Location = New Drawing.Point(99, 430)
            label17.Name = "label17"
            label17.Size = New Drawing.Size(131, 25)
            label17.TabIndex = 21
            label17.Text = "Crust: "
            label17.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' label18
            ' 
            label18.Anchor = Windows.Forms.AnchorStyles.Top
            label18.Location = New Drawing.Point(103, 399)
            label18.Name = "label18"
            label18.Size = New Drawing.Size(127, 25)
            label18.TabIndex = 20
            label18.Text = "Size: "
            label18.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' label19
            ' 
            label19.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            label19.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label19.Location = New Drawing.Point(103, 356)
            label19.Name = "label19"
            label19.Size = New Drawing.Size(263, 41)
            label19.TabIndex = 18
            label19.Text = "- Options -"
            label19.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' CB_Breakfast_Crust
            ' 
            CB_Breakfast_Crust.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Breakfast_Crust.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Breakfast_Crust.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Breakfast_Crust.FormattingEnabled = True
            CB_Breakfast_Crust.Items.AddRange(New Object() {"Hand Tossed - $0.00", "Thin 'n Crispy - $0.00", "Original Pan - $0.99", "Stuffed Crust - $1.99"})
            CB_Breakfast_Crust.Location = New Drawing.Point(236, 430)
            CB_Breakfast_Crust.Name = "CB_Breakfast_Crust"
            CB_Breakfast_Crust.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Breakfast_Crust.Size = New Drawing.Size(169, 25)
            CB_Breakfast_Crust.TabIndex = 17
            CB_Breakfast_Crust.Text = "- Crust -"
            AddHandler CB_Breakfast_Crust.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' CB_Breakfast_Size
            ' 
            CB_Breakfast_Size.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Breakfast_Size.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Breakfast_Size.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Breakfast_Size.FormattingEnabled = True
            CB_Breakfast_Size.Items.AddRange(New Object() {"Small - $9.99", "Medium - $11.99", "Large - $ 13.99"})
            CB_Breakfast_Size.Location = New Drawing.Point(236, 399)
            CB_Breakfast_Size.Name = "CB_Breakfast_Size"
            CB_Breakfast_Size.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Breakfast_Size.Size = New Drawing.Size(169, 25)
            CB_Breakfast_Size.TabIndex = 16
            CB_Breakfast_Size.Text = "- Size -"
            AddHandler CB_Breakfast_Size.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' label20
            ' 
            label20.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            label20.Font = New Drawing.Font("Century Gothic", 15.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label20.ForeColor = Drawing.Color.Black
            label20.Location = New Drawing.Point(103, 6)
            label20.Name = "label20"
            label20.Size = New Drawing.Size(263, 51)
            label20.TabIndex = 15
            label20.Text = "Breakfast"
            label20.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' pictureBox4
            ' 
            pictureBox4.Anchor = Windows.Forms.AnchorStyles.Top
            pictureBox4.Image = Global.PizzaShop.Properties.Resources.breakfast_pizza
            pictureBox4.Location = New Drawing.Point(103, 57)
            pictureBox4.Name = "pictureBox4"
            pictureBox4.Size = New Drawing.Size(263, 164)
            pictureBox4.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox4.TabIndex = 14
            pictureBox4.TabStop = False
            ' 
            ' CB_Breakfast_Toppings
            ' 
            CB_Breakfast_Toppings.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Breakfast_Toppings.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Breakfast_Toppings.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Breakfast_Toppings.FormattingEnabled = True
            CB_Breakfast_Toppings.Items.AddRange(New Object() {"Regular - $0.00", "More - $0.99", "Much More - $1.99"})
            CB_Breakfast_Toppings.Location = New Drawing.Point(236, 461)
            CB_Breakfast_Toppings.Name = "CB_Breakfast_Toppings"
            CB_Breakfast_Toppings.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Breakfast_Toppings.Size = New Drawing.Size(169, 25)
            CB_Breakfast_Toppings.TabIndex = 13
            CB_Breakfast_Toppings.Text = "- Toppings -"
            AddHandler CB_Breakfast_Toppings.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' panel10
            ' 
            panel10.Controls.Add(label21)
            panel10.Controls.Add(label22)
            panel10.Controls.Add(LBL_Spinach_Price)
            panel10.Controls.Add(BTN_Spinach_Order)
            panel10.Controls.Add(LBL_Spinach_Subtotal)
            panel10.Controls.Add(label25)
            panel10.Controls.Add(label26)
            panel10.Controls.Add(label27)
            panel10.Controls.Add(label28)
            panel10.Controls.Add(CB_Spinach_Crust)
            panel10.Controls.Add(CB_Spinach_Size)
            panel10.Controls.Add(label29)
            panel10.Controls.Add(pictureBox5)
            panel10.Controls.Add(CB_Spinach_Toppings)
            panel10.Dock = Windows.Forms.DockStyle.Fill
            panel10.Location = New Drawing.Point(3, 604)
            panel10.Name = "panel10"
            panel10.Size = New Drawing.Size(463, 595)
            panel10.TabIndex = 2
            ' 
            ' label21
            ' 
            label21.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            label21.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label21.Location = New Drawing.Point(79, 265)
            label21.Name = "label21"
            label21.Size = New Drawing.Size(341, 82)
            label21.TabIndex = 26
            label21.Text = "This isn't just any pizza. This is a thick crust, crispy edged, pan pizza topped " & "with a rich and creamy spinach sauce, chopped up artichoke hearts, and a final l" & "ayer of melted mozzarella cheese."
            label21.TextAlign = Drawing.ContentAlignment.TopCenter
            ' 
            ' label22
            ' 
            label22.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            label22.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label22.Location = New Drawing.Point(102, 224)
            label22.Name = "label22"
            label22.Size = New Drawing.Size(263, 41)
            label22.TabIndex = 25
            label22.Text = "- Description -"
            label22.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' LBL_Spinach_Price
            ' 
            LBL_Spinach_Price.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Spinach_Price.Location = New Drawing.Point(235, 494)
            LBL_Spinach_Price.Name = "LBL_Spinach_Price"
            LBL_Spinach_Price.Size = New Drawing.Size(185, 25)
            LBL_Spinach_Price.TabIndex = 24
            LBL_Spinach_Price.Text = "$0.00"
            LBL_Spinach_Price.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' BTN_Spinach_Order
            ' 
            BTN_Spinach_Order.Anchor = Windows.Forms.AnchorStyles.Top
            BTN_Spinach_Order.BackColor = Drawing.Color.FromArgb(52, 73, 94)
            BTN_Spinach_Order.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(44, 62, 80)
            BTN_Spinach_Order.FlatStyle = Windows.Forms.FlatStyle.Flat
            BTN_Spinach_Order.Location = New Drawing.Point(235, 534)
            BTN_Spinach_Order.Name = "BTN_Spinach_Order"
            BTN_Spinach_Order.Size = New Drawing.Size(185, 40)
            BTN_Spinach_Order.TabIndex = 19
            BTN_Spinach_Order.Text = "Order Now"
            BTN_Spinach_Order.UseVisualStyleBackColor = False
            AddHandler BTN_Spinach_Order.Click, New EventHandler(AddressOf BTN_Spinach_Order_Click)
            AddHandler BTN_Spinach_Order.MouseEnter, New EventHandler(AddressOf BTN_Order_MouseEnter)
            AddHandler BTN_Spinach_Order.MouseLeave, New EventHandler(AddressOf BTN_Order_MouseLeave)
            ' 
            ' LBL_Spinach_Subtotal
            ' 
            LBL_Spinach_Subtotal.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Spinach_Subtotal.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Underline, Drawing.GraphicsUnit.Point, 0)
            LBL_Spinach_Subtotal.Location = New Drawing.Point(98, 494)
            LBL_Spinach_Subtotal.Name = "LBL_Spinach_Subtotal"
            LBL_Spinach_Subtotal.Size = New Drawing.Size(131, 25)
            LBL_Spinach_Subtotal.TabIndex = 23
            LBL_Spinach_Subtotal.Text = "Subtotal: "
            LBL_Spinach_Subtotal.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' label25
            ' 
            label25.Anchor = Windows.Forms.AnchorStyles.Top
            label25.Location = New Drawing.Point(98, 453)
            label25.Name = "label25"
            label25.Size = New Drawing.Size(131, 25)
            label25.TabIndex = 22
            label25.Text = "Toppings: "
            label25.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' label26
            ' 
            label26.Anchor = Windows.Forms.AnchorStyles.Top
            label26.Location = New Drawing.Point(98, 422)
            label26.Name = "label26"
            label26.Size = New Drawing.Size(131, 25)
            label26.TabIndex = 21
            label26.Text = "Crust: "
            label26.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' label27
            ' 
            label27.Anchor = Windows.Forms.AnchorStyles.Top
            label27.Location = New Drawing.Point(102, 391)
            label27.Name = "label27"
            label27.Size = New Drawing.Size(127, 25)
            label27.TabIndex = 20
            label27.Text = "Size: "
            label27.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' label28
            ' 
            label28.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            label28.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label28.Location = New Drawing.Point(102, 348)
            label28.Name = "label28"
            label28.Size = New Drawing.Size(263, 41)
            label28.TabIndex = 18
            label28.Text = "- Options -"
            label28.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' CB_Spinach_Crust
            ' 
            CB_Spinach_Crust.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Spinach_Crust.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Spinach_Crust.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Spinach_Crust.FormattingEnabled = True
            CB_Spinach_Crust.Items.AddRange(New Object() {"Hand Tossed - $0.00", "Thin 'n Crispy - $0.00", "Original Pan - $0.99", "Stuffed Crust - $1.99"})
            CB_Spinach_Crust.Location = New Drawing.Point(235, 422)
            CB_Spinach_Crust.Name = "CB_Spinach_Crust"
            CB_Spinach_Crust.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Spinach_Crust.Size = New Drawing.Size(185, 25)
            CB_Spinach_Crust.TabIndex = 17
            CB_Spinach_Crust.Text = "- Crust -"
            AddHandler CB_Spinach_Crust.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' CB_Spinach_Size
            ' 
            CB_Spinach_Size.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Spinach_Size.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Spinach_Size.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Spinach_Size.FormattingEnabled = True
            CB_Spinach_Size.Items.AddRange(New Object() {"Small - $9.99", "Medium - $11.99", "Large - $ 13.99"})
            CB_Spinach_Size.Location = New Drawing.Point(235, 391)
            CB_Spinach_Size.Name = "CB_Spinach_Size"
            CB_Spinach_Size.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Spinach_Size.Size = New Drawing.Size(185, 25)
            CB_Spinach_Size.TabIndex = 16
            CB_Spinach_Size.Text = "- Size -"
            AddHandler CB_Spinach_Size.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' label29
            ' 
            label29.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            label29.Font = New Drawing.Font("Century Gothic", 15.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label29.ForeColor = Drawing.Color.Black
            label29.Location = New Drawing.Point(82, 6)
            label29.Name = "label29"
            label29.Size = New Drawing.Size(309, 51)
            label29.TabIndex = 15
            label29.Text = "Spinach Artichoke"
            label29.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' pictureBox5
            ' 
            pictureBox5.Anchor = Windows.Forms.AnchorStyles.Top
            pictureBox5.Image = Global.PizzaShop.Properties.Resources.spinach_pizza
            pictureBox5.Location = New Drawing.Point(102, 57)
            pictureBox5.Name = "pictureBox5"
            pictureBox5.Size = New Drawing.Size(263, 164)
            pictureBox5.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox5.TabIndex = 14
            pictureBox5.TabStop = False
            ' 
            ' CB_Spinach_Toppings
            ' 
            CB_Spinach_Toppings.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Spinach_Toppings.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Spinach_Toppings.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Spinach_Toppings.FormattingEnabled = True
            CB_Spinach_Toppings.Items.AddRange(New Object() {"Regular - $0.00", "More - $0.99", "Much More - $1.99"})
            CB_Spinach_Toppings.Location = New Drawing.Point(235, 453)
            CB_Spinach_Toppings.Name = "CB_Spinach_Toppings"
            CB_Spinach_Toppings.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Spinach_Toppings.Size = New Drawing.Size(185, 25)
            CB_Spinach_Toppings.TabIndex = 13
            CB_Spinach_Toppings.Text = "- Toppings -"
            AddHandler CB_Spinach_Toppings.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' panel11
            ' 
            panel11.Controls.Add(label30)
            panel11.Controls.Add(label31)
            panel11.Controls.Add(LBL_Potato_Price)
            panel11.Controls.Add(BTN_Potato_Order)
            panel11.Controls.Add(LBL_Potato_Subtotal)
            panel11.Controls.Add(label34)
            panel11.Controls.Add(label35)
            panel11.Controls.Add(label36)
            panel11.Controls.Add(label37)
            panel11.Controls.Add(CB_Potato_Crust)
            panel11.Controls.Add(CB_Potato_Size)
            panel11.Controls.Add(label38)
            panel11.Controls.Add(pictureBox6)
            panel11.Controls.Add(CB_Potato_Toppings)
            panel11.Dock = Windows.Forms.DockStyle.Fill
            panel11.Location = New Drawing.Point(472, 604)
            panel11.Name = "panel11"
            panel11.Size = New Drawing.Size(464, 595)
            panel11.TabIndex = 3
            ' 
            ' label30
            ' 
            label30.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            label30.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label30.Location = New Drawing.Point(61, 265)
            label30.Name = "label30"
            label30.Size = New Drawing.Size(341, 82)
            label30.TabIndex = 26
            label30.Text = "this pizza is loaded with bacon, green onions, cheese, and sour cream. It tastes " & "just like a baked potato! Plus you’ll love this crispy deep dish pizza because i" & "t’s made in a cast iron skillet!"
            label30.TextAlign = Drawing.ContentAlignment.TopCenter
            ' 
            ' label31
            ' 
            label31.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            label31.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label31.Location = New Drawing.Point(103, 224)
            label31.Name = "label31"
            label31.Size = New Drawing.Size(263, 41)
            label31.TabIndex = 25
            label31.Text = "- Description -"
            label31.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' LBL_Potato_Price
            ' 
            LBL_Potato_Price.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Potato_Price.Location = New Drawing.Point(236, 494)
            LBL_Potato_Price.Name = "LBL_Potato_Price"
            LBL_Potato_Price.Size = New Drawing.Size(169, 25)
            LBL_Potato_Price.TabIndex = 24
            LBL_Potato_Price.Text = "$0.00"
            LBL_Potato_Price.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' BTN_Potato_Order
            ' 
            BTN_Potato_Order.Anchor = Windows.Forms.AnchorStyles.Top
            BTN_Potato_Order.BackColor = Drawing.Color.FromArgb(52, 73, 94)
            BTN_Potato_Order.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(44, 62, 80)
            BTN_Potato_Order.FlatStyle = Windows.Forms.FlatStyle.Flat
            BTN_Potato_Order.Location = New Drawing.Point(236, 534)
            BTN_Potato_Order.Name = "BTN_Potato_Order"
            BTN_Potato_Order.Size = New Drawing.Size(169, 40)
            BTN_Potato_Order.TabIndex = 19
            BTN_Potato_Order.Text = "Order Now"
            BTN_Potato_Order.UseVisualStyleBackColor = False
            AddHandler BTN_Potato_Order.Click, New EventHandler(AddressOf BTN_Potato_Order_Click)
            AddHandler BTN_Potato_Order.MouseEnter, New EventHandler(AddressOf BTN_Order_MouseEnter)
            AddHandler BTN_Potato_Order.MouseLeave, New EventHandler(AddressOf BTN_Order_MouseLeave)
            ' 
            ' LBL_Potato_Subtotal
            ' 
            LBL_Potato_Subtotal.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Potato_Subtotal.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Underline, Drawing.GraphicsUnit.Point, 0)
            LBL_Potato_Subtotal.Location = New Drawing.Point(99, 494)
            LBL_Potato_Subtotal.Name = "LBL_Potato_Subtotal"
            LBL_Potato_Subtotal.Size = New Drawing.Size(131, 25)
            LBL_Potato_Subtotal.TabIndex = 23
            LBL_Potato_Subtotal.Text = "Subtotal: "
            LBL_Potato_Subtotal.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' label34
            ' 
            label34.Anchor = Windows.Forms.AnchorStyles.Top
            label34.Location = New Drawing.Point(99, 453)
            label34.Name = "label34"
            label34.Size = New Drawing.Size(131, 25)
            label34.TabIndex = 22
            label34.Text = "Toppings: "
            label34.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' label35
            ' 
            label35.Anchor = Windows.Forms.AnchorStyles.Top
            label35.Location = New Drawing.Point(99, 422)
            label35.Name = "label35"
            label35.Size = New Drawing.Size(131, 25)
            label35.TabIndex = 21
            label35.Text = "Crust: "
            label35.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' label36
            ' 
            label36.Anchor = Windows.Forms.AnchorStyles.Top
            label36.Location = New Drawing.Point(103, 391)
            label36.Name = "label36"
            label36.Size = New Drawing.Size(127, 25)
            label36.TabIndex = 20
            label36.Text = "Size: "
            label36.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' label37
            ' 
            label37.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            label37.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label37.Location = New Drawing.Point(103, 348)
            label37.Name = "label37"
            label37.Size = New Drawing.Size(263, 41)
            label37.TabIndex = 18
            label37.Text = "- Options -"
            label37.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' CB_Potato_Crust
            ' 
            CB_Potato_Crust.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Potato_Crust.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Potato_Crust.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Potato_Crust.FormattingEnabled = True
            CB_Potato_Crust.Items.AddRange(New Object() {"Hand Tossed - $0.00", "Thin 'n Crispy - $0.00", "Original Pan - $0.99", "Stuffed Crust - $1.99"})
            CB_Potato_Crust.Location = New Drawing.Point(236, 422)
            CB_Potato_Crust.Name = "CB_Potato_Crust"
            CB_Potato_Crust.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Potato_Crust.Size = New Drawing.Size(169, 25)
            CB_Potato_Crust.TabIndex = 17
            CB_Potato_Crust.Text = "- Crust -"
            AddHandler CB_Potato_Crust.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' CB_Potato_Size
            ' 
            CB_Potato_Size.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Potato_Size.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Potato_Size.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Potato_Size.FormattingEnabled = True
            CB_Potato_Size.Items.AddRange(New Object() {"Small - $12.99", "Medium - $14.99", "Large - $ 18.99"})
            CB_Potato_Size.Location = New Drawing.Point(236, 391)
            CB_Potato_Size.Name = "CB_Potato_Size"
            CB_Potato_Size.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Potato_Size.Size = New Drawing.Size(169, 25)
            CB_Potato_Size.TabIndex = 16
            CB_Potato_Size.Text = "- Size -"
            AddHandler CB_Potato_Size.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' label38
            ' 
            label38.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            label38.Font = New Drawing.Font("Century Gothic", 15.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label38.ForeColor = Drawing.Color.Black
            label38.Location = New Drawing.Point(103, 6)
            label38.Name = "label38"
            label38.Size = New Drawing.Size(263, 51)
            label38.TabIndex = 15
            label38.Text = "Loaded Potato"
            label38.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' pictureBox6
            ' 
            pictureBox6.Anchor = Windows.Forms.AnchorStyles.Top
            pictureBox6.Image = Global.PizzaShop.Properties.Resources.loaded_potato_pizza
            pictureBox6.Location = New Drawing.Point(103, 57)
            pictureBox6.Name = "pictureBox6"
            pictureBox6.Size = New Drawing.Size(263, 164)
            pictureBox6.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox6.TabIndex = 14
            pictureBox6.TabStop = False
            ' 
            ' CB_Potato_Toppings
            ' 
            CB_Potato_Toppings.Anchor = Windows.Forms.AnchorStyles.Top
            CB_Potato_Toppings.FlatStyle = Windows.Forms.FlatStyle.Flat
            CB_Potato_Toppings.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            CB_Potato_Toppings.FormattingEnabled = True
            CB_Potato_Toppings.Items.AddRange(New Object() {"Regular - $0.00", "More - $0.99", "Much More - $1.99"})
            CB_Potato_Toppings.Location = New Drawing.Point(236, 453)
            CB_Potato_Toppings.Name = "CB_Potato_Toppings"
            CB_Potato_Toppings.RightToLeft = Windows.Forms.RightToLeft.No
            CB_Potato_Toppings.Size = New Drawing.Size(169, 25)
            CB_Potato_Toppings.TabIndex = 13
            CB_Potato_Toppings.Text = "- Toppings -"
            AddHandler CB_Potato_Toppings.SelectedIndexChanged, New EventHandler(AddressOf PNL_UpdatePrice)
            ' 
            ' label1
            ' 
            label1.BackColor = Drawing.Color.Transparent
            label1.Dock = Windows.Forms.DockStyle.Top
            label1.FlatStyle = Windows.Forms.FlatStyle.Flat
            label1.Font = New Drawing.Font("Century Gothic", 20.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label1.ForeColor = Drawing.Color.Black
            label1.Location = New Drawing.Point(3, 252)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(939, 100)
            label1.TabIndex = 2
            label1.Text = "Specialty Za's"
            label1.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' PB_Specials_Title
            ' 
            PB_Specials_Title.BackColor = Drawing.Color.Transparent
            PB_Specials_Title.BackgroundImageLayout = Windows.Forms.ImageLayout.Center
            PB_Specials_Title.Dock = Windows.Forms.DockStyle.Top
            PB_Specials_Title.Image = Global.PizzaShop.Properties.Resources.Specials_920x250
            PB_Specials_Title.Location = New Drawing.Point(3, 3)
            PB_Specials_Title.Name = "PB_Specials_Title"
            PB_Specials_Title.Size = New Drawing.Size(939, 249)
            PB_Specials_Title.SizeMode = Windows.Forms.PictureBoxSizeMode.CenterImage
            PB_Specials_Title.TabIndex = 1
            PB_Specials_Title.TabStop = False
            ' 
            ' TC_Tab_Custom
            ' 
            TC_Tab_Custom.BackColor = Drawing.Color.FromArgb(90, 109, 123)
            TC_Tab_Custom.Controls.Add(LBL_Cstm_Price)
            TC_Tab_Custom.Controls.Add(label15)
            TC_Tab_Custom.Controls.Add(panel12)
            TC_Tab_Custom.Controls.Add(PNL_Custom_ImageHolder)
            TC_Tab_Custom.Controls.Add(PB_Custom_Title)
            TC_Tab_Custom.Location = New Drawing.Point(4, 30)
            TC_Tab_Custom.Name = "TC_Tab_Custom"
            TC_Tab_Custom.Padding = New Windows.Forms.Padding(3)
            TC_Tab_Custom.Size = New Drawing.Size(962, 630)
            TC_Tab_Custom.TabIndex = 2
            TC_Tab_Custom.Text = "Custom"
            ' 
            ' LBL_Cstm_Price
            ' 
            LBL_Cstm_Price.Anchor = Windows.Forms.AnchorStyles.Top
            LBL_Cstm_Price.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            LBL_Cstm_Price.Location = New Drawing.Point(230, 590)
            LBL_Cstm_Price.Name = "LBL_Cstm_Price"
            LBL_Cstm_Price.Size = New Drawing.Size(166, 35)
            LBL_Cstm_Price.TabIndex = 12
            LBL_Cstm_Price.Text = "$0.00"
            LBL_Cstm_Price.TextAlign = Drawing.ContentAlignment.MiddleLeft
            ' 
            ' label15
            ' 
            label15.Anchor = Windows.Forms.AnchorStyles.Top
            label15.Location = New Drawing.Point(46, 590)
            label15.Name = "label15"
            label15.Size = New Drawing.Size(178, 35)
            label15.TabIndex = 11
            label15.Text = "Subtotal:"
            label15.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' panel12
            ' 
            panel12.Anchor = Windows.Forms.AnchorStyles.Top
            panel12.AutoScroll = True
            panel12.Controls.Add(panel16)
            panel12.Controls.Add(panel15)
            panel12.Controls.Add(panel13)
            panel12.Controls.Add(panel14)
            panel12.Location = New Drawing.Point(397, 259)
            panel12.Name = "panel12"
            panel12.Size = New Drawing.Size(562, 368)
            panel12.TabIndex = 10
            ' 
            ' panel16
            ' 
            panel16.Controls.Add(PNL_Olives_Cstm)
            panel16.Controls.Add(PNL_Onions_Cstm)
            panel16.Controls.Add(PNL_Mushrooms_Cstm)
            panel16.Controls.Add(PNL_Bacon_Cstm)
            panel16.Controls.Add(PNL_Ham_Cstm)
            panel16.Controls.Add(PNL_Sausage_Cstm)
            panel16.Controls.Add(PNL_Pepperoni_Cstm)
            panel16.Controls.Add(BTN_Cstm_Order)
            panel16.Controls.Add(BTN_Cstm_Clear)
            panel16.Controls.Add(label24)
            panel16.Dock = Windows.Forms.DockStyle.Top
            panel16.Location = New Drawing.Point(0, 155)
            panel16.Name = "panel16"
            panel16.Size = New Drawing.Size(545, 620)
            panel16.TabIndex = 3
            ' 
            ' PNL_Olives_Cstm
            ' 
            PNL_Olives_Cstm.Controls.Add(RB_Cstm_Olives_Extra)
            PNL_Olives_Cstm.Controls.Add(PB_Cstm_Olives_Whole)
            PNL_Olives_Cstm.Controls.Add(PB_Cstm_Olives_R)
            PNL_Olives_Cstm.Controls.Add(PB_Cstm_Olives_L)
            PNL_Olives_Cstm.Controls.Add(RB_Cstm_Olives_Reg)
            PNL_Olives_Cstm.Controls.Add(CB_Cstm_Olives)
            PNL_Olives_Cstm.Dock = Windows.Forms.DockStyle.Top
            PNL_Olives_Cstm.Location = New Drawing.Point(0, 483)
            PNL_Olives_Cstm.Name = "PNL_Olives_Cstm"
            PNL_Olives_Cstm.Size = New Drawing.Size(545, 77)
            PNL_Olives_Cstm.TabIndex = 12
            ' 
            ' RB_Cstm_Olives_Extra
            ' 
            RB_Cstm_Olives_Extra.AutoSize = True
            RB_Cstm_Olives_Extra.Enabled = False
            RB_Cstm_Olives_Extra.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Olives_Extra.Location = New Drawing.Point(208, 42)
            RB_Cstm_Olives_Extra.Name = "RB_Cstm_Olives_Extra"
            RB_Cstm_Olives_Extra.Size = New Drawing.Size(57, 21)
            RB_Cstm_Olives_Extra.TabIndex = 5
            RB_Cstm_Olives_Extra.Tag = "olives"
            RB_Cstm_Olives_Extra.Text = "Extra"
            RB_Cstm_Olives_Extra.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Olives_Extra.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Olives_CheckedChanged)
            ' 
            ' PB_Cstm_Olives_Whole
            ' 
            PB_Cstm_Olives_Whole.Image = Global.PizzaShop.Properties.Resources.button_whole
            PB_Cstm_Olives_Whole.Location = New Drawing.Point(385, 24)
            PB_Cstm_Olives_Whole.Name = "PB_Cstm_Olives_Whole"
            PB_Cstm_Olives_Whole.Size = New Drawing.Size(28, 28)
            PB_Cstm_Olives_Whole.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Olives_Whole.TabIndex = 4
            PB_Cstm_Olives_Whole.TabStop = False
            PB_Cstm_Olives_Whole.Tag = "olives"
            AddHandler PB_Cstm_Olives_Whole.Click, New EventHandler(AddressOf PB_Cstm_Olives_Whole_Click)
            ' 
            ' PB_Cstm_Olives_R
            ' 
            PB_Cstm_Olives_R.Image = Global.PizzaShop.Properties.Resources.button_right
            PB_Cstm_Olives_R.Location = New Drawing.Point(351, 24)
            PB_Cstm_Olives_R.Name = "PB_Cstm_Olives_R"
            PB_Cstm_Olives_R.Size = New Drawing.Size(28, 28)
            PB_Cstm_Olives_R.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Olives_R.TabIndex = 3
            PB_Cstm_Olives_R.TabStop = False
            PB_Cstm_Olives_R.Tag = "olives"
            AddHandler PB_Cstm_Olives_R.Click, New EventHandler(AddressOf PB_Cstm_Olives_R_Click)
            ' 
            ' PB_Cstm_Olives_L
            ' 
            PB_Cstm_Olives_L.Image = Global.PizzaShop.Properties.Resources.button_left
            PB_Cstm_Olives_L.Location = New Drawing.Point(317, 24)
            PB_Cstm_Olives_L.Name = "PB_Cstm_Olives_L"
            PB_Cstm_Olives_L.Size = New Drawing.Size(28, 28)
            PB_Cstm_Olives_L.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Olives_L.TabIndex = 2
            PB_Cstm_Olives_L.TabStop = False
            PB_Cstm_Olives_L.Tag = "olives"
            AddHandler PB_Cstm_Olives_L.Click, New EventHandler(AddressOf PB_Cstm_Olives_L_Click)
            ' 
            ' RB_Cstm_Olives_Reg
            ' 
            RB_Cstm_Olives_Reg.AutoSize = True
            RB_Cstm_Olives_Reg.Checked = True
            RB_Cstm_Olives_Reg.Enabled = False
            RB_Cstm_Olives_Reg.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Olives_Reg.Location = New Drawing.Point(127, 42)
            RB_Cstm_Olives_Reg.Name = "RB_Cstm_Olives_Reg"
            RB_Cstm_Olives_Reg.Size = New Drawing.Size(75, 21)
            RB_Cstm_Olives_Reg.TabIndex = 1
            RB_Cstm_Olives_Reg.TabStop = True
            RB_Cstm_Olives_Reg.Tag = "olives"
            RB_Cstm_Olives_Reg.Text = "Regular"
            RB_Cstm_Olives_Reg.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Olives_Reg.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Olives_CheckedChanged)
            ' 
            ' CB_Cstm_Olives
            ' 
            CB_Cstm_Olives.AutoSize = True
            CB_Cstm_Olives.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            CB_Cstm_Olives.Location = New Drawing.Point(109, 15)
            CB_Cstm_Olives.Name = "CB_Cstm_Olives"
            CB_Cstm_Olives.Size = New Drawing.Size(67, 20)
            CB_Cstm_Olives.TabIndex = 0
            CB_Cstm_Olives.Tag = "olives"
            CB_Cstm_Olives.Text = "Olives"
            CB_Cstm_Olives.UseVisualStyleBackColor = True
            AddHandler CB_Cstm_Olives.CheckedChanged, New EventHandler(AddressOf CB_Cstm_Olives_CheckedChanged)
            ' 
            ' PNL_Onions_Cstm
            ' 
            PNL_Onions_Cstm.Controls.Add(RB_Cstm_Onions_Extra)
            PNL_Onions_Cstm.Controls.Add(PB_Cstm_Onions_Whole)
            PNL_Onions_Cstm.Controls.Add(PB_Cstm_Onions_R)
            PNL_Onions_Cstm.Controls.Add(PB_Cstm_Onions_L)
            PNL_Onions_Cstm.Controls.Add(RB_Cstm_Onions_Reg)
            PNL_Onions_Cstm.Controls.Add(CB_Cstm_Onions)
            PNL_Onions_Cstm.Dock = Windows.Forms.DockStyle.Top
            PNL_Onions_Cstm.Location = New Drawing.Point(0, 406)
            PNL_Onions_Cstm.Name = "PNL_Onions_Cstm"
            PNL_Onions_Cstm.Size = New Drawing.Size(545, 77)
            PNL_Onions_Cstm.TabIndex = 11
            ' 
            ' RB_Cstm_Onions_Extra
            ' 
            RB_Cstm_Onions_Extra.AutoSize = True
            RB_Cstm_Onions_Extra.Enabled = False
            RB_Cstm_Onions_Extra.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Onions_Extra.Location = New Drawing.Point(208, 42)
            RB_Cstm_Onions_Extra.Name = "RB_Cstm_Onions_Extra"
            RB_Cstm_Onions_Extra.Size = New Drawing.Size(57, 21)
            RB_Cstm_Onions_Extra.TabIndex = 5
            RB_Cstm_Onions_Extra.Tag = "onions"
            RB_Cstm_Onions_Extra.Text = "Extra"
            RB_Cstm_Onions_Extra.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Onions_Extra.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Onions_CheckedChanged)
            ' 
            ' PB_Cstm_Onions_Whole
            ' 
            PB_Cstm_Onions_Whole.Image = Global.PizzaShop.Properties.Resources.button_whole
            PB_Cstm_Onions_Whole.Location = New Drawing.Point(385, 24)
            PB_Cstm_Onions_Whole.Name = "PB_Cstm_Onions_Whole"
            PB_Cstm_Onions_Whole.Size = New Drawing.Size(28, 28)
            PB_Cstm_Onions_Whole.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Onions_Whole.TabIndex = 4
            PB_Cstm_Onions_Whole.TabStop = False
            PB_Cstm_Onions_Whole.Tag = "onions"
            AddHandler PB_Cstm_Onions_Whole.Click, New EventHandler(AddressOf PB_Cstm_Onions_Whole_Click)
            ' 
            ' PB_Cstm_Onions_R
            ' 
            PB_Cstm_Onions_R.Image = Global.PizzaShop.Properties.Resources.button_right
            PB_Cstm_Onions_R.Location = New Drawing.Point(351, 24)
            PB_Cstm_Onions_R.Name = "PB_Cstm_Onions_R"
            PB_Cstm_Onions_R.Size = New Drawing.Size(28, 28)
            PB_Cstm_Onions_R.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Onions_R.TabIndex = 3
            PB_Cstm_Onions_R.TabStop = False
            PB_Cstm_Onions_R.Tag = "onions"
            AddHandler PB_Cstm_Onions_R.Click, New EventHandler(AddressOf PB_Cstm_Onions_R_Click)
            ' 
            ' PB_Cstm_Onions_L
            ' 
            PB_Cstm_Onions_L.Image = Global.PizzaShop.Properties.Resources.button_left
            PB_Cstm_Onions_L.Location = New Drawing.Point(317, 24)
            PB_Cstm_Onions_L.Name = "PB_Cstm_Onions_L"
            PB_Cstm_Onions_L.Size = New Drawing.Size(28, 28)
            PB_Cstm_Onions_L.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Onions_L.TabIndex = 2
            PB_Cstm_Onions_L.TabStop = False
            PB_Cstm_Onions_L.Tag = "onions"
            AddHandler PB_Cstm_Onions_L.Click, New EventHandler(AddressOf PB_Cstm_Onions_L_Click)
            ' 
            ' RB_Cstm_Onions_Reg
            ' 
            RB_Cstm_Onions_Reg.AutoSize = True
            RB_Cstm_Onions_Reg.Checked = True
            RB_Cstm_Onions_Reg.Enabled = False
            RB_Cstm_Onions_Reg.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Onions_Reg.Location = New Drawing.Point(127, 42)
            RB_Cstm_Onions_Reg.Name = "RB_Cstm_Onions_Reg"
            RB_Cstm_Onions_Reg.Size = New Drawing.Size(75, 21)
            RB_Cstm_Onions_Reg.TabIndex = 1
            RB_Cstm_Onions_Reg.TabStop = True
            RB_Cstm_Onions_Reg.Tag = "onions"
            RB_Cstm_Onions_Reg.Text = "Regular"
            RB_Cstm_Onions_Reg.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Onions_Reg.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Onions_CheckedChanged)
            ' 
            ' CB_Cstm_Onions
            ' 
            CB_Cstm_Onions.AutoSize = True
            CB_Cstm_Onions.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            CB_Cstm_Onions.Location = New Drawing.Point(109, 15)
            CB_Cstm_Onions.Name = "CB_Cstm_Onions"
            CB_Cstm_Onions.Size = New Drawing.Size(72, 20)
            CB_Cstm_Onions.TabIndex = 0
            CB_Cstm_Onions.Tag = "onions"
            CB_Cstm_Onions.Text = "Onions"
            CB_Cstm_Onions.UseVisualStyleBackColor = True
            AddHandler CB_Cstm_Onions.CheckedChanged, New EventHandler(AddressOf CB_Cstm_Onions_CheckedChanged)
            ' 
            ' PNL_Mushrooms_Cstm
            ' 
            PNL_Mushrooms_Cstm.Controls.Add(RB_Cstm_Mushrooms_Extra)
            PNL_Mushrooms_Cstm.Controls.Add(PB_Cstm_Mushrooms_Whole)
            PNL_Mushrooms_Cstm.Controls.Add(PB_Cstm_Mushrooms_R)
            PNL_Mushrooms_Cstm.Controls.Add(PB_Cstm_Mushrooms_L)
            PNL_Mushrooms_Cstm.Controls.Add(RB_Cstm_Mushrooms_Reg)
            PNL_Mushrooms_Cstm.Controls.Add(CB_Cstm_Mushrooms)
            PNL_Mushrooms_Cstm.Dock = Windows.Forms.DockStyle.Top
            PNL_Mushrooms_Cstm.Location = New Drawing.Point(0, 329)
            PNL_Mushrooms_Cstm.Name = "PNL_Mushrooms_Cstm"
            PNL_Mushrooms_Cstm.Size = New Drawing.Size(545, 77)
            PNL_Mushrooms_Cstm.TabIndex = 10
            ' 
            ' RB_Cstm_Mushrooms_Extra
            ' 
            RB_Cstm_Mushrooms_Extra.AutoSize = True
            RB_Cstm_Mushrooms_Extra.Enabled = False
            RB_Cstm_Mushrooms_Extra.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Mushrooms_Extra.Location = New Drawing.Point(208, 42)
            RB_Cstm_Mushrooms_Extra.Name = "RB_Cstm_Mushrooms_Extra"
            RB_Cstm_Mushrooms_Extra.Size = New Drawing.Size(57, 21)
            RB_Cstm_Mushrooms_Extra.TabIndex = 5
            RB_Cstm_Mushrooms_Extra.Tag = "mushrooms"
            RB_Cstm_Mushrooms_Extra.Text = "Extra"
            RB_Cstm_Mushrooms_Extra.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Mushrooms_Extra.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Mushrooms_CheckedChanged)
            ' 
            ' PB_Cstm_Mushrooms_Whole
            ' 
            PB_Cstm_Mushrooms_Whole.Image = Global.PizzaShop.Properties.Resources.button_whole
            PB_Cstm_Mushrooms_Whole.Location = New Drawing.Point(385, 24)
            PB_Cstm_Mushrooms_Whole.Name = "PB_Cstm_Mushrooms_Whole"
            PB_Cstm_Mushrooms_Whole.Size = New Drawing.Size(28, 28)
            PB_Cstm_Mushrooms_Whole.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Mushrooms_Whole.TabIndex = 4
            PB_Cstm_Mushrooms_Whole.TabStop = False
            PB_Cstm_Mushrooms_Whole.Tag = "mushrooms"
            AddHandler PB_Cstm_Mushrooms_Whole.Click, New EventHandler(AddressOf PB_Cstm_Mushrooms_Whole_Click)
            ' 
            ' PB_Cstm_Mushrooms_R
            ' 
            PB_Cstm_Mushrooms_R.Image = Global.PizzaShop.Properties.Resources.button_right
            PB_Cstm_Mushrooms_R.Location = New Drawing.Point(351, 24)
            PB_Cstm_Mushrooms_R.Name = "PB_Cstm_Mushrooms_R"
            PB_Cstm_Mushrooms_R.Size = New Drawing.Size(28, 28)
            PB_Cstm_Mushrooms_R.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Mushrooms_R.TabIndex = 3
            PB_Cstm_Mushrooms_R.TabStop = False
            PB_Cstm_Mushrooms_R.Tag = "mushrooms"
            AddHandler PB_Cstm_Mushrooms_R.Click, New EventHandler(AddressOf PB_Cstm_Mushrooms_R_Click)
            ' 
            ' PB_Cstm_Mushrooms_L
            ' 
            PB_Cstm_Mushrooms_L.Image = Global.PizzaShop.Properties.Resources.button_left
            PB_Cstm_Mushrooms_L.Location = New Drawing.Point(317, 24)
            PB_Cstm_Mushrooms_L.Name = "PB_Cstm_Mushrooms_L"
            PB_Cstm_Mushrooms_L.Size = New Drawing.Size(28, 28)
            PB_Cstm_Mushrooms_L.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Mushrooms_L.TabIndex = 2
            PB_Cstm_Mushrooms_L.TabStop = False
            PB_Cstm_Mushrooms_L.Tag = "mushrooms"
            AddHandler PB_Cstm_Mushrooms_L.Click, New EventHandler(AddressOf PB_Cstm_Mushrooms_L_Click)
            ' 
            ' RB_Cstm_Mushrooms_Reg
            ' 
            RB_Cstm_Mushrooms_Reg.AutoSize = True
            RB_Cstm_Mushrooms_Reg.Checked = True
            RB_Cstm_Mushrooms_Reg.Enabled = False
            RB_Cstm_Mushrooms_Reg.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Mushrooms_Reg.Location = New Drawing.Point(127, 42)
            RB_Cstm_Mushrooms_Reg.Name = "RB_Cstm_Mushrooms_Reg"
            RB_Cstm_Mushrooms_Reg.Size = New Drawing.Size(75, 21)
            RB_Cstm_Mushrooms_Reg.TabIndex = 1
            RB_Cstm_Mushrooms_Reg.TabStop = True
            RB_Cstm_Mushrooms_Reg.Tag = "mushrooms"
            RB_Cstm_Mushrooms_Reg.Text = "Regular"
            RB_Cstm_Mushrooms_Reg.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Mushrooms_Reg.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Mushrooms_CheckedChanged)
            ' 
            ' CB_Cstm_Mushrooms
            ' 
            CB_Cstm_Mushrooms.AutoSize = True
            CB_Cstm_Mushrooms.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            CB_Cstm_Mushrooms.Location = New Drawing.Point(109, 15)
            CB_Cstm_Mushrooms.Name = "CB_Cstm_Mushrooms"
            CB_Cstm_Mushrooms.Size = New Drawing.Size(100, 20)
            CB_Cstm_Mushrooms.TabIndex = 0
            CB_Cstm_Mushrooms.Tag = "mushrooms"
            CB_Cstm_Mushrooms.Text = "Mushrooms"
            CB_Cstm_Mushrooms.UseVisualStyleBackColor = True
            AddHandler CB_Cstm_Mushrooms.CheckedChanged, New EventHandler(AddressOf CB_Cstm_Mushrooms_CheckedChanged)
            ' 
            ' PNL_Bacon_Cstm
            ' 
            PNL_Bacon_Cstm.Controls.Add(RB_Cstm_Bacon_Extra)
            PNL_Bacon_Cstm.Controls.Add(PB_Cstm_Bacon_Whole)
            PNL_Bacon_Cstm.Controls.Add(PB_Cstm_Bacon_R)
            PNL_Bacon_Cstm.Controls.Add(PB_Cstm_Bacon_L)
            PNL_Bacon_Cstm.Controls.Add(RB_Cstm_Bacon_Reg)
            PNL_Bacon_Cstm.Controls.Add(CB_Cstm_Bacon)
            PNL_Bacon_Cstm.Dock = Windows.Forms.DockStyle.Top
            PNL_Bacon_Cstm.Location = New Drawing.Point(0, 252)
            PNL_Bacon_Cstm.Name = "PNL_Bacon_Cstm"
            PNL_Bacon_Cstm.Size = New Drawing.Size(545, 77)
            PNL_Bacon_Cstm.TabIndex = 9
            ' 
            ' RB_Cstm_Bacon_Extra
            ' 
            RB_Cstm_Bacon_Extra.AutoSize = True
            RB_Cstm_Bacon_Extra.Enabled = False
            RB_Cstm_Bacon_Extra.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Bacon_Extra.Location = New Drawing.Point(208, 42)
            RB_Cstm_Bacon_Extra.Name = "RB_Cstm_Bacon_Extra"
            RB_Cstm_Bacon_Extra.Size = New Drawing.Size(57, 21)
            RB_Cstm_Bacon_Extra.TabIndex = 5
            RB_Cstm_Bacon_Extra.Tag = "bacon"
            RB_Cstm_Bacon_Extra.Text = "Extra"
            RB_Cstm_Bacon_Extra.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Bacon_Extra.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Bacon_CheckedChanged)
            ' 
            ' PB_Cstm_Bacon_Whole
            ' 
            PB_Cstm_Bacon_Whole.Image = Global.PizzaShop.Properties.Resources.button_whole
            PB_Cstm_Bacon_Whole.Location = New Drawing.Point(385, 24)
            PB_Cstm_Bacon_Whole.Name = "PB_Cstm_Bacon_Whole"
            PB_Cstm_Bacon_Whole.Size = New Drawing.Size(28, 28)
            PB_Cstm_Bacon_Whole.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Bacon_Whole.TabIndex = 4
            PB_Cstm_Bacon_Whole.TabStop = False
            PB_Cstm_Bacon_Whole.Tag = "bacon"
            AddHandler PB_Cstm_Bacon_Whole.Click, New EventHandler(AddressOf PB_Cstm_Bacon_Whole_Click)
            ' 
            ' PB_Cstm_Bacon_R
            ' 
            PB_Cstm_Bacon_R.Image = Global.PizzaShop.Properties.Resources.button_right
            PB_Cstm_Bacon_R.Location = New Drawing.Point(351, 24)
            PB_Cstm_Bacon_R.Name = "PB_Cstm_Bacon_R"
            PB_Cstm_Bacon_R.Size = New Drawing.Size(28, 28)
            PB_Cstm_Bacon_R.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Bacon_R.TabIndex = 3
            PB_Cstm_Bacon_R.TabStop = False
            PB_Cstm_Bacon_R.Tag = "bacon"
            AddHandler PB_Cstm_Bacon_R.Click, New EventHandler(AddressOf PB_Cstm_Bacon_R_Click)
            ' 
            ' PB_Cstm_Bacon_L
            ' 
            PB_Cstm_Bacon_L.Image = Global.PizzaShop.Properties.Resources.button_left
            PB_Cstm_Bacon_L.Location = New Drawing.Point(317, 24)
            PB_Cstm_Bacon_L.Name = "PB_Cstm_Bacon_L"
            PB_Cstm_Bacon_L.Size = New Drawing.Size(28, 28)
            PB_Cstm_Bacon_L.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Bacon_L.TabIndex = 2
            PB_Cstm_Bacon_L.TabStop = False
            PB_Cstm_Bacon_L.Tag = "bacon"
            AddHandler PB_Cstm_Bacon_L.Click, New EventHandler(AddressOf PB_Cstm_Bacon_L_Click)
            ' 
            ' RB_Cstm_Bacon_Reg
            ' 
            RB_Cstm_Bacon_Reg.AutoSize = True
            RB_Cstm_Bacon_Reg.Checked = True
            RB_Cstm_Bacon_Reg.Enabled = False
            RB_Cstm_Bacon_Reg.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Bacon_Reg.Location = New Drawing.Point(127, 42)
            RB_Cstm_Bacon_Reg.Name = "RB_Cstm_Bacon_Reg"
            RB_Cstm_Bacon_Reg.Size = New Drawing.Size(75, 21)
            RB_Cstm_Bacon_Reg.TabIndex = 1
            RB_Cstm_Bacon_Reg.TabStop = True
            RB_Cstm_Bacon_Reg.Tag = "bacon"
            RB_Cstm_Bacon_Reg.Text = "Regular"
            RB_Cstm_Bacon_Reg.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Bacon_Reg.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Bacon_CheckedChanged)
            ' 
            ' CB_Cstm_Bacon
            ' 
            CB_Cstm_Bacon.AutoSize = True
            CB_Cstm_Bacon.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            CB_Cstm_Bacon.Location = New Drawing.Point(109, 15)
            CB_Cstm_Bacon.Name = "CB_Cstm_Bacon"
            CB_Cstm_Bacon.Size = New Drawing.Size(68, 20)
            CB_Cstm_Bacon.TabIndex = 0
            CB_Cstm_Bacon.Tag = "bacon"
            CB_Cstm_Bacon.Text = "Bacon"
            CB_Cstm_Bacon.UseVisualStyleBackColor = True
            AddHandler CB_Cstm_Bacon.CheckedChanged, New EventHandler(AddressOf CB_Cstm_Bacon_CheckedChanged)
            ' 
            ' PNL_Ham_Cstm
            ' 
            PNL_Ham_Cstm.Controls.Add(RB_Cstm_Ham_Extra)
            PNL_Ham_Cstm.Controls.Add(PB_Cstm_Ham_Whole)
            PNL_Ham_Cstm.Controls.Add(PB_Cstm_Ham_R)
            PNL_Ham_Cstm.Controls.Add(PB_Cstm_Ham_L)
            PNL_Ham_Cstm.Controls.Add(RB_Cstm_Ham_Reg)
            PNL_Ham_Cstm.Controls.Add(CB_Cstm_Ham)
            PNL_Ham_Cstm.Dock = Windows.Forms.DockStyle.Top
            PNL_Ham_Cstm.Location = New Drawing.Point(0, 175)
            PNL_Ham_Cstm.Name = "PNL_Ham_Cstm"
            PNL_Ham_Cstm.Size = New Drawing.Size(545, 77)
            PNL_Ham_Cstm.TabIndex = 8
            ' 
            ' RB_Cstm_Ham_Extra
            ' 
            RB_Cstm_Ham_Extra.AutoSize = True
            RB_Cstm_Ham_Extra.Enabled = False
            RB_Cstm_Ham_Extra.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Ham_Extra.Location = New Drawing.Point(208, 42)
            RB_Cstm_Ham_Extra.Name = "RB_Cstm_Ham_Extra"
            RB_Cstm_Ham_Extra.Size = New Drawing.Size(57, 21)
            RB_Cstm_Ham_Extra.TabIndex = 5
            RB_Cstm_Ham_Extra.Tag = "ham"
            RB_Cstm_Ham_Extra.Text = "Extra"
            RB_Cstm_Ham_Extra.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Ham_Extra.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Ham_CheckedChanged)
            AddHandler RB_Cstm_Ham_Extra.Click, New EventHandler(AddressOf RB_Cstm_Ham_CheckedChanged)
            ' 
            ' PB_Cstm_Ham_Whole
            ' 
            PB_Cstm_Ham_Whole.Image = Global.PizzaShop.Properties.Resources.button_whole
            PB_Cstm_Ham_Whole.Location = New Drawing.Point(385, 24)
            PB_Cstm_Ham_Whole.Name = "PB_Cstm_Ham_Whole"
            PB_Cstm_Ham_Whole.Size = New Drawing.Size(28, 28)
            PB_Cstm_Ham_Whole.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Ham_Whole.TabIndex = 4
            PB_Cstm_Ham_Whole.TabStop = False
            PB_Cstm_Ham_Whole.Tag = "ham"
            AddHandler PB_Cstm_Ham_Whole.Click, New EventHandler(AddressOf PB_Cstm_Ham_Whole_Click)
            ' 
            ' PB_Cstm_Ham_R
            ' 
            PB_Cstm_Ham_R.Image = Global.PizzaShop.Properties.Resources.button_right
            PB_Cstm_Ham_R.Location = New Drawing.Point(351, 24)
            PB_Cstm_Ham_R.Name = "PB_Cstm_Ham_R"
            PB_Cstm_Ham_R.Size = New Drawing.Size(28, 28)
            PB_Cstm_Ham_R.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Ham_R.TabIndex = 3
            PB_Cstm_Ham_R.TabStop = False
            PB_Cstm_Ham_R.Tag = "ham"
            AddHandler PB_Cstm_Ham_R.Click, New EventHandler(AddressOf PB_Cstm_Ham_R_Click)
            ' 
            ' PB_Cstm_Ham_L
            ' 
            PB_Cstm_Ham_L.Image = Global.PizzaShop.Properties.Resources.button_left
            PB_Cstm_Ham_L.Location = New Drawing.Point(317, 24)
            PB_Cstm_Ham_L.Name = "PB_Cstm_Ham_L"
            PB_Cstm_Ham_L.Size = New Drawing.Size(28, 28)
            PB_Cstm_Ham_L.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Ham_L.TabIndex = 2
            PB_Cstm_Ham_L.TabStop = False
            PB_Cstm_Ham_L.Tag = "ham"
            AddHandler PB_Cstm_Ham_L.Click, New EventHandler(AddressOf PB_Cstm_Ham_L_Click)
            ' 
            ' RB_Cstm_Ham_Reg
            ' 
            RB_Cstm_Ham_Reg.AutoSize = True
            RB_Cstm_Ham_Reg.Checked = True
            RB_Cstm_Ham_Reg.Enabled = False
            RB_Cstm_Ham_Reg.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Ham_Reg.Location = New Drawing.Point(127, 42)
            RB_Cstm_Ham_Reg.Name = "RB_Cstm_Ham_Reg"
            RB_Cstm_Ham_Reg.Size = New Drawing.Size(75, 21)
            RB_Cstm_Ham_Reg.TabIndex = 1
            RB_Cstm_Ham_Reg.TabStop = True
            RB_Cstm_Ham_Reg.Tag = "ham"
            RB_Cstm_Ham_Reg.Text = "Regular"
            RB_Cstm_Ham_Reg.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Ham_Reg.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Ham_CheckedChanged)
            ' 
            ' CB_Cstm_Ham
            ' 
            CB_Cstm_Ham.AutoSize = True
            CB_Cstm_Ham.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            CB_Cstm_Ham.Location = New Drawing.Point(109, 15)
            CB_Cstm_Ham.Name = "CB_Cstm_Ham"
            CB_Cstm_Ham.Size = New Drawing.Size(57, 20)
            CB_Cstm_Ham.TabIndex = 0
            CB_Cstm_Ham.Tag = "ham"
            CB_Cstm_Ham.Text = "Ham"
            CB_Cstm_Ham.UseVisualStyleBackColor = True
            AddHandler CB_Cstm_Ham.CheckedChanged, New EventHandler(AddressOf CB_Cstm_Ham_CheckedChanged)
            ' 
            ' PNL_Sausage_Cstm
            ' 
            PNL_Sausage_Cstm.Controls.Add(RB_Cstm_Sausage_Extra)
            PNL_Sausage_Cstm.Controls.Add(PB_Cstm_Sausage_Whole)
            PNL_Sausage_Cstm.Controls.Add(PB_Cstm_Sausage_R)
            PNL_Sausage_Cstm.Controls.Add(PB_Cstm_Sausage_L)
            PNL_Sausage_Cstm.Controls.Add(RB_Cstm_Sausage_Reg)
            PNL_Sausage_Cstm.Controls.Add(CB_Cstm_Sausage)
            PNL_Sausage_Cstm.Dock = Windows.Forms.DockStyle.Top
            PNL_Sausage_Cstm.Location = New Drawing.Point(0, 98)
            PNL_Sausage_Cstm.Name = "PNL_Sausage_Cstm"
            PNL_Sausage_Cstm.Size = New Drawing.Size(545, 77)
            PNL_Sausage_Cstm.TabIndex = 7
            ' 
            ' RB_Cstm_Sausage_Extra
            ' 
            RB_Cstm_Sausage_Extra.AutoSize = True
            RB_Cstm_Sausage_Extra.Enabled = False
            RB_Cstm_Sausage_Extra.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Sausage_Extra.Location = New Drawing.Point(208, 42)
            RB_Cstm_Sausage_Extra.Name = "RB_Cstm_Sausage_Extra"
            RB_Cstm_Sausage_Extra.Size = New Drawing.Size(57, 21)
            RB_Cstm_Sausage_Extra.TabIndex = 5
            RB_Cstm_Sausage_Extra.Tag = "sausage"
            RB_Cstm_Sausage_Extra.Text = "Extra"
            RB_Cstm_Sausage_Extra.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Sausage_Extra.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Sausage_CheckedChanged)
            ' 
            ' PB_Cstm_Sausage_Whole
            ' 
            PB_Cstm_Sausage_Whole.Image = Global.PizzaShop.Properties.Resources.button_whole
            PB_Cstm_Sausage_Whole.Location = New Drawing.Point(385, 24)
            PB_Cstm_Sausage_Whole.Name = "PB_Cstm_Sausage_Whole"
            PB_Cstm_Sausage_Whole.Size = New Drawing.Size(28, 28)
            PB_Cstm_Sausage_Whole.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Sausage_Whole.TabIndex = 4
            PB_Cstm_Sausage_Whole.TabStop = False
            PB_Cstm_Sausage_Whole.Tag = "sausage"
            AddHandler PB_Cstm_Sausage_Whole.Click, New EventHandler(AddressOf PB_Cstm_Sausage_Whole_Click)
            ' 
            ' PB_Cstm_Sausage_R
            ' 
            PB_Cstm_Sausage_R.Image = Global.PizzaShop.Properties.Resources.button_right
            PB_Cstm_Sausage_R.Location = New Drawing.Point(351, 24)
            PB_Cstm_Sausage_R.Name = "PB_Cstm_Sausage_R"
            PB_Cstm_Sausage_R.Size = New Drawing.Size(28, 28)
            PB_Cstm_Sausage_R.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Sausage_R.TabIndex = 3
            PB_Cstm_Sausage_R.TabStop = False
            PB_Cstm_Sausage_R.Tag = "sausage"
            AddHandler PB_Cstm_Sausage_R.Click, New EventHandler(AddressOf PB_Cstm_Sausage_R_Click)
            ' 
            ' PB_Cstm_Sausage_L
            ' 
            PB_Cstm_Sausage_L.Image = Global.PizzaShop.Properties.Resources.button_left
            PB_Cstm_Sausage_L.Location = New Drawing.Point(317, 24)
            PB_Cstm_Sausage_L.Name = "PB_Cstm_Sausage_L"
            PB_Cstm_Sausage_L.Size = New Drawing.Size(28, 28)
            PB_Cstm_Sausage_L.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Sausage_L.TabIndex = 2
            PB_Cstm_Sausage_L.TabStop = False
            PB_Cstm_Sausage_L.Tag = "sausage"
            AddHandler PB_Cstm_Sausage_L.Click, New EventHandler(AddressOf PB_Cstm_Sausage_L_Click)
            ' 
            ' RB_Cstm_Sausage_Reg
            ' 
            RB_Cstm_Sausage_Reg.AutoSize = True
            RB_Cstm_Sausage_Reg.Checked = True
            RB_Cstm_Sausage_Reg.Enabled = False
            RB_Cstm_Sausage_Reg.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Sausage_Reg.Location = New Drawing.Point(127, 42)
            RB_Cstm_Sausage_Reg.Name = "RB_Cstm_Sausage_Reg"
            RB_Cstm_Sausage_Reg.Size = New Drawing.Size(75, 21)
            RB_Cstm_Sausage_Reg.TabIndex = 1
            RB_Cstm_Sausage_Reg.TabStop = True
            RB_Cstm_Sausage_Reg.Tag = "sausage"
            RB_Cstm_Sausage_Reg.Text = "Regular"
            RB_Cstm_Sausage_Reg.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Sausage_Reg.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Sausage_CheckedChanged)
            ' 
            ' CB_Cstm_Sausage
            ' 
            CB_Cstm_Sausage.AutoSize = True
            CB_Cstm_Sausage.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            CB_Cstm_Sausage.Location = New Drawing.Point(109, 15)
            CB_Cstm_Sausage.Name = "CB_Cstm_Sausage"
            CB_Cstm_Sausage.Size = New Drawing.Size(83, 20)
            CB_Cstm_Sausage.TabIndex = 0
            CB_Cstm_Sausage.Tag = "sausage"
            CB_Cstm_Sausage.Text = "Sausage"
            CB_Cstm_Sausage.UseVisualStyleBackColor = True
            AddHandler CB_Cstm_Sausage.CheckedChanged, New EventHandler(AddressOf CB_Cstm_Sausage_CheckedChanged)
            ' 
            ' PNL_Pepperoni_Cstm
            ' 
            PNL_Pepperoni_Cstm.BackColor = Drawing.Color.Transparent
            PNL_Pepperoni_Cstm.Controls.Add(RB_Cstm_Pepperoni_Extra)
            PNL_Pepperoni_Cstm.Controls.Add(PB_Cstm_Pepperoni_Whole)
            PNL_Pepperoni_Cstm.Controls.Add(PB_Cstm_Pepperoni_R)
            PNL_Pepperoni_Cstm.Controls.Add(PB_Cstm_Pepperoni_L)
            PNL_Pepperoni_Cstm.Controls.Add(RB_Cstm_Pepperoni_reg)
            PNL_Pepperoni_Cstm.Controls.Add(CB_Cstm_Pepperoni)
            PNL_Pepperoni_Cstm.Dock = Windows.Forms.DockStyle.Top
            PNL_Pepperoni_Cstm.Location = New Drawing.Point(0, 21)
            PNL_Pepperoni_Cstm.Name = "PNL_Pepperoni_Cstm"
            PNL_Pepperoni_Cstm.Size = New Drawing.Size(545, 77)
            PNL_Pepperoni_Cstm.TabIndex = 6
            ' 
            ' RB_Cstm_Pepperoni_Extra
            ' 
            RB_Cstm_Pepperoni_Extra.AutoSize = True
            RB_Cstm_Pepperoni_Extra.Enabled = False
            RB_Cstm_Pepperoni_Extra.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Pepperoni_Extra.Location = New Drawing.Point(208, 42)
            RB_Cstm_Pepperoni_Extra.Name = "RB_Cstm_Pepperoni_Extra"
            RB_Cstm_Pepperoni_Extra.Size = New Drawing.Size(57, 21)
            RB_Cstm_Pepperoni_Extra.TabIndex = 5
            RB_Cstm_Pepperoni_Extra.Tag = "pepperoni"
            RB_Cstm_Pepperoni_Extra.Text = "Extra"
            RB_Cstm_Pepperoni_Extra.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Pepperoni_Extra.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Pepperoni_CheckedChanged)
            ' 
            ' PB_Cstm_Pepperoni_Whole
            ' 
            PB_Cstm_Pepperoni_Whole.Image = Global.PizzaShop.Properties.Resources.button_whole
            PB_Cstm_Pepperoni_Whole.Location = New Drawing.Point(385, 24)
            PB_Cstm_Pepperoni_Whole.Name = "PB_Cstm_Pepperoni_Whole"
            PB_Cstm_Pepperoni_Whole.Size = New Drawing.Size(28, 28)
            PB_Cstm_Pepperoni_Whole.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Pepperoni_Whole.TabIndex = 4
            PB_Cstm_Pepperoni_Whole.TabStop = False
            PB_Cstm_Pepperoni_Whole.Tag = "pepperoni"
            AddHandler PB_Cstm_Pepperoni_Whole.Click, New EventHandler(AddressOf PB_Cstm_Pepperoni_Whole_Click)
            ' 
            ' PB_Cstm_Pepperoni_R
            ' 
            PB_Cstm_Pepperoni_R.Image = Global.PizzaShop.Properties.Resources.button_right
            PB_Cstm_Pepperoni_R.Location = New Drawing.Point(351, 24)
            PB_Cstm_Pepperoni_R.Name = "PB_Cstm_Pepperoni_R"
            PB_Cstm_Pepperoni_R.Size = New Drawing.Size(28, 28)
            PB_Cstm_Pepperoni_R.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Pepperoni_R.TabIndex = 3
            PB_Cstm_Pepperoni_R.TabStop = False
            PB_Cstm_Pepperoni_R.Tag = "pepperoni"
            AddHandler PB_Cstm_Pepperoni_R.Click, New EventHandler(AddressOf PB_Cstm_Pepperoni_R_Click)
            ' 
            ' PB_Cstm_Pepperoni_L
            ' 
            PB_Cstm_Pepperoni_L.Image = Global.PizzaShop.Properties.Resources.button_left
            PB_Cstm_Pepperoni_L.Location = New Drawing.Point(317, 24)
            PB_Cstm_Pepperoni_L.Name = "PB_Cstm_Pepperoni_L"
            PB_Cstm_Pepperoni_L.Size = New Drawing.Size(28, 28)
            PB_Cstm_Pepperoni_L.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
            PB_Cstm_Pepperoni_L.TabIndex = 2
            PB_Cstm_Pepperoni_L.TabStop = False
            PB_Cstm_Pepperoni_L.Tag = "pepperoni"
            AddHandler PB_Cstm_Pepperoni_L.Click, New EventHandler(AddressOf PB_Cstm_Pepperoni_L_Click)
            ' 
            ' RB_Cstm_Pepperoni_reg
            ' 
            RB_Cstm_Pepperoni_reg.AutoSize = True
            RB_Cstm_Pepperoni_reg.Checked = True
            RB_Cstm_Pepperoni_reg.Enabled = False
            RB_Cstm_Pepperoni_reg.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Pepperoni_reg.Location = New Drawing.Point(127, 42)
            RB_Cstm_Pepperoni_reg.Name = "RB_Cstm_Pepperoni_reg"
            RB_Cstm_Pepperoni_reg.Size = New Drawing.Size(75, 21)
            RB_Cstm_Pepperoni_reg.TabIndex = 1
            RB_Cstm_Pepperoni_reg.TabStop = True
            RB_Cstm_Pepperoni_reg.Tag = "pepperoni"
            RB_Cstm_Pepperoni_reg.Text = "Regular"
            RB_Cstm_Pepperoni_reg.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Pepperoni_reg.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Pepperoni_CheckedChanged)
            ' 
            ' CB_Cstm_Pepperoni
            ' 
            CB_Cstm_Pepperoni.AutoSize = True
            CB_Cstm_Pepperoni.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            CB_Cstm_Pepperoni.Location = New Drawing.Point(109, 15)
            CB_Cstm_Pepperoni.Name = "CB_Cstm_Pepperoni"
            CB_Cstm_Pepperoni.Size = New Drawing.Size(93, 20)
            CB_Cstm_Pepperoni.TabIndex = 0
            CB_Cstm_Pepperoni.Tag = "pepperoni"
            CB_Cstm_Pepperoni.Text = "Pepperoni"
            CB_Cstm_Pepperoni.UseVisualStyleBackColor = True
            AddHandler CB_Cstm_Pepperoni.CheckedChanged, New EventHandler(AddressOf CB_Cstm_Pepperoni_CheckedChanged)
            ' 
            ' BTN_Cstm_Order
            ' 
            BTN_Cstm_Order.BackColor = Drawing.Color.FromArgb(52, 73, 94)
            BTN_Cstm_Order.FlatStyle = Windows.Forms.FlatStyle.Flat
            BTN_Cstm_Order.Location = New Drawing.Point(371, 566)
            BTN_Cstm_Order.Name = "BTN_Cstm_Order"
            BTN_Cstm_Order.Size = New Drawing.Size(169, 45)
            BTN_Cstm_Order.TabIndex = 5
            BTN_Cstm_Order.Text = "Order Now"
            BTN_Cstm_Order.UseVisualStyleBackColor = False
            AddHandler BTN_Cstm_Order.Click, New EventHandler(AddressOf BTN_Cstm_Order_ClickEvent)
            AddHandler BTN_Cstm_Order.MouseEnter, New EventHandler(AddressOf BTN_Order_MouseEnter)
            AddHandler BTN_Cstm_Order.MouseLeave, New EventHandler(AddressOf BTN_Order_MouseLeave)
            ' 
            ' BTN_Cstm_Clear
            ' 
            BTN_Cstm_Clear.BackColor = Drawing.Color.FromArgb(52, 73, 94)
            BTN_Cstm_Clear.FlatStyle = Windows.Forms.FlatStyle.Flat
            BTN_Cstm_Clear.Location = New Drawing.Point(193, 566)
            BTN_Cstm_Clear.Name = "BTN_Cstm_Clear"
            BTN_Cstm_Clear.Size = New Drawing.Size(172, 45)
            BTN_Cstm_Clear.TabIndex = 4
            BTN_Cstm_Clear.Text = "Clear All"
            BTN_Cstm_Clear.UseVisualStyleBackColor = False
            AddHandler BTN_Cstm_Clear.Click, New EventHandler(AddressOf BTN_Cstm_Clear_ClickEvent)
            AddHandler BTN_Cstm_Clear.MouseEnter, New EventHandler(AddressOf BTN_Order_MouseEnter)
            AddHandler BTN_Cstm_Clear.MouseLeave, New EventHandler(AddressOf BTN_Order_MouseLeave)
            ' 
            ' label24
            ' 
            label24.Dock = Windows.Forms.DockStyle.Top
            label24.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold Or Drawing.FontStyle.Underline, Drawing.GraphicsUnit.Point, 0)
            label24.Location = New Drawing.Point(0, 0)
            label24.Name = "label24"
            label24.Size = New Drawing.Size(545, 21)
            label24.TabIndex = 1
            label24.Text = "- Toppings -"
            label24.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' panel15
            ' 
            panel15.Controls.Add(RB_Cstm_Sauce_Buf)
            panel15.Controls.Add(RB_Cstm_Sauce_BBQ)
            panel15.Controls.Add(RB_Cstm_Sauce_GP)
            panel15.Controls.Add(RB_Cstm_Sauce_Mar)
            panel15.Controls.Add(label14)
            panel15.Dock = Windows.Forms.DockStyle.Top
            panel15.Location = New Drawing.Point(0, 105)
            panel15.Name = "panel15"
            panel15.Size = New Drawing.Size(545, 50)
            panel15.TabIndex = 2
            ' 
            ' RB_Cstm_Sauce_Buf
            ' 
            RB_Cstm_Sauce_Buf.AutoSize = True
            RB_Cstm_Sauce_Buf.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Sauce_Buf.Location = New Drawing.Point(402, 24)
            RB_Cstm_Sauce_Buf.Name = "RB_Cstm_Sauce_Buf"
            RB_Cstm_Sauce_Buf.Size = New Drawing.Size(70, 21)
            RB_Cstm_Sauce_Buf.TabIndex = 4
            RB_Cstm_Sauce_Buf.Text = "Buffalo"
            RB_Cstm_Sauce_Buf.TextAlign = Drawing.ContentAlignment.MiddleCenter
            RB_Cstm_Sauce_Buf.UseVisualStyleBackColor = True
            ' 
            ' RB_Cstm_Sauce_BBQ
            ' 
            RB_Cstm_Sauce_BBQ.AutoSize = True
            RB_Cstm_Sauce_BBQ.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Sauce_BBQ.Location = New Drawing.Point(308, 24)
            RB_Cstm_Sauce_BBQ.Name = "RB_Cstm_Sauce_BBQ"
            RB_Cstm_Sauce_BBQ.Size = New Drawing.Size(88, 21)
            RB_Cstm_Sauce_BBQ.TabIndex = 3
            RB_Cstm_Sauce_BBQ.Text = "Barbeque"
            RB_Cstm_Sauce_BBQ.TextAlign = Drawing.ContentAlignment.MiddleCenter
            RB_Cstm_Sauce_BBQ.UseVisualStyleBackColor = True
            ' 
            ' RB_Cstm_Sauce_GP
            ' 
            RB_Cstm_Sauce_GP.AutoSize = True
            RB_Cstm_Sauce_GP.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Sauce_GP.Location = New Drawing.Point(170, 24)
            RB_Cstm_Sauce_GP.Name = "RB_Cstm_Sauce_GP"
            RB_Cstm_Sauce_GP.Size = New Drawing.Size(132, 21)
            RB_Cstm_Sauce_GP.TabIndex = 2
            RB_Cstm_Sauce_GP.Text = "Garlic Parmesan"
            RB_Cstm_Sauce_GP.TextAlign = Drawing.ContentAlignment.MiddleCenter
            RB_Cstm_Sauce_GP.UseVisualStyleBackColor = True
            ' 
            ' RB_Cstm_Sauce_Mar
            ' 
            RB_Cstm_Sauce_Mar.AutoSize = True
            RB_Cstm_Sauce_Mar.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Sauce_Mar.Location = New Drawing.Point(81, 24)
            RB_Cstm_Sauce_Mar.Name = "RB_Cstm_Sauce_Mar"
            RB_Cstm_Sauce_Mar.Size = New Drawing.Size(83, 21)
            RB_Cstm_Sauce_Mar.TabIndex = 1
            RB_Cstm_Sauce_Mar.Text = "Marinara"
            RB_Cstm_Sauce_Mar.TextAlign = Drawing.ContentAlignment.MiddleCenter
            RB_Cstm_Sauce_Mar.UseVisualStyleBackColor = True
            ' 
            ' label14
            ' 
            label14.Dock = Windows.Forms.DockStyle.Top
            label14.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold Or Drawing.FontStyle.Underline, Drawing.GraphicsUnit.Point, 0)
            label14.Location = New Drawing.Point(0, 0)
            label14.Name = "label14"
            label14.Size = New Drawing.Size(545, 21)
            label14.TabIndex = 0
            label14.Text = "- Sauce -"
            label14.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' panel13
            ' 
            panel13.Controls.Add(RB_Cstm_Size_Large)
            panel13.Controls.Add(RB_Cstm_Size_Med)
            panel13.Controls.Add(RB_Cstm_Size_Small)
            panel13.Controls.Add(label5)
            panel13.Dock = Windows.Forms.DockStyle.Top
            panel13.Location = New Drawing.Point(0, 53)
            panel13.Name = "panel13"
            panel13.Size = New Drawing.Size(545, 52)
            panel13.TabIndex = 0
            ' 
            ' RB_Cstm_Size_Large
            ' 
            RB_Cstm_Size_Large.AutoSize = True
            RB_Cstm_Size_Large.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Size_Large.Location = New Drawing.Point(315, 24)
            RB_Cstm_Size_Large.Name = "RB_Cstm_Size_Large"
            RB_Cstm_Size_Large.Size = New Drawing.Size(62, 21)
            RB_Cstm_Size_Large.TabIndex = 3
            RB_Cstm_Size_Large.Text = "Large"
            RB_Cstm_Size_Large.TextAlign = Drawing.ContentAlignment.MiddleCenter
            RB_Cstm_Size_Large.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Size_Large.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Size_CheckedChanged)
            ' 
            ' RB_Cstm_Size_Med
            ' 
            RB_Cstm_Size_Med.AutoSize = True
            RB_Cstm_Size_Med.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Size_Med.Location = New Drawing.Point(231, 24)
            RB_Cstm_Size_Med.Name = "RB_Cstm_Size_Med"
            RB_Cstm_Size_Med.Size = New Drawing.Size(78, 21)
            RB_Cstm_Size_Med.TabIndex = 2
            RB_Cstm_Size_Med.Text = "Medium"
            RB_Cstm_Size_Med.TextAlign = Drawing.ContentAlignment.MiddleCenter
            RB_Cstm_Size_Med.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Size_Med.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Size_CheckedChanged)
            ' 
            ' RB_Cstm_Size_Small
            ' 
            RB_Cstm_Size_Small.AutoSize = True
            RB_Cstm_Size_Small.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Size_Small.Location = New Drawing.Point(165, 24)
            RB_Cstm_Size_Small.Name = "RB_Cstm_Size_Small"
            RB_Cstm_Size_Small.Size = New Drawing.Size(60, 21)
            RB_Cstm_Size_Small.TabIndex = 1
            RB_Cstm_Size_Small.Text = "Small"
            RB_Cstm_Size_Small.TextAlign = Drawing.ContentAlignment.MiddleCenter
            RB_Cstm_Size_Small.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Size_Small.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Size_CheckedChanged)
            ' 
            ' label5
            ' 
            label5.Dock = Windows.Forms.DockStyle.Top
            label5.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold Or Drawing.FontStyle.Underline, Drawing.GraphicsUnit.Point, 0)
            label5.Location = New Drawing.Point(0, 0)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(545, 21)
            label5.TabIndex = 0
            label5.Text = "- Size -"
            label5.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' panel14
            ' 
            panel14.Controls.Add(RB_Cstm_Crust_Pan)
            panel14.Controls.Add(RB_Cstm_Crust_HT)
            panel14.Controls.Add(RB_Cstm_Crust_Stuffed)
            panel14.Controls.Add(RB_Cstm_Crust_Thin)
            panel14.Controls.Add(label6)
            panel14.Dock = Windows.Forms.DockStyle.Top
            panel14.Location = New Drawing.Point(0, 0)
            panel14.Name = "panel14"
            panel14.Size = New Drawing.Size(545, 53)
            panel14.TabIndex = 1
            ' 
            ' RB_Cstm_Crust_Pan
            ' 
            RB_Cstm_Crust_Pan.AutoSize = True
            RB_Cstm_Crust_Pan.Checked = True
            RB_Cstm_Crust_Pan.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Crust_Pan.Location = New Drawing.Point(55, 24)
            RB_Cstm_Crust_Pan.Name = "RB_Cstm_Crust_Pan"
            RB_Cstm_Crust_Pan.Size = New Drawing.Size(105, 21)
            RB_Cstm_Crust_Pan.TabIndex = 5
            RB_Cstm_Crust_Pan.TabStop = True
            RB_Cstm_Crust_Pan.Text = "Original Pan"
            RB_Cstm_Crust_Pan.TextAlign = Drawing.ContentAlignment.MiddleCenter
            RB_Cstm_Crust_Pan.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Crust_Pan.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Crust_CheckedChanged)
            ' 
            ' RB_Cstm_Crust_HT
            ' 
            RB_Cstm_Crust_HT.AutoSize = True
            RB_Cstm_Crust_HT.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Crust_HT.Location = New Drawing.Point(166, 24)
            RB_Cstm_Crust_HT.Name = "RB_Cstm_Crust_HT"
            RB_Cstm_Crust_HT.Size = New Drawing.Size(106, 21)
            RB_Cstm_Crust_HT.TabIndex = 4
            RB_Cstm_Crust_HT.Text = "Hand Tossed"
            RB_Cstm_Crust_HT.TextAlign = Drawing.ContentAlignment.MiddleCenter
            RB_Cstm_Crust_HT.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Crust_HT.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Crust_CheckedChanged)
            ' 
            ' RB_Cstm_Crust_Stuffed
            ' 
            RB_Cstm_Crust_Stuffed.AutoSize = True
            RB_Cstm_Crust_Stuffed.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Crust_Stuffed.Location = New Drawing.Point(393, 24)
            RB_Cstm_Crust_Stuffed.Name = "RB_Cstm_Crust_Stuffed"
            RB_Cstm_Crust_Stuffed.Size = New Drawing.Size(107, 21)
            RB_Cstm_Crust_Stuffed.TabIndex = 3
            RB_Cstm_Crust_Stuffed.Text = "Stuffed Crust"
            RB_Cstm_Crust_Stuffed.TextAlign = Drawing.ContentAlignment.MiddleCenter
            RB_Cstm_Crust_Stuffed.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Crust_Stuffed.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Crust_CheckedChanged)
            ' 
            ' RB_Cstm_Crust_Thin
            ' 
            RB_Cstm_Crust_Thin.AutoSize = True
            RB_Cstm_Crust_Thin.Font = New Drawing.Font("Century Gothic", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            RB_Cstm_Crust_Thin.Location = New Drawing.Point(278, 24)
            RB_Cstm_Crust_Thin.Name = "RB_Cstm_Crust_Thin"
            RB_Cstm_Crust_Thin.Size = New Drawing.Size(109, 21)
            RB_Cstm_Crust_Thin.TabIndex = 2
            RB_Cstm_Crust_Thin.Text = "Thin 'N Crispy"
            RB_Cstm_Crust_Thin.TextAlign = Drawing.ContentAlignment.MiddleCenter
            RB_Cstm_Crust_Thin.UseVisualStyleBackColor = True
            AddHandler RB_Cstm_Crust_Thin.CheckedChanged, New EventHandler(AddressOf RB_Cstm_Crust_CheckedChanged)
            ' 
            ' label6
            ' 
            label6.Dock = Windows.Forms.DockStyle.Top
            label6.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold Or Drawing.FontStyle.Underline, Drawing.GraphicsUnit.Point, 0)
            label6.Location = New Drawing.Point(0, 0)
            label6.Name = "label6"
            label6.Size = New Drawing.Size(545, 21)
            label6.TabIndex = 0
            label6.Text = "- Crust -"
            label6.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' PNL_Custom_ImageHolder
            ' 
            PNL_Custom_ImageHolder.Anchor = Windows.Forms.AnchorStyles.Top
            PNL_Custom_ImageHolder.BackColor = Drawing.Color.Transparent
            PNL_Custom_ImageHolder.Controls.Add(PB_Cstm_PizzaImg)
            PNL_Custom_ImageHolder.Location = New Drawing.Point(46, 259)
            PNL_Custom_ImageHolder.Name = "PNL_Custom_ImageHolder"
            PNL_Custom_ImageHolder.Size = New Drawing.Size(350, 324)
            PNL_Custom_ImageHolder.TabIndex = 8
            ' 
            ' PB_Cstm_PizzaImg
            ' 
            PB_Cstm_PizzaImg.Dock = Windows.Forms.DockStyle.Fill
            PB_Cstm_PizzaImg.Location = New Drawing.Point(0, 0)
            PB_Cstm_PizzaImg.Name = "PB_Cstm_PizzaImg"
            PB_Cstm_PizzaImg.Size = New Drawing.Size(350, 324)
            PB_Cstm_PizzaImg.TabIndex = 0
            PB_Cstm_PizzaImg.TabStop = False
            ' 
            ' PB_Custom_Title
            ' 
            PB_Custom_Title.Anchor = Windows.Forms.AnchorStyles.Top
            PB_Custom_Title.BackColor = Drawing.Color.Transparent
            PB_Custom_Title.BackgroundImageLayout = Windows.Forms.ImageLayout.Center
            PB_Custom_Title.Image = Global.PizzaShop.Properties.Resources.Custom_920x250
            PB_Custom_Title.Location = New Drawing.Point(3, 3)
            PB_Custom_Title.Name = "PB_Custom_Title"
            PB_Custom_Title.Size = New Drawing.Size(956, 250)
            PB_Custom_Title.SizeMode = Windows.Forms.PictureBoxSizeMode.CenterImage
            PB_Custom_Title.TabIndex = 1
            PB_Custom_Title.TabStop = False
            ' 
            ' TC_Tab_Cart
            ' 
            TC_Tab_Cart.AutoScroll = True
            TC_Tab_Cart.BackColor = Drawing.Color.FromArgb(90, 109, 123)
            TC_Tab_Cart.Controls.Add(panel17)
            TC_Tab_Cart.Controls.Add(PB_Order_Title)
            TC_Tab_Cart.Location = New Drawing.Point(4, 30)
            TC_Tab_Cart.Name = "TC_Tab_Cart"
            TC_Tab_Cart.Padding = New Windows.Forms.Padding(3)
            TC_Tab_Cart.Size = New Drawing.Size(962, 630)
            TC_Tab_Cart.TabIndex = 3
            TC_Tab_Cart.Text = "Cart"
            ' 
            ' panel17
            ' 
            panel17.Controls.Add(panel19)
            panel17.Controls.Add(panel18)
            panel17.Controls.Add(label23)
            panel17.Dock = Windows.Forms.DockStyle.Fill
            panel17.Location = New Drawing.Point(3, 253)
            panel17.Name = "panel17"
            panel17.Size = New Drawing.Size(956, 374)
            panel17.TabIndex = 6
            ' 
            ' panel19
            ' 
            panel19.Controls.Add(BTN_Order_Order)
            panel19.Controls.Add(LBL_Order_Tax)
            panel19.Controls.Add(LBL_Order_Total)
            panel19.Controls.Add(label40)
            panel19.Controls.Add(label39)
            panel19.Controls.Add(LBL_Order_Subtotal)
            panel19.Controls.Add(label32)
            panel19.Controls.Add(button1)
            panel19.Controls.Add(BTN_Cart_Remove)
            panel19.Dock = Windows.Forms.DockStyle.Fill
            panel19.Location = New Drawing.Point(725, 37)
            panel19.Name = "panel19"
            panel19.Size = New Drawing.Size(231, 337)
            panel19.TabIndex = 3
            ' 
            ' BTN_Order_Order
            ' 
            BTN_Order_Order.Anchor = Windows.Forms.AnchorStyles.Left
            BTN_Order_Order.AutoSize = True
            BTN_Order_Order.BackColor = Drawing.Color.FromArgb(52, 73, 94)
            BTN_Order_Order.FlatStyle = Windows.Forms.FlatStyle.Flat
            BTN_Order_Order.Location = New Drawing.Point(6, 283)
            BTN_Order_Order.Name = "BTN_Order_Order"
            BTN_Order_Order.Size = New Drawing.Size(220, 49)
            BTN_Order_Order.TabIndex = 13
            BTN_Order_Order.Text = "Pay Now!"
            BTN_Order_Order.UseVisualStyleBackColor = False
            AddHandler BTN_Order_Order.Click, New EventHandler(AddressOf BTN_Order_Order_Click)
            AddHandler BTN_Order_Order.MouseEnter, New EventHandler(AddressOf BTN_Order_MouseEnter)
            AddHandler BTN_Order_Order.MouseLeave, New EventHandler(AddressOf BTN_Nav_Order_MouseLeaveEvent)
            ' 
            ' LBL_Order_Tax
            ' 
            LBL_Order_Tax.Anchor = Windows.Forms.AnchorStyles.Left
            LBL_Order_Tax.Location = New Drawing.Point(99, 189)
            LBL_Order_Tax.Name = "LBL_Order_Tax"
            LBL_Order_Tax.Size = New Drawing.Size(127, 21)
            LBL_Order_Tax.TabIndex = 12
            LBL_Order_Tax.Text = "$0.00"
            ' 
            ' LBL_Order_Total
            ' 
            LBL_Order_Total.Anchor = Windows.Forms.AnchorStyles.Left
            LBL_Order_Total.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            LBL_Order_Total.Location = New Drawing.Point(99, 228)
            LBL_Order_Total.Name = "LBL_Order_Total"
            LBL_Order_Total.Size = New Drawing.Size(127, 21)
            LBL_Order_Total.TabIndex = 11
            LBL_Order_Total.Text = "$0.00"
            ' 
            ' label40
            ' 
            label40.Anchor = Windows.Forms.AnchorStyles.Left
            label40.Font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Bold Or Drawing.FontStyle.Underline, Drawing.GraphicsUnit.Point, 0)
            label40.Location = New Drawing.Point(6, 228)
            label40.Name = "label40"
            label40.Size = New Drawing.Size(87, 21)
            label40.TabIndex = 10
            label40.Text = "Total:"
            label40.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' label39
            ' 
            label39.Anchor = Windows.Forms.AnchorStyles.Left
            label39.Location = New Drawing.Point(6, 189)
            label39.Name = "label39"
            label39.Size = New Drawing.Size(87, 21)
            label39.TabIndex = 9
            label39.Text = "+ Tax:"
            label39.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' LBL_Order_Subtotal
            ' 
            LBL_Order_Subtotal.Anchor = Windows.Forms.AnchorStyles.Left
            LBL_Order_Subtotal.Location = New Drawing.Point(99, 168)
            LBL_Order_Subtotal.Name = "LBL_Order_Subtotal"
            LBL_Order_Subtotal.Size = New Drawing.Size(127, 21)
            LBL_Order_Subtotal.TabIndex = 8
            LBL_Order_Subtotal.Text = "$0.00"
            AddHandler LBL_Order_Subtotal.TextChanged, New EventHandler(AddressOf LBL_Order_Subtotal_TextChanged)
            ' 
            ' label32
            ' 
            label32.Anchor = Windows.Forms.AnchorStyles.Left
            label32.Location = New Drawing.Point(6, 168)
            label32.Name = "label32"
            label32.Size = New Drawing.Size(87, 21)
            label32.TabIndex = 7
            label32.Text = "Subtotal:"
            label32.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' button1
            ' 
            button1.Anchor = Windows.Forms.AnchorStyles.Left
            button1.AutoSize = True
            button1.BackColor = Drawing.Color.FromArgb(52, 73, 94)
            button1.FlatStyle = Windows.Forms.FlatStyle.Flat
            button1.Location = New Drawing.Point(99, 8)
            button1.Name = "button1"
            button1.Size = New Drawing.Size(127, 33)
            button1.TabIndex = 6
            button1.Text = "Add More"
            button1.UseVisualStyleBackColor = False
            AddHandler button1.Click, New EventHandler(AddressOf BTN_LV_AddMore)
            AddHandler button1.MouseEnter, New EventHandler(AddressOf BTN_Order_MouseEnter)
            AddHandler button1.MouseLeave, New EventHandler(AddressOf BTN_Order_MouseLeave)
            ' 
            ' BTN_Cart_Remove
            ' 
            BTN_Cart_Remove.Anchor = Windows.Forms.AnchorStyles.Left
            BTN_Cart_Remove.AutoSize = True
            BTN_Cart_Remove.BackColor = Drawing.Color.FromArgb(52, 73, 94)
            BTN_Cart_Remove.FlatStyle = Windows.Forms.FlatStyle.Flat
            BTN_Cart_Remove.Location = New Drawing.Point(6, 8)
            BTN_Cart_Remove.Name = "BTN_Cart_Remove"
            BTN_Cart_Remove.Size = New Drawing.Size(87, 33)
            BTN_Cart_Remove.TabIndex = 5
            BTN_Cart_Remove.Text = "Remove"
            BTN_Cart_Remove.UseVisualStyleBackColor = False
            AddHandler BTN_Cart_Remove.Click, New EventHandler(AddressOf BTN_LV_RemoveItem)
            AddHandler BTN_Cart_Remove.MouseEnter, New EventHandler(AddressOf BTN_Order_MouseEnter)
            AddHandler BTN_Cart_Remove.MouseLeave, New EventHandler(AddressOf BTN_Order_MouseLeave)
            ' 
            ' panel18
            ' 
            panel18.Controls.Add(LV_Cart)
            panel18.Dock = Windows.Forms.DockStyle.Left
            panel18.Location = New Drawing.Point(0, 37)
            panel18.Name = "panel18"
            panel18.Size = New Drawing.Size(725, 337)
            panel18.TabIndex = 2
            ' 
            ' LV_Cart
            ' 
            LV_Cart.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Right
            LV_Cart.BackColor = Drawing.Color.FromArgb(90, 109, 123)
            LV_Cart.BorderStyle = Windows.Forms.BorderStyle.None
            LV_Cart.Columns.AddRange(New Windows.Forms.ColumnHeader() {LV_Sku, LV_Pizza, LV_Size, LV_Crust, LV_Toppings, LV_Price})
            LV_Cart.FullRowSelect = True
            LV_Cart.Location = New Drawing.Point(6, 8)
            LV_Cart.Name = "LV_Cart"
            LV_Cart.Size = New Drawing.Size(726, 329)
            LV_Cart.TabIndex = 1
            LV_Cart.UseCompatibleStateImageBehavior = False
            LV_Cart.View = Windows.Forms.View.Details
            ' 
            ' LV_Sku
            ' 
            LV_Sku.Text = "SKU"
            LV_Sku.Width = 64
            ' 
            ' LV_Pizza
            ' 
            LV_Pizza.Text = "Pizza"
            LV_Pizza.Width = 116
            ' 
            ' LV_Size
            ' 
            LV_Size.Text = "Size"
            LV_Size.Width = 86
            ' 
            ' LV_Crust
            ' 
            LV_Crust.Text = "Crust"
            LV_Crust.Width = 122
            ' 
            ' LV_Toppings
            ' 
            LV_Toppings.Text = "Toppings"
            LV_Toppings.Width = 246
            ' 
            ' LV_Price
            ' 
            LV_Price.Text = "Price"
            LV_Price.Width = 84
            ' 
            ' label23
            ' 
            label23.Dock = Windows.Forms.DockStyle.Top
            label23.Font = New Drawing.Font("Century Gothic", 20.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label23.Location = New Drawing.Point(0, 0)
            label23.Name = "label23"
            label23.Size = New Drawing.Size(956, 37)
            label23.TabIndex = 0
            label23.Text = "Pizza Cart"
            label23.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' PB_Order_Title
            ' 
            PB_Order_Title.BackColor = Drawing.Color.Transparent
            PB_Order_Title.BackgroundImageLayout = Windows.Forms.ImageLayout.Center
            PB_Order_Title.Dock = Windows.Forms.DockStyle.Top
            PB_Order_Title.Image = Global.PizzaShop.Properties.Resources.Order_920x250
            PB_Order_Title.Location = New Drawing.Point(3, 3)
            PB_Order_Title.Name = "PB_Order_Title"
            PB_Order_Title.Size = New Drawing.Size(956, 250)
            PB_Order_Title.SizeMode = Windows.Forms.PictureBoxSizeMode.CenterImage
            PB_Order_Title.TabIndex = 1
            PB_Order_Title.TabStop = False
            ' 
            ' panel1
            ' 
            panel1.BackColor = Drawing.Color.FromArgb(52, 73, 94)
            panel1.Controls.Add(PB_Order_Notify)
            panel1.Controls.Add(BTN_Nav_Order)
            panel1.Controls.Add(BTN_Nav_Custom)
            panel1.Controls.Add(BTN_Nav_Specialties)
            panel1.Controls.Add(BTN_Nav_Menu)
            panel1.Controls.Add(panel7)
            panel1.Controls.Add(panel3)
            panel1.Dock = Windows.Forms.DockStyle.Left
            panel1.Location = New Drawing.Point(0, 24)
            panel1.Name = "panel1"
            panel1.Size = New Drawing.Size(156, 664)
            panel1.TabIndex = 3
            ' 
            ' PB_Order_Notify
            ' 
            PB_Order_Notify.BackColor = Drawing.Color.Transparent
            PB_Order_Notify.Image = Global.PizzaShop.Properties.Resources.error_red_18x18
            PB_Order_Notify.Location = New Drawing.Point(31, 512)
            PB_Order_Notify.Name = "PB_Order_Notify"
            PB_Order_Notify.Size = New Drawing.Size(18, 18)
            PB_Order_Notify.TabIndex = 7
            PB_Order_Notify.TabStop = False
            PB_Order_Notify.Visible = False
            ' 
            ' BTN_Nav_Order
            ' 
            BTN_Nav_Order.Dock = Windows.Forms.DockStyle.Top
            BTN_Nav_Order.FlatAppearance.BorderSize = 0
            BTN_Nav_Order.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(44, 62, 80)
            BTN_Nav_Order.FlatStyle = Windows.Forms.FlatStyle.Flat
            BTN_Nav_Order.ForeColor = Drawing.Color.White
            BTN_Nav_Order.Image = Global.PizzaShop.Properties.Resources.order_white_24x24
            BTN_Nav_Order.ImageAlign = Drawing.ContentAlignment.MiddleRight
            BTN_Nav_Order.Location = New Drawing.Point(0, 482)
            BTN_Nav_Order.Name = "BTN_Nav_Order"
            BTN_Nav_Order.Size = New Drawing.Size(153, 100)
            BTN_Nav_Order.TabIndex = 5
            BTN_Nav_Order.Text = "Your Order"
            BTN_Nav_Order.TextAlign = Drawing.ContentAlignment.MiddleLeft
            BTN_Nav_Order.TextImageRelation = Windows.Forms.TextImageRelation.ImageBeforeText
            BTN_Nav_Order.UseVisualStyleBackColor = True
            AddHandler BTN_Nav_Order.Click, New EventHandler(AddressOf BTN_Nav_Order_Click)
            AddHandler BTN_Nav_Order.MouseEnter, New EventHandler(AddressOf BTN_Nav_Order_MouseEnterEvent)
            AddHandler BTN_Nav_Order.MouseLeave, New EventHandler(AddressOf BTN_Nav_Order_MouseLeaveEvent)
            ' 
            ' BTN_Nav_Custom
            ' 
            BTN_Nav_Custom.Dock = Windows.Forms.DockStyle.Top
            BTN_Nav_Custom.FlatAppearance.BorderSize = 0
            BTN_Nav_Custom.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(44, 62, 80)
            BTN_Nav_Custom.FlatStyle = Windows.Forms.FlatStyle.Flat
            BTN_Nav_Custom.ForeColor = Drawing.Color.White
            BTN_Nav_Custom.Image = Global.PizzaShop.Properties.Resources.custom_white_24x24
            BTN_Nav_Custom.ImageAlign = Drawing.ContentAlignment.MiddleRight
            BTN_Nav_Custom.Location = New Drawing.Point(0, 382)
            BTN_Nav_Custom.Name = "BTN_Nav_Custom"
            BTN_Nav_Custom.Size = New Drawing.Size(153, 100)
            BTN_Nav_Custom.TabIndex = 4
            BTN_Nav_Custom.Text = "Build Your Own"
            BTN_Nav_Custom.TextAlign = Drawing.ContentAlignment.MiddleLeft
            BTN_Nav_Custom.TextImageRelation = Windows.Forms.TextImageRelation.ImageBeforeText
            BTN_Nav_Custom.UseVisualStyleBackColor = True
            AddHandler BTN_Nav_Custom.Click, New EventHandler(AddressOf BTN_Nav_Custom_Click)
            AddHandler BTN_Nav_Custom.MouseEnter, New EventHandler(AddressOf BTN_Nav_Custom_MouseEnterEvent)
            AddHandler BTN_Nav_Custom.MouseLeave, New EventHandler(AddressOf BTN_Nav_Custom_MouseLeaveEvent)
            ' 
            ' BTN_Nav_Specialties
            ' 
            BTN_Nav_Specialties.Dock = Windows.Forms.DockStyle.Top
            BTN_Nav_Specialties.FlatAppearance.BorderSize = 0
            BTN_Nav_Specialties.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(44, 62, 80)
            BTN_Nav_Specialties.FlatStyle = Windows.Forms.FlatStyle.Flat
            BTN_Nav_Specialties.ForeColor = Drawing.Color.White
            BTN_Nav_Specialties.Image = Global.PizzaShop.Properties.Resources.specialties_white_24x24
            BTN_Nav_Specialties.ImageAlign = Drawing.ContentAlignment.MiddleRight
            BTN_Nav_Specialties.Location = New Drawing.Point(0, 282)
            BTN_Nav_Specialties.Name = "BTN_Nav_Specialties"
            BTN_Nav_Specialties.Size = New Drawing.Size(153, 100)
            BTN_Nav_Specialties.TabIndex = 3
            BTN_Nav_Specialties.Text = "Specialties"
            BTN_Nav_Specialties.TextAlign = Drawing.ContentAlignment.MiddleLeft
            BTN_Nav_Specialties.TextImageRelation = Windows.Forms.TextImageRelation.ImageBeforeText
            BTN_Nav_Specialties.UseVisualStyleBackColor = True
            AddHandler BTN_Nav_Specialties.Click, New EventHandler(AddressOf BTN_Nav_Specialties_Click)
            AddHandler BTN_Nav_Specialties.MouseEnter, New EventHandler(AddressOf BTN_Nav_Specialties_MouseEnterEvent)
            AddHandler BTN_Nav_Specialties.MouseLeave, New EventHandler(AddressOf BTN_Nav_Specialties_MouseLeaveEvent)
            ' 
            ' BTN_Nav_Menu
            ' 
            BTN_Nav_Menu.Dock = Windows.Forms.DockStyle.Top
            BTN_Nav_Menu.FlatAppearance.BorderSize = 0
            BTN_Nav_Menu.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(44, 62, 80)
            BTN_Nav_Menu.FlatStyle = Windows.Forms.FlatStyle.Flat
            BTN_Nav_Menu.ForeColor = Drawing.Color.White
            BTN_Nav_Menu.Image = Global.PizzaShop.Properties.Resources.menu_white_24x24
            BTN_Nav_Menu.ImageAlign = Drawing.ContentAlignment.MiddleRight
            BTN_Nav_Menu.Location = New Drawing.Point(0, 182)
            BTN_Nav_Menu.Name = "BTN_Nav_Menu"
            BTN_Nav_Menu.Size = New Drawing.Size(153, 100)
            BTN_Nav_Menu.TabIndex = 2
            BTN_Nav_Menu.Text = "Menu"
            BTN_Nav_Menu.TextAlign = Drawing.ContentAlignment.MiddleLeft
            BTN_Nav_Menu.TextImageRelation = Windows.Forms.TextImageRelation.ImageBeforeText
            BTN_Nav_Menu.UseVisualStyleBackColor = True
            AddHandler BTN_Nav_Menu.Click, New EventHandler(AddressOf BTN_Nav_Menu_Click)
            AddHandler BTN_Nav_Menu.MouseEnter, New EventHandler(AddressOf BTN_Nav_Menu_MouseEnterEvent)
            AddHandler BTN_Nav_Menu.MouseLeave, New EventHandler(AddressOf BTN_Nav_Menu_MouseLeaveEvent)
            ' 
            ' panel7
            ' 
            panel7.Controls.Add(Lightup_Panel_Order)
            panel7.Controls.Add(Lightup_Panel_Custom)
            panel7.Controls.Add(Lightup_Panel_Specialties)
            panel7.Controls.Add(Lightup_Panel_Menu)
            panel7.Dock = Windows.Forms.DockStyle.Right
            panel7.Location = New Drawing.Point(153, 182)
            panel7.Name = "panel7"
            panel7.Size = New Drawing.Size(3, 482)
            panel7.TabIndex = 1
            ' 
            ' Lightup_Panel_Order
            ' 
            Lightup_Panel_Order.Dock = Windows.Forms.DockStyle.Top
            Lightup_Panel_Order.Location = New Drawing.Point(0, 300)
            Lightup_Panel_Order.Name = "Lightup_Panel_Order"
            Lightup_Panel_Order.Size = New Drawing.Size(3, 100)
            Lightup_Panel_Order.TabIndex = 3
            ' 
            ' Lightup_Panel_Custom
            ' 
            Lightup_Panel_Custom.Dock = Windows.Forms.DockStyle.Top
            Lightup_Panel_Custom.Location = New Drawing.Point(0, 200)
            Lightup_Panel_Custom.Name = "Lightup_Panel_Custom"
            Lightup_Panel_Custom.Size = New Drawing.Size(3, 100)
            Lightup_Panel_Custom.TabIndex = 2
            ' 
            ' Lightup_Panel_Specialties
            ' 
            Lightup_Panel_Specialties.Dock = Windows.Forms.DockStyle.Top
            Lightup_Panel_Specialties.Location = New Drawing.Point(0, 100)
            Lightup_Panel_Specialties.Name = "Lightup_Panel_Specialties"
            Lightup_Panel_Specialties.Size = New Drawing.Size(3, 100)
            Lightup_Panel_Specialties.TabIndex = 1
            ' 
            ' Lightup_Panel_Menu
            ' 
            Lightup_Panel_Menu.BackColor = Drawing.Color.FromArgb(181, 28, 11)
            Lightup_Panel_Menu.Dock = Windows.Forms.DockStyle.Top
            Lightup_Panel_Menu.Location = New Drawing.Point(0, 0)
            Lightup_Panel_Menu.Name = "Lightup_Panel_Menu"
            Lightup_Panel_Menu.Size = New Drawing.Size(3, 100)
            Lightup_Panel_Menu.TabIndex = 0
            ' 
            ' panel3
            ' 
            panel3.BackColor = Drawing.Color.FromArgb(44, 62, 80)
            panel3.Controls.Add(pictureBox1)
            panel3.Dock = Windows.Forms.DockStyle.Top
            panel3.Location = New Drawing.Point(0, 0)
            panel3.Name = "panel3"
            panel3.Size = New Drawing.Size(156, 182)
            panel3.TabIndex = 0
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Dock = Windows.Forms.DockStyle.Fill
            pictureBox1.Image = Global.PizzaShop.Properties.Resources.Logo_400x400
            pictureBox1.Location = New Drawing.Point(0, 0)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(156, 182)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox1.TabIndex = 0
            pictureBox1.TabStop = False
            ' 
            ' panel2
            ' 
            panel2.BackColor = Drawing.Color.FromArgb(44, 62, 80)
            panel2.Controls.Add(panel6)
            panel2.Dock = Windows.Forms.DockStyle.Top
            panel2.Location = New Drawing.Point(0, 0)
            panel2.Name = "panel2"
            panel2.Size = New Drawing.Size(1126, 24)
            panel2.TabIndex = 2
            AddHandler panel2.MouseDown, New Windows.Forms.MouseEventHandler(AddressOf Title_MouseDownEvent)
            ' 
            ' ApplicationForm
            ' 
            AutoScaleDimensions = New Drawing.SizeF(10.0F, 21.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            AutoScroll = True
            AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
            BackColor = Drawing.Color.FromArgb(90, 109, 123)
            ClientSize = New Drawing.Size(1126, 688)
            Controls.Add(panel5)
            font = New Drawing.Font("Century Gothic", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
            Margin = New Windows.Forms.Padding(5)
            MaximizeBox = False
            MinimizeBox = False
            MinimumSize = New Drawing.Size(1024, 660)
            Name = "ApplicationForm"
            SizeGripStyle = Windows.Forms.SizeGripStyle.Show
            StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Text = "Caterina"
            AddHandler Load, New EventHandler(AddressOf ApplicationForm_Load)
            panel6.ResumeLayout(False)
            panel6.PerformLayout()
            CType(PB_Minimize, ComponentModel.ISupportInitialize).EndInit()
            CType(PB_Exit, ComponentModel.ISupportInitialize).EndInit()
            CType(PB_Maximize, ComponentModel.ISupportInitialize).EndInit()
            panel5.ResumeLayout(False)
            TC_Navigation.ResumeLayout(False)
            TC_Tab_Menu.ResumeLayout(False)
            PNL_Pizza_Grid.ResumeLayout(False)
            PNL_Cheese.ResumeLayout(False)
            CType(PB_Cheese, ComponentModel.ISupportInitialize).EndInit()
            PNL_Pepperoni.ResumeLayout(False)
            CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
            PNL_BBQ.ResumeLayout(False)
            CType(PB_BBQ, ComponentModel.ISupportInitialize).EndInit()
            PNL_Supreme.ResumeLayout(False)
            CType(PB_Supreme, ComponentModel.ISupportInitialize).EndInit()
            CType(PB_Menu_Title, ComponentModel.ISupportInitialize).EndInit()
            TC_Tab_Specialties.ResumeLayout(False)
            tableLayoutPanel1.ResumeLayout(False)
            panel4.ResumeLayout(False)
            CType(pictureBox3, ComponentModel.ISupportInitialize).EndInit()
            panel9.ResumeLayout(False)
            CType(pictureBox4, ComponentModel.ISupportInitialize).EndInit()
            panel10.ResumeLayout(False)
            CType(pictureBox5, ComponentModel.ISupportInitialize).EndInit()
            panel11.ResumeLayout(False)
            CType(pictureBox6, ComponentModel.ISupportInitialize).EndInit()
            CType(PB_Specials_Title, ComponentModel.ISupportInitialize).EndInit()
            TC_Tab_Custom.ResumeLayout(False)
            panel12.ResumeLayout(False)
            panel16.ResumeLayout(False)
            PNL_Olives_Cstm.ResumeLayout(False)
            PNL_Olives_Cstm.PerformLayout()
            CType(PB_Cstm_Olives_Whole, ComponentModel.ISupportInitialize).EndInit()
            CType(PB_Cstm_Olives_R, ComponentModel.ISupportInitialize).EndInit()
            CType(PB_Cstm_Olives_L, ComponentModel.ISupportInitialize).EndInit()
            PNL_Onions_Cstm.ResumeLayout(False)
            PNL_Onions_Cstm.PerformLayout()
            CType(PB_Cstm_Onions_Whole, ComponentModel.ISupportInitialize).EndInit()
            CType(PB_Cstm_Onions_R, ComponentModel.ISupportInitialize).EndInit()
            CType(PB_Cstm_Onions_L, ComponentModel.ISupportInitialize).EndInit()
            PNL_Mushrooms_Cstm.ResumeLayout(False)
            PNL_Mushrooms_Cstm.PerformLayout()
            CType(PB_Cstm_Mushrooms_Whole, ComponentModel.ISupportInitialize).EndInit()
            CType(PB_Cstm_Mushrooms_R, ComponentModel.ISupportInitialize).EndInit()
            CType(PB_Cstm_Mushrooms_L, ComponentModel.ISupportInitialize).EndInit()
            PNL_Bacon_Cstm.ResumeLayout(False)
            PNL_Bacon_Cstm.PerformLayout()
            CType(PB_Cstm_Bacon_Whole, ComponentModel.ISupportInitialize).EndInit()
            CType(PB_Cstm_Bacon_R, ComponentModel.ISupportInitialize).EndInit()
            CType(PB_Cstm_Bacon_L, ComponentModel.ISupportInitialize).EndInit()
            PNL_Ham_Cstm.ResumeLayout(False)
            PNL_Ham_Cstm.PerformLayout()
            CType(PB_Cstm_Ham_Whole, ComponentModel.ISupportInitialize).EndInit()
            CType(PB_Cstm_Ham_R, ComponentModel.ISupportInitialize).EndInit()
            CType(PB_Cstm_Ham_L, ComponentModel.ISupportInitialize).EndInit()
            PNL_Sausage_Cstm.ResumeLayout(False)
            PNL_Sausage_Cstm.PerformLayout()
            CType(PB_Cstm_Sausage_Whole, ComponentModel.ISupportInitialize).EndInit()
            CType(PB_Cstm_Sausage_R, ComponentModel.ISupportInitialize).EndInit()
            CType(PB_Cstm_Sausage_L, ComponentModel.ISupportInitialize).EndInit()
            PNL_Pepperoni_Cstm.ResumeLayout(False)
            PNL_Pepperoni_Cstm.PerformLayout()
            CType(PB_Cstm_Pepperoni_Whole, ComponentModel.ISupportInitialize).EndInit()
            CType(PB_Cstm_Pepperoni_R, ComponentModel.ISupportInitialize).EndInit()
            CType(PB_Cstm_Pepperoni_L, ComponentModel.ISupportInitialize).EndInit()
            panel15.ResumeLayout(False)
            panel15.PerformLayout()
            panel13.ResumeLayout(False)
            panel13.PerformLayout()
            panel14.ResumeLayout(False)
            panel14.PerformLayout()
            PNL_Custom_ImageHolder.ResumeLayout(False)
            CType(PB_Cstm_PizzaImg, ComponentModel.ISupportInitialize).EndInit()
            CType(PB_Custom_Title, ComponentModel.ISupportInitialize).EndInit()
            TC_Tab_Cart.ResumeLayout(False)
            panel17.ResumeLayout(False)
            panel19.ResumeLayout(False)
            panel19.PerformLayout()
            panel18.ResumeLayout(False)
            CType(PB_Order_Title, ComponentModel.ISupportInitialize).EndInit()
            panel1.ResumeLayout(False)
            CType(PB_Order_Notify, ComponentModel.ISupportInitialize).EndInit()
            panel7.ResumeLayout(False)
            panel3.ResumeLayout(False)
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            panel2.ResumeLayout(False)
            ResumeLayout(False)

        End Sub

#End Region

        Private panel6 As Windows.Forms.Panel
        Private PB_Minimize As Windows.Forms.PictureBox
        Private PB_Exit As Windows.Forms.PictureBox
        Private PB_Maximize As Windows.Forms.PictureBox
        Private panel5 As Windows.Forms.Panel
        Private panel1 As Windows.Forms.Panel
        Private panel3 As Windows.Forms.Panel
        Private panel2 As Windows.Forms.Panel
        Private TC_Navigation As MaterialSkin.Controls.MaterialTabControl
        Private TC_Tab_Menu As Windows.Forms.TabPage
        Private TC_Tab_Specialties As Windows.Forms.TabPage
        Private BTN_Nav_Menu As Windows.Forms.Button
        Private panel7 As Windows.Forms.Panel
        Private Lightup_Panel_Menu As Windows.Forms.Panel
        Private BTN_Nav_Specialties As Windows.Forms.Button
        Private BTN_Nav_Custom As Windows.Forms.Button
        Private Lightup_Panel_Specialties As Windows.Forms.Panel
        Private Lightup_Panel_Custom As Windows.Forms.Panel
        Private TC_Tab_Custom As Windows.Forms.TabPage
        Private TC_Tab_Cart As Windows.Forms.TabPage
        Private BTN_Nav_Order As Windows.Forms.Button
        Private Lightup_Panel_Order As Windows.Forms.Panel
        Private PB_Menu_Title As Windows.Forms.PictureBox
        Private PB_Specials_Title As Windows.Forms.PictureBox
        Private PB_Custom_Title As Windows.Forms.PictureBox
        Private PB_Order_Title As Windows.Forms.PictureBox
        Private pictureBox1 As Windows.Forms.PictureBox
        Private LBL_Menu_Pizza As Windows.Forms.Label
        Private PNL_Pizza_Grid As Windows.Forms.TableLayoutPanel
        Private PNL_Cheese As Windows.Forms.Panel
        Private CB_Cheese_Toppings As Windows.Forms.ComboBox
        Private PB_Cheese As Windows.Forms.PictureBox
        Private LBL_Cheese As Windows.Forms.Label
        Private CB_Cheese_Crust As Windows.Forms.ComboBox
        Private CB_Cheese_Size As Windows.Forms.ComboBox
        Private LBL_Cheese_Toppings As Windows.Forms.Label
        Private LBL_Cheese_Crust As Windows.Forms.Label
        Private LBL_Cheese_Size As Windows.Forms.Label
        Private BTN_Cheese_Order As Windows.Forms.Button
        Private LBL_Cheese_Options As Windows.Forms.Label
        Private LBL_Cheese_Price As Windows.Forms.Label
        Private LBL_Cheese_Subtotal As Windows.Forms.Label
        Private PNL_Pepperoni As Windows.Forms.Panel
        Private LBL_Pepperoni_Price As Windows.Forms.Label
        Private BTN_Pepperoni_Order As Windows.Forms.Button
        Private LBL_Pepperoni_Subtotal As Windows.Forms.Label
        Private LBL_Pepperoni_Toppings As Windows.Forms.Label
        Private LBL_Pepperoni_Crust As Windows.Forms.Label
        Private LBL_Pepperoni_Size As Windows.Forms.Label
        Private LBL_Pepperoni_Options As Windows.Forms.Label
        Private CB_Pepperoni_Crust As Windows.Forms.ComboBox
        Private CB_Pepperoni_Size As Windows.Forms.ComboBox
        Private LBL_Pepperoni As Windows.Forms.Label
        Private pictureBox2 As Windows.Forms.PictureBox
        Private CB_Pepperoni_Toppings As Windows.Forms.ComboBox
        Private PNL_BBQ As Windows.Forms.Panel
        Private LBL_BBQ_Price As Windows.Forms.Label
        Private BTN_BBQ_Order As Windows.Forms.Button
        Private LBL_BBQ_Subtotal As Windows.Forms.Label
        Private LBL_BBQ_Toppings As Windows.Forms.Label
        Private LBL_BBQ_Crust As Windows.Forms.Label
        Private LBL_BBQ_Size As Windows.Forms.Label
        Private LBL_BBQ_Options As Windows.Forms.Label
        Private CB_BBQ_Crust As Windows.Forms.ComboBox
        Private CB_BBQ_Size As Windows.Forms.ComboBox
        Private LBL_BBQ As Windows.Forms.Label
        Private PB_BBQ As Windows.Forms.PictureBox
        Private CB_BBQ_Toppings As Windows.Forms.ComboBox
        Private PNL_Supreme As Windows.Forms.Panel
        Private LBL_Supreme_Price As Windows.Forms.Label
        Private BTN_Supreme_Order As Windows.Forms.Button
        Private LBL_Supreme_Subtotal As Windows.Forms.Label
        Private LBL_Supreme_Toppings As Windows.Forms.Label
        Private LBL_Supreme_Crust As Windows.Forms.Label
        Private LBL_Supreme_Size As Windows.Forms.Label
        Private LBL_Supreme_Options As Windows.Forms.Label
        Private CB_Supreme_Crust As Windows.Forms.ComboBox
        Private CB_Supreme_Size As Windows.Forms.ComboBox
        Private LBL_Supreme As Windows.Forms.Label
        Private PB_Supreme As Windows.Forms.PictureBox
        Private CB_Supreme_Toppings As Windows.Forms.ComboBox
        Private LBL_Cheese_Description As Windows.Forms.Label
        Private LBL_Cheese_Desc As Windows.Forms.Label
        Private LBL_Pepperoni_Desc As Windows.Forms.Label
        Private label3 As Windows.Forms.Label
        Private LBL_BBQ_Description As Windows.Forms.Label
        Private LBL_BBQ_Desc As Windows.Forms.Label
        Private LBL_Supreme_Description As Windows.Forms.Label
        Private LBL_Supreme_Desc As Windows.Forms.Label
        Private label1 As Windows.Forms.Label
        Private tableLayoutPanel1 As Windows.Forms.TableLayoutPanel
        Private panel4 As Windows.Forms.Panel
        Private label2 As Windows.Forms.Label
        Private label4 As Windows.Forms.Label
        Private LBL_Taco_Price As Windows.Forms.Label
        Private BTN_Taco_Order As Windows.Forms.Button
        Private LBL_Taco_Subtotal As Windows.Forms.Label
        Private label7 As Windows.Forms.Label
        Private label8 As Windows.Forms.Label
        Private label9 As Windows.Forms.Label
        Private label10 As Windows.Forms.Label
        Private CB_Taco_Crust As Windows.Forms.ComboBox
        Private CB_Taco_Size As Windows.Forms.ComboBox
        Private label11 As Windows.Forms.Label
        Private pictureBox3 As Windows.Forms.PictureBox
        Private CB_Taco_Toppings As Windows.Forms.ComboBox
        Private panel9 As Windows.Forms.Panel
        Private label12 As Windows.Forms.Label
        Private label13 As Windows.Forms.Label
        Private LBL_Breakfast_Price As Windows.Forms.Label
        Private BTN_Breakfast_Order As Windows.Forms.Button
        Private LBL_Breakfast_Subtotal As Windows.Forms.Label
        Private label16 As Windows.Forms.Label
        Private label17 As Windows.Forms.Label
        Private label18 As Windows.Forms.Label
        Private label19 As Windows.Forms.Label
        Private CB_Breakfast_Crust As Windows.Forms.ComboBox
        Private CB_Breakfast_Size As Windows.Forms.ComboBox
        Private label20 As Windows.Forms.Label
        Private pictureBox4 As Windows.Forms.PictureBox
        Private CB_Breakfast_Toppings As Windows.Forms.ComboBox
        Private panel10 As Windows.Forms.Panel
        Private label21 As Windows.Forms.Label
        Private label22 As Windows.Forms.Label
        Private LBL_Spinach_Price As Windows.Forms.Label
        Private BTN_Spinach_Order As Windows.Forms.Button
        Private LBL_Spinach_Subtotal As Windows.Forms.Label
        Private label25 As Windows.Forms.Label
        Private label26 As Windows.Forms.Label
        Private label27 As Windows.Forms.Label
        Private label28 As Windows.Forms.Label
        Private CB_Spinach_Crust As Windows.Forms.ComboBox
        Private CB_Spinach_Size As Windows.Forms.ComboBox
        Private label29 As Windows.Forms.Label
        Private pictureBox5 As Windows.Forms.PictureBox
        Private CB_Spinach_Toppings As Windows.Forms.ComboBox
        Private panel11 As Windows.Forms.Panel
        Private label30 As Windows.Forms.Label
        Private label31 As Windows.Forms.Label
        Private LBL_Potato_Price As Windows.Forms.Label
        Private BTN_Potato_Order As Windows.Forms.Button
        Private LBL_Potato_Subtotal As Windows.Forms.Label
        Private label34 As Windows.Forms.Label
        Private label35 As Windows.Forms.Label
        Private label36 As Windows.Forms.Label
        Private label37 As Windows.Forms.Label
        Private CB_Potato_Crust As Windows.Forms.ComboBox
        Private CB_Potato_Size As Windows.Forms.ComboBox
        Private label38 As Windows.Forms.Label
        Private pictureBox6 As Windows.Forms.PictureBox
        Private CB_Potato_Toppings As Windows.Forms.ComboBox
        Private PNL_Custom_ImageHolder As Windows.Forms.Panel
        Private panel12 As Windows.Forms.Panel
        Private panel15 As Windows.Forms.Panel
        Private RB_Cstm_Sauce_Buf As Windows.Forms.RadioButton
        Private RB_Cstm_Sauce_BBQ As Windows.Forms.RadioButton
        Private RB_Cstm_Sauce_GP As Windows.Forms.RadioButton
        Private RB_Cstm_Sauce_Mar As Windows.Forms.RadioButton
        Private label14 As Windows.Forms.Label
        Private panel14 As Windows.Forms.Panel
        Private RB_Cstm_Crust_Pan As Windows.Forms.RadioButton
        Private RB_Cstm_Crust_HT As Windows.Forms.RadioButton
        Private RB_Cstm_Crust_Stuffed As Windows.Forms.RadioButton
        Private RB_Cstm_Crust_Thin As Windows.Forms.RadioButton
        Private label6 As Windows.Forms.Label
        Private panel13 As Windows.Forms.Panel
        Private RB_Cstm_Size_Large As Windows.Forms.RadioButton
        Private RB_Cstm_Size_Med As Windows.Forms.RadioButton
        Private RB_Cstm_Size_Small As Windows.Forms.RadioButton
        Private label5 As Windows.Forms.Label
        Private panel16 As Windows.Forms.Panel
        Private LBL_Cstm_Price As Windows.Forms.Label
        Private label15 As Windows.Forms.Label
        Private label24 As Windows.Forms.Label
        Private BTN_Cstm_Order As Windows.Forms.Button
        Private BTN_Cstm_Clear As Windows.Forms.Button
        Private PNL_Pepperoni_Cstm As Windows.Forms.Panel
        Private PB_Cstm_Pepperoni_Whole As Windows.Forms.PictureBox
        Private PB_Cstm_Pepperoni_R As Windows.Forms.PictureBox
        Private PB_Cstm_Pepperoni_L As Windows.Forms.PictureBox
        Private RB_Cstm_Pepperoni_reg As Windows.Forms.RadioButton
        Private CB_Cstm_Pepperoni As Windows.Forms.CheckBox
        Private PNL_Sausage_Cstm As Windows.Forms.Panel
        Private RB_Cstm_Sausage_Extra As Windows.Forms.RadioButton
        Private PB_Cstm_Sausage_Whole As Windows.Forms.PictureBox
        Private PB_Cstm_Sausage_R As Windows.Forms.PictureBox
        Private PB_Cstm_Sausage_L As Windows.Forms.PictureBox
        Private RB_Cstm_Sausage_Reg As Windows.Forms.RadioButton
        Private CB_Cstm_Sausage As Windows.Forms.CheckBox
        Private RB_Cstm_Pepperoni_Extra As Windows.Forms.RadioButton
        Private PNL_Onions_Cstm As Windows.Forms.Panel
        Private RB_Cstm_Onions_Extra As Windows.Forms.RadioButton
        Private PB_Cstm_Onions_Whole As Windows.Forms.PictureBox
        Private PB_Cstm_Onions_R As Windows.Forms.PictureBox
        Private PB_Cstm_Onions_L As Windows.Forms.PictureBox
        Private RB_Cstm_Onions_Reg As Windows.Forms.RadioButton
        Private CB_Cstm_Onions As Windows.Forms.CheckBox
        Private PNL_Mushrooms_Cstm As Windows.Forms.Panel
        Private RB_Cstm_Mushrooms_Extra As Windows.Forms.RadioButton
        Private PB_Cstm_Mushrooms_Whole As Windows.Forms.PictureBox
        Private PB_Cstm_Mushrooms_R As Windows.Forms.PictureBox
        Private PB_Cstm_Mushrooms_L As Windows.Forms.PictureBox
        Private RB_Cstm_Mushrooms_Reg As Windows.Forms.RadioButton
        Private CB_Cstm_Mushrooms As Windows.Forms.CheckBox
        Private PNL_Bacon_Cstm As Windows.Forms.Panel
        Private RB_Cstm_Bacon_Extra As Windows.Forms.RadioButton
        Private PB_Cstm_Bacon_Whole As Windows.Forms.PictureBox
        Private PB_Cstm_Bacon_R As Windows.Forms.PictureBox
        Private PB_Cstm_Bacon_L As Windows.Forms.PictureBox
        Private RB_Cstm_Bacon_Reg As Windows.Forms.RadioButton
        Private CB_Cstm_Bacon As Windows.Forms.CheckBox
        Private PNL_Ham_Cstm As Windows.Forms.Panel
        Private RB_Cstm_Ham_Extra As Windows.Forms.RadioButton
        Private PB_Cstm_Ham_Whole As Windows.Forms.PictureBox
        Private PB_Cstm_Ham_R As Windows.Forms.PictureBox
        Private PB_Cstm_Ham_L As Windows.Forms.PictureBox
        Private RB_Cstm_Ham_Reg As Windows.Forms.RadioButton
        Private CB_Cstm_Ham As Windows.Forms.CheckBox
        Private PNL_Olives_Cstm As Windows.Forms.Panel
        Private RB_Cstm_Olives_Extra As Windows.Forms.RadioButton
        Private PB_Cstm_Olives_Whole As Windows.Forms.PictureBox
        Private PB_Cstm_Olives_R As Windows.Forms.PictureBox
        Private PB_Cstm_Olives_L As Windows.Forms.PictureBox
        Private RB_Cstm_Olives_Reg As Windows.Forms.RadioButton
        Private CB_Cstm_Olives As Windows.Forms.CheckBox
        Private PB_Cstm_PizzaImg As Windows.Forms.PictureBox
        Private label23 As Windows.Forms.Label
        Private LV_Cart As Windows.Forms.ListView
        Private LV_Sku As Windows.Forms.ColumnHeader
        Private LV_Pizza As Windows.Forms.ColumnHeader
        Private LV_Toppings As Windows.Forms.ColumnHeader
        Private LV_Price As Windows.Forms.ColumnHeader
        Private LV_Size As Windows.Forms.ColumnHeader
        Private LV_Crust As Windows.Forms.ColumnHeader
        Private PB_Order_Notify As Windows.Forms.PictureBox
        Private panel17 As Windows.Forms.Panel
        Private panel19 As Windows.Forms.Panel
        Private BTN_Cart_Remove As Windows.Forms.Button
        Private panel18 As Windows.Forms.Panel
        Private BTN_Order_Order As Windows.Forms.Button
        Private LBL_Order_Tax As Windows.Forms.Label
        Private LBL_Order_Total As Windows.Forms.Label
        Private label40 As Windows.Forms.Label
        Private label39 As Windows.Forms.Label
        Private LBL_Order_Subtotal As Windows.Forms.Label
        Private label32 As Windows.Forms.Label
        Private button1 As Windows.Forms.Button
    End Class
End Namespace
