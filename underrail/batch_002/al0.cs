using System;
using System.Runtime.Serialization;

// Token: 0x02001A97 RID: 6807
[eiz("ABSE")]
[Serializable]
public sealed class al0 : els, ISerializable
{
	// Token: 0x060093BE RID: 37822 RVA: 0x003A3B3C File Offset: 0x003A1D3C
	private al0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060093BF RID: 37823 RVA: 0x003A3B48 File Offset: 0x003A1D48
	public al0(int A_0) : base(al0.a, "Гиперактивность", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.AgilityBoost";
		base.ExpiredAction = "YellowExpirationAction";
		base.RemovedAction = "YellowExpirationAction";
		base.Stacking = axm.b;
		base.StaticEffects.Add(new d19((float)al0.b)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new e15((float)al0.b)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new ba(al0.c, true, false, false));
		base.StaticEffects.Add(new i0(0.4f, false, false, false));
	}

	// Token: 0x060093C0 RID: 37824 RVA: 0x003A3C08 File Offset: 0x003A1E08
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/AgilityBoost", new object[]
		{
			(int)(al0.b * 100.0),
			al0.c
		});
	}

	// Token: 0x040038C4 RID: 14532
	public new static readonly string a = "agilityBoost";

	// Token: 0x040038C5 RID: 14533
	public static readonly double b = 0.25;

	// Token: 0x040038C6 RID: 14534
	public new static readonly int c = 10;
}
