using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x02001452 RID: 5202
[eiz("SELTA")]
[Serializable]
public sealed class dqm : b1z, ISerializable
{
	// Token: 0x06007500 RID: 29952 RVA: 0x00319BC4 File Offset: 0x00317DC4
	private dqm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (EntityAspectReference<cd0, cd0>)A_0.GetValue("SELTA:SER", typeof(EntityAspectReference<cd0, cd0>));
			this.b = A_0.GetInt32("SELTA:SF");
			this.c = A_0.GetInt32("SELTA:TS");
			this.d = A_0.GetInt32("SELTA:SC");
			this.e = A_0.GetDouble("SELTA:ST");
			this.f = A_0.GetBoolean("SELTA:SLD");
			this.g = A_0.GetDouble("SELTA:TC");
			this.h = A_0.GetInt32("SELTA:DS");
			return;
		}
		if (base.GetType() == typeof(dqm))
		{
			this.a = (EntityAspectReference<cd0, cd0>)A_0.GetValue("_SimpleEntityRef", typeof(EntityAspectReference<cd0, cd0>));
			this.b = A_0.GetInt32("_StartFrame");
			this.c = A_0.GetInt32("_TotalSteps");
			this.d = A_0.GetInt32("_StepChange");
			this.e = A_0.GetDouble("_StepTime");
			this.f = A_0.GetBoolean("_SkipLastDelay");
			this.g = A_0.GetDouble("_TimeCache");
			this.h = A_0.GetInt32("_DoneSteps");
			return;
		}
		this.a = (EntityAspectReference<cd0, cd0>)A_0.GetValue("SimpleEntityLinearTransitionAction+_SimpleEntityRef", typeof(EntityAspectReference<cd0, cd0>));
		this.b = A_0.GetInt32("SimpleEntityLinearTransitionAction+_StartFrame");
		this.c = A_0.GetInt32("SimpleEntityLinearTransitionAction+_TotalSteps");
		this.d = A_0.GetInt32("SimpleEntityLinearTransitionAction+_StepChange");
		this.e = A_0.GetDouble("SimpleEntityLinearTransitionAction+_StepTime");
		this.f = A_0.GetBoolean("SimpleEntityLinearTransitionAction+_SkipLastDelay");
		this.g = A_0.GetDouble("SimpleEntityLinearTransitionAction+_TimeCache");
		this.h = A_0.GetInt32("SimpleEntityLinearTransitionAction+_DoneSteps");
	}

	// Token: 0x06007501 RID: 29953 RVA: 0x00319DE4 File Offset: 0x00317FE4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SELTA:SER", this.a);
		info.AddValue("SELTA:SF", this.b);
		info.AddValue("SELTA:TS", this.c);
		info.AddValue("SELTA:SC", this.d);
		info.AddValue("SELTA:ST", this.e);
		info.AddValue("SELTA:SLD", this.f);
		info.AddValue("SELTA:TC", this.g);
		info.AddValue("SELTA:DS", this.h);
	}

	// Token: 0x06007502 RID: 29954 RVA: 0x00319E84 File Offset: 0x00318084
	public cd0 b()
	{
		if (this.a != null)
		{
			return this.a.ao();
		}
		return null;
	}

	// Token: 0x06007503 RID: 29955 RVA: 0x00319EA0 File Offset: 0x003180A0
	public int e()
	{
		return this.b;
	}

	// Token: 0x06007504 RID: 29956 RVA: 0x00319EA8 File Offset: 0x003180A8
	public void b(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06007505 RID: 29957 RVA: 0x00319EB4 File Offset: 0x003180B4
	public int f()
	{
		return this.c;
	}

	// Token: 0x06007506 RID: 29958 RVA: 0x00319EBC File Offset: 0x003180BC
	public void c(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06007507 RID: 29959 RVA: 0x00319EC8 File Offset: 0x003180C8
	public int d()
	{
		return this.d;
	}

	// Token: 0x06007508 RID: 29960 RVA: 0x00319ED0 File Offset: 0x003180D0
	public void a(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06007509 RID: 29961 RVA: 0x00319EDC File Offset: 0x003180DC
	public double g()
	{
		return this.e;
	}

	// Token: 0x0600750A RID: 29962 RVA: 0x00319EE4 File Offset: 0x003180E4
	public void a(double A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600750B RID: 29963 RVA: 0x00319EF0 File Offset: 0x003180F0
	public bool c()
	{
		return this.f;
	}

	// Token: 0x0600750C RID: 29964 RVA: 0x00319EF8 File Offset: 0x003180F8
	public void a(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600750D RID: 29965 RVA: 0x00319F04 File Offset: 0x00318104
	public dqm(cd0 A_0)
	{
		this.a = new EntityAspectReference<cd0, cd0>(A_0);
	}

	// Token: 0x0600750E RID: 29966 RVA: 0x00319F38 File Offset: 0x00318138
	public dqm(EntityAspectReference<cd0, cd0> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600750F RID: 29967 RVA: 0x00319F68 File Offset: 0x00318168
	protected override dc4 dt()
	{
		if (this.b() == null)
		{
			return dc4.e;
		}
		if (this.c <= 0)
		{
			return dc4.c;
		}
		this.b().b = new Point(this.b, this.b().b.Y);
		this.g = 0.0;
		this.h = 0;
		return dc4.b;
	}

	// Token: 0x06007510 RID: 29968 RVA: 0x00319FD0 File Offset: 0x003181D0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.b() == null)
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

	// Token: 0x06007511 RID: 29969 RVA: 0x0031A054 File Offset: 0x00318254
	private void a()
	{
		if (this.b() != null)
		{
			this.b().b = new Point(this.b().b.X + this.d, this.b().b.Y);
		}
		this.h++;
	}

	// Token: 0x04002FED RID: 12269
	private new EntityAspectReference<cd0, cd0> a;

	// Token: 0x04002FEE RID: 12270
	private int b;

	// Token: 0x04002FEF RID: 12271
	private int c = 3;

	// Token: 0x04002FF0 RID: 12272
	private int d = 1;

	// Token: 0x04002FF1 RID: 12273
	private double e = 100.0;

	// Token: 0x04002FF2 RID: 12274
	private bool f;

	// Token: 0x04002FF3 RID: 12275
	private double g;

	// Token: 0x04002FF4 RID: 12276
	private int h;
}
