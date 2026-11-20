using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001A5A RID: 6746
[eiz("MBAFE")]
[Serializable]
public sealed class ax6 : dts, bdr, ISerializable
{
	// Token: 0x06009270 RID: 37488 RVA: 0x0039F770 File Offset: 0x0039D970
	private ax6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("MBAFE:BAN");
			return;
		}
		if (base.GetType() == typeof(ax6))
		{
			this.a = A_0.GetString("_BaseAbilityName");
			return;
		}
		this.a = A_0.GetString("ModifyBaseAbilityFlatEffect+_BaseAbilityName");
	}

	// Token: 0x06009271 RID: 37489 RVA: 0x0039F7E0 File Offset: 0x0039D9E0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MBAFE:BAN", this.a);
	}

	// Token: 0x1700026A RID: 618
	// (get) Token: 0x06009272 RID: 37490 RVA: 0x0039F7FC File Offset: 0x0039D9FC
	// (set) Token: 0x06009273 RID: 37491 RVA: 0x0039F804 File Offset: 0x0039DA04
	[XmlAttribute]
	public string BaseAbilityName
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

	// Token: 0x06009274 RID: 37492 RVA: 0x0039F810 File Offset: 0x0039DA10
	public ax6()
	{
	}

	// Token: 0x06009275 RID: 37493 RVA: 0x0039F818 File Offset: 0x0039DA18
	public ax6(string A_0, int A_1) : base(A_1)
	{
		this.a = A_0;
	}

	// Token: 0x06009276 RID: 37494 RVA: 0x0039F82C File Offset: 0x0039DA2C
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		if (!string.IsNullOrWhiteSpace(this.a) && A_0.a() != null)
		{
			to to = A_0.a().BaseAbilities.a(this.a);
			if (to != null)
			{
				to to2 = to;
				to2.b(to2.g() + base.c());
			}
		}
	}

	// Token: 0x06009277 RID: 37495 RVA: 0x0039F890 File Offset: 0x0039DA90
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((ax6)A_0).a = this.a;
	}

	// Token: 0x06009278 RID: 37496 RVA: 0x0039F8B0 File Offset: 0x0039DAB0
	public override d3e b3()
	{
		ax6 ax = new ax6();
		this.xx(ax);
		return ax;
	}

	// Token: 0x06009279 RID: 37497 RVA: 0x0039F8CC File Offset: 0x0039DACC
	public override string b2()
	{
		string text = dh9.a(typeof(BaseAbilityEnum).Name, this.a);
		if (base.c() < 0)
		{
			return qv.a("StaticEffects/ModifyBaseAbilityFlat_Decreased", new object[]
			{
				text,
				Math.Abs(base.c())
			});
		}
		return qv.a("StaticEffects/ModifyBaseAbilityFlat_Increased", new object[]
		{
			text,
			base.c()
		});
	}

	// Token: 0x04003854 RID: 14420
	private new string a;
}
