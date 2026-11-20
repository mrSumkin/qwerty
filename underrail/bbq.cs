using System;
using System.Collections.Generic;

// Token: 0x020005E6 RID: 1510
public sealed class bbq : ce8
{
	// Token: 0x060027AD RID: 10157 RVA: 0x000E6800 File Offset: 0x000E4A00
	public override string[] c6()
	{
		return new string[]
		{
			"spawnEntity",
			"se"
		};
	}

	// Token: 0x060027AE RID: 10158 RVA: 0x000E681C File Offset: 0x000E4A1C
	public bbq()
	{
		base.Args.Add(new ayk(typeof(o9), null, false));
	}

	// Token: 0x060027AF RID: 10159 RVA: 0x000E684C File Offset: 0x000E4A4C
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count > 0)
		{
			return new rl();
		}
		return null;
	}

	// Token: 0x060027B0 RID: 10160 RVA: 0x000E686C File Offset: 0x000E4A6C
	public override void wu(List<object> A_0, object A_1)
	{
		ak1 ak = A_1 as ak1;
		if (ak != null)
		{
			string text = A_0[0] as string;
			if (text != null)
			{
				if (text.StartsWith("!"))
				{
					string a_ = text.Substring(1);
					o9 argument = bdg.GetArgument<o9>();
					if (argument != null)
					{
						text = argument.a(a_);
					}
				}
				if (!string.IsNullOrEmpty(text))
				{
					c5x c5x = vq.a(text, ak.Zone, new bt4(ak.Area.y8(), ak.Location.a()), false);
					if (c5x != null)
					{
						bdg.a("Spawned entity [val]'{0}'[/val] from definition [val]'{1}'[/val] at [val]'{2}'[/val]", new object[]
						{
							c5x.y8(),
							text,
							ak.Location
						});
						return;
					}
					bdg.a("[error]Failed to spawn entity from definition [val]'{0}'", new object[]
					{
						text
					});
				}
			}
		}
	}
}
