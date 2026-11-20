using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001B11 RID: 6929
[eiz("1SE")]
[Serializable]
public sealed class cyw : els, ISerializable
{
	// Token: 0x060095FA RID: 38394 RVA: 0x003ABF8C File Offset: 0x003AA18C
	private cyw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060095FB RID: 38395 RVA: 0x003ABF98 File Offset: 0x003AA198
	public cyw(int A_0, double A_1, int A_2, int A_3) : base(cyw.a, "Подавление", ci8.c)
	{
		base.Duration = A_0;
		base.Icon = "Status.Suppressed";
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.Power = A_2 * 100 + A_3 * 10 + (int)(A_1 * 100.0);
		base.StaticEffects.Add(new etj(-A_1));
		base.StaticEffects.Add(new d9(-A_2, true, false));
		base.StaticEffects.Add(new ba(-A_3, false, true, true));
		base.StaticEffects.Add(new i0((float)(-(float)A_3) * 0.015f, false, false, true));
	}

	// Token: 0x060095FC RID: 38396 RVA: 0x003AC04C File Offset: 0x003AA24C
	public override string cb(ll A_0)
	{
		double num = -Enumerable.First<etj>(Enumerable.OfType<etj>(base.StaticEffects)).b();
		int num2 = -Enumerable.First<d9>(Enumerable.OfType<d9>(base.StaticEffects)).Amount;
		int num3 = -Enumerable.First<ba>(Enumerable.OfType<ba>(base.StaticEffects)).Amount;
		return qv.a("StatusEffects/Suppressed", new object[]
		{
			(int)(num * 100.0),
			num2,
			num3
		});
	}

	// Token: 0x040039B7 RID: 14775
	public new static readonly string a = "suppressed";
}
