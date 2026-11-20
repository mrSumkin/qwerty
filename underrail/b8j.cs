using System;
using System.Runtime.Serialization;

// Token: 0x02001B41 RID: 6977
[eiz("PBSE")]
[Serializable]
public sealed class b8j : els, ISerializable
{
	// Token: 0x060096E6 RID: 38630 RVA: 0x003AF60C File Offset: 0x003AD80C
	private b8j(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("PBSE:R");
	}

	// Token: 0x060096E7 RID: 38631 RVA: 0x003AF628 File Offset: 0x003AD828
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PBSE:R", this.a);
	}

	// Token: 0x060096E8 RID: 38632 RVA: 0x003AF644 File Offset: 0x003AD844
	public b8j(int A_0, int A_1) : base("psiBoost", "Пси-усилитель", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.PsiBoost";
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.ExpiredAction = "PsiBoosterExpiresAction";
		base.RemovedAction = "PsiBoosterExpiresAction";
		base.TickPeriod = d0u.b;
		this.a = A_1;
		base.DynamicEffects.Add(new ag8(this.a, true));
	}

	// Token: 0x060096E9 RID: 38633 RVA: 0x003AF6C4 File Offset: 0x003AD8C4
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/PsiBoost", new object[]
		{
			this.a
		});
	}

	// Token: 0x04003A10 RID: 14864
	private new int a;
}
