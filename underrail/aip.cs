using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000522 RID: 1314
[eiz("LEOC")]
[Serializable]
public sealed class aip : ISerializable
{
	// Token: 0x060021D0 RID: 8656 RVA: 0x000B4268 File Offset: 0x000B2468
	private aip(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<w0>("LEOC:FA", ref this.a, A_0);
			di7.ReadList<w0>("LEOC:FO", ref this.b, A_0);
			this.c = A_0.GetBoolean("LEOC:FV");
			return;
		}
		if (base.GetType() == typeof(aip))
		{
			this.a = (List<w0>)A_0.GetValue("_FulfillAll", typeof(List<w0>));
			this.b = (List<w0>)A_0.GetValue("_FulfillOne", typeof(List<w0>));
			this.c = A_0.GetBoolean("_ForceVisible");
			return;
		}
		this.a = (List<w0>)A_0.GetValue("LocalEventObservationConditions+_FulfillAll", typeof(List<w0>));
		this.b = (List<w0>)A_0.GetValue("LocalEventObservationConditions+_FulfillOne", typeof(List<w0>));
		this.c = A_0.GetBoolean("LocalEventObservationConditions+_ForceVisible");
	}

	// Token: 0x060021D1 RID: 8657 RVA: 0x000B438C File Offset: 0x000B258C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<w0>("LEOC:FA", this.a, info);
		di7.WriteList<w0>("LEOC:FO", this.b, info);
		info.AddValue("LEOC:FV", this.c);
	}

	// Token: 0x060021D2 RID: 8658 RVA: 0x000B43C4 File Offset: 0x000B25C4
	public List<w0> a()
	{
		return this.a;
	}

	// Token: 0x060021D3 RID: 8659 RVA: 0x000B43CC File Offset: 0x000B25CC
	public List<w0> b()
	{
		return this.b;
	}

	// Token: 0x060021D4 RID: 8660 RVA: 0x000B43D4 File Offset: 0x000B25D4
	public bool c()
	{
		return this.c;
	}

	// Token: 0x060021D5 RID: 8661 RVA: 0x000B43DC File Offset: 0x000B25DC
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060021D6 RID: 8662 RVA: 0x000B43E8 File Offset: 0x000B25E8
	public aip()
	{
	}

	// Token: 0x060021D7 RID: 8663 RVA: 0x000B4408 File Offset: 0x000B2608
	public bool a(c1a A_0)
	{
		if (this.c)
		{
			return true;
		}
		using (List<w0>.Enumerator enumerator = this.a.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.@if(A_0))
				{
					return false;
				}
			}
		}
		if (this.b.Count > 0)
		{
			using (List<w0>.Enumerator enumerator = this.b().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.@if(A_0))
					{
						return true;
					}
				}
			}
			return false;
		}
		return true;
	}

	// Token: 0x04001465 RID: 5221
	private List<w0> a = new List<w0>();

	// Token: 0x04001466 RID: 5222
	private List<w0> b = new List<w0>();

	// Token: 0x04001467 RID: 5223
	private bool c;
}
