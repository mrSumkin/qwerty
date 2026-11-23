using System;
using System.Runtime.Serialization;

// Token: 0x02001A9D RID: 6813
[eiz("BDPSE")]
[Serializable]
public sealed class dns : els, ISerializable, dl2
{
	// Token: 0x060093D8 RID: 37848 RVA: 0x003A40F8 File Offset: 0x003A22F8
	private dns(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060093D9 RID: 37849 RVA: 0x003A4104 File Offset: 0x003A2304
	public dns(int A_0) : base(dns.a, "Яд (чёрный дракон)", ci8.c)
	{
		base.Duration = A_0;
		base.Icon = "Status.BlackDragonPoison";
		base.Stacking = axm.b;
		base.VisualEffects.Add(new ud(this, "Inhibited"));
		base.StaticEffects.Add(new acl());
	}

	// Token: 0x060093DA RID: 37850 RVA: 0x003A4164 File Offset: 0x003A2364
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/BlackDragonPoison");
	}

	// Token: 0x040038D0 RID: 14544
	public new static string a = "poison:BlackDragonPoison";
}
