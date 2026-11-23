using System;
using System.Collections.Generic;

// Token: 0x020005C3 RID: 1475
public sealed class czq : ae1
{
	// Token: 0x06002735 RID: 10037 RVA: 0x000E408C File Offset: 0x000E228C
	public override string gr()
	{
		return "cooldown";
	}

	// Token: 0x06002736 RID: 10038 RVA: 0x000E4094 File Offset: 0x000E2294
	public override object gs(string A_0)
	{
		return A_0;
	}

	// Token: 0x06002737 RID: 10039 RVA: 0x000E409C File Offset: 0x000E229C
	protected override List<object> gt()
	{
		List<object> list = new List<object>();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().Cooldowns.b().Count > 0)
		{
			foreach (KeyValuePair<string, ip> keyValuePair in serviceOrThrow.aqu().v().Cooldowns.b())
			{
				list.Add(keyValuePair.Key);
			}
		}
		return list;
	}
}
