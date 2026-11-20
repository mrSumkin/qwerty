using System;
using System.Runtime.Serialization;

// Token: 0x02000FCC RID: 4044
[eiz("DTRIAC")]
[Serializable]
public sealed class a2w : dnh, ISerializable
{
	// Token: 0x06005327 RID: 21287 RVA: 0x0024FC9C File Offset: 0x0024DE9C
	private a2w(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("DTRIAC:R");
		this.b = A_0.GetBoolean("DTRIAC:I");
	}

	// Token: 0x06005328 RID: 21288 RVA: 0x0024FCC8 File Offset: 0x0024DEC8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DTRIAC:R", this.a);
		info.AddValue("DTRIAC:I", this.b);
	}

	// Token: 0x06005329 RID: 21289 RVA: 0x0024FCF4 File Offset: 0x0024DEF4
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600532A RID: 21290 RVA: 0x0024FCFC File Offset: 0x0024DEFC
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600532B RID: 21291 RVA: 0x0024FD08 File Offset: 0x0024DF08
	public bool b()
	{
		return this.b;
	}

	// Token: 0x0600532C RID: 21292 RVA: 0x0024FD10 File Offset: 0x0024DF10
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600532D RID: 21293 RVA: 0x0024FD1C File Offset: 0x0024DF1C
	public a2w()
	{
	}

	// Token: 0x0600532E RID: 21294 RVA: 0x0024FD28 File Offset: 0x0024DF28
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		if (!string.IsNullOrEmpty(this.a))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				eh6 eh = (A_0.get_Item(c49.b) as c5x).GetAspect<bim>() as eh6;
				if (eh != null && eh.e() != this.a)
				{
					string name = "riftAttunement_" + this.a;
					flag = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(name, new bool?(false)).Value;
				}
			}
		}
		return flag ^ this.b;
	}

	// Token: 0x040021FE RID: 8702
	private string a;

	// Token: 0x040021FF RID: 8703
	private bool b;
}
