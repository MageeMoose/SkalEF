using SkalEF.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SkalEF.Models
{
    public class RoomsModel
    {
        public Rooms RoomsNumbers { get; set; }
    }

    public enum Rooms
    {
        [Display(Name = "2073:1")]
        SevenThreeOne,

        [Display(Name = "2073:2")]
        SevenThreeTwo,

        [Display(Name = "2073:3")]
        SevenThreeThree,

        [Display(Name = "2073:4")]
        SevenThreeFour,

        [Display(Name = "2073:5")]
        SevenThreeFive,

        [Display(Name = "2073:6")]
        SevenThreeSix,

        [Display(Name = "2073:7")]
        SevenThreeSeven,

        [Display(Name = "2077:1")]
        SevenSevenOne,

        [Display(Name = "2077:2")]
        SevenSevenTwo,

        [Display(Name = "2077:3")]
        SevenSevenThree,

        [Display(Name = "2077:4")]
        SevenSevenFour,

        [Display(Name = "2077:5")]
        SevenSevenFive,

        [Display(Name = "2077:6")]
        SevenSevenSix,

        [Display(Name = "2105:1")]
        FiveOne,

        [Display(Name = "2105:2")]
        FiveTwo,

        [Display(Name = "2105:3")]
        FiveThree,

        [Display(Name = "2105:4")]
        FIveFour,

        [Display(Name = "2105:5")]
        FiveFive,

        [Display(Name = "2105:6")]
        FiveSix,

        [Display(Name = "2106:1")]
        SixOne,

        [Display(Name = "2106:2")]
        SixTwo,

        [Display(Name = "2106:3")]
        SixThree,

        [Display(Name = "2106:4")]
        SixFour,

        [Display(Name = "2107:1")]
        SevenOne,

        [Display(Name = "2107:2")]
        SevenTwo,

        [Display(Name = "2107:3")]
        SevenThree,

        [Display(Name = "2108:1")]
        EightOne,

        [Display(Name = "2108:2")]
        EightTwo,

        [Display(Name = "2108:3")]
        EightThree,

        [Display(Name = "2108:4")]
        EightFour,

        [Display(Name = "2110:1")]
        TenOne,

        [Display(Name = "2110:2")]
        TenTwo,

        [Display(Name = "2111:1")]
        ElevenOne,

        [Display(Name = "2111:2")]
        ElevenTwo,

        [Display(Name = "2111:3")]
        ElevenThree,

        [Display(Name = "2111:4")]
        ElevenFour,

        [Display(Name = "2111:5")]
        ElevenFive,

        [Display(Name = "2111:6")]
        ElevenSix,

        [Display(Name = "2111:7")]
        ElevenSeven,

        [Display(Name = "2111:8")]
        ElevenEight,

        [Display(Name = "2113:1")]
        ThriteenOne,

        [Display(Name = "2113:2")]
        ThirteenTwo,

        [Display(Name = "2113:3")]
        ThirteenThree,

        [Display(Name = "2113:4")]
        ThirteenFour,

        [Display(Name = "2114:1")]
        FourteenOne,

        [Display(Name = "2114:2")]
        FourteenTwo,

        [Display(Name = "2114:3")]
        FourteenThree,

        [Display(Name = "2115:1")]
        FifteenOne,

        [Display(Name = "2115:2")]
        FifteenTwo,

        [Display(Name = "2115:3")]
        FifteenThree,

        [Display(Name = "2115:4")]
        FifteenFour,

        [Display(Name = "2115:5")]
        FifteenFive,

        [Display(Name = "2115:6")]
        FifteenSix,

        [Display(Name = "2115:7")]
        FifteenSeven

    }
}
