using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020004E2 RID: 1250
[eiz("MPUSC")]
[Serializable]
public sealed class cgp : dnh, ISerializable
{
	// Token: 0x06002035 RID: 8245 RVA: 0x000AF348 File Offset: 0x000AD548
	private cgp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			this.a = A_0.GetInt32("_MinValue");
			string text = A_0.GetString("_SkillName");
			if (text != null)
			{
				text = text.Replace(" ", "");
			}
			Enum.TryParse<SkillEnum>(text, true, out this.b);
			return;
		}
		this.a = A_0.GetInt32("MPUSC:MV");
		if (ell.a() >= 483)
		{
			this.b = (SkillEnum)A_0.GetValue("MPUSC:SN", typeof(SkillEnum));
			return;
		}
		string text2 = A_0.GetString("MPUSC:SN");
		if (text2 != null)
		{
			text2 = text2.Replace(" ", "");
		}
		Enum.TryParse<SkillEnum>(text2, true, out this.b);
	}

	// Token: 0x06002036 RID: 8246 RVA: 0x000AF41C File Offset: 0x000AD61C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MPUSC:MV", this.a);
		info.AddValue("MPUSC:SN", this.b);
	}

	// Token: 0x06002037 RID: 8247 RVA: 0x000AF450 File Offset: 0x000AD650
	public int b()
	{
		return this.a;
	}

	// Token: 0x06002038 RID: 8248 RVA: 0x000AF458 File Offset: 0x000AD658
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002039 RID: 8249 RVA: 0x000AF464 File Offset: 0x000AD664
	public SkillEnum a()
	{
		return this.b;
	}

	// Token: 0x0600203A RID: 8250 RVA: 0x000AF46C File Offset: 0x000AD66C
	public void a(SkillEnum A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600203B RID: 8251 RVA: 0x000AF478 File Offset: 0x000AD678
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			csn csn = serviceOrThrow.aqu().v().Skills.b(this.b.ToString().a());
			return csn != null && csn.f() >= this.a;
		}
		return false;
	}

	// Token: 0x0600203C RID: 8252 RVA: 0x000AF4F0 File Offset: 0x000AD6F0
	public cgp()
	{
	}

	// Token: 0x04001404 RID: 5124
	private int a;

	// Token: 0x04001405 RID: 5125
	private SkillEnum b;
}
