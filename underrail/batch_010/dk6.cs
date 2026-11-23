using System;
using System.Runtime.Serialization;

// Token: 0x02001AE4 RID: 6884
[eiz("TRWS")]
[Serializable]
public sealed class dk6 : els, ISerializable
{
	// Token: 0x06009523 RID: 38179 RVA: 0x003A8D24 File Offset: 0x003A6F24
	private dk6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("TRWS:X");
	}

	// Token: 0x06009524 RID: 38180 RVA: 0x003A8D40 File Offset: 0x003A6F40
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TRWS:X", this.b);
	}

	// Token: 0x06009525 RID: 38181 RVA: 0x003A8D5C File Offset: 0x003A6F5C
	public int a()
	{
		return this.b;
	}

	// Token: 0x06009526 RID: 38182 RVA: 0x003A8D64 File Offset: 0x003A6F64
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06009527 RID: 38183 RVA: 0x003A8D70 File Offset: 0x003A6F70
	public dk6(int A_0, int A_1) : base(dk6.a, "Перемотка времени", ci8.c)
	{
		base.Duration = A_0;
		base.TickPeriod = d0u.b;
		base.Icon = "Psi.TemporaryRewind";
		base.ExpiredAction = "TemporaryRewindExpiresAction";
		base.MaxStacks = 1;
		base.Stacking = axm.c;
		this.b = A_1;
	}

	// Token: 0x06009528 RID: 38184 RVA: 0x003A8DCC File Offset: 0x003A6FCC
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/TemporaryRewind", new object[]
		{
			this.b
		});
	}

	// Token: 0x04003968 RID: 14696
	public new static readonly string a = "temporaryRewind";

	// Token: 0x04003969 RID: 14697
	private int b;
}
