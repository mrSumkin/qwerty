using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001048 RID: 4168
[eiz("EDUG0")]
[Serializable]
public sealed class ddu : cze, ISerializable
{
	// Token: 0x06005657 RID: 22103 RVA: 0x0025ECDC File Offset: 0x0025CEDC
	private ddu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetString("EDUG0:RG");
		this.a = A_0.GetBoolean("EDUG0:E");
	}

	// Token: 0x06005658 RID: 22104 RVA: 0x0025ED08 File Offset: 0x0025CF08
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("EDUG0:RG", this.b);
		info.AddValue("EDUG0:E", this.a);
	}

	// Token: 0x06005659 RID: 22105 RVA: 0x0025ED34 File Offset: 0x0025CF34
	public bool a()
	{
		return this.a;
	}

	// Token: 0x0600565A RID: 22106 RVA: 0x0025ED3C File Offset: 0x0025CF3C
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600565B RID: 22107 RVA: 0x0025ED48 File Offset: 0x0025CF48
	public string b()
	{
		return this.b;
	}

	// Token: 0x0600565C RID: 22108 RVA: 0x0025ED50 File Offset: 0x0025CF50
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600565D RID: 22109 RVA: 0x0025ED5C File Offset: 0x0025CF5C
	public ddu()
	{
	}

	// Token: 0x0600565E RID: 22110 RVA: 0x0025ED68 File Offset: 0x0025CF68
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!string.IsNullOrEmpty(this.b))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow != null)
			{
				d60 d = serviceOrThrow.aqw().a();
				if (d != null)
				{
					foreach (b0b b0b in d.ab4(new string[]
					{
						this.b
					}))
					{
						c5x c5x = (c5x)b0b;
						if (c5x != null && c5x.s.b != null)
						{
							c5x.s.b.j = this.a;
						}
					}
				}
			}
		}
	}

	// Token: 0x0400230B RID: 8971
	private new bool a;

	// Token: 0x0400230C RID: 8972
	private string b;
}
