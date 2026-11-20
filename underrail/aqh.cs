using System;
using System.Collections.Generic;

// Token: 0x020005DE RID: 1502
public sealed class aqh : ce8
{
	// Token: 0x06002792 RID: 10130 RVA: 0x000E5F08 File Offset: 0x000E4108
	public override string[] c6()
	{
		return new string[]
		{
			"readGlobalProperty",
			"readgp",
			"read"
		};
	}

	// Token: 0x06002793 RID: 10131 RVA: 0x000E5F28 File Offset: 0x000E4128
	public aqh()
	{
		base.Args.Add(new ayk(typeof(eqc), null, false));
	}

	// Token: 0x06002794 RID: 10132 RVA: 0x000E5F58 File Offset: 0x000E4158
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count == 1)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() == null)
			{
				base.a("[error]Current game not found", new object[0]);
				return null;
			}
			List<string> list = A_0[0] as List<string>;
			if (list != null)
			{
				if (list.Count > 0)
				{
					using (List<string>.Enumerator enumerator = list.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							string a_ = enumerator.Current;
							this.a(serviceOrThrow, a_);
						}
						goto IL_9E;
					}
				}
				base.a("[warning]No matching global properties found", new object[0]);
				IL_9E:
				return null;
			}
			string text = A_0[0] as string;
			if (!string.IsNullOrWhiteSpace(text))
			{
				this.a(serviceOrThrow, text);
			}
			else
			{
				base.b();
			}
		}
		else
		{
			base.b();
		}
		return null;
	}

	// Token: 0x06002795 RID: 10133 RVA: 0x000E6050 File Offset: 0x000E4250
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
