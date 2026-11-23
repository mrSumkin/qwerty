using System;
using System.Runtime.Serialization;

// Token: 0x020019C7 RID: 6599
[eiz("BPSIE")]
[Serializable]
public sealed class bpp : bs1
{
	// Token: 0x06008D56 RID: 36182 RVA: 0x003931B8 File Offset: 0x003913B8
	private bpp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008D57 RID: 36183 RVA: 0x003931C4 File Offset: 0x003913C4
	public override string f9()
	{
		return "burrowerPoison";
	}

	// Token: 0x06008D58 RID: 36184 RVA: 0x003931CC File Offset: 0x003913CC
	public override string ga()
	{
		return "Яд могильщика";
	}

	// Token: 0x06008D59 RID: 36185 RVA: 0x003931D4 File Offset: 0x003913D4
	protected override string gb()
	{
		return "BurrowerPoison";
	}

	// Token: 0x06008D5A RID: 36186 RVA: 0x003931DC File Offset: 0x003913DC
	public bpp()
	{
	}

	// Token: 0x06008D5B RID: 36187 RVA: 0x003931E8 File Offset: 0x003913E8
	public override string gc(efk A_0)
	{
		return qv.a("SpecialAttacks/BurrowerPoisonItemEffect_Cap", new object[]
		{
			base.a(),
			d6b.a,
			d6b.b,
			d6b.c
		});
	}

	// Token: 0x06008D5C RID: 36188 RVA: 0x00393238 File Offset: 0x00391438
	public override string gd(efk A_0)
	{
		int num = d6b.a;
		if (A_0 != null && A_0.Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("SpecialAttacks/BurrowerPoisonItemEffect_Applied", new object[]
		{
			num,
			d6b.b,
			d6b.c
		});
	}
}
