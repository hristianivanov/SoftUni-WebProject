﻿namespace CarRentalSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static Common.EntityValidationConstants.Contact;

    public class Contact
    {
        public Contact()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [MaxLength(EmailMaxLength)]
        public string? Email { get; set; }
        [Required, MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; }

        [ForeignKey(nameof(Customer))]
        public Guid CustomerId { get; set; }
        public virtual ApplicationUser Customer { get; set; } = null!;
    }
}