// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LondonBike {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("TripLogDetailViewController")]
	public partial class TripLogDetailViewController {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UILabel __mt_EndLabel;
		
		private MonoTouch.MapKit.MKMapView __mt_MapView;
		
		private MonoTouch.UIKit.UILabel __mt_StartLabel;
		
		private MonoTouch.UIKit.UILabel __mt_TimeLabel;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("EndLabel")]
		private MonoTouch.UIKit.UILabel EndLabel {
			get {
				this.__mt_EndLabel = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("EndLabel")));
				return this.__mt_EndLabel;
			}
			set {
				this.__mt_EndLabel = value;
				this.SetNativeField("EndLabel", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("MapView")]
		private MonoTouch.MapKit.MKMapView MapView {
			get {
				this.__mt_MapView = ((MonoTouch.MapKit.MKMapView)(this.GetNativeField("MapView")));
				return this.__mt_MapView;
			}
			set {
				this.__mt_MapView = value;
				this.SetNativeField("MapView", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("StartLabel")]
		private MonoTouch.UIKit.UILabel StartLabel {
			get {
				this.__mt_StartLabel = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("StartLabel")));
				return this.__mt_StartLabel;
			}
			set {
				this.__mt_StartLabel = value;
				this.SetNativeField("StartLabel", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("TimeLabel")]
		private MonoTouch.UIKit.UILabel TimeLabel {
			get {
				this.__mt_TimeLabel = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("TimeLabel")));
				return this.__mt_TimeLabel;
			}
			set {
				this.__mt_TimeLabel = value;
				this.SetNativeField("TimeLabel", value);
			}
		}
	}
}