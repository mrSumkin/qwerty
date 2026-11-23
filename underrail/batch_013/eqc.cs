using System;
using System.Collections.Generic;
using Ouroboros.Common.Data;

// Token: 0x020005C0 RID: 1472
public sealed class eqc : ae1
{
	// Token: 0x06002728 RID: 10024 RVA: 0x000E3B74 File Offset: 0x000E1D74
	protected override bool at0()
	{
		return false;
	}

	// Token: 0x06002729 RID: 10025 RVA: 0x000E3B78 File Offset: 0x000E1D78
	public override string gr()
	{
		return "globalProperty(name|pattern)";
	}

	// Token: 0x0600272A RID: 10026 RVA: 0x000E3B84 File Offset: 0x000E1D84
	public override object gs(string A_0)
	{
		if (!string.IsNullOrWhiteSpace(A_0))
		{
			if (A_0.StartsWith("*"))
			{
				List<string> list = new List<string>();
				List<object> list2 = base.a();
				if (A_0.EndsWith("*"))
				{
					string value = A_0.TrimStart(new char[]
					{
						'*'
					}).TrimEnd(new char[]
					{
						'*'
					});
					using (List<object>.Enumerator enumerator = list2.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							string text = (string)obj;
							if (text.Contains(value))
							{
								list.Add(text);
							}
						}
						return list;
					}
				}
				string value2 = A_0.TrimStart(new char[]
				{
					'*'
				});
				foreach (object obj2 in list2)
				{
					string text2 = (string)obj2;
					if (text2.EndsWith(value2))
					{
						list.Add(text2);
					}
				}
				return list;
			}
			if (A_0.EndsWith("*"))
			{
				List<string> list3 = new List<string>();
				List<object> list4 = base.a();
				string value3 = A_0.TrimEnd(new char[]
				{
					'*'
				});
				foreach (object obj3 in list4)
				{
					string text3 = (string)obj3;
					if (text3.StartsWith(value3))
					{
						list3.Add(text3);
					}
				}
				return list3;
			}
		}
		return A_0;
	}

	// Token: 0x0600272B RID: 10027 RVA: 0x000E3D44 File Offset: 0x000E1F44
	protected override List<object> gt()
	{
		List<object> list = new List<object>();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			foreach (Property property in serviceOrThrow.aqu().r().Properties)
			{
				list.Add(property.Name);
			}
		}
		return list;
	}
}
