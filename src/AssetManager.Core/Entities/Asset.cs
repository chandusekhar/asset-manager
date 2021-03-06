﻿using AssetManager.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManager.Core.Entities
{
    public class Asset: Entity
    {
        [Required]
        [Display(Name ="Asset Name")]
        public string Name { get; set; }

        [Display(Name="Asset Tag")]
        public string AssetTag { get; set; }

        [ForeignKey("Models")]
        public int ModelsId { get; set; }
        public virtual AssetModels Models { get; set; }

        [Display(Name = "Serial")]
        public string Serial { get; set; }

        [Display(Name ="Purchase Date")]
        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }

        [Display(Name ="Purchase Cost")]
        [DataType(DataType.Currency)]
        public decimal PurchaseCost { get; set; }

        [Display(Name ="Order Number")]
        public string OrderNumber { get; set; }

        [Display(Name = "Note")]
        [DataType(DataType.Text)]
        public string Notes { get; set; }

        [Display(Name = "Image")]
        public string Image { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [MaxLength(1)]
        public byte Physical { get; set; }
         public DateTime DeletedAt { get; set; }

        [ForeignKey("Status")]
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public bool Archived { get; set; }

        [Display(Name = "Warrenty")]
        public int WarrantyMonths { get; set; }

        public bool Depreciate { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }

        [Display(Name = "Requestable")]
        public bool Requestable { get; set; }

        [ForeignKey("RdLocation")]
        public int RtdLocationId { get; set; }
        public virtual Location RdLocation { get; set; }

        public bool Accepted { get; set; }

        public DateTime LastCheckout { get; set; }
        public DateTime ExpectedCheckin { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public int AssignedType { get; set; }
        public int CheckoutTo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastAuditDate { get; set; }
        public DateTime NextAuditDate { get; set; }

        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
    }
}
