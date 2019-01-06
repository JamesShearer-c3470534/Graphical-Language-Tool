CREATE TABLE [dbo].[BugTable] (
    [BugId]       INT          IDENTITY (1, 1) NOT NULL,
    [Username]    VARCHAR (50) NOT NULL,
    [Application] VARCHAR (50) NOT NULL,
    [Symptom]     TEXT         NOT NULL,
    [Cause]       TEXT         NOT NULL,
    [Class]       VARCHAR (50) NOT NULL,
    [Method]      VARCHAR (50) NOT NULL,
    [CodeBlock]   TEXT         NOT NULL,
    [LineNoStart] INT          NOT NULL,
    [LineNoEnd]   INT          NOT NULL,
    [Language]    VARCHAR (50) NOT NULL,
    [Fixed]       BIT          DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([BugId] ASC),
    CONSTRAINT [FK_BugTable_UserTable] FOREIGN KEY ([Username]) REFERENCES [dbo].[UserTable] ([Username])
);

