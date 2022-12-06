﻿using Newtonsoft.Json;

namespace TikTok.ApiClient.Entities
{
    /// <summary>
    /// Contain report metrics available at TikTok Reporting endpoint.
    /// See <a href="https://ads.tiktok.com/marketing_api/docs?id=1701890951192578"></a>
    /// </summary>
    public class ReportResponseMetric : IApiEntity
    {
        [JsonProperty("total_add_payment_info")]
        public string TotalAddPaymentInfo { get; set; }

        [JsonProperty("total_in_app_ad_click")]
        public string TotalInAppAdClick { get; set; }

        [JsonProperty("total_unlock_achievement_value")]
        public string TotalUnlockAchievementValue { get; set; }

        [JsonProperty("sales_lead")]
        public string SalesLead { get; set; }

        [JsonProperty("comments")] 
        public string Comments { get; set; }

        [JsonProperty("add_payment_info")] 
        public string AddPaymentInfo { get; set; }

        [JsonProperty("total_add_to_wishlist_value")]
        public string TotalAddToWishlistValue { get; set; }

        [JsonProperty("product_details_page_browse")]
        public string ProductDetailsPageBrowse { get; set; }

        [JsonProperty("total_loan_credit")] 
        public string TotalLoanCredit { get; set; }

        [JsonProperty("total_next_day_open")] 
        public string TotalNextDayOpen { get; set; }

        [JsonProperty("total_in_app_ad_click_value")]
        public string TotalInAppAdClickValue { get; set; }

        [JsonProperty("total_user_registration_value")]
        public string TotalUserRegistrationValue { get; set; }

        [JsonProperty("web_event_add_to_cart")]
        public string WebEventAddToCart { get; set; }

        [JsonProperty("total_create_gamerole")]
        public string TotalCreateGamerole { get; set; }

        [JsonProperty("tt_app_name")] 
        public string TtAppName { get; set; }

        [JsonProperty("total_complete_tutorial")]
        public string TotalCompleteTutorial { get; set; }

        [JsonProperty("loan_credit")] 
        public string LoanCredit { get; set; }

        [JsonProperty("user_registration")] 
        public string UserRegistration { get; set; }

        [JsonProperty("loan_disbursement")] 
        public string LoanDisbursement { get; set; }

        [JsonProperty("ad_text")] 
        public string AdText { get; set; }

        [JsonProperty("total_launch_app")] 
        public string TotalLaunchApp { get; set; }

        [JsonProperty("app_event_add_to_cart")]
        public string AppEventAddToCart { get; set; }

        [JsonProperty("ad_name")] 
        public string AdName { get; set; }

        [JsonProperty("total_purchase")] 
        public string TotalPurchase { get; set; }

        [JsonProperty("complete_payment")] 
        public string CompletePayment { get; set; }

        [JsonProperty("total_create_gamerole_value")]
        public string TotalCreateGameroleValue { get; set; }

        [JsonProperty("total_form_detail_value")]
        public string TotalFormDetailValue { get; set; }

        [JsonProperty("complete_payment_roas")]
        public string CompletePaymentRoas { get; set; }

        [JsonProperty("video_watched_6s")] 
        public string VideoWatched6s { get; set; }

        [JsonProperty("follows")] 
        public string Follows { get; set; }

        [JsonProperty("secondary_goal_result")]
        public string SecondaryGoalResult { get; set; }

        [JsonProperty("total_product_details_page_browse_value")]
        public string TotalProductDetailsPageBrowseValue { get; set; }

        [JsonProperty("next_day_open")] 
        public string NextDayOpen { get; set; }

        [JsonProperty("total_online_consult_value")]
        public string TotalOnlineConsultValue { get; set; }

        [JsonProperty("button_click")] 
        public string ButtonClick { get; set; }

        [JsonProperty("total_active_pay_roas")]
        public string TotalActivePayRoas { get; set; }

        [JsonProperty("mobile_app_id")] 
        public string MobileAppId { get; set; }

        [JsonProperty("total_download_start_value")]
        public string TotalDownloadStartValue { get; set; }

        [JsonProperty("campaign_id")] 
        public string CampaignId { get; set; }

        [JsonProperty("profile_visits")] public string ProfileVisits { get; set; }

        [JsonProperty("total_join_group")] public string TotalJoinGroup { get; set; }

        [JsonProperty("total_checkout_value")] public string TotalCheckoutValue { get; set; }

