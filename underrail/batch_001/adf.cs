using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001064 RID: 4196
[eiz("STBWTGPJ")]
[Serializable]
public sealed class adf : cze
{
	// Token: 0x0600572F RID: 22319 RVA: 0x00261F20 File Offset: 0x00260120
	private adf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("STBWTGPJ:P");
		this.b = (A_0.GetValue("STBWTGPJ:O", typeof(TimeSpan?)) as TimeSpan?);
	}

	// Token: 0x06005730 RID: 22320 RVA: 0x00261F6C File Offset: 0x0026016C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("STBWTGPJ:P", this.a);
		info.AddValue("STBWTGPJ:O", this.b);
	}

	// Token: 0x06005731 RID: 22321 RVA: 0x00261FA0 File Offset: 0x002601A0
	public string b()
	{
		return this.a;
	}

	// Token: 0x06005732 RID: 22322 RVA: 0x00261FA8 File Offset: 0x002601A8
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005733 RID: 22323 RVA: 0x00261FB4 File Offset: 0x002601B4
	public TimeSpan? a()
	{
		return this.b;
	}

	// Token: 0x06005734 RID: 22324 RVA: 0x00261FBC File Offset: 0x002601BC
	public void a(TimeSpan? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005735 RID: 22325 RVA: 0x00261FC8 File Offset: 0x002601C8
	public adf()
	{
	}

	// Token: 0x06005736 RID: 22326 RVA: 0x00261FD4 File Offset: 0x002601D4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				TimeSpan timeSpan = serviceOrThrow.aqu().o();
				if (this.b != null)
				{
					timeSpan += this.b.Value;
				}
				serviceOrThrow.aqu().r()[this.a] = timeSpan;
			}
		}
	}

	// Token: 0x0400234E RID: 9038
	private new string a;

	// Token: 0x0400234F RID: 9039
	private TimeSpan? b;
}
