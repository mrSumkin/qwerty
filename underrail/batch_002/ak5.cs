using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020019E4 RID: 6628
[eiz("MSVE")]
[Serializable]
public sealed class ak5 : d3e, d7s, ISerializable
{
	// Token: 0x06008E74 RID: 36468 RVA: 0x00395574 File Offset: 0x00393774
	private ak5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("MSVE:M");
		this.b = (A_0.GetValue("MSVE:S", typeof(ImpactSpeed?)) as ImpactSpeed?);
	}

	// Token: 0x06008E75 RID: 36469 RVA: 0x003955C0 File Offset: 0x003937C0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MSVE:M", this.a);
		info.AddValue("MSVE:S", this.b);
	}

	// Token: 0x06008E76 RID: 36470 RVA: 0x003955F4 File Offset: 0x003937F4
	public override bool ae5()
	{
		return this.a < 0.0;
	}

	// Token: 0x06008E77 RID: 36471 RVA: 0x00395608 File Offset: 0x00393808
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008E78 RID: 36472 RVA: 0x00395610 File Offset: 0x00393810
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008E79 RID: 36473 RVA: 0x0039561C File Offset: 0x0039381C
	public ImpactSpeed? b()
	{
		return this.b;
	}

	// Token: 0x06008E7A RID: 36474 RVA: 0x00395624 File Offset: 0x00393824
	public void a(ImpactSpeed? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008E7B RID: 36475 RVA: 0x00395630 File Offset: 0x00393830
	public ak5()
	{
	}

	// Token: 0x06008E7C RID: 36476 RVA: 0x00395638 File Offset: 0x00393838
	public ak5(ImpactSpeed? A_0, double A_1)
	{
		this.b = A_0;
		this.a = A_1;
	}

	// Token: 0x06008E7D RID: 36477 RVA: 0x00395650 File Offset: 0x00393850
	protected override void @in(ll A_0)
	{
		if (A_0 != null && A_0.a() != null && A_0.a().Defense.z != null)
		{
			for (int i = 0; i < A_0.a().Defense.z.Count; i++)
			{
				z3 value = A_0.a().Defense.z[i];
				if (this.b == null || value.ImpactSpeed == this.b.Value)
				{
					value.Value = Convert.ToInt32((double)value.Value * (1.0 + Math.Max(-1.0, this.a)));
					A_0.a().Defense.z[i] = value;
				}
			}
		}
	}

	// Token: 0x06008E7E RID: 36478 RVA: 0x00395734 File Offset: 0x00393934
	public void cn(d3e A_0)
	{
		ak5 ak = A_0 as ak5;
		if (ak != null)
		{
			this.a = Math.Max(-1.0, this.a + ak.a);
		}
	}

	// Token: 0x06008E7F RID: 36479 RVA: 0x00395770 File Offset: 0x00393970
	public bool co(d3e A_0)
	{
		ak5 ak = A_0 as ak5;
		if (ak != null)
		{
			ImpactSpeed? impactSpeed = ak.b;
			ImpactSpeed? impactSpeed2 = this.b;
			return impactSpeed.GetValueOrDefault() == impactSpeed2.GetValueOrDefault() & impactSpeed != null == (impactSpeed2 != null);
		}
		return false;
	}

	// Token: 0x06008E80 RID: 36480 RVA: 0x003957BC File Offset: 0x003939BC
	public override string b2()
	{
		string text;
		if (this.b == null)
		{
			text = qv.b("StaticEffects/ModifyShieldingValue_AllEnergyShieldingValues") + " ";
		}
		else
		{
			text = qv.a("StaticEffects/ModifyShieldingValue_SpecificEnergyShieldingValue", new object[]
			{
				ak5.a(this.b.Value)
			}) + " ";
		}
		if (this.a < 0.0)
		{
			text += qv.a("StaticEffects/ModifyShieldingValue_Decreased", new object[]
			{
				(int)Math.Abs(this.a * 100.0)
			});
		}
		else
		{
			text += qv.a("StaticEffects/ModifyShieldingValue_Increased", new object[]
			{
				(int)Math.Abs(this.a * 100.0)
			});
		}
		return text;
	}

	// Token: 0x06008E81 RID: 36481 RVA: 0x003958A8 File Offset: 0x00393AA8
	private static string a(ImpactSpeed A_0)
	{
		string text = dh9.a(A_0);
		return text[0].ToString() + text.Substring(1, text.Length - 1).ToLowerInvariant();
	}

	// Token: 0x06008E82 RID: 36482 RVA: 0x003958EC File Offset: 0x00393AEC
	public override d3e b3()
	{
		ak5 ak = new ak5();
		this.xx(ak);
		return ak;
	}

	// Token: 0x06008E83 RID: 36483 RVA: 0x00395908 File Offset: 0x00393B08
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		ak5 ak = (ak5)A_0;
		ak.b = this.b;
		ak.a = this.a;
	}

	// Token: 0x040037D7 RID: 14295
	private new double a;

	// Token: 0x040037D8 RID: 14296
	private ImpactSpeed? b;
}
