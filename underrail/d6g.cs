using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001A17 RID: 6679
[eiz("MCPE")]
[Serializable]
public sealed class d6g : d91, ISerializable
{
	// Token: 0x06009073 RID: 36979 RVA: 0x0039A66C File Offset: 0x0039886C
	private d6g(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (CooldownCategory)A_0.GetValue("MCPE:C", typeof(CooldownCategory));
	}

	// Token: 0x06009074 RID: 36980 RVA: 0x0039A698 File Offset: 0x00398898
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MCPE:C", this.a);
	}

	// Token: 0x06009075 RID: 36981 RVA: 0x0039A6B8 File Offset: 0x003988B8
	public CooldownCategory a()
	{
		return this.a;
	}

	// Token: 0x06009076 RID: 36982 RVA: 0x0039A6C0 File Offset: 0x003988C0
	public void a(CooldownCategory A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009077 RID: 36983 RVA: 0x0039A6CC File Offset: 0x003988CC
	public override bool ae5()
	{
		return base.b() > 0.0;
	}

	// Token: 0x06009078 RID: 36984 RVA: 0x0039A6E0 File Offset: 0x003988E0
	public d6g()
	{
	}

	// Token: 0x06009079 RID: 36985 RVA: 0x0039A6E8 File Offset: 0x003988E8
	public d6g(CooldownCategory A_0, int A_1) : base((double)A_1)
	{
		this.a = A_0;
	}

	// Token: 0x0600907A RID: 36986 RVA: 0x0039A6FC File Offset: 0x003988FC
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		Dictionary<CooldownCategory, double> dictionary = A_0.a().CooldownModifiersPercentage;
		CooldownCategory key = this.a;
		dictionary[key] += base.b();
	}

	// Token: 0x0600907B RID: 36987 RVA: 0x0039A73C File Offset: 0x0039893C
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((d6g)A_0).a = this.a;
	}

	// Token: 0x0600907C RID: 36988 RVA: 0x0039A758 File Offset: 0x00398958
	public override string b2()
	{
		string text = dh9.c("CooldownCategory_DisplayText_" + this.a.ToString());
		if (string.IsNullOrEmpty(text) && !uf.a.TryGetValue(this.a, out text))
		{
			text = "неизвестная способность";
		}
		if (base.b() < 0.0)
		{
			return qv.a("StaticEffects/ModifyCooldownPercentage_Decreased", new object[]
			{
				text,
				(int)Math.Abs(base.b() * 100.0)
			});
		}
		return qv.a("StaticEffects/ModifyCooldownPercentage_Increased", new object[]
		{
			text,
			(int)(base.b() * 100.0)
		});
	}

	// Token: 0x0600907D RID: 36989 RVA: 0x0039A824 File Offset: 0x00398A24
	public override d3e b3()
	{
		d6g d6g = new d6g();
		this.xx(d6g);
		return d6g;
	}

	// Token: 0x0400380F RID: 14351
	private new CooldownCategory a;
}
