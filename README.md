# DCbotYGO
Discord bot for Yu-Gi-Oh! cards.
# About
Discord bot created using DSharpPlus library (wrapper for Discord API).
For now it has only one command that retrieve information about card
from external resource (YGOPRODECK) and send them back to Discord.
Because of API limitation and for better performance all requested cards are
stored localy in DB (card images are located in working directory in folder "CardImages").

# Usage
First of all to run a bot you have to provide required information:
- Connection string to database (MSSQL)
- Bot token

Example connection string:
```
Server=<YourServerName>;Database=<YourDBName>;Trusted_Connection=True;MultipleActiveResultSets=true
``` 
To get the bot token, create Discord bot application. You can do it here: https://discord.com/developers/applications

### Commands
Bot uses slash commands with card names autocompletion (It only shows cards names that have been already requested
and saved into database).

To get information pass name of the card as an argument after "name" option:
```
/card name "Card Name" 
```

# Requirements
- .NET 5 or higher
- MSSQL Server
