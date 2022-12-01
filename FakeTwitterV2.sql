CREATE DATABASE FakeTwitterV2;
GO
USE FakeTwitterV2;
GO
CREATE TABLE Users
(	
	UserId INT NOT NULL,
	Username NVARCHAR(50) NOT NULL,
	PRIMARY KEY (UserId)
);
GO
CREATE TABLE Tweets

(	
	TweetId INT NOT NULL, 
	UserId INT NOT NULL REFERENCES Users(UserId), 
	TweetText NVARCHAR(3000) NOT NULL, 
	CreatedAt DATETIME NOT NULL,
	PRIMARY KEY (TweetId)
);
GO
CREATE TABLE Comments
(	
	CommentId INT NOT NULL, 
	UserId INT NOT NULL REFERENCES Users(UserId), 
	TweetId INT NOT NULL REFERENCES Tweets(TweetId), 
	CommentText NVARCHAR(3000) NOT NULL, 
	CreatedAt DATETIME NOT NULL,
	PRIMARY KEY (CommentId)
); 

GO
INSERT INTO USERS (UserId, Username) VALUES 
		(1, N'User #1'), (2, N'User #2'), (3, N'User #3');
GO
INSERT INTO Tweets (TweetId, UserId, TweetText, CreatedAt) VALUES 
		(1, 1, N'EF-Core is an open source ORM', '2022-01-11 19:35');
GO
INSERT INTO Comments (CommentId, UserId, TweetId, CommentText, CreatedAt) VALUES 
(1, 2, 1, N'yes and also it''s light weight', '2022-01-11 19:45');
GO
INSERT INTO Comments (CommentId, UserId, TweetId, CommentText, CreatedAt) VALUES 
(2, 3, 1,N'Don''t forget it''s also cross-platform', '2022-01-11 20:05');
