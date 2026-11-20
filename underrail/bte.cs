using System;
using System.Runtime.Serialization;

// Token: 0x020007B6 RID: 1974
[eiz("DCAMR")]
[Serializable]
public sealed class bte : esc, ISerializable
{
	// Token: 0x06003171 RID: 12657 RVA: 0x0012F300 File Offset: 0x0012D500
	private bte(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("DCAMR:R");
	}

	// Token: 0x06003172 RID: 12658 RVA: 0x0012F31C File Offset: 0x0012D51C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DCAMR:R", this.a);
	}

	// Token: 0x06003173 RID: 12659 RVA: 0x0012F338 File Offset: 0x0012D538
	public int a()
	{
		return this.a;
	}

	// Token: 0x06003174 RID: 12660 RVA: 0x0012F340 File Offset: 0x0012D540
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003175 RID: 12661 RVA: 0x0012F34C File Offset: 0x0012D54C
	public bte()
	{
	}

	// Token: 0x06003176 RID: 12662 RVA: 0x0012F358 File Offset: 0x0012D558
	public override int d5(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && this.a < euk.b)
		{
			agn agn = serviceOrThrow.aqu().r().GetClassPropertyValue<agn>("dc_mutagenCompound");
			if (agn == null)
			{
				agn = new agn();
				serviceOrThrow.aqu().r()["dc_mutagenCompound"] = agn;
			}
			agn a_ = serviceOrThrow.aqu().u().d[this.a];
			agn.a(a_);
			serviceOrThrow.aqu().r()["dc_mutagenCompoundText"] = agn.a(serviceOrThrow.aqu().u());
		}
		return 0;
	}

	// Token: 0x04001AB0 RID: 6832
	private int a;
}
