using System;
using System.Runtime.Serialization;

// Token: 0x02001A8F RID: 6799
[eiz("IRMNTSE")]
[Serializable]
public sealed class d0j : els, ISerializable
{
	// Token: 0x06009399 RID: 37785 RVA: 0x003A3180 File Offset: 0x003A1380
	private d0j(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600939A RID: 37786 RVA: 0x003A318C File Offset: 0x003A138C
	public d0j(int A_0) : base("iceRemnant", "Остатки льда", ci8.a)
	{
		base.Duration = A_0;
		base.Icon = "Status.PsiBoost";
		base.Stacking = axm.b;
		base.VisualEffects.Add(new ud(this, "FrostSpirit"));
		base.VisualEffects.Add(new ud(this, "Displacement"));
	}

	// Token: 0x0600939B RID: 37787 RVA: 0x003A31F0 File Offset: 0x003A13F0
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/IceRemnant");
	}
}
