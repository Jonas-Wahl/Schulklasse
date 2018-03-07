# Schulklasse
In dem Verzeichnis C:\Users\akt.Benutzer\.aws ein Credentials file anlegen
mit dem Inhalt:

[development]
aws_access_key_id = ******
aws_secret_access_key = ********

Die access key id und der secret access key erhält man nach dem Anlegen eines IAM Benutzers bei AWS.
Dieser Benutzer braucht den Full Access für die DynamoDB. Außerdem muss eine Tabelle "Schueler"
bei der DynamoDB angelegt werden.

!!! Vorsicht der secret access key ist wie ein passwort zu behandeln und darf nicht veröffentlicht werden !!!