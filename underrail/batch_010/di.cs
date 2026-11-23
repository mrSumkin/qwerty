using System;
using System.Runtime.Serialization;

// Token: 0x02001AFF RID: 6911
[eiz("GRSE")]
[Serializable]
public sealed class di : els, ISerializable
{
	// Token: 0x060095AC RID: 38316 RVA: 0x003AAE3C File Offset: 0x003A903C
	private di(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060095AD RID: 38317 RVA: 0x003AAE48 File Offset: 0x003A9048
	public di() : base(di.a, "Неистовство стрельбы", ci8.b)
	{
		base.Duration = d0u.b;
		base.Icon = "Status.Commando";
		base.Stacking = axm.b;
	}

	// Token: 0x060095AE RID: 38318 RVA: 0x003AAE84 File Offset: 0x003A9084
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/GunRush");
	}

	// Token: 0x0400399D RID: 14749
	public new static readonly string a = "gunRush";
}
