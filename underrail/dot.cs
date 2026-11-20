using System;
using System.Runtime.Serialization;

// Token: 0x02001B3D RID: 6973
[eiz("MDSE")]
[Serializable]
public sealed class dot : els, ISerializable
{
	// Token: 0x060096CD RID: 38605 RVA: 0x003AEEF0 File Offset: 0x003AD0F0
	private dot(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("MDSE:RBFPS");
		this.c = A_0.GetInt32("MDSE:WS");
		this.a = (A_0.GetValue("MDSE:E", typeof(ag8)) as ag8);
	}

	// Token: 0x060096CE RID: 38606 RVA: 0x003AEF48 File Offset: 0x003AD148
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MDSE:RBFPS", this.b);
		info.AddValue("MDSE:WS", this.c);
		info.AddValue("MDSE:E", this.a);
	}

	// Token: 0x17000281 RID: 641
	// (get) Token: 0x060096CF RID: 38607 RVA: 0x003AEF90 File Offset: 0x003AD190
	public int WithdrawalStacks
	{
		get
		{
			return this.c;
		}
	}

	// Token: 0x060096D0 RID: 38608 RVA: 0x003AEF98 File Offset: 0x003AD198
	public dot(int A_0, int A_1, int A_2, int A_3) : base("mindDarts", "Пси-рывок", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.MindDarts";
		base.MaxStacks = A_1;
		base.Stacking = axm.b;
		base.ExpiredAction = "MindDartsExpireAction";
		base.RemovedAction = "MindDartsExpireAction";
		base.TickPeriod = d0u.b;
		this.b = A_2;
		this.c = A_3;
		this.a = new ag8(this.b, true);
		base.DynamicEffects.Add(this.a);
	}

	// Token: 0x060096D1 RID: 38609 RVA: 0x003AF02C File Offset: 0x003AD22C
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/PsiBoost", new object[]
		{
			this.b * base.Stacks
		});
	}

	// Token: 0x060096D2 RID: 38610 RVA: 0x003AF054 File Offset: 0x003AD254
	protected override void c8()
	{
		base.c8();
		if (this.a != null)
		{
			this.a.a(this.b * base.Stacks);
		}
	}

	// Token: 0x04003A01 RID: 14849
	private new ag8 a;

	// Token: 0x04003A02 RID: 14850
	private int b;

	// Token: 0x04003A03 RID: 14851
	private new int c;
}
