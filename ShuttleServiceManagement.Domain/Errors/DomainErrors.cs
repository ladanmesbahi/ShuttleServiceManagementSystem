using ShuttleServiceManagement.Domain.Shared;

namespace ShuttleServiceManagement.Domain.Errors
{
    public static class DomainErrors
    {
        public static class DriverName
        {
            public static readonly Error Empty = new("DriverName.Empty", "ورود نام راننده الزامی است.");
            public static readonly Error MaxLength = new("DriverName.MaxLength", "تعداد کاراکترهای نام راننده بیش از حد مجاز است.");
        }
        public static class Bus
        {
            public static class Capacity
            {
                public static readonly Error Required = new("Bus.Capacity.Required", "ورود ظرفیت اتوبوس الزامی است.");
            }
        }
    }
}
