using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000FD4 RID: 4052
[eiz("LSC")]
[Serializable]
public sealed class akn : dnh
{
	// Token: 0x06005358 RID: 21336 RVA: 0x00250338 File Offset: 0x0024E538
	private akn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("LSC:A");
		this.b = (A_0.GetValue("LSC:E", typeof(Guid?)) as Guid?);
		this.c = A_0.GetBoolean("LSC:S");
	}

	// Token: 0x06005359 RID: 21337 RVA: 0x00250394 File Offset: 0x0024E594
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LSC:A", this.a);
		info.AddValue("LSC:E", this.b);
		info.AddValue("LSC:S", this.c);
	}

	// Token: 0x0600535A RID: 21338 RVA: 0x002503E4 File Offset: 0x0024E5E4
	public string b()
	{
		return this.a;
	}

	// Token: 0x0600535B RID: 21339 RVA: 0x002503EC File Offset: 0x0024E5EC
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600535C RID: 21340 RVA: 0x002503F8 File Offset: 0x0024E5F8
	public Guid? a()
	{
		return this.b;
	}

	// Token: 0x0600535D RID: 21341 RVA: 0x00250400 File Offset: 0x0024E600
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600535E RID: 21342 RVA: 0x0025040C File Offset: 0x0024E60C
	public bool c()
	{
		return this.c;
	}

	// Token: 0x0600535F RID: 21343 RVA: 0x00250414 File Offset: 0x0024E614
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005360 RID: 21344 RVA: 0x00250420 File Offset: 0x0024E620
	public akn()
	{
	}

	// Token: 0x06005361 RID: 21345 RVA: 0x00250428 File Offset: 0x0024E628
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
					EntityAspectReference<d2b, d2b> entityAspectReference = new EntityAspectReference<d2b, d2b>(aud, this.b.Value);
					if (entityAspectReference.ao() != null)
					{
						return entityAspectReference.ao().n() == this.c;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x04002206 RID: 8710
	private string a;

	// Token: 0x04002207 RID: 8711
	private Guid? b;

	// Token: 0x04002208 RID: 8712
	private bool c;
}