        [JsonProperty("result")] public string Result { get; set; }

        [JsonProperty("campaign_name")] public string CampaignName { get; set; }

        [JsonProperty("impressions")] public string Impressions { get; set; }

        [JsonProperty("spend_credits")] public string SpendCredits { get; set; }

        [JsonProperty("adgroup_id")] 
        public string AdgroupId { get; set; }

        [JsonProperty("total_unlock_achievement")]
        public string TotalUnlockAchievement { get; set; }

        [JsonProperty("total_in_app_ad_impr")] public string TotalInAppAdImpr { get; set; }

        [JsonProperty("total_in_app_ad_impr_value")]
        public string TotalInAppAdImprValue { get; set; }

        [JsonProperty("shares")] public string Shares { get; set; }

        [JsonProperty("total_achieve_level_value")]
        public string TotalAchieveLevelValue { get; set; }

        [JsonProperty("initiate_checkout")] 
        public string InitiateCheckout { get; set; }

        [JsonProperty("total_sales_lead_value")]
        public string TotalSalesLeadValue { get; set; }

        [JsonProperty("total_create_group_value")]
        public string TotalCreateGroupValue { get; set; }

        [JsonProperty("download_start")] 
        public string DownloadStart { get; set; }

        [JsonProperty("create_group")] 
        public string CreateGroup { get; set; }

        [JsonProperty("total_add_to_wishlist")]
        public string TotalAddToWishlist { get; set; }

        [JsonProperty("video_views_p25")] 
        public string VideoViewsP25 { get; set; }

        [JsonProperty("form_button")] 
        public string FormButton { get; set; }

        [JsonProperty("total_spend_credits")] 
        public string TotalSpendCredits { get; set; }

        [JsonProperty("join_group")] 
        public string JoinGroup { get; set; }

        [JsonProperty("total_subscribe_value")]
        public string TotalSubscribeValue { get; set; }

        [JsonProperty("search")] public string Search { get; set; }

        [JsonProperty("total_on_web_order_value")]
        public string TotalOnWebOrderValue { get; set; }

        [JsonProperty("total_achieve_level")] public string TotalAchieveLevel { get; set; }

        [JsonProperty("in_app_ad_click")] public string InAppAdClick { get; set; }

        [JsonProperty("total_view_content")] public string TotalViewContent { get; set; }

        [JsonProperty("real_time_conversion")] public string RealTimeConversion { get; set; }

        [JsonProperty("total_form_value")] public string TotalFormValue { get; set; }

        [JsonProperty("total_view_content_value")]
        public string TotalViewContentValue { get; set; }

        [JsonProperty("login")] public string Login { get; set; }

        [JsonProperty("total_sales_lead")] public string TotalSalesLead { get; set; }

        [JsonProperty("loan_apply")] public string LoanApply { get; set; }

        [JsonProperty("online_consult")] public string OnlineConsult { get; set; }

        [JsonProperty("download_button")] public string DownloadButton { get; set; }

        [JsonProperty("on_web_order")] public string OnWebOrder { get; set; }

        [JsonProperty("total_search")] public string TotalSearch { get; set; }

        [JsonProperty("subscribe")] public string Subscribe { get; set; }

        [JsonProperty("likes")] public string Likes { get; set; }

        [JsonProperty("registration")] public string Registration { get; set; }

        [JsonProperty("real_time_app_install")]
        public string RealTimeAppInstall { get; set; }

        [JsonProperty("create_gamerole")] public string CreateGamerole { get; set; }

        [JsonProperty("total_loan_apply")] public string TotalLoanApply { get; set; }

        [JsonProperty("real_time_result")] public string RealTimeResult { get; set; }

        [JsonProperty("button_click_consultation")]
        public string ButtonClickConsultation { get; set; }

        [JsonProperty("total_form_button_value")]
        public string TotalFormButtonValue { get; set; }

        [JsonProperty("video_views_p100")] public string VideoViewsP100 { get; set; }

        [JsonProperty("total_start_trial")] public string TotalStartTrial { get; set; }

        [JsonProperty("total_web_event_add_to_cart_value")]
        public string TotalWebEventAddToCartValue { get; set; }

        [JsonProperty("consultation")] public string Consultation { get; set; }

        [JsonProperty("page_event_search")] public string PageEventSearch { get; set; }

        [JsonProperty("total_consultation_value")]
        public string TotalConsultationValue { get; set; }

