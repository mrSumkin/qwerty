using System;
using System.Runtime.Serialization;

// Token: 0x02001B24 RID: 6948
[eiz("F09")]
[Serializable]
public sealed class c9i : els, ISerializable
{
	// Token: 0x0600964C RID: 38476 RVA: 0x003AD330 File Offset: 0x003AB530
	private c9i(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = A_0.GetString("F09:N");
		this.d = A_0.GetString("F09:C");
		this.e = A_0.GetString("F09:D");
	}

	// Token: 0x0600964D RID: 38477 RVA: 0x003AD378 File Offset: 0x003AB578
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("F09:N", this.c);
		info.AddValue("F09:C", this.d);
		info.AddValue("F09:D", this.e);
	}

	// Token: 0x0600964E RID: 38478 RVA: 0x003AD3C0 File Offset: 0x003AB5C0
	public c9i(string A_0, string A_1, string A_2, d3e[] A_3, wq[] A_4, string A_5 = null, int A_6 = 0) : base(c9i.a, A_1, ci8.b)
	{
		this.c = A_1;
		this.d = A_0;
		this.e = A_5;
		base.Duration = c9i.b + (int)TimeSpan.FromMinutes((double)A_6).TotalMilliseconds;
		base.Icon = A_2;
		base.Stacking = axm.b;
		base.TickPeriod = d0u.b;
		if (A_3 != null && A_3.Length != 0)
		{
			base.StaticEffects.AddRange(A_3);
		}
		if (A_4 != null && A_4.Length != 0)
		{
			base.DynamicEffects.AddRange(A_4);
		}
	}

	// Token: 0x0600964F RID: 38479 RVA: 0x003AD460 File Offset: 0x003AB660
	public override string cb(ll A_0)
	{
		if (!string.IsNullOrEmpty(this.e))
		{
			return this.e;
		}
		return qv.b("StatusEffects/Food_" + this.d);
	}

	// Token: 0x040039D8 RID: 14808
	public new static readonly string a = "food";

	// Token: 0x040039D9 RID: 14809
	public static readonly int b = (int)TimeSpan.FromMinutes(20.0).TotalMilliseconds;

	// Token: 0x040039DA RID: 14810
	private new string c;

	// Token: 0x040039DB RID: 14811
	private new string d;

	// Token: 0x040039DC RID: 14812
	private new string e;
}
