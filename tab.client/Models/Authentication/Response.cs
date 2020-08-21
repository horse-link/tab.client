using System;
using System.Collections.Generic;

namespace tab.client.Models.Authentication
{
    public class General 
    {
        public string rounding { get; set; } 
    }

    public class WeeklyDepositLimit 
    {
        public string value { get; set; } 
    }

    public class AcceptCounterOffer 
    {
        public bool amount { get; set; } 
        public bool price { get; set; } 
    }

    public class QuickBet 
    {
        public bool enabled { get; set; } 
        public string winStake { get; set; } 
        public string placeStake { get; set; } 
        public int enabledBefore { get; set; } 
    }

    public class Betting 
    {
        public string maxAmount { get; set; } 
        public AcceptCounterOffer acceptCounterOffer { get; set; } 
        public bool acceptReducedPrice { get; set; } 
        public bool defaultFlexi { get; set; } 
        public QuickBet quickBet { get; set; } 
        public string defaultBetType { get; set; } 
    }

    public class SpendLimit 
    {
        public string currentAmount { get; set; } 
        public string currentPeriod { get; set; } 
        public bool currentUnlimited { get; set; } 
        public string nextAmount { get; set; } 
        public string nextPeriod { get; set; } 
        public bool nextUnlimited { get; set; } 
        public object nextEffectiveTime { get; set; } 
        public int limitEffectiveAfter { get; set; } 
    }

    public class DepositLimit 
    {
        public bool pclAnniversary { get; set; } 
        public bool pclCompulsory { get; set; } 
        public string currentAmount { get; set; } 
        public string currentPeriod { get; set; } 
        public bool currentUnlimited { get; set; } 
        public string nextAmount { get; set; } 
        public string nextPeriod { get; set; } 
        public bool nextUnlimited { get; set; } 
        public string nextEffectiveTime { get; set; } 
        public int limitEffectiveAfter { get; set; } 
    }

    public class Preferences 
    {
        public General general { get; set; } 
        public WeeklyDepositLimit weeklyDepositLimit { get; set; } 
        public Betting betting { get; set; } 
        public SpendLimit spendLimit { get; set; } 
        public DepositLimit depositLimit { get; set; } 
    }

    public class Response 
    {
        public int accountNumber { get; set; } 
        public string username { get; set; } 
        public int customerId { get; set; } 
        public Preferences preferences { get; set; } 
        public string jurisdiction { get; set; } 
        public string homeState { get; set; } 
        public object lastBetTimestamp { get; set; } 
        public string tier { get; set; } 
        public string accountBalance { get; set; } 
        public string withdrawalBalance { get; set; } 
        public bool verified { get; set; } 
        public bool withdrawalBlocked { get; set; } 
        public bool eftWithdrawalEnabled { get; set; } 
        public string eftWithdrawalFee { get; set; } 
        public bool emailVerified { get; set; } 
        public bool pinSet { get; set; } 
        public DateTime lastAuthenticateTimestamp { get; set; } 
        public string verificationStatus { get; set; } 
        public tab.client.Models.Common.Authentication authentication { get; set; } 
    }
}