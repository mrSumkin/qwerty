using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020004CD RID: 1229
[eiz("MAXPUSC")]
[Serializable]
public sealed class um : dnh, ISerializable
{
	// Token: 0x06001F80 RID: 8064 RVA: 0x000AD808 File Offset: 0x000ABA08
	private um(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("MAXPUSC:MV");
		if (ell.a() >= 483)
		{
			this.b = (SkillEnum)A_0.GetValue("MAXPUSC:SN", typeof(SkillEnum));
			return;
		}
		string text = A_0.GetString("MAXPUSC:SN");
		if (text != null)
		{
			text = text.Replace(" ", "");
		}
		Enum.TryParse<SkillEnum>(text, true, out this.b);
	}

	// Token: 0x06001F81 RID: 8065 RVA: 0x000AD890 File Offset: 0x000ABA90
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MAXPUSC:MV", this.a);
		info.AddValue("MAXPUSC:SN", this.b);
	}

	// Token: 0x06001F82 RID: 8066 RVA: 0x000AD8C4 File Offset: 0x000ABAC4
	public int a()
	{
		return this.a;
	}

	// Token: 0x06001F83 RID: 8067 RVA: 0x000AD8CC File Offset: 0x000ABACC
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001F84 RID: 8068 RVA: 0x000AD8D8 File Offset: 0x000ABAD8
	public SkillEnum b()
	{
		return this.b;
	}

	// Token: 0x06001F85 RID: 8069 RVA: 0x000AD8E0 File Offset: 0x000ABAE0
	public void a(SkillEnum A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001F86 RID: 8070 RVA: 0x000AD8EC File Offset: 0x000ABAEC
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			csn csn = serviceOrThrow.aqu().v().Skills.b(this.b.ToString().a());
			return csn != null && csn.f() <= this.a;
		}
		return false;
	}

	// Token: 0x06001F87 RID: 8071 RVA: 0x000AD964 File Offset: 0x000ABB64
	public um()
	{
	}

	// Token: 0x040013D3 RID: 5075
	private int a;

	// Token: 0x040013D4 RID: 5076
	private SkillEnum b;
}
