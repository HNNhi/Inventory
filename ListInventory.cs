using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using QuanlyKho1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKho1
{
    public partial class ListInventory : Form
    {
        public ListInventory()
        {
            InitializeComponent();
        }
        Context db = new Context();

        private void ListInventory_Load(object sender, EventArgs e)
        {
            ReportViewer reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };
            reportViewer.LocalReport.DataSources.Add(new
           ReportDataSource("DataSet1", db.Inventory.Select(p => new {
               p.InventoryID,
               p.NameInventory,
               p.Address,

           }).ToList()));

            reportViewer.Dock = DockStyle.Fill;
            reportViewer.LocalReport.ReportPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
           "\\ReporInventory.rdlc";
            Controls.Add(reportViewer);
            reportViewer.RefreshReport();

        }
    }
}
