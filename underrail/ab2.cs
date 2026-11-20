using System;
using System.Runtime.Serialization;

// Token: 0x02001B3E RID: 6974
[eiz("FE")]
[Serializable]
public sealed class ab2 : els, ISerializable
{
	// Token: 0x060096D3 RID: 38611 RVA: 0x003AF080 File Offset: 0x003AD280
	private ab2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetSingle("FE:MSD");
		this.b = A_0.GetSingle("FE:ARTI");
		this.c = A_0.GetInt32("FE:A");
	}

	// Token: 0x060096D4 RID: 38612 RVA: 0x003AF0C8 File Offset: 0x003AD2C8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FE:MSD", this.a);
		info.AddValue("FE:ARTI", this.b);
		info.AddValue("FE:A", this.c);
	}

	// Token: 0x060096D5 RID: 38613 RVA: 0x003AF110 File Offset: 0x003AD310
	public ab2(float A_0, int A_1, float A_2, int A_3) : base("fatigue", "Усталость", ci8.c)
	{
		base.Duration = A_3;
		base.Icon = "Status.Fatigue";
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		this.a = A_0;
		this.b = A_2;
		this.c = A_1;
		base.StaticEffects.Add(new i0(-this.a, false, false, true)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bjo(this.b, 0, null)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new d9(-this.c, true, false));
	}

	// Token: 0x060096D6 RID: 38614 RVA: 0x003AF1C8 File Offset: 0x003AD3C8
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Fatigue", new object[]
		{
			this.c
		});
	}

	// Token: 0x04003A04 RID: 14852
	private new float a;

	// Token: 0x04003A05 RID: 14853
	private float b;

	// Token: 0x04003A06 RID: 14854
	private new int c;
}
