﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StoreShop.Data
{
    public class SettingModel
    {
        public List<StoreModel> StoreModels { get; set; }//Only visible to customer admin(not visible to store admin)
        public List<BrandModel> BrandModels { get; set; }
        public List<ProductTypeModel> ProductTypeModels { get; set; }
        public List<UserModel> UserModels { get; set; }
    }
}