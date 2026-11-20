using System;
using System.Collections.Generic;

// Token: 0x020005CF RID: 1487
public sealed class ek4 : ce8
{
	// Token: 0x06002764 RID: 10084 RVA: 0x000E4F4C File Offset: 0x000E314C
	public override string[] c6()
	{
		return new string[]
		{
			"playerExecuteJoblet",
			"pexecjoblet"
		};
	}

	// Token: 0x06002765 RID: 10085 RVA: 0x000E4F64 File Offset: 0x000E3164
	public ek4()
	{
		base.Args.Add(new ayk(typeof(exv), null, false));
		base.Args.Add(new ayk(typeof(c2v), "asInitiator", true));
	}

	// Token: 0x06002766 RID: 10086 RVA: 0x000E4FB4 File Offset: 0x000E31B4
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count >= 1)
		{
			string text = A_0[0] as string;
			if (!string.IsNullOrWhiteSpace(text))
			{
				af7 af = ea5.b(text);
				if (af == null)
				{
					bdg.a("[error]Could not find joblet '{0}'", new object[]
					{
						text
					});
					return null;
				}
				bool flag = false;
				if (A_0.Count > 1)
				{
					object obj = A_0[1];
					if (obj is bool)
					{
						bool flag2 = (bool)obj;
						flag = flag2;
					}
				}
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
				{
					c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
					if (c5x != null)
					{
						if (flag)
						{
							af(c5x, null, new Dictionary<string, object>());
						}
						else
						{
							af(null, c5x, new Dictionary<string, object>());
						}
						string text2 = "Joblet '{0}' executed on player entity";
						if (flag)
						{
							text2 += " as initiator";
						}
						bdg.a(text2, new object[]
						{
							text
						});
						goto IL_124;
					}
				}
				bdg.a("[error]Could not find player character", new object[0]);
				IL_124:
				return null;
			}
		}
		base.b();
		return null;
	}
}
