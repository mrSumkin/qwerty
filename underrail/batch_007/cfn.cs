using System;
using System.Runtime.Serialization;

// Token: 0x02000C7C RID: 3196
[eiz("SGSHPMBDE")]
[Serializable]
public sealed class cfn : cd2
{
	// Token: 0x0600482B RID: 18475 RVA: 0x001D98F8 File Offset: 0x001D7AF8
	private cfn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600482C RID: 18476 RVA: 0x001D9904 File Offset: 0x001D7B04
	public override TimeSpan ge()
	{
		return TimeSpan.FromMinutes(30.0);
	}

	// Token: 0x0600482D RID: 18477 RVA: 0x001D9914 File Offset: 0x001D7B14
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x0600482E RID: 18478 RVA: 0x001D9924 File Offset: 0x001D7B24
	public cfn() : base(cfn.a)
	{
	}

	// Token: 0x0600482F RID: 18479 RVA: 0x001D9934 File Offset: 0x001D7B34
	protected override void gg(cyt A_0)
	{
		A_0.r()["loc_dun_lup-a_explorer_haroldShouldMessage"] = true;
		new bls().ym(null, null, null);
	}

	// Token: 0x04001CAE RID: 7342
	public new static readonly string a = "sgs_haroldPreparesMinibot";
}
