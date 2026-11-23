using System;
using System.Runtime.Serialization;

// Token: 0x020013D9 RID: 5081
[eiz("EFA2")]
[Serializable]
public sealed class ad6 : dvv, ISerializable
{
	// Token: 0x06007262 RID: 29282 RVA: 0x00301194 File Offset: 0x002FF394
	private ad6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ar7)A_0.GetValue("EFA2:ER", typeof(ar7));
			this.b = A_0.GetDouble("EFA2:SA");
			this.c = A_0.GetDouble("EFA2:EA");
			this.d = A_0.GetDouble("EFA2:APM");
			this.e = A_0.GetDouble("EFA2:A");
			this.f = A_0.GetInt32("EFA2:S");
			return;
		}
		if (base.GetType() == typeof(e4o))
		{
			this.a = (ar7)A_0.GetValue("_EntityRef", typeof(ar7));
			this.b = A_0.GetDouble("_StartAlpha");
			this.c = A_0.GetDouble("_EndAlpha");
			this.d = A_0.GetDouble("_AlphaPerMilisecond");
			this.e = A_0.GetDouble("_Alpha");
			this.f = A_0.GetInt32("_Sign");
			return;
		}
		this.a = (ar7)A_0.GetValue("EntityFadeAction+_EntityRef", typeof(ar7));
		this.b = A_0.GetDouble("EntityFadeAction+_StartAlpha");
		this.c = A_0.GetDouble("EntityFadeAction+_EndAlpha");
		this.d = A_0.GetDouble("EntityFadeAction+_AlphaPerMilisecond");
		this.e = A_0.GetDouble("EntityFadeAction+_Alpha");
		this.f = A_0.GetInt32("EntityFadeAction+_Sign");
	}

	// Token: 0x06007263 RID: 29283 RVA: 0x0030134C File Offset: 0x002FF54C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("EFA2:ER", this.a);
		info.AddValue("EFA2:SA", this.b);
		info.AddValue("EFA2:EA", this.c);
		info.AddValue("EFA2:APM", this.d);
		info.AddValue("EFA2:A", this.e);
		info.AddValue("EFA2:S", this.f);
	}

	// Token: 0x06007264 RID: 29284 RVA: 0x003013C8 File Offset: 0x002FF5C8
	public double b()
	{
		return this.b;
	}

	// Token: 0x06007265 RID: 29285 RVA: 0x003013D0 File Offset: 0x002FF5D0
	public void b(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06007266 RID: 29286 RVA: 0x003013DC File Offset: 0x002FF5DC
	public double d()
	{
		return this.c;
	}

	// Token: 0x06007267 RID: 29287 RVA: 0x003013E4 File Offset: 0x002FF5E4
	public void c(double A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06007268 RID: 29288 RVA: 0x003013F0 File Offset: 0x002FF5F0
	public double c()
	{
		return this.d;
	}

	// Token: 0x06007269 RID: 29289 RVA: 0x003013F8 File Offset: 0x002FF5F8
	public void a(double A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600726A RID: 29290 RVA: 0x00301404 File Offset: 0x002FF604
	private c5x a()
	{
		return this.a.ao() as c5x;
	}

	// Token: 0x0600726B RID: 29291 RVA: 0x00301418 File Offset: 0x002FF618
	public ad6(c5x A_0)
	{
		this.a = new ar7(A_0);
	}

	// Token: 0x0600726C RID: 29292 RVA: 0x0030144C File Offset: 0x002FF64C
	protected override dc4 dt()
	{
		if (this.a() != null && this.b != this.c)
		{
			this.e = this.b;
			this.f = Math.Sign(this.c - this.b);
			this.a().ae = new float?((float)this.b);
			return dc4.b;
		}
		return dc4.e;
	}

	// Token: 0x0600726D RID: 29293 RVA: 0x003014B4 File Offset: 0x002FF6B4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a() == null)
		{
			return dc4.c;
		}
		this.e += this.d * A_1.TotalMilliseconds * (double)this.f;
		if ((this.f > 0 && this.e >= this.c) || (this.f < 0 && this.e <= this.c))
		{
			if (this.c >= 1.0)
			{
				this.a().ae = null;
			}
			else
			{
				this.a().ae = new float?((float)this.c);
			}
			return dc4.c;
		}
		try
		{
			this.a().ae = new float?((float)this.e);
		}
		catch
		{
		}
		return dc4.b;
	}

	// Token: 0x04002EB3 RID: 11955
	private new ar7 a;

	// Token: 0x04002EB4 RID: 11956
	private double b;

	// Token: 0x04002EB5 RID: 11957
	private double c = 1.0;

	// Token: 0x04002EB6 RID: 11958
	private double d = 0.001;

	// Token: 0x04002EB7 RID: 11959
	private double e;

	// Token: 0x04002EB8 RID: 11960
	private int f;
}