        [JsonProperty("total_create_group")] public string TotalCreateGroup { get; set; }

        [JsonProperty("checkout")] public string Checkout { get; set; }

        [JsonProperty("total_app_event_add_to_cart")]
        public string TotalAppEventAddToCart { get; set; }

        [JsonProperty("average_video_play")] public string AverageVideoPlay { get; set; }

        [JsonProperty("app_install")] public string AppInstall { get; set; }

        [JsonProperty("total_checkout")] public string TotalCheckout { get; set; }

        [JsonProperty("total_spend_credits_value")]
        public string TotalSpendCreditsValue { get; set; }

        [JsonProperty("download_detail")] public string DownloadDetail { get; set; }

        [JsonProperty("total_app_event_add_to_cart_value")]
        public string TotalAppEventAddToCartValue { get; set; }

        [JsonProperty("total_button_click_consultation_value")]
        public string TotalButtonClickConsultationValue { get; set; }

        [JsonProperty("total_download_detail_value")]
        public string TotalDownloadDetailValue { get; set; }

        [JsonProperty("video_watched_2s")] public string VideoWatched2s { get; set; }

        [JsonProperty("total_page_browse_view_value")]
        public string TotalPageBrowseViewValue { get; set; }

        [JsonProperty("unlock_achievement")] public string UnlockAchievement { get; set; }

        [JsonProperty("real_time_app_install_cost")]
        public string RealTimeAppInstallCost { get; set; }

        [JsonProperty("add_to_wishlist")] public string AddToWishlist { get; set; }

        [JsonProperty("page_browse_consultation")]
        public string PageBrowseConsultation { get; set; }

        [JsonProperty("total_page_browse_consultation_value")]
        public string TotalPageBrowseConsultationValue { get; set; }

        [JsonProperty("video_play_actions")] public string VideoPlayActions { get; set; }

        [JsonProperty("total_purchase_value")] public string TotalPurchaseValue { get; set; }

        [JsonProperty("video_views_p75")] public string VideoViewsP75 { get; set; }

        [JsonProperty("form_detail")] public string FormDetail { get; set; }

        [JsonProperty("conversion")] public string Conversion { get; set; }

        [JsonProperty("form")] public string Form { get; set; }

        [JsonProperty("total_button_click_value")]
        public string TotalButtonClickValue { get; set; }

        [JsonProperty("total_join_group_value")]
        public string TotalJoinGroupValue { get; set; }

        [JsonProperty("adgroup_name")] public string AdgroupName { get; set; }

        [JsonProperty("total_login")] public string TotalLogin { get; set; }

        [JsonProperty("tt_app_id")] public string TtAppId { get; set; }

        [JsonProperty("complete_tutorial")] public string CompleteTutorial { get; set; }

        [JsonProperty("video_views_p50")] public string VideoViewsP50 { get; set; }

        [JsonProperty("total_complete_tutorial_value")]
        public string TotalCompleteTutorialValue { get; set; }

        [JsonProperty("total_page_event_search_value")]
        public string TotalPageEventSearchValue { get; set; }

        [JsonProperty("clicks")] public string Clicks { get; set; }

        [JsonProperty("total_add_billing_value")]
        public string TotalAddBillingValue { get; set; }

        [JsonProperty("total_subscribe")] public string TotalSubscribe { get; set; }

        [JsonProperty("total_initiate_checkout_value")]
        public string TotalInitiateCheckoutValue { get; set; }

        [JsonProperty("reach")] public string Reach { get; set; }

        [JsonProperty("page_browse_view")] public string PageBrowseView { get; set; }

        [JsonProperty("launch_app")] public string LaunchApp { get; set; }

        [JsonProperty("add_billing")] public string AddBilling { get; set; }

        [JsonProperty("start_trial")] public string StartTrial { get; set; }

        [JsonProperty("total_download_button_value")]
        public string TotalDownloadButtonValue { get; set; }

        [JsonProperty("in_app_ad_impr")] public string InAppAdImpr { get; set; }

        [JsonProperty("purchase")] public string Purchase { get; set; }

        [JsonProperty("total_loan_disbursement")]
        public string TotalLoanDisbursement { get; set; }

        [JsonProperty("view_content")] public string ViewContent { get; set; }

        [JsonProperty("achieve_level")] public string AchieveLevel { get; set; }

        [JsonProperty("total_registration")] public string TotalRegistration { get; set; }

