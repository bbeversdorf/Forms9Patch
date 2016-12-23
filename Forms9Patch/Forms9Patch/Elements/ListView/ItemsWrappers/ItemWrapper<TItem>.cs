﻿
namespace Forms9Patch
{
	class ItemWrapper<TItem> : ItemWrapper {

		#region Properties
		public new TItem Source {
			get { return (TItem)GetValue(SourceProperty); }
			set { 
				if (debugProperties) System.Diagnostics.Debug.WriteLine ("Value: update from ["+(TItem)GetValue(SourceProperty)+"] to [" + value + "]");
				if (!Equals(value,Source))
					SetValue(SourceProperty, value);
			}
		}
		#endregion


		#region Convenience
		internal void ShallowCopy(ItemWrapper<TItem> other) 
		{
			CellBackgroundColor = other.CellBackgroundColor;
			SelectedCellBackgroundColor = other.SelectedCellBackgroundColor;
			Source = other.Source;
		}
		#endregion

	}
}
