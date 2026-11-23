using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001A18 RID: 6680
[eiz("MCFE")]
[Serializable]
public sealed class eox : dts, ISerializable
{
	// Token: 0x0600907E RID: 36990 RVA: 0x0039A840 File Offset: 0x00398A40
	private eox(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (CooldownCategory)A_0.GetValue("MCFE:C", typeof(CooldownCategory));
	}

	// Token: 0x0600907F RID: 36991 RVA: 0x0039A86C File Offset: 0x00398A6C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MCFE:C", this.a);
	}

	// Token: 0x06009080 RID: 36992 RVA: 0x0039A88C File Offset: 0x00398A8C
	public CooldownCategory a()
	{
		return this.a;
	}

	// Token: 0x06009081 RID: 36993 RVA: 0x0039A894 File Offset: 0x00398A94
	public void a(CooldownCategory A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009082 RID: 36994 RVA: 0x0039A8A0 File Offset: 0x00398AA0
	public override bool ae5()
	{
		return base.c() > 0;
	}

	// Token: 0x06009083 RID: 36995 RVA: 0x0039A8AC File Offset: 0x00398AAC
	public eox()
	{
	}

	// Token: 0x06009084 RID: 36996 RVA: 0x0039A8B4 File Offset: 0x00398AB4
	public eox(CooldownCategory A_0, int A_1) : base(A_1)
	{
		this.a = A_0;
	}

	// Token: 0x06009085 RID: 36997 RVA: 0x0039A8C8 File Offset: 0x00398AC8
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		Dictionary<CooldownCategory, int> dictionary = A_0.a().CooldownModifiersFlat;
		CooldownCategory key = this.a;
		dictionary[key] += base.c();
	}

	// Token: 0x06009086 RID: 36998 RVA: 0x0039A908 File Offset: 0x00398B08
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((eox)A_0).a = this.a;
	}

	// Token: 0x06009087 RID: 36999 RVA: 0x0039A924 File Offset: 0x00398B24
	public override string b2()
	{
		string text = dh9.c("CooldownCategory_DisplayText_" + this.a.ToString());
		if (string.IsNullOrEmpty(text) && !uf.a.TryGetValue(this.a, out text))
		{
			text = "неизвестная способность";
		}
		if (base.c() < 0)
		{
			return qv.a("StaticEffects/ModifyCooldownFlat_Decreased", new object[]
			{
				text,
				l4.a(Math.Abs(base.c()), false)
			});
		}
		return qv.a("StaticEffects/ModifyCooldownFlat_Increased", new object[]
		{
			text,
			l4.a(base.c(), false)
		});
	}

	// Token: 0x06009088 RID: 37000 RVA: 0x0039A9D4 File Offset: 0x00398BD4
	public override d3e b3()
	{
		eox eox = new eox();
		this.xx(eox);
		return eox;
	}

	// Token: 0x04003810 RID: 14352
	private new CooldownCategory a;
}
