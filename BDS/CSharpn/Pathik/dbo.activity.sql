CREATE TABLE [dbo].[activity] (
    [activity_Id]    INT NOT NULL IDENTITY(1, 1),
    [lane_id]        INT        NOT NULL,
    [vehicle_number] NCHAR (10) NOT NULL,
    [vehicle_type]   INT        NOT NULL,
    [fare_collected] REAL       NOT NULL,
    [activity_datetime] DATETIME NOT NULL DEFAULT GETDATE(), 
    PRIMARY KEY CLUSTERED ([activity_Id] ASC)
);