        [JsonProperty("spend")] public string Spend { get; set; }

		[JsonProperty("frequency")]
        public string Frequency { get; set; }

        // SKAN Metrics

        [JsonProperty("skan_conversion")]
        public string SkanConversion { get; set; }
        
        [JsonProperty("skan_result")]
        public string SkanResult { get; set; }
        
        [JsonProperty("skan_app_install")]
        public string SkanAppInstall { get; set; }

        [JsonProperty("skan_cost_per_app_install")]
        public string SkanCostPerAppInstall { get; set; }

        [JsonProperty("skan_app_install_withheld")]
        public string SkanAppInstallWithheld { get; set; }

        [JsonProperty("skan_registration")]
        public string SkanRegistration { get; set; }

        [JsonProperty("skan_cost_per_registration")]
        public string SkanCostPerRegistration { get; set; }

        [JsonProperty("skan_registration_rate")]
        public string SkanRegistrationRate { get; set; }

        [JsonProperty("skan_total_registration")]
        public string SkanTotalRegistration { get; set; }

        [JsonProperty("skan_cost_per_total_registration")]
        public string SkanCostPerTotalRegistration { get; set; }

        [JsonProperty("skan_purchase")]
        public string SkanPurchase { get; set; }

        [JsonProperty("skan_cost_per_purchase")]
        public string SkanCostPerPurchase { get; set; }

        [JsonProperty("skan_purchase_rate")]
        public string SkanPurchaseRate { get; set; }

        [JsonProperty("skan_total_purchase")]
        public string SkanTotalPurchase { get; set; }

        [JsonProperty("skan_cost_per_total_purchase")]
        public string SkanCostPerTotalPurchase { get; set; }

        [JsonProperty("skan_total_purchase_value")]
        public string SkanTotalPurchaseValue { get; set; }

        [JsonProperty("skan_total_repetitive_active_pay_roas")]
        public string SkanTotalRepetitiveActivePayRoas { get; set; }

        [JsonProperty("skan_add_to_cart")]
        public string SkanAddToCart { get; set; }

        [JsonProperty("skan_cost_per_add_to_cart")]
        public string SkanCostPerAddToCart { get; set; }

        [JsonProperty("skan_add_to_cart_rate")]
        public string SkanAddToCartRate { get; set; }

        [JsonProperty("skan_total_add_to_cart")]
        public string SkanTotalAddToCart { get; set; }

        [JsonProperty("skan_cost_per_total_add_to_cart")]
        public string SkanCostPerTotalAddToCart { get; set; }

        [JsonProperty("skan_total_add_to_cart_value")]
        public string SkanTotalAddToCartValue { get; set; }

        [JsonProperty("skan_checkout")]
        public string SkanCheckout { get; set; }

        [JsonProperty("skan_cost_per_checkout")]
        public string SkanCostPerCheckout { get; set; }

        [JsonProperty("skan_checkout_rate")]
        public string SkanCheckoutRate { get; set; }

        [JsonProperty("skan_total_checkout")]
        public string SkanTotalCheckout { get; set; }

        [JsonProperty("skan_cost_per_total_checkout")]
        public string SkanCostPerTotalCheckout { get; set; }

        [JsonProperty("skan_total_checkout_value")]
        public string SkanTotalCheckoutValue { get; set; }

        [JsonProperty("skan_view_content")]
        public string SkanViewContent { get; set; }

        [JsonProperty("skan_cost_per_view_content")]
        public string SkanCostPerViewContent { get; set; }

        [JsonProperty("skan_view_content_rate")]
        public string SkanViewContentRate { get; set; }

        [JsonProperty("skan_total_view_content")]
        public string SkanTotalViewContent { get; set; }

        [JsonProperty("skan_cost_per_total_view_content")]
        public string SkanCostPerTotalViewContent { get; set; }

        [JsonProperty("skan_total_view_content_value")]
        public string SkanTotalViewContentValue { get; set; }

        [JsonProperty("skan_add_payment_info")]
        public string SkanAddPaymentInfo { get; set; }

        [JsonProperty("skan_cost_per_add_payment_info")]
        public string SkanCostPerAddPaymentInfo { get; set; }

        [JsonProperty("skan_add_payment_info_rate")]
        public string SkanAddPaymentInfoRate { get; set; }

        [JsonProperty("skan_total_add_payment_info")]
        public string SkanTotalAddPaymentInfo { get; set; }

