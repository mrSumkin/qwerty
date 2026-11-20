using System;
using System.Runtime.Serialization;

// Token: 0x02001B4B RID: 6987
[eiz("Y28")]
[Serializable]
public sealed class bfw : b8c
{
	// Token: 0x0600971F RID: 38687 RVA: 0x003B0000 File Offset: 0x003AE200
	private bfw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009720 RID: 38688 RVA: 0x003B000C File Offset: 0x003AE20C
	public bfw()
	{
	}

	// Token: 0x06009721 RID: 38689 RVA: 0x003B0014 File Offset: 0x003AE214
	public override string xq()
	{
		return qv.a("Items\\ArmorItemModifier/CriticalHitUnblockedBulletDamageArmorReduction", new object[]
		{
			(int)(base.Reduction * 100.0)
		});
	}

	// Token: 0x06009722 RID: 38690 RVA: 0x003B0040 File Offset: 0x003AE240
	public override c3e xr()
	{
		bfw bfw = new bfw();
		this.ael(bfw);
		return bfw;
	}

	// Token: 0x06009723 RID: 38691 RVA: 0x003B005C File Offset: 0x003AE25C
	public override c3e xs(int A_0)
	{
		return new bfw
		{
			Reduction = (double)A_0 * 0.0035
		};
	}

	// Token: 0x06009724 RID: 38692 RVA: 0x003B0078 File Offset: 0x003AE278
	public override bool xt(cwt A_0)
	{
		return A_0 != null && eub.e(A_0.x);
	}
}
