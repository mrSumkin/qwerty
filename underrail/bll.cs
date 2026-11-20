using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x020005E4 RID: 1508
public sealed class bll : ce8
{
	// Token: 0x060027A5 RID: 10149 RVA: 0x000E660C File Offset: 0x000E480C
	public override string[] c6()
	{
		return new string[]
		{
			"spawnEffect",
			"spawnVisualEffect",
			"svx"
		};
	}

	// Token: 0x060027A6 RID: 10150 RVA: 0x000E6630 File Offset: 0x000E4830
	public bll()
	{
		base.Args.Add(new ayk(typeof(ri), null, false));
	}

	// Token: 0x060027A7 RID: 10151 RVA: 0x000E6660 File Offset: 0x000E4860
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count > 0)
		{
			return new rl();
		}
		return null;
	}

	// Token: 0x060027A8 RID: 10152 RVA: 0x000E6680 File Offset: 0x000E4880
	public override void wu(List<object> A_0, object A_1)
	{
		ak1 ak = A_1 as ak1;
		if (ak != null && ak.Area != null)
		{
			string text = A_0[0] as string;
			if (text != null)
			{
				if (text.StartsWith("!"))
				{
					text = text.Substring(1);
				}
				boj.a(ak.Area, ak.Location.a() + new Vector3(0f, 0f, 0.5f), null, text, 1, double.MaxValue, null, null, null, null);
			}
		}
	}
}
