using System;
using System.Runtime.Serialization;

// Token: 0x02001ACD RID: 6861
[eiz("RPST")]
[Serializable]
public sealed class edz : els, ISerializable
{
	// Token: 0x060094BE RID: 38078 RVA: 0x003A78C0 File Offset: 0x003A5AC0
	private edz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060094BF RID: 38079 RVA: 0x003A78CC File Offset: 0x003A5ACC
	public edz() : this(0)
	{
	}

	// Token: 0x060094C0 RID: 38080 RVA: 0x003A78D8 File Offset: 0x003A5AD8
	public edz(int A_0) : this(A_0, edz.b * d0u.b)
	{
	}

	// Token: 0x060094C1 RID: 38081 RVA: 0x003A78F0 File Offset: 0x003A5AF0
	public edz(int A_0, int A_1) : base(edz.a, "Ответный удар", ci8.b)
	{
		base.Stacking = axm.b;
		base.Duration = A_1;
		base.Icon = "xpbl_Abilities.4";
		base.MaxStacks += A_0;
	}

	// Token: 0x060094C2 RID: 38082 RVA: 0x003A7938 File Offset: 0x003A5B38
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/Riposte");
	}

	// Token: 0x0400394B RID: 14667
	public new static readonly string a = "riposte";

	// Token: 0x0400394C RID: 14668
	public static readonly int b = 1;
}
