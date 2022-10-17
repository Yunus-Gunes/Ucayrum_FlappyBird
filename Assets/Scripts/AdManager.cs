using UnityEngine;
using GoogleMobileAds.Api;


public class AdManager : MonoBehaviour
{
    public static bool hp = false;
    private bool reklamGo = false;
    
    
    private BannerView bannerView;
    private InterstitialAd interstitial;

    public void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });

        this.RequestBanner();
        this.RequestInterstitial();

    }
    public void Update()
    {
        if (reklamGo == false)
        {
            if (hp == false)
            {

                if (this.interstitial.IsLoaded())
                {
                    this.interstitial.Show();
                    reklamGo = false;
                }


            }
        }
    }

    
    private void RequestBanner()
    {

#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3778488598855493/1523456076";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3778488598855493/1386294083";
#else
            string adUnitId = "unexpected_platform";
#endif

        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the banner with the request.
        this.bannerView.LoadAd(request);
    }
    
    


    private void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3778488598855493/9438912029";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3778488598855493/5133967402";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }



}
