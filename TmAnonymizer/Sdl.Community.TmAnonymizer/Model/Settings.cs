﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdl.Community.TmAnonymizer.Model
{
	public class Settings
	{
		public bool Accepted { get; set; }
		public bool AlreadyAddedDefaultRules { get; set; }
		public ObservableCollection<Rule> Rules { get; set; }
	}
}
