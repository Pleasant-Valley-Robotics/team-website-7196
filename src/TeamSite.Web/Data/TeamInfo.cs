using TeamSite.Web.Models;

namespace TeamSite.Web.Data;

/// <summary>
/// Everything your team's site says. To change the site, edit this file.
/// Images go in wwwroot/images/.
/// </summary>
public static class TeamInfo
{
    public static readonly Team Team = new()
    {
        Name = "Everything That's Radical",
        ShortName = "Radical",
        Program = "FTC",
        Number = 7196,
        Founded = "2013",
        Tagline = "Exceed last year's results and make it to the World Championship.",
        Logo = "/images/radical-logo.png",
        AccentColor = "#f472b6",
        Photo = "/images/radical-team-2025.jpg",
        PhotoCaption = "The 2025–2026 Everything That's Radical team",
        Socials =
        [
            new("Instagram", "https://www.instagram.com/team.radical7196"),
            new("Facebook", "https://www.facebook.com/7196.Everything.thats.radical"),
            new("TikTok", "https://www.tiktok.com/@team.radical7196"),
            new("X", "https://www.twitter.com/7196ETR"),
        ],
        Highlights =
        [
            "Control Award winner",
            "Alliance partner selection",
            "4 FLL teams mentored weekly",
        ],
        Story =
        [
            "We are Everything That's Radical, an FTC team at Pleasant Valley High School in Bettendorf, Iowa, established in 2013. Last season we won the Control Award and were chosen as an alliance partner. This year's team is mostly members who are new to FTC, and we're excited to learn STEM skills with FIRST.",
            "Every student grows through the FIRST Tech Challenge, whether that's designing and building the robot, putting together a portfolio and presentation, or reaching out to the community. Many of our members also take one or more of Pleasant Valley's Applied Science classes.",
        ],
        Outreach =
        [
            new("Summer Camp",
                "A one-week June camp gave 18 incoming 7th–9th graders a condensed FTC season, covering the design process, CAD, Java programming and presentation skills, with five Radical members as mentors."),
            new("FLL Mentoring (4 Teams)",
                "Business department members with FLL experience visit Flourish and Bots Navy, Flourish and Bots Gold, Forest Grove Elementary and Hopewell Elementary every week for about an hour and a half, helping with project ideas, robot issues and staying on track."),
            new("HeartStart",
                "What began as a personal project inspired by a team member's childhood medical anxiety is now a collaboration with educators and healthcare partners to build a hand-cranked model that shows how the heart beats, a STEM tool that genuinely supports young patients."),
            new("Iowa FIRST Student Leadership Board",
                "Our team lead represents Pleasant Valley on the Iowa FIRST Student Leadership Board and the Iowa Governor's Youth STEM Advisory Council, keeping the team connected to statewide STEM goals."),
            new("Iowa STEM Day at the Fair",
                "We talked with families about STEM and FIRST pathways, highlighting the FLL-to-FTC progression and reaching new students from diverse communities."),
            new("Davenport Noon Optimists",
                "PV Robotics places over 220 flags in front yards across the community on five major American holidays, earning $4,500 a year for the program."),
            new("Run With Carl",
                "Members designed medals in CAD for the Run With Carl Labor Day race, then 3D printed them for the event."),
            new("Homecoming Carnival",
                "With kettle corn sponsored by Ma and Pa's Kettle Korn, our homecoming carnival booth raised $332 for team operations."),
            new("Club Fair",
                "A representative at the annual school club fair showed students what FIRST and robotics have to offer."),
            new("Monthly Newsletter",
                "A monthly newsletter keeps parents updated on team progress and upcoming events so families can support their students all season."),
        ],
    };

    // The menu at the top of every page. Add a line when you add a page.
    public static readonly List<(string Label, string Href)> Nav =
    [
        ("Home", "/"),
    ];

    public const string PvSite = "https://www.firstpvrobotics.com";
}
