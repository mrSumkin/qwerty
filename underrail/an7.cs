using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020004D7 RID: 1239
[eiz("MAXPMSC")]
[Serializable]
public sealed class an7 : dnh, ISerializable
{
	// Token: 0x06001FD6 RID: 8150 RVA: 0x000AE540 File Offset: 0x000AC740
	private an7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
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

	// Token: 0x06001FD7 RID: 8151 RVA: 0x000AE5C8 File Offset: 0x000AC7C8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MPMSC:MV", this.a);
		info.AddValue("MPMSC:SN", this.b);
	}

	// Token: 0x06001FD8 RID: 8152 RVA: 0x000AE5FC File Offset: 0x000AC7FC
	public int a()
	{
		return this.a;
	}

	// Token: 0x06001FD9 RID: 8153 RVA: 0x000AE604 File Offset: 0x000AC804
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001FDA RID: 8154 RVA: 0x000AE610 File Offset: 0x000AC810
	public SkillEnum b()
	{
		return this.b;
	}

	// Token: 0x06001FDB RID: 8155 RVA: 0x000AE618 File Offset: 0x000AC818
	public void a(SkillEnum A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001FDC RID: 8156 RVA: 0x000AE624 File Offset: 0x000AC824
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			csn csn = serviceOrThrow.aqu().v().Skills.b(this.b.ToString().a());
			return csn != null && csn.g() <= this.a;
		}
		return false;
	}

	// Token: 0x06001FDD RID: 8157 RVA: 0x000AE69C File Offset: 0x000AC89C
	public an7()
	{
	}

	// Token: 0x040013EA RID: 5098
	private int a;

	// Token: 0x040013EB RID: 5099
	private SkillEnum b;
}
