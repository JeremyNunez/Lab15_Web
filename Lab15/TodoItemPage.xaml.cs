﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab15
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TodoItemPage : ContentPage
	{
		public TodoItemPage ()
		{
			InitializeComponent ();
		}
	}
}