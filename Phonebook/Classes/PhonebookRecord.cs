// See https://aka.ms/new-console-template for more information
using System;

public class PhonebookRecord
{
    public Guid Id;
    public string FirstName;
    public string LastName;
    public string Organization;
    public string LandlineNumber;
    public string MobileNumber;
    public string FaxNumber;
    public string TelegramNumber;
    public string Description;
    public string CategoryIds;

    public PhonebookRecord()
    {
    }

    public PhonebookRecord(string firstName,
                     string lastName,
                     string organization,
                     string landlineNumber,
                     string mobileNumber,
                     string faxNumber,
                     string telegramNumber,
                     string categoryIds = null,
                     string description = null)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Organization = organization;
        LandlineNumber = landlineNumber;
        MobileNumber = mobileNumber;
        FaxNumber = faxNumber;
        TelegramNumber = telegramNumber;
        Description = description;
        CategoryIds = categoryIds;
    }
}
