using UnityEngine;
using GoogleMobileAds.Api;
using System;

//Banner ad
public class GameAds : MonoBehaviour
{
	private BannerView adBanner;

	private string idApp, idBanner;


	void Start ()
	{
		idBanner = "ca-app-pub-3940256099942544/6300978111";

		MobileAds.Initialize(initStatus => { });

		RequestBannerAd();
	}



	#region Banner Methods --------------------------------------------------

	public void RequestBannerAd ()
	{
		adBanner = new BannerView (idBanner, AdSize.Banner, AdPosition.Bottom);
		AdRequest request = AdRequestBuild ();
		adBanner.LoadAd (request);
	}

	public void DestroyBannerAd ()
	{
		if (adBanner != null)
			adBanner.Destroy();
	}

	#endregion

	
	//------------------------------------------------------------------------
	AdRequest AdRequestBuild ()
	{
		return new AdRequest.Builder().Build();
	}

	void OnDestroy ()
	{
		DestroyBannerAd ();
	}

}
