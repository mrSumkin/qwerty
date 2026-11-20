using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A93 RID: 6803
[eiz("CEPS")]
[Serializable]
public sealed class bhe : els, ISerializable, dl2
{
	// Token: 0x060093AB RID: 37803 RVA: 0x003A3798 File Offset: 0x003A1998
	private bhe(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060093AC RID: 37804 RVA: 0x003A37A4 File Offset: 0x003A19A4
	public bhe(int A_0) : base(bhe.a, "Яд (пещерное ухо)", ci8.c)
	{
		base.Duration = A_0;
		base.Icon = "Status.Poison";
		base.Stacking = axm.b;
		base.StaticEffects.Add(new e3r(DamageType.Bio, ezx.a));
		base.StaticEffects.Add(new ax6("Perception", -ezx.b));
	}

	// Token: 0x060093AD RID: 37805 RVA: 0x003A380C File Offset: 0x003A1A0C
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/CaveEarPoison", new object[]
		{
			(int)(ezx.a * 100.0),
			ezx.b
		});
	}

	// Token: 0x040038BF RID: 14527
	public new static readonly string a = "poison:CaveEarPoison";
}
