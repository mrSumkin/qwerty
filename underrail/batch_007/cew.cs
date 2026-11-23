using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020004D3 RID: 1235
[eiz("MCIC")]
[Serializable]
public sealed class cew : dnh, ISerializable
{
	// Token: 0x06001FAE RID: 8110 RVA: 0x000ADEF4 File Offset: 0x000AC0F4
	private cew(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("MCIC:MI");
		this.b = A_0.GetBoolean("MCIC:I");
		this.c = (A_0.GetValue("MCIC:N", typeof(Guid?)) as Guid?);
	}

	// Token: 0x06001FAF RID: 8111 RVA: 0x000ADF50 File Offset: 0x000AC150
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MCIC:MI", this.a);
		info.AddValue("MCIC:I", this.b);
		info.AddValue("MCIC:N", this.c);
	}

	// Token: 0x06001FB0 RID: 8112 RVA: 0x000ADFA0 File Offset: 0x000AC1A0
	public int c()
	{
		return this.a;
	}

	// Token: 0x06001FB1 RID: 8113 RVA: 0x000ADFA8 File Offset: 0x000AC1A8
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001FB2 RID: 8114 RVA: 0x000ADFB4 File Offset: 0x000AC1B4
	public bool b()
	{
		return this.b;
	}

	// Token: 0x06001FB3 RID: 8115 RVA: 0x000ADFBC File Offset: 0x000AC1BC
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001FB4 RID: 8116 RVA: 0x000ADFC8 File Offset: 0x000AC1C8
	public Guid? a()
	{
		return this.c;
	}

	// Token: 0x06001FB5 RID: 8117 RVA: 0x000ADFD0 File Offset: 0x000AC1D0
	public void a(Guid? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001FB6 RID: 8118 RVA: 0x000ADFDC File Offset: 0x000AC1DC
	public cew()
	{
	}

	// Token: 0x06001FB7 RID: 8119 RVA: 0x000ADFE4 File Offset: 0x000AC1E4
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		int num = this.a;
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Area != null)
		{
			efk efk = null;
			if (this.c != null)
			{
				EntityAspectReference<amc, amc> entityAspectReference = new EntityAspectReference<amc, amc>(serviceOrThrow.aqu().v().b().Area, this.c.Value);
				if (entityAspectReference.ao() != null)
				{
					efk = entityAspectReference.ao().aa();
				}
			}
			else
			{
				efk = serviceOrThrow.aqu().v();
			}
			if (efk != null && efk.Offense.ay() >= this.a)
			{
				flag = true;
			}
		}
		return flag ^ this.b;
	}

	// Token: 0x040013DE RID: 5086
	private int a;

	// Token: 0x040013DF RID: 5087
	private bool b;

	// Token: 0x040013E0 RID: 5088
	private Guid? c;
}
