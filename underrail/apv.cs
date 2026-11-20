using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020004E0 RID: 1248
[eiz("MPMSC")]
[Serializable]
public sealed class apv : dnh, ISerializable
{
	// Token: 0x06002024 RID: 8228 RVA: 0x000AF090 File Offset: 0x000AD290
	private apv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("MPMSC:MV");
		if (ell.a() >= 483)
		{
			this.b = (SkillEnum)A_0.GetValue("MPMSC:SN", typeof(SkillEnum));
			return;
		}
		string text = A_0.GetString("MPMSC:SN");
		if (text != null)
		{
			text = text.Replace(" ", "");
		}
		Enum.TryParse<SkillEnum>(text, true, out this.b);
	}

	// Token: 0x06002025 RID: 8229 RVA: 0x000AF118 File Offset: 0x000AD318
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MPMSC:MV", this.a);
		info.AddValue("MPMSC:SN", this.b);
	}

	// Token: 0x06002026 RID: 8230 RVA: 0x000AF14C File Offset: 0x000AD34C
	public int b()
	{
		return this.a;
	}

	// Token: 0x06002027 RID: 8231 RVA: 0x000AF154 File Offset: 0x000AD354
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002028 RID: 8232 RVA: 0x000AF160 File Offset: 0x000AD360
	public SkillEnum a()
	{
		return this.b;
	}

	// Token: 0x06002029 RID: 8233 RVA: 0x000AF168 File Offset: 0x000AD368
	public void a(SkillEnum A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600202A RID: 8234 RVA: 0x000AF174 File Offset: 0x000AD374
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			csn csn = serviceOrThrow.aqu().v().Skills.b(this.b.ToString().a());
			return csn != null && csn.g() >= this.a;
		}
		return false;
	}

	// Token: 0x0600202B RID: 8235 RVA: 0x000AF1EC File Offset: 0x000AD3EC
	public override string ToString()
	{
		return string.Format("{0} >= {1}", this.b, this.a);
	}

	// Token: 0x0600202C RID: 8236 RVA: 0x000AF210 File Offset: 0x000AD410
	public apv()
	{
	}

	// Token: 0x04001400 RID: 5120
	private int a;

	// Token: 0x04001401 RID: 5121
	private SkillEnum b;
}
