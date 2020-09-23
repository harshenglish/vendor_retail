using System.Collections.Generic;
using Vendor.Model;

namespace Vendor.Repository
{
    public interface IVendorDetailRepo
    {
        List<VendorDetail> GetDetails();
        List<VendorDetail> GetVenderbyId(int ProductId);
    }
}