﻿using RecordShop.Common.Dto.Music;

namespace RecordShop.Common.Dto.Inventory
{
    public class InventoryItemWriteDto
    {
        public int MusicProductId {  get; set; }
        
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
