using Discord;
using Discord.Commands;

using System;
using System.Collections.Genric;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TlodBot

{
class MyBot()

DiscordClient Discord:

public MyBot:
{
	discord = new DiscordClient(x =>
		{
			x.LogLevel = LogSeverity.Info;
           x.LogHandler = Log;
});

discord.ExecuteAndWait(async () =>
{
	await discord.Connect(NDMzNjUwNjAzMjkwMzk0NjQ1.DbO2eg.s1kEhtwa3vDyvaF4I7cBPGweEfc);
});

}

private void Log(object sender, LogMessageEvenArgs e)
{
	Console.WriteLine(e.Message);
}

       }
    }	
}
    