using System;
namespace ZarinPalCore
{
    public class VerificationResponse
    {

        public bool IsSuccess { get { return Status == 100; } set { this.IsSuccess = value; } }
        public String RefID { get; set; }
        public int Status { get; set; }

    }
}
