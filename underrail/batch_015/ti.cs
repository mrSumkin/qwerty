using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001A64 RID: 6756
[eiz("RUSTA")]
[Serializable]
public sealed class ti : bns, ISerializable
{
	// Token: 0x060092B1 RID: 37553 RVA: 0x0039FE90 File Offset: 0x0039E090
	private ti(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060092B2 RID: 37554 RVA: 0x0039FE9C File Offset: 0x0039E09C
	public ti()
	{
	}

	// Token: 0x060092B3 RID: 37555 RVA: 0x0039FEA4 File Offset: 0x0039E0A4
	public override void lk(ref csk A_0, cd1 A_1, efk A_2, efk A_3, bool A_4)
	{
		if (A_0.DamageType == DamageType.Acid && (A_4 || (A_3 != null && A_3.b(d8o.e))))
		{
			A_0.Amount = Convert.ToInt32((double)A_0.Amount * (1.0 + d9b.a));
		}
	}

	// Token: 0x060092B4 RID: 37556 RVA: 0x0039FEFC File Offset: 0x0039E0FC
	public override void ll(ref csk A_0, cd1 A_1, efk A_2, efk A_3, double A_4, double A_5, bool A_6, AmmoType A_7, bool A_8, bool A_9)
	{
		this.lk(ref A_0, A_1, A_2, A_3, A_9);
	}

	// Token: 0x060092B5 RID: 37557 RVA: 0x0039FF0C File Offset: 0x0039E10C
	public override string h0(cd1 A_0)
	{
		return string.Format("Урон кислотой увеличивается на {0}% против транспорта и машин.", Convert.ToInt32(d9b.a * 100.0));
	}

	// Token: 0x060092B6 RID: 37558 RVA: 0x0039FF34 File Offset: 0x0039E134
	public override bns h1()
	{
		ti ti = new ti();
		this.h2(ti);
		return ti;
	}
}
