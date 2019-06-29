using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
   public class Product
    {
        string ProductName;
        String ProductId; string DesignCode;
        String Color;
        int NumberOfPieces;
        int QuantityInStock;
        double ProductPrice;
        string KameezFabric;
        String ShalwarFabric;
        String DupattaFabric;
        bool IsKameezFrontEmbroided;
        bool IsKameezBackEmbroided;
        bool IsDupattaEmbroided;
        bool IsShalwarEmbroided;
        string ImagePath;
        public Product(String ProductId, string ProductName, string DesignCode, String Color, int NumberOfPieces, int QuantityInStock, double ProductPrice, string KameezFabric, String ShalwarFabric, String DupattaFabric, bool IsKameezFrontEmbroided, bool IsKameezBackEmbroided, bool IsDupattaEmbroided, bool IsShalwarEmbroided, string ImagePath)
        {
            this.ProductName = ProductName;
            this.ProductId = ProductId;
            this.DesignCode = DesignCode;
            this.Color = Color;
            this.NumberOfPieces = NumberOfPieces;
            this.QuantityInStock = QuantityInStock;
            this.ProductPrice = ProductPrice;
            this.KameezFabric = KameezFabric;
            this.ShalwarFabric = ShalwarFabric;
            this.DupattaFabric = DupattaFabric;
            this.IsKameezFrontEmbroided = IsKameezFrontEmbroided;
            this.IsKameezBackEmbroided = IsKameezBackEmbroided;
            this.IsDupattaEmbroided = IsDupattaEmbroided;
            this.IsShalwarEmbroided = IsShalwarEmbroided;
            this.ImagePath = ImagePath;
        }
        public Product()
        {

        }
        public string PRODUCT_NAME
        {
            get { return ProductName; }
        }
        public string PRODUCT_ID
        {
            get { return ProductId; }
            set { ProductId = value; }
        }
        public string DESIGN_CODE
        {
            get { return DesignCode; }
        }
        public string COLOR
        {
            get { return Color; }
        }
        public int NUMBER_OF_PIECES
        {
            get { return NumberOfPieces; }
        }
        public int QUANTITY_IN_STOCK
        {
            get { return QuantityInStock; }
            set { QuantityInStock = value; }

        }
        public double PRODUCT_PRICE
        {
            get { return ProductPrice; }
        }
        public string KAMEEZFABRIC
        {
            get { return KameezFabric; }
        }
        public string SHALWAR_FABRIC
        {
            get { return ShalwarFabric; }
        }
        public string DUPATTA_FABRIC
        {
            get { return DupattaFabric; }
        }
        public bool IS_KAMEEZ_FRONT_EMBROIDED
        {
            get { return IsKameezFrontEmbroided; }
        }
        public bool IS_KAMEEZ_BACK_EMBROIDED
        {
            get { return IsKameezBackEmbroided; }
        }
        public bool IS_DUPATTA_EMBROIDED
        {
            get { return IsDupattaEmbroided; }
        }
        public bool IS_SHALWAR_EMBROIDED
        {
            get { return IsShalwarEmbroided; }
        }
        
        public string IMAGE_PATH
        {
            get { return ImagePath; }
        }
      
    }
}

