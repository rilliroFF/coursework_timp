using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky_Utility  
{
    public static class WC
    {
        public const string ImagePath = @"\images\product\";
        public const string SessionCart = "ShoppingCartSession";
        public const string SessionInquiryId = "InquirySession";
        public const string AdminRole = "Admin";
        public const string CustomerRole = "Customer";
        public const string WorkWarehouse = "Работник склада";
        public const string SalesDepartment = "Отдел продаж";


        public const string CategoryName = "Category";
        public const string ApplicationTypeName = "ApplicationType";

        public const string Success = "Success";
        public const string Error = "Error";

        public const string StatusPending = "Ожидает";
        public const string StatusApproved = "Одобрен";
        public const string StatusInProcess = "В обработке";
        public const string StatusShipped = "Отгружен";
        public const string StatusCancelled = "Отменён";
        public const string StatusRefunded = "Возвращен";

        public static readonly IEnumerable<string> listStatus = new ReadOnlyCollection<string>(
            new List<string>
            {
                StatusApproved,StatusCancelled,StatusInProcess,StatusPending,StatusRefunded,StatusShipped
            });
        }
    
}
