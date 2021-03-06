﻿using System.Windows;
using FlexCharts.Helpers.DependencyHelpers;

namespace FlexCharts.MaterialDesign.Providers
{
	public class GradientMaterialStop : DependencyObject
	{
		public static readonly DependencyProperty MaterialSetProperty = DP.Register(
			new Meta<GradientMaterialStop, MaterialSetOLD>());
		public static readonly DependencyProperty OffsetProperty = DP.Register(
			new Meta<GradientMaterialStop, double>());

		public GradientMaterialStop() { }

		public GradientMaterialStop(MaterialSetOLD materialSet, double offset = 1)
		{
			MaterialSet = materialSet;
			Offset = offset;
		}

		public MaterialSetOLD MaterialSet
		{
			get { return (MaterialSetOLD)GetValue(MaterialSetProperty); }
			set { SetValue(MaterialSetProperty, value); }
		}
		public double Offset
		{
			get { return (double)GetValue(OffsetProperty); }
			set { SetValue(OffsetProperty, value); }
		}
	}
}
