using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020013DB RID: 5083
[eiz("SEACA")]
[Serializable]
public sealed class a7j : dvv, ISerializable
{
	// Token: 0x06007273 RID: 29299 RVA: 0x00301764 File Offset: 0x002FF964
	private a7j(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ar7)A_0.GetValue("SEACA:CR", typeof(ar7));
			this.b = A_0.GetString("SEACA:EM");
			this.c = A_0.GetInt32("SEACA:MC");
			this.d = A_0.GetDouble("SEACA:MD");
			this.e = A_0.GetBoolean("SEACA:C");
			this.f = A_0.GetBoolean("SEACA:ATC");
			this.g = (int?)A_0.GetValue("SEACA:OPS", typeof(int?));
			this.h = (float?)A_0.GetValue("SEACA:OA", typeof(float?));
			this.i = (Vector3?)A_0.GetValue("SEACA:O", typeof(Vector3?));
			if (ell.a() >= 330)
			{
				this.j = (float?)A_0.GetValue("SEACA:P", typeof(float?));
			}
			if (ell.a() >= 421)
			{
				this.k = A_0.GetBoolean("SEACA:T");
			}
			if (ell.a() >= 655)
			{
				this.l = (A_0.GetValue("SEACA:Y", typeof(int?)) as int?);
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(a7j))
			{
				this.a = (ar7)A_0.GetValue("_CarrierRef", typeof(ar7));
				this.b = A_0.GetString("_EffectModel");
				this.c = A_0.GetInt32("_MaxCycles");
				this.d = A_0.GetDouble("_MaxDuration");
				this.e = A_0.GetBoolean("_Center");
				this.f = A_0.GetBoolean("_AttachToCarrier");
				this.g = (int?)A_0.GetValue("_OverridePhaseStep", typeof(int?));
				this.h = (float?)A_0.GetValue("_OverrideAlpha", typeof(float?));
				this.i = (Vector3?)A_0.GetValue("_Offset", typeof(Vector3?));
				return;
			}
			this.a = (ar7)A_0.GetValue("SpawnEffectAtCarrierAction+_CarrierRef", typeof(ar7));
			this.b = A_0.GetString("SpawnEffectAtCarrierAction+_EffectModel");
			this.c = A_0.GetInt32("SpawnEffectAtCarrierAction+_MaxCycles");
			this.d = A_0.GetDouble("SpawnEffectAtCarrierAction+_MaxDuration");
			this.e = A_0.GetBoolean("SpawnEffectAtCarrierAction+_Center");
			this.f = A_0.GetBoolean("SpawnEffectAtCarrierAction+_AttachToCarrier");
			this.g = (int?)A_0.GetValue("SpawnEffectAtCarrierAction+_OverridePhaseStep", typeof(int?));
			this.h = (float?)A_0.GetValue("SpawnEffectAtCarrierAction+_OverrideAlpha", typeof(float?));
			this.i = (Vector3?)A_0.GetValue("SpawnEffectAtCarrierAction+_Offset", typeof(Vector3?));
		}
	}

	// Token: 0x06007274 RID: 29300 RVA: 0x00301AA4 File Offset: 0x002FFCA4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SEACA:CR", this.a);
		info.AddValue("SEACA:EM", this.b);
		info.AddValue("SEACA:MC", this.c);
		info.AddValue("SEACA:MD", this.d);
		info.AddValue("SEACA:C", this.e);
		info.AddValue("SEACA:ATC", this.f);
		info.AddValue("SEACA:OPS", this.g);
		info.AddValue("SEACA:OA", this.h);
		info.AddValue("SEACA:O", this.i);
		info.AddValue("SEACA:P", this.j);
		info.AddValue("SEACA:T", this.k);
		info.AddValue("SEACA:Y", this.l);
	}

	// Token: 0x06007275 RID: 29301 RVA: 0x00301BA0 File Offset: 0x002FFDA0
	private c5x a()
	{
		return this.a.ao() as c5x;
	}

	// Token: 0x06007276 RID: 29302 RVA: 0x00301BB4 File Offset: 0x002FFDB4
	public int? e()
	{
		return this.g;
	}

	// Token: 0x06007277 RID: 29303 RVA: 0x00301BBC File Offset: 0x002FFDBC
	public void a(int? A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06007278 RID: 29304 RVA: 0x00301BC8 File Offset: 0x002FFDC8
	public float? d()
	{
		return this.h;
	}

	// Token: 0x06007279 RID: 29305 RVA: 0x00301BD0 File Offset: 0x002FFDD0
	public void a(float? A_0)
	{
		this.h = A_0;
	}

	// Token: 0x0600727A RID: 29306 RVA: 0x00301BDC File Offset: 0x002FFDDC
	public Vector3? c()
	{
		return this.i;
	}

	// Token: 0x0600727B RID: 29307 RVA: 0x00301BE4 File Offset: 0x002FFDE4
	public void a(Vector3? A_0)
	{
		this.i = A_0;
	}

	// Token: 0x0600727C RID: 29308 RVA: 0x00301BF0 File Offset: 0x002FFDF0
	public bool b()
	{
		return this.k;
	}

	// Token: 0x0600727D RID: 29309 RVA: 0x00301BF8 File Offset: 0x002FFDF8
	public void a(bool A_0)
	{
		this.k = A_0;
	}

	// Token: 0x0600727E RID: 29310 RVA: 0x00301C04 File Offset: 0x002FFE04
	public int? f()
	{
		return this.l;
	}

	// Token: 0x0600727F RID: 29311 RVA: 0x00301C0C File Offset: 0x002FFE0C
	public void b(int? A_0)
	{
		this.l = A_0;
	}

	// Token: 0x06007280 RID: 29312 RVA: 0x00301C18 File Offset: 0x002FFE18
	public a7j(c5x A_0, string A_1, int A_2, double A_3, bool A_4, bool A_5, Vector3? A_6 = null, float? A_7 = null, int? A_8 = null, float? A_9 = null, bool A_10 = false, int? A_11 = null)
	{
		this.a = new ar7(A_0);
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
		this.e = A_4;
		this.f = A_5;
		this.i = A_6;
		this.h = A_7;
		this.g = A_8;
		this.j = A_9;
		this.k = A_10;
		this.l = A_11;
	}

	// Token: 0x06007281 RID: 29313 RVA: 0x00301C90 File Offset: 0x002FFE90
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a() == null)
		{
			return dc4.e;
		}
		c5x c5x = boj.a(this.a(), this.b, this.c, this.d, this.e, this.f, this.i, this.g, this.h, this.j, this.k);
		if (c5x != null)
		{
			if (this.l != null)
			{
				boj.a(c5x, this.l.Value);
			}
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x04002EBB RID: 11963
	private new ar7 a;

	// Token: 0x04002EBC RID: 11964
	private string b;

	// Token: 0x04002EBD RID: 11965
	private int c;

	// Token: 0x04002EBE RID: 11966
	private double d;

	// Token: 0x04002EBF RID: 11967
	private bool e;

	// Token: 0x04002EC0 RID: 11968
	private bool f;

	// Token: 0x04002EC1 RID: 11969
	private int? g;

	// Token: 0x04002EC2 RID: 11970
	private float? h;

	// Token: 0x04002EC3 RID: 11971
	private Vector3? i;

	// Token: 0x04002EC4 RID: 11972
	private new float? j;

	// Token: 0x04002EC5 RID: 11973
	private new bool k;

	// Token: 0x04002EC6 RID: 11974
	private int? l;
}
