﻿using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Xamarin.Forms.Build.Tasks
{
	public class GetTasksAbi : Task
	{
		[Output]
		public string AbiVersion { get; } = "5";

		public override bool Execute()
			=> true;
	}
}