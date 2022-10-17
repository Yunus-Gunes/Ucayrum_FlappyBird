using UnityEngine;
using GoogleMobileAds.Api;
using System;
using UnityEngine.UI;

public class AdManager2 : MonoBehaviour
{
    
    private RewardedAd rewardedAd;

    //Change tip image
    public Image oldImage;
    public Sprite newImage;

    public void Start()
    {
        string adUnitId;
#if UNITY_ANDROID
        adUnitId = "ca-app-pub-3778488598855493/9526272436";
#elif UNITY_IPHONE
            adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
            adUnitId = "unexpected_platform";
#endif

        

        this.rewardedAd = new RewardedAd(adUnitId);
        // Called when an ad request has successfully loaded.

        // Called when an ad request has successfully loaded.
        this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request);
    }

    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        oldImage.sprite = newImage;
    }

    public void UserChoseToWatchAd()
    {
        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
        }
    }
    
}
