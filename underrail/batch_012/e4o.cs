using System;
using System.Runtime.Serialization;

// Token: 0x020013DD RID: 5085
[eiz("EFA")]
[Serializable]
public sealed class e4o : dvv, ISerializable
{
	// Token: 0x06007289 RID: 29321 RVA: 0x00301EF4 File Offset: 0x003000F4
	private e4o(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ar7)A_0.GetValue("EFA:ER", typeof(ar7));
			this.b = A_0.GetByte("EFA:SA");
			this.c = A_0.GetByte("EFA:EA");
			this.d = A_0.GetDouble("EFA:APM");
			this.e = A_0.GetDouble("EFA:A");
			this.f = A_0.GetInt32("EFA:S");
			return;
		}
		if (base.GetType() == typeof(e4o))
		{
			this.a = (ar7)A_0.GetValue("_EntityRef", typeof(ar7));
			this.b = A_0.GetByte("_StartAlpha");
			this.c = A_0.GetByte("_EndAlpha");
			this.d = A_0.GetDouble("_AlphaPerMilisecond");
			this.e = A_0.GetDouble("_Alpha");
			this.f = A_0.GetInt32("_Sign");
			return;
		}
		this.a = (ar7)A_0.GetValue("EntityFadeAction+_EntityRef", typeof(ar7));
		this.b = A_0.GetByte("EntityFadeAction+_StartAlpha");
		this.c = A_0.GetByte("EntityFadeAction+_EndAlpha");
		this.d = A_0.GetDouble("EntityFadeAction+_AlphaPerMilisecond");
		this.e = A_0.GetDouble("EntityFadeAction+_Alpha");
		this.f = A_0.GetInt32("EntityFadeAction+_Sign");
	}

	// Token: 0x0600728A RID: 29322 RVA: 0x003020A8 File Offset: 0x003002A8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("EFA:ER", this.a);
		info.AddValue("EFA:SA", this.b);
		info.AddValue("EFA:EA", this.c);
		info.AddValue("EFA:APM", this.d);
		info.AddValue("EFA:A", this.e);
		info.AddValue("EFA:S", this.f);
	}

	// Token: 0x0600728B RID: 29323 RVA: 0x00302124 File Offset: 0x00300324
	public byte b()
	{
		return this.b;
	}

	// Token: 0x0600728C RID: 29324 RVA: 0x0030212C File Offset: 0x0030032C
	public void a(byte A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600728D RID: 29325 RVA: 0x00302138 File Offset: 0x00300338
	public byte d()
	{
		return this.c;
	}

	// Token: 0x0600728E RID: 29326 RVA: 0x00302140 File Offset: 0x00300340
	public void b(byte A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600728F RID: 29327 RVA: 0x0030214C File Offset: 0x0030034C
	public double c()
	{
		return this.d;
	}

	// Token: 0x06007290 RID: 29328 RVA: 0x00302154 File Offset: 0x00300354
	public void a(double A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06007291 RID: 29329 RVA: 0x00302160 File Offset: 0x00300360
	private c5x a()
	{
		return this.a.ao() as c5x;
	}

	// Token: 0x06007292 RID: 29330 RVA: 0x00302174 File Offset: 0x00300374
	public e4o(c5x A_0)
	{
		this.a = new ar7(A_0);
	}

	// Token: 0x06007293 RID: 29331 RVA: 0x003021A4 File Offset: 0x003003A4
	protected override dc4 dt()
	{
		if (this.a() != null && this.b != this.c)
		{
			this.e = (double)this.b;
			this.f = Math.Sign((int)(this.c - this.b));
			this.a().ae = new float?((float)this.b / 255f);
			return dc4.b;
		}
		return dc4.e;
	}

	// Token: 0x06007294 RID: 29332 RVA: 0x00302214 File Offset: 0x00300414
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a() == null)
		{
			return dc4.c;
		}
		this.e += this.c() * A_1.TotalMilliseconds * (double)this.f;
		if ((this.f > 0 && this.e >= (double)this.c) || (this.f < 0 && this.e <= (double)this.c))
		{
			if (this.c >= 255)
			{
				this.a().ae = null;
			}
			return dc4.c;
		}
		try
		{
			this.a().ae = new float?((float)(this.e / 256.0));
		}
		catch
		{
		}
		return dc4.b;
	}

	// Token: 0x04002EC8 RID: 11976
	private new ar7 a;

	// Token: 0x04002EC9 RID: 11977
	private byte b;

	// Token: 0x04002ECA RID: 11978
	private byte c = byte.MaxValue;

	// Token: 0x04002ECB RID: 11979
	private double d = 0.17;

	// Token: 0x04002ECC RID: 11980
	private double e;

	// Token: 0x04002ECD RID: 11981
	private int f;
}
