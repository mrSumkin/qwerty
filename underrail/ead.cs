using System;
using System.Runtime.Serialization;

// Token: 0x02001A2B RID: 6699
[eiz("C01")]
[Serializable]
public sealed class ead : wq, ISerializable
{
	// Token: 0x06009112 RID: 37138 RVA: 0x0039C19C File Offset: 0x0039A39C
	private ead(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (coh)A_0.GetValue("C01:I", typeof(coh));
		this.b = A_0.GetDouble("C01:A");
	}

	// Token: 0x06009113 RID: 37139 RVA: 0x0039C1D8 File Offset: 0x0039A3D8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("C01:I", this.a);
		info.AddValue("C01:A", this.b);
	}

	// Token: 0x06009114 RID: 37140 RVA: 0x0039C204 File Offset: 0x0039A404
	public coh c()
	{
		return this.a;
	}

	// Token: 0x06009115 RID: 37141 RVA: 0x0039C20C File Offset: 0x0039A40C
	public double b()
	{
		return this.b;
	}

	// Token: 0x06009116 RID: 37142 RVA: 0x0039C214 File Offset: 0x0039A414
	public ead()
	{
	}

	// Token: 0x06009117 RID: 37143 RVA: 0x0039C21C File Offset: 0x0039A41C
	public ead(coh A_0, double A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06009118 RID: 37144 RVA: 0x0039C234 File Offset: 0x0039A434
	public override void dk(ll A_0, int A_1)
	{
		this.a();
	}

	// Token: 0x06009119 RID: 37145 RVA: 0x0039C23C File Offset: 0x0039A43C
	public override void dl(ll A_0, int A_1)
	{
		this.a();
	}

	// Token: 0x0600911A RID: 37146 RVA: 0x0039C248 File Offset: 0x0039A448
	public override wq dn()
	{
		ead ead = new ead();
		this.@do(ead);
		return ead;
	}

	// Token: 0x0600911B RID: 37147 RVA: 0x0039C264 File Offset: 0x0039A464
	protected override void @do(wq A_0)
	{
		base.@do(A_0);
		ead ead = (ead)A_0;
		ead.b = this.b;
		ead.a = ((this.a != null) ? this.a.fy() : null);
	}

	// Token: 0x0600911C RID: 37148 RVA: 0x0039C2AC File Offset: 0x0039A4AC
	private void a()
	{
		if (this.a != null)
		{
			if (this.a.Battery >= this.b)
			{
				this.a.Battery -= this.b;
				return;
			}
			this.a.Battery = 0.0;
		}
	}

	// Token: 0x04003820 RID: 14368
	private coh a;

	// Token: 0x04003821 RID: 14369
	private double b;
}
