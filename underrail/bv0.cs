using System;
using System.Runtime.Serialization;

// Token: 0x02001B0C RID: 6924
[eiz("EN2")]
[Serializable]
public sealed class bv0 : els, ISerializable
{
	// Token: 0x060095E4 RID: 38372 RVA: 0x003ABB54 File Offset: 0x003A9D54
	private bv0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 539 && base.StaticEffects.Count == 0)
		{
			base.StaticEffects.Add(new awd());
		}
	}

	// Token: 0x060095E5 RID: 38373 RVA: 0x003ABB90 File Offset: 0x003A9D90
	public override bool oa()
	{
		return false;
	}

	// Token: 0x060095E6 RID: 38374 RVA: 0x003ABB94 File Offset: 0x003A9D94
	public bv0(int A_0) : base(bv0.a, "Ярость", ci8.c)
	{
		base.Icon = "Psi.Enrage";
		this.y = "REJ0";
		this.aa = "REJ0";
		base.StaticEffects.Add(new awd());
		base.VisualEffects.Add(new ud(this, "Rage"));
		base.Duration = A_0;
	}

	// Token: 0x060095E7 RID: 38375 RVA: 0x003ABC00 File Offset: 0x003A9E00
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/Rage");
	}

	// Token: 0x040039B2 RID: 14770
	public new static readonly string a = "rage";
}
