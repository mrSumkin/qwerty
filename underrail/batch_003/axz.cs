using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010EF RID: 4335
[eiz("X9")]
[Serializable]
public sealed class axz : cze, ISerializable
{
	// Token: 0x06005BC8 RID: 23496 RVA: 0x002760F0 File Offset: 0x002742F0
	private axz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("X9:M", typeof(TimeSpan?)) as TimeSpan?);
		this.b = A_0.GetString("X9:P");
	}

	// Token: 0x06005BC9 RID: 23497 RVA: 0x00276130 File Offset: 0x00274330
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("X9:M", this.a);
		info.AddValue("X9:P", this.b);
	}

	// Token: 0x06005BCA RID: 23498 RVA: 0x00276164 File Offset: 0x00274364
	public TimeSpan? a()
	{
		return this.a;
	}

	// Token: 0x06005BCB RID: 23499 RVA: 0x0027616C File Offset: 0x0027436C
	public void a(TimeSpan? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005BCC RID: 23500 RVA: 0x00276178 File Offset: 0x00274378
	public string b()
	{
		return this.b;
	}

	// Token: 0x06005BCD RID: 23501 RVA: 0x00276180 File Offset: 0x00274380
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005BCE RID: 23502 RVA: 0x0027618C File Offset: 0x0027438C
	public axz()
	{
	}

	// Token: 0x06005BCF RID: 23503 RVA: 0x00276198 File Offset: 0x00274398
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!string.IsNullOrEmpty(this.b))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				TimeSpan timeSpan = serviceOrThrow.aqu().p();
				if (this.a != null)
				{
					timeSpan += this.a.Value;
				}
				serviceOrThrow.aqu().r()[this.b] = timeSpan;
			}
		}
	}

	// Token: 0x040024AE RID: 9390
	private new TimeSpan? a;

	// Token: 0x040024AF RID: 9391
	private string b;
}
