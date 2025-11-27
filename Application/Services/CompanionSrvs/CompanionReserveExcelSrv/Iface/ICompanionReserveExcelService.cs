using Application.Services.CompanionSrvs.CompanionReserveExcelSrv.Dto;
using Application.Services.ProductSrvs.ProductExelSrv.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionReserveExcelSrv.Iface
{
    public interface ICompanionReserveExcelService
    {
        MemoryStream GetReserveExcel(SearchCompanionReserveExcelDto search);
    }
}
