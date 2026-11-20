using System;
using System.Runtime.Serialization;

// Token: 0x020019FF RID: 6655
[eiz("MCDPE")]
[Serializable]
public sealed class c35 : d91, d7s, ISerializable
{
	// Token: 0x06008F95 RID: 36757 RVA: 0x00398200 File Offset: 0x00396400
	private c35(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("MCDPE:C");
	}

	// Token: 0x06008F96 RID: 36758 RVA: 0x0039821C File Offset: 0x0039641C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MCDPE:C", this.a);
	}

	// Token: 0x06008F97 RID: 36759 RVA: 0x00398238 File Offset: 0x00396438
	public string a()
	{
		return this.a;
	}

	// Token: 0x06008F98 RID: 36760 RVA: 0x00398240 File Offset: 0x00396440
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008F99 RID: 36761 RVA: 0x0039824C File Offset: 0x0039644C
	public c35()
	{
	}

	// Token: 0x06008F9A RID: 36762 RVA: 0x00398254 File Offset: 0x00396454
	public c35(string A_0, double A_1) : base(A_1)
	{
		this.a = A_0;
	}

	// Token: 0x06008F9B RID: 36763 RVA: 0x00398268 File Offset: 0x00396468
	protected override void @in(ll A_0)
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			eax eax;
			A_0.a().Offense.@as().TryGetValue(this.a.ToLowerInvariant(), out eax);
			if (eax == null)
			{
				eax = new eax();
				A_0.a().Offense.@as()[this.a.ToLowerInvariant()] = eax;
			}
			if (eax.b == null)
			{
				eax.b = new double?((double)1);
			}
			eax.b += base.b();
		}
	}

	// Token: 0x06008F9C RID: 36764 RVA: 0x00398330 File Offset: 0x00396530
	public void cn(d3e A_0)
	{
		c35 c = A_0 as c35;
		if (c != null)
		{
			base.a(base.b() + c.b());
		}
	}

	// Token: 0x06008F9D RID: 36765 RVA: 0x00398360 File Offset: 0x00396560
	public bool co(d3e A_0)
	{
		c35 c = A_0 as c35;
		return c != null && c.a == this.a;
	}

	// Token: 0x06008F9E RID: 36766 RVA: 0x00398390 File Offset: 0x00396590
	public override string b2()
	{
		c3n c3n = null;
		if (!string.IsNullOrEmpty(this.a))
		{
			c3n = dgk.a(this.a);
		}
		string text = ((c3n != null) ? c3n.Name : null) ?? "Неизвестная способность";
		string text2 = qv.b("AbilityNames/" + text);
		if (!string.IsNullOrEmpty(text2))
		{
			text = text2;
		}
		if (base.b() < 0.0)
		{
			return qv.a("StaticEffects/ModifyCapabilityDamagePercentage_Decreased", new object[]
			{
				text,
				(int)Math.Abs(base.b() * 100.0)
			});
		}
		return qv.a("StaticEffects/ModifyCapabilityDamagePercentage_Increased", new object[]
		{
			text,
			(int)(base.b() * 100.0)
		});
	}

	// Token: 0x06008F9F RID: 36767 RVA: 0x0039846C File Offset: 0x0039666C
	public override d3e b3()
	{
		c35 c = new c35();
		this.xx(c);
		return c;
	}

	// Token: 0x06008FA0 RID: 36768 RVA: 0x00398488 File Offset: 0x00396688
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((c35)A_0).a = this.a;
	}

	// Token: 0x040037F9 RID: 14329
	private new string a;
}
