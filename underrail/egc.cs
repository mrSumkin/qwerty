using System;
using System.Runtime.Serialization;

// Token: 0x02001B0A RID: 6922
[eiz("TRE")]
[Serializable]
public sealed class egc : els, ISerializable
{
	// Token: 0x060095DC RID: 38364 RVA: 0x003AB9B0 File Offset: 0x003A9BB0
	private egc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060095DD RID: 38365 RVA: 0x003AB9BC File Offset: 0x003A9BBC
	public egc(int A_0) : base("psionicTrance", "Псионический транс", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.PsionicTrance";
		base.ExpiredAction = "BlueExpirationAction";
		base.RemovedAction = "BlueExpirationAction";
		base.Stacking = axm.b;
		base.StaticEffects.Add(new db(null, (float)egc.a));
		base.StaticEffects.Add(new ato(null, (float)egc.b));
	}

	// Token: 0x060095DE RID: 38366 RVA: 0x003ABA48 File Offset: 0x003A9C48
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/PsionicTrance", new object[]
		{
			(int)(egc.a * 100.0),
			(int)(egc.b * 100.0)
		});
	}

	// Token: 0x040039AF RID: 14767
	public new static readonly double a = 1.0;

	// Token: 0x040039B0 RID: 14768
	public static readonly double b = 0.2;
}
