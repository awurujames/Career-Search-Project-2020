﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Career_Search_Project.Areas.Admin.ViewModel
{
    public class AccountLoginViewModel
    {
			[Required(ErrorMessage = "Please enter your email address")]
			[EmailAddress]
			public string Email { get; set; }
			[Required(ErrorMessage = "Please enter your password")]
			[DataType(DataType.Password)]
			public string Password { get; set; }
			public bool RememberMe { get; set; }
		

	}
}
