using Business;
using DataTransferObject;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Vml;
using Presentation.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentation.Forms
{
    public partial class UseServide : Form
    {
        ServiceB ServiceB;
        string Id;
        private UseServide()
        {
            InitializeComponent();
            ServiceB = new ServiceB();
        }

        public UseServide(string bookingId) : this()
        {
            Id = bookingId;
            FirstLoad();
        }

        private void FirstLoad()
        {
            dataGridView.DataSource = ServiceB.GetAllServices();
            DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
            btnCol.HeaderText = "Thêm";
            btnCol.Text = "Add";
            btnCol.UseColumnTextForButtonValue = true;
            btnCol.Name = "btnAdd";
            btnCol.Width = 60;
            btnCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns.Add(btnCol);

            HienThiCacDichVuDaThem();
        }

        private void HienThiCacDichVuDaThem()
        {
            flowPanelAdded.Controls.Clear();
            var list = ServiceB.GetAllServicesUsage(Id);
            if (list != null && list.Count > 0)
            {
                foreach (var service in list)
                {
                    InitializeItemAdded(service);
                }
                flowPanelAdded.BringToFront();
            }
        }

        private void LoadAgain()
        {
            flowPanelAdd.Controls.Clear();
            HienThiCacDichVuDaThem();
        }

        private void InitializeItemAdded(ServiceUsageDetailDTO serviceUsageDetailDTO)
        {
            itemServiceAdded itemServiceAdded = new itemServiceAdded(serviceUsageDetailDTO);
            flowPanelAdded.Controls.Add(itemServiceAdded);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView.Columns["btnAdd"].Index)
            {
                string sname = dataGridView.Rows[e.RowIndex].Cells["SName"].Value.ToString();
                string sprice = dataGridView.Rows[e.RowIndex].Cells["SPrice"].Value.ToString();
                string sdescription = dataGridView.Rows[e.RowIndex].Cells["SDescription"].Value.ToString();
                AddService(new ServiceDTO
                {
                    SName = sname,
                    SPrice = Convert.ToDecimal(sprice),
                    SDescription = sdescription
                });
            }
        }

        private void AddService(ServiceDTO serviceDTO)
        {
            foreach (itemService i in flowPanelAdd.Controls)
            {
                if (i.SName.Text == serviceDTO.SName)
                {
                    try
                    {
                        int num = Convert.ToInt32(i.txtQuantity.Text);
                        num++;
                        i.txtQuantity.Text = num.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    return;
                }
            }
            itemService itemService = new itemService(serviceDTO);
            itemService.Width = 460;
            itemService.Margin = new Padding(0, 6, 0, 0);
            flowPanelAdd.Controls.Add(itemService);
        }

        private void ThemRecordVaoServiceUsage()
        {
            ServiceB.CreateRequest(Id);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //  try
            {
                if (flowPanelAdd.Controls.Count > 0)
                {
                    ServiceB.CreateRequest(Id);
                    List<ServiceUsageDetailDTO> list = new List<ServiceUsageDetailDTO>();
                    foreach (itemService i in flowPanelAdd.Controls)
                    {
                        list.Add(new ServiceUsageDetailDTO
                        {
                            SUId = Id,
                            SName = i.SName.Text,
                            EId = ConfigPresentation.CURRENT_EId,
                            Quantity = Convert.ToInt32(i.txtQuantity.Text)
                        });
                    }
                    if (list.Count > 0)
                    {
                        //  try
                        {
                            if (ServiceB.Request(list))
                            {
                                MessageBox.Show("Thành công");
                            }
                        }
                        //catch (Exception ex)
                        //{
                        //    MessageBox.Show(ex.Message);
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Không có dịch vụ nào được thêm");
                    }
                    LoadAgain();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Chưa có dịch vụ nào được thêm",
                                    "Cảnh báo",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Cancel) { this.Close(); }
                }
            }
            //catch (Exception ex)
            //{

            //    //throw;
            //    MessageBox.Show(ex.Message);
            //}
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
