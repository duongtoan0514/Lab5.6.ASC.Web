namespace ASC.Utilities
{
    public static class Constants
    {
        // Định nghĩa các trạng thái của yêu cầu dịch vụ
        public enum Status
        {
            New,
            In_Progress,
            Wait_For_Customer,
            Resolved,
            Closed
        }
    }
}