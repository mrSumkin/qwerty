using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x020013D3 RID: 5075
[eiz("LFA2")]
[Serializable]
public sealed class exq : dvv, ISerializable
{
	// Token: 0x0600723A RID: 29242 RVA: 0x003005F4 File Offset: 0x002FE7F4
	private exq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (ar7)A_0.GetValue("LFA2:ER", typeof(ar7));
		this.b = A_0.GetDouble("LFA2:SA");
		this.c = A_0.GetDouble("LFA2:EA");
		this.d = A_0.GetDouble("LFA2:APM");
		this.e = A_0.GetDouble("LFA2:A");
		this.f = A_0.GetInt32("LFA2:S");
		this.g = A_0.GetString("LFA2:LN");
	}

	// Token: 0x0600723B RID: 29243 RVA: 0x003006B0 File Offset: 0x002FE8B0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LFA2:ER", this.a);
		info.AddValue("LFA2:SA", this.b);
		info.AddValue("LFA2:EA", this.c);
		info.AddValue("LFA2:APM", this.d);
		info.AddValue("LFA2:A", this.e);
		info.AddValue("LFA2:S", this.f);
		info.AddValue("LFA2:LN", this.g);
	}

	// Token: 0x0600723C RID: 29244 RVA: 0x0030073C File Offset: 0x002FE93C
	public double c()
	{
		return this.b;
	}

	// Token: 0x0600723D RID: 29245 RVA: 0x00300744 File Offset: 0x002FE944
	public void b(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600723E RID: 29246 RVA: 0x00300750 File Offset: 0x002FE950
	public double d()
	{
		return this.c;
	}

	// Token: 0x0600723F RID: 29247 RVA: 0x00300758 File Offset: 0x002FE958
	public void c(double A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06007240 RID: 29248 RVA: 0x00300764 File Offset: 0x002FE964
	public double e()
	{
		return this.d;
	}

	// Token: 0x06007241 RID: 29249 RVA: 0x0030076C File Offset: 0x002FE96C
	public void a(double A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06007242 RID: 29250 RVA: 0x00300778 File Offset: 0x002FE978
	private c5x b()
	{
		return this.a.ao() as c5x;
	}

	// Token: 0x06007243 RID: 29251 RVA: 0x0030078C File Offset: 0x002FE98C
	private string a()
	{
		return this.g;
	}

	// Token: 0x06007244 RID: 29252 RVA: 0x00300794 File Offset: 0x002FE994
	public exq(c5x A_0, string A_1)
	{
		this.a = new ar7(A_0);
		this.g = A_1;
	}

	// Token: 0x06007245 RID: 29253 RVA: 0x003007D0 File Offset: 0x002FE9D0
	protected override dc4 dt()
	{
		if (this.b() == null || this.b == this.c || string.IsNullOrEmpty(this.g))
		{
			return dc4.e;
		}
		this.e = this.b;
		this.f = Math.Sign(this.c - this.b);
		bsf bsf = Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(this.b().RaysEmitters), new Func<bsf, bool>(this.b)));
		if (bsf == null)
		{
			return dc4.e;
		}
		bsf.Definition.Light = new ae8(bsf.Definition.Light.d(), (float)this.b, bsf.Definition.Light.a());
		bsf.Definition.d();
		return dc4.b;
	}

	// Token: 0x06007246 RID: 29254 RVA: 0x003008A8 File Offset: 0x002FEAA8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.b() == null || string.IsNullOrEmpty(this.g))
		{
			return dc4.c;
		}
		bsf bsf = Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(this.b().RaysEmitters), new Func<bsf, bool>(this.a)));
		if (bsf == null)
		{
			return dc4.e;
		}
		this.e += this.d * A_1.TotalMilliseconds * (double)this.f;
		float a_ = (float)this.e;
		bsf.Definition.Light = new ae8(bsf.Definition.Light.d(), a_, bsf.Definition.Light.a());
		bsf.Definition.d();
		if ((this.f > 0 && this.e >= this.c) || (this.f < 0 && this.e <= this.c))
		{
			return dc4.c;
		}
		return dc4.b;
	}

	// Token: 0x06007247 RID: 29255 RVA: 0x003009AC File Offset: 0x002FEBAC
	[CompilerGenerated]
	private bool b(bsf A_0)
	{
		return A_0.Definition != null && A_0.Definition.Name == this.g;
	}

	// Token: 0x06007248 RID: 29256 RVA: 0x003009D4 File Offset: 0x002FEBD4
	[CompilerGenerated]
	private bool a(bsf A_0)
	{
		return A_0.Definition != null && A_0.Definition.Name == this.g;
	}

	// Token: 0x04002E9B RID: 11931
	private new ar7 a;

	// Token: 0x04002E9C RID: 11932
	private double b;

	// Token: 0x04002E9D RID: 11933
	private double c = 1.0;

	// Token: 0x04002E9E RID: 11934
	private double d = 0.001;

	// Token: 0x04002E9F RID: 11935
	private double e;

	// Token: 0x04002EA0 RID: 11936
	private int f;

	// Token: 0x04002EA1 RID: 11937
	private string g;
}
