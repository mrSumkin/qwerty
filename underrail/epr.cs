using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000FD5 RID: 4053
[eiz("VSSC")]
[Serializable]
public sealed class epr : dnh
{
	// Token: 0x06005362 RID: 21346 RVA: 0x002504B0 File Offset: 0x0024E6B0
	private epr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("VSSC:A");
		this.b = (A_0.GetValue("VSSC:E", typeof(Guid?)) as Guid?);
		this.c = A_0.GetBoolean("VSSC:S");
	}

	// Token: 0x06005363 RID: 21347 RVA: 0x0025050C File Offset: 0x0024E70C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("VSSC:A", this.a);
		info.AddValue("VSSC:E", this.b);
		info.AddValue("VSSC:S", this.c);
	}

	// Token: 0x06005364 RID: 21348 RVA: 0x0025055C File Offset: 0x0024E75C
	public string a()
	{
		return this.a;
	}

	// Token: 0x06005365 RID: 21349 RVA: 0x00250564 File Offset: 0x0024E764
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005366 RID: 21350 RVA: 0x00250570 File Offset: 0x0024E770
	public Guid? b()
	{
		return this.b;
	}

	// Token: 0x06005367 RID: 21351 RVA: 0x00250578 File Offset: 0x0024E778
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005368 RID: 21352 RVA: 0x00250584 File Offset: 0x0024E784
	public bool c()
	{
		return this.c;
	}

	// Token: 0x06005369 RID: 21353 RVA: 0x0025058C File Offset: 0x0024E78C
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600536A RID: 21354 RVA: 0x00250598 File Offset: 0x0024E798
	public epr()
	{
	}

	// Token: 0x0600536B RID: 21355 RVA: 0x002505A0 File Offset: 0x0024E7A0
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		if (!string.IsNullOrEmpty(this.a) && this.b != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqw() != null)
			{
				aud aud = serviceOrThrow.aqw().n(this.a);
				if (aud != null)
				{
					EntityAspectReference<pa, bim> entityAspectReference = new EntityAspectReference<pa, bim>(aud, this.b.Value);
					if (entityAspectReference.ao() != null)
					{
						return entityAspectReference.ao().m() == this.c;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x04002209 RID: 8713
	private string a;

	// Token: 0x0400220A RID: 8714
	private Guid? b;

	// Token: 0x0400220B RID: 8715
	private bool c;
}
