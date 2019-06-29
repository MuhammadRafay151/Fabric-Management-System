using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class FabricInfo

    {
        public FabricInfo(String FabricColor, string FabricName,string StitchingType, string DesignCode)
        {
          
            if(string.IsNullOrWhiteSpace(FabricColor))
            {
                this.FabricColor = string.Empty;
            }
            else
                this.FabricColor = FabricColor;
            if (string.IsNullOrWhiteSpace(FabricName))
            {
                this.FabricName = string.Empty;
            }
            else
                this.FabricName = FabricName;
            if (string.IsNullOrWhiteSpace(StitchingType))
            {
                this.Stitching_Type = string.Empty;
            }
            else
                this.Stitching_Type = StitchingType;
            if (string.IsNullOrWhiteSpace(DesignCode))
            {
                this.DesignCode = string.Empty;
            }
            else
                this.DesignCode = DesignCode;
        }
        public FabricInfo(String FabricColor, string FabricName, string DesignCode)
        {
            this.FabricColor = FabricColor;
            this.FabricName = FabricName;
            this.DesignCode = DesignCode;
           
        }
        public FabricInfo(String FabricColor, string FabricName)
        {
            this.FabricColor = FabricColor;
            this.FabricName = FabricName;
            

        }
        public FabricInfo( string FabricName)
        {
          
            this.FabricName = FabricName;

        }
        public FabricInfo()
        {

        }


        public String FabricColor { get; }
        public String FabricName { get; }
        public string Stitching_Type { get; set; }
        public string DesignCode { get; set; }
        public string DesignName { get; set; }
    }
}
