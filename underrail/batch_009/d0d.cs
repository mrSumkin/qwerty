using System;
using System.Runtime.Serialization;

// Token: 0x02001A30 RID: 6704
[eiz("MDPE2")]
[Serializable]
public sealed class d0d : dh6, ISerializable
{
	// Token: 0x06009137 RID: 37175 RVA: 0x0039C6F0 File Offset: 0x0039A8F0
	private d0d(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009138 RID: 37176 RVA: 0x0039C6FC File Offset: 0x0039A8FC
	public d0d()
	{
	}

	// Token: 0x06009139 RID: 37177 RVA: 0x0039C704 File Offset: 0x0039A904
	public d0d(float A_0) : base(A_0)
	{
	}

	// Token: 0x0600913A RID: 37178 RVA: 0x0039C710 File Offset: 0x0039A910
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		A_0.a().Detection += (int)((float)A_0.a().Detection * base.c());
	}

	// Token: 0x0600913B RID: 37179 RVA: 0x0039C750 File Offset: 0x0039A950
	public override string b2()
	{
		if (base.c() >= 0f)
		{
			return qv.a("StaticEffects/ModifyDetectionPercentage_Increased", new object[]
			{
				base.c() * 100f
			});
		}
		return qv.a("StaticEffects/ModifyDetectionPercentage_Decreased", new object[]
		{
			-base.c() * 100f
		});
	}

	// Token: 0x0600913C RID: 37180 RVA: 0x0039C7B8 File Offset: 0x0039A9B8
	public override d3e b3()
	{
		d0d d0d = new d0d();
		this.xx(d0d);
		return d0d;
	}
}
