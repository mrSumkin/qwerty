using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020004C9 RID: 1225
[eiz("CMCHPC")]
[Serializable]
public sealed class bnv : dnh, ISerializable
{
	// Token: 0x06001F5F RID: 8031 RVA: 0x000AD1AC File Offset: 0x000AB3AC
	private bnv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetSingle("CMCHPC:V");
		this.a = A_0.GetBoolean("CMCHPC:I");
		this.c = (A_0.GetValue("CMCHPC:N", typeof(Guid?)) as Guid?);
	}

	// Token: 0x06001F60 RID: 8032 RVA: 0x000AD208 File Offset: 0x000AB408
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CMCHPC:V", this.b);
		info.AddValue("CMCHPC:I", this.a);
		info.AddValue("CMCHPC:N", this.c);
	}

	// Token: 0x06001F61 RID: 8033 RVA: 0x000AD258 File Offset: 0x000AB458
	public bool c()
	{
		return this.a;
	}

	// Token: 0x06001F62 RID: 8034 RVA: 0x000AD260 File Offset: 0x000AB460
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001F63 RID: 8035 RVA: 0x000AD26C File Offset: 0x000AB46C
	public float b()
	{
		return this.b;
	}

	// Token: 0x06001F64 RID: 8036 RVA: 0x000AD274 File Offset: 0x000AB474
	public void a(float A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001F65 RID: 8037 RVA: 0x000AD280 File Offset: 0x000AB480
	public Guid? a()
	{
		return this.c;
	}

	// Token: 0x06001F66 RID: 8038 RVA: 0x000AD288 File Offset: 0x000AB488
	public void a(Guid? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001F67 RID: 8039 RVA: 0x000AD294 File Offset: 0x000AB494
	public bnv()
	{
	}

	// Token: 0x06001F68 RID: 8040 RVA: 0x000AD29C File Offset: 0x000AB49C
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
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
			if (efk != null)
			{
				flag = (efk.Defense.q().zo() / Math.Max(1f, efk.Defense.q().zm()) >= this.b);
			}
		}
		return flag ^ this.a;
	}

	// Token: 0x040013C8 RID: 5064
	private bool a;

	// Token: 0x040013C9 RID: 5065
	private float b;

	// Token: 0x040013CA RID: 5066
	private Guid? c;
}
