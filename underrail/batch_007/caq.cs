using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x020005E5 RID: 1509
public sealed class caq : ce8
{
	// Token: 0x060027A9 RID: 10153 RVA: 0x000E673C File Offset: 0x000E493C
	public override string[] c6()
	{
		return new string[]
		{
			"exportItem",
			"exi"
		};
	}

	// Token: 0x060027AA RID: 10154 RVA: 0x000E6758 File Offset: 0x000E4958
	public caq()
	{
		base.Args.Add(new ayk(typeof(cj8), null, false));
	}

	// Token: 0x060027AB RID: 10155 RVA: 0x000E6788 File Offset: 0x000E4988
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count > 0)
		{
			return new atd();
		}
		return null;
	}

	// Token: 0x060027AC RID: 10156 RVA: 0x000E67A8 File Offset: 0x000E49A8
	public override void wu(List<object> A_0, object A_1)
	{
		coh coh = A_1 as coh;
		if (coh != null)
		{
			string text = A_0[0] as string;
			if (!string.IsNullOrEmpty(text))
			{
				string text2 = Path.Combine(d5x.a(), text);
				text2 = Path.ChangeExtension(text2, "item");
				coh.Definition.j(text2);
			}
		}
	}
}
