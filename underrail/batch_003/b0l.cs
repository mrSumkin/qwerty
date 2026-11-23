using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020005BF RID: 1471
public sealed class b0l : ae1
{
	// Token: 0x06002724 RID: 10020 RVA: 0x000E3AD8 File Offset: 0x000E1CD8
	public override string gr()
	{
		return "capability";
	}

	// Token: 0x06002725 RID: 10021 RVA: 0x000E3AE0 File Offset: 0x000E1CE0
	public override object gs(string A_0)
	{
		return dgk.a(A_0);
	}

	// Token: 0x06002726 RID: 10022 RVA: 0x000E3AEC File Offset: 0x000E1CEC
	protected override List<object> gt()
	{
		List<object> list = new List<object>();
		foreach (c3n c3n in dgk.b())
		{
			ayj ayj = Enumerable.FirstOrDefault<object>(c3n.GetType().GetCustomAttributes(typeof(ayj), false)) as ayj;
			list.Add(ayj.a());
		}
		return list;
	}
}
