﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
	public class Cart
	{
		[Key]
		[ScaffoldColumn(false)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public string? UserId { get; set; }
		public ApplicationUser? User { get; set; }

		public List<CartItem> CartItems { get; set; }
		public bool IsCheckout { get; set; }
	}
}
