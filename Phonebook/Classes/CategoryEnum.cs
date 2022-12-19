// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
public enum CategoryEnum
{
    [Description("دبیرخانه")]
    Mailroom = 1,

    [Description("هنرمندان")]
    Artists,

    [Description("پیشکسوتان و مرتبط")]
    VeteransAndRelated,

    [Description("نظامیان دان بقه الله وبرکت و...")]
    BaqiyatullahUniversitySoldiers,

    [Description("مدیران موسسه")]
    DirectorsOfTheInstitution,

    [Description("سازمان نامشخص")]
    UnspecifiedOrganization,

    [Description("وزارت بهداشت،نظام پزشکی،هلال احمر، تامین اجتماعی")]
    MinistryOfHealthMedicalSystemRedCrescentSocialSecurity,

    [Description("شماره های داخل موبایل")]
    MobilePhoneNumbers,

    [Description("عمومی")]
    General,

    [Description("کادر پزشکی دفاع مقدس")]
    HolyDefenseMedicalStaff,

    [Description("محفل انس 88")]
    AnasParty88,

    [Description("جامعه پزشکی")]
    MedicalCommunity,

    [Description("همکاران موسسه بهداری رزمی")]
    ColleaguesOfTheMilitaryMedicalInstitute,

    [Description("لیست تیمهای اظطراری و سایر اسامی")]
    ListOfEmergencyTeamsAndOtherNames,
}