        [JsonProperty("skan_cost_total_add_payment_info")]
        public string SkanCostTotalAddPaymentInfo { get; set; }

        [JsonProperty("skan_add_to_wishlist")]
        public string SkanAddToWishlist { get; set; }

        [JsonProperty("skan_cost_per_add_to_wishlist")]
        public string SkanCostPerAddToWishlist { get; set; }

        [JsonProperty("skan_add_to_wishlist_rate")]
        public string SkanAddToWishlistRate { get; set; }

        [JsonProperty("skan_total_add_to_wishlist")]
        public string SkanTotalAddToWishlist { get; set; }

        [JsonProperty("skan_cost_per_total_add_to_wishlist")]
        public string SkanCostPerTotalAddToWishlist { get; set; }

        [JsonProperty("skan_total_add_to_wishlist_value")]
        public string SkanTotalAddToWishlistValue { get; set; }

        [JsonProperty("skan_launch_app")]
        public string SkanLaunchApp { get; set; }

        [JsonProperty("skan_cost_per_launch_app")]
        public string SkanCostPerLaunchApp { get; set; }

        [JsonProperty("skan_launch_app_rate")]
        public string SkanLaunchAppRate { get; set; }

        [JsonProperty("skan_total_launch_app")]
        public string SkanTotalLaunchApp { get; set; }

        [JsonProperty("skan_cost_per_total_launch_app")]
        public string SkanCostPerTotalLaunchApp { get; set; }

        [JsonProperty("skan_total_complete_tutorial")]
        public string SkanTotalCompleteTutorial { get; set; }

        [JsonProperty("skan_cost_per_total_complete_tutorial")]
        public string SkanCostPerTotalCompleteTutorial { get; set; }

        [JsonProperty("skan_complete_tutorial")]
        public string SkanCompleteTutorial { get; set; }

        [JsonProperty("skan_cost_per_complete_tutorial")]
        public string SkanCostPerCompleteTutorial { get; set; }

        [JsonProperty("skan_complete_tutorial_rate")]
        public string SkanCompleteTutorialRate { get; set; }

        [JsonProperty("skan_total_complete_tutorial_value")]
        public string SkanTotalCompleteTutorialValue { get; set; }

        [JsonProperty("skan_create_group")]
        public string SkanCreateGroup { get; set; }

        [JsonProperty("skan_cost_per_create_group")]
        public string SkanCostPerCreateGroup { get; set; }

        [JsonProperty("skan_create_group_rate")]
        public string SkanCreateGroupRate { get; set; }

        [JsonProperty("skan_total_create_group")]
        public string SkanTotalCreateGroup { get; set; }

        [JsonProperty("skan_cost_per_total_create_group")]
        public string SkanCostPerTotalCreateGroup { get; set; }

        [JsonProperty("skan_total_create_group_value")]
        public string SkanTotalCreateGroupValue { get; set; }

        [JsonProperty("skan_join_group")]
        public string SkanJoinGroup { get; set; }

        [JsonProperty("skan_cost_per_join_group")]
        public string SkanCostPerJoinGroup { get; set; }

        [JsonProperty("skan_join_group_rate")]
        public string SkanJoinGroupRate { get; set; }

        [JsonProperty("skan_total_join_group")]
        public string SkanTotalJoinGroup { get; set; }

        [JsonProperty("skan_cost_per_total_join_group")]
        public string SkanCostPerTotalJoinGroup { get; set; }

        [JsonProperty("skan_total_join_group_value")]
        public string SkanTotalJoinGroupValue { get; set; }

        [JsonProperty("skan_create_gamerole")]
        public string SkanCreateGamerole { get; set; }

        [JsonProperty("skan_cost_per_create_gamerole")]
        public string SkanCostPerCreateGamerole { get; set; }

        [JsonProperty("skan_create_gamerole_rate")]
        public string SkanCreateGameroleRate { get; set; }

        [JsonProperty("skan_total_create_gamerole")]
        public string SkanTotalCreateGamerole { get; set; }

        [JsonProperty("skan_cost_per_total_create_gamerole")]
        public string SkanCostPerTotalCreateGamerole { get; set; }

        [JsonProperty("skan_total_create_gamerole_value")]
        public string SkanTotalCreateGameroleValue { get; set; }

        [JsonProperty("skan_spend_credits")]
        public string SkanSpendCredits { get; set; }

        [JsonProperty("skan_cost_per_spend_credits")]
        public string SkanCostPerSpendCredits { get; set; }

