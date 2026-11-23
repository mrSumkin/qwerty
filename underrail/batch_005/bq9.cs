using System;
using System.Runtime.Serialization;

// Token: 0x02000F62 RID: 3938
[eiz("XPBLSISZAF")]
[Serializable]
public sealed class bq9 : dnh, ISerializable
{
	// Token: 0x06004FCF RID: 20431 RVA: 0x0023DA78 File Offset: 0x0023BC78
	private bq9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("XPBLSISZAF:I");
	}

	// Token: 0x06004FD0 RID: 20432 RVA: 0x0023DA94 File Offset: 0x0023BC94
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPBLSISZAF:I", this.a);
	}

	// Token: 0x06004FD1 RID: 20433 RVA: 0x0023DAB0 File Offset: 0x0023BCB0
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06004FD2 RID: 20434 RVA: 0x0023DAB8 File Offset: 0x0023BCB8
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004FD3 RID: 20435 RVA: 0x0023DAC4 File Offset: 0x0023BCC4
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			aud aud = serviceOrThrow.aqu().v().b().Area;
			if (aud != null)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.s.b != null && c5x.GetAspect<bdf>() is atg)
					{
						return !this.a;
					}
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x06004FD4 RID: 20436 RVA: 0x0023DB8C File Offset: 0x0023BD8C
	public bq9()
	{
	}

	// Token: 0x04002097 RID: 8343
	private bool a;
}
