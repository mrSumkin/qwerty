using System;
using System.Runtime.Serialization;

// Token: 0x02001AE0 RID: 6880
[eiz("HTSE")]
[Serializable]
public sealed class dio : els, ISerializable
{
	// Token: 0x06009511 RID: 38161 RVA: 0x003A8934 File Offset: 0x003A6B34
	private dio(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009512 RID: 38162 RVA: 0x003A8940 File Offset: 0x003A6B40
	public dio(int A_0) : base(dio.a, "Капкан", ci8.c)
	{
		base.Duration = A_0;
		base.TickPeriod = d0u.b;
		base.Icon = "Explosives.180";
		base.VisualEffects.Add(new ud(this, "HopperTrap"));
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.StaticEffects.Add(new ap0());
	}

	// Token: 0x06009513 RID: 38163 RVA: 0x003A89B0 File Offset: 0x003A6BB0
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/Trapped");
	}

	// Token: 0x04003963 RID: 14691
	public new static readonly string a = "hopperTrapped";
}