        [JsonProperty("skan_spend_credits_rate")]
        public string SkanSpendCreditsRate { get; set; }

        [JsonProperty("skan_total_spend_credits")]
        public string SkanTotalSpendCredits { get; set; }

        [JsonProperty("skan_cost_per_total_spend_credits")]
        public string SkanCostPerTotalSpendCredits { get; set; }

        [JsonProperty("skan_total_spend_credits_value")]
        public string SkanTotalSpendCreditsValue { get; set; }

        [JsonProperty("skan_achieve_level")]
        public string SkanAchieveLevel { get; set; }

        [JsonProperty("skan_cost_per_achieve_level")]
        public string SkanCostPerAchieveLevel { get; set; }

        [JsonProperty("skan_achieve_level_rate")]
        public string SkanAchieveLevelRate { get; set; }

        [JsonProperty("skan_total_achieve_level")]
        public string SkanTotalAchieveLevel { get; set; }

        [JsonProperty("skan_cost_per_total_achieve_level")]
        public string SkanCostPerTotalAchieveLevel { get; set; }

        [JsonProperty("skan_total_achieve_level_value")]
        public string SkanTotalAchieveLevelValue { get; set; }

        [JsonProperty("skan_unlock_achievement")]
        public string SkanUnlockAchievement { get; set; }

        [JsonProperty("skan_cost_per_unlock_achievement")]
        public string SkanCostPerUnlockAchievement { get; set; }

        [JsonProperty("skan_unlock_achievement_rate")]
        public string SkanUnlockAchievementRate { get; set; }

        [JsonProperty("skan_total_unlock_achievement")]
        public string SkanTotalUnlockAchievement { get; set; }

        [JsonProperty("skan_cost_per_total_unlock_achievement")]
        public string SkanCostPerTotalUnlockAchievement { get; set; }

        [JsonProperty("skan_total_unlock_achievement_value")]
        public string SkanTotalUnlockAchievementValue { get; set; }

        [JsonProperty("skan_sales_lead")]
        public string SkanSalesLead { get; set; }

        [JsonProperty("skan_cost_per_sales_lead")]
        public string SkanCostPerSalesLead { get; set; }

        [JsonProperty("skan_sales_lead_rate")]
        public string SkanSalesLeadRate { get; set; }

        [JsonProperty("skan_total_sales_lead")]
        public string SkanTotalSalesLead { get; set; }

        [JsonProperty("skan_cost_per_total_sales_lead")]
        public string SkanCostPerTotalSalesLead { get; set; }

        [JsonProperty("skan_total_sales_lead_value")]
        public string SkanTotalSalesLeadValue { get; set; }

        [JsonProperty("skan_in_app_ad_click")]
        public string SkanInAppAdClick { get; set; }

        [JsonProperty("skan_cost_per_in_app_ad_click")]
        public string SkanCostPerInAppAdClick { get; set; }

        [JsonProperty("skan_in_app_ad_click_rate")]
        public string SkanInAppAdClickRate { get; set; }

        [JsonProperty("skan_total_in_app_ad_click")]
        public string SkanTotalInAppAdClick { get; set; }

        [JsonProperty("skan_cost_per_total_in_app_ad_click")]
        public string SkanCostPerTotalInAppAdClick { get; set; }

        [JsonProperty("skan_total_in_app_ad_click_value")]
        public string SkanTotalInAppAdClickValue { get; set; }

        [JsonProperty("skan_in_app_ad_impr")]
        public string SkanInAppAdImpr { get; set; }

        [JsonProperty("skan_cost_per_in_app_ad_impr")]
        public string SkanCostPerInAppAdImpr { get; set; }

        [JsonProperty("skan_in_app_ad_impr_rate")]
        public string SkanInAppAdImprRate { get; set; }

        [JsonProperty("skan_total_in_app_ad_impr")]
        public string SkanTotalInAppAdImpr { get; set; }

        [JsonProperty("skan_cost_per_total_in_app_ad_impr")]
        public string SkanCostPerTotalInAppAdImpr { get; set; }

        [JsonProperty("skan_total_in_app_ad_impr_value")]
        public string SkanTotalInAppAdImprValue { get; set; }

        [JsonProperty("skan_loan_apply")]
        public string SkanLoanApply { get; set; }

        [JsonProperty("skan_cost_per_loan_apply")]
        public string SkanCostPerLoanApply { get; set; }

