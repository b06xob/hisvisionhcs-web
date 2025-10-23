-- HisVisionDB Database Tables
-- Created for His Vision Home Health website forms

USE HisVisionDB;
GO

-- 1. Referrals Table
CREATE TABLE Referrals (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    -- Client Information
    ClientFirstName NVARCHAR(100) NOT NULL,
    ClientLastName NVARCHAR(100) NOT NULL,
    ClientPhone NVARCHAR(20),
    ClientEmail NVARCHAR(255),
    ClientAddress NVARCHAR(500),
    
    -- Referrer Information
    ReferrerName NVARCHAR(200) NOT NULL,
    ReferrerTitle NVARCHAR(200),
    ReferrerPhone NVARCHAR(20) NOT NULL,
    ReferrerEmail NVARCHAR(255) NOT NULL,
    
    -- Service Information
    WaiverType NVARCHAR(50),
    ServiceNeeds NVARCHAR(100),
    AdditionalInfo NVARCHAR(MAX),
    
    -- System Fields
    CreatedDate DATETIME2 DEFAULT GETUTCDATE(),
    Status NVARCHAR(50) DEFAULT 'New'
);
GO

-- 2. Careers Applications Table
CREATE TABLE CareersApplications (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    -- Personal Information
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    Address NVARCHAR(500),
    
    -- Position Information
    Position NVARCHAR(100) NOT NULL,
    Experience NVARCHAR(50),
    Availability NVARCHAR(MAX),
    
    -- Qualifications
    License NVARCHAR(100),
    LicenseExpiry DATE,
    AdditionalSkills NVARCHAR(MAX),
    
    -- Motivation
    Motivation NVARCHAR(MAX),
    
    -- System Fields
    CreatedDate DATETIME2 DEFAULT GETUTCDATE(),
    Status NVARCHAR(50) DEFAULT 'New'
);
GO

-- 3. Contact Messages Table
CREATE TABLE ContactMessages (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    -- Contact Information
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20),
    Email NVARCHAR(255) NOT NULL,
    
    -- Message Information
    Subject NVARCHAR(100),
    Message NVARCHAR(MAX) NOT NULL,
    
    -- System Fields
    CreatedDate DATETIME2 DEFAULT GETUTCDATE(),
    Status NVARCHAR(50) DEFAULT 'New'
);
GO

-- Create indexes for better performance
CREATE INDEX IX_Referrals_CreatedDate ON Referrals(CreatedDate);
CREATE INDEX IX_Referrals_Status ON Referrals(Status);
CREATE INDEX IX_Referrals_WaiverType ON Referrals(WaiverType);

CREATE INDEX IX_CareersApplications_CreatedDate ON CareersApplications(CreatedDate);
CREATE INDEX IX_CareersApplications_Status ON CareersApplications(Status);
CREATE INDEX IX_CareersApplications_Position ON CareersApplications(Position);

CREATE INDEX IX_ContactMessages_CreatedDate ON ContactMessages(CreatedDate);
CREATE INDEX IX_ContactMessages_Status ON ContactMessages(Status);
CREATE INDEX IX_ContactMessages_Subject ON ContactMessages(Subject);
GO

-- Insert some sample data for testing (optional)
INSERT INTO Referrals (ClientFirstName, ClientLastName, ClientPhone, ClientEmail, ReferrerName, ReferrerPhone, ReferrerEmail, WaiverType, ServiceNeeds)
VALUES 
('John', 'Doe', '555-1234', 'john.doe@email.com', 'Jane Smith', '555-5678', 'jane.smith@hospital.com', 'SOURCE', 'Companion Sitter');

INSERT INTO CareersApplications (FirstName, LastName, Phone, Email, Position, Experience, Motivation)
VALUES 
('Mary', 'Johnson', '555-9876', 'mary.johnson@email.com', 'CNA', '2-5', 'Passionate about helping others and making a difference in their lives.');

INSERT INTO ContactMessages (FirstName, LastName, Email, Subject, Message)
VALUES 
('Robert', 'Wilson', 'robert.wilson@email.com', 'Service Information', 'I would like to learn more about your home health services for my elderly mother.');

PRINT 'Database tables created successfully!';

