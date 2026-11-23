using System;
using System.Collections.Generic;

// Token: 0x020005D6 RID: 1494
public sealed class b6f : ce8
{
	// Token: 0x0600277A RID: 10106 RVA: 0x000E5768 File Offset: 0x000E3968
	public override string[] c6()
	{
		return new string[]
		{
			"playerListCooldowns",
			"plistcd"
		};
	}

	// Token: 0x0600277C RID: 10108 RVA: 0x000E578C File Offset: 0x000E398C
	public override lu c7(List<object> A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			base.a("Player cooldowns:", new object[0]);
			if (serviceOrThrow.aqu().v().Cooldowns.b().Count > 0)
			{
				using (Dictionary<string, ip>.Enumerator enumerator = serviceOrThrow.aqu().v().Cooldowns.b().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, ip> keyValuePair = enumerator.Current;
						base.a("[prop]{0}[/prop]: [val]{1}[/val] / [val]{2}[/val]", new object[]
						{
							keyValuePair.Key,
							keyValuePair.Value.a,
							keyValuePair.Value.b
						});
					}
					goto IL_100;
				}
			}
			base.a("[warning]none", new object[0]);
		}
		else
		{
			base.a("[error]Could not find player character", new object[0]);
		}
		IL_100:
		return null;
	}
}
