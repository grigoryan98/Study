Alter Table ReadBooks
Add  Genre NvarChar(50)  Null

Alter Table ReadBooks
Add Country NvarChar(50) Not Null  Default'unknown';

Alter Table ReadBooks
Alter Column Author NvarChar(200)

Alter Table ReadBooks
Add Check(Year>1700)

Alter Table ReadBooks
Add Awards NvarChar(50) Null,
    FirstPublishPlase NvarChar(50) Not Null Default'unknown';