using System;
using System.Collections.Generic;

// Token: 0x020005D5 RID: 1493
public sealed class b9a : ce8
{
	// Token: 0x06002776 RID: 10102 RVA: 0x000E5618 File Offset: 0x000E3818
	public override string[] c6()
	{
		return new string[]
		{
			"writeGlobalProperty",
			"writegp",
			"write"
		};
	}

	// Token: 0x06002777 RID: 10103 RVA: 0x000E5638 File Offset: 0x000E3838
	public b9a()
	{
		base.Args.Add(new ayk(typeof(cj8), null, false));
		base.Args.Add(new ayk(typeof(c2v), null, false));
	}

	// Token: 0x06002778 RID: 10104 RVA: 0x000E5684 File Offset: 0x000E3884
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count == 2)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() == null)
			{
				base.a("[error]Current game not found", new object[0]);
				return null;
			}
			string text = A_0[0] as string;
			if (string.IsNullOrEmpty(text))
			{
				base.b();
				return null;
			}
			serviceOrThrow.aqu().r()[text] = A_0[1];
		}
		else
		{
			base.b();
		}
		return null;
	}

	// Token: 0x06002779 RID: 10105 RVA: 0x000E570C File Offset: 0x000E390C
	private void a(cnk A_0, string A_1)
	{
		if (!string.IsNullOrWhiteSpace(A_1))
		{
			object propertyValue = A_0.aqu().r().GetPropertyValue(A_1);
			string text;
			if (propertyValue == null)
			{
				text = "null";
			}
			else
			{
				text = propertyValue.ToString();
			}
			base.a("[prop]{0}[/prop] = [val]'{1}'[/val]", new object[]
			{
				A_1,
				text
			});
		}
	}
}
