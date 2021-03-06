﻿using TravBotSharp.Files.Helpers;

namespace TbsCore.Models.Settings
{
    public class VillSettings
    {
        public void Init()
        {
            GetRes = true;
            SendRes = false;
            UseHeroRes = true;
        }
        public VillType Type { get; set; }
        public Classificator.TroopsEnum BarracksTrain { get; set; }
        public bool GreatBarracksTrain { get; set; }
        public Classificator.TroopsEnum StableTrain { get; set; }
        public bool GreatStableTrain { get; set; }
        public Classificator.TroopsEnum WorkshopTrain { get; set; }
        public bool GetRes { get; set; }
        public bool SendRes { get; set; }
        public bool AutoExpandStorage { get; set; }
        public bool UseHeroRes { get; set; }
        /// <summary>
        /// Auto-Improve troops in smithy
        /// </summary>
        public bool AutoImprove { get; set; }
        /// <summary>
        /// Donate excess resources to alliance bonus
        /// </summary>
        public DonateEnum Donate { get; set; }
    }

    public enum VillType
    {
        Farm,
        Support,
        Deff,
        Off
    }
    public enum DonateEnum
    {
        None,
        ExcludeCrop,
        OnlyCrop
    }
}
