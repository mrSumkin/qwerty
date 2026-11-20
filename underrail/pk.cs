using System;
using System.Runtime.Serialization;

// Token: 0x02000161 RID: 353
[eiz("SGUIDFV")]
[Serializable]
public sealed class pk : ccy, ISerializable
{
	// Token: 0x060008DE RID: 2270 RVA: 0x000250A4 File Offset: 0x000232A4
	private pk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (Guid)A_0.GetValue("SGUIDFV:V", typeof(Guid));
			return;
		}
		if (base.GetType() == typeof(dsl))
		{
			this.a = (Guid)A_0.GetValue("_Value", typeof(Guid));
			return;
		}
		this.a = (Guid)A_0.GetValue("SetGuidFieldValue+_Value", typeof(Guid));
	}

	// Token: 0x060008DF RID: 2271 RVA: 0x00025140 File Offset: 0x00023340
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SGUIDFV:V", this.a);
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x00025160 File Offset: 0x00023360
	public Guid a()
	{
		return this.a;
	}

	// Token: 0x060008E1 RID: 2273 RVA: 0x00025168 File Offset: 0x00023368
	public void a(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060008E2 RID: 2274 RVA: 0x00025174 File Offset: 0x00023374
	public override int d5(bq8 A_0, bq8 A_1)
	{
		d8z.a(A_0, A_1, base.b(), this.a);
		return 1;
	}

	// Token: 0x060008E3 RID: 2275 RVA: 0x00025190 File Offset: 0x00023390
	public override string ToString()
	{
		return string.Format("{0} = \"{1}\"", base.b(), this.a);
	}

	// Token: 0x060008E4 RID: 2276 RVA: 0x000251B0 File Offset: 0x000233B0
	public pk()
	{
	}

	// Token: 0x040005C8 RID: 1480
	private Guid a;
}
