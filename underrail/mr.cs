using System;
using System.Runtime.Serialization;

// Token: 0x02001B16 RID: 6934
[eiz("ISPSE")]
[Serializable]
public sealed class mr : els, ISerializable
{
	// Token: 0x06009611 RID: 38417 RVA: 0x003AC688 File Offset: 0x003AA888
	private mr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009612 RID: 38418 RVA: 0x003AC694 File Offset: 0x003AA894
	public mr() : base(mr.b, "Инфузия: скорость", ci8.b)
	{
		base.Icon = "Status.102";
		base.StaticEffects.Add(new ba(30, false, true, false));
		base.StaticEffects.Add(new i0(0.3f, false, false, false));
	}

	// Token: 0x06009613 RID: 38419 RVA: 0x003AC6EC File Offset: 0x003AA8EC
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Infusion_Speed", new object[]
		{
			30
		});
	}

	// Token: 0x040039BE RID: 14782
	private new const int a = 30;

	// Token: 0x040039BF RID: 14783
	public static string b = "infusion_speed";
}