        [JsonProperty("skan_loan_apply_rate")]
        public string SkanLoanApplyRate { get; set; }

        [JsonProperty("skan_total_loan_apply")]
        public string SkanTotalLoanApply { get; set; }

        [JsonProperty("skan_cost_per_total_loan_apply")]
        public string SkanCostPerTotalLoanApply { get; set; }

        [JsonProperty("skan_loan_credit")]
        public string SkanLoanCredit { get; set; }

        [JsonProperty("skan_cost_per_loan_credit")]
        public string SkanCostPerLoanCredit { get; set; }

        [JsonProperty("skan_loan_credit_rate")]
        public string SkanLoanCreditRate { get; set; }

        [JsonProperty("skan_total_loan_credit")]
        public string SkanTotalLoanCredit { get; set; }

        [JsonProperty("skan_cost_per_total_loan_credit")]
        public string SkanCostPerTotalLoanCredit { get; set; }

        [JsonProperty("skan_loan_disbursement")]
        public string SkanLoanDisbursement { get; set; }

        [JsonProperty("skan_cost_per_loan_disbursement")]
        public string SkanCostPerLoanDisbursement { get; set; }

        [JsonProperty("skan_loan_disbursement_rate")]
        public string SkanLoanDisbursementRate { get; set; }

        [JsonProperty("skan_total_loan_disbursement")]
        public string SkanTotalLoanDisbursement { get; set; }

        [JsonProperty("skan_cost_per_total_loan_disbursement")]
        public string SkanCostPerTotalLoanDisbursement { get; set; }

        [JsonProperty("skan_login")]
        public string SkanLogin { get; set; }

        [JsonProperty("skan_cost_per_login")]
        public string SkanCostPerLogin { get; set; }

        [JsonProperty("skan_login_rate")]
        public string SkanLoginRate { get; set; }

        [JsonProperty("skan_total_login")]
        public string SkanTotalLogin { get; set; }

        [JsonProperty("skan_cost_per_total_login")]
        public string SkanCostPerTotalLogin { get; set; }

        [JsonProperty("skan_ratings")]
        public string SkanRatings { get; set; }

        [JsonProperty("skan_cost_per_ratings")]
        public string SkanCostPerRatings { get; set; }

        [JsonProperty("skan_ratings_rate")]
        public string SkanRatingsRate { get; set; }

        [JsonProperty("skan_total_ratings")]
        public string SkanTotalRatings { get; set; }

        [JsonProperty("skan_cost_per_total_ratings")]
        public string SkanCostPerTotalRatings { get; set; }

        [JsonProperty("skan_total_ratings_value")]
        public string SkanTotalRatingsValue { get; set; }

        [JsonProperty("skan_search")]
        public string SkanSearch { get; set; }

        [JsonProperty("skan_cost_per_search")]
        public string SkanCostPerSearch { get; set; }

        [JsonProperty("skan_search_rate")]
        public string SkanSearchRate { get; set; }

        [JsonProperty("skan_total_search")]
        public string SkanTotalSearch { get; set; }

        [JsonProperty("skan_cost_per_total_search")]
        public string SkanCostPerTotalSearch { get; set; }

        [JsonProperty("skan_start_trial")]
        public string SkanStartTrial { get; set; }

        [JsonProperty("skan_cost_per_start_trial")]
        public string SkanCostPerStartTrial { get; set; }

        [JsonProperty("skan_start_trial_rate")]
        public string SkanStartTrialRate { get; set; }

        [JsonProperty("skan_total_start_trial")]
        public string SkanTotalStartTrial { get; set; }

        [JsonProperty("skan_cost_per_total_start_trial")]
        public string SkanCostPerTotalStartTrial { get; set; }

        [JsonProperty("skan_subscribe")]
        public string SkanSubscribe { get; set; }

        [JsonProperty("skan_cost_per_subscribe")]
        public string SkanCostPerSubscribe { get; set; }

        [JsonProperty("skan_subscribe_rate")]
        public string SkanSubscribeRate { get; set; }

        [JsonProperty("skan_total_subscribe")]
        public string SkanTotalSubscribe { get; set; }

        [JsonProperty("skan_cost_per_total_subscribe")]
        public string SkanCostPerTotalSubscribe { get; set; }

        [JsonProperty("skan_total_subscribe_value")]
        public string SkanTotalSubscribeValue { get; set; }
    }
}