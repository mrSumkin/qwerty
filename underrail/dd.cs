using System;
using System.Runtime.Serialization;

// Token: 0x02001B0F RID: 6927
[eiz("TFB")]
[Serializable]
public sealed class dd : els, ISerializable
{
	// Token: 0x060095F3 RID: 38387 RVA: 0x003ABE6C File Offset: 0x003AA06C
	private dd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060095F4 RID: 38388 RVA: 0x003ABE78 File Offset: 0x003AA078
	public dd(int A_0) : base("tasteForBlood", "Вкус крови", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.TasteForBlood";
		base.MaxStacks = aq0.b;
		base.Stacking = axm.b;
	}

	// Token: 0x060095F5 RID: 38389 RVA: 0x003ABEBC File Offset: 0x003AA0BC
	public override string cb(ll A_0)
	{
		double num = aq0.a((A_0 != null) ? A_0.a() : null);
		return qv.a("StatusEffects/TasteForBlood", new object[]
		{
			(int)(num * (double)base.Stacks * 100.0)
		});
	}
}
