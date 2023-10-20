﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.Business.Dtos.Category
{
	public class CreateOrEditCategoryDto
	{
		[Required(ErrorMessage = "{0} boş geçilemez.")]
		[DisplayName("Kategori Adı")]
		[StringLength(40, ErrorMessage = "{0} {1} karakterden fazla olamaz!")]
		[MinLength(3, ErrorMessage = "{0} en az {1} karakter olabilir!")]
		public string CategoryName { get; set; }
	}
}