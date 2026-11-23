using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001129 RID: 4393
[eiz("SVEACJ")]
[Serializable]
public sealed class e01 : cze, ISerializable
{
	// Token: 0x06005DF3 RID: 24051 RVA: 0x0027D518 File Offset: 0x0027B718
	private e01(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("SVEACJ:EM");
			this.b = A_0.GetBoolean("SVEACJ:ATC");
			this.c = A_0.GetBoolean("SVEACJ:C");
			this.d = A_0.GetInt32("SVEACJ:MC");
			this.e = A_0.GetDouble("SVEACJ:MD");
			if (ell.a() >= 251)
			{
				this.f = (A_0.GetValue("SVEACJ:O", typeof(Vector3?)) as Vector3?);
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(e01))
			{
				this.a = A_0.GetString("_EffectModel");
				this.b = A_0.GetBoolean("_AttachToCarrier");
				this.c = A_0.GetBoolean("_Center");
				this.d = A_0.GetInt32("_MaxCycles");
				this.e = A_0.GetDouble("_MaxDuration");
				return;
			}
			this.a = A_0.GetString("SpawnVisualEffectAtCarrierJob+_EffectModel");
			this.b = A_0.GetBoolean("SpawnVisualEffectAtCarrierJob+_AttachToCarrier");
			this.c = A_0.GetBoolean("SpawnVisualEffectAtCarrierJob+_Center");
			this.d = A_0.GetInt32("SpawnVisualEffectAtCarrierJob+_MaxCycles");
			this.e = A_0.GetDouble("SpawnVisualEffectAtCarrierJob+_MaxDuration");
		}
	}

	// Token: 0x06005DF4 RID: 24052 RVA: 0x0027D6A4 File Offset: 0x0027B8A4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SVEACJ:EM", this.a);
		info.AddValue("SVEACJ:ATC", this.b);
		info.AddValue("SVEACJ:C", this.c);
		info.AddValue("SVEACJ:MC", this.d);
		info.AddValue("SVEACJ:MD", this.e);
		info.AddValue("SVEACJ:O", this.f);
	}

	// Token: 0x06005DF5 RID: 24053 RVA: 0x0027D724 File Offset: 0x0027B924
	public string d()
	{
		return this.a;
	}

	// Token: 0x06005DF6 RID: 24054 RVA: 0x0027D72C File Offset: 0x0027B92C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005DF7 RID: 24055 RVA: 0x0027D738 File Offset: 0x0027B938
	public bool f()
	{
		return this.b;
	}

	// Token: 0x06005DF8 RID: 24056 RVA: 0x0027D740 File Offset: 0x0027B940
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005DF9 RID: 24057 RVA: 0x0027D74C File Offset: 0x0027B94C
	public bool e()
	{
		return this.c;
	}

	// Token: 0x06005DFA RID: 24058 RVA: 0x0027D754 File Offset: 0x0027B954
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005DFB RID: 24059 RVA: 0x0027D760 File Offset: 0x0027B960
	public double a()
	{
		return this.e;
	}

	// Token: 0x06005DFC RID: 24060 RVA: 0x0027D768 File Offset: 0x0027B968
	public void a(double A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005DFD RID: 24061 RVA: 0x0027D774 File Offset: 0x0027B974
	public int b()
	{
		return this.d;
	}

	// Token: 0x06005DFE RID: 24062 RVA: 0x0027D77C File Offset: 0x0027B97C
	public void a(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005DFF RID: 24063 RVA: 0x0027D788 File Offset: 0x0027B988
	public Vector3? c()
	{
		return this.f;
	}

	// Token: 0x06005E00 RID: 24064 RVA: 0x0027D790 File Offset: 0x0027B990
	public void a(Vector3? A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005E01 RID: 24065 RVA: 0x0027D79C File Offset: 0x0027B99C
	public e01()
	{
	}

	// Token: 0x06005E02 RID: 24066 RVA: 0x0027D7C4 File Offset: 0x0027B9C4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x == null && A_0 != null)
		{
			c5x = (A_0 as c5x);
		}
		if (c5x != null)
		{
			c5x a_ = c5x;
			string a_2 = this.a;
			int a_3 = this.d;
			double a_4 = this.e;
			bool a_5 = this.c;
			bool a_6 = this.b;
			Vector3? a_7 = this.f;
			float? a_8 = dz6.b();
			boj.a(a_, a_2, a_3, a_4, a_5, a_6, a_7, null, null, a_8, false);
		}
	}

	// Token: 0x04002561 RID: 9569
	private new string a;

	// Token: 0x04002562 RID: 9570
	private bool b;

	// Token: 0x04002563 RID: 9571
	private bool c = true;

	// Token: 0x04002564 RID: 9572
	private int d = 1;

	// Token: 0x04002565 RID: 9573
	private double e = double.MaxValue;

	// Token: 0x04002566 RID: 9574
	private Vector3? f;
}
