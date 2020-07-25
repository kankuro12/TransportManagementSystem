using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControls
{
    public static class ErrorInterFace
    {
        public  class Error
        {
            public int errorcode { get; set; }
            public string errormessage { get; set; }
        }
        public static List<Error> Errors { get; set; } 

        public static Error getErrorMessage(int errcode)
        {
            if (Errors == null)
            {
                Errors = new List<Error>();
                Errors.Add(new Error()
                {
                    errorcode = 0,
                    errormessage = "Error Cannot be identified"
                });
                Errors.Add(new Error()
                {
                    errorcode = 1,
                    errormessage = "Token Mismatch"
                });
                Errors.Add(new Error()
                {
                    errorcode = 2,
                    errormessage = "Token Not Found"
                });

                Errors.Add(new Error()
                {
                    errorcode = 3,
                    errormessage = "Token Generation Failed"
                });
                Errors.Add(new Error()
                {
                    errorcode = 4,
                    errormessage = "Token Validity Failed"
                });
                Errors.Add(new Error()
                {
                    errorcode = 5,
                    errormessage = "Bill Cannot be saved"
                });

                Errors.Add(new Error()
                {
                    errorcode = 6,
                    errormessage = "Bill Cannot be Handled"
                });
            }

            return Errors.FirstOrDefault(o => o.errorcode == errcode);
        }
    }
}
