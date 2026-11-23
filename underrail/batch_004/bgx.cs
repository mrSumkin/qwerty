using System;
using System.Runtime.Serialization;

// Token: 0x02001A77 RID: 6775
[eiz("JBSE")]
[Serializable]
public sealed class bgx : els, ISerializable
{
	// Token: 0x0600931F RID: 37663 RVA: 0x003A13E4 File Offset: 0x0039F5E4
	private bgx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("JBSE:E");
		this.c = (Guid)A_0.GetValue("JBSE:W", typeof(Guid));
		this.d = A_0.GetString("JBSE:N");
	}

	// Token: 0x06009320 RID: 37664 RVA: 0x003A143C File Offset: 0x0039F63C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("JBSE:E", this.b);
		info.AddValue("JBSE:W", this.c);
		info.AddValue("JBSE:N", this.d);
	}

	// Token: 0x06009321 RID: 37665 RVA: 0x003A148C File Offset: 0x0039F68C
	public int b()
	{
		return this.b;
	}

	// Token: 0x06009322 RID: 37666 RVA: 0x003A1494 File Offset: 0x0039F694
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06009323 RID: 37667 RVA: 0x003A14A0 File Offset: 0x0039F6A0
	public Guid a()
	{
		return this.c;
	}

	// Token: 0x06009324 RID: 37668 RVA: 0x003A14A8 File Offset: 0x0039F6A8
	public void a(Guid A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06009325 RID: 37669 RVA: 0x003A14B4 File Offset: 0x0039F6B4
	public bgx(int A_0, int A_1, coh A_2) : base(bgx.a, "Ускорение ротора", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.139";
		base.MaxStacks = 1;
		base.Stacking = axm.c;
		this.b = A_1;
		if (A_2 != null && A_2.Definition != null)
		{
			this.c = A_2.Id;
			this.d = A_2.Definition.az();
		}
	}

	// Token: 0x06009326 RID: 37670 RVA: 0x003A1528 File Offset: 0x0039F728
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/JumpstarterBoost", new object[]
		{
			this.b,
			this.d
		});
	}

	// Token: 0x0400387C RID: 14460
	public new static readonly string a = "jumpstarterBoost";

	// Token: 0x0400387D RID: 14461
	private int b;

	// Token: 0x0400387E RID: 14462
	private new Guid c;

	// Token: 0x0400387F RID: 14463
	private new string d;
}
