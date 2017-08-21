CREATE TABLE [dbo].[ProductTbl] (
    [ProductID]    INT           NOT NULL,
    [ProductName]  NVARCHAR (50) NULL,
    [ProductStock] INT           NULL,
    [Description]  TEXT          NOT NULL,
    PRIMARY KEY CLUSTERED ([ProductID] ASC)
);

