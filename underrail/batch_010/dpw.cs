using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

// Token: 0x02001A4E RID: 6734
[eiz("MSFE1")]
[Serializable]
public sealed class dpw : dts, d7s, em0, ISerializable
{
	// Token: 0x0600921D RID: 37405 RVA: 0x0039E90C File Offset: 0x0039CB0C
	private dpw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("MSFE1:SN");
			return;
		}
		if (base.GetType() == typeof(dpw))
		{
			this.a = A_0.GetString("_SkillName");
			return;
		}
		this.a = A_0.GetString("ModifySkillFlatEffect+_SkillName");
	}

	// Token: 0x0600921E RID: 37406 RVA: 0x0039E97C File Offset: 0x0039CB7C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MSFE1:SN", this.a);
	}

	// Token: 0x17000264 RID: 612
	// (get) Token: 0x0600921F RID: 37407 RVA: 0x0039E998 File Offset: 0x0039CB98
	// (set) Token: 0x06009220 RID: 37408 RVA: 0x0039E9A0 File Offset: 0x0039CBA0
	[XmlAttribute]
	public string SkillName
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x06009221 RID: 37409 RVA: 0x0039E9AC File Offset: 0x0039CBAC
	public dpw()
	{
	}

	// Token: 0x06009222 RID: 37410 RVA: 0x0039E9B4 File Offset: 0x0039CBB4
	public dpw(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009223 RID: 37411 RVA: 0x0039E9C4 File Offset: 0x0039CBC4
	public dpw(string A_0, int A_1) : base(A_1)
	{
		this.a = A_0;
	}

	// Token: 0x06009224 RID: 37412 RVA: 0x0039E9D8 File Offset: 0x0039CBD8
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		if (A_0.a() != null && !string.IsNullOrEmpty(this.a))
		{
			csn csn = A_0.a().Skills.a(this.a);
			if (csn != null)
			{
				csn csn2 = csn;
				csn2.b(csn2.g() + base.c());
				csn.a();
			}
		}
	}

	// Token: 0x06009225 RID: 37413 RVA: 0x0039EA44 File Offset: 0x0039CC44
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((dpw)A_0).a = this.a;
	}

	// Token: 0x06009226 RID: 37414 RVA: 0x0039EA60 File Offset: 0x0039CC60
	public void cn(d3e A_0)
	{
		dpw dpw = A_0 as dpw;
		if (dpw != null)
		{
			base.a(base.c() + dpw.c());
		}
	}

	// Token: 0x06009227 RID: 37415 RVA: 0x0039EA90 File Offset: 0x0039CC90
	public bool co(d3e A_0)
	{
		dpw dpw = A_0 as dpw;
		return dpw != null && dpw.a == this.a;
	}

	// Token: 0x06009228 RID: 37416 RVA: 0x0039EAC0 File Offset: 0x0039CCC0
	public override string b2()
	{
		if (this.a == null)
		{
			return "";
		}
		string text = dh9.a("SkillEnum." + this.a);
		if (string.IsNullOrEmpty(text))
		{
			text = this.a;
		}
		if (base.c() < 0)
		{
			return qv.a("StaticEffects/ModifySkillFlat_Decreased", new object[]
			{
				text,
				Math.Abs(base.c())
			});
		}
		return qv.a("StaticEffects/ModifySkillFlat_Increased", new object[]
		{
			text,
			base.c()
		});
	}

	// Token: 0x06009229 RID: 37417 RVA: 0x0039EB5C File Offset: 0x0039CD5C
	public override d3e b3()
	{
		dpw dpw = new dpw();
		this.xx(dpw);
		return dpw;
	}

	// Token: 0x04003846 RID: 14406
	private new string a;
}
