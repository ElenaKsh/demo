using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
namespace WSUniversalLib
{
    public class Calculation
    {
        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            if (productType > 3 || productType < 1)
            {
                return -1;
            }

            if (materialType > 2 || materialType < 1)
            {
                return -1;
            }

            if (count < 0 || width < 0 || length < 0)
            {
                return -1;
            }

            return Convert.ToInt32(Math.Ceiling(width * length * GetProductTypeKoef(productType) * count + (width * length * GetProductTypeKoef(productType) * count * GetMaterialType(materialType)))); 
        }

        private double GetProductTypeKoef(int productType)
        {
            switch (productType)
            {
                case 1:
                    return 1.1;
                case 2:
                    return 2.5;
                case 3:
                    return 8.43;
            }
            return 0;
        }

        private double GetMaterialType(int materialType)
        {
            switch (materialType)
            {
                case 1:
                    return 0.003;
                case 2:
                    return 0.0012;
            }
            return 0;
        }
    }
}
