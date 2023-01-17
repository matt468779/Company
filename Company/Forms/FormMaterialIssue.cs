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
    public partial class FormMaterialIssue : SfForm
    {
        List<Item> items;
        List<User> users;
        List<Unit> units;
        BindingList<TableData> tableData = new BindingList<TableData>();
        public FormMaterialIssue()
        {
            InitializeComponent();
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
            //numberFormat.CurrencyDecimalDigits = 0;
            //numberFormat.CurrencyGroupSizes = new int[] { };
            //sfDataGrid1.CellComboBoxSelectionChanged += onCellComboBoxChanged;
            //sfDataGrid1.AutoGeneratingColumn += sfDataGrid1AutoGeneratingColumn;
            sfDataGrid1.DataSource = tableData;
            
            //sfDataGrid1.CurrentCellEndEdit += onTextChanged;
            //sfDataGrid1.EditorSelectionBehavior = EditorSelectionBehavior.SelectAll;
            //sfDataGrid1.SelectionUnit = SelectionUnit.Cell;
            //sfDataGrid1.DrawCell += SfDataGrid1DrawCell;


            comboBoxFrom.DataSource = users;
            comboBoxTo.DataSource = users;
            comboBoxApprovedBy.DataSource = users;
            comboBoxRequestedBy.DataSource = users;


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
    }
}
