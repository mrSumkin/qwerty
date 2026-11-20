using System;
using System.Runtime.Serialization;

// Token: 0x02001AF8 RID: 6904
[eiz("CSX")]
[Serializable]
public sealed class a3w : els, ISerializable
{
	// Token: 0x0600958A RID: 38282 RVA: 0x003AA8E4 File Offset: 0x003A8AE4
	private a3w(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("CSX:B");
	}

	// Token: 0x0600958B RID: 38283 RVA: 0x003AA900 File Offset: 0x003A8B00
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CSX:B", this.b);
	}

	// Token: 0x17000277 RID: 631
	// (get) Token: 0x0600958C RID: 38284 RVA: 0x003AA91C File Offset: 0x003A8B1C
	public int BlockAmount
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x0600958D RID: 38285 RVA: 0x003AA928 File Offset: 0x003A8B28
	public a3w(int A_0, int A_1) : base(a3w.a, "Криощит", ci8.b)
	{
		base.Icon = "Psi.CryoShield";
		base.MaxStacks = 5;
		base.VisualEffects.Add(new ud(this, "Cryoshield"));
		this.b = A_1;
		base.Power = this.b;
		base.Duration = A_0;
	}

	// Token: 0x0600958E RID: 38286 RVA: 0x003AA988 File Offset: 0x003A8B88
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/CryoShield", new object[]
		{
			(int)(a9.d * 100.0),
			this.b
		});
	}

	// Token: 0x04003995 RID: 14741
	public new static readonly string a = "cryoShield";

	// Token: 0x04003996 RID: 14742
	private int b;
}
