USE [pos_db]
GO
/****** Object:  Table [dbo].[billing_type]    Script Date: 6/21/2020 1:39:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[billing_type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type_name] [varchar](50) NULL,
 CONSTRAINT [PK_billing_type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cus_type]    Script Date: 6/21/2020 1:39:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cus_type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type_name] [varchar](50) NULL,
	[description] [varchar](100) NULL,
 CONSTRAINT [PK_cus_type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[customer]    Script Date: 6/21/2020 1:39:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[branch_id] [int] NULL,
	[name] [varchar](100) NULL,
	[address] [varchar](100) NULL,
	[nic] [varchar](20) NULL,
	[telephone] [varchar](20) NULL,
	[mobile] [varchar](20) NULL,
	[email] [varchar](100) NULL,
	[type_id] [int] NULL,
	[created_date] [varchar](50) NULL,
	[created_by] [int] NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[direct_item_stock]    Script Date: 6/21/2020 1:39:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[direct_item_stock](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NULL,
	[supplier_id] [int] NULL,
	[created_by] [int] NULL,
	[discount] [varchar](50) NULL,
	[qty] [varchar](50) NULL,
	[created_date] [varchar](50) NULL,
	[price] [varchar](50) NULL,
 CONSTRAINT [PK_direct_sale_item_stock] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[emp_type]    Script Date: 6/21/2020 1:39:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[emp_type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type_name] [varchar](50) NULL,
	[description] [varchar](50) NULL,
 CONSTRAINT [PK_emp_type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[employee]    Script Date: 6/21/2020 1:39:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[employee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[branch_id] [int] NULL,
	[name] [varchar](100) NULL,
	[address] [varchar](100) NULL,
	[province] [varchar](50) NULL,
	[nic] [varchar](20) NULL,
	[mobile] [varchar](20) NULL,
	[email] [varchar](100) NULL,
	[created_date] [varchar](50) NULL,
	[type_id] [int] NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[invoice]    Script Date: 6/21/2020 1:39:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[invoice](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ticket_id] [int] NULL,
	[billing_type] [int] NULL,
	[created_by] [int] NULL,
	[total] [varchar](50) NULL,
	[cus_id] [int] NULL,
	[emp_id] [int] NULL,
	[total_discount] [varchar](50) NULL,
 CONSTRAINT [PK_invoice] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[invoiced_product]    Script Date: 6/21/2020 1:39:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[invoiced_product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[inv_id] [int] NULL,
	[product_id] [int] NULL,
	[qty] [int] NULL,
	[item_discount] [varchar](50) NULL,
	[product_total] [varchar](50) NULL,
 CONSTRAINT [PK_invoiced_product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[login]    Script Date: 6/21/2020 1:39:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[login](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [varchar](50) NULL,
	[password] [varchar](500) NULL,
	[emp_id] [int] NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[meta_data]    Script Date: 6/21/2020 1:39:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[meta_data](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[company_id] [int] NULL,
	[branch_id] [int] NULL,
 CONSTRAINT [PK_meta_data] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[my_tables]    Script Date: 6/21/2020 1:39:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[my_tables](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[table_name] [varchar](50) NULL,
	[created_by] [int] NULL,
	[created_date] [varchar](50) NULL,
 CONSTRAINT [PK_my_tables] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pro_category]    Script Date: 6/21/2020 1:39:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pro_category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cat_code] [varchar](100) NULL,
	[cat_name] [varchar](50) NULL,
	[created_date] [varchar](50) NULL,
	[branch_id] [int] NULL,
	[created_by] [int] NULL,
 CONSTRAINT [PK_product_category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[product]    Script Date: 6/21/2020 1:39:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[pro_code] [varchar](100) NULL,
	[barcode] [varchar](100) NULL,
	[name] [varchar](50) NULL,
	[selling_price] [varchar](50) NULL,
	[discount] [varchar](50) NULL,
	[created_date] [varchar](50) NULL,
	[created_by] [int] NULL,
	[cat_id] [int] NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[raw_item_stock]    Script Date: 6/21/2020 1:39:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[raw_item_stock](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NULL,
	[supplier_id] [int] NULL,
	[created_by] [int] NULL,
	[discount] [varchar](50) NULL,
	[qty] [varchar](50) NULL,
	[unit] [varchar](50) NULL,
	[availlable_stock] [varchar](50) NULL,
	[created_date] [varchar](50) NULL,
	[price] [varchar](50) NULL,
 CONSTRAINT [PK_raw_item_stock] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[raw_products]    Script Date: 6/21/2020 1:39:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[raw_products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[pro_code] [varchar](50) NULL,
	[pro_name] [varchar](100) NULL,
	[branch_id] [int] NULL,
	[sale_price] [varchar](50) NULL,
	[discount] [varchar](50) NULL,
	[created_date] [varchar](50) NULL,
	[created_by] [int] NULL,
	[barcode] [varchar](500) NULL,
 CONSTRAINT [PK_raw_products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[supplier_tbl]    Script Date: 6/21/2020 1:39:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[supplier_tbl](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NULL,
	[address] [varchar](200) NULL,
	[mobile] [varchar](20) NULL,
	[email] [varchar](50) NULL,
	[created_by] [int] NULL,
	[created_date] [varchar](50) NULL,
	[branch_id] [int] NULL,
 CONSTRAINT [PK_supplier_tbl] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[temp_bill_table]    Script Date: 6/21/2020 1:39:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[temp_bill_table](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NULL,
	[ticket_id] [int] NULL,
	[qty] [int] NULL,
	[item_discount] [varchar](10) NULL,
 CONSTRAINT [PK_temp_bill_table] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ticket]    Script Date: 6/21/2020 1:39:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ticket](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[billing_type] [int] NULL,
	[table_id] [int] NULL,
	[is_hold] [int] NULL,
	[created_by] [int] NULL,
	[created_date] [varchar](50) NULL,
	[total] [varchar](50) NULL,
	[cus_id] [int] NULL,
	[emp_id] [int] NULL,
	[total_discount] [varchar](10) NULL,
 CONSTRAINT [PK_ticket] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[customer]  WITH CHECK ADD  CONSTRAINT [FK_customer_cus_type] FOREIGN KEY([type_id])
REFERENCES [dbo].[cus_type] ([id])
GO
ALTER TABLE [dbo].[customer] CHECK CONSTRAINT [FK_customer_cus_type]
GO
ALTER TABLE [dbo].[direct_item_stock]  WITH CHECK ADD  CONSTRAINT [FK_direct_sale_item_stock_product_id] FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([id])
GO
ALTER TABLE [dbo].[direct_item_stock] CHECK CONSTRAINT [FK_direct_sale_item_stock_product_id]
GO
ALTER TABLE [dbo].[direct_item_stock]  WITH CHECK ADD  CONSTRAINT [FK_direct_sale_item_stock_supplier] FOREIGN KEY([supplier_id])
REFERENCES [dbo].[supplier_tbl] ([id])
GO
ALTER TABLE [dbo].[direct_item_stock] CHECK CONSTRAINT [FK_direct_sale_item_stock_supplier]
GO
ALTER TABLE [dbo].[employee]  WITH CHECK ADD  CONSTRAINT [FK_employee_branch_code] FOREIGN KEY([type_id])
REFERENCES [dbo].[emp_type] ([id])
GO
ALTER TABLE [dbo].[employee] CHECK CONSTRAINT [FK_employee_branch_code]
GO
ALTER TABLE [dbo].[invoice]  WITH CHECK ADD  CONSTRAINT [FK_invoice_billing_type] FOREIGN KEY([billing_type])
REFERENCES [dbo].[billing_type] ([id])
GO
ALTER TABLE [dbo].[invoice] CHECK CONSTRAINT [FK_invoice_billing_type]
GO
ALTER TABLE [dbo].[invoice]  WITH CHECK ADD  CONSTRAINT [FK_invoice_customer] FOREIGN KEY([cus_id])
REFERENCES [dbo].[customer] ([id])
GO
ALTER TABLE [dbo].[invoice] CHECK CONSTRAINT [FK_invoice_customer]
GO
ALTER TABLE [dbo].[invoice]  WITH CHECK ADD  CONSTRAINT [FK_invoice_employee] FOREIGN KEY([emp_id])
REFERENCES [dbo].[employee] ([id])
GO
ALTER TABLE [dbo].[invoice] CHECK CONSTRAINT [FK_invoice_employee]
GO
ALTER TABLE [dbo].[invoice]  WITH CHECK ADD  CONSTRAINT [FK_invoice_ticket] FOREIGN KEY([ticket_id])
REFERENCES [dbo].[ticket] ([id])
GO
ALTER TABLE [dbo].[invoice] CHECK CONSTRAINT [FK_invoice_ticket]
GO
ALTER TABLE [dbo].[invoiced_product]  WITH CHECK ADD  CONSTRAINT [FK_invoiced_product_invoice] FOREIGN KEY([inv_id])
REFERENCES [dbo].[invoice] ([id])
GO
ALTER TABLE [dbo].[invoiced_product] CHECK CONSTRAINT [FK_invoiced_product_invoice]
GO
ALTER TABLE [dbo].[invoiced_product]  WITH CHECK ADD  CONSTRAINT [FK_invoiced_product_product] FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([id])
GO
ALTER TABLE [dbo].[invoiced_product] CHECK CONSTRAINT [FK_invoiced_product_product]
GO
ALTER TABLE [dbo].[login]  WITH CHECK ADD  CONSTRAINT [FK_login_employee] FOREIGN KEY([emp_id])
REFERENCES [dbo].[employee] ([id])
GO
ALTER TABLE [dbo].[login] CHECK CONSTRAINT [FK_login_employee]
GO
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK_product_catego] FOREIGN KEY([cat_id])
REFERENCES [dbo].[pro_category] ([id])
GO
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK_product_catego]
GO
ALTER TABLE [dbo].[raw_item_stock]  WITH CHECK ADD  CONSTRAINT [FK_raw_stock_product_id] FOREIGN KEY([product_id])
REFERENCES [dbo].[raw_products] ([id])
GO
ALTER TABLE [dbo].[raw_item_stock] CHECK CONSTRAINT [FK_raw_stock_product_id]
GO
ALTER TABLE [dbo].[raw_item_stock]  WITH CHECK ADD  CONSTRAINT [FK_raw_stock_supplier] FOREIGN KEY([supplier_id])
REFERENCES [dbo].[supplier_tbl] ([id])
GO
ALTER TABLE [dbo].[raw_item_stock] CHECK CONSTRAINT [FK_raw_stock_supplier]
GO
ALTER TABLE [dbo].[temp_bill_table]  WITH CHECK ADD  CONSTRAINT [FK_temp_bill_table_product_item] FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([id])
GO
ALTER TABLE [dbo].[temp_bill_table] CHECK CONSTRAINT [FK_temp_bill_table_product_item]
GO
ALTER TABLE [dbo].[temp_bill_table]  WITH CHECK ADD  CONSTRAINT [FK_temp_bill_table_ticket_id] FOREIGN KEY([ticket_id])
REFERENCES [dbo].[ticket] ([id])
GO
ALTER TABLE [dbo].[temp_bill_table] CHECK CONSTRAINT [FK_temp_bill_table_ticket_id]
GO
ALTER TABLE [dbo].[ticket]  WITH CHECK ADD  CONSTRAINT [FK_ticket_billing_type] FOREIGN KEY([billing_type])
REFERENCES [dbo].[billing_type] ([id])
GO
ALTER TABLE [dbo].[ticket] CHECK CONSTRAINT [FK_ticket_billing_type]
GO
ALTER TABLE [dbo].[ticket]  WITH CHECK ADD  CONSTRAINT [FK_ticket_customer] FOREIGN KEY([cus_id])
REFERENCES [dbo].[customer] ([id])
GO
ALTER TABLE [dbo].[ticket] CHECK CONSTRAINT [FK_ticket_customer]
GO
ALTER TABLE [dbo].[ticket]  WITH CHECK ADD  CONSTRAINT [FK_ticket_employee] FOREIGN KEY([emp_id])
REFERENCES [dbo].[employee] ([id])
GO
ALTER TABLE [dbo].[ticket] CHECK CONSTRAINT [FK_ticket_employee]
GO
ALTER TABLE [dbo].[ticket]  WITH CHECK ADD  CONSTRAINT [FK_ticket_table] FOREIGN KEY([table_id])
REFERENCES [dbo].[my_tables] ([id])
GO
ALTER TABLE [dbo].[ticket] CHECK CONSTRAINT [FK_ticket_table]
GO
