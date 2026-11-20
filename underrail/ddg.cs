using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x02001451 RID: 5201
[eiz("CELTA")]
[Serializable]
public sealed class ddg : b1z, ISerializable
{
	// Token: 0x060074EE RID: 29934 RVA: 0x00319650 File Offset: 0x00317850
	private ddg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (EntityAspectReference<alv, alv>)A_0.GetValue("CELTA:CE", typeof(EntityAspectReference<alv, alv>));
			this.b = A_0.GetInt32("CELTA:SF");
			this.c = A_0.GetInt32("CELTA:TS");
			this.d = A_0.GetInt32("CELTA:SC");
			this.e = A_0.GetDouble("CELTA:ST");
			this.f = A_0.GetBoolean("CELTA:SLD");
			this.g = A_0.GetDouble("CELTA:TC");
			this.h = A_0.GetInt32("CELTA:DS");
			return;
		}
		if (base.GetType() == typeof(ddg))
		{
			this.a = (EntityAspectReference<alv, alv>)A_0.GetValue("_ComplexEntity", typeof(EntityAspectReference<alv, alv>));
			this.b = A_0.GetInt32("_StartFrame");
			this.c = A_0.GetInt32("_TotalSteps");
			this.d = A_0.GetInt32("_StepChange");
			this.e = A_0.GetDouble("_StepTime");
			this.f = A_0.GetBoolean("_SkipLastDelay");
			this.g = A_0.GetDouble("_TimeCache");
			this.h = A_0.GetInt32("_DoneSteps");
			return;
		}
		this.a = (EntityAspectReference<alv, alv>)A_0.GetValue("ComplexEntityLinearTransitionAction+_ComplexEntity", typeof(EntityAspectReference<alv, alv>));
		this.b = A_0.GetInt32("ComplexEntityLinearTransitionAction+_StartFrame");
		this.c = A_0.GetInt32("ComplexEntityLinearTransitionAction+_TotalSteps");
		this.d = A_0.GetInt32("ComplexEntityLinearTransitionAction+_StepChange");
		this.e = A_0.GetDouble("ComplexEntityLinearTransitionAction+_StepTime");
		this.f = A_0.GetBoolean("ComplexEntityLinearTransitionAction+_SkipLastDelay");
		this.g = A_0.GetDouble("ComplexEntityLinearTransitionAction+_TimeCache");
		this.h = A_0.GetInt32("ComplexEntityLinearTransitionAction+_DoneSteps");
	}

	// Token: 0x060074EF RID: 29935 RVA: 0x00319870 File Offset: 0x00317A70
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CELTA:CE", this.a);
		info.AddValue("CELTA:SF", this.b);
		info.AddValue("CELTA:TS", this.c);
		info.AddValue("CELTA:SC", this.d);
		info.AddValue("CELTA:ST", this.e);
		info.AddValue("CELTA:SLD", this.f);
		info.AddValue("CELTA:TC", this.g);
		info.AddValue("CELTA:DS", this.h);
	}

	// Token: 0x060074F0 RID: 29936 RVA: 0x00319910 File Offset: 0x00317B10
	public alv g()
	{
		if (this.a != null)
		{
			return this.a.ao();
		}
		return null;
	}

	// Token: 0x060074F1 RID: 29937 RVA: 0x0031992C File Offset: 0x00317B2C
	public int d()
	{
		return this.b;
	}

	// Token: 0x060074F2 RID: 29938 RVA: 0x00319934 File Offset: 0x00317B34
	public void b(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060074F3 RID: 29939 RVA: 0x00319940 File Offset: 0x00317B40
	public int e()
	{
		return this.c;
	}

	// Token: 0x060074F4 RID: 29940 RVA: 0x00319948 File Offset: 0x00317B48
	public void c(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060074F5 RID: 29941 RVA: 0x00319954 File Offset: 0x00317B54
	public int c()
	{
		return this.d;
	}

	// Token: 0x060074F6 RID: 29942 RVA: 0x0031995C File Offset: 0x00317B5C
	public void a(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060074F7 RID: 29943 RVA: 0x00319968 File Offset: 0x00317B68
	public double f()
	{
		return this.e;
	}

	// Token: 0x060074F8 RID: 29944 RVA: 0x00319970 File Offset: 0x00317B70
	public void a(double A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060074F9 RID: 29945 RVA: 0x0031997C File Offset: 0x00317B7C
	public bool b()
	{
		return this.f;
	}

	// Token: 0x060074FA RID: 29946 RVA: 0x00319984 File Offset: 0x00317B84
	public void a(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060074FB RID: 29947 RVA: 0x00319990 File Offset: 0x00317B90
	public ddg(alv A_0)
	{
		this.a = new EntityAspectReference<alv, alv>(A_0);
	}

	// Token: 0x060074FC RID: 29948 RVA: 0x003199C4 File Offset: 0x00317BC4
	public ddg(EntityAspectReference<alv, alv> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060074FD RID: 29949 RVA: 0x003199F4 File Offset: 0x00317BF4
	protected override dc4 dt()
	{
		if (this.g() == null)
		{
			return dc4.e;
		}
		if (this.c == 0)
		{
			return dc4.c;
		}
		foreach (cd0 cd in this.g().a)
		{
			if (cd != null)
			{
				cd.b = new Point(this.b, cd.b.Y);
			}
		}
		this.g = 0.0;
		this.h = 0;
		return dc4.b;
	}

	// Token: 0x060074FE RID: 29950 RVA: 0x00319AA0 File Offset: 0x00317CA0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.g() == null)
		{
			return dc4.e;
		}
		if ((this.g += A_1.TotalMilliseconds) >= this.e)
		{
			if (this.h >= this.c)
			{
				return dc4.c;
			}
			this.a();
			this.g = 0.0;
			if (this.f && this.h >= this.c)
			{
				return dc4.c;
			}
		}
		return dc4.b;
	}

	// Token: 0x060074FF RID: 29951 RVA: 0x00319B24 File Offset: 0x00317D24
	private void a()
	{
		if (this.g() != null)
		{
			foreach (cd0 cd in this.g().a)
			{
				if (cd != null)
				{
					cd.b = new Point(cd.b.X + this.d, cd.b.Y);
				}
			}
		}
		this.h++;
	}

	// Token: 0x04002FE5 RID: 12261
	private new EntityAspectReference<alv, alv> a;

	// Token: 0x04002FE6 RID: 12262
	private int b;

	// Token: 0x04002FE7 RID: 12263
	private int c = 3;

	// Token: 0x04002FE8 RID: 12264
	private int d = 1;

	// Token: 0x04002FE9 RID: 12265
	private double e = 100.0;

	// Token: 0x04002FEA RID: 12266
	private bool f;

	// Token: 0x04002FEB RID: 12267
	private double g;

	// Token: 0x04002FEC RID: 12268
	private int h;
}
