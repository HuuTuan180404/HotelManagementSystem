using Business;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.User_Controls
{
    public partial class itemServiceAdded : UserControl
    {
        ServiceDTO ServiceDTO;
        ServiceB ServiceB;
        private itemServiceAdded()
        {
            InitializeComponent();
            ServiceB = new ServiceB();
        }

        public itemServiceAdded(ServiceUsageDetailDTO serviceUsageDetailDTO) : this()
        {
            ServiceDTO = ServiceB.GetServiceBySName(serviceUsageDetailDTO.SName);

            SName.Text = serviceUsageDetailDTO.SName;
            SPrice.Text = ServiceDTO.SPrice.ToString();
            Quantity.Text = serviceUsageDetailDTO.Quantity.ToString();
            Total.Text = $"{ServiceDTO.SPrice * serviceUsageDetailDTO.Quantity}";
        }
    }
}
