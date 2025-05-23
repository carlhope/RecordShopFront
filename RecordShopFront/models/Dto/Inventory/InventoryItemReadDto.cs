﻿using RecordShop.Common.Dto.Music;

namespace RecordShop.Common.Dto.Inventory
{
    public class InventoryItemReadDto
    {
        public int Id { get; set; }
        
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        //navigation properties
        public MusicProductReadDto MusicProduct { get; set; }
    }
}
