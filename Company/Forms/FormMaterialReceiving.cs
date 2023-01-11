using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Company.Models;
using Syncfusion.WinForms.Controls;
using System.Data;
using MySql.Data.MySqlClient;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Events;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.Input.Enums;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Globalization;
namespace Company.Forms
{
    public partial class FormMaterialReceiving : SfForm
    {
        List<Item> items;
        List<User> users;
        List<Unit> units;
        BindingList<TableData> tableData = new BindingList<TableData>();

        NumberFormatInfo numberFormat = Application.CurrentCulture.NumberFormat.Clone() as NumberFormatInfo;
        
        public FormMaterialReceiving()
        {
            InitializeComponent();
            init_data();
            init_table();
        }

        private void init_data()
        {
            using (var db = new DatabaseContext())
            {
                var itemsQuery = from itms in db.Items
                                 select itms;
                items = itemsQuery.ToList<Item>();

                var usersQuery = from users in db.Users
                                 select users;
                users = usersQuery.ToList<User>();

                var unitsQuery = from units in db.units
                                 select units;
                units = unitsQuery.ToList<Unit>();
            }
        }
        private void init_table()
        {
            numberFormat.CurrencyDecimalDigits = 0;
            numberFormat.CurrencyGroupSizes = new int[] { };
            sfDataGrid1.CellComboBoxSelectionChanged += onCellComboBoxChanged;
            sfDataGrid1.AutoGeneratingColumn += sfDataGrid1AutoGeneratingColumn;
            sfDataGrid1.DataSource = tableData;
            sfDataGrid1.CurrentCellEndEdit += onTextChanged;
            sfDataGrid1.EditorSelectionBehavior = EditorSelectionBehavior.SelectAll;
            sfDataGrid1.SelectionUnit = SelectionUnit.Cell;
            sfDataGrid1.DrawCell += SfDataGrid1DrawCell;


            comboBoxFrom.DataSource = users;
            comboBoxTo.DataSource = users;
            comboBoxApprovedBy.DataSource = users;
            comboBoxRequestedBy.DataSource = users;


        }

        private void SfDataGrid1DrawCell(object sender, DrawCellEventArgs e)
        {
            if (sfDataGrid1.ShowRowHeader && e.RowIndex != 0)
            {
                if (e.ColumnIndex == 0)
                {
                    e.DisplayText = e.RowIndex.ToString();
                }

            }
        }
        private void onTextChanged(object sender, CurrentCellEndEditEventArgs e) {
            if (e.DataColumn.GridColumn.MappingName == "quantity")
            {
                var row = e.DataRow.RowData as TableData;
                row.totalPrice = row.quantity * row.unitPrice;
            }
        }

        private void sfDataGrid1AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            var numberFormatCurrency = Application.CurrentCulture.NumberFormat.Clone() as NumberFormatInfo;
            numberFormatCurrency.NumberDecimalDigits = 2;
            numberFormatCurrency.CurrencySymbol = "Birr ";
            numberFormatCurrency.NumberGroupSizes = new int[] { };
            Console.WriteLine(e.Column.MappingName);
            if (e.Column.MappingName == "itemName")
            {
                e.Column = new GridComboBoxColumn() { MappingName = "itemName", HeaderText = "Description", DataSource = items, DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDown, AutoCompleteMode = AutoCompleteMode.SuggestAppend  };
            }

            if (e.Column.MappingName == "unit")
            {
                e.Column = new GridComboBoxColumn() { MappingName = "unit", HeaderText = "Unit", DataSource = units, AllowEditing = false };
            }

            if (e.Column.MappingName == "quantity")
            {
                numberFormat = Application.CurrentCulture.NumberFormat.Clone() as NumberFormatInfo;
                numberFormat.NumberGroupSizes = new int[] { };
                numberFormat.NumberDecimalDigits = 0;

                e.Column = new GridNumericColumn()
                {
                    HeaderText = "Quantity",
                    MappingName = "quantity",
                    InterceptArrowKeys = true,
                    MinValue = 0,
                    FormatMode = FormatMode.Numeric,
                    NumberFormatInfo = numberFormat,
                };
            }

            if (e.Column.MappingName == "totalPrice")
            {
                e.Column = new GridNumericColumn() { MappingName = "totalPrice", HeaderText = "Total Price", AllowEditing = false, FormatMode = FormatMode.Currency, NumberFormatInfo = numberFormatCurrency };
            }

            if (e.Column.MappingName == "unitPrice")
            {
                e.Column = new GridNumericColumn() { MappingName = "unitPrice", HeaderText = "Unit Price", AllowEditing = false, FormatMode = FormatMode.Currency ,NumberFormatInfo = numberFormatCurrency };
            }

        }

        private void onCellComboBoxChanged(object sender, CellComboBoxSelectionChangedEventArgs e)
        {
            if (e.GridColumn.MappingName == "itemName")
            {
                var itemDetails = e.SelectedItem as Item;
                var row = e.Record as TableData;
                row.item = itemDetails;
                if (itemDetails != null)
                {
                    row.unitPrice = itemDetails.price;
                    row.totalPrice = itemDetails.price * row.quantity;
                    row.unit = itemDetails.unit.ToString();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MaterialReceiving_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        class TableData
        {
            public Item item { get; set; }

            public string itemName { get; set; }  
            public int quantity { get; set; }
            public string unit { get; set; }
            [ReadOnly(true)]
            [DataType(DataType.Currency)]
            [Display(Name = "Unit Price", Description = "The price of one unit of the item")]
            [Editable(false)]
            public double unitPrice { get; set; }
            [DataType(DataType.Currency)]
            public double totalPrice { get; set; }
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            List<ItemQuantity> itemQuantities = new List<ItemQuantity>();

            foreach (TableData td in tableData)
            {
                itemQuantities.Add(new ItemQuantity() { item=td.item, quantity=td.quantity });
            }
            Models.MaterialReceiving mr = new Models.MaterialReceiving() { itemQuantities = itemQuantities,
                approvedBy = comboBoxApprovedBy.SelectedItem as User,
                receivedBy = comboBoxRequestedBy.SelectedItem as User,
                from = comboBoxRequestedBy.SelectedItem.ToString(),
                
            };
        }
    }
}
