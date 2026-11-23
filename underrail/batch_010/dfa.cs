using System;
using System.Collections.Generic;

// Token: 0x02001002 RID: 4098
public sealed class dfa : d5s
{
	// Token: 0x0600543E RID: 21566 RVA: 0x0025424C File Offset: 0x0025244C
	public void aj1(d0z A_0, d5q A_1)
	{
		this.a[A_0] = A_1;
	}

	// Token: 0x0600543F RID: 21567 RVA: 0x0025425C File Offset: 0x0025245C
	public bool aj2(d0z A_0)
	{
		return this.a.Remove(A_0);
	}

	// Token: 0x06005440 RID: 21568 RVA: 0x0025426C File Offset: 0x0025246C
	public d5q aj3(d0z A_0)
	{
		d5q result;
		this.a.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x06005441 RID: 21569 RVA: 0x0025428C File Offset: 0x0025248C
	public List<d0z> aj4(List<string> A_0 = null)
	{
		if (A_0 == null || A_0.Count == 0)
		{
			return new List<d0z>();
		}
		List<d0z> list = new List<d0z>(this.a.Keys);
		if (!A_0.Contains("*"))
		{
			int i = list.Count - 1;
			while (i >= 0)
			{
				d0z d0z = list[i];
				if (d0z == null)
				{
					goto IL_C4;
				}
				if (d0z.e != null || d0z.e.Count > 0)
				{
					using (List<object>.Enumerator enumerator = d0z.e.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							string item = (string)obj;
							if (!A_0.Contains(item))
							{
								list.RemoveAt(i);
								break;
							}
						}
						goto IL_CB;
					}
					goto IL_C4;
				}
				IL_CB:
				i--;
				continue;
				IL_C4:
				list.RemoveAt(i);
				goto IL_CB;
			}
		}
		return list;
	}

	// Token: 0x0400226D RID: 8813
	private Dictionary<d0z, d5q> a = new Dictionary<d0z, d5q>();
}
